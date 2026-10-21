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
    /// NestedXmlMapWithXmlName Request Marshaller
    /// </summary>
    public partial class NestedXmlMapWithXmlNameRequestMarshaller : IMarshaller<IRequest, NestedXmlMapWithXmlNameRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NestedXmlMapWithXmlNameRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(NestedXmlMapWithXmlNameRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";

            request.ResourcePath = "/NestedXmlMapWithXmlName";

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
                context.Writer.WriteStartElement("NestedXmlMapWithXmlNameRequest");
                if (publicRequest.IsSetNestedXmlMapWithXmlNameMap())
                {
                    context.Writer.WriteStartElement("nestedXmlMapWithXmlNameMap");
                    foreach (var kvp in publicRequest.NestedXmlMapWithXmlNameMap)
                    {
                        context.Writer.WriteStartElement("entry");
                        context.Writer.WriteElementString("OuterKey", kvp.Key);
                        context.Writer.WriteStartElement("value");
                        foreach (var kvp1 in kvp.Value)
                        {
                            context.Writer.WriteStartElement("entry");
                            context.Writer.WriteElementString("InnerKey", kvp1.Key);
                            context.Writer.WriteElementString("InnerValue", kvp1.Value);
                            context.Writer.WriteEndElement();
                        }
                        context.Writer.WriteEndElement();
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
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

        private static readonly NestedXmlMapWithXmlNameRequestMarshaller _instance = new();

        internal static NestedXmlMapWithXmlNameRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static NestedXmlMapWithXmlNameRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, NestedXmlMapWithXmlNameRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, NestedXmlMapWithXmlNameRequest publicRequest);
    }
}
