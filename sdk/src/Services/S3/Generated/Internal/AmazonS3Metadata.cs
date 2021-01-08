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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */


using Amazon.Runtime.Internal;


namespace Amazon.S3.Internal
{
    /// <summary>
    /// Service metadata for  Amazon S3 service
    /// </summary>
    public partial class AmazonS3Metadata : IServiceMetadata
    {
        /// <summary>
        /// Gets the value of the Service Id.
        /// </summary>
        public string ServiceId
        {
            get
            {
                return "S3";
            }
        }

        /// <summary>
        /// Gets the dictionary that gives mapping of renamed operations
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> OperationNameMapping
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>(15)
                {
                    {"PutBucket", "CreateBucket"},
                    {"InitiateMultipartUpload", "CreateMultipartUpload"},
                    {"DeleteCORSConfiguration", "DeleteBucketCors"},
                    {"DeleteLifecycleConfiguration", "DeleteBucketLifecycle"},
                    {"GetACL", "GetBucketAcl"},
                    {"GetCORSConfiguration", "GetBucketCors"},
                    {"GetLifecycleConfiguration", "GetBucketLifecycleConfiguration"},
                    {"GetBucketNotification", "GetBucketNotificationConfiguration"},
                    {"GetObjectMetadata", "HeadObject"},
                    {"ListVersions", "ListObjectVersions"},
                    {"PutACL", "PutBucketAcl"},
                    {"PutCORSConfiguration", "PutBucketCors"},
                    {"PutLifecycleConfiguration", "PutBucketLifecycleConfiguration"},
                    {"PutBucketNotification", "PutBucketNotificationConfiguration"},
                    {"CopyPart", "UploadPartCopy"},
                };
            }
        }
    }
}