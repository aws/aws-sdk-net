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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RcsSuggestedAction Marshaller
    /// </summary>
    public class RcsSuggestedActionMarshaller : IRequestMarshaller<RcsSuggestedAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RcsSuggestedAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreateCalendarEvent())
            {
                context.Writer.WritePropertyName("CreateCalendarEvent");
                context.Writer.WriteStartObject();

                var marshaller = RcsCreateCalendarEventActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateCalendarEvent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDialPhone())
            {
                context.Writer.WritePropertyName("DialPhone");
                context.Writer.WriteStartObject();

                var marshaller = RcsDialPhoneActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DialPhone, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOpenUrl())
            {
                context.Writer.WritePropertyName("OpenUrl");
                context.Writer.WriteStartObject();

                var marshaller = RcsOpenUrlActionMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenUrl, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReply())
            {
                context.Writer.WritePropertyName("Reply");
                context.Writer.WriteStartObject();

                var marshaller = RcsReplyActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Reply, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequestLocation())
            {
                context.Writer.WritePropertyName("RequestLocation");
                context.Writer.WriteStartObject();

                var marshaller = RcsRequestLocationActionMarshaller.Instance;
                marshaller.Marshall(requestObject.RequestLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetShowLocation())
            {
                context.Writer.WritePropertyName("ShowLocation");
                context.Writer.WriteStartObject();

                var marshaller = RcsShowLocationActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ShowLocation, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RcsSuggestedActionMarshaller Instance = new RcsSuggestedActionMarshaller();

    }
}