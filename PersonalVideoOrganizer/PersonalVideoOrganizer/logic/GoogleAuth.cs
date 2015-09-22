using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalVideoOrganizer.logic {
	class GoogleAuth {
		private static UserCredential credentials = null;
		private static string username = null;

		public static UserCredential getCredentials(string forUser) {
			if (forUser == null) {
				throw new ArgumentNullException();
			}
			if (forUser.Trim().Length == 0) {
				throw new ArgumentException();
			}
			if (forUser.Equals(username)) {
				return credentials;
			}
			if (credentials == null) {
				username = forUser;
			}
			
			ClientSecrets secrets;

			using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "client_secret.json"), FileMode.Open, FileAccess.Read)) {
				secrets = GoogleClientSecrets.Load(stream).Secrets;
			}

			FileDataStore store = new FileDataStore("PersonalVideoOrganizer");

			credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(secrets, new[] { YouTubeService.Scope.YoutubeReadonly }, username, CancellationToken.None, store).Result;
			
            return credentials;
		}
	}
}
