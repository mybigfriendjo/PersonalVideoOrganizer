using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using PersonalVideoOrganizer.data;
using PersonalVideoOrganizer.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalVideoOrganizer {
	public partial class frmMain : Form {
		private List<YTVid> videos = new List<YTVid>();

		public frmMain() {
			InitializeComponent();
			listVideos.Columns.Add("Video", 400, HorizontalAlignment.Left);
			listVideos.Columns.Add("Title", 100, HorizontalAlignment.Left);
			listVideos.Columns.Add("Uploaded at", 100, HorizontalAlignment.Left);

		}

		private void buttonLoad_Click(object sender, EventArgs e) {
			string username = textUser.Text.Trim();

			if (username.Length == 0) {
				MessageBox.Show("Please enter a username!", "Username missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DateTime notOlderThan = dateFrom.Value;

			var youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				HttpClientInitializer = GoogleAuth.getCredentials(username),
				ApplicationName = "PersonalVideoOrganizer"
			});

			videos.Clear();

			var nextSubPageToken = "";
			while (nextSubPageToken != null) {
				var subListRequest = youtubeService.Subscriptions.List("snippet");
				subListRequest.Mine = true;
				subListRequest.Order = SubscriptionsResource.ListRequest.OrderEnum.Alphabetical;
				subListRequest.MaxResults = 50;
				subListRequest.PageToken = nextSubPageToken;

				Debug.WriteLine("Loading subs of '" + username + "'");
				var subListResponse = subListRequest.Execute();

				foreach (var subscription in subListResponse.Items) {
					var channelID = subscription.Snippet.ResourceId.ChannelId;

					var channelInfoRequest = youtubeService.Channels.List("contentDetails");
					channelInfoRequest.Id = channelID;

					Debug.WriteLine("Getting channel Info of '" + subscription.Snippet.Title + "'");
					var channelInfoResponse = channelInfoRequest.Execute();

					var channelUploadedPlaylistID = channelInfoResponse.Items[0].ContentDetails.RelatedPlaylists.Uploads;

					var nextVidPageToken = "";
					while (nextVidPageToken != null) {
						var vidListRequest = youtubeService.PlaylistItems.List("snippet");
						vidListRequest.PlaylistId = channelUploadedPlaylistID;
						vidListRequest.MaxResults = 50;
						vidListRequest.PageToken = nextVidPageToken;

						Debug.WriteLine("Getting uploaded Videos");
						var vidListResponse = vidListRequest.Execute();

						var timeLimitReached = false;
						foreach (var video in vidListResponse.Items) {
							if (video.Snippet.PublishedAt < notOlderThan) {
								Debug.WriteLine("Video too old... going to next sub...");
								timeLimitReached = true;
								break;
							}
							YTVid ytvid = new YTVid();
							ytvid.Title = video.Snippet.Title;
							ytvid.Description = video.Snippet.Description;
							ytvid.PublishedAt = DateTime.Parse(video.Snippet.PublishedAtRaw, null, DateTimeStyles.RoundtripKind);
							ytvid.Publisher = subscription.Snippet.Title;
							ytvid.Thumbnails = video.Snippet.Thumbnails;
							ytvid.VideoID = video.Snippet.ResourceId.VideoId;

							videos.Add(ytvid);
						}
						if (timeLimitReached) {
							break;
						}
						nextVidPageToken = vidListResponse.NextPageToken;
					}
				}
				nextSubPageToken = subListResponse.NextPageToken;
			}

			updateVideoList();
		}

		private void updateVideoList() {
			ImageList imgList = new ImageList();
			// 320, 180
			imgList.ImageSize = new Size(256, 180);
			imgList.ColorDepth = ColorDepth.Depth24Bit;
			listVideos.LargeImageList = imgList;
			listVideos.SmallImageList = imgList;

			int count = 0;

			listVideos.Items.Clear();

			videos = videos.OrderBy(i => i.PublishedAt).ToList();

			foreach (var video in videos) {
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(video.Thumbnails.Medium.Url);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

				imgList.Images.Add(Image.FromStream(httpWebResponse.GetResponseStream()));

				ListViewItem item = new ListViewItem();
				item.ImageIndex = count++;
				item.Text = video.Title;

				ListViewItem.ListViewSubItem subItemPublisher = new ListViewItem.ListViewSubItem();
				subItemPublisher.Text = video.Publisher;
				ListViewItem.ListViewSubItem subItemDate = new ListViewItem.ListViewSubItem();
				subItemDate.Text = video.PublishedAt.ToString("dd.MM.yyyy HH:mm:ss");

				item.SubItems.Add(subItemPublisher);
				item.SubItems.Add(subItemDate);

				item.Tag = video;

				listVideos.Items.Add(item);
			}
		}

		private void buttonOpen_Click(object sender, EventArgs e) {
			if (listVideos.SelectedItems.Count == 0) {
				return;
			}

			YTVid video = (YTVid)listVideos.SelectedItems[0].Tag;

			Process.Start("https://www.youtube.com/watch?v=" + video.VideoID);
		}
	}
}
