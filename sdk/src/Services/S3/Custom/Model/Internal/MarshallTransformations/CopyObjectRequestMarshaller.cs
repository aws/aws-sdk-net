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
using System;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;
using Amazon.S3.Internal;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Copy Object Request Marshaller
    /// </summary>       
    public class CopyObjectRequestMarshaller : IMarshaller<IRequest, CopyObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((CopyObjectRequest)input);
		}

        public IRequest Marshall(CopyObjectRequest copyObjectRequest)
        {
            var sourceKey = copyObjectRequest.SourceKey;

            var destinationKey = copyObjectRequest.DestinationKey;
            
            IRequest request = new DefaultRequest(copyObjectRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (copyObjectRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, S3Transforms.ToStringValue(copyObjectRequest.CannedACL));

            var headers = copyObjectRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            HeaderACLRequestMarshaller.Marshall(request, copyObjectRequest);

            if (copyObjectRequest.IsSetSourceBucket())
                request.Headers.Add(HeaderKeys.XAmzCopySourceHeader, ConstructCopySourceHeaderValue(copyObjectRequest.SourceBucket, sourceKey, copyObjectRequest.SourceVersionId));

            if (copyObjectRequest.IsSetETagToMatch())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfMatchHeader, S3Transforms.ToStringValue(copyObjectRequest.ETagToMatch));

            if (copyObjectRequest.IsSetModifiedSinceDate())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfModifiedSinceHeader, S3Transforms.ToStringValue(copyObjectRequest.ModifiedSinceDate.Value));

            if (copyObjectRequest.IsSetETagToNotMatch())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfNoneMatchHeader, S3Transforms.ToStringValue(copyObjectRequest.ETagToNotMatch));

            if (copyObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfUnmodifiedSinceHeader, S3Transforms.ToStringValue(copyObjectRequest.UnmodifiedSinceDate.Value));
            
            if (copyObjectRequest.IsSetTaggingDirective())
            {
                if (copyObjectRequest.TaggingDirective == TaggingDirective.REPLACE)
                {
                    if (copyObjectRequest.IsSetTagSet())
                        request.Headers.Add(S3Constants.AmzHeaderTagging, AmazonS3Util.TagSetToQueryString(copyObjectRequest.TagSet));
                    request.Headers.Add(S3Constants.AmzHeaderTaggingDirective, TaggingDirective.REPLACE.Value);
                }
                else if (copyObjectRequest.TaggingDirective == TaggingDirective.COPY)
                    request.Headers.Add(S3Constants.AmzHeaderTaggingDirective, TaggingDirective.COPY.Value);
            }

            request.Headers.Add(HeaderKeys.XAmzMetadataDirectiveHeader, S3Transforms.ToStringValue(copyObjectRequest.MetadataDirective.ToString()));

			if(copyObjectRequest.IsSetObjectLockLegalHoldStatus())
                request.Headers.Add("x-amz-object-lock-legal-hold", S3Transforms.ToStringValue(copyObjectRequest.ObjectLockLegalHoldStatus));        
            if(copyObjectRequest.IsSetObjectLockMode())
                request.Headers.Add("x-amz-object-lock-mode", S3Transforms.ToStringValue(copyObjectRequest.ObjectLockMode));        
            if(copyObjectRequest.IsSetObjectLockRetainUntilDate())
                request.Headers.Add("x-amz-object-lock-retain-until-date", S3Transforms.ToStringValue(copyObjectRequest.ObjectLockRetainUntilDate.Value, AWSSDKUtils.ISO8601DateFormat));

            if (copyObjectRequest.IsSetServerSideEncryptionMethod())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, S3Transforms.ToStringValue(copyObjectRequest.ServerSideEncryptionMethod));
            if (copyObjectRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, copyObjectRequest.ServerSideEncryptionCustomerMethod);
            if (copyObjectRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, copyObjectRequest.ServerSideEncryptionCustomerProvidedKey);
                if(copyObjectRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, copyObjectRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(copyObjectRequest.ServerSideEncryptionCustomerProvidedKey));
            }
            if (copyObjectRequest.IsSetCopySourceServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerAlgorithmHeader, copyObjectRequest.CopySourceServerSideEncryptionCustomerMethod);
            if (copyObjectRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyHeader, copyObjectRequest.CopySourceServerSideEncryptionCustomerProvidedKey);
                if (copyObjectRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, copyObjectRequest.CopySourceServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(copyObjectRequest.CopySourceServerSideEncryptionCustomerProvidedKey));
            }
            if (copyObjectRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, copyObjectRequest.ServerSideEncryptionKeyManagementServiceKeyId);

            if (copyObjectRequest.IsSetServerSideEncryptionKeyManagementServiceEncryptionContext())
                request.Headers.Add("x-amz-server-side-encryption-context", copyObjectRequest.ServerSideEncryptionKeyManagementServiceEncryptionContext);

            if (copyObjectRequest.IsSetStorageClass())
                request.Headers.Add(HeaderKeys.XAmzStorageClassHeader, S3Transforms.ToStringValue(copyObjectRequest.StorageClass));

            if (copyObjectRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add(HeaderKeys.XAmzWebsiteRedirectLocationHeader, S3Transforms.ToStringValue(copyObjectRequest.WebsiteRedirectLocation));

            if (copyObjectRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(copyObjectRequest.RequestPayer.ToString()));

            if (copyObjectRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(copyObjectRequest.ExpectedBucketOwner));

            if (copyObjectRequest.IsSetExpectedSourceBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedSourceBucketOwner, S3Transforms.ToStringValue(copyObjectRequest.ExpectedSourceBucketOwner));

            if (copyObjectRequest.IsSetBucketKeyEnabled())
                request.Headers.Add(S3Constants.AmzHeaderBucketKeyEnabled, S3Transforms.ToStringValue(copyObjectRequest.BucketKeyEnabled.Value));

            if (copyObjectRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderChecksumAlgorithm ,S3Transforms.ToStringValue(copyObjectRequest.ChecksumAlgorithm));

            AmazonS3Util.SetMetadataHeaders(request, copyObjectRequest.Metadata);

            if (string.IsNullOrEmpty(copyObjectRequest.DestinationBucket))
                throw new System.ArgumentException("DestinationBucket is a required property and must be set before making this call.", "CopyObjectRequest.DestinationBucket");
            if (string.IsNullOrEmpty(destinationKey))
                throw new System.ArgumentException("DestinationKey is a required property and must be set before making this call.", "CopyObjectRequest.DestinationKey");
            if (string.IsNullOrEmpty(copyObjectRequest.SourceBucket))
                throw new System.ArgumentException("SourceBucket is a required property and must be set before making this call.", "CopyObjectRequest.SourceBucket");
            if (string.IsNullOrEmpty(sourceKey))
                throw new System.ArgumentException("SourceKey is a required property and must be set before making this call.", "CopyObjectRequest.SourceKey");
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(destinationKey));
            request.ResourcePath = "/{Key+}";


            request.UseQueryString = true;

            return request;
        }

        static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
        {
            string source;
            if (!String.IsNullOrEmpty(key))
            {
                var isAccessPoint = S3ArnUtils.IsS3AccessPointsArn(bucket) || S3ArnUtils.IsS3OutpostsArn(bucket);
                // 'object/' needed appended to key for copy header with access points

                source = AWSSDKUtils.UrlEncode(String.Concat(bucket, isAccessPoint ? "/object/" : "/", key), false);
                if (!String.IsNullOrEmpty(version))
                {
                    source = string.Format(CultureInfo.InvariantCulture, "{0}?versionId={1}", source, AWSSDKUtils.UrlEncode(version, true));
                }
            }
            else
            {
                source = AWSSDKUtils.UrlEncode(bucket, true);
            }

            return source;
        }

        private static CopyObjectRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static CopyObjectRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new CopyObjectRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

