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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PromptConfiguration Marshaller
    /// </summary>
    public class PromptConfigurationMarshaller : IRequestMarshaller<PromptConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PromptConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBasePromptTemplate())
            {
                context.Writer.WritePropertyName("basePromptTemplate");
                context.Writer.Write(requestObject.BasePromptTemplate);
            }

            if(requestObject.IsSetInferenceConfiguration())
            {
                context.Writer.WritePropertyName("inferenceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = InferenceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InferenceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParserMode())
            {
                context.Writer.WritePropertyName("parserMode");
                context.Writer.Write(requestObject.ParserMode);
            }

            if(requestObject.IsSetPromptCreationMode())
            {
                context.Writer.WritePropertyName("promptCreationMode");
                context.Writer.Write(requestObject.PromptCreationMode);
            }

            if(requestObject.IsSetPromptState())
            {
                context.Writer.WritePropertyName("promptState");
                context.Writer.Write(requestObject.PromptState);
            }

            if(requestObject.IsSetPromptType())
            {
                context.Writer.WritePropertyName("promptType");
                context.Writer.Write(requestObject.PromptType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PromptConfigurationMarshaller Instance = new PromptConfigurationMarshaller();

    }
}