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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GameSessionQueue Object
    /// </summary>  
    public class GameSessionQueueUnmarshaller : IJsonUnmarshaller<GameSessionQueue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GameSessionQueue Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GameSessionQueue unmarshalledObject = new GameSessionQueue();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CustomEventData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomEventData = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Destinations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<GameSessionQueueDestination, GameSessionQueueDestinationUnmarshaller>(GameSessionQueueDestinationUnmarshaller.Instance);
                    unmarshalledObject.Destinations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FilterConfiguration", targetDepth))
                {
                    var unmarshaller = FilterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FilterConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GameSessionQueueArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionQueueArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotificationTarget", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotificationTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlayerLatencyPolicies", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PlayerLatencyPolicy, PlayerLatencyPolicyUnmarshaller>(PlayerLatencyPolicyUnmarshaller.Instance);
                    unmarshalledObject.PlayerLatencyPolicies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PriorityConfiguration", targetDepth))
                {
                    var unmarshaller = PriorityConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PriorityConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeoutInSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutInSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GameSessionQueueUnmarshaller _instance = new GameSessionQueueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GameSessionQueueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}