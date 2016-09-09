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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotificationConfig Marshaller
    /// </summary>       
    public class NotificationConfigMarshaller : IRequestMarshaller<NotificationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NotificationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetNotificationArn())
            {
                context.Writer.WritePropertyName("NotificationArn");
                context.Writer.Write(requestObject.NotificationArn);
            }

            if(requestObject.IsSetNotificationEvents())
            {
                context.Writer.WritePropertyName("NotificationEvents");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotificationEventsListValue in requestObject.NotificationEvents)
                {
                        context.Writer.Write(requestObjectNotificationEventsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNotificationType())
            {
                context.Writer.WritePropertyName("NotificationType");
                context.Writer.Write(requestObject.NotificationType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static NotificationConfigMarshaller Instance = new NotificationConfigMarshaller();

    }
}