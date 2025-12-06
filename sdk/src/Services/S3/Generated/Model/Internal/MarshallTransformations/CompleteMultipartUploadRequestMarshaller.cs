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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CompleteMultipartUpload Request Marshaller
    /// </summary>       
    public partial class CompleteMultipartUploadRequestMarshaller : IMarshaller<IRequest, CompleteMultipartUploadRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CompleteMultipartUploadRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CompleteMultipartUploadRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetChecksumCRC32()) 
            {
                request.Headers["x-amz-checksum-crc32"] = publicRequest.ChecksumCRC32;
            }
        
            if (publicRequest.IsSetChecksumCRC32C()) 
            {
                request.Headers["x-amz-checksum-crc32c"] = publicRequest.ChecksumCRC32C;
            }
        
            if (publicRequest.IsSetChecksumCRC64NVME()) 
            {
                request.Headers["x-amz-checksum-crc64nvme"] = publicRequest.ChecksumCRC64NVME;
            }
        
            if (publicRequest.IsSetChecksumSHA1()) 
            {
                request.Headers["x-amz-checksum-sha1"] = publicRequest.ChecksumSHA1;
            }
        
            if (publicRequest.IsSetChecksumSHA256()) 
            {
                request.Headers["x-amz-checksum-sha256"] = publicRequest.ChecksumSHA256;
            }
        
            if (publicRequest.IsSetChecksumType()) 
            {
                request.Headers["x-amz-checksum-type"] = publicRequest.ChecksumType;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
        
            if (publicRequest.IsSetMpuObjectSize()) 
            {
                request.Headers["x-amz-mp-object-size"] = StringUtils.FromLong(publicRequest.MpuObjectSize);
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
        
            if (publicRequest.IsSetSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = publicRequest.SSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetSSECustomerKey()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key"] = publicRequest.SSECustomerKey;
            }
        
            if (publicRequest.IsSetSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key-MD5"] = publicRequest.SSECustomerKeyMD5;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "CompleteMultipartUploadRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "CompleteMultipartUploadRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            if (string.IsNullOrEmpty(publicRequest.UploadId))
                throw new AmazonS3Exception("Request object does not have required field UploadId set");
            
            if (publicRequest.IsSetUploadId())
                request.Parameters.Add("uploadId", StringUtils.FromString(publicRequest.UploadId));
            request.ResourcePath = "/{Key+}";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                SortPartsList(publicRequest);
                    xmlWriter.WriteStartElement("CompleteMultipartUpload", "http://s3.amazonaws.com/doc/2006-03-01/");
                    var publicRequestPartETags = publicRequest.PartETags;
                    if (publicRequestPartETags != null && (publicRequestPartETags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestPartETagsValue in publicRequestPartETags) 
                        {
                        if (publicRequestPartETagsValue != null)
                        {
                            xmlWriter.WriteStartElement("Part");
                            if(publicRequestPartETagsValue.IsSetChecksumCRC32())
                                xmlWriter.WriteElementString("ChecksumCRC32", StringUtils.FromString(publicRequestPartETagsValue.ChecksumCRC32));
                            if(publicRequestPartETagsValue.IsSetChecksumCRC32C())
                                xmlWriter.WriteElementString("ChecksumCRC32C", StringUtils.FromString(publicRequestPartETagsValue.ChecksumCRC32C));
                            if(publicRequestPartETagsValue.IsSetChecksumCRC64NVME())
                                xmlWriter.WriteElementString("ChecksumCRC64NVME", StringUtils.FromString(publicRequestPartETagsValue.ChecksumCRC64NVME));
                            if(publicRequestPartETagsValue.IsSetChecksumSHA1())
                                xmlWriter.WriteElementString("ChecksumSHA1", StringUtils.FromString(publicRequestPartETagsValue.ChecksumSHA1));
                            if(publicRequestPartETagsValue.IsSetChecksumSHA256())
                                xmlWriter.WriteElementString("ChecksumSHA256", StringUtils.FromString(publicRequestPartETagsValue.ChecksumSHA256));
                            if(publicRequestPartETagsValue.IsSetETag())
                                xmlWriter.WriteElementString("ETag", StringUtils.FromString(publicRequestPartETagsValue.ETag));
                            if(publicRequestPartETagsValue.IsSetPartNumber())
                                xmlWriter.WriteElementString("PartNumber", StringUtils.FromInt(publicRequestPartETagsValue.PartNumber.Value));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                    }

                    xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            request.UseQueryString = true;
            return request;
        }
        private static CompleteMultipartUploadRequestMarshaller _instance = new CompleteMultipartUploadRequestMarshaller();        

        internal static CompleteMultipartUploadRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompleteMultipartUploadRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CompleteMultipartUploadRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CompleteMultipartUploadRequest publicRequest);
    }    
}