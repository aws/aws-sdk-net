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
    /// CreateResponseHeadersPolicy Request Marshaller
    /// </summary>       
    public partial class CreateResponseHeadersPolicyRequestMarshaller : IMarshaller<IRequest, CreateResponseHeadersPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateResponseHeadersPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateResponseHeadersPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/response-headers-policy";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetResponseHeadersPolicyConfig())
                {
                    xmlWriter.WriteStartElement("ResponseHeadersPolicyConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.ResponseHeadersPolicyConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.ResponseHeadersPolicyConfig.Comment));

                    if (publicRequest.ResponseHeadersPolicyConfig.CorsConfig != null)
                    {
                        xmlWriter.WriteStartElement("CorsConfig");
                        if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.IsSetAccessControlAllowCredentials())
                            xmlWriter.WriteElementString("AccessControlAllowCredentials", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowCredentials.Value));
                        if (publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowHeaders != null)
                        {
                            xmlWriter.WriteStartElement("AccessControlAllowHeaders");
                            var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeadersItems = publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowHeaders.Items;
                            if (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeadersItems != null && (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeadersItemsValue in publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeadersItems) 
                                {
                                    xmlWriter.WriteStartElement("Header");
                                    xmlWriter.WriteValue(publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeadersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowHeaders.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowHeaders.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowMethods != null)
                        {
                            xmlWriter.WriteStartElement("AccessControlAllowMethods");
                            var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethodsItems = publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowMethods.Items;
                            if (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethodsItems != null && (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethodsItemsValue in publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethodsItems) 
                                {
                                    xmlWriter.WriteStartElement("Method");
                                    xmlWriter.WriteValue(publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethodsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowMethods.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowMethods.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowOrigins != null)
                        {
                            xmlWriter.WriteStartElement("AccessControlAllowOrigins");
                            var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowOriginsItems = publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowOrigins.Items;
                            if (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowOriginsItems != null && (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowOriginsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowOriginsItemsValue in publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowOriginsItems) 
                                {
                                    xmlWriter.WriteStartElement("Origin");
                                    xmlWriter.WriteValue(publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlAllowOriginsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowOrigins.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlAllowOrigins.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlExposeHeaders != null)
                        {
                            xmlWriter.WriteStartElement("AccessControlExposeHeaders");
                            var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeadersItems = publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlExposeHeaders.Items;
                            if (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeadersItems != null && (publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeadersItemsValue in publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeadersItems) 
                                {
                                    xmlWriter.WriteStartElement("Header");
                                    xmlWriter.WriteValue(publicRequestResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeadersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlExposeHeaders.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlExposeHeaders.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.IsSetAccessControlMaxAgeSec())
                            xmlWriter.WriteElementString("AccessControlMaxAgeSec", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.AccessControlMaxAgeSec.Value));
                        if(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.IsSetOriginOverride())
                            xmlWriter.WriteElementString("OriginOverride", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.CorsConfig.OriginOverride.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.ResponseHeadersPolicyConfig.CustomHeadersConfig != null)
                    {
                        xmlWriter.WriteStartElement("CustomHeadersConfig");
                        var publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItems = publicRequest.ResponseHeadersPolicyConfig.CustomHeadersConfig.Items;
                        if (publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItems != null && (publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue in publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItems) 
                            {
                            if (publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("ResponseHeadersPolicyCustomHeader");
                                if(publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue.IsSetHeader())
                                    xmlWriter.WriteElementString("Header", StringUtils.FromString(publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue.Header));
                                if(publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue.IsSetOverride())
                                    xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue.Override.Value));
                                if(publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestResponseHeadersPolicyConfigCustomHeadersConfigItemsValue.Value));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.ResponseHeadersPolicyConfig.CustomHeadersConfig.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.CustomHeadersConfig.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.ResponseHeadersPolicyConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.ResponseHeadersPolicyConfig.Name));

                    if (publicRequest.ResponseHeadersPolicyConfig.RemoveHeadersConfig != null)
                    {
                        xmlWriter.WriteStartElement("RemoveHeadersConfig");
                        var publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItems = publicRequest.ResponseHeadersPolicyConfig.RemoveHeadersConfig.Items;
                        if (publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItems != null && (publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItemsValue in publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItems) 
                            {
                            if (publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("ResponseHeadersPolicyRemoveHeader");
                                if(publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItemsValue.IsSetHeader())
                                    xmlWriter.WriteElementString("Header", StringUtils.FromString(publicRequestResponseHeadersPolicyConfigRemoveHeadersConfigItemsValue.Header));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.ResponseHeadersPolicyConfig.RemoveHeadersConfig.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.RemoveHeadersConfig.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig != null)
                    {
                        xmlWriter.WriteStartElement("SecurityHeadersConfig");
                        if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentSecurityPolicy != null)
                        {
                            xmlWriter.WriteStartElement("ContentSecurityPolicy");
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentSecurityPolicy.IsSetContentSecurityPolicy())
                                xmlWriter.WriteElementString("ContentSecurityPolicy", StringUtils.FromString(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentSecurityPolicy.ContentSecurityPolicy));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentSecurityPolicy.IsSetOverride())
                                xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentSecurityPolicy.Override.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentTypeOptions != null)
                        {
                            xmlWriter.WriteStartElement("ContentTypeOptions");
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentTypeOptions.IsSetOverride())
                                xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ContentTypeOptions.Override.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.FrameOptions != null)
                        {
                            xmlWriter.WriteStartElement("FrameOptions");
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.FrameOptions.IsSetFrameOption())
                                xmlWriter.WriteElementString("FrameOption", StringUtils.FromString(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.FrameOptions.FrameOption));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.FrameOptions.IsSetOverride())
                                xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.FrameOptions.Override.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ReferrerPolicy != null)
                        {
                            xmlWriter.WriteStartElement("ReferrerPolicy");
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ReferrerPolicy.IsSetOverride())
                                xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ReferrerPolicy.Override.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ReferrerPolicy.IsSetReferrerPolicy())
                                xmlWriter.WriteElementString("ReferrerPolicy", StringUtils.FromString(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.ReferrerPolicy.ReferrerPolicy));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity != null)
                        {
                            xmlWriter.WriteStartElement("StrictTransportSecurity");
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.IsSetAccessControlMaxAgeSec())
                                xmlWriter.WriteElementString("AccessControlMaxAgeSec", StringUtils.FromInt(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.AccessControlMaxAgeSec.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.IsSetIncludeSubdomains())
                                xmlWriter.WriteElementString("IncludeSubdomains", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.IncludeSubdomains.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.IsSetOverride())
                                xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.Override.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.IsSetPreload())
                                xmlWriter.WriteElementString("Preload", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.StrictTransportSecurity.Preload.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection != null)
                        {
                            xmlWriter.WriteStartElement("XSSProtection");
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.IsSetModeBlock())
                                xmlWriter.WriteElementString("ModeBlock", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.ModeBlock.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.IsSetOverride())
                                xmlWriter.WriteElementString("Override", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.Override.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.IsSetProtection())
                                xmlWriter.WriteElementString("Protection", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.Protection.Value));
                            if(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.IsSetReportUri())
                                xmlWriter.WriteElementString("ReportUri", StringUtils.FromString(publicRequest.ResponseHeadersPolicyConfig.SecurityHeadersConfig.XSSProtection.ReportUri));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.ResponseHeadersPolicyConfig.ServerTimingHeadersConfig != null)
                    {
                        xmlWriter.WriteStartElement("ServerTimingHeadersConfig");
                        if(publicRequest.ResponseHeadersPolicyConfig.ServerTimingHeadersConfig.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.ResponseHeadersPolicyConfig.ServerTimingHeadersConfig.Enabled.Value));
                        if(publicRequest.ResponseHeadersPolicyConfig.ServerTimingHeadersConfig.IsSetSamplingRate())
                            xmlWriter.WriteElementString("SamplingRate", StringUtils.FromDouble(publicRequest.ResponseHeadersPolicyConfig.ServerTimingHeadersConfig.SamplingRate.Value));
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
        private static CreateResponseHeadersPolicyRequestMarshaller _instance = new CreateResponseHeadersPolicyRequestMarshaller();        

        internal static CreateResponseHeadersPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateResponseHeadersPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateResponseHeadersPolicyRequest publicRequest);
    }    
}