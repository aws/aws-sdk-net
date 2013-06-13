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
    /// Create Distribution Request Marshaller
    /// </summary>       
    public class CreateDistributionRequestMarshaller : IMarshaller<IRequest, CreateDistributionRequest>
    {
        
    
        public IRequest Marshall(CreateDistributionRequest createDistributionRequest)
        {
            IRequest request = new DefaultRequest(createDistributionRequest, "AmazonCloudFront");



            request.HttpMethod = "POST";
              
            string uriResourcePath = "2013-05-12/distribution"; 
            
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
                       
                    if (createDistributionRequest != null) 
        {
            DistributionConfig distributionConfigDistributionConfig = createDistributionRequest.DistributionConfig;
            if (distributionConfigDistributionConfig != null) 
            {
                xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                if (distributionConfigDistributionConfig.IsSetCallerReference()) 
                {
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2013-05-12/", distributionConfigDistributionConfig.CallerReference.ToString());
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    Aliases aliasesAliases = distributionConfigDistributionConfig.Aliases;
                    if (aliasesAliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                        if (aliasesAliases.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", aliasesAliases.Quantity.ToString());
                          }

                        if (aliasesAliases != null) 
                        {
                            List<string> aliasesAliasesitemsList = aliasesAliases.Items;
                            if (aliasesAliasesitemsList != null && aliasesAliasesitemsList.Count > 0) 
                            {
                                int aliasesAliasesitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                foreach (string aliasesAliasesitemsListValue in aliasesAliasesitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
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
                if (distributionConfigDistributionConfig.IsSetDefaultRootObject()) 
                {
                    xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2013-05-12/", distributionConfigDistributionConfig.DefaultRootObject.ToString());
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    Origins originsOrigins = distributionConfigDistributionConfig.Origins;
                    if (originsOrigins != null) 
                    {
                        xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                        if (originsOrigins.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", originsOrigins.Quantity.ToString());
                          }

                        if (originsOrigins != null) 
                        {
                            List<Origin> originsOriginsitemsList = originsOrigins.Items;
                            if (originsOriginsitemsList != null && originsOriginsitemsList.Count > 0) 
                            {
                                int originsOriginsitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                foreach (Origin originsOriginsitemsListValue in originsOriginsitemsList) 
                                {
                                    xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                    if (originsOriginsitemsListValue.IsSetId()) 
                                    {
                                        xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2013-05-12/", originsOriginsitemsListValue.Id.ToString());
                                      }
                                    if (originsOriginsitemsListValue.IsSetDomainName()) 
                                    {
                                        xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2013-05-12/", originsOriginsitemsListValue.DomainName.ToString());
                                      }
                                    if (originsOriginsitemsListValue != null) 
                                    {
                                        S3OriginConfig s3OriginConfigS3OriginConfig = originsOriginsitemsListValue.S3OriginConfig;
                                        if (s3OriginConfigS3OriginConfig != null) 
                                        {
                                            xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                            if (s3OriginConfigS3OriginConfig.IsSetOriginAccessIdentity()) 
                                            {
                                                xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", s3OriginConfigS3OriginConfig.OriginAccessIdentity.ToString());
                                              }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (originsOriginsitemsListValue != null) 
                                    {
                                        CustomOriginConfig customOriginConfigCustomOriginConfig = originsOriginsitemsListValue.CustomOriginConfig;
                                        if (customOriginConfigCustomOriginConfig != null) 
                                        {
                                            xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                            if (customOriginConfigCustomOriginConfig.IsSetHTTPPort()) 
                                            {
                                                xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2013-05-12/", customOriginConfigCustomOriginConfig.HTTPPort.ToString());
                                              }
                                            if (customOriginConfigCustomOriginConfig.IsSetHTTPSPort()) 
                                            {
                                                xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2013-05-12/", customOriginConfigCustomOriginConfig.HTTPSPort.ToString());
                                              }
                                            if (customOriginConfigCustomOriginConfig.IsSetOriginProtocolPolicy()) 
                                            {
                                                xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2013-05-12/", customOriginConfigCustomOriginConfig.OriginProtocolPolicy.ToString());
                                              }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                xmlWriter.WriteEndElement();


                                    originsOriginsitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig != null) 
                {
                    DefaultCacheBehavior defaultCacheBehaviorDefaultCacheBehavior = distributionConfigDistributionConfig.DefaultCacheBehavior;
                    if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                    {
                        xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                        if (defaultCacheBehaviorDefaultCacheBehavior.IsSetTargetOriginId()) 
                        {
                            xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2013-05-12/", defaultCacheBehaviorDefaultCacheBehavior.TargetOriginId.ToString());
                          }
                        if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                        {
                            ForwardedValues forwardedValuesForwardedValues = defaultCacheBehaviorDefaultCacheBehavior.ForwardedValues;
                            if (forwardedValuesForwardedValues != null) 
                            {
                                xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                if (forwardedValuesForwardedValues.IsSetQueryString()) 
                                {
                                    xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2013-05-12/", forwardedValuesForwardedValues.QueryString.ToString().ToLower());
                                  }
                                if (forwardedValuesForwardedValues != null) 
                                {
                                    CookiePreference cookiePreferenceCookies = forwardedValuesForwardedValues.Cookies;
                                    if (cookiePreferenceCookies != null) 
                                    {
                                        xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                        if (cookiePreferenceCookies.IsSetForward()) 
                                        {
                                            xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cookiePreferenceCookies.Forward.ToString());
                                          }
                                        if (cookiePreferenceCookies != null) 
                                        {
                                            CookieNames cookieNamesWhitelistedNames = cookiePreferenceCookies.WhitelistedNames;
                                            if (cookieNamesWhitelistedNames != null) 
                                            {
                                                xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                if (cookieNamesWhitelistedNames.IsSetQuantity()) 
                                                {
                                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cookieNamesWhitelistedNames.Quantity.ToString());
                                                  }

                                                if (cookieNamesWhitelistedNames != null) 
                                                {
                                                    List<string> cookieNamesWhitelistedNamesitemsList = cookieNamesWhitelistedNames.Items;
                                                    if (cookieNamesWhitelistedNamesitemsList != null && cookieNamesWhitelistedNamesitemsList.Count > 0) 
                                                    {
                                                        int cookieNamesWhitelistedNamesitemsListIndex = 1;
                                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                        foreach (string cookieNamesWhitelistedNamesitemsListValue in cookieNamesWhitelistedNamesitemsList) 
                                                        {
                                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                            xmlWriter.WriteValue(cookieNamesWhitelistedNamesitemsListValue);
                                                        xmlWriter.WriteEndElement();


                                                            cookieNamesWhitelistedNamesitemsListIndex++;
                                                        }
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }
                                                xmlWriter.WriteEndElement();
                                            }
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                        {
                            TrustedSigners trustedSignersTrustedSigners = defaultCacheBehaviorDefaultCacheBehavior.TrustedSigners;
                            if (trustedSignersTrustedSigners != null) 
                            {
                                xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                if (trustedSignersTrustedSigners.IsSetEnabled()) 
                                {
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-05-12/", trustedSignersTrustedSigners.Enabled.ToString().ToLower());
                                  }
                                if (trustedSignersTrustedSigners.IsSetQuantity()) 
                                {
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", trustedSignersTrustedSigners.Quantity.ToString());
                                  }

                                if (trustedSignersTrustedSigners != null) 
                                {
                                    List<string> trustedSignersTrustedSignersitemsList = trustedSignersTrustedSigners.Items;
                                    if (trustedSignersTrustedSignersitemsList != null && trustedSignersTrustedSignersitemsList.Count > 0) 
                                    {
                                        int trustedSignersTrustedSignersitemsListIndex = 1;
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                        foreach (string trustedSignersTrustedSignersitemsListValue in trustedSignersTrustedSignersitemsList) 
                                        {
                                            xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
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
                        if (defaultCacheBehaviorDefaultCacheBehavior.IsSetViewerProtocolPolicy()) 
                        {
                            xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2013-05-12/", defaultCacheBehaviorDefaultCacheBehavior.ViewerProtocolPolicy.ToString());
                          }
                        if (defaultCacheBehaviorDefaultCacheBehavior.IsSetMinTTL()) 
                        {
                            xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2013-05-12/", defaultCacheBehaviorDefaultCacheBehavior.MinTTL.ToString());
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig != null) 
                {
                    CacheBehaviors cacheBehaviorsCacheBehaviors = distributionConfigDistributionConfig.CacheBehaviors;
                    if (cacheBehaviorsCacheBehaviors != null) 
                    {
                        xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                        if (cacheBehaviorsCacheBehaviors.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cacheBehaviorsCacheBehaviors.Quantity.ToString());
                          }

                        if (cacheBehaviorsCacheBehaviors != null) 
                        {
                            List<CacheBehavior> cacheBehaviorsCacheBehaviorsitemsList = cacheBehaviorsCacheBehaviors.Items;
                            if (cacheBehaviorsCacheBehaviorsitemsList != null && cacheBehaviorsCacheBehaviorsitemsList.Count > 0) 
                            {
                                int cacheBehaviorsCacheBehaviorsitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                foreach (CacheBehavior cacheBehaviorsCacheBehaviorsitemsListValue in cacheBehaviorsCacheBehaviorsitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetPathPattern()) 
                                    {
                                        xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cacheBehaviorsCacheBehaviorsitemsListValue.PathPattern.ToString());
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetTargetOriginId()) 
                                    {
                                        xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cacheBehaviorsCacheBehaviorsitemsListValue.TargetOriginId.ToString());
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue != null) 
                                    {
                                        ForwardedValues forwardedValuesForwardedValues = cacheBehaviorsCacheBehaviorsitemsListValue.ForwardedValues;
                                        if (forwardedValuesForwardedValues != null) 
                                        {
                                            xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                            if (forwardedValuesForwardedValues.IsSetQueryString()) 
                                            {
                                                xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2013-05-12/", forwardedValuesForwardedValues.QueryString.ToString().ToLower());
                                              }
                                            if (forwardedValuesForwardedValues != null) 
                                            {
                                                CookiePreference cookiePreferenceCookies = forwardedValuesForwardedValues.Cookies;
                                                if (cookiePreferenceCookies != null) 
                                                {
                                                    xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                    if (cookiePreferenceCookies.IsSetForward()) 
                                                    {
                                                        xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cookiePreferenceCookies.Forward.ToString());
                                                      }
                                                    if (cookiePreferenceCookies != null) 
                                                    {
                                                        CookieNames cookieNamesWhitelistedNames = cookiePreferenceCookies.WhitelistedNames;
                                                        if (cookieNamesWhitelistedNames != null) 
                                                        {
                                                            xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                            if (cookieNamesWhitelistedNames.IsSetQuantity()) 
                                                            {
                                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cookieNamesWhitelistedNames.Quantity.ToString());
                                                              }

                                                            if (cookieNamesWhitelistedNames != null) 
                                                            {
                                                                List<string> cookieNamesWhitelistedNamesitemsList = cookieNamesWhitelistedNames.Items;
                                                                if (cookieNamesWhitelistedNamesitemsList != null && cookieNamesWhitelistedNamesitemsList.Count > 0) 
                                                                {
                                                                    int cookieNamesWhitelistedNamesitemsListIndex = 1;
                                                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                                    foreach (string cookieNamesWhitelistedNamesitemsListValue in cookieNamesWhitelistedNamesitemsList) 
                                                                    {
                                                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                                        xmlWriter.WriteValue(cookieNamesWhitelistedNamesitemsListValue);
                                                                    xmlWriter.WriteEndElement();


                                                                        cookieNamesWhitelistedNamesitemsListIndex++;
                                                                    }
                                                                    xmlWriter.WriteEndElement();
                                                                }
                                                            }
                                                            xmlWriter.WriteEndElement();
                                                        }
                                                    }
                                                    xmlWriter.WriteEndElement();
                                                }
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue != null) 
                                    {
                                        TrustedSigners trustedSignersTrustedSigners = cacheBehaviorsCacheBehaviorsitemsListValue.TrustedSigners;
                                        if (trustedSignersTrustedSigners != null) 
                                        {
                                            xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                            if (trustedSignersTrustedSigners.IsSetEnabled()) 
                                            {
                                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-05-12/", trustedSignersTrustedSigners.Enabled.ToString().ToLower());
                                              }
                                            if (trustedSignersTrustedSigners.IsSetQuantity()) 
                                            {
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-05-12/", trustedSignersTrustedSigners.Quantity.ToString());
                                              }

                                            if (trustedSignersTrustedSigners != null) 
                                            {
                                                List<string> trustedSignersTrustedSignersitemsList = trustedSignersTrustedSigners.Items;
                                                if (trustedSignersTrustedSignersitemsList != null && trustedSignersTrustedSignersitemsList.Count > 0) 
                                                {
                                                    int trustedSignersTrustedSignersitemsListIndex = 1;
                                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                                                    foreach (string trustedSignersTrustedSignersitemsListValue in trustedSignersTrustedSignersitemsList) 
                                                    {
                                                        xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
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
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetViewerProtocolPolicy()) 
                                    {
                                        xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cacheBehaviorsCacheBehaviorsitemsListValue.ViewerProtocolPolicy.ToString());
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetMinTTL()) 
                                    {
                                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2013-05-12/", cacheBehaviorsCacheBehaviorsitemsListValue.MinTTL.ToString());
                                      }
                                xmlWriter.WriteEndElement();


                                    cacheBehaviorsCacheBehaviorsitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig.IsSetComment()) 
                {
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2013-05-12/", distributionConfigDistributionConfig.Comment.ToString());
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    LoggingConfig loggingConfigLogging = distributionConfigDistributionConfig.Logging;
                    if (loggingConfigLogging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                        if (loggingConfigLogging.IsSetEnabled()) 
                        {
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-05-12/", loggingConfigLogging.Enabled.ToString().ToLower());
                          }
                        if (loggingConfigLogging.IsSetIncludeCookies()) 
                        {
                            xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2013-05-12/", loggingConfigLogging.IncludeCookies.ToString().ToLower());
                          }
                        if (loggingConfigLogging.IsSetBucket()) 
                        {
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2013-05-12/", loggingConfigLogging.Bucket.ToString());
                          }
                        if (loggingConfigLogging.IsSetPrefix()) 
                        {
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2013-05-12/", loggingConfigLogging.Prefix.ToString());
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig.IsSetPriceClass()) 
                {
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2013-05-12/", distributionConfigDistributionConfig.PriceClass.ToString());
                  }
                if (distributionConfigDistributionConfig.IsSetEnabled()) 
                {
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-05-12/", distributionConfigDistributionConfig.Enabled.ToString().ToLower());
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    ViewerCertificate viewerCertificateViewerCertificate = distributionConfigDistributionConfig.ViewerCertificate;
                    if (viewerCertificateViewerCertificate != null) 
                    {
                        xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2013-05-12/");
                        if (viewerCertificateViewerCertificate.IsSetIAMCertificateId()) 
                        {
                            xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2013-05-12/", viewerCertificateViewerCertificate.IAMCertificateId.ToString());
                          }
                        if (viewerCertificateViewerCertificate.IsSetCloudFrontDefaultCertificate()) 
                        {
                            xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2013-05-12/", viewerCertificateViewerCertificate.CloudFrontDefaultCertificate.ToString().ToLower());
                          }
                        xmlWriter.WriteEndElement();
                    }
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
    
