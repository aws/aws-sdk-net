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

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOriginRequestPolicy Request Marshaller
    /// </summary>       
    public class CreateOriginRequestPolicyRequestMarshaller : IMarshaller<IRequest, CreateOriginRequestPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOriginRequestPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOriginRequestPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/origin-request-policy";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetOriginRequestPolicyConfig())
                {
                    xmlWriter.WriteStartElement("OriginRequestPolicyConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.OriginRequestPolicyConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.Comment));                    

                
                    if (publicRequest.OriginRequestPolicyConfig.CookiesConfig != null) 
                    {
                        xmlWriter.WriteStartElement("CookiesConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        if(publicRequest.OriginRequestPolicyConfig.CookiesConfig.IsSetCookieBehavior())
                            xmlWriter.WriteElementString("CookieBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.CookiesConfig.CookieBehavior));                 

                
                        if (publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies != null) 
                        {
                            xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems = publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies.Items;
                            if (publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems != null && publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItemsValue in publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItems) 
                                {
                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestOriginRequestPolicyConfigCookiesConfigCookiesItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.OriginRequestPolicyConfig.CookiesConfig.Cookies.Quantity));                 

                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                
                    if (publicRequest.OriginRequestPolicyConfig.HeadersConfig != null) 
                    {
                        xmlWriter.WriteStartElement("HeadersConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        if(publicRequest.OriginRequestPolicyConfig.HeadersConfig.IsSetHeaderBehavior())
                            xmlWriter.WriteElementString("HeaderBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.HeadersConfig.HeaderBehavior));                 

                
                        if (publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers != null) 
                        {
                            xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems = publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers.Items;
                            if (publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems != null && publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItemsValue in publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItems) 
                                {
                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestOriginRequestPolicyConfigHeadersConfigHeadersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.OriginRequestPolicyConfig.HeadersConfig.Headers.Quantity));                 

                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.OriginRequestPolicyConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.Name));                    

                
                    if (publicRequest.OriginRequestPolicyConfig.QueryStringsConfig != null) 
                    {
                        xmlWriter.WriteStartElement("QueryStringsConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        if(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.IsSetQueryStringBehavior())
                            xmlWriter.WriteElementString("QueryStringBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStringBehavior));                 

                
                        if (publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings != null) 
                        {
                            xmlWriter.WriteStartElement("QueryStrings", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems = publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings.Items;
                            if (publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems != null && publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItemsValue in publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItems) 
                                {
                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestOriginRequestPolicyConfigQueryStringsConfigQueryStringsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.OriginRequestPolicyConfig.QueryStringsConfig.QueryStrings.Quantity));                 

                            xmlWriter.WriteEndElement();
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static CreateOriginRequestPolicyRequestMarshaller _instance = new CreateOriginRequestPolicyRequestMarshaller();        

        internal static CreateOriginRequestPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOriginRequestPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}