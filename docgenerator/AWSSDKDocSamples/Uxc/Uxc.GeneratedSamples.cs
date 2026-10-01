using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Uxc;
using Amazon.Uxc.Model;

namespace AWSSDKDocSamples.Amazon.Uxc.Generated
{
    class UxcSamples : ISample
    {
        public void UxcGetAccountCustomizations()
        {
            #region GetAccountCustomizations-1

            var client = new AmazonUxcClient();
            var response = client.GetAccountCustomizations(new GetAccountCustomizationsRequest
            {
            });

            AccountColor accountColor = response.AccountColor;
            List<string> visibleRegions = response.VisibleRegions;
            List<string> visibleServices = response.VisibleServices;

            #endregion
        }

        public void UxcListServices()
        {
            #region ListServices-1

            var client = new AmazonUxcClient();
            var response = client.ListServices(new ListServicesRequest
            {
            });

            string nextToken = response.NextToken;
            List<string> services = response.Services;

            #endregion
        }

        public void UxcUpdateAccountCustomizations()
        {
            #region UpdateAccountCustomizations-1

            var client = new AmazonUxcClient();
            var response = client.UpdateAccountCustomizations(new UpdateAccountCustomizationsRequest
            {
                AccountColor = "green",
                VisibleServices = new List<string> {
                    "s3",
                    "ec2",
                    "lambda"
                }
            });

            AccountColor accountColor = response.AccountColor;
            List<string> visibleRegions = response.VisibleRegions;
            List<string> visibleServices = response.VisibleServices;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
