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
    public partial class PutCORSConfigurationRequestMarshaller : IMarshaller<IRequest, PutCORSConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutCORSConfigurationRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetConfiguration())
                {
                    xmlWriter.WriteStartElement("CORSConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    var publicRequestConfigurationRules = publicRequest.Configuration.Rules;
                    if (publicRequestConfigurationRules != null && (publicRequestConfigurationRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestConfigurationRulesValue in publicRequestConfigurationRules) 
                        {
                        if (publicRequestConfigurationRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("CORSRule");
                            var publicRequestConfigurationRulesValueAllowedHeaders = publicRequestConfigurationRulesValue.AllowedHeaders;
                            if (publicRequestConfigurationRulesValueAllowedHeaders != null && (publicRequestConfigurationRulesValueAllowedHeaders.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestConfigurationRulesValueAllowedHeadersValue in publicRequestConfigurationRulesValueAllowedHeaders) 
                                {
                                    xmlWriter.WriteStartElement("AllowedHeader");
                                    xmlWriter.WriteValue(publicRequestConfigurationRulesValueAllowedHeadersValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            var publicRequestConfigurationRulesValueAllowedMethods = publicRequestConfigurationRulesValue.AllowedMethods;
                            if (publicRequestConfigurationRulesValueAllowedMethods != null && (publicRequestConfigurationRulesValueAllowedMethods.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestConfigurationRulesValueAllowedMethodsValue in publicRequestConfigurationRulesValueAllowedMethods) 
                                {
                                    xmlWriter.WriteStartElement("AllowedMethod");
                                    xmlWriter.WriteValue(publicRequestConfigurationRulesValueAllowedMethodsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            var publicRequestConfigurationRulesValueAllowedOrigins = publicRequestConfigurationRulesValue.AllowedOrigins;
                            if (publicRequestConfigurationRulesValueAllowedOrigins != null && (publicRequestConfigurationRulesValueAllowedOrigins.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestConfigurationRulesValueAllowedOriginsValue in publicRequestConfigurationRulesValueAllowedOrigins) 
                                {
                                    xmlWriter.WriteStartElement("AllowedOrigin");
                                    xmlWriter.WriteValue(publicRequestConfigurationRulesValueAllowedOriginsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            var publicRequestConfigurationRulesValueExposeHeaders = publicRequestConfigurationRulesValue.ExposeHeaders;
                            if (publicRequestConfigurationRulesValueExposeHeaders != null && (publicRequestConfigurationRulesValueExposeHeaders.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestConfigurationRulesValueExposeHeadersValue in publicRequestConfigurationRulesValueExposeHeaders) 
                                {
                                    xmlWriter.WriteStartElement("ExposeHeader");
                                    xmlWriter.WriteValue(publicRequestConfigurationRulesValueExposeHeadersValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            if(publicRequestConfigurationRulesValue.IsSetId())
                                xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestConfigurationRulesValue.Id));
                            if(publicRequestConfigurationRulesValue.IsSetMaxAgeSeconds())
                                xmlWriter.WriteElementString("MaxAgeSeconds", StringUtils.FromInt(publicRequestConfigurationRulesValue.MaxAgeSeconds.Value));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                    }

                    xmlWriter.WriteEndElement();
                }
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutCORSConfigurationRequest publicRequest);
    }    
}