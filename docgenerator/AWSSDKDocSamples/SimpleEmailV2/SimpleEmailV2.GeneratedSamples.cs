using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

namespace AWSSDKDocSamples.Amazon.SimpleEmailV2.Generated
{
    class SimpleEmailServiceV2Samples : ISample
    {
        public void SimpleEmailServiceV2PutDedicatedIpPoolScalingAttributes()
        {
            #region put-dedicated-ip-pool-scaling-attributes-example-1683639172

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.PutDedicatedIpPoolScalingAttributes(new PutDedicatedIpPoolScalingAttributesRequest 
            {
                PoolName = "sample-ses-pool",
                ScalingMode = "MANAGED"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}