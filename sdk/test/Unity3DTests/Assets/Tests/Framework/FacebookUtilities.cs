using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using ThirdParty.Json.LitJson;

namespace AWSSDK.Tests.Framework
{
    public static class FacebookUtilities
    {
        public static void DeleteFacebookUser(FacebookCreateUserResponse user)
        {
            var facebookDeleteUserUrl = string.Format("https://graph.facebook.com/{0}?method=delete&access_token={1}",
            user.ID, user.AccessToken);
            var deleteUserRequest = new UnityWwwRequest(new Uri(facebookDeleteUserUrl));
            deleteUserRequest.GetResponse();
        }

        public static FacebookCreateUserResponse CreateFacebookUser(string facebookAppId, string facebookAppSecret)
        {
            var accessToken = GetFacebookAccessToken(facebookAppId, facebookAppSecret);

            FacebookCreateUserResponse responseObject;
            // Create an user for the app. This returns the OAuth token.
            // https://developers.facebook.com/docs/test_users/
            var facebookCreateNewUserUrl = string.Format(
                @"https://graph.facebook.com/{0}/accounts/test-users?
                installed=true&name=Foo%20Bar&locale=en_US&permissions=read_stream&method=post&{1}",
                facebookAppId,
                accessToken);

            var createUserRequest = new UnityWwwRequest(new Uri(facebookCreateNewUserUrl));
            var createUserResponse = createUserRequest.GetResponse();
            using (var streamReader = new StreamReader(createUserResponse.ResponseBody.OpenResponse()))
            {
                var json = ThirdParty.Json.LitJson.JsonMapper.ToObject(streamReader);
                responseObject = new FacebookCreateUserResponse(json);
            }

            return responseObject;
        }

        private static string GetFacebookAccessToken(string facebookAppId, string facebookAppSecret)
        {
            // https://developers.facebook.com/docs/opengraph/howtos/publishing-with-app-token/
            var facebookAppAccessTokenUri = string.Format(
                "https://graph.facebook.com/oauth/access_token?client_id={0}&client_secret={1}&grant_type=client_credentials",
                facebookAppId,
                facebookAppSecret);

            // Get App Access Token
            string accessToken;
            var accessTokenRequest = new UnityWwwRequest(new Uri(facebookAppAccessTokenUri));
            var accessTokenResponse = accessTokenRequest.GetResponse();

            using (var streamReader = new StreamReader(accessTokenResponse.ResponseBody.OpenResponse(), Encoding.GetEncoding("UTF-8")))
            {
                accessToken = streamReader.ReadToEnd();
            }

            return accessToken;
        }

        public class FacebookCreateUserResponse
        {
            public string ID { get; private set; }

            public string Email { get; private set; }

            public string AccessToken { get; private set; }

            public string LoginUrl { get; private set; }

            public string Password { get; private set; }

            public FacebookCreateUserResponse(JsonData json)
            {
                ID = GetValue(json, "id");
                Email = GetValue(json, "email");
                AccessToken = GetValue(json, "access_token");
                LoginUrl = GetValue(json, "login_url");
                Password = GetValue(json, "password");
            }
            private static string GetValue(JsonData json, string name)
            {
                var value = json[name];
                return (value == null) ? null : value.ToString();
            }
        }
    }
}
