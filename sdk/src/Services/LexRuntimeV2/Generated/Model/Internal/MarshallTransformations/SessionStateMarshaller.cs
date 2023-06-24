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
    /// SessionState Marshaller
    /// </summary>
    public class SessionStateMarshaller : IRequestMarshaller<SessionState, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SessionState requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActiveContexts())
            {
                context.Writer.WritePropertyName("activeContexts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActiveContextsListValue in requestObject.ActiveContexts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ActiveContextMarshaller.Instance;
                    marshaller.Marshall(requestObjectActiveContextsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDialogAction())
            {
                context.Writer.WritePropertyName("dialogAction");
                context.Writer.WriteObjectStart();

                var marshaller = DialogActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DialogAction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIntent())
            {
                context.Writer.WritePropertyName("intent");
                context.Writer.WriteObjectStart();

                var marshaller = IntentMarshaller.Instance;
                marshaller.Marshall(requestObject.Intent, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOriginatingRequestId())
            {
                context.Writer.WritePropertyName("originatingRequestId");
                context.Writer.Write(requestObject.OriginatingRequestId);
            }

            if(requestObject.IsSetRuntimeHints())
            {
                context.Writer.WritePropertyName("runtimeHints");
                context.Writer.WriteObjectStart();

                var marshaller = RuntimeHintsMarshaller.Instance;
                marshaller.Marshall(requestObject.RuntimeHints, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSessionAttributes())
            {
                context.Writer.WritePropertyName("sessionAttributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSessionAttributesKvp in requestObject.SessionAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectSessionAttributesKvp.Key);
                    var requestObjectSessionAttributesValue = requestObjectSessionAttributesKvp.Value;

                        context.Writer.Write(requestObjectSessionAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SessionStateMarshaller Instance = new SessionStateMarshaller();

    }
}