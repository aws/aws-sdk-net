using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SecurityToken;
using AWSSDKDocSamples.Util;
using Amazon.SecurityToken.Model;

namespace AWSSDKDocSamples.SecurityToken
{
    public class StsSamplesBase : ISample
    {
        private AmazonSecurityTokenServiceClient client = null;
        public AmazonSecurityTokenServiceClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new AmazonSecurityTokenServiceClient();
                }
                return client;
            }
        }

        #region ISample Members

        public virtual void Run()
        {
        }

        #endregion
    }

    public class BasicSamples : StsSamplesBase
    {
        public override void Run()
        {
            BasicStsSample();
        }

        private void BasicStsSample()
        {
            {
                #region Sample 1

                GetSessionTokenResponse response = Client.GetSessionToken();
                Credentials credentials = response.Credentials;
                Console.WriteLine("Access Key = {0}", credentials.AccessKeyId);
                Console.WriteLine("Secret Key = {0}", credentials.SecretAccessKey);
                Console.WriteLine("Session Token = {0}", credentials.SessionToken);
                Console.WriteLine("Expiration = {0}", credentials.Expiration);

                #endregion
            }
            {
                #region Sample 2

                GetSessionTokenResponse response = Client.GetSessionToken(new GetSessionTokenRequest
                {
                    DurationSeconds = (int)TimeSpan.FromHours(8).TotalSeconds
                });
                Credentials credentials = response.Credentials;
                Console.WriteLine("Access Key = {0}", credentials.AccessKeyId);
                Console.WriteLine("Secret Key = {0}", credentials.SecretAccessKey);
                Console.WriteLine("Session Token = {0}", credentials.SessionToken);
                Console.WriteLine("Expiration = {0}", credentials.Expiration);

                #endregion
            }
        }
    }
}
