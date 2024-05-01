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

            if (putBucketInventoryConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketInventoryConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(putBucketInventoryConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketInventoryConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("inventory");

            if (putBucketInventoryConfigurationRequest.IsSetInventoryId())
            {
                request.AddSubResource("id", S3Transforms.ToStringValue(putBucketInventoryConfigurationRequest.InventoryId));
            }

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                if (putBucketInventoryConfigurationRequest.IsSetInventoryConfiguration())
                {
                    var inventoryConfiguration = putBucketInventoryConfigurationRequest.InventoryConfiguration;
                    xmlWriter.WriteStartElement("InventoryConfiguration", S3Constants.S3RequestXmlNamespace);
                    if (inventoryConfiguration != null)
                    {
                        if (inventoryConfiguration.IsSetDestination())
                        {
                            InventoryDestination inventoryDestination = inventoryConfiguration.Destination;
                            xmlWriter.WriteStartElement("Destination");
                            if (inventoryDestination.isSetS3BucketDestination())
                            {
                                InventoryS3BucketDestination inventoryS3BucketDestination = inventoryDestination.S3BucketDestination;
                                xmlWriter.WriteStartElement("S3BucketDestination");
                                if (inventoryS3BucketDestination.IsSetAccountId())
                                {
                                    xmlWriter.WriteElementString("AccountId", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.AccountId));
                                }
                                if (inventoryS3BucketDestination.IsSetBucketName())
                                {
                                    xmlWriter.WriteElementString("Bucket", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.BucketName));
                                }
                                if (inventoryS3BucketDestination.IsSetInventoryFormat())
                                {
                                    xmlWriter.WriteElementString("Format", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.InventoryFormat));
                                }
                                if (inventoryS3BucketDestination.IsSetPrefix())
                                {
                                    xmlWriter.WriteElementString("Prefix", S3Transforms.ToXmlStringValue(inventoryS3BucketDestination.Prefix));
                                }
                                if (inventoryS3BucketDestination.IsSetInventoryEncryption())
                                {
                                    xmlWriter.WriteStartElement("Encryption");
                                    var inventoryEncryption = inventoryS3BucketDestination.InventoryEncryption;
                                    if (inventoryEncryption.IsSetSSEKMS())
                                    {
                                        xmlWriter.WriteStartElement("SSE-KMS");
                                        if (inventoryEncryption.SSEKMS.IsSetKeyId())
                                        {
                                            xmlWriter.WriteElementString("KeyId", S3Transforms.ToXmlStringValue(inventoryEncryption.SSEKMS.KeyId));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (inventoryEncryption.IsSetSSES3())
                                    {
                                        xmlWriter.WriteStartElement("SSE-S3");
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }

                        xmlWriter.WriteElementString("IsEnabled", S3Transforms.ToXmlStringValue(inventoryConfiguration.IsEnabled.GetValueOrDefault()));

                        if (inventoryConfiguration.IsSetInventoryFilter())
                        {
                            xmlWriter.WriteStartElement("Filter");
                            var predicate = inventoryConfiguration.InventoryFilter.InventoryFilterPredicate;
                            predicate.Accept(new InventoryPredicateVisitor(xmlWriter));
                            xmlWriter.WriteEndElement();
                        }

                        if(inventoryConfiguration.IsSetInventoryId())
                        {
                            xmlWriter.WriteElementString("Id", S3Transforms.ToXmlStringValue(inventoryConfiguration.InventoryId));
                        }
                        
                        if(inventoryConfiguration.IsSetIncludedObjectVersions())
                        {
                            xmlWriter.WriteElementString("IncludedObjectVersions", S3Transforms.ToXmlStringValue(inventoryConfiguration.IncludedObjectVersions));
                        }

                        if (inventoryConfiguration.IsSetInventoryOptionalFields())
                        {
                            xmlWriter.WriteStartElement("OptionalFields");
                            foreach (var inventoryOptionalField in inventoryConfiguration.InventoryOptionalFields)
                            {
                                xmlWriter.WriteElementString("Field", S3Transforms.ToXmlStringValue(inventoryOptionalField));
                            }
                            xmlWriter.WriteEndElement();
                        }

                        if(inventoryConfiguration.IsSetSchedule())
                        {
                            xmlWriter.WriteStartElement("Schedule");
                            var inventorySchedule = inventoryConfiguration.Schedule;
                            if (inventorySchedule.IsFrequency())
                            {
                                xmlWriter.WriteElementString("Frequency", S3Transforms.ToXmlStringValue(inventorySchedule.Frequency));
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

                ChecksumUtils.SetChecksumData(request);
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        private static PutBucketInventoryConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
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
