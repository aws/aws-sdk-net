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
    /// ListFlowOperations Request Marshaller
    /// </summary>
    public partial class ListFlowOperationsRequestMarshaller : IMarshaller<IRequest, ListFlowOperationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFlowOperationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListFlowOperationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NetworkFirewall_20201112/operation/ListFlowOperations";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WriteTextString("AvailabilityZone");
                    context.Writer.WriteTextString(publicRequest.AvailabilityZone);
                }
                if (publicRequest.IsSetAvailabilityZoneId())
                {
                    context.Writer.WriteTextString("AvailabilityZoneId");
                    context.Writer.WriteTextString(publicRequest.AvailabilityZoneId);
                }
                if (publicRequest.IsSetFirewallArn())
                {
                    context.Writer.WriteTextString("FirewallArn");
                    context.Writer.WriteTextString(publicRequest.FirewallArn);
                }
                if (publicRequest.IsSetFlowOperationType())
                {
                    context.Writer.WriteTextString("FlowOperationType");
                    context.Writer.WriteTextString(publicRequest.FlowOperationType);
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("MaxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetVpcEndpointAssociationArn())
                {
                    context.Writer.WriteTextString("VpcEndpointAssociationArn");
                    context.Writer.WriteTextString(publicRequest.VpcEndpointAssociationArn);
                }
                if (publicRequest.IsSetVpcEndpointId())
                {
                    context.Writer.WriteTextString("VpcEndpointId");
                    context.Writer.WriteTextString(publicRequest.VpcEndpointId);
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

        private static readonly ListFlowOperationsRequestMarshaller _instance = new();

        internal static ListFlowOperationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListFlowOperationsRequestMarshaller Instance => _instance;
    }
}
