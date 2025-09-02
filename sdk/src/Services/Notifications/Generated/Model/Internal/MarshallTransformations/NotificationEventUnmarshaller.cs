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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Notifications.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Notifications.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NotificationEvent Object
    /// </summary>  
    public class NotificationEventUnmarshaller : IUnmarshaller<NotificationEvent, XmlUnmarshallerContext>, IUnmarshaller<NotificationEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NotificationEvent IUnmarshaller<NotificationEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NotificationEvent Unmarshall(JsonUnmarshallerContext context)
        {
            NotificationEvent unmarshalledObject = new NotificationEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aggregateNotificationEventArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AggregateNotificationEventArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aggregationEventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AggregationEventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aggregationSummary", targetDepth))
                {
                    var unmarshaller = AggregationSummaryUnmarshaller.Instance;
                    unmarshalledObject.AggregationSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("media", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MediaElement, MediaElementUnmarshaller>(MediaElementUnmarshaller.Instance);
                    unmarshalledObject.Media = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageComponents", targetDepth))
                {
                    var unmarshaller = MessageComponentsUnmarshaller.Instance;
                    unmarshalledObject.MessageComponents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("notificationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotificationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("organizationalUnitId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationalUnitId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceEventDetailUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceEventDetailUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceEventDetailUrlDisplayText", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceEventDetailUrlDisplayText = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceEventMetadata", targetDepth))
                {
                    var unmarshaller = SourceEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.SourceEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("textParts", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TextPartValue, StringUnmarshaller, TextPartValueUnmarshaller>(StringUnmarshaller.Instance, TextPartValueUnmarshaller.Instance);
                    unmarshalledObject.TextParts = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NotificationEventUnmarshaller _instance = new NotificationEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotificationEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}