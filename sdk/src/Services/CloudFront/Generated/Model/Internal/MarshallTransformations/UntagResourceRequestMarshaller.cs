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
    /// UntagResource Request Marshaller
    /// </summary>       
    public class UntagResourceRequestMarshaller : IMarshaller<IRequest, UntagResourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UntagResourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UntagResourceRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2017-10-30/tagging";
            request.AddSubResource("Operation", "Untag");
            
            if (publicRequest.IsSetResource())
                request.Parameters.Add("Resource", StringUtils.FromString(publicRequest.Resource));
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("TagKeys", "http://cloudfront.amazonaws.com/doc/2017-10-30/");                                
                var publicRequestTagKeysItems = publicRequest.TagKeys.Items;
                if (publicRequestTagKeysItems != null && publicRequestTagKeysItems.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                    foreach (var publicRequestTagKeysItemsValue in publicRequestTagKeysItems) 
                    {
                        xmlWriter.WriteStartElement("Key", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                        xmlWriter.WriteValue(publicRequestTagKeysItemsValue);
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

            request.UseQueryString = true;
            return request;
        }
        private static UntagResourceRequestMarshaller _instance = new UntagResourceRequestMarshaller();        

        internal static UntagResourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UntagResourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}