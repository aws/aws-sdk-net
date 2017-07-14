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
    /// <summary>
    ///    Request Marshaller for PutInventoryConfiguration operation
    /// </summary> 
    public class PutBucketInventoryConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketInventoryConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketInventoryConfigurationRequest)input);
        }
        public IRequest Marshall(PutBucketInventoryConfigurationRequest putBucketInventoryConfigurationRequest)
        {
            IRequest request = new DefaultRequest(putBucketInventoryConfigurationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketInventoryConfigurationRequest.BucketName));

            request.AddSubResource("inventory");

            if (putBucketInventoryConfigurationRequest.IsSetInventoryId())
            {
                request.AddSubResource("id", S3Transforms.ToStringValue(putBucketInventoryConfigurationRequest.InventoryId));
            }

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                if (putBucketInventoryConfigurationRequest.IsSetInventoryConfiguration())
                {
                    var inventoryConfiguration = putBucketInventoryConfigurationRequest.InventoryConfiguration;
                    xmlWriter.WriteStartElement("InventoryConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (inventoryConfiguration != null)
                    {
                        if (inventoryConfiguration.IsSetDestination())
                        {
                            InventoryDestination inventoryDestination = inventoryConfiguration.Destination;
                            xmlWriter.WriteStartElement("Destination", "http://s3.amazonaws.com/doc/2006-03-01/");
                            if (inventoryDestination.isSetS3BucketDestination())
                            {
                                InventoryS3BucketDestination inventoryS3BucketDestination = inventoryDestination.S3BucketDestination;
                                xmlWriter.WriteStartElement("S3BucketDestination", "http://s3.amazonaws.com/doc/2006-03-01/");
                                if (inventoryS3BucketDestination.IsSetAccountId())
                                {
                                    xmlWriter.WriteElementString("AccountId", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.AccountId));
                                }
                                if (inventoryS3BucketDestination.IsSetBucketName())
                                {
                                    xmlWriter.WriteElementString("Bucket", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.BucketName));
                                }
                                if (inventoryS3BucketDestination.IsSetInventoryFormat())
                                {
                                    xmlWriter.WriteElementString("Format", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.InventoryFormat));
                                }
                                if (inventoryS3BucketDestination.IsSetPrefix())
                                {
                                    xmlWriter.WriteElementString("Prefix", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.Prefix));
                                }
                                if (inventoryS3BucketDestination.IsSetInventoryEncryption())
                                {
                                    xmlWriter.WriteStartElement("Encryption", "http://s3.amazonaws.com/doc/2006-03-01/");
                                    var inventoryEncryption = inventoryS3BucketDestination.InventoryEncryption;
                                    if (inventoryEncryption.IsSetSSEKMS())
                                    {
                                        xmlWriter.WriteStartElement("SSE-KMS", "http://s3.amazonaws.com/doc/2006-03-01/");
                                        if (inventoryEncryption.SSEKMS.IsSetKeyId())
                                        {
                                            xmlWriter.WriteElementString("KeyId", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryEncryption.SSEKMS.KeyId));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (inventoryEncryption.IsSetSSES3())
                                    {
                                        xmlWriter.WriteStartElement("SSE-S3", "http://s3.amazonaws.com/doc/2006-03-01/");
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }

                        xmlWriter.WriteElementString("IsEnabled", "http://s3.amazonaws.com/doc/2006-03-01/", inventoryConfiguration.IsEnabled.ToString().ToLowerInvariant());

                        if (inventoryConfiguration.IsSetInventoryFilter())
                        {
                            xmlWriter.WriteStartElement("Filter", "http://s3.amazonaws.com/doc/2006-03-01/");
                            var predicate = inventoryConfiguration.InventoryFilter.InventoryFilterPredicate;
                            predicate.Accept(new InventoryPredicateVisitor(xmlWriter));
                            xmlWriter.WriteEndElement();
                        }

                        if(inventoryConfiguration.IsSetInventoryId())
                        {
                            xmlWriter.WriteElementString("Id", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryConfiguration.InventoryId));
                        }
                        
                        if(inventoryConfiguration.IsSetIncludedObjectVersions())
                        {
                            xmlWriter.WriteElementString("IncludedObjectVersions", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryConfiguration.IncludedObjectVersions));
                        }

                        if (inventoryConfiguration.IsSetInventoryOptionalFields())
                        {
                            xmlWriter.WriteStartElement("OptionalFields", "http://s3.amazonaws.com/doc/2006-03-01/");
                            foreach (var inventoryOptionalField in inventoryConfiguration.InventoryOptionalFields)
                            {
                                xmlWriter.WriteElementString("Field", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryOptionalField));
                            }
                            xmlWriter.WriteEndElement();
                        }

                        if(inventoryConfiguration.IsSetSchedule())
                        {
                            xmlWriter.WriteStartElement("Schedule", "http://s3.amazonaws.com/doc/2006-03-01/");
                            var inventorySchedule = inventoryConfiguration.Schedule;
                            if (inventorySchedule.IsFrequency())
                            {
                                xmlWriter.WriteElementString("Frequency", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventorySchedule.Frequency));
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

        private static PutBucketInventoryConfigurationRequestMarshaller _instance;

        public static PutBucketInventoryConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketInventoryConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
