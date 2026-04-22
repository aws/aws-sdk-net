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
    /// HarnessGeminiModelConfig Marshaller
    /// </summary>
    public class HarnessGeminiModelConfigMarshaller : IRequestMarshaller<HarnessGeminiModelConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HarnessGeminiModelConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiKeyArn())
            {
                context.Writer.WritePropertyName("apiKeyArn");
                context.Writer.WriteStringValue(requestObject.ApiKeyArn);
            }

            if(requestObject.IsSetMaxTokens())
            {
                context.Writer.WritePropertyName("maxTokens");
                context.Writer.WriteNumberValue(requestObject.MaxTokens.Value);
            }

            if(requestObject.IsSetModelId())
            {
                context.Writer.WritePropertyName("modelId");
                context.Writer.WriteStringValue(requestObject.ModelId);
            }

            if(requestObject.IsSetTemperature())
            {
                context.Writer.WritePropertyName("temperature");
                if(StringUtils.IsSpecialFloatValue(requestObject.Temperature.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Temperature.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Temperature.Value);
                }
            }

            if(requestObject.IsSetTopK())
            {
                context.Writer.WritePropertyName("topK");
                context.Writer.WriteNumberValue(requestObject.TopK.Value);
            }

            if(requestObject.IsSetTopP())
            {
                context.Writer.WritePropertyName("topP");
                if(StringUtils.IsSpecialFloatValue(requestObject.TopP.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.TopP.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TopP.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HarnessGeminiModelConfigMarshaller Instance = new HarnessGeminiModelConfigMarshaller();

    }
}