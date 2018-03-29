/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// CreateHealthCheck Request Marshaller
    /// </summary>       
    public class CreateHealthCheckRequestMarshaller : IMarshaller<IRequest, CreateHealthCheckRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHealthCheckRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHealthCheckRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2013-04-01/healthcheck";
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("CreateHealthCheckRequest", "https://route53.amazonaws.com/doc/2013-04-01/");    
                if(publicRequest.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.CallerReference));                    

                
                if (publicRequest.HealthCheckConfig != null) 
                {
                    xmlWriter.WriteStartElement("HealthCheckConfig", "https://route53.amazonaws.com/doc/2013-04-01/");            
                    if(publicRequest.HealthCheckConfig.IsSetIPAddress())
                        xmlWriter.WriteElementString("IPAddress", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.IPAddress));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetPort())
                        xmlWriter.WriteElementString("Port", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.HealthCheckConfig.Port));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetType())
                        xmlWriter.WriteElementString("Type", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.Type));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetResourcePath())
                        xmlWriter.WriteElementString("ResourcePath", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.ResourcePath));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetFullyQualifiedDomainName())
                        xmlWriter.WriteElementString("FullyQualifiedDomainName", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.FullyQualifiedDomainName));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetSearchString())
                        xmlWriter.WriteElementString("SearchString", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.SearchString));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetRequestInterval())
                        xmlWriter.WriteElementString("RequestInterval", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.HealthCheckConfig.RequestInterval));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetFailureThreshold())
                        xmlWriter.WriteElementString("FailureThreshold", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.HealthCheckConfig.FailureThreshold));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetMeasureLatency())
                        xmlWriter.WriteElementString("MeasureLatency", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequest.HealthCheckConfig.MeasureLatency));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetInverted())
                        xmlWriter.WriteElementString("Inverted", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequest.HealthCheckConfig.Inverted));                 
    
                    if(publicRequest.HealthCheckConfig.IsSetHealthThreshold())
                        xmlWriter.WriteElementString("HealthThreshold", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.HealthCheckConfig.HealthThreshold));                 
    
                    var publicRequestHealthCheckConfigChildHealthChecks = publicRequest.HealthCheckConfig.ChildHealthChecks;
                    if (publicRequestHealthCheckConfigChildHealthChecks != null && publicRequestHealthCheckConfigChildHealthChecks.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("ChildHealthChecks", "https://route53.amazonaws.com/doc/2013-04-01/");
                        foreach (var publicRequestHealthCheckConfigChildHealthChecksValue in publicRequestHealthCheckConfigChildHealthChecks) 
                        {
                            xmlWriter.WriteStartElement("ChildHealthCheck", "https://route53.amazonaws.com/doc/2013-04-01/");
                            xmlWriter.WriteValue(publicRequestHealthCheckConfigChildHealthChecksValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.HealthCheckConfig.IsSetEnableSNI())
                        xmlWriter.WriteElementString("EnableSNI", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequest.HealthCheckConfig.EnableSNI));                 
    
                    var publicRequestHealthCheckConfigRegions = publicRequest.HealthCheckConfig.Regions;
                    if (publicRequestHealthCheckConfigRegions != null && publicRequestHealthCheckConfigRegions.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Regions", "https://route53.amazonaws.com/doc/2013-04-01/");
                        foreach (var publicRequestHealthCheckConfigRegionsValue in publicRequestHealthCheckConfigRegions) 
                        {
                            xmlWriter.WriteStartElement("Region", "https://route53.amazonaws.com/doc/2013-04-01/");
                            xmlWriter.WriteValue(publicRequestHealthCheckConfigRegionsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    
                    if (publicRequest.HealthCheckConfig.AlarmIdentifier != null) 
                    {
                        xmlWriter.WriteStartElement("AlarmIdentifier", "https://route53.amazonaws.com/doc/2013-04-01/");            
                        if(publicRequest.HealthCheckConfig.AlarmIdentifier.IsSetRegion())
                            xmlWriter.WriteElementString("Region", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.AlarmIdentifier.Region));                 
        
                        if(publicRequest.HealthCheckConfig.AlarmIdentifier.IsSetName())
                            xmlWriter.WriteElementString("Name", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.AlarmIdentifier.Name));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.HealthCheckConfig.IsSetInsufficientDataHealthStatus())
                        xmlWriter.WriteElementString("InsufficientDataHealthStatus", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HealthCheckConfig.InsufficientDataHealthStatus));                 
    
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static CreateHealthCheckRequestMarshaller _instance = new CreateHealthCheckRequestMarshaller();        

        internal static CreateHealthCheckRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHealthCheckRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}