using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;

namespace AWSSDKDocSamples.Amazon.CloudFront.Generated
{
    class CloudFrontSamples : ISample
    {
        public void CloudFrontCreateFunction()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.CreateFunction(new CreateFunctionRequest 
            {
                FunctionCode = new MemoryStream(function-code.js),
                FunctionConfig = new FunctionConfig {
                    Comment = "my-function-comment",
                    KeyValueStoreAssociations = new KeyValueStoreAssociations {
                        Items = new List<KeyValueStoreAssociation> {
                            new KeyValueStoreAssociation { KeyValueStoreARN = "arn:aws:cloudfront::123456789012:key-value-store/54947df8-0e9e-4471-a2f9-9af509fb5889" }
                        },
                        Quantity = 1
                    },
                    Runtime = "cloudfront-js-2.0"
                },
                Name = "my-function-name"
            });

            string eTag = response.ETag;
            FunctionSummary functionSummary = response.FunctionSummary;
            string location = response.Location;

            #endregion
        }

        public void CloudFrontCreateKeyValueStore()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.CreateKeyValueStore(new CreateKeyValueStoreRequest 
            {
                Comment = "my-key-valuestore-comment",
                ImportSource = new ImportSource {
                    SourceARN = "arn:aws:s3:::amzn-s3-demo-bucket/validJSON.json",
                    SourceType = "S3"
                },
                Name = "my-keyvaluestore-name"
            });

            string eTag = response.ETag;
            KeyValueStore keyValueStore = response.KeyValueStore;
            string location = response.Location;

            #endregion
        }

        public void CloudFrontCreateVpcOrigin()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.CreateVpcOrigin(new CreateVpcOriginRequest 
            {
                VpcOriginEndpointConfig = new VpcOriginEndpointConfig {
                    Arn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-alb-us-west-2/e6aa5c7d26415c6d",
                    HTTPPort = 80,
                    HTTPSPort = 443,
                    Name = "my-vpcorigin-name",
                    OriginProtocolPolicy = "match-viewer",
                    OriginSslProtocols = new OriginSslProtocols {
                        Items = new List<string> {
                            "TLSv1.1",
                            "TLSv1.2"
                        },
                        Quantity = 2
                    }
                }
            });

            string eTag = response.ETag;
            string location = response.Location;
            VpcOrigin vpcOrigin = response.VpcOrigin;

            #endregion
        }

        public void CloudFrontDeleteKeyValueStore()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.DeleteKeyValueStore(new DeleteKeyValueStoreRequest 
            {
                IfMatch = "ETVPDKIKX0DER",
                Name = "my-keyvaluestore-name"
            });


            #endregion
        }

        public void CloudFrontDeleteVpcOrigin()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.DeleteVpcOrigin(new DeleteVpcOriginRequest 
            {
                Id = "vo_BQwjxxQxjCaBcQLzJUFkDM",
                IfMatch = "E1F83G8C2ARO7P"
            });

            string eTag = response.ETag;
            VpcOrigin vpcOrigin = response.VpcOrigin;

            #endregion
        }

        public void CloudFrontDescribeKeyValueStore()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.DescribeKeyValueStore(new DescribeKeyValueStoreRequest 
            {
                Name = "my-keyvaluestore-name"
            });

            string eTag = response.ETag;
            KeyValueStore keyValueStore = response.KeyValueStore;

            #endregion
        }

        public void CloudFrontGetVpcOrigin()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.GetVpcOrigin(new GetVpcOriginRequest 
            {
                Id = "vo_BQwjxxQxjCaBcQLzJUFkDM"
            });

            string eTag = response.ETag;
            VpcOrigin vpcOrigin = response.VpcOrigin;

            #endregion
        }

        public void CloudFrontListDistributionsByVpcOriginId()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.ListDistributionsByVpcOriginId(new ListDistributionsByVpcOriginIdRequest 
            {
                VpcOriginId = "vo_BQwjxxQxjCaBcQLzJUFkDM"
            });

            DistributionIdList distributionIdList = response.DistributionIdList;

            #endregion
        }

        public void CloudFrontListKeyValueStores()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.ListKeyValueStores(new ListKeyValueStoresRequest 
            {
                Status = "READY"
            });

            KeyValueStoreList keyValueStoreList = response.KeyValueStoreList;

            #endregion
        }

        public void CloudFrontListVpcOrigins()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.ListVpcOrigins(new ListVpcOriginsRequest 
            {
            });

            VpcOriginList vpcOriginList = response.VpcOriginList;

            #endregion
        }

        public void CloudFrontUpdateFunction()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.UpdateFunction(new UpdateFunctionRequest 
            {
                FunctionCode = new MemoryStream(function-code-changed.js),
                FunctionConfig = new FunctionConfig {
                    Comment = "my-changed-comment",
                    KeyValueStoreAssociations = new KeyValueStoreAssociations {
                        Items = new List<KeyValueStoreAssociation> {
                            new KeyValueStoreAssociation { KeyValueStoreARN = "arn:aws:cloudfront::123456789012:key-value-store/54947df8-0e9e-4471-a2f9-9af509fb5889" }
                        },
                        Quantity = 1
                    },
                    Runtime = "cloudfront-js-2.0"
                },
                IfMatch = "ETVPDKIKX0DER",
                Name = "my-function-name"
            });

            string eTag = response.ETag;
            FunctionSummary functionSummary = response.FunctionSummary;

            #endregion
        }

        public void CloudFrontUpdateKeyValueStore()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.UpdateKeyValueStore(new UpdateKeyValueStoreRequest 
            {
                Comment = "my-changed-comment",
                IfMatch = "ETVPDKIKX0DER",
                Name = "my-keyvaluestore-name"
            });

            string eTag = response.ETag;
            KeyValueStore keyValueStore = response.KeyValueStore;

            #endregion
        }

        public void CloudFrontUpdateVpcOrigin()
        {
            #region example-1

            var client = new AmazonCloudFrontClient();
            var response = client.UpdateVpcOrigin(new UpdateVpcOriginRequest 
            {
                Id = "vo_BQwjxxQxjCaBcQLzJUFkDM",
                IfMatch = "ETVPDKIKX0DER",
                VpcOriginEndpointConfig = new VpcOriginEndpointConfig {
                    Arn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-alb-us-west-2/e6aa5c7d26415c6d",
                    HTTPPort = 80,
                    HTTPSPort = 443,
                    Name = "my-vpcorigin-name",
                    OriginProtocolPolicy = "match-viewer",
                    OriginSslProtocols = new OriginSslProtocols {
                        Items = new List<string> {
                            "TLSv1.1",
                            "TLSv1.2"
                        },
                        Quantity = 2
                    }
                }
            });

            string eTag = response.ETag;
            VpcOrigin vpcOrigin = response.VpcOrigin;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}