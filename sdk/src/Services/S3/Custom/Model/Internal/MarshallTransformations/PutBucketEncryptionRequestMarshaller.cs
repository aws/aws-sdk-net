/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            
            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketEncryptionRequest.BucketName));

            request.AddSubResource("encryption");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                if (putBucketEncryptionRequest.IsSetServerSideEncryptionConfiguration())
                {
                    var sseConfiguration = putBucketEncryptionRequest.ServerSideEncryptionConfiguration;
                    xmlWriter.WriteStartElement("ServerSideEncryptionConfiguration", "");
                    if (sseConfiguration != null)
                    {
                        foreach(var serverSideEncryptionRule in sseConfiguration.ServerSideEncryptionRules)
                        {
                            xmlWriter.WriteStartElement("Rule", "");
                            if (serverSideEncryptionRule != null)
                            {
                                if (serverSideEncryptionRule.IsSetServerSideEncryptionByDefault())
                                {
                                    xmlWriter.WriteStartElement("ApplyServerSideEncryptionByDefault", "");
                                    var sseDefault = serverSideEncryptionRule.ServerSideEncryptionByDefault;
                                    if(sseDefault.IsSetServerSideEncryptionAlgorithm())
                                    {
                                        xmlWriter.WriteElementString("SSEAlgorithm", "", S3Transforms.ToXmlStringValue(sseDefault.ServerSideEncryptionAlgorithm));
                                    }
                                    if (sseDefault.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                                    {
                                        xmlWriter.WriteElementString("KMSMasterKeyID", "", S3Transforms.ToXmlStringValue(sseDefault.ServerSideEncryptionKeyManagementServiceKeyId));
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

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                if (putBucketEncryptionRequest.IsSetContentMD5())
                    checksum = putBucketEncryptionRequest.ContentMD5;
                
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        private static PutBucketEncryptionRequestMarshaller _instance;

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