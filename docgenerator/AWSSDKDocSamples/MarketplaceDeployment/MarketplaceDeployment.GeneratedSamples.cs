using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MarketplaceDeployment;
using Amazon.MarketplaceDeployment.Model;

namespace AWSSDKDocSamples.Amazon.MarketplaceDeployment.Generated
{
    class MarketplaceDeploymentSamples : ISample
    {
        public void MarketplaceDeploymentListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:aws-marketplace:us-east-1:123456789012:DeploymentParameter:catalogs/AWSMarketplace/products/product-1234/dp-uniqueidentifier"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MarketplaceDeploymentPutDeploymentParameter()
        {
            #region PutDeploymentParameter-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.PutDeploymentParameter(new PutDeploymentParameterRequest
            {
                AgreementId = "agmt-1234",
                Catalog = "AWSMarketplace",
                ClientToken = "some-unique-uuid-between-32-and-64-characters",
                DeploymentParameter = new DeploymentParameterInput {
                    Name = "ExampleDeploymentParameterName",
                    SecretString = "{\"apiKey\": \"helloWorldApiKey\", \"entityId\": \"fooBarEntityId\"}"
                },
                ProductId = "product-1234"
            });

            string agreementId = response.AgreementId;
            string deploymentParameterId = response.DeploymentParameterId;
            string resourceArn = response.ResourceArn;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MarketplaceDeploymentPutDeploymentParameter()
        {
            #region PutDeploymentParameter-2

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.PutDeploymentParameter(new PutDeploymentParameterRequest
            {
                AgreementId = "agmt-1234",
                Catalog = "AWSMarketplace",
                ClientToken = "some-unique-uuid-between-32-and-64-characters",
                DeploymentParameter = new DeploymentParameterInput {
                    Name = "ExampleSimpleDeploymentParameterName",
                    SecretString = "MySimpleValue"
                },
                ExpirationDate = new DateTime(2099, 11, 18, 8, 52, 46, 397, DateTimeKind.Utc),
                ProductId = "product-1234",
                Tags = new Dictionary<string, string> {
                    { "FooKey", "BarValue" },
                    { "HelloKey", "WorldValue" }
                }
            });

            string agreementId = response.AgreementId;
            string deploymentParameterId = response.DeploymentParameterId;
            string resourceArn = response.ResourceArn;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MarketplaceDeploymentTagResource()
        {
            #region TagResource-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "arn:aws:aws-marketplace:us-east-1:123456789012:DeploymentParameter:catalogs/AWSMarketplace/products/product-1234/dp-uniqueidentifier",
                Tags = new Dictionary<string, string> {
                    { "FooKey", "BarValue" },
                    { "HelloKey", "WorldValue" }
                }
            });


            #endregion
        }

        public void MarketplaceDeploymentUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "arn:aws:aws-marketplace:us-east-1:123456789012:DeploymentParameter:catalogs/AWSMarketplace/products/product-1234/dp-uniqueidentifier",
                TagKeys = new List<string> {
                    "FooKey",
                    "HelloKey"
                }
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
