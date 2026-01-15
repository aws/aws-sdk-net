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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AIPromptInferenceConfiguration Marshaller
    /// </summary>
    public class AIPromptInferenceConfigurationMarshaller : IRequestMarshaller<AIPromptInferenceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AIPromptInferenceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxTokensToSample())
            {
                context.Writer.WritePropertyName("maxTokensToSample");
                context.Writer.Write(requestObject.MaxTokensToSample);
            }

            if(requestObject.IsSetTemperature())
            {
                context.Writer.WritePropertyName("temperature");
                if(StringUtils.IsSpecialFloatValue(requestObject.Temperature))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Temperature));
                }
                else
                {
                    context.Writer.Write(requestObject.Temperature);
                }
            }

            if(requestObject.IsSetTopK())
            {
                context.Writer.WritePropertyName("topK");
                context.Writer.Write(requestObject.TopK);
            }

            if(requestObject.IsSetTopP())
            {
                context.Writer.WritePropertyName("topP");
                if(StringUtils.IsSpecialFloatValue(requestObject.TopP))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.TopP));
                }
                else
                {
                    context.Writer.Write(requestObject.TopP);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AIPromptInferenceConfigurationMarshaller Instance = new AIPromptInferenceConfigurationMarshaller();

    }
}