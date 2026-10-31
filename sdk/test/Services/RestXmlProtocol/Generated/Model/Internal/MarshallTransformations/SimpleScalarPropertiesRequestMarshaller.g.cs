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

using Amazon.RestXmlProtocol.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimpleScalarProperties Request Marshaller
    /// </summary>
    public partial class SimpleScalarPropertiesRequestMarshaller : IMarshaller<IRequest, SimpleScalarPropertiesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimpleScalarPropertiesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SimpleScalarPropertiesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";

            if (publicRequest.IsSetFoo())
            {
                request.Headers["X-Foo"] = publicRequest.Foo;
            }

            request.ResourcePath = "/SimpleScalarProperties";

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
                context.Writer.WriteStartElement("SimpleScalarPropertiesRequest");
                if (publicRequest.IsSetByteValue())
                {
                    context.Writer.WriteElementString("byteValue", StringUtils.FromSByte(publicRequest.ByteValue.Value));
                }
                if (publicRequest.IsSetDoubleValue())
                {
                    context.Writer.WriteElementString("DoubleDribble", StringUtils.FromDouble(publicRequest.DoubleValue.Value));
                }
                if (publicRequest.IsSetFalseBooleanValue())
                {
                    context.Writer.WriteElementString("falseBooleanValue", StringUtils.FromBool(publicRequest.FalseBooleanValue.Value));
                }
                if (publicRequest.IsSetFloatValue())
                {
                    context.Writer.WriteElementString("floatValue", StringUtils.FromFloat(publicRequest.FloatValue.Value));
                }
                if (publicRequest.IsSetIntegerValue())
                {
                    context.Writer.WriteElementString("integerValue", StringUtils.FromInt(publicRequest.IntegerValue.Value));
                }
                if (publicRequest.IsSetLongValue())
                {
                    context.Writer.WriteElementString("longValue", StringUtils.FromLong(publicRequest.LongValue.Value));
                }
                if (publicRequest.IsSetShortValue())
                {
                    context.Writer.WriteElementString("shortValue", StringUtils.FromShort(publicRequest.ShortValue.Value));
                }
                if (publicRequest.IsSetStringValue())
                {
                    context.Writer.WriteElementString("stringValue", StringUtils.FromString(publicRequest.StringValue));
                }
                if (publicRequest.IsSetTrueBooleanValue())
                {
                    context.Writer.WriteElementString("trueBooleanValue", StringUtils.FromBool(publicRequest.TrueBooleanValue.Value));
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly SimpleScalarPropertiesRequestMarshaller _instance = new();

        internal static SimpleScalarPropertiesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SimpleScalarPropertiesRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, SimpleScalarPropertiesRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, SimpleScalarPropertiesRequest publicRequest);
    }
}
