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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexRuntimeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuntimeHintDetails Marshaller
    /// </summary>
    public class RuntimeHintDetailsMarshaller : IRequestMarshaller<RuntimeHintDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuntimeHintDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRuntimeHintValues())
            {
                context.Writer.WritePropertyName("runtimeHintValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRuntimeHintValuesListValue in requestObject.RuntimeHintValues)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RuntimeHintValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectRuntimeHintValuesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubSlotHints())
            {
                context.Writer.WritePropertyName("subSlotHints");
                context.Writer.WriteStartObject();
                foreach (var requestObjectSubSlotHintsKvp in requestObject.SubSlotHints)
                {
                    context.Writer.WritePropertyName(requestObjectSubSlotHintsKvp.Key);
                    var requestObjectSubSlotHintsValue = requestObjectSubSlotHintsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = RuntimeHintDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubSlotHintsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuntimeHintDetailsMarshaller Instance = new RuntimeHintDetailsMarshaller();

    }
}