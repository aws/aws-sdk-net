/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Put Buckeyt Replication Request Marshaller
    /// </summary>
    public class PutBucketReplicationRequestMarshaller : IMarshaller<IRequest, PutBucketReplicationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketReplicationRequest)input);
        }

        public IRequest Marshall(PutBucketReplicationRequest putBucketreplicationRequest)
        {
            IRequest request = new DefaultRequest(putBucketreplicationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketreplicationRequest.BucketName));

            request.AddSubResource("replication");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                var replicationConfiguration = putBucketreplicationRequest.Configuration;

                if (replicationConfiguration != null)
                {
                xmlWriter.WriteStartElement("ReplicationConfiguration", "");
                if (replicationConfiguration.Role != null)
                {
                    xmlWriter.WriteElementString("Role", "", S3Transforms.ToXmlStringValue(replicationConfiguration.Role));
                }
                if (replicationConfiguration.Rules != null)
                {
                    foreach (var rule in replicationConfiguration.Rules)
                    {
                        xmlWriter.WriteStartElement("Rule");
                        if (rule.IsSetId())
                        {
                            xmlWriter.WriteElementString("ID", "", S3Transforms.ToXmlStringValue(rule.Id));
                        }
                        if (rule.IsSetPrefix())
                        {
                            xmlWriter.WriteElementString("Prefix", "", S3Transforms.ToXmlStringValue(rule.Prefix));
                        }
                        else // Write an empty Prefix tag
                        {
                            xmlWriter.WriteElementString("Prefix", "", S3Transforms.ToXmlStringValue(""));
                        }

                        if (rule.IsSetStatus())
                        {
                            xmlWriter.WriteElementString("Status", "", S3Transforms.ToXmlStringValue(rule.Status.ToString()));
                        }
                        if (rule.IsSetDestination())
                        {
                            xmlWriter.WriteStartElement("Destination", "");
                            if (rule.Destination.IsSetBucketArn())
                            {
                                xmlWriter.WriteElementString("Bucket", "", rule.Destination.BucketArn);
                            }
                            if (rule.Destination.IsSetStorageClass())
                            {
                                xmlWriter.WriteElementString("StorageClass", "", rule.Destination.StorageClass);
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
