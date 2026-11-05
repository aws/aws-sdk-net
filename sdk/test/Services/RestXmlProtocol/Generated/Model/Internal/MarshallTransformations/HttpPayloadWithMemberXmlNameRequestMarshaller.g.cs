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
    /// HttpPayloadWithMemberXmlName Request Marshaller
    /// </summary>
    public partial class HttpPayloadWithMemberXmlNameRequestMarshaller : IMarshaller<IRequest, HttpPayloadWithMemberXmlNameRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpPayloadWithMemberXmlNameRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(HttpPayloadWithMemberXmlNameRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";

            request.ResourcePath = "/HttpPayloadWithMemberXmlName";

            if (publicRequest.IsSetNested())
            {
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
                    context.Writer.WriteStartElement("Hola");
                    PayloadWithXmlNameMarshaller.Instance.Marshall(publicRequest.Nested, context);
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
            }

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly HttpPayloadWithMemberXmlNameRequestMarshaller _instance = new();

        internal static HttpPayloadWithMemberXmlNameRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static HttpPayloadWithMemberXmlNameRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, HttpPayloadWithMemberXmlNameRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, HttpPayloadWithMemberXmlNameRequest publicRequest);
    }
}
