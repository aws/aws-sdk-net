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
    /// PutCORSConfiguration Request Marshaller
    /// </summary>       
    public class PutCORSConfigurationRequestMarshaller : IMarshaller<IRequest, PutCORSConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutCORSConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutCORSConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("cors");
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetContentMD5()) 
            {
                request.Headers["Content-MD5"] = publicRequest.ContentMD5;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetConfiguration())
                {
                    xmlWriter.WriteStartElement("CORSConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    var publicRequestConfigurationCORSRules = publicRequest.Configuration.CORSRules;
                    if (publicRequestConfigurationCORSRules != null && (publicRequestConfigurationCORSRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("CORSRule");
                        foreach (var publicRequestConfigurationCORSRulesValue in publicRequestConfigurationCORSRules) 
                        {
                        if (publicRequestConfigurationCORSRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            var publicRequestConfigurationCORSRulesValueAllowedHeaders = publicRequestConfigurationCORSRulesValue.AllowedHeaders;
                            if (publicRequestConfigurationCORSRulesValueAllowedHeaders != null && (publicRequestConfigurationCORSRulesValueAllowedHeaders.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("AllowedHeader");
                                foreach (var publicRequestConfigurationCORSRulesValueAllowedHeadersValue in publicRequestConfigurationCORSRulesValueAllowedHeaders) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestConfigurationCORSRulesValueAllowedHeadersValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestConfigurationCORSRulesValueAllowedMethods = publicRequestConfigurationCORSRulesValue.AllowedMethods;
                            if (publicRequestConfigurationCORSRulesValueAllowedMethods != null && (publicRequestConfigurationCORSRulesValueAllowedMethods.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("AllowedMethod");
                                foreach (var publicRequestConfigurationCORSRulesValueAllowedMethodsValue in publicRequestConfigurationCORSRulesValueAllowedMethods) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestConfigurationCORSRulesValueAllowedMethodsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestConfigurationCORSRulesValueAllowedOrigins = publicRequestConfigurationCORSRulesValue.AllowedOrigins;
                            if (publicRequestConfigurationCORSRulesValueAllowedOrigins != null && (publicRequestConfigurationCORSRulesValueAllowedOrigins.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("AllowedOrigin");
                                foreach (var publicRequestConfigurationCORSRulesValueAllowedOriginsValue in publicRequestConfigurationCORSRulesValueAllowedOrigins) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestConfigurationCORSRulesValueAllowedOriginsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestConfigurationCORSRulesValueExposeHeaders = publicRequestConfigurationCORSRulesValue.ExposeHeaders;
                            if (publicRequestConfigurationCORSRulesValueExposeHeaders != null && (publicRequestConfigurationCORSRulesValueExposeHeaders.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("ExposeHeader");
                                foreach (var publicRequestConfigurationCORSRulesValueExposeHeadersValue in publicRequestConfigurationCORSRulesValueExposeHeaders) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestConfigurationCORSRulesValueExposeHeadersValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequestConfigurationCORSRulesValue.IsSetID())
                                xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestConfigurationCORSRulesValue.ID));
                            if(publicRequestConfigurationCORSRulesValue.IsSetMaxAgeSeconds())
                                xmlWriter.WriteElementString("MaxAgeSeconds", StringUtils.FromInt(publicRequestConfigurationCORSRulesValue.MaxAgeSeconds.Value));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                if (publicRequest.IsSetContentMD5())
                    request.Headers[Amazon.Util.HeaderKeys.ContentMD5Header] = publicRequest.ContentMD5;
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
        private static PutCORSConfigurationRequestMarshaller _instance = new PutCORSConfigurationRequestMarshaller();        

        internal static PutCORSConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutCORSConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}