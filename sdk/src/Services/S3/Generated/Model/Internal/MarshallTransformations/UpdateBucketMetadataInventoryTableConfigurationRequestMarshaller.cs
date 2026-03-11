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
    /// UpdateBucketMetadataInventoryTableConfiguration Request Marshaller
    /// </summary>       
    public partial class UpdateBucketMetadataInventoryTableConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateBucketMetadataInventoryTableConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBucketMetadataInventoryTableConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBucketMetadataInventoryTableConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
            request.AddSubResource("metadataInventoryTable");
        
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
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "UpdateBucketMetadataInventoryTableConfigurationRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetInventoryTableConfiguration())
                {
                    xmlWriter.WriteStartElement("InventoryTableConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if(publicRequest.InventoryTableConfiguration.IsSetConfigurationState())
                        xmlWriter.WriteElementString("ConfigurationState", StringUtils.FromString(publicRequest.InventoryTableConfiguration.ConfigurationState));

                    if (publicRequest.InventoryTableConfiguration.IsSetEncryptionConfiguration())
                    {
                        xmlWriter.WriteStartElement("EncryptionConfiguration");
                        if(publicRequest.InventoryTableConfiguration.EncryptionConfiguration.IsSetKmsKeyArn())
                            xmlWriter.WriteElementString("KmsKeyArn", StringUtils.FromString(publicRequest.InventoryTableConfiguration.EncryptionConfiguration.KmsKeyArn));
                        if(publicRequest.InventoryTableConfiguration.EncryptionConfiguration.IsSetSseAlgorithm())
                            xmlWriter.WriteElementString("SseAlgorithm", StringUtils.FromString(publicRequest.InventoryTableConfiguration.EncryptionConfiguration.SseAlgorithm));
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
        private static UpdateBucketMetadataInventoryTableConfigurationRequestMarshaller _instance = new UpdateBucketMetadataInventoryTableConfigurationRequestMarshaller();        

        internal static UpdateBucketMetadataInventoryTableConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBucketMetadataInventoryTableConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateBucketMetadataInventoryTableConfigurationRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateBucketMetadataInventoryTableConfigurationRequest publicRequest);
    }    
}