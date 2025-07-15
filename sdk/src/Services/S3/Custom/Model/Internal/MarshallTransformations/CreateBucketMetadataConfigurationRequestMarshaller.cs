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
    /// CreateBucketMetadataConfiguration Request Marshaller
    /// </summary>       
    public class CreateBucketMetadataConfigurationRequestMarshaller : IMarshaller<IRequest, CreateBucketMetadataConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBucketMetadataConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBucketMetadataConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "POST";
            request.AddSubResource("metadataConfiguration");
        
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
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetMetadataConfiguration())
                {
                    xmlWriter.WriteStartElement("MetadataConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.MetadataConfiguration.InventoryTableConfiguration != null)
                    {
                        xmlWriter.WriteStartElement("InventoryTableConfiguration");
                        if(publicRequest.MetadataConfiguration.InventoryTableConfiguration.IsSetConfigurationState())
                            xmlWriter.WriteElementString("ConfigurationState", StringUtils.FromString(publicRequest.MetadataConfiguration.InventoryTableConfiguration.ConfigurationState));                 

                        if (publicRequest.MetadataConfiguration.InventoryTableConfiguration.EncryptionConfiguration != null)
                        {
                            xmlWriter.WriteStartElement("EncryptionConfiguration");
                            if(publicRequest.MetadataConfiguration.InventoryTableConfiguration.EncryptionConfiguration.IsSetKmsKeyArn())
                                xmlWriter.WriteElementString("KmsKeyArn", StringUtils.FromString(publicRequest.MetadataConfiguration.InventoryTableConfiguration.EncryptionConfiguration.KmsKeyArn));                 

                            if(publicRequest.MetadataConfiguration.InventoryTableConfiguration.EncryptionConfiguration.IsSetSseAlgorithm())
                                xmlWriter.WriteElementString("SseAlgorithm", StringUtils.FromString(publicRequest.MetadataConfiguration.InventoryTableConfiguration.EncryptionConfiguration.SseAlgorithm));                 

                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.MetadataConfiguration.JournalTableConfiguration != null)
                    {
                        xmlWriter.WriteStartElement("JournalTableConfiguration");
                        if (publicRequest.MetadataConfiguration.JournalTableConfiguration.EncryptionConfiguration != null)
                        {
                            xmlWriter.WriteStartElement("EncryptionConfiguration");
                            if(publicRequest.MetadataConfiguration.JournalTableConfiguration.EncryptionConfiguration.IsSetKmsKeyArn())
                                xmlWriter.WriteElementString("KmsKeyArn", StringUtils.FromString(publicRequest.MetadataConfiguration.JournalTableConfiguration.EncryptionConfiguration.KmsKeyArn));                 

                            if(publicRequest.MetadataConfiguration.JournalTableConfiguration.EncryptionConfiguration.IsSetSseAlgorithm())
                                xmlWriter.WriteElementString("SseAlgorithm", StringUtils.FromString(publicRequest.MetadataConfiguration.JournalTableConfiguration.EncryptionConfiguration.SseAlgorithm));                 

                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.MetadataConfiguration.JournalTableConfiguration.RecordExpiration != null)
                        {
                            xmlWriter.WriteStartElement("RecordExpiration");
                            if(publicRequest.MetadataConfiguration.JournalTableConfiguration.RecordExpiration.IsSetDays())
                                xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequest.MetadataConfiguration.JournalTableConfiguration.RecordExpiration.Days));                 

                            if(publicRequest.MetadataConfiguration.JournalTableConfiguration.RecordExpiration.IsSetExpiration())
                                xmlWriter.WriteElementString("Expiration", StringUtils.FromString(publicRequest.MetadataConfiguration.JournalTableConfiguration.RecordExpiration.Expiration));                 

                            xmlWriter.WriteEndElement();
                        }
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
                if (publicRequest.IsSetContentMD5())
                    request.Headers[Amazon.Util.HeaderKeys.ContentMD5Header] = publicRequest.ContentMD5;
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
        private static CreateBucketMetadataConfigurationRequestMarshaller _instance = new CreateBucketMetadataConfigurationRequestMarshaller();        

        internal static CreateBucketMetadataConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBucketMetadataConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}