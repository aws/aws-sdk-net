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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Fallback Marshaller
    /// </summary>
    public class FallbackMarshaller : IRequestMarshaller<Fallback, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Fallback requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCircuitBreaker())
            {
                context.Writer.WritePropertyName("circuitBreaker");
                context.Writer.WriteStartObject();

                var marshaller = CircuitBreakerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CircuitBreaker, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFirstByteTimeoutMilliseconds())
            {
                context.Writer.WritePropertyName("firstByteTimeoutMilliseconds");
                context.Writer.WriteNumberValue(requestObject.FirstByteTimeoutMilliseconds.Value);
            }

            if(requestObject.IsSetTargetFallback())
            {
                context.Writer.WritePropertyName("targetFallback");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetFallbackListValue in requestObject.TargetFallback)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FallbackTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetFallbackListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTriggerOn())
            {
                context.Writer.WritePropertyName("triggerOn");
                context.Writer.WriteStartObject();

                var marshaller = FallbackTriggersMarshaller.Instance;
                marshaller.Marshall(requestObject.TriggerOn, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FallbackMarshaller Instance = new FallbackMarshaller();

    }
}