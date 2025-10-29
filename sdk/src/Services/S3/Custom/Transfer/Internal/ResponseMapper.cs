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
            response.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();
            response.ChecksumCRC32 = source.ChecksumCRC32;
            response.ChecksumCRC32C = source.ChecksumCRC32C;
            response.ChecksumCRC64NVME = source.ChecksumCRC64NVME;
            response.ChecksumSHA1 = source.ChecksumSHA1;
            response.ChecksumSHA256 = source.ChecksumSHA256;
            response.ChecksumType = source.ChecksumType;
            response.ETag = source.ETag;
            response.Expiration = source.Expiration;
            response.RequestCharged = source.RequestCharged;
            response.ServerSideEncryptionCustomerMethod = source.ServerSideEncryptionCustomerMethod;
            response.ServerSideEncryptionCustomerProvidedKeyMD5 = source.ServerSideEncryptionCustomerProvidedKeyMD5;
            response.ServerSideEncryptionKeyManagementServiceEncryptionContext = source.ServerSideEncryptionKeyManagementServiceEncryptionContext;
            response.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;
            response.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;
            response.VersionId = source.VersionId;
            response.Size = source.Size;

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
            response.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();
            response.ChecksumCRC32 = source.ChecksumCRC32;
            response.ChecksumCRC32C = source.ChecksumCRC32C;
            response.ChecksumCRC64NVME = source.ChecksumCRC64NVME;
            response.ChecksumSHA1 = source.ChecksumSHA1;
            response.ChecksumSHA256 = source.ChecksumSHA256;
            response.ChecksumType = source.ChecksumType;
            response.ETag = source.ETag;
            response.Expiration = source.Expiration;
            response.RequestCharged = source.RequestCharged;
            response.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;
            response.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;
            response.VersionId = source.VersionId;
            response.BucketName = source.BucketName;
            response.Key = source.Key;
            response.Location = source.Location;

            return response;
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

            // Map all fields as defined in mapping.json "Conversion" -> "GetObjectResponse" -> "DownloadResponse"
            response.AcceptRanges = source.AcceptRanges;
            response.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();
            response.ChecksumCRC32 = source.ChecksumCRC32;
            response.ChecksumCRC32C = source.ChecksumCRC32C;
            response.ChecksumCRC64NVME = source.ChecksumCRC64NVME;
            response.ChecksumSHA1 = source.ChecksumSHA1;
            response.ChecksumSHA256 = source.ChecksumSHA256;
            response.ChecksumType = source.ChecksumType;
            response.ContentRange = source.ContentRange;
            response.Headers = source.Headers;
            response.DeleteMarker = source.DeleteMarker;
            response.ETag = source.ETag;
            response.Expiration = source.Expiration;
            response.ExpiresString = source.ExpiresString;
            response.LastModified = source.LastModified;
            response.Metadata = source.Metadata;
            response.MissingMeta = source.MissingMeta;
            response.ObjectLockLegalHoldStatus = source.ObjectLockLegalHoldStatus;
            response.ObjectLockMode = source.ObjectLockMode;
            response.ObjectLockRetainUntilDate = source.ObjectLockRetainUntilDate;
            response.PartsCount = source.PartsCount;
            response.ReplicationStatus = source.ReplicationStatus;
            response.RequestCharged = source.RequestCharged;
            response.RestoreExpiration = source.RestoreExpiration;
            response.RestoreInProgress = source.RestoreInProgress;
            response.ServerSideEncryptionCustomerMethod = source.ServerSideEncryptionCustomerMethod;
            response.ServerSideEncryptionCustomerProvidedKeyMD5 = source.ServerSideEncryptionCustomerProvidedKeyMD5;
            response.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;
            response.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;
            response.StorageClass = source.StorageClass;
            response.TagCount = source.TagCount;
            response.VersionId = source.VersionId;
            response.WebsiteRedirectLocation = source.WebsiteRedirectLocation;
            return response;
        }
        
    }
}
