using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using ThirdParty.Json.LitJson;
using System.Net;
using System.IO;
using Amazon.SecurityToken.Model;


namespace CommonTests
{
    public class VendedCredentials : AWSCredentials
    {
        private string json;
        
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