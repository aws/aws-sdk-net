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

using System;
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
        /// <exception cref="ArgumentNullException">Thrown when source is null</exception>
        internal static TransferUtilityUploadResponse MapPutObjectResponse(PutObjectResponse source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

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
        /// <exception cref="ArgumentNullException">Thrown when source is null</exception>
        internal static TransferUtilityUploadResponse MapCompleteMultipartUploadResponse(CompleteMultipartUploadResponse source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

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
        /// <exception cref="ArgumentNullException">Thrown when source or target is null</exception>
        private static void PopulateGetObjectResponseBase(GetObjectResponse source, TransferUtilityGetObjectResponseBase target)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            // Map all fields as defined in mapping.json "Conversion" -> "GetObjectResponse" -> "DownloadResponse"
            target.AcceptRanges = source.AcceptRanges;
            target.BucketKeyEnabled = source.BucketKeyEnabled.GetValueOrDefault();
            target.ChecksumCRC32 = source.ChecksumCRC32;
            target.ChecksumCRC32C = source.ChecksumCRC32C;
            target.ChecksumCRC64NVME = source.ChecksumCRC64NVME;
            target.ChecksumSHA1 = source.ChecksumSHA1;
            target.ChecksumSHA256 = source.ChecksumSHA256;
            target.ChecksumType = source.ChecksumType;
            target.ContentRange = source.ContentRange;
            target.Headers = source.Headers;
            target.DeleteMarker = source.DeleteMarker;
            target.ETag = source.ETag;
            target.Expiration = source.Expiration;
            target.ExpiresString = source.ExpiresString;
            target.LastModified = source.LastModified;
            target.Metadata = source.Metadata;
            target.MissingMeta = source.MissingMeta;
            target.ObjectLockLegalHoldStatus = source.ObjectLockLegalHoldStatus;
            target.ObjectLockMode = source.ObjectLockMode;
            target.ObjectLockRetainUntilDate = source.ObjectLockRetainUntilDate;
            target.PartsCount = source.PartsCount;
            target.ReplicationStatus = source.ReplicationStatus;
            target.RequestCharged = source.RequestCharged;
            target.RestoreExpiration = source.RestoreExpiration;
            target.RestoreInProgress = source.RestoreInProgress;
            target.ServerSideEncryptionCustomerMethod = source.ServerSideEncryptionCustomerMethod;
            target.ServerSideEncryptionCustomerProvidedKeyMD5 = source.ServerSideEncryptionCustomerProvidedKeyMD5;
            target.ServerSideEncryptionKeyManagementServiceKeyId = source.ServerSideEncryptionKeyManagementServiceKeyId;
            target.ServerSideEncryptionMethod = source.ServerSideEncryptionMethod;
            target.StorageClass = source.StorageClass;
            target.TagCount = source.TagCount;
            target.VersionId = source.VersionId;
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
        /// <exception cref="ArgumentNullException">Thrown when source is null</exception>
        internal static TransferUtilityDownloadResponse MapGetObjectResponse(GetObjectResponse source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

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
        /// <exception cref="ArgumentNullException">Thrown when source is null</exception>
        internal static TransferUtilityOpenStreamResponse MapGetObjectResponseToOpenStream(GetObjectResponse source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var response = new TransferUtilityOpenStreamResponse();
            PopulateGetObjectResponseBase(source, response);
            response.ResponseStream = source.ResponseStream;

            return response;            
        }

        
    }
}
