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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HarnessHook Marshaller
    /// </summary>
    public partial class HarnessHookMarshaller : IRequestMarshaller<HarnessHook, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HarnessHook requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAfterInvocation())
            {
                context.Writer.WritePropertyName("afterInvocation");
                context.Writer.WriteStartObject();

                var marshaller = HarnessAfterInvocationHookMarshaller.Instance;
                marshaller.Marshall(requestObject.AfterInvocation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetAfterToolCall())
            {
                context.Writer.WritePropertyName("afterToolCall");
                context.Writer.WriteStartObject();

                var marshaller = HarnessAfterToolCallHookMarshaller.Instance;
                marshaller.Marshall(requestObject.AfterToolCall, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetBeforeInvocation())
            {
                context.Writer.WritePropertyName("beforeInvocation");
                context.Writer.WriteStartObject();

                var marshaller = HarnessBeforeInvocationHookMarshaller.Instance;
                marshaller.Marshall(requestObject.BeforeInvocation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetBeforeToolCall())
            {
                context.Writer.WritePropertyName("beforeToolCall");
                context.Writer.WriteStartObject();

                var marshaller = HarnessBeforeToolCallHookMarshaller.Instance;
                marshaller.Marshall(requestObject.BeforeToolCall, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HarnessHookMarshaller Instance = new HarnessHookMarshaller();
    }
}
