using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CloudFrontKeyValueStore;
using Amazon.CloudFrontKeyValueStore.Model;

namespace AWSSDKDocSamples.Amazon.CloudFrontKeyValueStore.Generated
{
    class CloudFrontKeyValueStoreSamples : ISample
    {
        public void CloudFrontKeyValueStoreDeleteKey()
        {
            #region DeleteKey-1

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.DeleteKey(new DeleteKeyRequest
            {
                IfMatch = "KV0AB12C3DEF456",
                Key = "key1",
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58"
            });

            string eTag = response.ETag;
            int? itemCount = response.ItemCount;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        public void CloudFrontKeyValueStoreDescribeKeyValueStore()
        {
            #region DescribeKeyValueStore-1

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.DescribeKeyValueStore(new DescribeKeyValueStoreRequest
            {
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58"
            });

            DateTime? created = response.Created;
            string eTag = response.ETag;
            string failureReason = response.FailureReason;
            int? itemCount = response.ItemCount;
            string kvsARN = response.KvsARN;
            DateTime? lastModified = response.LastModified;
            string status = response.Status;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        public void CloudFrontKeyValueStoreDescribeKeyValueStore()
        {
            #region DescribeKeyValueStore-2

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.DescribeKeyValueStore(new DescribeKeyValueStoreRequest
            {
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-1234a9d35678"
            });

            DateTime? created = response.Created;
            string eTag = response.ETag;
            int? itemCount = response.ItemCount;
            string kvsARN = response.KvsARN;
            DateTime? lastModified = response.LastModified;
            string status = response.Status;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        public void CloudFrontKeyValueStoreGetKey()
        {
            #region GetKey-1

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.GetKey(new GetKeyRequest
            {
                Key = "key1",
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58"
            });

            int? itemCount = response.ItemCount;
            string key = response.Key;
            long? totalSizeInBytes = response.TotalSizeInBytes;
            string value = response.Value;

            #endregion
        }

        public void CloudFrontKeyValueStoreListKeys()
        {
            #region ListKeys-1

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.ListKeys(new ListKeysRequest
            {
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58",
                MaxResults = 3
            });

            List<ListKeysResponseListItem> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudFrontKeyValueStoreListKeys()
        {
            #region ListKeys-2

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.ListKeys(new ListKeysRequest
            {
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58",
                MaxResults = 3,
                NextToken = "hVTTZndkpBZ0VRZ0R1RF"
            });

            List<ListKeysResponseListItem> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudFrontKeyValueStorePutKey()
        {
            #region PutKey-1

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.PutKey(new PutKeyRequest
            {
                IfMatch = "KV0AB12C3DEF456",
                Key = "key1",
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58",
                Value = "value1"
            });

            string eTag = response.ETag;
            int? itemCount = response.ItemCount;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        public void CloudFrontKeyValueStoreUpdateKeys()
        {
            #region UpdateKeys-1

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.UpdateKeys(new UpdateKeysRequest
            {
                IfMatch = "KV0AB12C3DEF456",
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58",
                Puts = new List<PutKeyRequestListItem> {
                    new PutKeyRequestListItem {
                        Key = "key1",
                        Value = "value1"
                    },
                    new PutKeyRequestListItem {
                        Key = "key2",
                        Value = "value2"
                    }
                }
            });

            string eTag = response.ETag;
            int? itemCount = response.ItemCount;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        public void CloudFrontKeyValueStoreUpdateKeys()
        {
            #region UpdateKeys-2

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.UpdateKeys(new UpdateKeysRequest
            {
                Deletes = new List<DeleteKeyRequestListItem> {
                    new DeleteKeyRequestListItem { Key = "key1" },
                    new DeleteKeyRequestListItem { Key = "key2" }
                },
                IfMatch = "KV0AB12C3DEF456",
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58"
            });

            string eTag = response.ETag;
            int? itemCount = response.ItemCount;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        public void CloudFrontKeyValueStoreUpdateKeys()
        {
            #region UpdateKeys-3

            var client = new AmazonCloudFrontKeyValueStoreClient();
            var response = client.UpdateKeys(new UpdateKeysRequest
            {
                Deletes = new List<DeleteKeyRequestListItem> {
                    new DeleteKeyRequestListItem { Key = "key3" },
                    new DeleteKeyRequestListItem { Key = "key4" }
                },
                IfMatch = "KV0AB12C3DEF456",
                KvsARN = "arn:aws:cloudfront::123456789012:key-value-store/327284aa-bcd5-499f-a3ff-26b9a9d31b58",
                Puts = new List<PutKeyRequestListItem> {
                    new PutKeyRequestListItem {
                        Key = "key1",
                        Value = "value1"
                    },
                    new PutKeyRequestListItem {
                        Key = "key2",
                        Value = "value2"
                    }
                }
            });

            string eTag = response.ETag;
            int? itemCount = response.ItemCount;
            long? totalSizeInBytes = response.TotalSizeInBytes;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
