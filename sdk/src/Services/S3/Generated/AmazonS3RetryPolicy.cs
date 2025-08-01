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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Amazon.S3.Internal
{
    /// <summary>
    /// This generated class exists solely to populate the list of request types that should be retried when a 200 status code with an error is encountered. The list
    /// is model driven, and should not be modified.
    /// </summary>
    public partial class AmazonS3RetryPolicy : DefaultRetryPolicy
    {
        internal static readonly ICollection<Type> RequestsWith200Error = new HashSet<Type>
        {
            typeof(AbortMultipartUploadRequest),
            typeof(CompleteMultipartUploadRequest),
            typeof(CopyObjectRequest),
            typeof(CopyPartRequest),
            typeof(CreateBucketMetadataConfigurationRequest),
            typeof(CreateBucketMetadataTableConfigurationRequest),
            typeof(CreateSessionRequest),
            typeof(DeleteBucketRequest),
            typeof(DeleteBucketAnalyticsConfigurationRequest),
            typeof(DeleteBucketEncryptionRequest),
            typeof(DeleteBucketIntelligentTieringConfigurationRequest),
            typeof(DeleteBucketInventoryConfigurationRequest),
            typeof(DeleteBucketMetadataConfigurationRequest),
            typeof(DeleteBucketMetadataTableConfigurationRequest),
            typeof(DeleteBucketMetricsConfigurationRequest),
            typeof(DeleteBucketOwnershipControlsRequest),
            typeof(DeleteBucketPolicyRequest),
            typeof(DeleteBucketReplicationRequest),
            typeof(DeleteBucketTaggingRequest),
            typeof(DeleteBucketWebsiteRequest),
            typeof(DeleteCORSConfigurationRequest),
            typeof(DeleteLifecycleConfigurationRequest),
            typeof(DeleteObjectRequest),
            typeof(DeleteObjectsRequest),
            typeof(DeleteObjectTaggingRequest),
            typeof(DeletePublicAccessBlockRequest),
            typeof(GetBucketAccelerateConfigurationRequest),
            typeof(GetBucketAclRequest),
            typeof(GetBucketAnalyticsConfigurationRequest),
            typeof(GetBucketEncryptionRequest),
            typeof(GetBucketIntelligentTieringConfigurationRequest),
            typeof(GetBucketInventoryConfigurationRequest),
            typeof(GetBucketLocationRequest),
            typeof(GetBucketLoggingRequest),
            typeof(GetBucketMetadataConfigurationRequest),
            typeof(GetBucketMetadataTableConfigurationRequest),
            typeof(GetBucketMetricsConfigurationRequest),
            typeof(GetBucketNotificationRequest),
            typeof(GetBucketOwnershipControlsRequest),
            typeof(GetBucketPolicyRequest),
            typeof(GetBucketPolicyStatusRequest),
            typeof(GetBucketReplicationRequest),
            typeof(GetBucketRequestPaymentRequest),
            typeof(GetBucketTaggingRequest),
            typeof(GetBucketVersioningRequest),
            typeof(GetBucketWebsiteRequest),
            typeof(GetCORSConfigurationRequest),
            typeof(GetLifecycleConfigurationRequest),
            typeof(GetObjectAclRequest),
            typeof(GetObjectAttributesRequest),
            typeof(GetObjectLegalHoldRequest),
            typeof(GetObjectLockConfigurationRequest),
            typeof(GetObjectMetadataRequest),
            typeof(GetObjectRetentionRequest),
            typeof(GetObjectTaggingRequest),
            typeof(GetPublicAccessBlockRequest),
            typeof(HeadBucketRequest),
            typeof(InitiateMultipartUploadRequest),
            typeof(ListBucketAnalyticsConfigurationsRequest),
            typeof(ListBucketIntelligentTieringConfigurationsRequest),
            typeof(ListBucketInventoryConfigurationsRequest),
            typeof(ListBucketMetricsConfigurationsRequest),
            typeof(ListBucketsRequest),
            typeof(ListDirectoryBucketsRequest),
            typeof(ListMultipartUploadsRequest),
            typeof(ListObjectsRequest),
            typeof(ListObjectsV2Request),
            typeof(ListPartsRequest),
            typeof(ListVersionsRequest),
            typeof(PutBucketRequest),
            typeof(PutBucketAccelerateConfigurationRequest),
            typeof(PutBucketAclRequest),
            typeof(PutBucketAnalyticsConfigurationRequest),
            typeof(PutBucketEncryptionRequest),
            typeof(PutBucketIntelligentTieringConfigurationRequest),
            typeof(PutBucketInventoryConfigurationRequest),
            typeof(PutBucketLoggingRequest),
            typeof(PutBucketMetricsConfigurationRequest),
            typeof(PutBucketNotificationRequest),
            typeof(PutBucketOwnershipControlsRequest),
            typeof(PutBucketPolicyRequest),
            typeof(PutBucketReplicationRequest),
            typeof(PutBucketRequestPaymentRequest),
            typeof(PutBucketTaggingRequest),
            typeof(PutBucketVersioningRequest),
            typeof(PutBucketWebsiteRequest),
            typeof(PutCORSConfigurationRequest),
            typeof(PutLifecycleConfigurationRequest),
            typeof(PutObjectRequest),
            typeof(PutObjectAclRequest),
            typeof(PutObjectLegalHoldRequest),
            typeof(PutObjectLockConfigurationRequest),
            typeof(PutObjectRetentionRequest),
            typeof(PutObjectTaggingRequest),
            typeof(PutPublicAccessBlockRequest),
            typeof(RenameObjectRequest),
            typeof(RestoreObjectRequest),
            typeof(SelectObjectContentRequest),
            typeof(UpdateBucketMetadataInventoryTableConfigurationRequest),
            typeof(UpdateBucketMetadataJournalTableConfigurationRequest),
            typeof(UploadPartRequest),
            typeof(WriteGetObjectResponseRequest),
        };
    }
}