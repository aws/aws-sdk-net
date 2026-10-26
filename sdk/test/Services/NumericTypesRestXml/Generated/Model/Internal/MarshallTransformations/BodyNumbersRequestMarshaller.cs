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
 * Do not modify this file. This file is generated from the numerictypesrestxml-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesRestXml.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BodyNumbers Request Marshaller
    /// </summary>       
    public partial class BodyNumbersRequestMarshaller : IMarshaller<IRequest, BodyNumbersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BodyNumbersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BodyNumbersRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.NumericTypesRestXml");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
            request.ResourcePath = "/BodyNumbers";

#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            var bufferTextWriter = new XMLEncodedBufferTextWriter(((PooledContentStream)request.ContentStream).BufferWriter);
            using (var xmlWriter = XmlWriter.Create(bufferTextWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#else
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#endif
                xmlWriter.WriteStartElement("BodyNumbersRequest", "");
                var publicRequestBigDecimalList = publicRequest.BigDecimalList;
                if (publicRequest.IsSetBigDecimalList()) 
                {
                    xmlWriter.WriteStartElement("BigDecimalList");
                    foreach (var publicRequestBigDecimalListValue in publicRequestBigDecimalList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestBigDecimalListValue.ToPlainString(System.Globalization.CultureInfo.InvariantCulture));
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetBigDecimalMap())
                {
                    xmlWriter.WriteStartElement("BigDecimalMap");
                    foreach (var kvp in publicRequest.BigDecimalMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("key", kvp.Key);
                        xmlWriter.WriteElementString("value", kvp.Value.ToPlainString(System.Globalization.CultureInfo.InvariantCulture));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetBigDecimalValue())
                    xmlWriter.WriteElementString("BigDecimalValue", StringUtils.FromBigDecimal(publicRequest.BigDecimalValue.Value));

                var publicRequestBigIntegerList = publicRequest.BigIntegerList;
                if (publicRequest.IsSetBigIntegerList()) 
                {
                    xmlWriter.WriteStartElement("BigIntegerList");
                    foreach (var publicRequestBigIntegerListValue in publicRequestBigIntegerList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestBigIntegerListValue.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetBigIntegerMap())
                {
                    xmlWriter.WriteStartElement("BigIntegerMap");
                    foreach (var kvp in publicRequest.BigIntegerMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("key", kvp.Key);
                        xmlWriter.WriteElementString("value", kvp.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetBigIntegerValue())
                    xmlWriter.WriteElementString("BigIntegerValue", StringUtils.FromBigInteger(publicRequest.BigIntegerValue.Value));

                var publicRequestByteList = publicRequest.ByteList;
                if (publicRequest.IsSetByteList()) 
                {
                    xmlWriter.WriteStartElement("ByteList");
                    foreach (var publicRequestByteListValue in publicRequestByteList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestByteListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetByteMap())
                {
                    xmlWriter.WriteStartElement("ByteMap");
                    foreach (var kvp in publicRequest.ByteMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("key", kvp.Key);
                        xmlWriter.WriteElementString("value", kvp.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetByteValue())
                    xmlWriter.WriteElementString("ByteValue", StringUtils.FromSByte(publicRequest.ByteValue.Value));

                if (publicRequest.IsSetNested())
                {
                    xmlWriter.WriteStartElement("Nested");
                    if(publicRequest.Nested.IsSetBigDecimalValue())
                        xmlWriter.WriteElementString("BigDecimalValue", StringUtils.FromBigDecimal(publicRequest.Nested.BigDecimalValue.Value));
                    if(publicRequest.Nested.IsSetBigIntegerValue())
                        xmlWriter.WriteElementString("BigIntegerValue", StringUtils.FromBigInteger(publicRequest.Nested.BigIntegerValue.Value));
                    if(publicRequest.Nested.IsSetByteValue())
                        xmlWriter.WriteElementString("ByteValue", StringUtils.FromSByte(publicRequest.Nested.ByteValue.Value));
                    if(publicRequest.Nested.IsSetShortValue())
                        xmlWriter.WriteElementString("ShortValue", StringUtils.FromShort(publicRequest.Nested.ShortValue.Value));
                    xmlWriter.WriteEndElement();
                }
                var publicRequestNestedList = publicRequest.NestedList;
                if (publicRequest.IsSetNestedList()) 
                {
                    xmlWriter.WriteStartElement("NestedList");
                    foreach (var publicRequestNestedListValue in publicRequestNestedList) 
                    {
                        if (publicRequestNestedListValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            if(publicRequestNestedListValue.IsSetBigDecimalValue())
                                xmlWriter.WriteElementString("BigDecimalValue", StringUtils.FromBigDecimal(publicRequestNestedListValue.BigDecimalValue.Value));
                            if(publicRequestNestedListValue.IsSetBigIntegerValue())
                                xmlWriter.WriteElementString("BigIntegerValue", StringUtils.FromBigInteger(publicRequestNestedListValue.BigIntegerValue.Value));
                            if(publicRequestNestedListValue.IsSetByteValue())
                                xmlWriter.WriteElementString("ByteValue", StringUtils.FromSByte(publicRequestNestedListValue.ByteValue.Value));
                            if(publicRequestNestedListValue.IsSetShortValue())
                                xmlWriter.WriteElementString("ShortValue", StringUtils.FromShort(publicRequestNestedListValue.ShortValue.Value));
                            xmlWriter.WriteEndElement();
                        }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestShortList = publicRequest.ShortList;
                if (publicRequest.IsSetShortList()) 
                {
                    xmlWriter.WriteStartElement("ShortList");
                    foreach (var publicRequestShortListValue in publicRequestShortList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestShortListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetShortMap())
                {
                    xmlWriter.WriteStartElement("ShortMap");
                    foreach (var kvp in publicRequest.ShortMap)
                    {
                        xmlWriter.WriteStartElement("entry");

                        xmlWriter.WriteElementString("key", kvp.Key);
                        xmlWriter.WriteElementString("value", kvp.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetShortValue())
                    xmlWriter.WriteElementString("ShortValue", StringUtils.FromShort(publicRequest.ShortValue.Value));


                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
#if NETFRAMEWORK // For non .NET Framework targets the request payload is stored in the ContentStream via the PooledContentStream.
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
#endif
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-10-26";
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static BodyNumbersRequestMarshaller _instance = new BodyNumbersRequestMarshaller();        

        internal static BodyNumbersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BodyNumbersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, BodyNumbersRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, BodyNumbersRequest publicRequest);
    }    
}