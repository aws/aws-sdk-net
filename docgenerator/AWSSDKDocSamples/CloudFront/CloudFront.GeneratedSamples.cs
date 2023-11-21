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
            #region to-create-a-function-1699737558249

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
            #region to-create-a-key-value-store-1699751722467

            var client = new AmazonCloudFrontClient();
            var response = client.CreateKeyValueStore(new CreateKeyValueStoreRequest 
            {
                Comment = "my-key-valuestore-comment",
                ImportSource = new ImportSource {
                    SourceARN = "arn:aws:s3:::my-bucket/validJSON.json",
                    SourceType = "S3"
                },
                Name = "my-keyvaluestore-name"
            });

            string eTag = response.ETag;
            KeyValueStore keyValueStore = response.KeyValueStore;
            string location = response.Location;

            #endregion
        }

        public void CloudFrontDeleteKeyValueStore()
        {
            #region to-delete-a-key-value-store-1699751759648

            var client = new AmazonCloudFrontClient();
            var response = client.DeleteKeyValueStore(new DeleteKeyValueStoreRequest 
            {
                IfMatch = "ETVPDKIKX0DER",
                Name = "my-keyvaluestore-name"
            });


            #endregion
        }

        public void CloudFrontDescribeKeyValueStore()
        {
            #region to-describe-a-key-value-store-1699751788152

            var client = new AmazonCloudFrontClient();
            var response = client.DescribeKeyValueStore(new DescribeKeyValueStoreRequest 
            {
                Name = "my-keyvaluestore-name"
            });

            string eTag = response.ETag;
            KeyValueStore keyValueStore = response.KeyValueStore;

            #endregion
        }

        public void CloudFrontListKeyValueStores()
        {
            #region to-get-a-list-of-key-value-store-1699751799198

            var client = new AmazonCloudFrontClient();
            var response = client.ListKeyValueStores(new ListKeyValueStoresRequest 
            {
                Marker = "",
                MaxItems = "100",
                Status = "READY"
            });

            KeyValueStoreList keyValueStoreList = response.KeyValueStoreList;

            #endregion
        }

        public void CloudFrontUpdateFunction()
        {
            #region to-update-a-function-1699751865053

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
            #region to-update-a-key-value-store-1699751822090

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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}