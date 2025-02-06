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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TextGenerationJobConfig Marshaller
    /// </summary>
    public class TextGenerationJobConfigMarshaller : IRequestMarshaller<TextGenerationJobConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TextGenerationJobConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBaseModelName())
            {
                context.Writer.WritePropertyName("BaseModelName");
                context.Writer.WriteStringValue(requestObject.BaseModelName);
            }

            if(requestObject.IsSetCompletionCriteria())
            {
                context.Writer.WritePropertyName("CompletionCriteria");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLJobCompletionCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.CompletionCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModelAccessConfig())
            {
                context.Writer.WritePropertyName("ModelAccessConfig");
                context.Writer.WriteStartObject();

                var marshaller = ModelAccessConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelAccessConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextGenerationHyperParameters())
            {
                context.Writer.WritePropertyName("TextGenerationHyperParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTextGenerationHyperParametersKvp in requestObject.TextGenerationHyperParameters)
                {
                    context.Writer.WritePropertyName(requestObjectTextGenerationHyperParametersKvp.Key);
                    var requestObjectTextGenerationHyperParametersValue = requestObjectTextGenerationHyperParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTextGenerationHyperParametersValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TextGenerationJobConfigMarshaller Instance = new TextGenerationJobConfigMarshaller();

    }
}