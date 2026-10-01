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

using Amazon.NovaAct.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NovaAct.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkflowRun Request Marshaller
    /// </summary>
    public partial class CreateWorkflowRunRequestMarshaller : IMarshaller<IRequest, CreateWorkflowRunRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkflowRunRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateWorkflowRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NovaAct");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-08-22";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetWorkflowDefinitionName())
            {
                throw new AmazonNovaActException("Request object does not have required field WorkflowDefinitionName set");
            }
            request.AddPathResource("{workflowDefinitionName}", StringUtils.FromString(publicRequest.WorkflowDefinitionName));

            request.ResourcePath = "/workflow-definitions/{workflowDefinitionName}/workflow-runs";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetClientInfo())
            {
                context.Writer.WritePropertyName("clientInfo");
                context.Writer.WriteStartObject();

                var marshaller = ClientInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.ClientInfo, context);

                context.Writer.WriteEndObject();
            }
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
            if (publicRequest.IsSetLogGroupName())
            {
                context.Writer.WritePropertyName("logGroupName");
                context.Writer.WriteStringValue(publicRequest.LogGroupName);
            }
            if (publicRequest.IsSetModelId())
            {
                context.Writer.WritePropertyName("modelId");
                context.Writer.WriteStringValue(publicRequest.ModelId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateWorkflowRunRequestMarshaller _instance = new();

        internal static CreateWorkflowRunRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateWorkflowRunRequestMarshaller Instance => _instance;
    }
}
