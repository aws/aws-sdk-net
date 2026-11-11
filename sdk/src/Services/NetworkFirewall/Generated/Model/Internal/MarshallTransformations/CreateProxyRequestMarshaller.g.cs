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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProxy Request Marshaller
    /// </summary>
    public partial class CreateProxyRequestMarshaller : IMarshaller<IRequest, CreateProxyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProxyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateProxyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NetworkFirewall_20201112/operation/CreateProxy";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetListenerProperties())
                {
                    context.Writer.WriteTextString("ListenerProperties");
                    context.Writer.WriteStartArray(publicRequest.ListenerProperties.Count);
                    foreach (var publicRequestListenerPropertiesListValue in publicRequest.ListenerProperties)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ListenerPropertyRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestListenerPropertiesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetNatGatewayId())
                {
                    context.Writer.WriteTextString("NatGatewayId");
                    context.Writer.WriteTextString(publicRequest.NatGatewayId);
                }
                if (publicRequest.IsSetProxyConfigurationArn())
                {
                    context.Writer.WriteTextString("ProxyConfigurationArn");
                    context.Writer.WriteTextString(publicRequest.ProxyConfigurationArn);
                }
                if (publicRequest.IsSetProxyConfigurationName())
                {
                    context.Writer.WriteTextString("ProxyConfigurationName");
                    context.Writer.WriteTextString(publicRequest.ProxyConfigurationName);
                }
                if (publicRequest.IsSetProxyName())
                {
                    context.Writer.WriteTextString("ProxyName");
                    context.Writer.WriteTextString(publicRequest.ProxyName);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTlsInterceptProperties())
                {
                    context.Writer.WriteTextString("TlsInterceptProperties");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TlsInterceptPropertiesRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TlsInterceptProperties, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly CreateProxyRequestMarshaller _instance = new();

        internal static CreateProxyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateProxyRequestMarshaller Instance => _instance;
    }
}
