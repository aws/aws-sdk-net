using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Pricing;
using Amazon.Pricing.Model;

namespace AWSSDKDocSamples.Amazon.Pricing.Generated
{
    class PricingSamples : ISample
    {
        public void PricingDescribeServices()
        {
            #region example-1

            var client = new AmazonPricingClient();
            var response = client.DescribeServices(new DescribeServicesRequest 
            {
                FormatVersion = "aws_v1",
                MaxResults = 1,
                ServiceCode = "AmazonEC2"
            });

            string formatVersion = response.FormatVersion;
            string nextToken = response.NextToken;
            List<Service> services = response.Services;

            #endregion
        }

        public void PricingGetAttributeValues()
        {
            #region example-1

            var client = new AmazonPricingClient();
            var response = client.GetAttributeValues(new GetAttributeValuesRequest 
            {
                AttributeName = "volumeType",
                MaxResults = 2,
                ServiceCode = "AmazonEC2"
            });

            List<AttributeValue> attributeValues = response.AttributeValues;
            string nextToken = response.NextToken;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}