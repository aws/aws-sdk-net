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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TriggerConditionInput Marshaller
    /// </summary>
    public class TriggerConditionInputMarshaller : IRequestMarshaller<TriggerConditionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TriggerConditionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMessageBasedTrigger())
            {
                context.Writer.WritePropertyName("messageBasedTrigger");
                context.Writer.WriteObjectStart();

                var marshaller = MessageBasedTriggerInputMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageBasedTrigger, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeBasedTrigger())
            {
                context.Writer.WritePropertyName("timeBasedTrigger");
                context.Writer.WriteObjectStart();

                var marshaller = TimeBasedTriggerInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeBasedTrigger, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTokenBasedTrigger())
            {
                context.Writer.WritePropertyName("tokenBasedTrigger");
                context.Writer.WriteObjectStart();

                var marshaller = TokenBasedTriggerInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TokenBasedTrigger, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TriggerConditionInputMarshaller Instance = new TriggerConditionInputMarshaller();

    }
}