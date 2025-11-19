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

using System;
using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System.Globalization;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class PutBucketEncryptionRequestMarshaller : IMarshaller<IRequest, PutBucketEncryptionRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketEncryptionRequest)input);
        }
        public IRequest Marshall(PutBucketEncryptionRequest putBucketEncryptionRequest)
        {
            IRequest request = new DefaultRequest(putBucketEncryptionRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketEncryptionRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putBucketEncryptionRequest.ChecksumAlgorithm));

            if (putBucketEncryptionRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketEncryptionRequest.ExpectedBucketOwner));

            if (putBucketEncryptionRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(putBucketEncryptionRequest.ContentMD5));

            if (string.IsNullOrEmpty(putBucketEncryptionRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketEncryptionRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("encryption");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                if (putBucketEncryptionRequest.IsSetServerSideEncryptionConfiguration())
                {
                    var sseConfiguration = putBucketEncryptionRequest.ServerSideEncryptionConfiguration;
                    xmlWriter.WriteStartElement("ServerSideEncryptionConfiguration", S3Constants.S3RequestXmlNamespace);
                    if (sseConfiguration != null)
                    {
                        if (sseConfiguration.ServerSideEncryptionRules != null)
                        {
                            foreach (var serverSideEncryptionRule in sseConfiguration.ServerSideEncryptionRules)
                            {
                                xmlWriter.WriteStartElement("Rule");
                                if (serverSideEncryptionRule.BlockedEncryptionTypes != null)
                                {
                                    xmlWriter.WriteStartElement("BlockedEncryptionTypes");
                                    var serverSideEncryptionRuleBlockedEncryptionTypesEncryptionType = serverSideEncryptionRule.BlockedEncryptionTypes.EncryptionType;
                                    if (serverSideEncryptionRuleBlockedEncryptionTypesEncryptionType != null && (serverSideEncryptionRuleBlockedEncryptionTypesEncryptionType.Count > 0 || !AWSConfigs.InitializeCollections))
                                    {
                                        foreach (var serverSideEncryptionRuleBlockedEncryptionTypesEncryptionTypeValue in serverSideEncryptionRuleBlockedEncryptionTypesEncryptionType)
                                        {
                                            xmlWriter.WriteStartElement("EncryptionType");
                                            xmlWriter.WriteValue(serverSideEncryptionRuleBlockedEncryptionTypesEncryptionTypeValue);
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (serverSideEncryptionRule != null)
                                {
                                    if (serverSideEncryptionRule.IsSetServerSideEncryptionByDefault())
                                    {
                                        xmlWriter.WriteStartElement("ApplyServerSideEncryptionByDefault");
                                        var sseDefault = serverSideEncryptionRule.ServerSideEncryptionByDefault;
                                        if (sseDefault.IsSetServerSideEncryptionAlgorithm())
                                        {
                                            xmlWriter.WriteElementString("SSEAlgorithm", S3Transforms.ToXmlStringValue(sseDefault.ServerSideEncryptionAlgorithm));
                                        }
                                        if (sseDefault.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                                        {
                                            xmlWriter.WriteElementString("KMSMasterKeyID", S3Transforms.ToXmlStringValue(sseDefault.ServerSideEncryptionKeyManagementServiceKeyId));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }

                                    if (serverSideEncryptionRule.IsSetBucketKeyEnabled())
                                    {
                                        xmlWriter.WriteElementString("BucketKeyEnabled", S3Transforms.ToXmlStringValue(serverSideEncryptionRule.BucketKeyEnabled));
                                    }
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
                    putBucketEncryptionRequest.ChecksumAlgorithm, 
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

        private static PutBucketEncryptionRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketEncryptionRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketEncryptionRequestMarshaller();
                }
                return _instance;
            }
        }

    }
}