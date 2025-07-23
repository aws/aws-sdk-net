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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NestedXmlMapWithXmlName Request Marshaller
    /// </summary>       
    public partial class NestedXmlMapWithXmlNameRequestMarshaller : IMarshaller<IRequest, NestedXmlMapWithXmlNameRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NestedXmlMapWithXmlNameRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(NestedXmlMapWithXmlNameRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "POST";
            request.ResourcePath = "/NestedXmlMapWithXmlName";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("NestedXmlMapWithXmlNameRequest", "");
                if(publicRequest.IsSetNestedXmlMapWithXmlNameMap())
                {
                    xmlWriter.WriteStartElement("nestedXmlMapWithXmlNameMap");
                    foreach (var kvp in publicRequest.NestedXmlMapWithXmlNameMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("OuterKey", kvp.Key);
                        xmlWriter.WriteStartElement("value");
                        foreach (var kvp1 in kvp.Value) 
                        {
                            xmlWriter.WriteStartElement("entry");
                            xmlWriter.WriteElementString("InnerKey", kvp1.Key);
                            xmlWriter.WriteElementString("InnerValue", kvp1.Value);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();                
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static NestedXmlMapWithXmlNameRequestMarshaller _instance = new NestedXmlMapWithXmlNameRequestMarshaller();        

        internal static NestedXmlMapWithXmlNameRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NestedXmlMapWithXmlNameRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, NestedXmlMapWithXmlNameRequest publicRequest);
    }    
}