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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
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
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetBucket())
                throw new AmazonS3ControlException("Request object does not have required field Bucket set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Bucket));
            request.ResourcePath = "/v20180820/bucket/{name}/replication";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetReplicationConfiguration())
                {
                    xmlWriter.WriteStartElement("ReplicationConfiguration", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    if(publicRequest.ReplicationConfiguration.IsSetRole())
                        xmlWriter.WriteElementString("Role", StringUtils.FromString(publicRequest.ReplicationConfiguration.Role));

                    var publicRequestReplicationConfigurationRules = publicRequest.ReplicationConfiguration.Rules;
                    if (publicRequest.ReplicationConfiguration.IsSetRules()) 
                    {
                        xmlWriter.WriteStartElement("Rules");
                        foreach (var publicRequestReplicationConfigurationRulesValue in publicRequestReplicationConfigurationRules) 
                        {
                        if (publicRequestReplicationConfigurationRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if(publicRequestReplicationConfigurationRulesValue.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Bucket));
                            if (publicRequestReplicationConfigurationRulesValue.IsSetDeleteMarkerReplication())
                            {
                                xmlWriter.WriteStartElement("DeleteMarkerReplication");
                                if(publicRequestReplicationConfigurationRulesValue.DeleteMarkerReplication.IsSetStatus())
                                    xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.DeleteMarkerReplication.Status));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestReplicationConfigurationRulesValue.IsSetDestination())
                            {
                                xmlWriter.WriteStartElement("Destination");
                                if (publicRequestReplicationConfigurationRulesValue.Destination.IsSetAccessControlTranslation())
                                {
                                    xmlWriter.WriteStartElement("AccessControlTranslation");
                                    if(publicRequestReplicationConfigurationRulesValue.Destination.AccessControlTranslation.IsSetOwner())
                                        xmlWriter.WriteElementString("Owner", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.AccessControlTranslation.Owner));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestReplicationConfigurationRulesValue.Destination.IsSetAccount())
                                    xmlWriter.WriteElementString("Account", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.Account));
                                if(publicRequestReplicationConfigurationRulesValue.Destination.IsSetBucket())
                                    xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.Bucket));
                                if (publicRequestReplicationConfigurationRulesValue.Destination.IsSetEncryptionConfiguration())
                                {
                                    xmlWriter.WriteStartElement("EncryptionConfiguration");
                                    if(publicRequestReplicationConfigurationRulesValue.Destination.EncryptionConfiguration.IsSetReplicaKmsKeyID())
                                        xmlWriter.WriteElementString("ReplicaKmsKeyID", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.EncryptionConfiguration.ReplicaKmsKeyID));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestReplicationConfigurationRulesValue.Destination.IsSetMetrics())
                                {
                                    xmlWriter.WriteStartElement("Metrics");
                                    if (publicRequestReplicationConfigurationRulesValue.Destination.Metrics.IsSetEventThreshold())
                                    {
                                        xmlWriter.WriteStartElement("EventThreshold");
                                        if(publicRequestReplicationConfigurationRulesValue.Destination.Metrics.EventThreshold.IsSetMinutes())
                                            xmlWriter.WriteElementString("Minutes", StringUtils.FromInt(publicRequestReplicationConfigurationRulesValue.Destination.Metrics.EventThreshold.Minutes.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestReplicationConfigurationRulesValue.Destination.Metrics.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.Metrics.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestReplicationConfigurationRulesValue.Destination.IsSetReplicationTime())
                                {
                                    xmlWriter.WriteStartElement("ReplicationTime");
                                    if(publicRequestReplicationConfigurationRulesValue.Destination.ReplicationTime.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.ReplicationTime.Status));
                                    if (publicRequestReplicationConfigurationRulesValue.Destination.ReplicationTime.IsSetTime())
                                    {
                                        xmlWriter.WriteStartElement("Time");
                                        if(publicRequestReplicationConfigurationRulesValue.Destination.ReplicationTime.Time.IsSetMinutes())
                                            xmlWriter.WriteElementString("Minutes", StringUtils.FromInt(publicRequestReplicationConfigurationRulesValue.Destination.ReplicationTime.Time.Minutes.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestReplicationConfigurationRulesValue.Destination.IsSetStorageClass())
                                    xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Destination.StorageClass));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestReplicationConfigurationRulesValue.IsSetExistingObjectReplication())
                            {
                                xmlWriter.WriteStartElement("ExistingObjectReplication");
                                if(publicRequestReplicationConfigurationRulesValue.ExistingObjectReplication.IsSetStatus())
                                    xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.ExistingObjectReplication.Status));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestReplicationConfigurationRulesValue.IsSetFilter())
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestReplicationConfigurationRulesValue.Filter.IsSetAnd())
                                {
                                    xmlWriter.WriteStartElement("And");
                                    if(publicRequestReplicationConfigurationRulesValue.Filter.And.IsSetPrefix())
                                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Filter.And.Prefix));
                                    var publicRequestReplicationConfigurationRulesValueFilterAndTags = publicRequestReplicationConfigurationRulesValue.Filter.And.Tags;
                                    if (publicRequestReplicationConfigurationRulesValue.Filter.And.IsSetTags()) 
                                    {
                                        xmlWriter.WriteStartElement("Tags");
                                        foreach (var publicRequestReplicationConfigurationRulesValueFilterAndTagsValue in publicRequestReplicationConfigurationRulesValueFilterAndTags) 
                                        {
                                        if (publicRequestReplicationConfigurationRulesValueFilterAndTagsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("member");
                                            if(publicRequestReplicationConfigurationRulesValueFilterAndTagsValue.IsSetKey())
                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestReplicationConfigurationRulesValueFilterAndTagsValue.Key));
                                            if(publicRequestReplicationConfigurationRulesValueFilterAndTagsValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestReplicationConfigurationRulesValueFilterAndTagsValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestReplicationConfigurationRulesValue.Filter.IsSetPrefix())
                                    xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Filter.Prefix));
                                if (publicRequestReplicationConfigurationRulesValue.Filter.IsSetTag())
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestReplicationConfigurationRulesValue.Filter.Tag.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Filter.Tag.Key));
                                    if(publicRequestReplicationConfigurationRulesValue.Filter.Tag.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Filter.Tag.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestReplicationConfigurationRulesValue.IsSetID())
                                xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.ID));
                            if(publicRequestReplicationConfigurationRulesValue.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Prefix));
                            if(publicRequestReplicationConfigurationRulesValue.IsSetPriority())
                                xmlWriter.WriteElementString("Priority", StringUtils.FromInt(publicRequestReplicationConfigurationRulesValue.Priority.Value));
                            if (publicRequestReplicationConfigurationRulesValue.IsSetSourceSelectionCriteria())
                            {
                                xmlWriter.WriteStartElement("SourceSelectionCriteria");
                                if (publicRequestReplicationConfigurationRulesValue.SourceSelectionCriteria.IsSetReplicaModifications())
                                {
                                    xmlWriter.WriteStartElement("ReplicaModifications");
                                    if(publicRequestReplicationConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestReplicationConfigurationRulesValue.SourceSelectionCriteria.IsSetSseKmsEncryptedObjects())
                                {
                                    xmlWriter.WriteStartElement("SseKmsEncryptedObjects");
                                    if(publicRequestReplicationConfigurationRulesValue.SourceSelectionCriteria.SseKmsEncryptedObjects.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.SourceSelectionCriteria.SseKmsEncryptedObjects.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestReplicationConfigurationRulesValue.IsSetStatus())
                                xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestReplicationConfigurationRulesValue.Status));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
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
                ChecksumUtils.SetChecksumData(request);
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
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
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutBucketReplicationRequest publicRequest);
    }    
}