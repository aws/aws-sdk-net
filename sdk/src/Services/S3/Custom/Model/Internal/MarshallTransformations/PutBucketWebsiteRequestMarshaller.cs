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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Website Request Marshaller
    /// </summary>       
    public class PutBucketWebsiteRequestMarshaller : IMarshaller<IRequest, PutBucketWebsiteRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketWebsiteRequest)input);
		}

        public IRequest Marshall(PutBucketWebsiteRequest putBucketWebsiteRequest)
        {
            IRequest request = new DefaultRequest(putBucketWebsiteRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketWebsiteRequest.BucketName));

            request.AddSubResource("website");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                var websiteConfigurationWebsiteConfiguration = putBucketWebsiteRequest.WebsiteConfiguration;
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
                        var redirectAllRequestsToRedirectAllRequestsTo = websiteConfigurationWebsiteConfiguration.RedirectAllRequestsTo;
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
                        var websiteConfigurationWebsiteConfigurationroutingRulesList = websiteConfigurationWebsiteConfiguration.RoutingRules;
                        if (websiteConfigurationWebsiteConfigurationroutingRulesList != null && websiteConfigurationWebsiteConfigurationroutingRulesList.Count > 0)
                        {
                            xmlWriter.WriteStartElement("RoutingRules", "");
                            foreach (var websiteConfigurationWebsiteConfigurationroutingRulesListValue in websiteConfigurationWebsiteConfigurationroutingRulesList)
                            {
                                xmlWriter.WriteStartElement("RoutingRule", "");
                                if (websiteConfigurationWebsiteConfigurationroutingRulesListValue != null)
                                {
                                    var conditionCondition = websiteConfigurationWebsiteConfigurationroutingRulesListValue.Condition;
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
                                    var redirectRedirect = websiteConfigurationWebsiteConfigurationroutingRulesListValue.Redirect;
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
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
    }
}

