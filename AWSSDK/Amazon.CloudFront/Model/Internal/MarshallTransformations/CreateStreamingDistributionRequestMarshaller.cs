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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Streaming Distribution Request Marshaller
    /// </summary>       
    public class CreateStreamingDistributionRequestMarshaller : IMarshaller<IRequest, CreateStreamingDistributionRequest>
    {
        
    
        public IRequest Marshall(CreateStreamingDistributionRequest createStreamingDistributionRequest)
        {
            IRequest request = new DefaultRequest(createStreamingDistributionRequest, "AmazonCloudFront");



            request.HttpMethod = "POST";
              
            string uriResourcePath = "2012-07-01/streaming-distribution"; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
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
            
             
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            xmlWriter.Namespaces = true;
                       
                    if (createStreamingDistributionRequest != null) 
        {
            StreamingDistributionConfig streamingDistributionConfigStreamingDistributionConfig = createStreamingDistributionRequest.StreamingDistributionConfig;
            if (streamingDistributionConfigStreamingDistributionConfig != null) 
            {
                xmlWriter.WriteStartElement("StreamingDistributionConfig", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                if (streamingDistributionConfigStreamingDistributionConfig.IsSetCallerReference()) 
                {
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingDistributionConfigStreamingDistributionConfig.CallerReference.ToString());
                  }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    S3Origin s3OriginS3Origin = streamingDistributionConfigStreamingDistributionConfig.S3Origin;
                    if (s3OriginS3Origin != null) 
                    {
                        xmlWriter.WriteStartElement("S3Origin", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                        if (s3OriginS3Origin.IsSetDomainName()) 
                        {
                            xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2012-07-01/", s3OriginS3Origin.DomainName.ToString());
                          }
                        if (s3OriginS3Origin.IsSetOriginAccessIdentity()) 
                        {
                            xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2012-07-01/", s3OriginS3Origin.OriginAccessIdentity.ToString());
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    Aliases aliasesAliases = streamingDistributionConfigStreamingDistributionConfig.Aliases;
                    if (aliasesAliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                        if (aliasesAliases.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2012-07-01/", aliasesAliases.Quantity.ToString());
                          }

                        if (aliasesAliases != null) 
                        {
                            List<string> aliasesAliasesitemsList = aliasesAliases.Items;
                            if (aliasesAliasesitemsList != null && aliasesAliasesitemsList.Count > 0) 
                            {
                                int aliasesAliasesitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                                foreach (string aliasesAliasesitemsListValue in aliasesAliasesitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
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
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingDistributionConfigStreamingDistributionConfig.Comment.ToString());
                  }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    StreamingLoggingConfig streamingLoggingConfigLogging = streamingDistributionConfigStreamingDistributionConfig.Logging;
                    if (streamingLoggingConfigLogging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                        if (streamingLoggingConfigLogging.IsSetEnabled()) 
                        {
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingLoggingConfigLogging.Enabled.ToString().ToLower());
                          }
                        if (streamingLoggingConfigLogging.IsSetBucket()) 
                        {
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingLoggingConfigLogging.Bucket.ToString());
                          }
                        if (streamingLoggingConfigLogging.IsSetPrefix()) 
                        {
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingLoggingConfigLogging.Prefix.ToString());
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (streamingDistributionConfigStreamingDistributionConfig != null) 
                {
                    TrustedSigners trustedSignersTrustedSigners = streamingDistributionConfigStreamingDistributionConfig.TrustedSigners;
                    if (trustedSignersTrustedSigners != null) 
                    {
                        xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                        if (trustedSignersTrustedSigners.IsSetEnabled()) 
                        {
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2012-07-01/", trustedSignersTrustedSigners.Enabled.ToString().ToLower());
                          }
                        if (trustedSignersTrustedSigners.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2012-07-01/", trustedSignersTrustedSigners.Quantity.ToString());
                          }

                        if (trustedSignersTrustedSigners != null) 
                        {
                            List<string> trustedSignersTrustedSignersitemsList = trustedSignersTrustedSigners.Items;
                            if (trustedSignersTrustedSignersitemsList != null && trustedSignersTrustedSignersitemsList.Count > 0) 
                            {
                                int trustedSignersTrustedSignersitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
                                foreach (string trustedSignersTrustedSignersitemsListValue in trustedSignersTrustedSignersitemsList) 
                                {
                                    xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2012-07-01/");
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
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingDistributionConfigStreamingDistributionConfig.PriceClass.ToString());
                  }
                if (streamingDistributionConfigStreamingDistributionConfig.IsSetEnabled()) 
                {
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2012-07-01/", streamingDistributionConfigStreamingDistributionConfig.Enabled.ToString().ToLower());
                  }
                xmlWriter.WriteEndElement();
            }
        }

    
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
    
