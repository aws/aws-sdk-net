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
    /// DeleteObjects Request Marshaller
    /// </summary>       
    public partial class DeleteObjectsRequestMarshaller : IMarshaller<IRequest, DeleteObjectsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteObjectsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteObjectsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
            request.AddSubResource("delete");
        
            if (publicRequest.IsSetBypassGovernanceRetention()) 
            {
                request.Headers["x-amz-bypass-governance-retention"] = StringUtils.FromBool(publicRequest.BypassGovernanceRetention);
            }
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetMfaCodes()) 
            {
                MfaCodesCustomMarshall(request, publicRequest);
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteObjectsRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                    xmlWriter.WriteStartElement("Delete", "http://s3.amazonaws.com/doc/2006-03-01/");
                    var publicRequestObjects = publicRequest.Objects;
                    if (publicRequest.IsSetObjects()) 
                    {
                        foreach (var publicRequestObjectsValue in publicRequestObjects) 
                        {
                            if (publicRequestObjectsValue != null)
                            {
                                xmlWriter.WriteStartElement("Object");
                                if(publicRequestObjectsValue.IsSetETag())
                                    xmlWriter.WriteElementString("ETag", StringUtils.FromString(publicRequestObjectsValue.ETag));
                                if(publicRequestObjectsValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestObjectsValue.Key));
                                if(publicRequestObjectsValue.IsSetLastModifiedTime())
                                    xmlWriter.WriteElementString("LastModifiedTime", StringUtils.FromDateTimeToRFC822(publicRequestObjectsValue.LastModifiedTime.Value));
                                if(publicRequestObjectsValue.IsSetSize())
                                    xmlWriter.WriteElementString("Size", StringUtils.FromLong(publicRequestObjectsValue.Size.Value));
                                if(publicRequestObjectsValue.IsSetVersionId())
                                    xmlWriter.WriteElementString("VersionId", StringUtils.FromString(publicRequestObjectsValue.VersionId));
                                xmlWriter.WriteEndElement();
                            }
                        }            
                    }
                    if(publicRequest.IsSetQuiet())
                        xmlWriter.WriteElementString("Quiet", StringUtils.FromBool(publicRequest.Quiet.Value));


                    xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetChecksumData(
                    request,
                    publicRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: true,
                    headerName: "x-amz-sdk-checksum-algorithm"
                );
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static DeleteObjectsRequestMarshaller _instance = new DeleteObjectsRequestMarshaller();        

        internal static DeleteObjectsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteObjectsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, DeleteObjectsRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, DeleteObjectsRequest publicRequest);
    }    
}