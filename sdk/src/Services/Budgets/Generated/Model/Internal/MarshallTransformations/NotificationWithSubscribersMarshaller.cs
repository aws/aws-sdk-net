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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotificationWithSubscribers Marshaller
    /// </summary>
    public class NotificationWithSubscribersMarshaller : IRequestMarshaller<NotificationWithSubscribers, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NotificationWithSubscribers requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetNotification())
            {
                context.Writer.WritePropertyName("Notification");
                context.Writer.WriteStartObject();

                var marshaller = NotificationMarshaller.Instance;
                marshaller.Marshall(requestObject.Notification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubscribers())
            {
                context.Writer.WritePropertyName("Subscribers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubscribersListValue in requestObject.Subscribers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SubscriberMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubscribersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NotificationWithSubscribersMarshaller Instance = new NotificationWithSubscribersMarshaller();

    }
}