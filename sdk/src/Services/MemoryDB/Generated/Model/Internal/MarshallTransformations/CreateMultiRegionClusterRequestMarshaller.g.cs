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

using Amazon.MemoryDB.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMultiRegionCluster Request Marshaller
    /// </summary>
    public partial class CreateMultiRegionClusterRequestMarshaller : IMarshaller<IRequest, CreateMultiRegionClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMultiRegionClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateMultiRegionClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AmazonMemoryDB/operation/CreateMultiRegionCluster";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEngine())
                {
                    context.Writer.WriteTextString("Engine");
                    context.Writer.WriteTextString(publicRequest.Engine);
                }
                if (publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WriteTextString("EngineVersion");
                    context.Writer.WriteTextString(publicRequest.EngineVersion);
                }
                if (publicRequest.IsSetMultiRegionClusterNameSuffix())
                {
                    context.Writer.WriteTextString("MultiRegionClusterNameSuffix");
                    context.Writer.WriteTextString(publicRequest.MultiRegionClusterNameSuffix);
                }
                if (publicRequest.IsSetMultiRegionParameterGroupName())
                {
                    context.Writer.WriteTextString("MultiRegionParameterGroupName");
                    context.Writer.WriteTextString(publicRequest.MultiRegionParameterGroupName);
                }
                if (publicRequest.IsSetNodeType())
                {
                    context.Writer.WriteTextString("NodeType");
                    context.Writer.WriteTextString(publicRequest.NodeType);
                }
                if (publicRequest.IsSetNumShards())
                {
                    context.Writer.WriteTextString("NumShards");
                    context.Writer.WriteInt32(publicRequest.NumShards.Value);
                }
                if (publicRequest.IsSetTLSEnabled())
                {
                    context.Writer.WriteTextString("TLSEnabled");
                    context.Writer.WriteBoolean(publicRequest.TLSEnabled.Value);
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

        private static readonly CreateMultiRegionClusterRequestMarshaller _instance = new();

        internal static CreateMultiRegionClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateMultiRegionClusterRequestMarshaller Instance => _instance;
    }
}
