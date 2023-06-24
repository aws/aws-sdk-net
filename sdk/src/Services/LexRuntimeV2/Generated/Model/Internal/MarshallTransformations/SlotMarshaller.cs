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
    /// Slot Marshaller
    /// </summary>
    public class SlotMarshaller : IRequestMarshaller<Slot, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Slot requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetShape())
            {
                context.Writer.WritePropertyName("shape");
                context.Writer.Write(requestObject.Shape);
            }

            if(requestObject.IsSetSubSlots())
            {
                context.Writer.WritePropertyName("subSlots");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSubSlotsKvp in requestObject.SubSlots)
                {
                    context.Writer.WritePropertyName(requestObjectSubSlotsKvp.Key);
                    var requestObjectSubSlotsValue = requestObjectSubSlotsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = SlotMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubSlotsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.WriteObjectStart();

                var marshaller = ValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetValues())
            {
                context.Writer.WritePropertyName("values");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectValuesListValue in requestObject.Values)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SlotMarshaller.Instance;
                    marshaller.Marshall(requestObjectValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SlotMarshaller Instance = new SlotMarshaller();

    }
}