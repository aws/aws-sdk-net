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
        public void MarketplaceDeploymentGetDeploymentConfiguration()
        {
            #region GetDeploymentConfiguration-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfiguration(new GetDeploymentConfigurationRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });

            DeploymentConfigurationDetail configuration = response.Configuration;

            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfiguration()
        {
            #region GetDeploymentConfiguration-2

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfiguration(new GetDeploymentConfigurationRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });


            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfiguration()
        {
            #region GetDeploymentConfiguration-3

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfiguration(new GetDeploymentConfigurationRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });


            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfigurationJob()
        {
            #region GetDeploymentConfigurationJob-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfigurationJob(new GetDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                JobId = "1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d",
                ProductId = "product-1234"
            });

            DeploymentConfigurationDetail configuration = response.Configuration;
            string configurationArn = response.ConfigurationArn;
            DateTime? createdAt = response.CreatedAt;
            DateTime? endedAt = response.EndedAt;
            string jobId = response.JobId;
            DeploymentConfigurationJobStatus status = response.Status;

            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfigurationJob()
        {
            #region GetDeploymentConfigurationJob-2

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfigurationJob(new GetDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                JobId = "9f8e7d6c5b4a3f2e1d0c9b8a7f6e5d4c",
                ProductId = "product-1234"
            });

            DeploymentConfigurationDetail configuration = response.Configuration;
            DateTime? createdAt = response.CreatedAt;
            DateTime? endedAt = response.EndedAt;
            DeploymentConfigurationJobErrorCode errorCode = response.ErrorCode;
            string jobId = response.JobId;
            string message = response.Message;
            DeploymentConfigurationJobStatus status = response.Status;

            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfigurationJob()
        {
            #region GetDeploymentConfigurationJob-3

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfigurationJob(new GetDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                JobId = "abcd1234abcd1234abcd1234abcd1234",
                ProductId = "product-1234"
            });


            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfigurationJob()
        {
            #region GetDeploymentConfigurationJob-4

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfigurationJob(new GetDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                JobId = "1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d",
                ProductId = "product-1234"
            });


            #endregion
        }

        public void MarketplaceDeploymentGetDeploymentConfigurationJob()
        {
            #region GetDeploymentConfigurationJob-5

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.GetDeploymentConfigurationJob(new GetDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                JobId = "abcd1234abcd1234abcd1234abcd1234",
                ProductId = "product-1234"
            });


            #endregion
        }

        public void MarketplaceDeploymentListDeploymentConfigurationJobs()
        {
            #region ListDeploymentConfigurationJobs-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.ListDeploymentConfigurationJobs(new ListDeploymentConfigurationJobsRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                MaxResults = 20,
                ProductId = "product-1234"
            });

            List<DeploymentConfigurationJobSummary> jobs = response.Jobs;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MarketplaceDeploymentListDeploymentConfigurationJobs()
        {
            #region ListDeploymentConfigurationJobs-2

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.ListDeploymentConfigurationJobs(new ListDeploymentConfigurationJobsRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });

            List<DeploymentConfigurationJobSummary> jobs = response.Jobs;

            #endregion
        }

        public void MarketplaceDeploymentListDeploymentConfigurationJobs()
        {
            #region ListDeploymentConfigurationJobs-3

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.ListDeploymentConfigurationJobs(new ListDeploymentConfigurationJobsRequest
            {
                Catalog = "AWSMarketplace",
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });


            #endregion
        }

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

        public void MarketplaceDeploymentStartDeploymentConfigurationJob()
        {
            #region StartDeploymentConfigurationJob-1

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.StartDeploymentConfigurationJob(new StartDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                ClientToken = "some-unique-uuid-between-32-and-64-characters",
                Configuration = new DeploymentConfigurationDetail { DataAsAService = new DataAsAServiceConfigurationDetail { FulfillmentUrl = "https://example.com/daas/register" } },
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });

            DeploymentConfigurationDetail configuration = response.Configuration;
            DateTime? createdAt = response.CreatedAt;
            string jobId = response.JobId;
            DeploymentConfigurationJobStatus status = response.Status;

            #endregion
        }

        public void MarketplaceDeploymentStartDeploymentConfigurationJob()
        {
            #region StartDeploymentConfigurationJob-2

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.StartDeploymentConfigurationJob(new StartDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                Configuration = new DeploymentConfigurationDetail { DataAsAService = new DataAsAServiceConfigurationDetail { FulfillmentUrl = "https://example.com/daas/register" } },
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-does-not-exist"
            });


            #endregion
        }

        public void MarketplaceDeploymentStartDeploymentConfigurationJob()
        {
            #region StartDeploymentConfigurationJob-3

            var client = new AmazonMarketplaceDeploymentClient();
            var response = client.StartDeploymentConfigurationJob(new StartDeploymentConfigurationJobRequest
            {
                Catalog = "AWSMarketplace",
                Configuration = new DeploymentConfigurationDetail { DataAsAService = new DataAsAServiceConfigurationDetail { FulfillmentUrl = "https://example.com/daas/register" } },
                DeliveryOptionType = "data-as-a-service",
                ProductId = "product-1234"
            });


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
