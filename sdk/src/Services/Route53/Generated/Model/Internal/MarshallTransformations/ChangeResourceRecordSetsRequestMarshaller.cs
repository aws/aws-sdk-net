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
    /// ChangeResourceRecordSets Request Marshaller
    /// </summary>       
    public partial class ChangeResourceRecordSetsRequestMarshaller : IMarshaller<IRequest, ChangeResourceRecordSetsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            if (!publicRequest.IsSetHostedZoneId())
                throw new AmazonRoute53Exception("Request object does not have required field HostedZoneId set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.HostedZoneId));
            request.ResourcePath = "/2013-04-01/hostedzone/{Id}/rrset/";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("ChangeResourceRecordSetsRequest", "https://route53.amazonaws.com/doc/2013-04-01/");
                if (publicRequest.ChangeBatch != null)
                {
                    xmlWriter.WriteStartElement("ChangeBatch");
                    if(publicRequest.ChangeBatch.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.ChangeBatch.Comment));
                    var publicRequestChangeBatchChanges = publicRequest.ChangeBatch.Changes;
                    if (publicRequestChangeBatchChanges != null && (publicRequestChangeBatchChanges.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Changes");
                        foreach (var publicRequestChangeBatchChangesValue in publicRequestChangeBatchChanges) 
                        {
                        if (publicRequestChangeBatchChangesValue != null)
                        {
                            xmlWriter.WriteStartElement("Change");
                            if(publicRequestChangeBatchChangesValue.IsSetAction())
                                xmlWriter.WriteElementString("Action", StringUtils.FromString(publicRequestChangeBatchChangesValue.Action));
                            if (publicRequestChangeBatchChangesValue.ResourceRecordSet != null)
                            {
                                xmlWriter.WriteStartElement("ResourceRecordSet");
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetName())
                                    xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Name));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetType())
                                    xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Type));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetSetIdentifier())
                                    xmlWriter.WriteElementString("SetIdentifier", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.SetIdentifier));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetWeight())
                                    xmlWriter.WriteElementString("Weight", StringUtils.FromLong(publicRequestChangeBatchChangesValue.ResourceRecordSet.Weight.Value));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetRegion())
                                    xmlWriter.WriteElementString("Region", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Region));
                                if (publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation != null)
                                {
                                    xmlWriter.WriteStartElement("GeoLocation");
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.IsSetContinentCode())
                                        xmlWriter.WriteElementString("ContinentCode", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.ContinentCode));
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.IsSetCountryCode())
                                        xmlWriter.WriteElementString("CountryCode", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.CountryCode));
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.IsSetSubdivisionCode())
                                        xmlWriter.WriteElementString("SubdivisionCode", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoLocation.SubdivisionCode));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetFailover())
                                    xmlWriter.WriteElementString("Failover", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.Failover));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetMultiValueAnswer())
                                    xmlWriter.WriteElementString("MultiValueAnswer", StringUtils.FromBool(publicRequestChangeBatchChangesValue.ResourceRecordSet.MultiValueAnswer.Value));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetTTL())
                                    xmlWriter.WriteElementString("TTL", StringUtils.FromLong(publicRequestChangeBatchChangesValue.ResourceRecordSet.TTL.Value));
                                var publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords = publicRequestChangeBatchChangesValue.ResourceRecordSet.ResourceRecords;
                                if (publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords != null && (publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                {
                                    xmlWriter.WriteStartElement("ResourceRecords");
                                    foreach (var publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue in publicRequestChangeBatchChangesValueResourceRecordSetResourceRecords) 
                                    {
                                    if (publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("ResourceRecord");
                                        if(publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue.IsSetValue())
                                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestChangeBatchChangesValueResourceRecordSetResourceRecordsValue.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if (publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget != null)
                                {
                                    xmlWriter.WriteStartElement("AliasTarget");
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.IsSetHostedZoneId())
                                        xmlWriter.WriteElementString("HostedZoneId", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.HostedZoneId));
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.IsSetDNSName())
                                        xmlWriter.WriteElementString("DNSName", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.DNSName));
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.IsSetEvaluateTargetHealth())
                                        xmlWriter.WriteElementString("EvaluateTargetHealth", StringUtils.FromBool(publicRequestChangeBatchChangesValue.ResourceRecordSet.AliasTarget.EvaluateTargetHealth.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetHealthCheckId())
                                    xmlWriter.WriteElementString("HealthCheckId", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.HealthCheckId));
                                if(publicRequestChangeBatchChangesValue.ResourceRecordSet.IsSetTrafficPolicyInstanceId())
                                    xmlWriter.WriteElementString("TrafficPolicyInstanceId", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.TrafficPolicyInstanceId));
                                if (publicRequestChangeBatchChangesValue.ResourceRecordSet.CidrRoutingConfig != null)
                                {
                                    xmlWriter.WriteStartElement("CidrRoutingConfig");
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.CidrRoutingConfig.IsSetCollectionId())
                                        xmlWriter.WriteElementString("CollectionId", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.CidrRoutingConfig.CollectionId));
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.CidrRoutingConfig.IsSetLocationName())
                                        xmlWriter.WriteElementString("LocationName", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.CidrRoutingConfig.LocationName));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation != null)
                                {
                                    xmlWriter.WriteStartElement("GeoProximityLocation");
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.IsSetAWSRegion())
                                        xmlWriter.WriteElementString("AWSRegion", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.AWSRegion));
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.IsSetLocalZoneGroup())
                                        xmlWriter.WriteElementString("LocalZoneGroup", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.LocalZoneGroup));
                                    if (publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.Coordinates != null)
                                    {
                                        xmlWriter.WriteStartElement("Coordinates");
                                        if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.Coordinates.IsSetLatitude())
                                            xmlWriter.WriteElementString("Latitude", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.Coordinates.Latitude));
                                        if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.Coordinates.IsSetLongitude())
                                            xmlWriter.WriteElementString("Longitude", StringUtils.FromString(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.Coordinates.Longitude));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.IsSetBias())
                                        xmlWriter.WriteElementString("Bias", StringUtils.FromInt(publicRequestChangeBatchChangesValue.ResourceRecordSet.GeoProximityLocation.Bias.Value));
                                    xmlWriter.WriteEndElement();
                                }
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ChangeResourceRecordSetsRequest publicRequest);
    }    
}