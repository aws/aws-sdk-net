using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AWSHealth;
using Amazon.AWSHealth.Model;

namespace AWSSDKDocSamples.Amazon.AWSHealth.Generated
{
    class AWSHealthSamples : ISample
    {
        public void AWSHealthDescribeServiceLifecycle()
        {
            #region DescribeServiceLifecycle-1

            var client = new AmazonAWSHealthClient();
            var response = client.DescribeServiceLifecycle(new DescribeServiceLifecycleRequest
            {
                MaxResults = 5
            });

            string nextToken = response.NextToken;
            List<ServiceLifecycle> serviceLifecycles = response.ServiceLifecycles;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
