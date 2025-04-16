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
    /// CopyPart Request Marshaller
    /// </summary>       
    public class CopyPartRequestMarshaller : IMarshaller<IRequest, CopyPartRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyPartRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyPartRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetCopySourceIfMatch()) 
            {
                request.Headers["x-amz-copy-source-if-match"] = publicRequest.CopySourceIfMatch;
            }
        
            if (publicRequest.IsSetCopySourceIfModifiedSince()) 
            {
                request.Headers["x-amz-copy-source-if-modified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.CopySourceIfModifiedSince);
            }
        
            if (publicRequest.IsSetCopySourceIfNoneMatch()) 
            {
                request.Headers["x-amz-copy-source-if-none-match"] = publicRequest.CopySourceIfNoneMatch;
            }
        
            if (publicRequest.IsSetCopySourceIfUnmodifiedSince()) 
            {
                request.Headers["x-amz-copy-source-if-unmodified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.CopySourceIfUnmodifiedSince);
            }
        
            if (publicRequest.IsSetCopySourceRange()) 
            {
                request.Headers["x-amz-copy-source-range"] = publicRequest.CopySourceRange;
            }
        
            if (publicRequest.IsSetCopySourceSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-algorithm"] = publicRequest.CopySourceSSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetCopySourceSSECustomerKey()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-key"] = publicRequest.CopySourceSSECustomerKey;
            }
        
            if (publicRequest.IsSetCopySourceSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-key-MD5"] = publicRequest.CopySourceSSECustomerKeyMD5;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetExpectedSourceBucketOwner()) 
            {
                request.Headers["x-amz-source-expected-bucket-owner"] = publicRequest.ExpectedSourceBucketOwner;
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
            if (!publicRequest.IsSetDestinationBucket())
                throw new AmazonS3Exception("Request object does not have required field DestinationBucket set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.DestinationBucket));
            
            if (publicRequest.IsSetPartNumber())
                request.Parameters.Add("partNumber", StringUtils.FromInt(publicRequest.PartNumber));
            
            if (publicRequest.IsSetUploadId())
                request.Parameters.Add("uploadId", StringUtils.FromString(publicRequest.UploadId));
            request.ResourcePath = "/{Bucket}/{Key+}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("UploadPartCopyRequest", "");
                if(publicRequest.IsSetDestinationBucket())
                    xmlWriter.WriteElementString("DestinationBucket", StringUtils.FromString(publicRequest.DestinationBucket));

                if(publicRequest.IsSetDestinationKey())
                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequest.DestinationKey));

                if(publicRequest.IsSetSourceBucket())
                    xmlWriter.WriteElementString("SourceBucket", StringUtils.FromString(publicRequest.SourceBucket));

                if(publicRequest.IsSetSourceKey())
                    xmlWriter.WriteElementString("x-amz-copy-source", StringUtils.FromString(publicRequest.SourceKey));

                if(publicRequest.IsSetSourceVersionId())
                    xmlWriter.WriteElementString("SourceVersionId", StringUtils.FromString(publicRequest.SourceVersionId));


                xmlWriter.WriteEndElement();
            }
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
        private static CopyPartRequestMarshaller _instance = new CopyPartRequestMarshaller();        

        internal static CopyPartRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyPartRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}