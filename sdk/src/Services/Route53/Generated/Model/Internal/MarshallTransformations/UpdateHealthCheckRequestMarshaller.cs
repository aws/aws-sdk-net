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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateHealthCheck Request Marshaller
    /// </summary>       
    public class UpdateHealthCheckRequestMarshaller : IMarshaller<IRequest, UpdateHealthCheckRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateHealthCheckRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateHealthCheckRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            if (!publicRequest.IsSetHealthCheckId())
                throw new AmazonRoute53Exception("Request object does not have required field HealthCheckId set");
            request.AddPathResource("{HealthCheckId}", StringUtils.FromString(publicRequest.HealthCheckId));
            request.ResourcePath = "/2013-04-01/healthcheck/{HealthCheckId}";
            request.MarshallerVersion = 2;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("UpdateHealthCheckRequest", "https://route53.amazonaws.com/doc/2013-04-01/");    
                if(publicRequest.IsSetHealthCheckVersion())
                    xmlWriter.WriteElementString("HealthCheckVersion", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromLong(publicRequest.HealthCheckVersion));                    

                if(publicRequest.IsSetIPAddress())
                    xmlWriter.WriteElementString("IPAddress", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.IPAddress));                    

                if(publicRequest.IsSetPort())
                    xmlWriter.WriteElementString("Port", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.Port));                    

                if(publicRequest.IsSetResourcePath())
                    xmlWriter.WriteElementString("ResourcePath", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.ResourcePath));                    

                if(publicRequest.IsSetFullyQualifiedDomainName())
                    xmlWriter.WriteElementString("FullyQualifiedDomainName", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.FullyQualifiedDomainName));                    

                if(publicRequest.IsSetSearchString())
                    xmlWriter.WriteElementString("SearchString", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.SearchString));                    

                if(publicRequest.IsSetFailureThreshold())
                    xmlWriter.WriteElementString("FailureThreshold", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.FailureThreshold));                    

                if(publicRequest.IsSetInverted())
                    xmlWriter.WriteElementString("Inverted", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequest.Inverted));                    

                if(publicRequest.IsSetDisabled())
                    xmlWriter.WriteElementString("Disabled", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequest.Disabled));                    

                if(publicRequest.IsSetHealthThreshold())
                    xmlWriter.WriteElementString("HealthThreshold", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.HealthThreshold));                    

                var publicRequestChildHealthChecks = publicRequest.ChildHealthChecks;
                if (publicRequestChildHealthChecks != null && publicRequestChildHealthChecks.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("ChildHealthChecks", "https://route53.amazonaws.com/doc/2013-04-01/");
                    foreach (var publicRequestChildHealthChecksValue in publicRequestChildHealthChecks) 
                    {
                        xmlWriter.WriteStartElement("ChildHealthCheck", "https://route53.amazonaws.com/doc/2013-04-01/");
                        xmlWriter.WriteValue(publicRequestChildHealthChecksValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetEnableSNI())
                    xmlWriter.WriteElementString("EnableSNI", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequest.EnableSNI));                    

                var publicRequestRegions = publicRequest.Regions;
                if (publicRequestRegions != null && publicRequestRegions.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("Regions", "https://route53.amazonaws.com/doc/2013-04-01/");
                    foreach (var publicRequestRegionsValue in publicRequestRegions) 
                    {
                        xmlWriter.WriteStartElement("Region", "https://route53.amazonaws.com/doc/2013-04-01/");
                        xmlWriter.WriteValue(publicRequestRegionsValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                
                if (publicRequest.AlarmIdentifier != null) 
                {
                    xmlWriter.WriteStartElement("AlarmIdentifier", "https://route53.amazonaws.com/doc/2013-04-01/");            
                    if(publicRequest.AlarmIdentifier.IsSetRegion())
                        xmlWriter.WriteElementString("Region", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.AlarmIdentifier.Region));                 
    
                    if(publicRequest.AlarmIdentifier.IsSetName())
                        xmlWriter.WriteElementString("Name", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.AlarmIdentifier.Name));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetInsufficientDataHealthStatus())
                    xmlWriter.WriteElementString("InsufficientDataHealthStatus", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.InsufficientDataHealthStatus));                    

                var publicRequestResetElements = publicRequest.ResetElements;
                if (publicRequestResetElements != null && publicRequestResetElements.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("ResetElements", "https://route53.amazonaws.com/doc/2013-04-01/");
                    foreach (var publicRequestResetElementsValue in publicRequestResetElements) 
                    {
                        xmlWriter.WriteStartElement("ResettableElementName", "https://route53.amazonaws.com/doc/2013-04-01/");
                        xmlWriter.WriteValue(publicRequestResetElementsValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static UpdateHealthCheckRequestMarshaller _instance = new UpdateHealthCheckRequestMarshaller();        

        internal static UpdateHealthCheckRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateHealthCheckRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}