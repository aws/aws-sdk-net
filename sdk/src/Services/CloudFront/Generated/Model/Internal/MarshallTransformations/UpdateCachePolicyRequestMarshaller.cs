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
    /// UpdateCachePolicy Request Marshaller
    /// </summary>       
    public class UpdateCachePolicyRequestMarshaller : IMarshaller<IRequest, UpdateCachePolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCachePolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCachePolicyRequest publicRequest)
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
            request.ResourcePath = "/2020-05-31/cache-policy/{Id}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetCachePolicyConfig())
                {
                    xmlWriter.WriteStartElement("CachePolicyConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.CachePolicyConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.CachePolicyConfig.Comment));                    

                    if(publicRequest.CachePolicyConfig.IsSetDefaultTTL())
                        xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.CachePolicyConfig.DefaultTTL));                    

                    if(publicRequest.CachePolicyConfig.IsSetMaxTTL())
                        xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.CachePolicyConfig.MaxTTL));                    

                    if(publicRequest.CachePolicyConfig.IsSetMinTTL())
                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.CachePolicyConfig.MinTTL));                    

                    if(publicRequest.CachePolicyConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.CachePolicyConfig.Name));                    

                
                    if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin != null) 
                    {
                        xmlWriter.WriteStartElement("ParametersInCacheKeyAndForwardedToOrigin", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                
                        if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig != null) 
                        {
                            xmlWriter.WriteStartElement("CookiesConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig.IsSetCookieBehavior())
                                xmlWriter.WriteElementString("CookieBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig.CookieBehavior));                 

                
                            if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig.Cookies != null) 
                            {
                                xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesItems = publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig.Cookies.Items;
                                if (publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesItems != null && publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesItemsValue in publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig.Cookies.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.CookiesConfig.Cookies.Quantity));                 

                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.IsSetEnableAcceptEncodingBrotli())
                            xmlWriter.WriteElementString("EnableAcceptEncodingBrotli", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.EnableAcceptEncodingBrotli));                 

                        if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.IsSetEnableAcceptEncodingGzip())
                            xmlWriter.WriteElementString("EnableAcceptEncodingGzip", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.EnableAcceptEncodingGzip));                 

                
                        if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig != null) 
                        {
                            xmlWriter.WriteStartElement("HeadersConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig.IsSetHeaderBehavior())
                                xmlWriter.WriteElementString("HeaderBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig.HeaderBehavior));                 

                
                            if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig.Headers != null) 
                            {
                                xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginHeadersConfigHeadersItems = publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig.Headers.Items;
                                if (publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginHeadersConfigHeadersItems != null && publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginHeadersConfigHeadersItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginHeadersConfigHeadersItemsValue in publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginHeadersConfigHeadersItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginHeadersConfigHeadersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig.Headers.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.HeadersConfig.Headers.Quantity));                 

                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                
                        if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig != null) 
                        {
                            xmlWriter.WriteStartElement("QueryStringsConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig.IsSetQueryStringBehavior())
                                xmlWriter.WriteElementString("QueryStringBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig.QueryStringBehavior));                 

                
                            if (publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig.QueryStrings != null) 
                            {
                                xmlWriter.WriteStartElement("QueryStrings", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStringsItems = publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig.QueryStrings.Items;
                                if (publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStringsItems != null && publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStringsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStringsItemsValue in publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStringsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestCachePolicyConfigParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStringsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig.QueryStrings.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.CachePolicyConfig.ParametersInCacheKeyAndForwardedToOrigin.QueryStringsConfig.QueryStrings.Quantity));                 

                                xmlWriter.WriteEndElement();
                            }
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
        private static UpdateCachePolicyRequestMarshaller _instance = new UpdateCachePolicyRequestMarshaller();        

        internal static UpdateCachePolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCachePolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}