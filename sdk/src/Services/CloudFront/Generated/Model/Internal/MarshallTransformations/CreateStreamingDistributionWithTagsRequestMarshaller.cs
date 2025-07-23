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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStreamingDistributionWithTags Request Marshaller
    /// </summary>       
    public partial class CreateStreamingDistributionWithTagsRequestMarshaller : IMarshaller<IRequest, CreateStreamingDistributionWithTagsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStreamingDistributionWithTagsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStreamingDistributionWithTagsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.AddSubResource("WithTags");
            request.ResourcePath = "/2020-05-31/streaming-distribution";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetStreamingDistributionConfigWithTags())
                {
                    xmlWriter.WriteStartElement("StreamingDistributionConfigWithTags", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig != null)
                    {
                        xmlWriter.WriteStartElement("StreamingDistributionConfig");
                        if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases != null)
                        {
                            xmlWriter.WriteStartElement("Aliases");
                            var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems = publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases.Items;
                            if (publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems != null && (publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItemsValue in publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems) 
                                {
                                    xmlWriter.WriteStartElement("CNAME");
                                    xmlWriter.WriteValue(publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetCallerReference())
                            xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.CallerReference));
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetComment())
                            xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Comment));
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Enabled.Value));
                        if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging != null)
                        {
                            xmlWriter.WriteStartElement("Logging");
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.Bucket));
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.Enabled.Value));
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.Prefix));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetPriceClass())
                            xmlWriter.WriteElementString("PriceClass", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.PriceClass));
                        if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin != null)
                        {
                            xmlWriter.WriteStartElement("S3Origin");
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.IsSetDomainName())
                                xmlWriter.WriteElementString("DomainName", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.DomainName));
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.IsSetOriginAccessIdentity())
                                xmlWriter.WriteElementString("OriginAccessIdentity", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.OriginAccessIdentity));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners != null)
                        {
                            xmlWriter.WriteStartElement("TrustedSigners");
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.Enabled.Value));
                            var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems = publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.Items;
                            if (publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems != null && (publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItemsValue in publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems) 
                                {
                                    xmlWriter.WriteStartElement("AwsAccountNumber");
                                    xmlWriter.WriteValue(publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.StreamingDistributionConfigWithTags.Tags != null)
                    {
                        xmlWriter.WriteStartElement("Tags");
                        var publicRequestStreamingDistributionConfigWithTagsTagsItems = publicRequest.StreamingDistributionConfigWithTags.Tags.Items;
                        if (publicRequestStreamingDistributionConfigWithTagsTagsItems != null && (publicRequestStreamingDistributionConfigWithTagsTagsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestStreamingDistributionConfigWithTagsTagsItemsValue in publicRequestStreamingDistributionConfigWithTagsTagsItems) 
                            {
                            if (publicRequestStreamingDistributionConfigWithTagsTagsItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("Tag");
                                if(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.Key));
                                if(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.Value));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateStreamingDistributionWithTagsRequestMarshaller _instance = new CreateStreamingDistributionWithTagsRequestMarshaller();        

        internal static CreateStreamingDistributionWithTagsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStreamingDistributionWithTagsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateStreamingDistributionWithTagsRequest publicRequest);
    }    
}