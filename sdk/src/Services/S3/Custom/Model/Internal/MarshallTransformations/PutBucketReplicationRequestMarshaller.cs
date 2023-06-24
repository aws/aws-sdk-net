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

            if (string.IsNullOrEmpty(putBucketreplicationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketReplicationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("replication");

            if (putBucketreplicationRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putBucketreplicationRequest.ChecksumAlgorithm));

            if (putBucketreplicationRequest.IsSetToken())
                request.Headers.Add("x-amz-bucket-object-lock-token", putBucketreplicationRequest.Token);

            if (putBucketreplicationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketreplicationRequest.ExpectedBucketOwner));

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var replicationConfiguration = putBucketreplicationRequest.Configuration;

                if (replicationConfiguration != null)
                {
                    xmlWriter.WriteStartElement("ReplicationConfiguration", S3Constants.S3RequestXmlNamespace);

                    if (replicationConfiguration.Role != null)
                    {
                        xmlWriter.WriteElementString("Role", S3Transforms.ToXmlStringValue(replicationConfiguration.Role));
                    }
                    if (replicationConfiguration.Rules != null)
                    {
                        foreach (var rule in replicationConfiguration.Rules)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if (rule.IsSetId())
                            {
                                xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(rule.Id));
                            }
                            if (rule.IsSetPriority())
                            {
                                xmlWriter.WriteElementString("Priority", S3Transforms.ToXmlStringValue(rule.Priority));
                            }
                            if (rule.IsSetPrefix())
                            {
                                xmlWriter.WriteElementString("Prefix", S3Transforms.ToXmlStringValue(rule.Prefix));
                            }

                            if (rule.IsSetFilter())
                            {
                                xmlWriter.WriteStartElement("Filter", "");
                                if (rule.Filter.IsSetPrefix())
                                {
                                    xmlWriter.WriteElementString("Prefix", S3Transforms.ToXmlStringValue(rule.Filter.Prefix));
                                }
                                if (rule.Filter.IsSetTag())
                                {
                                    rule.Filter.Tag.Marshall("Tag", xmlWriter);
                                }
                                if (rule.Filter.IsSetAnd())
                                {
                                    xmlWriter.WriteStartElement("And");
                                    if (rule.Filter.And.IsSetPrefix())
                                    {
                                        xmlWriter.WriteElementString("Prefix", S3Transforms.ToXmlStringValue(rule.Filter.And.Prefix));
                                    }
                                    if (rule.Filter.And.IsSetTags())
                                    {
                                        foreach (var tag in rule.Filter.And.Tags)
                                        {
                                            tag.Marshall("Tag", xmlWriter);
                                        }
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }

                            if (rule.IsSetStatus())
                            {
                                xmlWriter.WriteElementString("Status", S3Transforms.ToXmlStringValue(rule.Status.ToString()));
                            }
                            if (rule.IsSetSourceSelectionCriteria())
                            {
                                xmlWriter.WriteStartElement("SourceSelectionCriteria");
                                if (rule.SourceSelectionCriteria.IsSetSseKmsEncryptedObjects())
                                {
                                    xmlWriter.WriteStartElement("SseKmsEncryptedObjects");
                                    if (rule.SourceSelectionCriteria.SseKmsEncryptedObjects.IsSetSseKmsEncryptedObjectsStatus())
                                    {
                                        xmlWriter.WriteElementString("Status", rule.SourceSelectionCriteria.SseKmsEncryptedObjects.SseKmsEncryptedObjectsStatus);
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (rule.SourceSelectionCriteria.IsSetReplicaModifications())
                                {
                                    xmlWriter.WriteStartElement("ReplicaModifications");
                                    if (rule.SourceSelectionCriteria.ReplicaModifications.IsSetStatus())
                                    {
                                        xmlWriter.WriteElementString("Status", rule.SourceSelectionCriteria.ReplicaModifications.Status);
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if (rule.IsSetExistingObjectReplication())
                            {
                                xmlWriter.WriteStartElement("ExistingObjectReplication");
                                if (rule.ExistingObjectReplication.IsSetExistingObjectReplicationStatus())
                                {
                                    xmlWriter.WriteElementString("Status", rule.ExistingObjectReplication.Status);
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if (rule.IsSetDeleteMarkerReplication())
                            {
                                xmlWriter.WriteStartElement("DeleteMarkerReplication");
                                if (rule.DeleteMarkerReplication.IsSetStatus())
                                {
                                    xmlWriter.WriteElementString("Status", rule.DeleteMarkerReplication.Status);
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if (rule.IsSetDestination())
                            {
                                xmlWriter.WriteStartElement("Destination", "");
                                if (rule.Destination.IsSetBucketArn())
                                {
                                    xmlWriter.WriteElementString("Bucket", rule.Destination.BucketArn);
                                }
                                if (rule.Destination.IsSetStorageClass())
                                {
                                    xmlWriter.WriteElementString("StorageClass", rule.Destination.StorageClass);
                                }
                                if (rule.Destination.IsSetAccountId())
                                {
                                    xmlWriter.WriteElementString("Account", S3Transforms.ToXmlStringValue(rule.Destination.AccountId));
                                }
                                if (rule.Destination.IsSetEncryptionConfiguration())
                                {
                                    xmlWriter.WriteStartElement("EncryptionConfiguration");
                                    if (rule.Destination.EncryptionConfiguration.isSetReplicaKmsKeyID())
                                    {
                                        xmlWriter.WriteElementString("ReplicaKmsKeyID", S3Transforms.ToXmlStringValue(rule.Destination.EncryptionConfiguration.ReplicaKmsKeyID));
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (rule.Destination.IsSetMetrics())
                                {
                                    xmlWriter.WriteStartElement("Metrics");
                                    if (rule.Destination.Metrics.IsSetStatus())
                                    {
                                        xmlWriter.WriteElementString("Status", S3Transforms.ToXmlStringValue(rule.Destination.Metrics.Status));
                                    }
                                    if (rule.Destination.Metrics.IsSetEventThreshold())
                                    {
                                        xmlWriter.WriteStartElement("EventThreshold");
                                        if (rule.Destination.Metrics.EventThreshold.IsSetMinutes())
                                        {
                                            xmlWriter.WriteElementString("Minutes", S3Transforms.ToXmlStringValue(rule.Destination.Metrics.EventThreshold.Minutes));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (rule.Destination.IsSetReplicationTime())
                                {
                                    xmlWriter.WriteStartElement("ReplicationTime");
                                    if (rule.Destination.ReplicationTime.IsSetStatus())
                                    {
                                        xmlWriter.WriteElementString("Status", S3Transforms.ToXmlStringValue(rule.Destination.ReplicationTime.Status));
                                    }
                                    if (rule.Destination.ReplicationTime.IsSetTime())
                                    {
                                        xmlWriter.WriteStartElement("Time");
                                        if (rule.Destination.ReplicationTime.Time.IsSetMinutes())
                                        {
                                            xmlWriter.WriteElementString("Minutes", S3Transforms.ToXmlStringValue(rule.Destination.ReplicationTime.Time.Minutes));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (rule.Destination.IsSetAccessControlTranslation())
                                {
                                    xmlWriter.WriteStartElement("AccessControlTranslation");
                                    if (rule.Destination.AccessControlTranslation.IsSetOwner())
                                    {
                                        xmlWriter.WriteElementString("Owner", S3Transforms.ToXmlStringValue(rule.Destination.AccessControlTranslation.Owner));
                                    }
                                    xmlWriter.WriteEndElement();
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

                ChecksumUtils.SetRequestChecksum(request, putBucketreplicationRequest.ChecksumAlgorithm);
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        private static PutBucketReplicationRequestMarshaller _instance;

        public static PutBucketReplicationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketReplicationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
