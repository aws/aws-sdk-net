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
    /// CreateVpcOrigin Request Marshaller
    /// </summary>       
    public partial class CreateVpcOriginRequestMarshaller : IMarshaller<IRequest, CreateVpcOriginRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpcOriginRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVpcOriginRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/vpc-origin";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateVpcOriginRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if (publicRequest.Tags != null)
                {
                    xmlWriter.WriteStartElement("Tags");
                    var publicRequestTagsItems = publicRequest.Tags.Items;
                    if (publicRequestTagsItems != null && (publicRequestTagsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Items");
                        foreach (var publicRequestTagsItemsValue in publicRequestTagsItems) 
                        {
                        if (publicRequestTagsItemsValue != null)
                        {
                            xmlWriter.WriteStartElement("Tag");
                            if(publicRequestTagsItemsValue.IsSetKey())
                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsItemsValue.Key));
                            if(publicRequestTagsItemsValue.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsItemsValue.Value));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.VpcOriginEndpointConfig != null)
                {
                    xmlWriter.WriteStartElement("VpcOriginEndpointConfig");
                    if(publicRequest.VpcOriginEndpointConfig.IsSetArn())
                        xmlWriter.WriteElementString("Arn", StringUtils.FromString(publicRequest.VpcOriginEndpointConfig.Arn));
                    if(publicRequest.VpcOriginEndpointConfig.IsSetHTTPPort())
                        xmlWriter.WriteElementString("HTTPPort", StringUtils.FromInt(publicRequest.VpcOriginEndpointConfig.HTTPPort.Value));
                    if(publicRequest.VpcOriginEndpointConfig.IsSetHTTPSPort())
                        xmlWriter.WriteElementString("HTTPSPort", StringUtils.FromInt(publicRequest.VpcOriginEndpointConfig.HTTPSPort.Value));
                    if(publicRequest.VpcOriginEndpointConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.VpcOriginEndpointConfig.Name));
                    if(publicRequest.VpcOriginEndpointConfig.IsSetOriginProtocolPolicy())
                        xmlWriter.WriteElementString("OriginProtocolPolicy", StringUtils.FromString(publicRequest.VpcOriginEndpointConfig.OriginProtocolPolicy));
                    if (publicRequest.VpcOriginEndpointConfig.OriginSslProtocols != null)
                    {
                        xmlWriter.WriteStartElement("OriginSslProtocols");
                        var publicRequestVpcOriginEndpointConfigOriginSslProtocolsItems = publicRequest.VpcOriginEndpointConfig.OriginSslProtocols.Items;
                        if (publicRequestVpcOriginEndpointConfigOriginSslProtocolsItems != null && (publicRequestVpcOriginEndpointConfigOriginSslProtocolsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestVpcOriginEndpointConfigOriginSslProtocolsItemsValue in publicRequestVpcOriginEndpointConfigOriginSslProtocolsItems) 
                            {
                                xmlWriter.WriteStartElement("SslProtocol");
                                xmlWriter.WriteValue(publicRequestVpcOriginEndpointConfigOriginSslProtocolsItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.VpcOriginEndpointConfig.OriginSslProtocols.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.VpcOriginEndpointConfig.OriginSslProtocols.Quantity.Value));
                        xmlWriter.WriteEndElement();
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateVpcOriginRequestMarshaller _instance = new CreateVpcOriginRequestMarshaller();        

        internal static CreateVpcOriginRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVpcOriginRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateVpcOriginRequest publicRequest);
    }    
}