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
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Utility class for mapping Transfer Utility request objects to S3 request objects.
    /// Centralizes request creation logic to ensure consistency across different commands.
    /// </summary>
    internal static class RequestMapper
    {
        /// <summary>
        /// Maps a BaseDownloadRequest to GetObjectRequest.
        /// Includes comprehensive property mappings for all supported download scenarios.
        /// </summary>
        /// <param name="request">The BaseDownloadRequest to map from</param>
        /// <returns>A new GetObjectRequest with mapped fields</returns>
        /// <exception cref="ArgumentNullException">Thrown when request is null</exception>
        internal static GetObjectRequest MapToGetObjectRequest(BaseDownloadRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var getRequest = new GetObjectRequest
            {
                BucketName = request.BucketName,
                Key = request.Key,
                VersionId = request.VersionId
            };

            // Map date conditions
            if (request.IsSetModifiedSinceDate())
            {
                getRequest.ModifiedSinceDate = request.ModifiedSinceDate;
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                getRequest.UnmodifiedSinceDate = request.UnmodifiedSinceDate;
            }

            // Map server-side encryption properties
            getRequest.ServerSideEncryptionCustomerMethod = request.ServerSideEncryptionCustomerMethod;
            getRequest.ServerSideEncryptionCustomerProvidedKey = request.ServerSideEncryptionCustomerProvidedKey;
            getRequest.ServerSideEncryptionCustomerProvidedKeyMD5 = request.ServerSideEncryptionCustomerProvidedKeyMD5;

            // Map additional properties
            getRequest.ChecksumMode = request.ChecksumMode;
            getRequest.RequestPayer = request.RequestPayer;

            // Map ownership and ETag matching properties
            if (request.IsSetExpectedBucketOwner())
            {
                getRequest.ExpectedBucketOwner = request.ExpectedBucketOwner;
            }
            if (request.IsSetIfMatch())
            {
                getRequest.EtagToMatch = request.IfMatch;
            }
            if (request.IsSetIfNoneMatch())
            {
                getRequest.EtagToNotMatch = request.IfNoneMatch;
            }

            // Map response header overrides
            getRequest.ResponseHeaderOverrides = request.ResponseHeaderOverrides;

            return getRequest;
        }
    }
}
