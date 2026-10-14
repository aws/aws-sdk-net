using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ARCRegionswitch;
using Amazon.ARCRegionswitch.Model;

namespace AWSSDKDocSamples.Amazon.ARCRegionswitch.Generated
{
    class ARCRegionswitchSamples : ISample
    {
        public void ARCRegionswitchListRoute53HealthChecksInRegion()
        {
            #region ListRoute53HealthChecksInRegion-1

            var client = new AmazonARCRegionswitchClient();
            var response = client.ListRoute53HealthChecksInRegion(new ListRoute53HealthChecksInRegionRequest
            {
                Arn = "arn:aws:arc-region-switch::123456789012:plan/example:000000",
                HostedZoneId = "Z0123456789ABCDEFGHI",
                MaxResults = 10,
                NextToken = "eyJNYXJrZXIiOiBudWxsLCAiYm90b190cnVuY2F0ZV9hbW91bnQiOiAxfQ",
                RecordName = "my.record.name"
            });

            List<Route53HealthCheck> healthChecks = response.HealthChecks;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
