/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStreamingDistributionWithTags Request Marshaller
    /// </summary>       
    public class CreateStreamingDistributionWithTagsRequestMarshaller : IMarshaller<IRequest, CreateStreamingDistributionWithTagsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            string uriResourcePath = "/2017-10-30/streaming-distribution";
            request.AddSubResource("WithTags");
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("StreamingDistributionConfigWithTags", "http://cloudfront.amazonaws.com/doc/2017-10-30/");                                
                
                if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig != null) 
                {
                    xmlWriter.WriteStartElement("StreamingDistributionConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    
                    if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems = publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases.Items;
                        if (publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems != null && publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            foreach (var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItemsValue in publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItems) 
                            {
                                xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                xmlWriter.WriteValue(publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigAliasesItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Aliases.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.CallerReference));                 
    
                    if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Comment));                 
    
                    if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Enabled));                 
    
                    
                    if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.Bucket));                 
        
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.Enabled));                 
        
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.Logging.Prefix));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.IsSetPriceClass())
                        xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.PriceClass));                 
    
                    
                    if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin != null) 
                    {
                        xmlWriter.WriteStartElement("S3Origin", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.IsSetDomainName())
                            xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.DomainName));                 
        
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.IsSetOriginAccessIdentity())
                            xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.S3Origin.OriginAccessIdentity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners != null) 
                    {
                        xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.Enabled));                 
        
                        var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems = publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.Items;
                        if (publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems != null && publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            foreach (var publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItemsValue in publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItems) 
                            {
                                xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                xmlWriter.WriteValue(publicRequestStreamingDistributionConfigWithTagsStreamingDistributionConfigTrustedSignersItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.StreamingDistributionConfigWithTags.StreamingDistributionConfig.TrustedSigners.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.StreamingDistributionConfigWithTags.Tags != null) 
                {
                    xmlWriter.WriteStartElement("Tags", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    var publicRequestStreamingDistributionConfigWithTagsTagsItems = publicRequest.StreamingDistributionConfigWithTags.Tags.Items;
                    if (publicRequestStreamingDistributionConfigWithTagsTagsItems != null && publicRequestStreamingDistributionConfigWithTagsTagsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                        foreach (var publicRequestStreamingDistributionConfigWithTagsTagsItemsValue in publicRequestStreamingDistributionConfigWithTagsTagsItems) 
                        {
                        
                        if (publicRequestStreamingDistributionConfigWithTagsTagsItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("Tag", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            if(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.IsSetKey())
                                xmlWriter.WriteElementString("Key", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.Key));                 
            
                            if(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.IsSetValue())
                                xmlWriter.WriteElementString("Value", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestStreamingDistributionConfigWithTagsTagsItemsValue.Value));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
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

    }    
}