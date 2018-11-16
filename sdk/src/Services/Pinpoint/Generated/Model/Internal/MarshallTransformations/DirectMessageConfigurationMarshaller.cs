/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DirectMessageConfiguration Marshaller
    /// </summary>       
    public class DirectMessageConfigurationMarshaller : IRequestMarshaller<DirectMessageConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DirectMessageConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetADMMessage())
            {
                context.Writer.WritePropertyName("ADMMessage");
                context.Writer.WriteObjectStart();

                var marshaller = ADMMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.ADMMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAPNSMessage())
            {
                context.Writer.WritePropertyName("APNSMessage");
                context.Writer.WriteObjectStart();

                var marshaller = APNSMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.APNSMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBaiduMessage())
            {
                context.Writer.WritePropertyName("BaiduMessage");
                context.Writer.WriteObjectStart();

                var marshaller = BaiduMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.BaiduMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultMessage())
            {
                context.Writer.WritePropertyName("DefaultMessage");
                context.Writer.WriteObjectStart();

                var marshaller = DefaultMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultPushNotificationMessage())
            {
                context.Writer.WritePropertyName("DefaultPushNotificationMessage");
                context.Writer.WriteObjectStart();

                var marshaller = DefaultPushNotificationMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultPushNotificationMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmailMessage())
            {
                context.Writer.WritePropertyName("EmailMessage");
                context.Writer.WriteObjectStart();

                var marshaller = EmailMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.EmailMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGCMMessage())
            {
                context.Writer.WritePropertyName("GCMMessage");
                context.Writer.WriteObjectStart();

                var marshaller = GCMMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.GCMMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSMSMessage())
            {
                context.Writer.WritePropertyName("SMSMessage");
                context.Writer.WriteObjectStart();

                var marshaller = SMSMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.SMSMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVoiceMessage())
            {
                context.Writer.WritePropertyName("VoiceMessage");
                context.Writer.WriteObjectStart();

                var marshaller = VoiceMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.VoiceMessage, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DirectMessageConfigurationMarshaller Instance = new DirectMessageConfigurationMarshaller();

    }
}