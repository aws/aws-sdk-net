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

using Amazon.CodeGuruProfiler.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProfilingGroup Request Marshaller
    /// </summary>
    public partial class CreateProfilingGroupRequestMarshaller : IMarshaller<IRequest, CreateProfilingGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProfilingGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateProfilingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("clientToken", Guid.NewGuid().ToString());
            }

            request.ResourcePath = "/profilingGroups";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAgentOrchestrationConfig())
            {
                context.Writer.WritePropertyName("agentOrchestrationConfig");
                context.Writer.WriteStartObject();

                var marshaller = AgentOrchestrationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AgentOrchestrationConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetComputePlatform())
            {
                context.Writer.WritePropertyName("computePlatform");
                context.Writer.WriteStringValue(publicRequest.ComputePlatform);
            }
            if (publicRequest.IsSetProfilingGroupName())
            {
                context.Writer.WritePropertyName("profilingGroupName");
                context.Writer.WriteStringValue(publicRequest.ProfilingGroupName);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly CreateProfilingGroupRequestMarshaller _instance = new();

        internal static CreateProfilingGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateProfilingGroupRequestMarshaller Instance => _instance;
    }
}
