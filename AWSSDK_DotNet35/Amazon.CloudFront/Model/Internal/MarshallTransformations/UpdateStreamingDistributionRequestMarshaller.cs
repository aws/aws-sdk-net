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

using Amazon.CloudFront.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Streaming Distribution Request Marshaller
    /// </summary>       
    public class UpdateStreamingDistributionRequestMarshaller : IMarshaller<IRequest, UpdateStreamingDistributionRequest>
    {
        
    
        public IRequest Marshall(UpdateStreamingDistributionRequest updateStreamingDistributionRequest)
        {
            IRequest request = new DefaultRequest(updateStreamingDistributionRequest, "AmazonCloudFront");



            request.HttpMethod = "PUT";
        if(updateStreamingDistributionRequest.IsSetIfMatch())
            request.Headers.Add("If-Match", updateStreamingDistributionRequest.IfMatch);
            
            string uriResourcePath = "2013-09-27/streaming-distribution/{Id}/config"; 
            uriResourcePath = uriResourcePath.Replace("{Id}", updateStreamingDistributionRequest.IsSetId() ? updateStreamingDistributionRequest.Id.ToString() : "" ); 

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
                       
                    if (updateStreamingDistributionRequest != null) 
        {
            StreamingDistributionConfig streamingDistributionConfigStreamingDistributionConfig = updateStreamingDistributionRequest.StreamingDistributionConfig;
            if (streamingDistributionConfigStreamingDistributionConfig != null) 
            {
                xmlWriter.WriteStartElement("StreamingDistributionConfig", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                if (streamingDistributionConfigStreamingDistributionConfig.IsSetCallerReference()) 
                {
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingDistributionConfigStreamingDistributionConfig.CallerReference.ToString(CultureInfo.InvariantCulture));
                  }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    S3Origin s3OriginS3Origin = streamingDistributionConfigStreamingDistributionConfig.S3Origin;
                    if (s3OriginS3Origin != null) 
                    {
                        xmlWriter.WriteStartElement("S3Origin", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (s3OriginS3Origin.IsSetDomainName()) 
                        {
                            xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2013-09-27/", s3OriginS3Origin.DomainName.ToString(CultureInfo.InvariantCulture));
                          }
                        if (s3OriginS3Origin.IsSetOriginAccessIdentity()) 
                        {
                            xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", s3OriginS3Origin.OriginAccessIdentity.ToString(CultureInfo.InvariantCulture));
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    Aliases aliasesAliases = streamingDistributionConfigStreamingDistributionConfig.Aliases;
                    if (aliasesAliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (aliasesAliases.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", aliasesAliases.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (aliasesAliases != null) 
                        {
                            List<string> aliasesAliasesitemsList = aliasesAliases.Items;
                            if (aliasesAliasesitemsList != null && aliasesAliasesitemsList.Count > 0) 
                            {
                                int aliasesAliasesitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                foreach (string aliasesAliasesitemsListValue in aliasesAliasesitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                    xmlWriter.WriteValue(aliasesAliasesitemsListValue);
                                xmlWriter.WriteEndElement();


                                    aliasesAliasesitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (streamingDistributionConfigStreamingDistributionConfig.IsSetComment()) 
                {
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingDistributionConfigStreamingDistributionConfig.Comment.ToString(CultureInfo.InvariantCulture));
                  }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    StreamingLoggingConfig streamingLoggingConfigLogging = streamingDistributionConfigStreamingDistributionConfig.Logging;
                    if (streamingLoggingConfigLogging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (streamingLoggingConfigLogging.IsSetEnabled()) 
                        {
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingLoggingConfigLogging.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                          }
                        if (streamingLoggingConfigLogging.IsSetBucket()) 
                        {
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingLoggingConfigLogging.Bucket.ToString(CultureInfo.InvariantCulture));
                          }
                        if (streamingLoggingConfigLogging.IsSetPrefix()) 
                        {
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingLoggingConfigLogging.Prefix.ToString(CultureInfo.InvariantCulture));
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    TrustedSigners trustedSignersTrustedSigners = streamingDistributionConfigStreamingDistributionConfig.TrustedSigners;
                    if (trustedSignersTrustedSigners != null) 
                    {
                        xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (trustedSignersTrustedSigners.IsSetEnabled()) 
                        {
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", trustedSignersTrustedSigners.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                          }
                        if (trustedSignersTrustedSigners.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", trustedSignersTrustedSigners.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (trustedSignersTrustedSigners != null) 
                        {
                            List<string> trustedSignersTrustedSignersitemsList = trustedSignersTrustedSigners.Items;
                            if (trustedSignersTrustedSignersitemsList != null && trustedSignersTrustedSignersitemsList.Count > 0) 
                            {
                                int trustedSignersTrustedSignersitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                foreach (string trustedSignersTrustedSignersitemsListValue in trustedSignersTrustedSignersitemsList) 
                                {
                                    xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                    xmlWriter.WriteValue(trustedSignersTrustedSignersitemsListValue);
                                xmlWriter.WriteEndElement();


                                    trustedSignersTrustedSignersitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (streamingDistributionConfigStreamingDistributionConfig.IsSetPriceClass()) 
                {
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingDistributionConfigStreamingDistributionConfig.PriceClass.ToString(CultureInfo.InvariantCulture));
                  }
                if (streamingDistributionConfigStreamingDistributionConfig.IsSetEnabled()) 
                {
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", streamingDistributionConfigStreamingDistributionConfig.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                  }
                xmlWriter.WriteEndElement();
            }
        }

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
    
