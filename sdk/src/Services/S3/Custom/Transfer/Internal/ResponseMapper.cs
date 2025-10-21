/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Collections.Generic;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Utility class for mapping S3 response objects to TransferUtilityUploadResponse.
    /// Maps fields based on the mapping.json configuration used by the Transfer Utility.
    /// </summary>
    internal static class ResponseMapper
    {
        /// <summary>
        /// Maps a PutObjectResponse to TransferUtilityUploadResponse.
        /// Uses the field mappings defined in mapping.json "Conversion" -> "PutObjectResponse" -> "UploadResponse".
        /// </summary>
        /// <param name="source">The PutObjectResponse to map from</param>
        /// <returns>A new TransferUtilityUploadResponse with mapped fields</returns>
        internal static TransferUtilityUploadResponse MapPutObjectResponse(PutObjectResponse source)
        {
            if (source == null)
                return null;

            var response = new TransferUtilityUploadResponse();

            // Map all fields as defined in mapping.json "Conversion" -> "PutObjectResponse" -> "UploadResponse"
            if (source.IsSetBucketKeyEnabled())
                response.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();

            if (source.IsSetChecksumCRC32())
                response.ChecksumCRC32 = source.ChecksumCRC32;

            if (source.IsSetChecksumCRC32C())
                response.ChecksumCRC32C = source.ChecksumCRC32C;

            if (source.IsSetChecksumCRC64NVME())
                response.ChecksumCRC64NVME = source.ChecksumCRC64NVME;

            if (source.IsSetChecksumSHA1())
                response.ChecksumSHA1 = source.ChecksumSHA1;

            if (source.IsSetChecksumSHA256())
                response.ChecksumSHA256 = source.ChecksumSHA256;

            if (source.IsSetChecksumType())
                response.ChecksumType = source.ChecksumType;

            if (source.IsSetETag())
                response.ETag = source.ETag;

            if (source.Expiration != null)
                response.Expiration = source.Expiration;

            if (source.IsSetRequestCharged())
                response.RequestCharged = source.RequestCharged;

            if (source.ServerSideEncryptionCustomerMethod != null)
                response.ServerSideEncryptionCustomerMethod = source.ServerSideEncryptionCustomerMethod;

            if (source.ServerSideEncryptionCustomerProvidedKeyMD5 != null)
                response.ServerSideEncryptionCustomerProvidedKeyMD5 = source.ServerSideEncryptionCustomerProvidedKeyMD5;

            if (source.ServerSideEncryptionKeyManagementServiceEncryptionContext != null)
                response.ServerSideEncryptionKeyManagementServiceEncryptionContext = source.ServerSideEncryptionKeyManagementServiceEncryptionContext;

            if (source.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                response.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;

            if (source.ServerSideEncryptionMethod != null)
                response.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;

            if (source.IsSetVersionId())
                response.VersionId = source.VersionId;

            // Copy response metadata
            response.ResponseMetadata = source.ResponseMetadata;
            response.ContentLength = source.ContentLength;
            response.HttpStatusCode = source.HttpStatusCode;

            return response;
        }

        /// <summary>
        /// Maps a CompleteMultipartUploadResponse to TransferUtilityUploadResponse.
        /// Uses the field mappings defined in mapping.json "Conversion" -> "CompleteMultipartResponse" -> "UploadResponse".
        /// </summary>
        /// <param name="source">The CompleteMultipartUploadResponse to map from</param>
        /// <returns>A new TransferUtilityUploadResponse with mapped fields</returns>
        internal static TransferUtilityUploadResponse MapCompleteMultipartUploadResponse(CompleteMultipartUploadResponse source)
        {
            if (source == null)
                return null;

            var response = new TransferUtilityUploadResponse();

            // Map all fields as defined in mapping.json "Conversion" -> "CompleteMultipartResponse" -> "UploadResponse"
            if (source.IsSetBucketKeyEnabled())
                response.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();

            if (source.IsSetChecksumCRC32())
                response.ChecksumCRC32 = source.ChecksumCRC32;

            if (source.IsSetChecksumCRC32C())
                response.ChecksumCRC32C = source.ChecksumCRC32C;

            if (source.IsSetChecksumCRC64NVME())
                response.ChecksumCRC64NVME = source.ChecksumCRC64NVME;

            if (source.IsSetChecksumSHA1())
                response.ChecksumSHA1 = source.ChecksumSHA1;

            if (source.IsSetChecksumSHA256())
                response.ChecksumSHA256 = source.ChecksumSHA256;

            if (source.ChecksumType != null)
                response.ChecksumType = source.ChecksumType;

            if (source.IsSetETag())
                response.ETag = source.ETag;

            if (source.Expiration != null)
                response.Expiration = source.Expiration;

            if (source.IsSetRequestCharged())
                response.RequestCharged = source.RequestCharged;

            if (source.ServerSideEncryptionMethod != null)
                response.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;

            if (source.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                response.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;

            if (source.IsSetVersionId())
                response.VersionId = source.VersionId;

            // Copy response metadata
            response.ResponseMetadata = source.ResponseMetadata;
            response.ContentLength = source.ContentLength;
            response.HttpStatusCode = source.HttpStatusCode;

            return response;
        }

        /// <summary>
        /// Private helper method to populate the common properties from GetObjectResponse to the base response class.
        /// Contains all the shared mapping logic for GetObjectResponse fields. 
        /// </summary>
        /// <param name="source">The GetObjectResponse to map from</param>
        /// <param name="target">The TransferUtilityGetObjectResponseBase to populate</param>
        private static void PopulateGetObjectResponseBase(GetObjectResponse source, TransferUtilityGetObjectResponseBase target)
        {
            if (source == null || target == null)
                return;

            // Map all fields as defined in mapping.json "Conversion" -> "GetObjectResponse" -> "DownloadResponse"
            if (source.IsSetAcceptRanges())
                target.AcceptRanges = source.AcceptRanges;

            if (source.IsSetBucketKeyEnabled())
                target.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();

            if (source.IsSetChecksumCRC32())
                target.ChecksumCRC32 = source.ChecksumCRC32;

            if (source.IsSetChecksumCRC32C())
                target.ChecksumCRC32C = source.ChecksumCRC32C;

            if (source.IsSetChecksumCRC64NVME())
                target.ChecksumCRC64NVME = source.ChecksumCRC64NVME;

            if (source.IsSetChecksumSHA1())
                target.ChecksumSHA1 = source.ChecksumSHA1;

            if (source.IsSetChecksumSHA256())
                target.ChecksumSHA256 = source.ChecksumSHA256;

            if (source.IsSetChecksumType())
                target.ChecksumType = source.ChecksumType;

            target.ContentLength = source.ContentLength;

            if (source.IsSetContentRange())
                target.ContentRange = source.ContentRange;

            target.Headers = source.Headers;

            if (source.IsSetDeleteMarker())
                target.DeleteMarker = source.DeleteMarker;

            if (source.IsSetETag())
                target.ETag = source.ETag;

            if (source.Expiration != null)
                target.Expiration = source.Expiration;

            if (source.ExpiresString != null)
                target.ExpiresString = source.ExpiresString;

            if (source.IsSetLastModified())
                target.LastModified = source.LastModified;

            if (source.Metadata != null)
                target.Metadata = source.Metadata;

            if (source.IsSetMissingMeta())
                target.MissingMeta = source.MissingMeta;

            if (source.IsSetObjectLockLegalHoldStatus())
                target.ObjectLockLegalHoldStatus = source.ObjectLockLegalHoldStatus;

            if (source.IsSetObjectLockMode())
                target.ObjectLockMode = source.ObjectLockMode;

            if (source.IsSetObjectLockRetainUntilDate())
                target.ObjectLockRetainUntilDate = source.ObjectLockRetainUntilDate;

            if (source.IsSetPartsCount())
                target.PartsCount = source.PartsCount;

            if (source.IsSetReplicationStatus())
                target.ReplicationStatus = source.ReplicationStatus;

            if (source.IsSetRequestCharged())
                target.RequestCharged = source.RequestCharged;

            if (source.RestoreExpiration.HasValue)
                target.RestoreExpiration = source.RestoreExpiration;

            if (source.RestoreInProgress.HasValue)
                target.RestoreInProgress = source.RestoreInProgress;

            if (source.ServerSideEncryptionCustomerMethod != null)
                target.ServerSideEncryptionCustomerMethod = source.ServerSideEncryptionCustomerMethod;

            if (source.ServerSideEncryptionCustomerProvidedKeyMD5 != null)
                target.ServerSideEncryptionCustomerProvidedKeyMD5 = source.ServerSideEncryptionCustomerProvidedKeyMD5;

            if (source.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                target.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;

            if (source.IsSetServerSideEncryptionMethod())
                target.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;

            if (source.IsSetStorageClass())
                target.StorageClass = source.StorageClass;

            target.TagCount = source.TagCount;

            if (source.IsSetVersionId())
                target.VersionId = source.VersionId;

            if (source.IsSetWebsiteRedirectLocation())
                target.WebsiteRedirectLocation = source.WebsiteRedirectLocation;

            // Copy response metadata  
            target.ResponseMetadata = source.ResponseMetadata;
            target.ContentLength = source.ContentLength;
            target.HttpStatusCode = source.HttpStatusCode;
        }

        /// <summary>
        /// Maps a GetObjectResponse to TransferUtilityDownloadResponse.
        /// Uses the field mappings defined in mapping.json "Conversion" -> "GetObjectResponse" -> "DownloadResponse".
        /// </summary>
        /// <param name="source">The GetObjectResponse to map from</param>
        /// <returns>A new TransferUtilityDownloadResponse with mapped fields</returns>
        internal static TransferUtilityDownloadResponse MapGetObjectResponse(GetObjectResponse source)
        {
            if (source == null)
                return null;

            var response = new TransferUtilityDownloadResponse();
            PopulateGetObjectResponseBase(source, response);
            return response;
        }

        /// <summary>
        /// Maps a GetObjectResponse to TransferUtilityOpenStreamResponse.
        /// Uses the same field mappings as DownloadResponse plus the ResponseStream property.
        /// </summary>
        /// <param name="source">The GetObjectResponse to map from</param>
        /// <returns>A new TransferUtilityOpenStreamResponse with mapped fields</returns>
        internal static TransferUtilityOpenStreamResponse MapGetObjectResponseToOpenStream(GetObjectResponse source)
        {
            if (source == null)
                return null;

            var response = new TransferUtilityOpenStreamResponse();
            PopulateGetObjectResponseBase(source, response);
            response.ResponseStream = source.ResponseStream;

            return response;            
        }

        
    }
}
