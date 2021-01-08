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

using System.Globalization;
using System.IO;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Part Request Marshaller
    /// </summary>       
    public class UploadPartRequestMarshaller : IMarshaller<IRequest, UploadPartRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((UploadPartRequest)input);
		}

        public IRequest Marshall(UploadPartRequest uploadPartRequest)
        {
            IRequest request = new DefaultRequest(uploadPartRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (uploadPartRequest.IsSetMD5Digest())
                request.Headers[HeaderKeys.ContentMD5Header] = uploadPartRequest.MD5Digest;

            if (uploadPartRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, uploadPartRequest.ServerSideEncryptionCustomerMethod);
            if (uploadPartRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, uploadPartRequest.ServerSideEncryptionCustomerProvidedKey);
                if (uploadPartRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, uploadPartRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(uploadPartRequest.ServerSideEncryptionCustomerProvidedKey));
            }
            if (uploadPartRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(uploadPartRequest.RequestPayer.ToString()));

            if (uploadPartRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(uploadPartRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(uploadPartRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "UploadPartRequest.BucketName");
            if (string.IsNullOrEmpty(uploadPartRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "UploadPartRequest.Key");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(uploadPartRequest.BucketName),
                                                 S3Transforms.ToStringValue(uploadPartRequest.Key));

            if (uploadPartRequest.IsSetPartNumber())
                request.AddSubResource("partNumber", S3Transforms.ToStringValue(uploadPartRequest.PartNumber));
            if (uploadPartRequest.IsSetUploadId())
                request.AddSubResource("uploadId", S3Transforms.ToStringValue(uploadPartRequest.UploadId));

            if (uploadPartRequest.InputStream != null)
            {
                // Wrap input stream in partial wrapper (to upload only part of the stream)
                var partialStream = new PartialWrapperStream(uploadPartRequest.InputStream, uploadPartRequest.PartSize);
                if (partialStream.Length > 0 && !(uploadPartRequest.DisablePayloadSigning ?? false))
                    request.UseChunkEncoding = uploadPartRequest.UseChunkEncoding;
                if (!request.Headers.ContainsKey(HeaderKeys.ContentLengthHeader))
                    request.Headers.Add(HeaderKeys.ContentLengthHeader, partialStream.Length.ToString(CultureInfo.InvariantCulture));

                request.DisablePayloadSigning = uploadPartRequest.DisablePayloadSigning;

                if (!(uploadPartRequest.DisableMD5Stream ?? AWSConfigsS3.DisableMD5Stream))
                {
                    // Wrap input stream in MD5Stream; after this we can no longer seek or position the stream
                    var hashStream = new MD5Stream(partialStream, null, partialStream.Length);
                    uploadPartRequest.InputStream = hashStream;
                }
                else
                {
                    uploadPartRequest.InputStream = partialStream;
                }
            }

            request.ContentStream = uploadPartRequest.InputStream;

            if (!request.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                request.Headers.Add(HeaderKeys.ContentTypeHeader, "text/plain");

            return request;
        }

	    private static UploadPartRequestMarshaller _instance;

	    public static UploadPartRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new UploadPartRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

