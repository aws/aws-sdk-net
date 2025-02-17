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
    /// OrchestrationConfiguration Marshaller
    /// </summary>
    public class OrchestrationConfigurationMarshaller : IRequestMarshaller<OrchestrationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OrchestrationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalModelRequestFields())
            {
                context.Writer.WritePropertyName("additionalModelRequestFields");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAdditionalModelRequestFieldsKvp in requestObject.AdditionalModelRequestFields)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalModelRequestFieldsKvp.Key);
                    var requestObjectAdditionalModelRequestFieldsValue = requestObjectAdditionalModelRequestFieldsKvp.Value;

                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObjectAdditionalModelRequestFieldsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInferenceConfig())
            {
                context.Writer.WritePropertyName("inferenceConfig");
                context.Writer.WriteObjectStart();

                var marshaller = InferenceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.InferenceConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPerformanceConfig())
            {
                context.Writer.WritePropertyName("performanceConfig");
                context.Writer.WriteObjectStart();

                var marshaller = PerformanceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PerformanceConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPromptTemplate())
            {
                context.Writer.WritePropertyName("promptTemplate");
                context.Writer.WriteObjectStart();

                var marshaller = PromptTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.PromptTemplate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQueryTransformationConfiguration())
            {
                context.Writer.WritePropertyName("queryTransformationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = QueryTransformationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryTransformationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OrchestrationConfigurationMarshaller Instance = new OrchestrationConfigurationMarshaller();

    }
}