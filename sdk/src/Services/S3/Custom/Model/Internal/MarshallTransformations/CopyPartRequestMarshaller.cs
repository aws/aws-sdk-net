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
using Amazon.Util;
using System.Globalization;
using Amazon.S3.Internal;

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
            var sourceKey = AmazonS3Util.RemoveLeadingSlash(copyPartRequest.SourceKey);
            var destinationKey = AmazonS3Util.RemoveLeadingSlash(copyPartRequest.DestinationKey);
            request.HttpMethod = "PUT";

            if (copyPartRequest.IsSetSourceBucket())
                request.Headers.Add(HeaderKeys.XAmzCopySourceHeader, ConstructCopySourceHeaderValue(copyPartRequest.SourceBucket, sourceKey, copyPartRequest.SourceVersionId));

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

            if(copyPartRequest.IsSetFirstByte() && copyPartRequest.IsSetLastByte())
            	request.Headers.Add(HeaderKeys.XAmzCopySourceRangeHeader, ConstructCopySourceRangeHeader(copyPartRequest.FirstByte, copyPartRequest.LastByte));

            if (copyPartRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(copyPartRequest.ExpectedBucketOwner));

            if (copyPartRequest.IsSetExpectedSourceBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedSourceBucketOwner, S3Transforms.ToStringValue(copyPartRequest.ExpectedSourceBucketOwner));

            if (string.IsNullOrEmpty(copyPartRequest.DestinationBucket))
                throw new System.ArgumentException("DestinationBucket is a required property and must be set before making this call.", "CopyPartRequest.DestinationBucket");

            if (string.IsNullOrEmpty(destinationKey))
                throw new System.ArgumentException("DestinationKey is a required property and must be set before making this call.", "CopyPartRequest.DestinationKey");

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}",
                                                 S3Transforms.ToStringValue(destinationKey));

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
                var isAccessPoint = S3ArnUtils.IsS3AccessPointsArn(bucket) || S3ArnUtils.IsS3OutpostsArn(bucket);
                // 'object/' needed appended to key for copy header with access points
                source = AmazonS3Util.UrlEncode(String.Concat(bucket, isAccessPoint ? "/object/" : "/", key), !isAccessPoint);
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

        private static CopyPartRequestMarshaller _instance;

	    public static CopyPartRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new CopyPartRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

