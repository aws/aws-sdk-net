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
    /// MessageConfiguration Marshaller
    /// </summary>       
    public class MessageConfigurationMarshaller : IRequestMarshaller<MessageConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MessageConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetADMMessage())
            {
                context.Writer.WritePropertyName("ADMMessage");
                context.Writer.WriteObjectStart();

                var marshaller = MessageMarshaller.Instance;
                marshaller.Marshall(requestObject.ADMMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAPNSMessage())
            {
                context.Writer.WritePropertyName("APNSMessage");
                context.Writer.WriteObjectStart();

                var marshaller = MessageMarshaller.Instance;
                marshaller.Marshall(requestObject.APNSMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBaiduMessage())
            {
                context.Writer.WritePropertyName("BaiduMessage");
                context.Writer.WriteObjectStart();

                var marshaller = MessageMarshaller.Instance;
                marshaller.Marshall(requestObject.BaiduMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomMessage())
            {
                context.Writer.WritePropertyName("CustomMessage");
                context.Writer.WriteObjectStart();

                var marshaller = CampaignCustomMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultMessage())
            {
                context.Writer.WritePropertyName("DefaultMessage");
                context.Writer.WriteObjectStart();

                var marshaller = MessageMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmailMessage())
            {
                context.Writer.WritePropertyName("EmailMessage");
                context.Writer.WriteObjectStart();

                var marshaller = CampaignEmailMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.EmailMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGCMMessage())
            {
                context.Writer.WritePropertyName("GCMMessage");
                context.Writer.WriteObjectStart();

                var marshaller = MessageMarshaller.Instance;
                marshaller.Marshall(requestObject.GCMMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSMSMessage())
            {
                context.Writer.WritePropertyName("SMSMessage");
                context.Writer.WriteObjectStart();

                var marshaller = CampaignSmsMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.SMSMessage, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static MessageConfigurationMarshaller Instance = new MessageConfigurationMarshaller();

    }
}