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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChannelMessageCallback Marshaller
    /// </summary>
    public class ChannelMessageCallbackMarshaller : IRequestMarshaller<ChannelMessageCallback, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ChannelMessageCallback requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteStringValue(requestObject.Content);
            }

            if(requestObject.IsSetContentType())
            {
                context.Writer.WritePropertyName("ContentType");
                context.Writer.WriteStringValue(requestObject.ContentType);
            }

            if(requestObject.IsSetMessageAttributes())
            {
                context.Writer.WritePropertyName("MessageAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMessageAttributesKvp in requestObject.MessageAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectMessageAttributesKvp.Key);
                    var requestObjectMessageAttributesValue = requestObjectMessageAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = MessageAttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessageAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMessageId())
            {
                context.Writer.WritePropertyName("MessageId");
                context.Writer.WriteStringValue(requestObject.MessageId);
            }

            if(requestObject.IsSetMetadata())
            {
                context.Writer.WritePropertyName("Metadata");
                context.Writer.WriteStringValue(requestObject.Metadata);
            }

            if(requestObject.IsSetPushNotification())
            {
                context.Writer.WritePropertyName("PushNotification");
                context.Writer.WriteStartObject();

                var marshaller = PushNotificationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PushNotification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubChannelId())
            {
                context.Writer.WritePropertyName("SubChannelId");
                context.Writer.WriteStringValue(requestObject.SubChannelId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChannelMessageCallbackMarshaller Instance = new ChannelMessageCallbackMarshaller();

    }
}