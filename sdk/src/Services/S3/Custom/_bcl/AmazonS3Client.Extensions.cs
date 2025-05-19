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

using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util.Internal;
using Amazon.S3.Model;
using System;

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        #region ICoreAmazonS3 Implementation

        IList<string> ICoreAmazonS3.GetAllObjectKeys(string bucketName, string prefix, IDictionary<string, object> additionalProperties)
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
                InternalSDKUtils.ApplyValuesV2(request, additionalProperties);

                var listResponse = this.ListObjects(request);
                if (listResponse.S3Objects != null)
                    keys.AddRange(listResponse.S3Objects.Select(o => o.Key));

                marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(marker));

            return keys;
        }

        void ICoreAmazonS3.Delete(string bucketName, string objectKey, IDictionary<string, object> additionalProperties)
        {
            var request = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = objectKey
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);
            this.DeleteObject(request);
        }

        void ICoreAmazonS3.Deletes(string bucketName, IEnumerable<string> objectKeys, IDictionary<string, object> additionalProperties)
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = bucketName
            };

            foreach(var key in objectKeys)
            {
                request.AddKey(key);
            }
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);
            this.DeleteObjects(request);
        }

        void ICoreAmazonS3.UploadObjectFromStream(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            var request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                InputStream = stream
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);
            transfer.Upload(request);
        }

        void ICoreAmazonS3.UploadObjectFromFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);
            var request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = filepath
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);
            transfer.Upload(request);
        }

        void ICoreAmazonS3.DownloadToFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties)
        {
            var transfer = new Amazon.S3.Transfer.TransferUtility(this);

            var request = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = filepath
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);
            transfer.Download(request);
        }

        Stream ICoreAmazonS3.GetObjectStream(string bucketName, string objectKey, IDictionary<string, object> additionalProperties)
        {
            var request = new GetObjectRequest()
            {
                BucketName = bucketName,
                Key = objectKey
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);
            return this.GetObject(request).ResponseStream;
        }

        void ICoreAmazonS3.MakeObjectPublic(string bucket, string objectKey, bool enable)
        {
            var request = new PutObjectAclRequest
            {
                BucketName = bucket,
                Key = objectKey,
                ACL = enable ? S3CannedACL.PublicRead : S3CannedACL.Private
            };
            this.PutObjectAcl(request);
        }

        void ICoreAmazonS3.EnsureBucketExists(string bucketName)
        {
            try
            {
                this.PutBucket(bucketName);
            }
            catch (BucketAlreadyOwnedByYouException) { }
        }
        #endregion
    }
}

