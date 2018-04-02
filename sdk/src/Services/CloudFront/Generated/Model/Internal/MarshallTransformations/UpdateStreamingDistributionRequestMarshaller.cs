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
    /// UpdateStreamingDistribution Request Marshaller
    /// </summary>       
    public class UpdateStreamingDistributionRequestMarshaller : IMarshaller<IRequest, UpdateStreamingDistributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStreamingDistributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStreamingDistributionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
            string uriResourcePath = "/2017-10-30/streaming-distribution/{Id}/config";
        
            if(publicRequest.IsSetIfMatch())
                request.Headers["If-Match"] = publicRequest.IfMatch;
            if (!publicRequest.IsSetId())
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            uriResourcePath = uriResourcePath.Replace("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("StreamingDistributionConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");                                
                
                if (publicRequest.StreamingDistributionConfig.Aliases != null) 
                {
                    xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    var publicRequestStreamingDistributionConfigAliasesItems = publicRequest.StreamingDistributionConfig.Aliases.Items;
                    if (publicRequestStreamingDistributionConfigAliasesItems != null && publicRequestStreamingDistributionConfigAliasesItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                        foreach (var publicRequestStreamingDistributionConfigAliasesItemsValue in publicRequestStreamingDistributionConfigAliasesItems) 
                        {
                            xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            xmlWriter.WriteValue(publicRequestStreamingDistributionConfigAliasesItemsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.StreamingDistributionConfig.Aliases.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.StreamingDistributionConfig.Aliases.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.StreamingDistributionConfig.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.CallerReference));                    

                if(publicRequest.StreamingDistributionConfig.IsSetComment())
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.Comment));                    

                if(publicRequest.StreamingDistributionConfig.IsSetEnabled())
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.StreamingDistributionConfig.Enabled));                    

                
                if (publicRequest.StreamingDistributionConfig.Logging != null) 
                {
                    xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    if(publicRequest.StreamingDistributionConfig.Logging.IsSetBucket())
                        xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.Logging.Bucket));                 
    
                    if(publicRequest.StreamingDistributionConfig.Logging.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.StreamingDistributionConfig.Logging.Enabled));                 
    
                    if(publicRequest.StreamingDistributionConfig.Logging.IsSetPrefix())
                        xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.Logging.Prefix));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.StreamingDistributionConfig.IsSetPriceClass())
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.PriceClass));                    

                
                if (publicRequest.StreamingDistributionConfig.S3Origin != null) 
                {
                    xmlWriter.WriteStartElement("S3Origin", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    if(publicRequest.StreamingDistributionConfig.S3Origin.IsSetDomainName())
                        xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.S3Origin.DomainName));                 
    
                    if(publicRequest.StreamingDistributionConfig.S3Origin.IsSetOriginAccessIdentity())
                        xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.StreamingDistributionConfig.S3Origin.OriginAccessIdentity));                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.StreamingDistributionConfig.TrustedSigners != null) 
                {
                    xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    if(publicRequest.StreamingDistributionConfig.TrustedSigners.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.StreamingDistributionConfig.TrustedSigners.Enabled));                 
    
                    var publicRequestStreamingDistributionConfigTrustedSignersItems = publicRequest.StreamingDistributionConfig.TrustedSigners.Items;
                    if (publicRequestStreamingDistributionConfigTrustedSignersItems != null && publicRequestStreamingDistributionConfigTrustedSignersItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                        foreach (var publicRequestStreamingDistributionConfigTrustedSignersItemsValue in publicRequestStreamingDistributionConfigTrustedSignersItems) 
                        {
                            xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            xmlWriter.WriteValue(publicRequestStreamingDistributionConfigTrustedSignersItemsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.StreamingDistributionConfig.TrustedSigners.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.StreamingDistributionConfig.TrustedSigners.Quantity));                 
    
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
        private static UpdateStreamingDistributionRequestMarshaller _instance = new UpdateStreamingDistributionRequestMarshaller();        

        internal static UpdateStreamingDistributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStreamingDistributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}