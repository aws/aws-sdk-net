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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

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

            if (putCORSConfigurationRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putCORSConfigurationRequest.ChecksumAlgorithm));

            if (putCORSConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putCORSConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(putCORSConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutCORSConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("cors");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var configuration = putCORSConfigurationRequest.Configuration;
                if (configuration != null)
                {
                    xmlWriter.WriteStartElement("CORSConfiguration", S3Constants.S3RequestXmlNamespace);

                    if (configuration != null)
                    {
                        var cORSConfigurationCORSConfigurationcORSRulesList = configuration.Rules;
                        if (cORSConfigurationCORSConfigurationcORSRulesList != null && cORSConfigurationCORSConfigurationcORSRulesList.Count > 0)
                        {
                            foreach (var cORSConfigurationCORSConfigurationcORSRulesListValue in cORSConfigurationCORSConfigurationcORSRulesList)
                            {
                                xmlWriter.WriteStartElement("CORSRule");

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue != null)
                                {
                                    var cORSRuleMemberallowedMethodsList = cORSConfigurationCORSConfigurationcORSRulesListValue.AllowedMethods;
                                    if (cORSRuleMemberallowedMethodsList != null && cORSRuleMemberallowedMethodsList.Count > 0)
                                    {
                                        foreach (string cORSRuleMemberallowedMethodsListValue in cORSRuleMemberallowedMethodsList)
                                        {
                                            xmlWriter.WriteStartElement("AllowedMethod");
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
                                            xmlWriter.WriteStartElement("AllowedOrigin");
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
                                            xmlWriter.WriteStartElement("ExposeHeader");
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
                                            xmlWriter.WriteStartElement("AllowedHeader");
                                            xmlWriter.WriteValue(cORSRuleMemberallowedHeadersListValue);
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue.IsSetMaxAgeSeconds())
                                {
                                    xmlWriter.WriteElementString("MaxAgeSeconds", S3Transforms.ToXmlStringValue(cORSConfigurationCORSConfigurationcORSRulesListValue.MaxAgeSeconds.Value));
                                }

                                if (cORSConfigurationCORSConfigurationcORSRulesListValue.IsSetId())
                                {
                                    xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(cORSConfigurationCORSConfigurationcORSRulesListValue.Id));
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

                ChecksumUtils.SetChecksumData(
                    request, 
                    putCORSConfigurationRequest.ChecksumAlgorithm, 
                    fallbackToMD5: false, 
                    isRequestChecksumRequired: true,
                    headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
                );
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

	    private static PutCORSConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutCORSConfigurationRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new PutCORSConfigurationRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

