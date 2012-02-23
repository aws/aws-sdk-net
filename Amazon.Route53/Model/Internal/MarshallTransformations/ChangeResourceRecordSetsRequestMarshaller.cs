/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

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
    public class ChangeResourceRecordSetsRequestMarshaller : IMarshaller<IRequest<ChangeResourceRecordSetsRequest>, ChangeResourceRecordSetsRequest>
    {
        
    
        public IRequest<ChangeResourceRecordSetsRequest> Marshall(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest)
        {
            IRequest<ChangeResourceRecordSetsRequest> request = new DefaultRequest<ChangeResourceRecordSetsRequest>(changeResourceRecordSetsRequest, "AmazonRoute53");
            request.HttpMethod = "POST";
              
            string uriResourcePath = "/2011-05-05/hostedzone/{Id}/rrset/"; 
            uriResourcePath = uriResourcePath.Replace("{Id}", changeResourceRecordSetsRequest.HostedZoneId ?? "" ); 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            xmlWriter.Namespaces = true;
                       
            
            xmlWriter.WriteStartElement("ChangeResourceRecordSetsRequest", "https://route53.amazonaws.com/doc/2011-05-05/");
                    if (changeResourceRecordSetsRequest != null) 
        {
            ChangeBatch changeBatchChangeBatch = changeResourceRecordSetsRequest.ChangeBatch;
            if (changeBatchChangeBatch != null) 
            {
                xmlWriter.WriteStartElement("ChangeBatch", "https://route53.amazonaws.com/doc/2011-05-05/");
                if (changeBatchChangeBatch.IsSetComment()) 
                {
                    xmlWriter.WriteElementString("Comment", "https://route53.amazonaws.com/doc/2011-05-05/", changeBatchChangeBatch.Comment.ToString());
                }

                if (changeBatchChangeBatch != null) 
                {
                    List<Change> changesList = changeBatchChangeBatch.Changes;
                    if (changesList != null && changesList.Count > 0) 
                    {
                        int changesListIndex = 1;
                        xmlWriter.WriteStartElement("Changes", "https://route53.amazonaws.com/doc/2011-05-05/");
                        foreach (Change changesListValue in changesList) 
                        {
                            xmlWriter.WriteStartElement("Change", "https://route53.amazonaws.com/doc/2011-05-05/");
                            if (changesListValue.IsSetAction()) 
                            {
                                xmlWriter.WriteElementString("Action", "https://route53.amazonaws.com/doc/2011-05-05/", changesListValue.Action.ToString());
                            }
                            if (changesListValue != null) 
                            {
                                ResourceRecordSet resourceRecordSetResourceRecordSet = changesListValue.ResourceRecordSet;
                                if (resourceRecordSetResourceRecordSet != null) 
                                {
                                    xmlWriter.WriteStartElement("ResourceRecordSet", "https://route53.amazonaws.com/doc/2011-05-05/");
                                    if (resourceRecordSetResourceRecordSet.IsSetName()) 
                                    {
                                        xmlWriter.WriteElementString("Name", "https://route53.amazonaws.com/doc/2011-05-05/", resourceRecordSetResourceRecordSet.Name.ToString());
                                    }
                                    if (resourceRecordSetResourceRecordSet.IsSetType()) 
                                    {
                                        xmlWriter.WriteElementString("Type", "https://route53.amazonaws.com/doc/2011-05-05/", resourceRecordSetResourceRecordSet.Type.ToString());
                                    }
                                    if (resourceRecordSetResourceRecordSet.IsSetSetIdentifier()) 
                                    {
                                        xmlWriter.WriteElementString("SetIdentifier", "https://route53.amazonaws.com/doc/2011-05-05/", resourceRecordSetResourceRecordSet.SetIdentifier.ToString());
                                    }
                                    if (resourceRecordSetResourceRecordSet.IsSetWeight()) 
                                    {
                                        xmlWriter.WriteElementString("Weight", "https://route53.amazonaws.com/doc/2011-05-05/", resourceRecordSetResourceRecordSet.Weight.ToString());
                                    }
                                    if (resourceRecordSetResourceRecordSet.IsSetTTL()) 
                                    {
                                        xmlWriter.WriteElementString("TTL", "https://route53.amazonaws.com/doc/2011-05-05/", resourceRecordSetResourceRecordSet.TTL.ToString());
                                    }

                                    if (resourceRecordSetResourceRecordSet != null) 
                                    {
                                        List<ResourceRecord> resourceRecordsList = resourceRecordSetResourceRecordSet.ResourceRecords;
                                        if (resourceRecordsList != null && resourceRecordsList.Count > 0) 
                                        {
                                            int resourceRecordsListIndex = 1;
                                            xmlWriter.WriteStartElement("ResourceRecords", "https://route53.amazonaws.com/doc/2011-05-05/");
                                            foreach (ResourceRecord resourceRecordsListValue in resourceRecordsList) 
                                            {
                                                xmlWriter.WriteStartElement("ResourceRecord", "https://route53.amazonaws.com/doc/2011-05-05/");
                                                if (resourceRecordsListValue.IsSetValue()) 
                                                {
                                                    xmlWriter.WriteElementString("Value", "https://route53.amazonaws.com/doc/2011-05-05/", resourceRecordsListValue.Value.ToString());
                                                }
                                            xmlWriter.WriteEndElement();


                                                resourceRecordsListIndex++;
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (resourceRecordSetResourceRecordSet != null) 
                                    {
                                        AliasTarget aliasTargetAliasTarget = resourceRecordSetResourceRecordSet.AliasTarget;
                                        if (aliasTargetAliasTarget != null) 
                                        {
                                            xmlWriter.WriteStartElement("AliasTarget", "https://route53.amazonaws.com/doc/2011-05-05/");
                                            if (aliasTargetAliasTarget.IsSetHostedZoneId()) 
                                            {
                                                xmlWriter.WriteElementString("HostedZoneId", "https://route53.amazonaws.com/doc/2011-05-05/", aliasTargetAliasTarget.HostedZoneId.ToString());
                                            }
                                            if (aliasTargetAliasTarget.IsSetDNSName()) 
                                            {
                                                xmlWriter.WriteElementString("DNSName", "https://route53.amazonaws.com/doc/2011-05-05/", aliasTargetAliasTarget.DNSName.ToString());
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                            }
                        xmlWriter.WriteEndElement();


                            changesListIndex++;
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();
            }
        }

            xmlWriter.WriteEndElement();
            
    
            try 
            {
                request.Content = System.Text.Encoding.UTF8.GetBytes(stringWriter.ToString());
                request.Headers.Add("Content-Type", "application/xml");
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
                    
            
            return request;
        }
    }
}
    
