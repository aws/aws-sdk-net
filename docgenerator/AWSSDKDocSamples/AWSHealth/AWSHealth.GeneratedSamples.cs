using System;
using System.Collections.Generic;
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
            #region describeservicelifecycle-1727539200000

            var client = new AmazonAWSHealthClient();
            var response = client.DescribeServiceLifecycle(new DescribeServiceLifecycleRequest 
            {
                MaxResults = 5
            });

            string nextToken = response.NextToken;
            List<ServiceLifecycle> serviceLifecycles = response.ServiceLifecycles;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}