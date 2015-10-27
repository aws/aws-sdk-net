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
using Amazon.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Part Copy Request Marshaller
    /// </summary>       
    public class CopyPartRequestMarshaller : IMarshaller<IRequest, CopyPartRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((CopyPartRequest)input);
		}

        public IRequest Marshall(CopyPartRequest copyPartRequest)
        {
            IRequest request = new DefaultRequest(copyPartRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (copyPartRequest.IsSetSourceBucket())
                request.Headers.Add(HeaderKeys.XAmzCopySourceHeader, ConstructCopySourceHeaderValue(copyPartRequest.SourceBucket, copyPartRequest.SourceKey, copyPartRequest.SourceVersionId));

            if (copyPartRequest.IsSetETagToMatch())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfMatchHeader, AWSSDKUtils.Join(copyPartRequest.ETagToMatch));

            if (copyPartRequest.IsSetETagToNotMatch())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfNoneMatchHeader, AWSSDKUtils.Join(copyPartRequest.ETagsToNotMatch));

            if (copyPartRequest.IsSetModifiedSinceDate())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfModifiedSinceHeader, copyPartRequest.ModifiedSinceDate.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat, CultureInfo.InvariantCulture));

            if (copyPartRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add(HeaderKeys.XAmzCopySourceIfUnmodifiedSinceHeader, copyPartRequest.UnmodifiedSinceDate.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat, CultureInfo.InvariantCulture));

            if (copyPartRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, copyPartRequest.ServerSideEncryptionCustomerMethod);
            if (copyPartRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, copyPartRequest.ServerSideEncryptionCustomerProvidedKey);
                if (copyPartRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, copyPartRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(copyPartRequest.ServerSideEncryptionCustomerProvidedKey));
            }
            if (copyPartRequest.IsSetCopySourceServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerAlgorithmHeader, copyPartRequest.CopySourceServerSideEncryptionCustomerMethod);
            if (copyPartRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyHeader, copyPartRequest.CopySourceServerSideEncryptionCustomerProvidedKey);
                if (copyPartRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, copyPartRequest.CopySourceServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(copyPartRequest.CopySourceServerSideEncryptionCustomerProvidedKey));
            }
            if (copyPartRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, copyPartRequest.ServerSideEncryptionKeyManagementServiceKeyId);

            if(copyPartRequest.IsSetFirstByte() && copyPartRequest.IsSetLastByte())
            	request.Headers.Add(HeaderKeys.XAmzCopySourceRangeHeader, ConstructCopySourceRangeHeader(copyPartRequest.FirstByte, copyPartRequest.LastByte));

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(copyPartRequest.DestinationBucket),
                                                 S3Transforms.ToStringValue(copyPartRequest.DestinationKey));

            request.AddSubResource("partNumber", S3Transforms.ToStringValue(copyPartRequest.PartNumber));
            request.AddSubResource("uploadId", S3Transforms.ToStringValue(copyPartRequest.UploadId));

            request.UseQueryString = true;

            return request;
        }

        static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
        {
            string source;
            if (!String.IsNullOrEmpty(key))
            {
                source = AmazonS3Util.UrlEncode(String.Concat("/", bucket, "/", key), true);
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

        static string ConstructCopySourceRangeHeader(long firstByte, long lastByte)
        {
            return string.Format(CultureInfo.InvariantCulture, "bytes={0}-{1}", firstByte, lastByte);
        }
    }
}

