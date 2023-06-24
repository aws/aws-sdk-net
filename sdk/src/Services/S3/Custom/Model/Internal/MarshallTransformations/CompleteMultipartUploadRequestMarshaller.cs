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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Complete Multipart Upload Request Marshaller
    /// </summary>       
    public class CompleteMultipartUploadRequestMarshaller : IMarshaller<IRequest, CompleteMultipartUploadRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((CompleteMultipartUploadRequest)input);
		}

        public IRequest Marshall(CompleteMultipartUploadRequest completeMultipartUploadRequest)
        {
            IRequest request = new DefaultRequest(completeMultipartUploadRequest, "AmazonS3");

            request.HttpMethod = "POST";

            if (completeMultipartUploadRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(completeMultipartUploadRequest.RequestPayer.ToString()));

            if (completeMultipartUploadRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(completeMultipartUploadRequest.ExpectedBucketOwner));

            if (completeMultipartUploadRequest.IsSetChecksumCRC32())
                request.Headers["x-amz-checksum-crc32"] = completeMultipartUploadRequest.ChecksumCRC32;

            if (completeMultipartUploadRequest.IsSetChecksumCRC32C())
                request.Headers["x-amz-checksum-crc32c"] = completeMultipartUploadRequest.ChecksumCRC32C;

            if (completeMultipartUploadRequest.IsSetChecksumSHA1())
                request.Headers["x-amz-checksum-sha1"] = completeMultipartUploadRequest.ChecksumSHA1;

            if (completeMultipartUploadRequest.IsSetChecksumSHA256())
                request.Headers["x-amz-checksum-sha256"] = completeMultipartUploadRequest.ChecksumSHA256;

            if (completeMultipartUploadRequest.IsSetSSECustomerAlgorithm())
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = completeMultipartUploadRequest.SSECustomerAlgorithm;

            if (completeMultipartUploadRequest.IsSetSSECustomerKey())
                request.Headers["x-amz-server-side-encryption-customer-key"] = completeMultipartUploadRequest.SSECustomerKey;

            if (completeMultipartUploadRequest.IsSetSSECustomerKeyMD5())
                request.Headers["x-amz-server-side-encryption-customer-key-MD5"] = completeMultipartUploadRequest.SSECustomerKeyMD5;

            if (string.IsNullOrEmpty(completeMultipartUploadRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "CompleteMultipartUploadRequest.BucketName");
            if (string.IsNullOrEmpty(completeMultipartUploadRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "CompleteMultipartUploadRequest.Key");

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}",
                                                 S3Transforms.ToStringValue(completeMultipartUploadRequest.Key));

            request.AddSubResource("uploadId", S3Transforms.ToStringValue(completeMultipartUploadRequest.UploadId));

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                xmlWriter.WriteStartElement("CompleteMultipartUpload", S3Constants.S3RequestXmlNamespace);
                var multipartUploadMultipartUploadpartsList = completeMultipartUploadRequest.PartETags;
                multipartUploadMultipartUploadpartsList.Sort();

                if (multipartUploadMultipartUploadpartsList != null && multipartUploadMultipartUploadpartsList.Count > 0)
                {
                    foreach (var multipartUploadMultipartUploadpartsListValue in multipartUploadMultipartUploadpartsList)
                    {
                        xmlWriter.WriteStartElement("Part");
                        if (multipartUploadMultipartUploadpartsListValue.IsSetETag())
                        {
                            xmlWriter.WriteElementString("ETag", 
                                                         S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.ETag));
                        }
                        if (multipartUploadMultipartUploadpartsListValue.IsSetPartNumber())
                        {
                            xmlWriter.WriteElementString("PartNumber", 
                                                         S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.PartNumber));
                        }
                        if (multipartUploadMultipartUploadpartsListValue.IsSetChecksumCRC32())
                        {
                            xmlWriter.WriteElementString("ChecksumCRC32", 
                                S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.ChecksumCRC32));
                        }
                        if (multipartUploadMultipartUploadpartsListValue.IsSetChecksumCRC32C())
                        {
                            xmlWriter.WriteElementString("ChecksumCRC32C", 
                                S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.ChecksumCRC32C));
                        }

                        if (multipartUploadMultipartUploadpartsListValue.IsSetChecksumSHA1())
                        {
                            xmlWriter.WriteElementString("ChecksumSHA1", 
                                S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.ChecksumSHA1));
                        }

                        if (multipartUploadMultipartUploadpartsListValue.IsSetChecksumSHA256())
                        {
                            xmlWriter.WriteElementString("ChecksumSHA256", 
                                S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.ChecksumSHA256));
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                var checksum = AWSSDKUtils.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

	    private static CompleteMultipartUploadRequestMarshaller _instance;

	    public static CompleteMultipartUploadRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new CompleteMultipartUploadRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

