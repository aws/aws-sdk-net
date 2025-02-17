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
    /// AIAgentConfiguration Marshaller
    /// </summary>
    public class AIAgentConfigurationMarshaller : IRequestMarshaller<AIAgentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AIAgentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnswerRecommendationAIAgentConfiguration())
            {
                context.Writer.WritePropertyName("answerRecommendationAIAgentConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AnswerRecommendationAIAgentConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AnswerRecommendationAIAgentConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetManualSearchAIAgentConfiguration())
            {
                context.Writer.WritePropertyName("manualSearchAIAgentConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ManualSearchAIAgentConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ManualSearchAIAgentConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSelfServiceAIAgentConfiguration())
            {
                context.Writer.WritePropertyName("selfServiceAIAgentConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SelfServiceAIAgentConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SelfServiceAIAgentConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AIAgentConfigurationMarshaller Instance = new AIAgentConfigurationMarshaller();

    }
}