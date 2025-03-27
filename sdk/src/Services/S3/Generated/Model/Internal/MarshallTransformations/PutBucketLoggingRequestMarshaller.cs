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
    public class PutBucketLoggingRequestMarshaller : IMarshaller<IRequest, PutBucketLoggingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetBucketLoggingStatus())
                {
                    xmlWriter.WriteStartElement("BucketLoggingStatus", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.BucketLoggingStatus.LoggingEnabled != null)
                    {
                        xmlWriter.WriteStartElement("LoggingEnabled");
                        if(publicRequest.BucketLoggingStatus.LoggingEnabled.IsSetTargetBucket())
                            xmlWriter.WriteElementString("TargetBucket", StringUtils.FromString(publicRequest.BucketLoggingStatus.LoggingEnabled.TargetBucket));
                        var publicRequestBucketLoggingStatusLoggingEnabledTargetGrants = publicRequest.BucketLoggingStatus.LoggingEnabled.TargetGrants;
                        if (publicRequestBucketLoggingStatusLoggingEnabledTargetGrants != null && (publicRequestBucketLoggingStatusLoggingEnabledTargetGrants.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("TargetGrants");
                            foreach (var publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue in publicRequestBucketLoggingStatusLoggingEnabledTargetGrants) 
                            {
                            if (publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue != null)
                            {
                                xmlWriter.WriteStartElement("Grant");
                                if (publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee != null)
                                {
                                    xmlWriter.WriteStartElement("Grantee");
                                    if(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName", StringUtils.FromString(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.DisplayName));
                                    if(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.IsSetEmailAddress())
                                        xmlWriter.WriteElementString("EmailAddress", StringUtils.FromString(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.EmailAddress));
                                    if(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.IsSetID())
                                        xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.ID));
                                    if(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.IsSetType())
                                        xmlWriter.WriteAttributeString("xsi","type", "",StringUtils.FromString(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.Type));
                                    if(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.IsSetURI())
                                        xmlWriter.WriteElementString("URI", StringUtils.FromString(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Grantee.URI));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.IsSetPermission())
                                    xmlWriter.WriteElementString("Permission", StringUtils.FromString(publicRequestBucketLoggingStatusLoggingEnabledTargetGrantsValue.Permission));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if (publicRequest.BucketLoggingStatus.LoggingEnabled.TargetObjectKeyFormat != null)
                        {
                            xmlWriter.WriteStartElement("TargetObjectKeyFormat");
                            if (publicRequest.BucketLoggingStatus.LoggingEnabled.TargetObjectKeyFormat.PartitionedPrefix != null)
                            {
                                xmlWriter.WriteStartElement("PartitionedPrefix");
                                if(publicRequest.BucketLoggingStatus.LoggingEnabled.TargetObjectKeyFormat.PartitionedPrefix.IsSetPartitionDateSource())
                                    xmlWriter.WriteElementString("PartitionDateSource", StringUtils.FromString(publicRequest.BucketLoggingStatus.LoggingEnabled.TargetObjectKeyFormat.PartitionedPrefix.PartitionDateSource));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.BucketLoggingStatus.LoggingEnabled.TargetObjectKeyFormat.SimplePrefix != null)
                            {
                                xmlWriter.WriteStartElement("SimplePrefix");
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.BucketLoggingStatus.LoggingEnabled.IsSetTargetPrefix())
                            xmlWriter.WriteElementString("TargetPrefix", StringUtils.FromString(publicRequest.BucketLoggingStatus.LoggingEnabled.TargetPrefix));
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

    }    
}