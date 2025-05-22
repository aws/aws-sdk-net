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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FlowNodeConfiguration Marshaller
    /// </summary>
    public class FlowNodeConfigurationMarshaller : IRequestMarshaller<FlowNodeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FlowNodeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAgent())
            {
                context.Writer.WritePropertyName("agent");
                context.Writer.WriteStartObject();

                var marshaller = AgentFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Agent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCollector())
            {
                context.Writer.WritePropertyName("collector");
                context.Writer.WriteStartObject();

                var marshaller = CollectorFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Collector, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCondition())
            {
                context.Writer.WritePropertyName("condition");
                context.Writer.WriteStartObject();

                var marshaller = ConditionFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Condition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInlineCode())
            {
                context.Writer.WritePropertyName("inlineCode");
                context.Writer.WriteStartObject();

                var marshaller = InlineCodeFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InlineCode, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStartObject();

                var marshaller = InputFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Input, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIterator())
            {
                context.Writer.WritePropertyName("iterator");
                context.Writer.WriteStartObject();

                var marshaller = IteratorFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Iterator, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKnowledgeBase())
            {
                context.Writer.WritePropertyName("knowledgeBase");
                context.Writer.WriteStartObject();

                var marshaller = KnowledgeBaseFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.KnowledgeBase, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambdaFunction())
            {
                context.Writer.WritePropertyName("lambdaFunction");
                context.Writer.WriteStartObject();

                var marshaller = LambdaFunctionFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaFunction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLex())
            {
                context.Writer.WritePropertyName("lex");
                context.Writer.WriteStartObject();

                var marshaller = LexFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Lex, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLoop())
            {
                context.Writer.WritePropertyName("loop");
                context.Writer.WriteStartObject();

                var marshaller = LoopFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Loop, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLoopController())
            {
                context.Writer.WritePropertyName("loopController");
                context.Writer.WriteStartObject();

                var marshaller = LoopControllerFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LoopController, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLoopInput())
            {
                context.Writer.WritePropertyName("loopInput");
                context.Writer.WriteStartObject();

                var marshaller = LoopInputFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LoopInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutput())
            {
                context.Writer.WritePropertyName("output");
                context.Writer.WriteStartObject();

                var marshaller = OutputFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Output, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrompt())
            {
                context.Writer.WritePropertyName("prompt");
                context.Writer.WriteStartObject();

                var marshaller = PromptFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Prompt, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetrieval())
            {
                context.Writer.WritePropertyName("retrieval");
                context.Writer.WriteStartObject();

                var marshaller = RetrievalFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Retrieval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStorage())
            {
                context.Writer.WritePropertyName("storage");
                context.Writer.WriteStartObject();

                var marshaller = StorageFlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Storage, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FlowNodeConfigurationMarshaller Instance = new FlowNodeConfigurationMarshaller();

    }
}