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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HarnessModelConfiguration Marshaller
    /// </summary>
    public class HarnessModelConfigurationMarshaller : IRequestMarshaller<HarnessModelConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HarnessModelConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBedrockModelConfig())
            {
                context.Writer.WritePropertyName("bedrockModelConfig");
                context.Writer.WriteStartObject();

                var marshaller = HarnessBedrockModelConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BedrockModelConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGeminiModelConfig())
            {
                context.Writer.WritePropertyName("geminiModelConfig");
                context.Writer.WriteStartObject();

                var marshaller = HarnessGeminiModelConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.GeminiModelConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOpenAiModelConfig())
            {
                context.Writer.WritePropertyName("openAiModelConfig");
                context.Writer.WriteStartObject();

                var marshaller = HarnessOpenAiModelConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenAiModelConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HarnessModelConfigurationMarshaller Instance = new HarnessModelConfigurationMarshaller();

    }
}