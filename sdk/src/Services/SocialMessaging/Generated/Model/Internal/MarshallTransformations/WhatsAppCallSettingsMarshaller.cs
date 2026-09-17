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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WhatsAppCallSettings Marshaller
    /// </summary>
    public class WhatsAppCallSettingsMarshaller : IRequestMarshaller<WhatsAppCallSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WhatsAppCallSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCallbackPermissionStatus())
            {
                context.Writer.WritePropertyName("callbackPermissionStatus");
                context.Writer.WriteStringValue(requestObject.CallbackPermissionStatus);
            }

            if(requestObject.IsSetCallEnabled())
            {
                context.Writer.WritePropertyName("callEnabled");
                context.Writer.WriteBooleanValue(requestObject.CallEnabled.Value);
            }

            if(requestObject.IsSetCallHours())
            {
                context.Writer.WritePropertyName("callHours");
                context.Writer.WriteStartObject();

                var marshaller = WhatsAppCallHoursMarshaller.Instance;
                marshaller.Marshall(requestObject.CallHours, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCallIconVisibility())
            {
                context.Writer.WritePropertyName("callIconVisibility");
                context.Writer.WriteStringValue(requestObject.CallIconVisibility);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WhatsAppCallSettingsMarshaller Instance = new WhatsAppCallSettingsMarshaller();

    }
}