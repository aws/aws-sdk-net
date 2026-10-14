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

using Amazon.PCS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateQueue Request Marshaller
    /// </summary>
    public partial class UpdateQueueRequestMarshaller : IMarshaller<IRequest, UpdateQueueRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateQueueRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PCS");
            string target = "AWSParallelComputingService.UpdateQueue";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-02-10";
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
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                context.Writer.WritePropertyName("clusterIdentifier");
                context.Writer.WriteStringValue(publicRequest.ClusterIdentifier);
            }
            if (publicRequest.IsSetComputeNodeGroupConfigurations())
            {
                context.Writer.WritePropertyName("computeNodeGroupConfigurations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestComputeNodeGroupConfigurationsListValue in publicRequest.ComputeNodeGroupConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComputeNodeGroupConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestComputeNodeGroupConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetQueueIdentifier())
            {
                context.Writer.WritePropertyName("queueIdentifier");
                context.Writer.WriteStringValue(publicRequest.QueueIdentifier);
            }
            if (publicRequest.IsSetSlurmConfiguration())
            {
                context.Writer.WritePropertyName("slurmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = UpdateQueueSlurmConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.SlurmConfiguration, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateQueueRequestMarshaller _instance = new();

        internal static UpdateQueueRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateQueueRequestMarshaller Instance => _instance;
    }
}
