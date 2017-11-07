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
        static IAmazonPricing client = new AmazonPricingClient();
        public void PricingDescribeServices()
        {
            #region to-retrieve-service-metadata

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
            #region to-retreive-attribute-values

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

        public void PricingGetProducts()
        {
            #region to-retrieve-available products

            var response = client.GetProducts(new GetProductsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Field = "ServiceCode",
                        Type = "TERM_MATCH",
                        Value = "AmazonEC2"
                    },
                    new Filter {
                        Field = "volumeType",
                        Type = "TERM_MATCH",
                        Value = "Provisioned IOPS"
                    }
                },
                FormatVersion = "aws_v1",
                MaxResults = 1
            });

            string formatVersion = response.FormatVersion;
            string nextToken = response.NextToken;
            List<string> priceList = response.PriceList;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}