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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateChannelParameters Marshaller
    /// </summary>
    public class UpdateChannelParametersMarshaller : IRequestMarshaller<UpdateChannelParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateChannelParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetNotify())
            {
                context.Writer.WritePropertyName("notify");
                context.Writer.WriteStartObject();

                var marshaller = UpdateNotifyParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Notify, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetText())
            {
                context.Writer.WritePropertyName("text");
                context.Writer.WriteStartObject();

                var marshaller = UpdateTextParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Text, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVoice())
            {
                context.Writer.WritePropertyName("voice");
                context.Writer.WriteStartObject();

                var marshaller = UpdateVoiceParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Voice, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWhatsApp())
            {
                context.Writer.WritePropertyName("whatsApp");
                context.Writer.WriteStartObject();

                var marshaller = UpdateWhatsAppParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.WhatsApp, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateChannelParametersMarshaller Instance = new UpdateChannelParametersMarshaller();

    }
}