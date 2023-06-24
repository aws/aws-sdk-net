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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCatalyst.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EventLogEntry Object
    /// </summary>  
    public class EventLogEntryUnmarshaller : IUnmarshaller<EventLogEntry, XmlUnmarshallerContext>, IUnmarshaller<EventLogEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EventLogEntry IUnmarshaller<EventLogEntry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EventLogEntry Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EventLogEntry unmarshalledObject = new EventLogEntry();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("errorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventCategory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventCategory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EventTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("operationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectInformation", targetDepth))
                {
                    var unmarshaller = ProjectInformationUnmarshaller.Instance;
                    unmarshalledObject.ProjectInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestPayload", targetDepth))
                {
                    var unmarshaller = EventPayloadUnmarshaller.Instance;
                    unmarshalledObject.RequestPayload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("responsePayload", targetDepth))
                {
                    var unmarshaller = EventPayloadUnmarshaller.Instance;
                    unmarshalledObject.ResponsePayload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userAgent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserAgent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userIdentity", targetDepth))
                {
                    var unmarshaller = UserIdentityUnmarshaller.Instance;
                    unmarshalledObject.UserIdentity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EventLogEntryUnmarshaller _instance = new EventLogEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventLogEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}