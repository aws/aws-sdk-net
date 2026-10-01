using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

namespace AWSSDKDocSamples.Amazon.SimpleEmailV2.Generated
{
    class SimpleEmailServiceV2Samples : ISample
    {
        public void SimpleEmailServiceV2CancelExportJob()
        {
            #region CancelExportJob-1

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.CancelExportJob(new CancelExportJobRequest
            {
                JobId = "ef28cf62-9d8e-4b60-9283-b09816c99a99"
            });


            #endregion
        }

        public void SimpleEmailServiceV2GetEmailAddressInsights()
        {
            #region GetEmailAddressInsights-1

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.GetEmailAddressInsights(new GetEmailAddressInsightsRequest
            {
                EmailAddress = "hello@example.com"
            });

            MailboxValidation mailboxValidation = response.MailboxValidation;

            #endregion
        }

        public void SimpleEmailServiceV2PutConfigurationSetArchivingOptions()
        {
            #region PutConfigurationSetArchivingOptions-1

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.PutConfigurationSetArchivingOptions(new PutConfigurationSetArchivingOptionsRequest
            {
                ArchiveArn = "arn:aws:ses:us-west-2:123456789012:mailmanager-archive/a-abcdefghijklmnopqrstuvwxyz",
                ConfigurationSetName = "sample-configuration-name"
            });


            #endregion
        }

        public void SimpleEmailServiceV2PutDedicatedIpPoolScalingAttributes()
        {
            #region PutDedicatedIpPoolScalingAttributes-1

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.PutDedicatedIpPoolScalingAttributes(new PutDedicatedIpPoolScalingAttributesRequest
            {
                PoolName = "sample-ses-pool",
                ScalingMode = "MANAGED"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
