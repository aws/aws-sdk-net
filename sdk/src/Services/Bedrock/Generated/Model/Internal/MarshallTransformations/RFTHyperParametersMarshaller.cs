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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RFTHyperParameters Marshaller
    /// </summary>
    public class RFTHyperParametersMarshaller : IRequestMarshaller<RFTHyperParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RFTHyperParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchSize())
            {
                context.Writer.WritePropertyName("batchSize");
                context.Writer.WriteNumberValue(requestObject.BatchSize.Value);
            }

            if(requestObject.IsSetEpochCount())
            {
                context.Writer.WritePropertyName("epochCount");
                context.Writer.WriteNumberValue(requestObject.EpochCount.Value);
            }

            if(requestObject.IsSetEvalInterval())
            {
                context.Writer.WritePropertyName("evalInterval");
                context.Writer.WriteNumberValue(requestObject.EvalInterval.Value);
            }

            if(requestObject.IsSetInferenceMaxTokens())
            {
                context.Writer.WritePropertyName("inferenceMaxTokens");
                context.Writer.WriteNumberValue(requestObject.InferenceMaxTokens.Value);
            }

            if(requestObject.IsSetLearningRate())
            {
                context.Writer.WritePropertyName("learningRate");
                if(StringUtils.IsSpecialFloatValue(requestObject.LearningRate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.LearningRate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LearningRate.Value);
                }
            }

            if(requestObject.IsSetMaxPromptLength())
            {
                context.Writer.WritePropertyName("maxPromptLength");
                context.Writer.WriteNumberValue(requestObject.MaxPromptLength.Value);
            }

            if(requestObject.IsSetReasoningEffort())
            {
                context.Writer.WritePropertyName("reasoningEffort");
                context.Writer.WriteStringValue(requestObject.ReasoningEffort);
            }

            if(requestObject.IsSetTrainingSamplePerPrompt())
            {
                context.Writer.WritePropertyName("trainingSamplePerPrompt");
                context.Writer.WriteNumberValue(requestObject.TrainingSamplePerPrompt.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RFTHyperParametersMarshaller Instance = new RFTHyperParametersMarshaller();

    }
}