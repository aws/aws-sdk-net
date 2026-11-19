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
    /// AssociateSubnets Request Marshaller
    /// </summary>
    public partial class AssociateSubnetsRequestMarshaller : IMarshaller<IRequest, AssociateSubnetsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateSubnetsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssociateSubnetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NetworkFirewall_20201112/operation/AssociateSubnets";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetFirewallArn())
                {
                    context.Writer.WriteTextString("FirewallArn");
                    context.Writer.WriteTextString(publicRequest.FirewallArn);
                }
                if (publicRequest.IsSetFirewallName())
                {
                    context.Writer.WriteTextString("FirewallName");
                    context.Writer.WriteTextString(publicRequest.FirewallName);
                }
                if (publicRequest.IsSetNatGatewayCreateMappings())
                {
                    context.Writer.WriteTextString("NatGatewayCreateMappings");
                    context.Writer.WriteStartArray(publicRequest.NatGatewayCreateMappings.Count);
                    foreach (var publicRequestNatGatewayCreateMappingsListValue in publicRequest.NatGatewayCreateMappings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = NatGatewayCreateMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestNatGatewayCreateMappingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSubnetMappings())
                {
                    context.Writer.WriteTextString("SubnetMappings");
                    context.Writer.WriteStartArray(publicRequest.SubnetMappings.Count);
                    foreach (var publicRequestSubnetMappingsListValue in publicRequest.SubnetMappings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = SubnetMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubnetMappingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetUpdateToken())
                {
                    context.Writer.WriteTextString("UpdateToken");
                    context.Writer.WriteTextString(publicRequest.UpdateToken);
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

        private static readonly AssociateSubnetsRequestMarshaller _instance = new();

        internal static AssociateSubnetsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssociateSubnetsRequestMarshaller Instance => _instance;
    }
}
