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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBucketReplication Request Marshaller
    /// </summary>       
    public partial class PutBucketReplicationRequestMarshaller : IMarshaller<IRequest, PutBucketReplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketReplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketReplicationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("replication");
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetContentMD5()) 
            {
                request.Headers["Content-MD5"] = publicRequest.ContentMD5;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetToken()) 
            {
                request.Headers["x-amz-bucket-object-lock-token"] = publicRequest.Token;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketReplicationRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetConfiguration())
                {
                    xmlWriter.WriteStartElement("ReplicationConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if(publicRequest.Configuration.IsSetRole())
                        xmlWriter.WriteElementString("Role", StringUtils.FromString(publicRequest.Configuration.Role));

                    var publicRequestConfigurationRules = publicRequest.Configuration.Rules;
                    if (publicRequestConfigurationRules != null && (publicRequestConfigurationRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestConfigurationRulesValue in publicRequestConfigurationRules) 
                        {
                        if (publicRequestConfigurationRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if (publicRequestConfigurationRulesValue.DeleteMarkerReplication != null)
                            {
                                xmlWriter.WriteStartElement("DeleteMarkerReplication");
                                if(publicRequestConfigurationRulesValue.DeleteMarkerReplication.IsSetStatus())
                                    xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.DeleteMarkerReplication.Status));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestConfigurationRulesValue.Destination != null)
                            {
                                xmlWriter.WriteStartElement("Destination");
                                if (publicRequestConfigurationRulesValue.Destination.AccessControlTranslation != null)
                                {
                                    xmlWriter.WriteStartElement("AccessControlTranslation");
                                    if(publicRequestConfigurationRulesValue.Destination.AccessControlTranslation.IsSetOwner())
                                        xmlWriter.WriteElementString("Owner", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.AccessControlTranslation.Owner));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestConfigurationRulesValue.Destination.IsSetAccountId())
                                    xmlWriter.WriteElementString("Account", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.AccountId));
                                if(publicRequestConfigurationRulesValue.Destination.IsSetBucketArn())
                                    xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.BucketArn));
                                if (publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration != null)
                                {
                                    xmlWriter.WriteStartElement("EncryptionConfiguration");
                                    if(publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.IsSetReplicaKmsKeyID())
                                        xmlWriter.WriteElementString("ReplicaKmsKeyID", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.ReplicaKmsKeyID));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestConfigurationRulesValue.Destination.Metrics != null)
                                {
                                    xmlWriter.WriteStartElement("Metrics");
                                    if (publicRequestConfigurationRulesValue.Destination.Metrics.EventThreshold != null)
                                    {
                                        xmlWriter.WriteStartElement("EventThreshold");
                                        if(publicRequestConfigurationRulesValue.Destination.Metrics.EventThreshold.IsSetMinutes())
                                            xmlWriter.WriteElementString("Minutes", StringUtils.FromInt(publicRequestConfigurationRulesValue.Destination.Metrics.EventThreshold.Minutes.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestConfigurationRulesValue.Destination.Metrics.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.Metrics.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestConfigurationRulesValue.Destination.ReplicationTime != null)
                                {
                                    xmlWriter.WriteStartElement("ReplicationTime");
                                    if(publicRequestConfigurationRulesValue.Destination.ReplicationTime.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.ReplicationTime.Status));
                                    if (publicRequestConfigurationRulesValue.Destination.ReplicationTime.Time != null)
                                    {
                                        xmlWriter.WriteStartElement("Time");
                                        if(publicRequestConfigurationRulesValue.Destination.ReplicationTime.Time.IsSetMinutes())
                                            xmlWriter.WriteElementString("Minutes", StringUtils.FromInt(publicRequestConfigurationRulesValue.Destination.ReplicationTime.Time.Minutes.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestConfigurationRulesValue.Destination.IsSetStorageClass())
                                    xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.StorageClass));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestConfigurationRulesValue.ExistingObjectReplication != null)
                            {
                                xmlWriter.WriteStartElement("ExistingObjectReplication");
                                if(publicRequestConfigurationRulesValue.ExistingObjectReplication.IsSetStatus())
                                    xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.ExistingObjectReplication.Status));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestConfigurationRulesValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestConfigurationRulesValue.Filter.And != null)
                                {
                                    xmlWriter.WriteStartElement("And");
                                    if(publicRequestConfigurationRulesValue.Filter.And.IsSetPrefix())
                                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Prefix));
                                    var publicRequestConfigurationRulesValueFilterAndTags = publicRequestConfigurationRulesValue.Filter.And.Tags;
                                    if (publicRequestConfigurationRulesValueFilterAndTags != null && (publicRequestConfigurationRulesValueFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        foreach (var publicRequestConfigurationRulesValueFilterAndTagsValue in publicRequestConfigurationRulesValueFilterAndTags) 
                                        {
                                        if (publicRequestConfigurationRulesValueFilterAndTagsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("Tag");
                                            if(publicRequestConfigurationRulesValueFilterAndTagsValue.IsSetKey())
                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndTagsValue.Key));
                                            if(publicRequestConfigurationRulesValueFilterAndTagsValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndTagsValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestConfigurationRulesValue.Filter.IsSetPrefix())
                                    xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Prefix));
                                if (publicRequestConfigurationRulesValue.Filter.Tag != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestConfigurationRulesValue.Filter.Tag.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Tag.Key));
                                    if(publicRequestConfigurationRulesValue.Filter.Tag.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Tag.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestConfigurationRulesValue.IsSetId())
                                xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestConfigurationRulesValue.Id));
                            if(publicRequestConfigurationRulesValue.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Prefix));
                            if(publicRequestConfigurationRulesValue.IsSetPriority())
                                xmlWriter.WriteElementString("Priority", StringUtils.FromInt(publicRequestConfigurationRulesValue.Priority.Value));
                            if (publicRequestConfigurationRulesValue.SourceSelectionCriteria != null)
                            {
                                xmlWriter.WriteStartElement("SourceSelectionCriteria");
                                if (publicRequestConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications != null)
                                {
                                    xmlWriter.WriteStartElement("ReplicaModifications");
                                    if(publicRequestConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestConfigurationRulesValue.SourceSelectionCriteria.SseKmsEncryptedObjects != null)
                                {
                                    xmlWriter.WriteStartElement("SseKmsEncryptedObjects");
                                    if(publicRequestConfigurationRulesValue.SourceSelectionCriteria.SseKmsEncryptedObjects.IsSetSseKmsEncryptedObjectsStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.SourceSelectionCriteria.SseKmsEncryptedObjects.SseKmsEncryptedObjectsStatus));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestConfigurationRulesValue.IsSetStatus())
                                xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.Status));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetChecksumData(
                    request,
                    publicRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: true,
                    headerName: "x-amz-sdk-checksum-algorithm"
                );
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static PutBucketReplicationRequestMarshaller _instance = new PutBucketReplicationRequestMarshaller();        

        internal static PutBucketReplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketReplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketReplicationRequest publicRequest);
    }    
}