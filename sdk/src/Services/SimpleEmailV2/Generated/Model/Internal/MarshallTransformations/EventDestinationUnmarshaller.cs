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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EventDestination Object
    /// </summary>  
    public class EventDestinationUnmarshaller : IUnmarshaller<EventDestination, XmlUnmarshallerContext>, IUnmarshaller<EventDestination, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EventDestination IUnmarshaller<EventDestination, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EventDestination Unmarshall(JsonUnmarshallerContext context)
        {
            EventDestination unmarshalledObject = new EventDestination();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchDestination", targetDepth))
                {
                    var unmarshaller = CloudWatchDestinationUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Enabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventBridgeDestination", targetDepth))
                {
                    var unmarshaller = EventBridgeDestinationUnmarshaller.Instance;
                    unmarshalledObject.EventBridgeDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisFirehoseDestination", targetDepth))
                {
                    var unmarshaller = KinesisFirehoseDestinationUnmarshaller.Instance;
                    unmarshalledObject.KinesisFirehoseDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MatchingEventTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MatchingEventTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PinpointDestination", targetDepth))
                {
                    var unmarshaller = PinpointDestinationUnmarshaller.Instance;
                    unmarshalledObject.PinpointDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnsDestination", targetDepth))
                {
                    var unmarshaller = SnsDestinationUnmarshaller.Instance;
                    unmarshalledObject.SnsDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EventDestinationUnmarshaller _instance = new EventDestinationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventDestinationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}