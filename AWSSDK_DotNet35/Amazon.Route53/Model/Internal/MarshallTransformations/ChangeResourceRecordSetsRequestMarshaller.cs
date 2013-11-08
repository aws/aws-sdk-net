/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Amazon.Route53.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Change Resource Record Sets Request Marshaller
    /// </summary>       
    public class ChangeResourceRecordSetsRequestMarshaller : IMarshaller<IRequest, ChangeResourceRecordSetsRequest>
    {
        
    
        public IRequest Marshall(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest)
        {
            IRequest request = new DefaultRequest(changeResourceRecordSetsRequest, "AmazonRoute53");



            request.HttpMethod = "POST";
            string uriResourcePath = "/2012-12-12/hostedzone/{Id}/rrset/"; 
            uriResourcePath = uriResourcePath.Replace("{Id}", changeResourceRecordSetsRequest.IsSetHostedZoneId() ? changeResourceRecordSetsRequest.HostedZoneId.ToString() : "" ); 

            if (uriResourcePath.Contains("?")) 
            {
                int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                
                uriResourcePath    = uriResourcePath.Substring(0, queryIndex);
                
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
                {
                       
            
            xmlWriter.WriteStartElement("ChangeResourceRecordSetsRequest", "https://route53.amazonaws.com/doc/2012-12-12/");
                    if (changeResourceRecordSetsRequest != null) 
        {
            ChangeBatch changeBatchChangeBatch = changeResourceRecordSetsRequest.ChangeBatch;
            if (changeBatchChangeBatch != null) 
            {
                xmlWriter.WriteStartElement("ChangeBatch", "https://route53.amazonaws.com/doc/2012-12-12/");
                if (changeBatchChangeBatch.IsSetComment()) 
                {
                    xmlWriter.WriteElementString("Comment", "https://route53.amazonaws.com/doc/2012-12-12/", changeBatchChangeBatch.Comment.ToString(CultureInfo.InvariantCulture));
                  }

                if (changeBatchChangeBatch != null) 
                {
                    List<Change> changeBatchChangeBatchchangesList = changeBatchChangeBatch.Changes;
                    if (changeBatchChangeBatchchangesList != null && changeBatchChangeBatchchangesList.Count > 0) 
                    {
                        int changeBatchChangeBatchchangesListIndex = 1;
                        xmlWriter.WriteStartElement("Changes", "https://route53.amazonaws.com/doc/2012-12-12/");
                        foreach (Change changeBatchChangeBatchchangesListValue in changeBatchChangeBatchchangesList) 
                        {
                            xmlWriter.WriteStartElement("Change", "https://route53.amazonaws.com/doc/2012-12-12/");
                            if (changeBatchChangeBatchchangesListValue.IsSetAction()) 
                            {
                                xmlWriter.WriteElementString("Action", "https://route53.amazonaws.com/doc/2012-12-12/", changeBatchChangeBatchchangesListValue.Action.ToString(CultureInfo.InvariantCulture));
                              }
                            if (changeBatchChangeBatchchangesListValue != null) 
                            {
                                ResourceRecordSet resourceRecordSetResourceRecordSet = changeBatchChangeBatchchangesListValue.ResourceRecordSet;
                                if (resourceRecordSetResourceRecordSet != null) 
                                {
                                    xmlWriter.WriteStartElement("ResourceRecordSet", "https://route53.amazonaws.com/doc/2012-12-12/");
                                    if (resourceRecordSetResourceRecordSet.IsSetName()) 
                                    {
                                        xmlWriter.WriteElementString("Name", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.Name.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (resourceRecordSetResourceRecordSet.IsSetType()) 
                                    {
                                        xmlWriter.WriteElementString("Type", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.Type.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (resourceRecordSetResourceRecordSet.IsSetSetIdentifier()) 
                                    {
                                        xmlWriter.WriteElementString("SetIdentifier", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.SetIdentifier.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (resourceRecordSetResourceRecordSet.IsSetWeight()) 
                                    {
                                        xmlWriter.WriteElementString("Weight", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.Weight.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (resourceRecordSetResourceRecordSet.IsSetRegion()) 
                                    {
                                        xmlWriter.WriteElementString("Region", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.Region.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (resourceRecordSetResourceRecordSet.IsSetFailover()) 
                                    {
                                        xmlWriter.WriteElementString("Failover", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.Failover.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (resourceRecordSetResourceRecordSet.IsSetTTL()) 
                                    {
                                        xmlWriter.WriteElementString("TTL", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.TTL.ToString(CultureInfo.InvariantCulture));
                                      }

                                    if (resourceRecordSetResourceRecordSet != null) 
                                    {
                                        List<ResourceRecord> resourceRecordSetResourceRecordSetresourceRecordsList = resourceRecordSetResourceRecordSet.ResourceRecords;
                                        if (resourceRecordSetResourceRecordSetresourceRecordsList != null && resourceRecordSetResourceRecordSetresourceRecordsList.Count > 0) 
                                        {
                                            int resourceRecordSetResourceRecordSetresourceRecordsListIndex = 1;
                                            xmlWriter.WriteStartElement("ResourceRecords", "https://route53.amazonaws.com/doc/2012-12-12/");
                                            foreach (ResourceRecord resourceRecordSetResourceRecordSetresourceRecordsListValue in resourceRecordSetResourceRecordSetresourceRecordsList) 
                                            {
                                                xmlWriter.WriteStartElement("ResourceRecord", "https://route53.amazonaws.com/doc/2012-12-12/");
                                                if (resourceRecordSetResourceRecordSetresourceRecordsListValue.IsSetValue()) 
                                                {
                                                    xmlWriter.WriteElementString("Value", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSetresourceRecordsListValue.Value.ToString(CultureInfo.InvariantCulture));
                                                  }
                                            xmlWriter.WriteEndElement();


                                                resourceRecordSetResourceRecordSetresourceRecordsListIndex++;
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (resourceRecordSetResourceRecordSet != null) 
                                    {
                                        AliasTarget aliasTargetAliasTarget = resourceRecordSetResourceRecordSet.AliasTarget;
                                        if (aliasTargetAliasTarget != null) 
                                        {
                                            xmlWriter.WriteStartElement("AliasTarget", "https://route53.amazonaws.com/doc/2012-12-12/");
                                            if (aliasTargetAliasTarget.IsSetHostedZoneId()) 
                                            {
                                                xmlWriter.WriteElementString("HostedZoneId", "https://route53.amazonaws.com/doc/2012-12-12/", aliasTargetAliasTarget.HostedZoneId.ToString(CultureInfo.InvariantCulture));
                                              }
                                            if (aliasTargetAliasTarget.IsSetDNSName()) 
                                            {
                                                xmlWriter.WriteElementString("DNSName", "https://route53.amazonaws.com/doc/2012-12-12/", aliasTargetAliasTarget.DNSName.ToString(CultureInfo.InvariantCulture));
                                              }
                                            if (aliasTargetAliasTarget.IsSetEvaluateTargetHealth()) 
                                            {
                                                xmlWriter.WriteElementString("EvaluateTargetHealth", "https://route53.amazonaws.com/doc/2012-12-12/", aliasTargetAliasTarget.EvaluateTargetHealth.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                                              }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (resourceRecordSetResourceRecordSet.IsSetHealthCheckId()) 
                                    {
                                        xmlWriter.WriteElementString("HealthCheckId", "https://route53.amazonaws.com/doc/2012-12-12/", resourceRecordSetResourceRecordSet.HealthCheckId.ToString(CultureInfo.InvariantCulture));
                                      }
                                    xmlWriter.WriteEndElement();
                                }
                            }
                        xmlWriter.WriteEndElement();


                            changeBatchChangeBatchchangesListIndex++;
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();
            }
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
    }
}
    
