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

using Amazon.ELBProxy.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ELBProxy.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ELBProxy");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-11-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/ELBProxy/operation/CreateProxy";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAttributes())
                {
                    context.Writer.WriteTextString("attributes");
                    context.Writer.WriteStartArray(publicRequest.Attributes.Count);
                    foreach (var publicRequestAttributesListValue in publicRequest.Attributes)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = AttributeMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttributesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetConfiguration())
                {
                    context.Writer.WriteTextString("configuration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProxyConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCustomerKmsKeyArn())
                {
                    context.Writer.WriteTextString("customerKmsKeyArn");
                    context.Writer.WriteTextString(publicRequest.CustomerKmsKeyArn);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WriteTextString("networkConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProxyNetworkUserConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetProxyVersion())
                {
                    context.Writer.WriteTextString("proxyVersion");
                    context.Writer.WriteTextString(publicRequest.ProxyVersion);
                }
                if (publicRequest.IsSetRoleArn())
                {
                    context.Writer.WriteTextString("roleArn");
                    context.Writer.WriteTextString(publicRequest.RoleArn);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;
                        context.Writer.WriteTextString(publicRequestTagsValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetType())
                {
                    context.Writer.WriteTextString("type");
                    context.Writer.WriteTextString(publicRequest.Type);
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
