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

using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Website Request Marshaller
    /// </summary>       
    public class PutBucketWebsiteRequestMarshaller : IMarshaller<IRequest, PutBucketWebsiteRequest>
    {


        public IRequest Marshall(PutBucketWebsiteRequest putBucketWebsiteRequest)
        {
            IRequest request = new DefaultRequest(putBucketWebsiteRequest, "AmazonS3");



            request.HttpMethod = "PUT";

            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}/?website";
            uriResourcePath = uriResourcePath.Replace("{Bucket}", putBucketWebsiteRequest.IsSetBucketName() ? S3Transforms.ToStringValue(putBucketWebsiteRequest.BucketName) : "");
            string path = uriResourcePath;


            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
            if (queryIndex != -1)
            {
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                path = uriResourcePath.Substring(0, queryIndex);

                S3Transforms.BuildQueryParameterMap(request, queryParameters, queryString);
            }

            request.CanonicalResource = S3Transforms.GetCanonicalResource(path, queryParameters);
            uriResourcePath = S3Transforms.FormatResourcePath(path, queryParameters);

            request.ResourcePath = uriResourcePath;


            StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {


                if (putBucketWebsiteRequest != null)
                {
                    WebsiteConfiguration websiteConfigurationWebsiteConfiguration = putBucketWebsiteRequest.WebsiteConfiguration;
                    if (websiteConfigurationWebsiteConfiguration != null)
                    {
                        xmlWriter.WriteStartElement("WebsiteConfiguration", "");
                        if (websiteConfigurationWebsiteConfiguration != null)
                        {
                            string errorDocumentErrorDocument = websiteConfigurationWebsiteConfiguration.ErrorDocument;
                            if (errorDocumentErrorDocument != null)
                            {
                                xmlWriter.WriteStartElement("ErrorDocument", "");
                                xmlWriter.WriteElementString("Key", "", S3Transforms.ToXmlStringValue(errorDocumentErrorDocument));
                                xmlWriter.WriteEndElement();
                            }
                        }
                        if (websiteConfigurationWebsiteConfiguration != null)
                        {
                            string indexDocumentIndexDocument = websiteConfigurationWebsiteConfiguration.IndexDocumentSuffix;
                            if (indexDocumentIndexDocument != null)
                            {
                                xmlWriter.WriteStartElement("IndexDocument", "");
                                xmlWriter.WriteElementString("Suffix", "", S3Transforms.ToXmlStringValue(indexDocumentIndexDocument));
                                xmlWriter.WriteEndElement();
                            }
                        }
                        if (websiteConfigurationWebsiteConfiguration != null)
                        {
                            RoutingRuleRedirect redirectAllRequestsToRedirectAllRequestsTo = websiteConfigurationWebsiteConfiguration.RedirectAllRequestsTo;
                            if (redirectAllRequestsToRedirectAllRequestsTo != null)
                            {
                                xmlWriter.WriteStartElement("RedirectAllRequestsTo", "");
                                if (redirectAllRequestsToRedirectAllRequestsTo.IsSetHostName())
                                {
                                    xmlWriter.WriteElementString("HostName", "", S3Transforms.ToXmlStringValue(redirectAllRequestsToRedirectAllRequestsTo.HostName));
                                }
                                if (redirectAllRequestsToRedirectAllRequestsTo.IsSetHttpRedirectCode())
                                {
                                    xmlWriter.WriteElementString("HttpRedirectCode", "", S3Transforms.ToXmlStringValue(redirectAllRequestsToRedirectAllRequestsTo.HttpRedirectCode));
                                }
                                if (redirectAllRequestsToRedirectAllRequestsTo.IsSetProtocol())
                                {
                                    xmlWriter.WriteElementString("Protocol", "", S3Transforms.ToXmlStringValue(redirectAllRequestsToRedirectAllRequestsTo.Protocol));
                                }
                                if (redirectAllRequestsToRedirectAllRequestsTo.IsSetReplaceKeyPrefixWith())
                                {
                                    xmlWriter.WriteElementString("ReplaceKeyPrefixWith", "", S3Transforms.ToXmlStringValue(redirectAllRequestsToRedirectAllRequestsTo.ReplaceKeyPrefixWith));
                                }
                                if (redirectAllRequestsToRedirectAllRequestsTo.IsSetReplaceKeyWith())
                                {
                                    xmlWriter.WriteElementString("ReplaceKeyWith", "", S3Transforms.ToXmlStringValue(redirectAllRequestsToRedirectAllRequestsTo.ReplaceKeyWith));
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }

                        if (websiteConfigurationWebsiteConfiguration != null)
                        {
                            List<RoutingRule> websiteConfigurationWebsiteConfigurationroutingRulesList = websiteConfigurationWebsiteConfiguration.RoutingRules;
                            if (websiteConfigurationWebsiteConfigurationroutingRulesList != null && websiteConfigurationWebsiteConfigurationroutingRulesList.Count > 0)
                            {
                                int websiteConfigurationWebsiteConfigurationroutingRulesListIndex = 1;
                                xmlWriter.WriteStartElement("RoutingRules", "");
                                foreach (RoutingRule websiteConfigurationWebsiteConfigurationroutingRulesListValue in websiteConfigurationWebsiteConfigurationroutingRulesList)
                                {
                                    xmlWriter.WriteStartElement("RoutingRule", "");
                                    if (websiteConfigurationWebsiteConfigurationroutingRulesListValue != null)
                                    {
                                        RoutingRuleCondition conditionCondition = websiteConfigurationWebsiteConfigurationroutingRulesListValue.Condition;
                                        if (conditionCondition != null)
                                        {
                                            xmlWriter.WriteStartElement("Condition", "");
                                            if (conditionCondition.IsSetHttpErrorCodeReturnedEquals())
                                            {
                                                xmlWriter.WriteElementString("HttpErrorCodeReturnedEquals", "", S3Transforms.ToXmlStringValue(conditionCondition.HttpErrorCodeReturnedEquals));
                                            }
                                            if (conditionCondition.IsSetKeyPrefixEquals())
                                            {
                                                xmlWriter.WriteElementString("KeyPrefixEquals", "", S3Transforms.ToXmlStringValue(conditionCondition.KeyPrefixEquals));
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (websiteConfigurationWebsiteConfigurationroutingRulesListValue != null)
                                    {
                                        RoutingRuleRedirect redirectRedirect = websiteConfigurationWebsiteConfigurationroutingRulesListValue.Redirect;
                                        if (redirectRedirect != null)
                                        {
                                            xmlWriter.WriteStartElement("Redirect", "");
                                            if (redirectRedirect.IsSetHostName())
                                            {
                                                xmlWriter.WriteElementString("HostName", "", S3Transforms.ToXmlStringValue(redirectRedirect.HostName));
                                            }
                                            if (redirectRedirect.IsSetHttpRedirectCode())
                                            {
                                                xmlWriter.WriteElementString("HttpRedirectCode", "", S3Transforms.ToXmlStringValue(redirectRedirect.HttpRedirectCode));
                                            }
                                            if (redirectRedirect.IsSetProtocol())
                                            {
                                                xmlWriter.WriteElementString("Protocol", "", S3Transforms.ToXmlStringValue(redirectRedirect.Protocol));
                                            }
                                            if (redirectRedirect.IsSetReplaceKeyPrefixWith())
                                            {
                                                xmlWriter.WriteElementString("ReplaceKeyPrefixWith", "", S3Transforms.ToXmlStringValue(redirectRedirect.ReplaceKeyPrefixWith));
                                            }
                                            if (redirectRedirect.IsSetReplaceKeyWith())
                                            {
                                                xmlWriter.WriteElementString("ReplaceKeyWith", "", S3Transforms.ToXmlStringValue(redirectRedirect.ReplaceKeyWith));
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    xmlWriter.WriteEndElement();


                                    websiteConfigurationWebsiteConfigurationroutingRulesListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
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


                request.Parameters[S3QueryParameter.ContentType.ToString()] = "application/xml";
                string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[Amazon.Util.AWSSDKUtils.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            if (!request.UseQueryString)
            {
                string queryString = Amazon.Util.AWSSDKUtils.GetParametersAsString(request.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    if (request.ResourcePath.Contains("?"))
                        request.ResourcePath = string.Concat(request.ResourcePath, "&", queryString);
                    else
                        request.ResourcePath = string.Concat(request.ResourcePath, "?", queryString);
                }
            }


            return request;
        }
    }
}

