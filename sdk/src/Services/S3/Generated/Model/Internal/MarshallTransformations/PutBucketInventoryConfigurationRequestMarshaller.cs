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
    /// PutBucketInventoryConfiguration Request Marshaller
    /// </summary>       
    public class PutBucketInventoryConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketInventoryConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketInventoryConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketInventoryConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("inventory");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            
            if (publicRequest.IsSetId())
                request.Parameters.Add("id", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetInventoryConfiguration())
                {
                    xmlWriter.WriteStartElement("InventoryConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.InventoryConfiguration.Destination != null)
                    {
                        xmlWriter.WriteStartElement("Destination");
                        if (publicRequest.InventoryConfiguration.Destination.S3BucketDestination != null)
                        {
                            xmlWriter.WriteStartElement("S3BucketDestination");
                            if(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.IsSetAccountId())
                                xmlWriter.WriteElementString("AccountId", StringUtils.FromString(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.AccountId));
                            if(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.IsSetBucketName())
                                xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.BucketName));
                            if (publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Encryption != null)
                            {
                                xmlWriter.WriteStartElement("Encryption");
                                if (publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Encryption.SSEKMS != null)
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS");
                                    if(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Encryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", StringUtils.FromString(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Encryption.SSEKMS.KeyId));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Encryption.SSES3 != null)
                                {
                                    xmlWriter.WriteStartElement("SSE-S3");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.IsSetFormat())
                                xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Format));
                            if(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.InventoryConfiguration.Destination.S3BucketDestination.Prefix));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.InventoryConfiguration.Filter != null)
                    {
                        xmlWriter.WriteStartElement("Filter");
                        if(publicRequest.InventoryConfiguration.Filter.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.InventoryConfiguration.Filter.Prefix));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.InventoryConfiguration.IsSetId())
                        xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequest.InventoryConfiguration.Id));

                    if(publicRequest.InventoryConfiguration.IsSetIncludedObjectVersions())
                        xmlWriter.WriteElementString("IncludedObjectVersions", StringUtils.FromString(publicRequest.InventoryConfiguration.IncludedObjectVersions));

                    if(publicRequest.InventoryConfiguration.IsSetIsEnabled())
                        xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.InventoryConfiguration.IsEnabled.Value));

                    var publicRequestInventoryConfigurationOptionalFields = publicRequest.InventoryConfiguration.OptionalFields;
                    if (publicRequestInventoryConfigurationOptionalFields != null && (publicRequestInventoryConfigurationOptionalFields.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("OptionalFields");
                        foreach (var publicRequestInventoryConfigurationOptionalFieldsValue in publicRequestInventoryConfigurationOptionalFields) 
                        {
                            xmlWriter.WriteStartElement("Field");
                            xmlWriter.WriteValue(publicRequestInventoryConfigurationOptionalFieldsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if (publicRequest.InventoryConfiguration.Schedule != null)
                    {
                        xmlWriter.WriteStartElement("Schedule");
                        if(publicRequest.InventoryConfiguration.Schedule.IsSetFrequency())
                            xmlWriter.WriteElementString("Frequency", StringUtils.FromString(publicRequest.InventoryConfiguration.Schedule.Frequency));
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            request.UseQueryString = true;
            return request;
        }
        private static PutBucketInventoryConfigurationRequestMarshaller _instance = new PutBucketInventoryConfigurationRequestMarshaller();        

        internal static PutBucketInventoryConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketInventoryConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}