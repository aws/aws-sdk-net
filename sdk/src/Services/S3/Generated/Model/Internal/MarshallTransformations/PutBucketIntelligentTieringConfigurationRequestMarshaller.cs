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
    /// PutBucketIntelligentTieringConfiguration Request Marshaller
    /// </summary>       
    public class PutBucketIntelligentTieringConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketIntelligentTieringConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketIntelligentTieringConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketIntelligentTieringConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("intelligent-tiering");
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            
            if (publicRequest.IsSetId())
                request.Parameters.Add("id", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetIntelligentTieringConfiguration())
                {
                    xmlWriter.WriteStartElement("IntelligentTieringConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.IntelligentTieringConfiguration.Filter != null)
                    {
                        xmlWriter.WriteStartElement("Filter");
                        if (publicRequest.IntelligentTieringConfiguration.Filter.And != null)
                        {
                            xmlWriter.WriteStartElement("And");
                            if(publicRequest.IntelligentTieringConfiguration.Filter.And.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.IntelligentTieringConfiguration.Filter.And.Prefix));
                            var publicRequestIntelligentTieringConfigurationFilterAndTags = publicRequest.IntelligentTieringConfiguration.Filter.And.Tags;
                            if (publicRequestIntelligentTieringConfigurationFilterAndTags != null && (publicRequestIntelligentTieringConfigurationFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestIntelligentTieringConfigurationFilterAndTagsValue in publicRequestIntelligentTieringConfigurationFilterAndTags) 
                                {
                                if (publicRequestIntelligentTieringConfigurationFilterAndTagsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestIntelligentTieringConfigurationFilterAndTagsValue.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestIntelligentTieringConfigurationFilterAndTagsValue.Key));
                                    if(publicRequestIntelligentTieringConfigurationFilterAndTagsValue.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestIntelligentTieringConfigurationFilterAndTagsValue.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.IntelligentTieringConfiguration.Filter.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.IntelligentTieringConfiguration.Filter.Prefix));
                        if (publicRequest.IntelligentTieringConfiguration.Filter.Tag != null)
                        {
                            xmlWriter.WriteStartElement("Tag");
                            if(publicRequest.IntelligentTieringConfiguration.Filter.Tag.IsSetKey())
                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequest.IntelligentTieringConfiguration.Filter.Tag.Key));
                            if(publicRequest.IntelligentTieringConfiguration.Filter.Tag.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequest.IntelligentTieringConfiguration.Filter.Tag.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.IntelligentTieringConfiguration.IsSetId())
                        xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequest.IntelligentTieringConfiguration.Id));

                    if(publicRequest.IntelligentTieringConfiguration.IsSetStatus())
                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequest.IntelligentTieringConfiguration.Status));

                    var publicRequestIntelligentTieringConfigurationTierings = publicRequest.IntelligentTieringConfiguration.Tierings;
                    if (publicRequestIntelligentTieringConfigurationTierings != null && (publicRequestIntelligentTieringConfigurationTierings.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Tiering");
                        foreach (var publicRequestIntelligentTieringConfigurationTieringsValue in publicRequestIntelligentTieringConfigurationTierings) 
                        {
                        if (publicRequestIntelligentTieringConfigurationTieringsValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            if(publicRequestIntelligentTieringConfigurationTieringsValue.IsSetAccessTier())
                                xmlWriter.WriteElementString("AccessTier", StringUtils.FromString(publicRequestIntelligentTieringConfigurationTieringsValue.AccessTier));
                            if(publicRequestIntelligentTieringConfigurationTieringsValue.IsSetDays())
                                xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequestIntelligentTieringConfigurationTieringsValue.Days.Value));
                            xmlWriter.WriteEndElement();
                        }
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            request.UseQueryString = true;
            return request;
        }
        private static PutBucketIntelligentTieringConfigurationRequestMarshaller _instance = new PutBucketIntelligentTieringConfigurationRequestMarshaller();        

        internal static PutBucketIntelligentTieringConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketIntelligentTieringConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}