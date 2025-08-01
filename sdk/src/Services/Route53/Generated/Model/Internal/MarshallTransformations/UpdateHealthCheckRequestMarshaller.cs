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

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateHealthCheck Request Marshaller
    /// </summary>       
    public partial class UpdateHealthCheckRequestMarshaller : IMarshaller<IRequest, UpdateHealthCheckRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("UpdateHealthCheckRequest", "https://route53.amazonaws.com/doc/2013-04-01/");
                if(publicRequest.IsSetHealthCheckVersion())
                    xmlWriter.WriteElementString("HealthCheckVersion", StringUtils.FromLong(publicRequest.HealthCheckVersion.Value));

                if(publicRequest.IsSetIPAddress())
                    xmlWriter.WriteElementString("IPAddress", StringUtils.FromString(publicRequest.IPAddress));

                if(publicRequest.IsSetPort())
                    xmlWriter.WriteElementString("Port", StringUtils.FromInt(publicRequest.Port.Value));

                if(publicRequest.IsSetResourcePath())
                    xmlWriter.WriteElementString("ResourcePath", StringUtils.FromString(publicRequest.ResourcePath));

                if(publicRequest.IsSetFullyQualifiedDomainName())
                    xmlWriter.WriteElementString("FullyQualifiedDomainName", StringUtils.FromString(publicRequest.FullyQualifiedDomainName));

                if(publicRequest.IsSetSearchString())
                    xmlWriter.WriteElementString("SearchString", StringUtils.FromString(publicRequest.SearchString));

                if(publicRequest.IsSetFailureThreshold())
                    xmlWriter.WriteElementString("FailureThreshold", StringUtils.FromInt(publicRequest.FailureThreshold.Value));

                if(publicRequest.IsSetInverted())
                    xmlWriter.WriteElementString("Inverted", StringUtils.FromBool(publicRequest.Inverted.Value));

                if(publicRequest.IsSetDisabled())
                    xmlWriter.WriteElementString("Disabled", StringUtils.FromBool(publicRequest.Disabled.Value));

                if(publicRequest.IsSetHealthThreshold())
                    xmlWriter.WriteElementString("HealthThreshold", StringUtils.FromInt(publicRequest.HealthThreshold.Value));

                var publicRequestChildHealthChecks = publicRequest.ChildHealthChecks;
                if (publicRequestChildHealthChecks != null && (publicRequestChildHealthChecks.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("ChildHealthChecks");
                    foreach (var publicRequestChildHealthChecksValue in publicRequestChildHealthChecks) 
                    {
                        xmlWriter.WriteStartElement("ChildHealthCheck");
                        xmlWriter.WriteValue(publicRequestChildHealthChecksValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetEnableSNI())
                    xmlWriter.WriteElementString("EnableSNI", StringUtils.FromBool(publicRequest.EnableSNI.Value));

                var publicRequestRegions = publicRequest.Regions;
                if (publicRequestRegions != null && (publicRequestRegions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Regions");
                    foreach (var publicRequestRegionsValue in publicRequestRegions) 
                    {
                        xmlWriter.WriteStartElement("Region");
                        xmlWriter.WriteValue(publicRequestRegionsValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if (publicRequest.AlarmIdentifier != null)
                {
                    xmlWriter.WriteStartElement("AlarmIdentifier");
                    if(publicRequest.AlarmIdentifier.IsSetRegion())
                        xmlWriter.WriteElementString("Region", StringUtils.FromString(publicRequest.AlarmIdentifier.Region));
                    if(publicRequest.AlarmIdentifier.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.AlarmIdentifier.Name));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetInsufficientDataHealthStatus())
                    xmlWriter.WriteElementString("InsufficientDataHealthStatus", StringUtils.FromString(publicRequest.InsufficientDataHealthStatus));

                var publicRequestResetElements = publicRequest.ResetElements;
                if (publicRequestResetElements != null && (publicRequestResetElements.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("ResetElements");
                    foreach (var publicRequestResetElementsValue in publicRequestResetElements) 
                    {
                        xmlWriter.WriteStartElement("ResettableElementName");
                        xmlWriter.WriteValue(publicRequestResetElementsValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateHealthCheckRequest publicRequest);
    }    
}