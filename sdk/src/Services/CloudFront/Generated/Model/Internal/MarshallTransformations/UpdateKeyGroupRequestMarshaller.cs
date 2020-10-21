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

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateKeyGroup Request Marshaller
    /// </summary>       
    public class UpdateKeyGroupRequestMarshaller : IMarshaller<IRequest, UpdateKeyGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateKeyGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateKeyGroupRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
        
            if(publicRequest.IsSetIfMatch())
                request.Headers["If-Match"] = publicRequest.IfMatch;
            if (!publicRequest.IsSetId())
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2020-05-31/key-group/{Id}";
            request.MarshallerVersion = 2;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                if (publicRequest.IsSetKeyGroupConfig())
                {
                    xmlWriter.WriteStartElement("KeyGroupConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.KeyGroupConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.KeyGroupConfig.Comment));                    
    
                    var publicRequestKeyGroupConfigItems = publicRequest.KeyGroupConfig.Items;
                    if (publicRequestKeyGroupConfigItems != null && publicRequestKeyGroupConfigItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                        foreach (var publicRequestKeyGroupConfigItemsValue in publicRequestKeyGroupConfigItems) 
                        {
                            xmlWriter.WriteStartElement("PublicKey", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            xmlWriter.WriteValue(publicRequestKeyGroupConfigItemsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.KeyGroupConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.KeyGroupConfig.Name));                    
    
    
                    xmlWriter.WriteEndElement();
                }
            }
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
        private static UpdateKeyGroupRequestMarshaller _instance = new UpdateKeyGroupRequestMarshaller();        

        internal static UpdateKeyGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateKeyGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}