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
    /// CreateStreamingDistribution Request Marshaller
    /// </summary>       
    public partial class CreateStreamingDistributionRequestMarshaller : IMarshaller<IRequest, CreateStreamingDistributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStreamingDistributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStreamingDistributionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/streaming-distribution";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetStreamingDistributionConfig())
                {
                    xmlWriter.WriteStartElement("StreamingDistributionConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if (publicRequest.StreamingDistributionConfig.Aliases != null)
                    {
                        xmlWriter.WriteStartElement("Aliases");
                        var publicRequestStreamingDistributionConfigAliasesItems = publicRequest.StreamingDistributionConfig.Aliases.Items;
                        if (publicRequestStreamingDistributionConfigAliasesItems != null && (publicRequestStreamingDistributionConfigAliasesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestStreamingDistributionConfigAliasesItemsValue in publicRequestStreamingDistributionConfigAliasesItems) 
                            {
                                xmlWriter.WriteStartElement("CNAME");
                                xmlWriter.WriteValue(publicRequestStreamingDistributionConfigAliasesItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.StreamingDistributionConfig.Aliases.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.StreamingDistributionConfig.Aliases.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StreamingDistributionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.StreamingDistributionConfig.CallerReference));

                    if(publicRequest.StreamingDistributionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.StreamingDistributionConfig.Comment));

                    if(publicRequest.StreamingDistributionConfig.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.StreamingDistributionConfig.Enabled.Value));

                    if (publicRequest.StreamingDistributionConfig.Logging != null)
                    {
                        xmlWriter.WriteStartElement("Logging");
                        if(publicRequest.StreamingDistributionConfig.Logging.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.StreamingDistributionConfig.Logging.Bucket));
                        if(publicRequest.StreamingDistributionConfig.Logging.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.StreamingDistributionConfig.Logging.Enabled.Value));
                        if(publicRequest.StreamingDistributionConfig.Logging.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.StreamingDistributionConfig.Logging.Prefix));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StreamingDistributionConfig.IsSetPriceClass())
                        xmlWriter.WriteElementString("PriceClass", StringUtils.FromString(publicRequest.StreamingDistributionConfig.PriceClass));

                    if (publicRequest.StreamingDistributionConfig.S3Origin != null)
                    {
                        xmlWriter.WriteStartElement("S3Origin");
                        if(publicRequest.StreamingDistributionConfig.S3Origin.IsSetDomainName())
                            xmlWriter.WriteElementString("DomainName", StringUtils.FromString(publicRequest.StreamingDistributionConfig.S3Origin.DomainName));
                        if(publicRequest.StreamingDistributionConfig.S3Origin.IsSetOriginAccessIdentity())
                            xmlWriter.WriteElementString("OriginAccessIdentity", StringUtils.FromString(publicRequest.StreamingDistributionConfig.S3Origin.OriginAccessIdentity));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.StreamingDistributionConfig.TrustedSigners != null)
                    {
                        xmlWriter.WriteStartElement("TrustedSigners");
                        if(publicRequest.StreamingDistributionConfig.TrustedSigners.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.StreamingDistributionConfig.TrustedSigners.Enabled.Value));
                        var publicRequestStreamingDistributionConfigTrustedSignersItems = publicRequest.StreamingDistributionConfig.TrustedSigners.Items;
                        if (publicRequestStreamingDistributionConfigTrustedSignersItems != null && (publicRequestStreamingDistributionConfigTrustedSignersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestStreamingDistributionConfigTrustedSignersItemsValue in publicRequestStreamingDistributionConfigTrustedSignersItems) 
                            {
                                xmlWriter.WriteStartElement("AwsAccountNumber");
                                xmlWriter.WriteValue(publicRequestStreamingDistributionConfigTrustedSignersItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.StreamingDistributionConfig.TrustedSigners.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.StreamingDistributionConfig.TrustedSigners.Quantity.Value));
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
        private static CreateStreamingDistributionRequestMarshaller _instance = new CreateStreamingDistributionRequestMarshaller();        

        internal static CreateStreamingDistributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStreamingDistributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateStreamingDistributionRequest publicRequest);
    }    
}