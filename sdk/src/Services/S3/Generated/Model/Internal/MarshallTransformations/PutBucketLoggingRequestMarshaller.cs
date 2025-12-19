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
    /// PutBucketLogging Request Marshaller
    /// </summary>       
    public partial class PutBucketLoggingRequestMarshaller : IMarshaller<IRequest, PutBucketLoggingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketLoggingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketLoggingRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
            request.AddSubResource("logging");
        
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
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketLoggingRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                    xmlWriter.WriteStartElement("BucketLoggingStatus", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.IsSetLoggingConfig())
                    {
                        xmlWriter.WriteStartElement("LoggingEnabled");
                        var publicRequestLoggingConfigGrants = publicRequest.LoggingConfig.Grants;
                        if (publicRequestLoggingConfigGrants != null && (publicRequestLoggingConfigGrants.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("TargetGrants");
                            foreach (var publicRequestLoggingConfigGrantsValue in publicRequestLoggingConfigGrants) 
                            {
                            if (publicRequestLoggingConfigGrantsValue != null)
                            {
                                xmlWriter.WriteStartElement("Grant");
                                if (publicRequestLoggingConfigGrantsValue.IsSetGrantee())
                                {
                                    xmlWriter.WriteStartElement("xsi","Grantee","http://www.w3.org/2001/XMLSchema-instance");
                                    if(publicRequestLoggingConfigGrantsValue.Grantee.IsSetType())
                                        xmlWriter.WriteAttributeString("xsi","type", "http://www.w3.org/2001/XMLSchema-instance",StringUtils.FromString(publicRequestLoggingConfigGrantsValue.Grantee.Type));
                                    if(publicRequestLoggingConfigGrantsValue.Grantee.IsSetCanonicalUser())
                                        xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestLoggingConfigGrantsValue.Grantee.CanonicalUser));
                                    if(publicRequestLoggingConfigGrantsValue.Grantee.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName", StringUtils.FromString(publicRequestLoggingConfigGrantsValue.Grantee.DisplayName));
                                    if(publicRequestLoggingConfigGrantsValue.Grantee.IsSetEmailAddress())
                                        xmlWriter.WriteElementString("EmailAddress", StringUtils.FromString(publicRequestLoggingConfigGrantsValue.Grantee.EmailAddress));
                                    if(publicRequestLoggingConfigGrantsValue.Grantee.IsSetURI())
                                        xmlWriter.WriteElementString("URI", StringUtils.FromString(publicRequestLoggingConfigGrantsValue.Grantee.URI));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestLoggingConfigGrantsValue.IsSetPermission())
                                    xmlWriter.WriteElementString("Permission", StringUtils.FromString(publicRequestLoggingConfigGrantsValue.Permission));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.LoggingConfig.IsSetTargetBucketName())
                            xmlWriter.WriteElementString("TargetBucket", StringUtils.FromString(publicRequest.LoggingConfig.TargetBucketName));
                        if (publicRequest.LoggingConfig.IsSetTargetObjectKeyFormat())
                        {
                            xmlWriter.WriteStartElement("TargetObjectKeyFormat");
                            if (publicRequest.LoggingConfig.TargetObjectKeyFormat.IsSetPartitionedPrefix())
                            {
                                xmlWriter.WriteStartElement("PartitionedPrefix");
                                if(publicRequest.LoggingConfig.TargetObjectKeyFormat.PartitionedPrefix.IsSetPartitionDateSource())
                                    xmlWriter.WriteElementString("PartitionDateSource", StringUtils.FromString(publicRequest.LoggingConfig.TargetObjectKeyFormat.PartitionedPrefix.PartitionDateSource));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.LoggingConfig.TargetObjectKeyFormat.IsSetSimplePrefix())
                            {
                                xmlWriter.WriteStartElement("SimplePrefix");
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        TargetPrefixCustomMarshall(publicRequest, xmlWriter);
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
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
        private static PutBucketLoggingRequestMarshaller _instance = new PutBucketLoggingRequestMarshaller();        

        internal static PutBucketLoggingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketLoggingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketLoggingRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutBucketLoggingRequest publicRequest);
    }    
}