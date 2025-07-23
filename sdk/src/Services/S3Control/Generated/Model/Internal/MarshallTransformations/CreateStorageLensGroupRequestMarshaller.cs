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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStorageLensGroup Request Marshaller
    /// </summary>       
    public partial class CreateStorageLensGroupRequestMarshaller : IMarshaller<IRequest, CreateStorageLensGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStorageLensGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStorageLensGroupRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            request.ResourcePath = "/v20180820/storagelensgroup";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateStorageLensGroupRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if (publicRequest.StorageLensGroup != null)
                {
                    xmlWriter.WriteStartElement("StorageLensGroup");
                    if (publicRequest.StorageLensGroup.Filter != null)
                    {
                        xmlWriter.WriteStartElement("Filter");
                        if (publicRequest.StorageLensGroup.Filter.And != null)
                        {
                            xmlWriter.WriteStartElement("And");
                            var publicRequestStorageLensGroupFilterAndMatchAnyPrefix = publicRequest.StorageLensGroup.Filter.And.MatchAnyPrefix;
                            if (publicRequestStorageLensGroupFilterAndMatchAnyPrefix != null && (publicRequestStorageLensGroupFilterAndMatchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("MatchAnyPrefix");
                                foreach (var publicRequestStorageLensGroupFilterAndMatchAnyPrefixValue in publicRequestStorageLensGroupFilterAndMatchAnyPrefix) 
                                {
                                    xmlWriter.WriteStartElement("Prefix");
                                    xmlWriter.WriteValue(publicRequestStorageLensGroupFilterAndMatchAnyPrefixValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestStorageLensGroupFilterAndMatchAnySuffix = publicRequest.StorageLensGroup.Filter.And.MatchAnySuffix;
                            if (publicRequestStorageLensGroupFilterAndMatchAnySuffix != null && (publicRequestStorageLensGroupFilterAndMatchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("MatchAnySuffix");
                                foreach (var publicRequestStorageLensGroupFilterAndMatchAnySuffixValue in publicRequestStorageLensGroupFilterAndMatchAnySuffix) 
                                {
                                    xmlWriter.WriteStartElement("Suffix");
                                    xmlWriter.WriteValue(publicRequestStorageLensGroupFilterAndMatchAnySuffixValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestStorageLensGroupFilterAndMatchAnyTag = publicRequest.StorageLensGroup.Filter.And.MatchAnyTag;
                            if (publicRequestStorageLensGroupFilterAndMatchAnyTag != null && (publicRequestStorageLensGroupFilterAndMatchAnyTag.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("MatchAnyTag");
                                foreach (var publicRequestStorageLensGroupFilterAndMatchAnyTagValue in publicRequestStorageLensGroupFilterAndMatchAnyTag) 
                                {
                                if (publicRequestStorageLensGroupFilterAndMatchAnyTagValue != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestStorageLensGroupFilterAndMatchAnyTagValue.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestStorageLensGroupFilterAndMatchAnyTagValue.Key));
                                    if(publicRequestStorageLensGroupFilterAndMatchAnyTagValue.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestStorageLensGroupFilterAndMatchAnyTagValue.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if (publicRequest.StorageLensGroup.Filter.And.MatchObjectAge != null)
                            {
                                xmlWriter.WriteStartElement("MatchObjectAge");
                                if(publicRequest.StorageLensGroup.Filter.And.MatchObjectAge.IsSetDaysGreaterThan())
                                    xmlWriter.WriteElementString("DaysGreaterThan", StringUtils.FromInt(publicRequest.StorageLensGroup.Filter.And.MatchObjectAge.DaysGreaterThan.Value));
                                if(publicRequest.StorageLensGroup.Filter.And.MatchObjectAge.IsSetDaysLessThan())
                                    xmlWriter.WriteElementString("DaysLessThan", StringUtils.FromInt(publicRequest.StorageLensGroup.Filter.And.MatchObjectAge.DaysLessThan.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensGroup.Filter.And.MatchObjectSize != null)
                            {
                                xmlWriter.WriteStartElement("MatchObjectSize");
                                if(publicRequest.StorageLensGroup.Filter.And.MatchObjectSize.IsSetBytesGreaterThan())
                                    xmlWriter.WriteElementString("BytesGreaterThan", StringUtils.FromLong(publicRequest.StorageLensGroup.Filter.And.MatchObjectSize.BytesGreaterThan.Value));
                                if(publicRequest.StorageLensGroup.Filter.And.MatchObjectSize.IsSetBytesLessThan())
                                    xmlWriter.WriteElementString("BytesLessThan", StringUtils.FromLong(publicRequest.StorageLensGroup.Filter.And.MatchObjectSize.BytesLessThan.Value));
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        var publicRequestStorageLensGroupFilterMatchAnyPrefix = publicRequest.StorageLensGroup.Filter.MatchAnyPrefix;
                        if (publicRequestStorageLensGroupFilterMatchAnyPrefix != null && (publicRequestStorageLensGroupFilterMatchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("MatchAnyPrefix");
                            foreach (var publicRequestStorageLensGroupFilterMatchAnyPrefixValue in publicRequestStorageLensGroupFilterMatchAnyPrefix) 
                            {
                                xmlWriter.WriteStartElement("Prefix");
                                xmlWriter.WriteValue(publicRequestStorageLensGroupFilterMatchAnyPrefixValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        var publicRequestStorageLensGroupFilterMatchAnySuffix = publicRequest.StorageLensGroup.Filter.MatchAnySuffix;
                        if (publicRequestStorageLensGroupFilterMatchAnySuffix != null && (publicRequestStorageLensGroupFilterMatchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("MatchAnySuffix");
                            foreach (var publicRequestStorageLensGroupFilterMatchAnySuffixValue in publicRequestStorageLensGroupFilterMatchAnySuffix) 
                            {
                                xmlWriter.WriteStartElement("Suffix");
                                xmlWriter.WriteValue(publicRequestStorageLensGroupFilterMatchAnySuffixValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        var publicRequestStorageLensGroupFilterMatchAnyTag = publicRequest.StorageLensGroup.Filter.MatchAnyTag;
                        if (publicRequestStorageLensGroupFilterMatchAnyTag != null && (publicRequestStorageLensGroupFilterMatchAnyTag.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("MatchAnyTag");
                            foreach (var publicRequestStorageLensGroupFilterMatchAnyTagValue in publicRequestStorageLensGroupFilterMatchAnyTag) 
                            {
                            if (publicRequestStorageLensGroupFilterMatchAnyTagValue != null)
                            {
                                xmlWriter.WriteStartElement("Tag");
                                if(publicRequestStorageLensGroupFilterMatchAnyTagValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestStorageLensGroupFilterMatchAnyTagValue.Key));
                                if(publicRequestStorageLensGroupFilterMatchAnyTagValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestStorageLensGroupFilterMatchAnyTagValue.Value));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if (publicRequest.StorageLensGroup.Filter.MatchObjectAge != null)
                        {
                            xmlWriter.WriteStartElement("MatchObjectAge");
                            if(publicRequest.StorageLensGroup.Filter.MatchObjectAge.IsSetDaysGreaterThan())
                                xmlWriter.WriteElementString("DaysGreaterThan", StringUtils.FromInt(publicRequest.StorageLensGroup.Filter.MatchObjectAge.DaysGreaterThan.Value));
                            if(publicRequest.StorageLensGroup.Filter.MatchObjectAge.IsSetDaysLessThan())
                                xmlWriter.WriteElementString("DaysLessThan", StringUtils.FromInt(publicRequest.StorageLensGroup.Filter.MatchObjectAge.DaysLessThan.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensGroup.Filter.MatchObjectSize != null)
                        {
                            xmlWriter.WriteStartElement("MatchObjectSize");
                            if(publicRequest.StorageLensGroup.Filter.MatchObjectSize.IsSetBytesGreaterThan())
                                xmlWriter.WriteElementString("BytesGreaterThan", StringUtils.FromLong(publicRequest.StorageLensGroup.Filter.MatchObjectSize.BytesGreaterThan.Value));
                            if(publicRequest.StorageLensGroup.Filter.MatchObjectSize.IsSetBytesLessThan())
                                xmlWriter.WriteElementString("BytesLessThan", StringUtils.FromLong(publicRequest.StorageLensGroup.Filter.MatchObjectSize.BytesLessThan.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensGroup.Filter.Or != null)
                        {
                            xmlWriter.WriteStartElement("Or");
                            var publicRequestStorageLensGroupFilterOrMatchAnyPrefix = publicRequest.StorageLensGroup.Filter.Or.MatchAnyPrefix;
                            if (publicRequestStorageLensGroupFilterOrMatchAnyPrefix != null && (publicRequestStorageLensGroupFilterOrMatchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("MatchAnyPrefix");
                                foreach (var publicRequestStorageLensGroupFilterOrMatchAnyPrefixValue in publicRequestStorageLensGroupFilterOrMatchAnyPrefix) 
                                {
                                    xmlWriter.WriteStartElement("Prefix");
                                    xmlWriter.WriteValue(publicRequestStorageLensGroupFilterOrMatchAnyPrefixValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestStorageLensGroupFilterOrMatchAnySuffix = publicRequest.StorageLensGroup.Filter.Or.MatchAnySuffix;
                            if (publicRequestStorageLensGroupFilterOrMatchAnySuffix != null && (publicRequestStorageLensGroupFilterOrMatchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("MatchAnySuffix");
                                foreach (var publicRequestStorageLensGroupFilterOrMatchAnySuffixValue in publicRequestStorageLensGroupFilterOrMatchAnySuffix) 
                                {
                                    xmlWriter.WriteStartElement("Suffix");
                                    xmlWriter.WriteValue(publicRequestStorageLensGroupFilterOrMatchAnySuffixValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestStorageLensGroupFilterOrMatchAnyTag = publicRequest.StorageLensGroup.Filter.Or.MatchAnyTag;
                            if (publicRequestStorageLensGroupFilterOrMatchAnyTag != null && (publicRequestStorageLensGroupFilterOrMatchAnyTag.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("MatchAnyTag");
                                foreach (var publicRequestStorageLensGroupFilterOrMatchAnyTagValue in publicRequestStorageLensGroupFilterOrMatchAnyTag) 
                                {
                                if (publicRequestStorageLensGroupFilterOrMatchAnyTagValue != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestStorageLensGroupFilterOrMatchAnyTagValue.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestStorageLensGroupFilterOrMatchAnyTagValue.Key));
                                    if(publicRequestStorageLensGroupFilterOrMatchAnyTagValue.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestStorageLensGroupFilterOrMatchAnyTagValue.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if (publicRequest.StorageLensGroup.Filter.Or.MatchObjectAge != null)
                            {
                                xmlWriter.WriteStartElement("MatchObjectAge");
                                if(publicRequest.StorageLensGroup.Filter.Or.MatchObjectAge.IsSetDaysGreaterThan())
                                    xmlWriter.WriteElementString("DaysGreaterThan", StringUtils.FromInt(publicRequest.StorageLensGroup.Filter.Or.MatchObjectAge.DaysGreaterThan.Value));
                                if(publicRequest.StorageLensGroup.Filter.Or.MatchObjectAge.IsSetDaysLessThan())
                                    xmlWriter.WriteElementString("DaysLessThan", StringUtils.FromInt(publicRequest.StorageLensGroup.Filter.Or.MatchObjectAge.DaysLessThan.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensGroup.Filter.Or.MatchObjectSize != null)
                            {
                                xmlWriter.WriteStartElement("MatchObjectSize");
                                if(publicRequest.StorageLensGroup.Filter.Or.MatchObjectSize.IsSetBytesGreaterThan())
                                    xmlWriter.WriteElementString("BytesGreaterThan", StringUtils.FromLong(publicRequest.StorageLensGroup.Filter.Or.MatchObjectSize.BytesGreaterThan.Value));
                                if(publicRequest.StorageLensGroup.Filter.Or.MatchObjectSize.IsSetBytesLessThan())
                                    xmlWriter.WriteElementString("BytesLessThan", StringUtils.FromLong(publicRequest.StorageLensGroup.Filter.Or.MatchObjectSize.BytesLessThan.Value));
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StorageLensGroup.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.StorageLensGroup.Name));
                    if(publicRequest.StorageLensGroup.IsSetStorageLensGroupArn())
                        xmlWriter.WriteElementString("StorageLensGroupArn", StringUtils.FromString(publicRequest.StorageLensGroup.StorageLensGroupArn));
                    xmlWriter.WriteEndElement();
                }
                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && (publicRequestTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Tags");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    if (publicRequestTagsValue != null)
                    {
                        xmlWriter.WriteStartElement("Tag");
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsValue.Key));
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsValue.Value));
                        xmlWriter.WriteEndElement();
                    }
                    }            
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateStorageLensGroupRequestMarshaller _instance = new CreateStorageLensGroupRequestMarshaller();        

        internal static CreateStorageLensGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStorageLensGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateStorageLensGroupRequest publicRequest);
    }    
}