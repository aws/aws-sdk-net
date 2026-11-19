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

using Amazon.ServiceDiscovery.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DiscoverInstances Request Marshaller
    /// </summary>
    public partial class DiscoverInstancesRequestMarshaller : IMarshaller<IRequest, DiscoverInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DiscoverInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DiscoverInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceDiscovery");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Route53AutoNaming_v20170314/operation/DiscoverInstances";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetHealthStatus())
                {
                    context.Writer.WriteTextString("HealthStatus");
                    context.Writer.WriteTextString(publicRequest.HealthStatus);
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("MaxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetNamespaceName())
                {
                    context.Writer.WriteTextString("NamespaceName");
                    context.Writer.WriteTextString(publicRequest.NamespaceName);
                }
                if (publicRequest.IsSetOptionalParameters())
                {
                    context.Writer.WriteTextString("OptionalParameters");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestOptionalParametersKvp in publicRequest.OptionalParameters)
                    {
                        context.Writer.WriteTextString(publicRequestOptionalParametersKvp.Key);
                        var publicRequestOptionalParametersValue = publicRequestOptionalParametersKvp.Value;
                        context.Writer.WriteTextString(publicRequestOptionalParametersValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetOwnerAccount())
                {
                    context.Writer.WriteTextString("OwnerAccount");
                    context.Writer.WriteTextString(publicRequest.OwnerAccount);
                }
                if (publicRequest.IsSetQueryParameters())
                {
                    context.Writer.WriteTextString("QueryParameters");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestQueryParametersKvp in publicRequest.QueryParameters)
                    {
                        context.Writer.WriteTextString(publicRequestQueryParametersKvp.Key);
                        var publicRequestQueryParametersValue = publicRequestQueryParametersKvp.Value;
                        context.Writer.WriteTextString(publicRequestQueryParametersValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetServiceName())
                {
                    context.Writer.WriteTextString("ServiceName");
                    context.Writer.WriteTextString(publicRequest.ServiceName);
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

            request.HostPrefix = $"data-";

            return request;
        }

        private static readonly DiscoverInstancesRequestMarshaller _instance = new();

        internal static DiscoverInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DiscoverInstancesRequestMarshaller Instance => _instance;
    }
}
