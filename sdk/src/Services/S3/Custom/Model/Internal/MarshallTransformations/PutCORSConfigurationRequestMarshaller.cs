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
    /// Put Bucket Cors Request Marshaller
    /// </summary>       
    public class PutCORSConfigurationRequestMarshaller : IMarshaller<IRequest, PutCORSConfigurationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutCORSConfigurationRequest)input);
		}

        public IRequest Marshall(PutCORSConfigurationRequest putCORSConfigurationRequest)
        {
            IRequest request = new DefaultRequest(putCORSConfigurationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putCORSConfigurationRequest.BucketName));

            request.AddSubResource("cors");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                var configuration = putCORSConfigurationRequest.Configuration;
                if (configuration != null)
                {
                    xmlWriter.WriteStartElement("CORSConfiguration", "");

                    if (configuration != null)
                    {
                        var cORSConfigurationCORSConfigurationcORSRulesList = configuration.Rules;
                        if (cORSConfigurationCORSConfigurationcORSRulesList != null && cORSConfigurationCORSConfigurationcORSRulesList.Count > 0)
                        {
                            foreach (var cORSConfigurationCORSConfigurationcORSRulesListValue in cORSConfigurationCORSConfigurationcORSRulesList)
                            {
                                xmlWriter.WriteStartElement("CORSRule", "");

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue != null)
                                {
                                    var cORSRuleMemberallowedMethodsList = cORSConfigurationCORSConfigurationcORSRulesListValue.AllowedMethods;
                                    if (cORSRuleMemberallowedMethodsList != null && cORSRuleMemberallowedMethodsList.Count > 0)
                                    {
                                        foreach (string cORSRuleMemberallowedMethodsListValue in cORSRuleMemberallowedMethodsList)
                                        {
                                            xmlWriter.WriteStartElement("AllowedMethod", "");
                                            xmlWriter.WriteValue(cORSRuleMemberallowedMethodsListValue);
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue != null)
                                {
                                    var cORSRuleMemberallowedOriginsList = cORSConfigurationCORSConfigurationcORSRulesListValue.AllowedOrigins;
                                    if (cORSRuleMemberallowedOriginsList != null && cORSRuleMemberallowedOriginsList.Count > 0)
                                    {
                                        foreach (string cORSRuleMemberallowedOriginsListValue in cORSRuleMemberallowedOriginsList)
                                        {
                                            xmlWriter.WriteStartElement("AllowedOrigin", "");
                                            xmlWriter.WriteValue(cORSRuleMemberallowedOriginsListValue);
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue != null)
                                {
                                    var cORSRuleMemberexposeHeadersList = cORSConfigurationCORSConfigurationcORSRulesListValue.ExposeHeaders;
                                    if (cORSRuleMemberexposeHeadersList != null && cORSRuleMemberexposeHeadersList.Count > 0)
                                    {
                                        foreach (string cORSRuleMemberexposeHeadersListValue in cORSRuleMemberexposeHeadersList)
                                        {
                                            xmlWriter.WriteStartElement("ExposeHeader", "");
                                            xmlWriter.WriteValue(cORSRuleMemberexposeHeadersListValue);
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue != null)
                                {
                                    var cORSRuleMemberallowedHeadersList = cORSConfigurationCORSConfigurationcORSRulesListValue.AllowedHeaders;
                                    if (cORSRuleMemberallowedHeadersList != null && cORSRuleMemberallowedHeadersList.Count > 0)
                                    {
                                        foreach (string cORSRuleMemberallowedHeadersListValue in cORSRuleMemberallowedHeadersList)
                                        {
                                            xmlWriter.WriteStartElement("AllowedHeader", "");
                                            xmlWriter.WriteValue(cORSRuleMemberallowedHeadersListValue);
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue.IsSetMaxAgeSeconds())
                                {
                                    xmlWriter.WriteElementString("MaxAgeSeconds", "", S3Transforms.ToXmlStringValue(cORSConfigurationCORSConfigurationcORSRulesListValue.MaxAgeSeconds));
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue.IsSetId())
                                {
                                    xmlWriter.WriteElementString("ID", "", S3Transforms.ToXmlStringValue(cORSConfigurationCORSConfigurationcORSRulesListValue.Id));
                                }

                                xmlWriter.WriteEndElement();
                            }
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

