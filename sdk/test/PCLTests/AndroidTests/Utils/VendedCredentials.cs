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

namespace AndroidTests.Utils
{
    public class VendedCredentials : AWSCredentials
    {
        JsonData json;
        public VendedCredentials(Stream assetsStream)
        {
            using(var reader = new StreamReader(assetsStream))
            {
                json = ThirdParty.Json.LitJson.JsonMapper.ToObject(reader);
            }
        }

        public override ImmutableCredentials GetCredentials()
        {
            //var json = GetJson();
            var accessKey = json["AccessKey"].ToString();
            var secretkey = json["SecretKey"].ToString();
            var token = json["Token"].ToString();

            var creds = new ImmutableCredentials(accessKey, secretkey, token);
            return creds;
        }
    }
}