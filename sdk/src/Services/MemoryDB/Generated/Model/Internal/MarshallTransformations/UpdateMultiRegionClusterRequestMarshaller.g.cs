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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.MemoryDB.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMultiRegionCluster Request Marshaller
    /// </summary>
    public partial class UpdateMultiRegionClusterRequestMarshaller : IMarshaller<IRequest, UpdateMultiRegionClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMultiRegionClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateMultiRegionClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            string target = "AmazonMemoryDB.UpdateMultiRegionCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(publicRequest.EngineVersion);
            }
            if (publicRequest.IsSetMultiRegionClusterName())
            {
                context.Writer.WritePropertyName("MultiRegionClusterName");
                context.Writer.WriteStringValue(publicRequest.MultiRegionClusterName);
            }
            if (publicRequest.IsSetMultiRegionParameterGroupName())
            {
                context.Writer.WritePropertyName("MultiRegionParameterGroupName");
                context.Writer.WriteStringValue(publicRequest.MultiRegionParameterGroupName);
            }
            if (publicRequest.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.WriteStringValue(publicRequest.NodeType);
            }
            if (publicRequest.IsSetShardConfiguration())
            {
                context.Writer.WritePropertyName("ShardConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ShardConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ShardConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetUpdateStrategy())
            {
                context.Writer.WritePropertyName("UpdateStrategy");
                context.Writer.WriteStringValue(publicRequest.UpdateStrategy);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateMultiRegionClusterRequestMarshaller _instance = new();

        internal static UpdateMultiRegionClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateMultiRegionClusterRequestMarshaller Instance => _instance;
    }
}
