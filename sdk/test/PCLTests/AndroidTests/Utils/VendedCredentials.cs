using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Amazon.Runtime;
using ThirdParty.Json.LitJson;
using System.Net;
using System.IO;
using Amazon.SecurityToken.Model;
using Android.Content.Res;

namespace AndroidTests.Utils
{
    public class VendedCredentials : AWSCredentials
    {
        public const string CredentialsAsset = "credentials.json";
        private string json;

        public VendedCredentials(AssetManager am)
            : this(am.Open(CredentialsAsset))
        { }
        public VendedCredentials(Stream assetsStream)
        {
            using(var reader = new StreamReader(assetsStream))
            {
                json = reader.ReadToEnd();
            }
        }

        public override ImmutableCredentials GetCredentials()
        {
            var creds = ThirdParty.Json.LitJson.JsonMapper.ToObject<Credentials>(json);
            var ic = creds.GetCredentials();
            return ic;
        }
    }
}