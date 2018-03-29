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
    /// ChangeResourceRecordSets Request Marshaller
    /// </summary>       
    public class ChangeResourceRecordSetsRequestMarshaller : IMarshaller<IRequest, ChangeResourceRecordSetsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChangeResourceRecordSetsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ChangeResourceRecordSetsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2013-04-01/hostedzone/{Id}/rrset/";
            if (!publicRequest.IsSetHostedZoneId())
                throw new AmazonRoute53Exception("Request object does not have required field HostedZoneId set");
            uriResourcePath = uriResourcePath.Replace("{Id}", StringUtils.FromString(publicRequest.HostedZoneId));
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("ChangeResourceRecordSetsRequest", "https://route53.amazonaws.com/doc/2013-04-01/");    
                
                if (publicRequest.ChangeBatch != null) 
                {
                    xmlWriter.WriteStartElement("ChangeBatch", "https://route53.amazonaws.com/doc/2013-04-01/");            
                    if(publicRequest.ChangeBatch.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.ChangeBatch.Comment));                 
    
                    var publicRequestChangeBatchChanges = publicRequest.ChangeBatch.Changes;
                    if (publicRequestChangeBatchChanges != null && publicRequestChangeBatchChanges.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Changes", "https://route53.amazonaws.com/doc/2013-04-01/");
                        foreach (var publicRequestChangeBatchChangesValue in publicRequestChangeBatchChanges) 
                        {
                        
                        if (publicRequestChangeBatchChangesValue != null) 
                        {
                            xmlWriter.WriteStartElement("Change", "https://route53.amazonaws.com/doc/2013-04-01/");            
                            if(publicRequestChangeBatchChangesValue.IsSetAction())
                                xmlWriter.WriteElementString("Action", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.Action));                 
            
                            
                            if (publicRequestChangeBatchChangesValue.ResourceRecordSet != null) 
                            {
                                xmlWriter.WriteStartElement("ResourceRecordSet", "https://route53.amazonaws.com/doc/2013-04-01/");            
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetName())
                                    xmlWriter.WriteElementString("Name", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Name));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetType())
                                    xmlWriter.WriteElementString("Type", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Type));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetSetIdentifier())
                                    xmlWriter.WriteElementString("SetIdentifier", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.SetIdentifier));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetWeight())
                                    xmlWriter.WriteElementString("Weight", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromLong(publicRequestChangeBatchChangesValue.ResourceRecordSet.Weight));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetRegion())
                                    xmlWriter.WriteElementString("Region", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Region));                 
                
                                
                                if (publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation != null) 
                                {
                                    xmlWriter.WriteStartElement("GeoLocation", "https://route53.amazonaws.com/doc/2013-04-01/");            
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.IsSetContinentCode())
                                        xmlWriter.WriteElementString("ContinentCode", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.ContinentCode));                 
                    
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.IsSetCountryCode())
                                        xmlWriter.WriteElementString("CountryCode", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.CountryCode));                 
                    
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.IsSetSubdivisionCode())
                                        xmlWriter.WriteElementString("SubdivisionCode", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.SubdivisionCode));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetFailover())
                                    xmlWriter.WriteElementString("Failover", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Failover));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetMultiValueAnswer())
                                    xmlWriter.WriteElementString("MultiValueAnswer", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequestChangeBatchChangesValue.ResourceRecordSet.MultiValueAnswer));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetTTL())
                                    xmlWriter.WriteElementString("TTL", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromLong(publicRequestChangeBatchChangesValue.ResourceRecordSet.TTL));                 
                
                                var publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords = publicRequestChangeBatchChangesValue.ResourceRecordSet.ResourceRecords;
                                if (publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords != null && publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("ResourceRecords", "https://route53.amazonaws.com/doc/2013-04-01/");
                                    foreach (var publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue in publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords) 
                                    {
                                    
                                    if (publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue != null) 
                                    {
                                        xmlWriter.WriteStartElement("ResourceRecord", "https://route53.amazonaws.com/doc/2013-04-01/");            
                                        if(publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue.IsSetValue())
                                            xmlWriter.WriteElementString("Value", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue.Value));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                
                                if (publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget != null) 
                                {
                                    xmlWriter.WriteStartElement("AliasTarget", "https://route53.amazonaws.com/doc/2013-04-01/");            
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.IsSetHostedZoneId())
                                        xmlWriter.WriteElementString("HostedZoneId", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.HostedZoneId));                 
                    
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.IsSetDNSName())
                                        xmlWriter.WriteElementString("DNSName", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.DNSName));                 
                    
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.IsSetEvaluateTargetHealth())
                                        xmlWriter.WriteElementString("EvaluateTargetHealth", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromBool(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.EvaluateTargetHealth));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetHealthCheckId())
                                    xmlWriter.WriteElementString("HealthCheckId", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.HealthCheckId));                 
                
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetTrafficPolicyInstanceId())
                                    xmlWriter.WriteElementString("TrafficPolicyInstanceId", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.TrafficPolicyInstanceId));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
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
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static ChangeResourceRecordSetsRequestMarshaller _instance = new ChangeResourceRecordSetsRequestMarshaller();        

        internal static ChangeResourceRecordSetsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChangeResourceRecordSetsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}