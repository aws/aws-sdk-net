using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.S3.Model;
using Amazon.Util.Internal;
using System;
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        #region ICoreAmazonS3 Implementation

        async Task<IList<string>> ICoreAmazonS3.GetAllObjectKeysAsync(string bucketName, string prefix, IDictionary<string, object> additionalProperties)
        {
            var keys = new List<string>();
            string marker = null;
            do
            {
                var request = new ListObjectsRequest
                {
                    BucketName = bucketName,
                    Prefix = prefix,
                    Marker = marker
                };
                InternalSDKUtils.ApplyValues(request, additionalProperties);

                var listResponse = await this.ListObjectsAsync(request).ConfigureAwait(false);
                keys.AddRange(listResponse.S3Objects.Select(o => o.Key));
                marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(marker));

            return keys;
        }

        Task ICoreAmazonS3.DeleteAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken)
        {
            var request = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = objectKey
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);
            return this.DeleteObjectAsync(request, cancellationToken);
        }

        Task ICoreAmazonS3.DeletesAsync(string bucketName, IEnumerable<string> objectKeys, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken)
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = bucketName,
            };

            foreach (var key in objectKeys)
            {
                request.AddKey(key);
            }
            InternalSDKUtils.ApplyValues(request, additionalProperties);
            return this.DeleteObjectsAsync(request, cancellationToken);
        }

        Task ICoreAmazonS3.UploadObjectFromStreamAsync(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            var request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                InputStream = stream
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);
            return transfer.UploadAsync(request, cancellationToken);
        }

        async Task<Stream> ICoreAmazonS3.GetObjectStreamAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken)
        {
            var request = new GetObjectRequest()
            {
                BucketName = bucketName,
                Key = objectKey
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return (await this.GetObjectAsync(request, cancellationToken).ConfigureAwait(false)).ResponseStream;
        }

        Task ICoreAmazonS3.UploadObjectFromFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            var request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = filepath
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return transfer.UploadAsync(request, cancellationToken);
        }

        Task ICoreAmazonS3.DownloadToFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);

            var request = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = filepath
            };
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            return transfer.DownloadAsync(request, cancellationToken);
        }

        Task ICoreAmazonS3.MakeObjectPublicAsync(string bucket, string objectKey, bool enable)
        {
            var request = new PutACLRequest
            {
                BucketName = bucket,
                Key = objectKey,
                CannedACL = enable ? S3CannedACL.PublicRead : S3CannedACL.Private
            };
            return this.PutACLAsync(request);
        }

        Task ICoreAmazonS3.EnsureBucketExistsAsync(string bucketName)
        {
            return this.PutBucketAsync(bucketName);
        }

        [Obsolete("This method is deprecated: its behavior is inconsistent and always uses HTTP. Please use Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async instead.")]
        Task<bool> ICoreAmazonS3.DoesS3BucketExistAsync(string bucketName)
        {
            return Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistAsync(this, bucketName);
        }
        #endregion
    }
}

