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
            PreMarshallCustomization(request, publicRequest);
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
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            var bufferTextWriter = new XMLEncodedBufferTextWriter(((PooledContentStream)request.ContentStream).BufferWriter);
            using (var xmlWriter = XmlWriter.Create(bufferTextWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#else
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#endif
                if (publicRequest.IsSetConfiguration())
                {
                    xmlWriter.WriteStartElement("ReplicationConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if(publicRequest.Configuration.IsSetRole())
                        xmlWriter.WriteElementString("Role", StringUtils.FromString(publicRequest.Configuration.Role));

                    var publicRequestConfigurationRules = publicRequest.Configuration.Rules;
                    if (publicRequest.Configuration.IsSetRules()) 
                    {
                        foreach (var publicRequestConfigurationRulesValue in publicRequestConfigurationRules) 
                        {
                            if (publicRequestConfigurationRulesValue != null)
                            {
                                xmlWriter.WriteStartElement("Rule");
                                if (publicRequestConfigurationRulesValue.IsSetDeleteMarkerReplication())
                                {
                                    xmlWriter.WriteStartElement("DeleteMarkerReplication");
                                    if(publicRequestConfigurationRulesValue.DeleteMarkerReplication.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.DeleteMarkerReplication.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestConfigurationRulesValue.IsSetDestination())
                                {
                                    xmlWriter.WriteStartElement("Destination");
                                    if (publicRequestConfigurationRulesValue.Destination.IsSetAccessControlTranslation())
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
                                    if (publicRequestConfigurationRulesValue.Destination.IsSetEncryptionConfiguration())
                                    {
                                        xmlWriter.WriteStartElement("EncryptionConfiguration");
                                        if(publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.IsSetReplicaKmsKeyID())
                                            xmlWriter.WriteElementString("ReplicaKmsKeyID", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.ReplicaKmsKeyID));
                                        if (publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.IsSetUseSourceMultiRegionKey())
                                        {
                                            xmlWriter.WriteStartElement("UseSourceMultiRegionKey");
                                            if(publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.UseSourceMultiRegionKey.IsSetStatus())
                                                xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.EncryptionConfiguration.UseSourceMultiRegionKey.Status));
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestConfigurationRulesValue.Destination.IsSetMetrics())
                                    {
                                        xmlWriter.WriteStartElement("Metrics");
                                        if (publicRequestConfigurationRulesValue.Destination.Metrics.IsSetEventThreshold())
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
                                    if (publicRequestConfigurationRulesValue.Destination.IsSetReplicationTime())
                                    {
                                        xmlWriter.WriteStartElement("ReplicationTime");
                                        if(publicRequestConfigurationRulesValue.Destination.ReplicationTime.IsSetStatus())
                                            xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.Destination.ReplicationTime.Status));
                                        if (publicRequestConfigurationRulesValue.Destination.ReplicationTime.IsSetTime())
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
                                if (publicRequestConfigurationRulesValue.IsSetExistingObjectReplication())
                                {
                                    xmlWriter.WriteStartElement("ExistingObjectReplication");
                                    if(publicRequestConfigurationRulesValue.ExistingObjectReplication.IsSetStatus())
                                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.ExistingObjectReplication.Status));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestConfigurationRulesValue.IsSetFilter())
                                {
                                    xmlWriter.WriteStartElement("Filter");
                                    if (publicRequestConfigurationRulesValue.Filter.IsSetAnd())
                                    {
                                        xmlWriter.WriteStartElement("And");
                                        if (publicRequestConfigurationRulesValue.Filter.And.IsSetNot())
                                        {
                                            xmlWriter.WriteStartElement("Not");
                                            if (publicRequestConfigurationRulesValue.Filter.And.Not.IsSetOr())
                                            {
                                                xmlWriter.WriteStartElement("Or");
                                                var publicRequestConfigurationRulesValueFilterAndNotOrPrefixes = publicRequestConfigurationRulesValue.Filter.And.Not.Or.Prefixes;
                                                if (publicRequestConfigurationRulesValue.Filter.And.Not.Or.IsSetPrefixes()) 
                                                {
                                                    foreach (var publicRequestConfigurationRulesValueFilterAndNotOrPrefixesValue in publicRequestConfigurationRulesValueFilterAndNotOrPrefixes) 
                                                    {
                                                        xmlWriter.WriteStartElement("Prefix");
                                                        xmlWriter.WriteValue(publicRequestConfigurationRulesValueFilterAndNotOrPrefixesValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                }
                                                var publicRequestConfigurationRulesValueFilterAndNotOrTags = publicRequestConfigurationRulesValue.Filter.And.Not.Or.Tags;
                                                if (publicRequestConfigurationRulesValue.Filter.And.Not.Or.IsSetTags()) 
                                                {
                                                    foreach (var publicRequestConfigurationRulesValueFilterAndNotOrTagsValue in publicRequestConfigurationRulesValueFilterAndNotOrTags) 
                                                    {
                                                        if (publicRequestConfigurationRulesValueFilterAndNotOrTagsValue != null)
                                                        {
                                                            xmlWriter.WriteStartElement("Tag");
                                                            if(publicRequestConfigurationRulesValueFilterAndNotOrTagsValue.IsSetKey())
                                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndNotOrTagsValue.Key));
                                                            if(publicRequestConfigurationRulesValueFilterAndNotOrTagsValue.IsSetValue())
                                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndNotOrTagsValue.Value));
                                                            xmlWriter.WriteEndElement();
                                                        }
                                                    }            
                                                }
                                                xmlWriter.WriteEndElement();
                                            }
                                            if(publicRequestConfigurationRulesValue.Filter.And.Not.IsSetPrefix())
                                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Not.Prefix));
                                            if (publicRequestConfigurationRulesValue.Filter.And.Not.IsSetTag())
                                            {
                                                xmlWriter.WriteStartElement("Tag");
                                                if(publicRequestConfigurationRulesValue.Filter.And.Not.Tag.IsSetKey())
                                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Not.Tag.Key));
                                                if(publicRequestConfigurationRulesValue.Filter.And.Not.Tag.IsSetValue())
                                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Not.Tag.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestConfigurationRulesValue.Filter.And.IsSetPrefix())
                                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Prefix));
                                        var publicRequestConfigurationRulesValueFilterAndTags = publicRequestConfigurationRulesValue.Filter.And.Tags;
                                        if (publicRequestConfigurationRulesValue.Filter.And.IsSetTags()) 
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
                                    if (publicRequestConfigurationRulesValue.Filter.IsSetNot())
                                    {
                                        xmlWriter.WriteStartElement("Not");
                                        if (publicRequestConfigurationRulesValue.Filter.Not.IsSetOr())
                                        {
                                            xmlWriter.WriteStartElement("Or");
                                            var publicRequestConfigurationRulesValueFilterNotOrPrefixes = publicRequestConfigurationRulesValue.Filter.Not.Or.Prefixes;
                                            if (publicRequestConfigurationRulesValue.Filter.Not.Or.IsSetPrefixes()) 
                                            {
                                                foreach (var publicRequestConfigurationRulesValueFilterNotOrPrefixesValue in publicRequestConfigurationRulesValueFilterNotOrPrefixes) 
                                                {
                                                    xmlWriter.WriteStartElement("Prefix");
                                                    xmlWriter.WriteValue(publicRequestConfigurationRulesValueFilterNotOrPrefixesValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                            }
                                            var publicRequestConfigurationRulesValueFilterNotOrTags = publicRequestConfigurationRulesValue.Filter.Not.Or.Tags;
                                            if (publicRequestConfigurationRulesValue.Filter.Not.Or.IsSetTags()) 
                                            {
                                                foreach (var publicRequestConfigurationRulesValueFilterNotOrTagsValue in publicRequestConfigurationRulesValueFilterNotOrTags) 
                                                {
                                                    if (publicRequestConfigurationRulesValueFilterNotOrTagsValue != null)
                                                    {
                                                        xmlWriter.WriteStartElement("Tag");
                                                        if(publicRequestConfigurationRulesValueFilterNotOrTagsValue.IsSetKey())
                                                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValueFilterNotOrTagsValue.Key));
                                                        if(publicRequestConfigurationRulesValueFilterNotOrTagsValue.IsSetValue())
                                                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValueFilterNotOrTagsValue.Value));
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }            
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestConfigurationRulesValue.Filter.Not.IsSetPrefix())
                                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Not.Prefix));
                                        if (publicRequestConfigurationRulesValue.Filter.Not.IsSetTag())
                                        {
                                            xmlWriter.WriteStartElement("Tag");
                                            if(publicRequestConfigurationRulesValue.Filter.Not.Tag.IsSetKey())
                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Not.Tag.Key));
                                            if(publicRequestConfigurationRulesValue.Filter.Not.Tag.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Not.Tag.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestConfigurationRulesValue.Filter.IsSetPrefix())
                                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Prefix));
                                    if (publicRequestConfigurationRulesValue.Filter.IsSetTag())
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
                                if (publicRequestConfigurationRulesValue.IsSetSourceSelectionCriteria())
                                {
                                    xmlWriter.WriteStartElement("SourceSelectionCriteria");
                                    if (publicRequestConfigurationRulesValue.SourceSelectionCriteria.IsSetReplicaModifications())
                                    {
                                        xmlWriter.WriteStartElement("ReplicaModifications");
                                        if(publicRequestConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications.IsSetStatus())
                                            xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.SourceSelectionCriteria.ReplicaModifications.Status));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestConfigurationRulesValue.SourceSelectionCriteria.IsSetSseKmsEncryptedObjects())
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
#if NETFRAMEWORK // For non .NET Framework targets the request payload is stored in the ContentStream via the PooledContentStream.
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
#endif
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
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutBucketReplicationRequest publicRequest);
    }    
}