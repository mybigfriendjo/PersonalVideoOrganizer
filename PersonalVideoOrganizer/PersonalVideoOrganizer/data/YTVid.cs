using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3.Data;

namespace PersonalVideoOrganizer.data {
	class YTVid {
		public string Description {
			get;
			internal set;
		}
		public DateTime PublishedAt {
			get;
			internal set;
		}
		public string Publisher {
			get;
			internal set;
		}
		public ThumbnailDetails Thumbnails {
			get;
			internal set;
		}
		public string Title {
			get;
			internal set;
		}
		public string VideoID {
			get;
			internal set;
		}
	}
}
