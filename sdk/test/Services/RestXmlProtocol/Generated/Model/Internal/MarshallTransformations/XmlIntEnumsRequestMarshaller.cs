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
    /// XmlIntEnums Request Marshaller
    /// </summary>       
    public partial class XmlIntEnumsRequestMarshaller : IMarshaller<IRequest, XmlIntEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((XmlIntEnumsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(XmlIntEnumsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "PUT";
            request.ResourcePath = "/XmlIntEnums";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("XmlIntEnumsRequest", "");
                if(publicRequest.IsSetIntEnum1())
                    xmlWriter.WriteElementString("intEnum1", StringUtils.FromInt(publicRequest.IntEnum1.Value));

                if(publicRequest.IsSetIntEnum2())
                    xmlWriter.WriteElementString("intEnum2", StringUtils.FromInt(publicRequest.IntEnum2.Value));

                if(publicRequest.IsSetIntEnum3())
                    xmlWriter.WriteElementString("intEnum3", StringUtils.FromInt(publicRequest.IntEnum3.Value));

                var publicRequestIntEnumList = publicRequest.IntEnumList;
                if (publicRequestIntEnumList != null && (publicRequestIntEnumList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("intEnumList");
                    foreach (var publicRequestIntEnumListValue in publicRequestIntEnumList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestIntEnumListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetIntEnumMap())
                {
                    xmlWriter.WriteStartElement("intEnumMap");
                    foreach (var kvp in publicRequest.IntEnumMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("key", kvp.Key);
                        xmlWriter.WriteElementString("value", kvp.Value.ToString());
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                var publicRequestIntEnumSet = publicRequest.IntEnumSet;
                if (publicRequestIntEnumSet != null && (publicRequestIntEnumSet.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("intEnumSet");
                    foreach (var publicRequestIntEnumSetValue in publicRequestIntEnumSet) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestIntEnumSetValue);
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
        private static XmlIntEnumsRequestMarshaller _instance = new XmlIntEnumsRequestMarshaller();        

        internal static XmlIntEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlIntEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, XmlIntEnumsRequest publicRequest);
    }    
}