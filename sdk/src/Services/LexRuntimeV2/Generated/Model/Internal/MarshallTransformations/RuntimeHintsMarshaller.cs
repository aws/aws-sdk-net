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
using ThirdParty.Json.LitJson;

namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuntimeHints Marshaller
    /// </summary>
    public class RuntimeHintsMarshaller : IRequestMarshaller<RuntimeHints, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuntimeHints requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetSlotHints())
            {
                context.Writer.WritePropertyName("slotHints");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSlotHintsKvp in requestObject.SlotHints)
                {
                    context.Writer.WritePropertyName(requestObjectSlotHintsKvp.Key);
                    var requestObjectSlotHintsValue = requestObjectSlotHintsKvp.Value;

                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectSlotHintsValueKvp in requestObjectSlotHintsValue)
                    {
                        context.Writer.WritePropertyName(requestObjectSlotHintsValueKvp.Key);
                        var requestObjectSlotHintsValueValue = requestObjectSlotHintsValueKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = RuntimeHintDetailsMarshaller.Instance;
                        marshaller.Marshall(requestObjectSlotHintsValueValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuntimeHintsMarshaller Instance = new RuntimeHintsMarshaller();

    }
}