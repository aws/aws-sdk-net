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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.NumericTypesRestXml.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BodyNumbers Request Marshaller
    /// </summary>
    public partial class BodyNumbersRequestMarshaller : IMarshaller<IRequest, BodyNumbersRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BodyNumbersRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
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
                var context = new XmlMarshallerContext(request, xmlWriter);
                context.Writer.WriteStartElement("BodyNumbersRequest");
                if (publicRequest.IsSetBigDecimalList())
                {
                    var publicRequestBigDecimalList = publicRequest.BigDecimalList;
                    context.Writer.WriteStartElement("BigDecimalList");
                    foreach (var publicRequestBigDecimalListValue in publicRequestBigDecimalList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromBigDecimal(publicRequestBigDecimalListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetBigDecimalMap())
                {
                    context.Writer.WriteStartElement("BigDecimalMap");
                    foreach (var kvp in publicRequest.BigDecimalMap)
                    {
                        context.Writer.WriteStartElement("entry");
                        context.Writer.WriteElementString("key", kvp.Key);
                        context.Writer.WriteElementString("value", StringUtils.FromBigDecimal(kvp.Value));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetBigDecimalValue())
                {
                    context.Writer.WriteElementString("BigDecimalValue", StringUtils.FromBigDecimal(publicRequest.BigDecimalValue.Value));
                }
                if (publicRequest.IsSetBigIntegerList())
                {
                    var publicRequestBigIntegerList = publicRequest.BigIntegerList;
                    context.Writer.WriteStartElement("BigIntegerList");
                    foreach (var publicRequestBigIntegerListValue in publicRequestBigIntegerList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromBigInteger(publicRequestBigIntegerListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetBigIntegerMap())
                {
                    context.Writer.WriteStartElement("BigIntegerMap");
                    foreach (var kvp in publicRequest.BigIntegerMap)
                    {
                        context.Writer.WriteStartElement("entry");
                        context.Writer.WriteElementString("key", kvp.Key);
                        context.Writer.WriteElementString("value", StringUtils.FromBigInteger(kvp.Value));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetBigIntegerValue())
                {
                    context.Writer.WriteElementString("BigIntegerValue", StringUtils.FromBigInteger(publicRequest.BigIntegerValue.Value));
                }
                if (publicRequest.IsSetByteList())
                {
                    var publicRequestByteList = publicRequest.ByteList;
                    context.Writer.WriteStartElement("ByteList");
                    foreach (var publicRequestByteListValue in publicRequestByteList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromSByte(publicRequestByteListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetByteMap())
                {
                    context.Writer.WriteStartElement("ByteMap");
                    foreach (var kvp in publicRequest.ByteMap)
                    {
                        context.Writer.WriteStartElement("entry");
                        context.Writer.WriteElementString("key", kvp.Key);
                        context.Writer.WriteElementString("value", StringUtils.FromSByte(kvp.Value));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetByteValue())
                {
                    context.Writer.WriteElementString("ByteValue", StringUtils.FromSByte(publicRequest.ByteValue.Value));
                }
                if (publicRequest.IsSetNested())
                {
                    context.Writer.WriteStartElement("Nested");
                    NestedNumbersMarshaller.Instance.Marshall(publicRequest.Nested, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetNestedList())
                {
                    var publicRequestNestedList = publicRequest.NestedList;
                    context.Writer.WriteStartElement("NestedList");
                    foreach (var publicRequestNestedListValue in publicRequestNestedList)
                    {
                        if (publicRequestNestedListValue != null)
                        {
                            context.Writer.WriteStartElement("member");
                            NestedNumbersMarshaller.Instance.Marshall(publicRequestNestedListValue, context);
                            context.Writer.WriteEndElement();
                        }
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetShortList())
                {
                    var publicRequestShortList = publicRequest.ShortList;
                    context.Writer.WriteStartElement("ShortList");
                    foreach (var publicRequestShortListValue in publicRequestShortList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromShort(publicRequestShortListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetShortMap())
                {
                    context.Writer.WriteStartElement("ShortMap");
                    foreach (var kvp in publicRequest.ShortMap)
                    {
                        context.Writer.WriteStartElement("entry");
                        context.Writer.WriteElementString("key", kvp.Key);
                        context.Writer.WriteElementString("value", StringUtils.FromShort(kvp.Value));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetShortValue())
                {
                    context.Writer.WriteElementString("ShortValue", StringUtils.FromShort(publicRequest.ShortValue.Value));
                }
                context.Writer.WriteEndElement();
            }
            try
            {
#if NETFRAMEWORK
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

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly BodyNumbersRequestMarshaller _instance = new();

        internal static BodyNumbersRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BodyNumbersRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, BodyNumbersRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, BodyNumbersRequest publicRequest);
    }
}
