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
    /// UpdateBucketMetadataAnnotationTableConfiguration Request Marshaller
    /// </summary>       
    public partial class UpdateBucketMetadataAnnotationTableConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateBucketMetadataAnnotationTableConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBucketMetadataAnnotationTableConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBucketMetadataAnnotationTableConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
            request.AddSubResource("metadataAnnotationTable");
        
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
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "UpdateBucketMetadataAnnotationTableConfigurationRequest.BucketName");
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
                if (publicRequest.IsSetAnnotationTableConfiguration())
                {
                    xmlWriter.WriteStartElement("AnnotationTableConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if(publicRequest.AnnotationTableConfiguration.IsSetConfigurationState())
                        xmlWriter.WriteElementString("ConfigurationState", StringUtils.FromString(publicRequest.AnnotationTableConfiguration.ConfigurationState));

                    if (publicRequest.AnnotationTableConfiguration.IsSetEncryptionConfiguration())
                    {
                        xmlWriter.WriteStartElement("EncryptionConfiguration");
                        if(publicRequest.AnnotationTableConfiguration.EncryptionConfiguration.IsSetKmsKeyArn())
                            xmlWriter.WriteElementString("KmsKeyArn", StringUtils.FromString(publicRequest.AnnotationTableConfiguration.EncryptionConfiguration.KmsKeyArn));
                        if(publicRequest.AnnotationTableConfiguration.EncryptionConfiguration.IsSetSseAlgorithm())
                            xmlWriter.WriteElementString("SseAlgorithm", StringUtils.FromString(publicRequest.AnnotationTableConfiguration.EncryptionConfiguration.SseAlgorithm));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.AnnotationTableConfiguration.IsSetRole())
                        xmlWriter.WriteElementString("Role", StringUtils.FromString(publicRequest.AnnotationTableConfiguration.Role));


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
        private static UpdateBucketMetadataAnnotationTableConfigurationRequestMarshaller _instance = new UpdateBucketMetadataAnnotationTableConfigurationRequestMarshaller();        

        internal static UpdateBucketMetadataAnnotationTableConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBucketMetadataAnnotationTableConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateBucketMetadataAnnotationTableConfigurationRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateBucketMetadataAnnotationTableConfigurationRequest publicRequest);
    }    
}