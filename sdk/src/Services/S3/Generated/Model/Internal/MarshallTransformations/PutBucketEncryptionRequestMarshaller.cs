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
    /// PutBucketEncryption Request Marshaller
    /// </summary>       
    public partial class PutBucketEncryptionRequestMarshaller : IMarshaller<IRequest, PutBucketEncryptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketEncryptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketEncryptionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("encryption");
        
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
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketEncryptionRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetServerSideEncryptionConfiguration())
                {
                    xmlWriter.WriteStartElement("ServerSideEncryptionConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    var publicRequestServerSideEncryptionConfigurationServerSideEncryptionRules = publicRequest.ServerSideEncryptionConfiguration.ServerSideEncryptionRules;
                    if (publicRequestServerSideEncryptionConfigurationServerSideEncryptionRules != null && (publicRequestServerSideEncryptionConfigurationServerSideEncryptionRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue in publicRequestServerSideEncryptionConfigurationServerSideEncryptionRules) 
                        {
                        if (publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if(publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.IsSetBucketKeyEnabled())
                                xmlWriter.WriteElementString("BucketKeyEnabled", StringUtils.FromBool(publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.BucketKeyEnabled.Value));
                            if (publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.ServerSideEncryptionByDefault != null)
                            {
                                xmlWriter.WriteStartElement("ApplyServerSideEncryptionByDefault");
                                if(publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.ServerSideEncryptionByDefault.IsSetServerSideEncryptionAlgorithm())
                                    xmlWriter.WriteElementString("SSEAlgorithm", StringUtils.FromString(publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.ServerSideEncryptionByDefault.ServerSideEncryptionAlgorithm));
                                if(publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.ServerSideEncryptionByDefault.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                                    xmlWriter.WriteElementString("KMSMasterKeyID", StringUtils.FromString(publicRequestServerSideEncryptionConfigurationServerSideEncryptionRulesValue.ServerSideEncryptionByDefault.ServerSideEncryptionKeyManagementServiceKeyId));
                                xmlWriter.WriteEndElement();
                            }
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
        private static PutBucketEncryptionRequestMarshaller _instance = new PutBucketEncryptionRequestMarshaller();        

        internal static PutBucketEncryptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketEncryptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketEncryptionRequest publicRequest);
    }    
}