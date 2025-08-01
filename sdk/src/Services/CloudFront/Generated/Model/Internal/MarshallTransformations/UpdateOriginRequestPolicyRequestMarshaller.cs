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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOriginRequestPolicy Request Marshaller
    /// </summary>       
    public partial class UpdateOriginRequestPolicyRequestMarshaller : IMarshaller<IRequest, UpdateOriginRequestPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOriginRequestPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOriginRequestPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
            if (!publicRequest.IsSetId())
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2020-05-31/origin-request-policy/{Id}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetOriginRequestPolicyConfig())
                {
                    xmlWriter.WriteStartElement("OriginRequestPolicyConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.OriginRequestPolicyConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.Comment));

                    if (publicRequest.OriginRequestPolicyConfig.CookiesConfig != null)
                    {
                        xmlWriter.WriteStartElement("CookiesConfig");
                        if(publicRequest.OriginRequestPolicyConfig.CookiesConfig.IsSetCookieBehavior())
                            xmlWriter.WriteElementString("CookieBehavior", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.CookiesConfig.CookieBehavior));
                        if (publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies != null)
                        {
                            xmlWriter.WriteStartElement("Cookies");
                            var publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems = publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies.Items;
                            if (publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems != null && (publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItemsValue in publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems) 
                                {
                                    xmlWriter.WriteStartElement("Name");
                                    xmlWriter.WriteValue(publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.OriginRequestPolicyConfig.HeadersConfig != null)
                    {
                        xmlWriter.WriteStartElement("HeadersConfig");
                        if(publicRequest.OriginRequestPolicyConfig.HeadersConfig.IsSetHeaderBehavior())
                            xmlWriter.WriteElementString("HeaderBehavior", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.HeadersConfig.HeaderBehavior));
                        if (publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers != null)
                        {
                            xmlWriter.WriteStartElement("Headers");
                            var publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems = publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers.Items;
                            if (publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems != null && (publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItemsValue in publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems) 
                                {
                                    xmlWriter.WriteStartElement("Name");
                                    xmlWriter.WriteValue(publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.OriginRequestPolicyConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.Name));

                    if (publicRequest.OriginRequestPolicyConfig.QueryStringsConfig != null)
                    {
                        xmlWriter.WriteStartElement("QueryStringsConfig");
                        if(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.IsSetQueryStringBehavior())
                            xmlWriter.WriteElementString("QueryStringBehavior", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStringBehavior));
                        if (publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings != null)
                        {
                            xmlWriter.WriteStartElement("QueryStrings");
                            var publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems = publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings.Items;
                            if (publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems != null && (publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItemsValue in publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems) 
                                {
                                    xmlWriter.WriteStartElement("Name");
                                    xmlWriter.WriteValue(publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static UpdateOriginRequestPolicyRequestMarshaller _instance = new UpdateOriginRequestPolicyRequestMarshaller();        

        internal static UpdateOriginRequestPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOriginRequestPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateOriginRequestPolicyRequest publicRequest);
    }    
}