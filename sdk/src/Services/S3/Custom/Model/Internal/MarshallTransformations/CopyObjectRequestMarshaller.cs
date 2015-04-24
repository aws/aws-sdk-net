/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            IRequest request = new DefaultRequest(copyObjectRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (copyObjectRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, S3Transforms.ToStringValue(copyObjectRequest.CannedACL));

            var headers = copyObjectRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            HeaderACLRequestMarshaller.Marshall(request, copyObjectRequest);

            if (copyObjectRequest.IsSetSourceBucket())
                request.Headers.Add(HeaderKeys.XAmzCopySourceHeader, ConstructCopySourceHeaderValue(copyObjectRequest.SourceBucket, copyObjectRequest.SourceKey, copyObjectRequest.SourceVersionId));

            if (copyObjectRequest.IsSetETagToMatch())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfMatchHeader, S3Transforms.ToStringValue(copyObjectRequest.ETagToMatch));

            if (copyObjectRequest.IsSetModifiedSinceDate())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfModifiedSinceHeader, S3Transforms.ToStringValue(copyObjectRequest.ModifiedSinceDate));

            if (copyObjectRequest.IsSetETagToNotMatch())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfNoneMatchHeader, S3Transforms.ToStringValue(copyObjectRequest.ETagToNotMatch));

            if (copyObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfUnmodifiedSinceHeader, S3Transforms.ToStringValue(copyObjectRequest.UnmodifiedSinceDate));

            request.Headers.Add(HeaderKeys.XAmzMetadataDirectiveHeader, S3Transforms.ToStringValue(copyObjectRequest.MetadataDirective.ToString()));

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

            if (copyObjectRequest.IsSetStorageClass())
                request.Headers.Add(HeaderKeys.XAmzStorageClassHeader, S3Transforms.ToStringValue(copyObjectRequest.StorageClass));

            if (copyObjectRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add(HeaderKeys.XAmzWebsiteRedirectLocationHeader, S3Transforms.ToStringValue(copyObjectRequest.WebsiteRedirectLocation));

            AmazonS3Util.SetMetadataHeaders(request, copyObjectRequest.Metadata);

            var destinationKey = copyObjectRequest.DestinationKey.StartsWith("/", StringComparison.Ordinal) 
                                    ? copyObjectRequest.DestinationKey.Substring(1) 
                                    : copyObjectRequest.DestinationKey;
            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(copyObjectRequest.DestinationBucket),
                                                 S3Transforms.ToStringValue(destinationKey));


            request.UseQueryString = true;

            return request;
        }

        static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
        {
            string source;
            if (!String.IsNullOrEmpty(key))
            {
                var sourceKey = key.StartsWith("/", StringComparison.Ordinal)
                                        ? key.Substring(1)
                                        : key;
                source = AmazonS3Util.UrlEncode(String.Concat("/", bucket, "/", sourceKey), true);
                if (!String.IsNullOrEmpty(version))
                {
                    source = string.Format(CultureInfo.InvariantCulture, "{0}?versionId={1}", source, AmazonS3Util.UrlEncode(version, true));
                }
            }
            else
            {
                source = AmazonS3Util.UrlEncode(bucket, true);
            }

            return source;
        }
    }
}

