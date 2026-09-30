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
    /// InvokeActStep Request Marshaller
    /// </summary>
    public partial class InvokeActStepRequestMarshaller : IMarshaller<IRequest, InvokeActStepRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeActStepRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeActStepRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NovaAct");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-08-22";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetActId())
            {
                throw new AmazonNovaActException("Request object does not have required field ActId set");
            }
            request.AddPathResource("{actId}", StringUtils.FromString(publicRequest.ActId));

            if (!publicRequest.IsSetSessionId())
            {
                throw new AmazonNovaActException("Request object does not have required field SessionId set");
            }
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));

            if (!publicRequest.IsSetWorkflowDefinitionName())
            {
                throw new AmazonNovaActException("Request object does not have required field WorkflowDefinitionName set");
            }
            request.AddPathResource("{workflowDefinitionName}", StringUtils.FromString(publicRequest.WorkflowDefinitionName));

            if (!publicRequest.IsSetWorkflowRunId())
            {
                throw new AmazonNovaActException("Request object does not have required field WorkflowRunId set");
            }
            request.AddPathResource("{workflowRunId}", StringUtils.FromString(publicRequest.WorkflowRunId));

            request.ResourcePath = "/workflow-definitions/{workflowDefinitionName}/workflow-runs/{workflowRunId}/sessions/{sessionId}/acts/{actId}/invoke-step/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCallResults())
            {
                context.Writer.WritePropertyName("callResults");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCallResultsListValue in publicRequest.CallResults)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CallResultMarshaller.Instance;
                    marshaller.Marshall(publicRequestCallResultsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetPreviousStepId())
            {
                context.Writer.WritePropertyName("previousStepId");
                context.Writer.WriteStringValue(publicRequest.PreviousStepId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly InvokeActStepRequestMarshaller _instance = new();

        internal static InvokeActStepRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeActStepRequestMarshaller Instance => _instance;
    }
}
