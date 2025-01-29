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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lex.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DialogAction Marshaller
    /// </summary>
    public class DialogActionMarshaller : IRequestMarshaller<DialogAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DialogAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFulfillmentState())
            {
                context.Writer.WritePropertyName("fulfillmentState");
                context.Writer.WriteStringValue(requestObject.FulfillmentState);
            }

            if(requestObject.IsSetIntentName())
            {
                context.Writer.WritePropertyName("intentName");
                context.Writer.WriteStringValue(requestObject.IntentName);
            }

            if(requestObject.IsSetMessage())
            {
                context.Writer.WritePropertyName("message");
                context.Writer.WriteStringValue(requestObject.Message);
            }

            if(requestObject.IsSetMessageFormat())
            {
                context.Writer.WritePropertyName("messageFormat");
                context.Writer.WriteStringValue(requestObject.MessageFormat);
            }

            if(requestObject.IsSetSlots())
            {
                context.Writer.WritePropertyName("slots");
                context.Writer.WriteStartObject();
                foreach (var requestObjectSlotsKvp in requestObject.Slots)
                {
                    context.Writer.WritePropertyName(requestObjectSlotsKvp.Key);
                    var requestObjectSlotsValue = requestObjectSlotsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectSlotsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlotToElicit())
            {
                context.Writer.WritePropertyName("slotToElicit");
                context.Writer.WriteStringValue(requestObject.SlotToElicit);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DialogActionMarshaller Instance = new DialogActionMarshaller();

    }
}