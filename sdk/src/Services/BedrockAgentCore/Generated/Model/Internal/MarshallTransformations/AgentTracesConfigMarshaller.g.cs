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

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AgentTracesConfig Marshaller
    /// </summary>
    public partial class AgentTracesConfigMarshaller : IRequestMarshaller<AgentTracesConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AgentTracesConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBatchEvaluation())
            {
                context.Writer.WritePropertyName("batchEvaluation");
                context.Writer.WriteStartObject();

                var marshaller = BatchEvaluationTraceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BatchEvaluation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetCloudwatchLogs())
            {
                context.Writer.WritePropertyName("cloudwatchLogs");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLogsTraceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchLogs, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetOnlineEvaluation())
            {
                context.Writer.WritePropertyName("onlineEvaluation");
                context.Writer.WriteStartObject();

                var marshaller = OnlineEvaluationTraceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OnlineEvaluation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSessionSpans())
            {
                context.Writer.WritePropertyName("sessionSpans");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSessionSpansListValue in requestObject.SessionSpans)
                {
                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObjectSessionSpansListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AgentTracesConfigMarshaller Instance = new AgentTracesConfigMarshaller();
    }
}
