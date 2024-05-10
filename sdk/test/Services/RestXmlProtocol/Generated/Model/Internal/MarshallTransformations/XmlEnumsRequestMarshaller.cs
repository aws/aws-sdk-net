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
    /// XmlEnums Request Marshaller
    /// </summary>       
    public class XmlEnumsRequestMarshaller : IMarshaller<IRequest, XmlEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((XmlEnumsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(XmlEnumsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "PUT";
            request.ResourcePath = "/XmlEnums";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("XmlEnumsRequest", "");
                if(publicRequest.IsSetFooEnum1())
                    xmlWriter.WriteElementString("fooEnum1", StringUtils.FromString(publicRequest.FooEnum1));

                if(publicRequest.IsSetFooEnum2())
                    xmlWriter.WriteElementString("fooEnum2", StringUtils.FromString(publicRequest.FooEnum2));

                if(publicRequest.IsSetFooEnum3())
                    xmlWriter.WriteElementString("fooEnum3", StringUtils.FromString(publicRequest.FooEnum3));

                var publicRequestFooEnumList = publicRequest.FooEnumList;
                if (publicRequestFooEnumList != null && (publicRequestFooEnumList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("fooEnumList");
                    foreach (var publicRequestFooEnumListValue in publicRequestFooEnumList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestFooEnumListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetFooEnumMap())
                {
                    xmlWriter.WriteStartElement("fooEnumMap");
                    foreach (var kvp in publicRequest.FooEnumMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("key", kvp.Key);
                        xmlWriter.WriteElementString("value", kvp.Value);
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                var publicRequestFooEnumSet = publicRequest.FooEnumSet;
                if (publicRequestFooEnumSet != null && (publicRequestFooEnumSet.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("fooEnumSet");
                    foreach (var publicRequestFooEnumSetValue in publicRequestFooEnumSet) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestFooEnumSetValue);
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static XmlEnumsRequestMarshaller _instance = new XmlEnumsRequestMarshaller();        

        internal static XmlEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}