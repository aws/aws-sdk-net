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
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GameSessionPlacement Object
    /// </summary>  
    public class GameSessionPlacementUnmarshaller : IUnmarshaller<GameSessionPlacement, XmlUnmarshallerContext>, IUnmarshaller<GameSessionPlacement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GameSessionPlacement IUnmarshaller<GameSessionPlacement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GameSessionPlacement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GameSessionPlacement unmarshalledObject = new GameSessionPlacement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GameProperty, GamePropertyUnmarshaller>(GamePropertyUnmarshaller.Instance);
                    unmarshalledObject.GameProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionQueueName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionQueueName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameSessionRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MatchmakerData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MatchmakerData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumPlayerSessionCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumPlayerSessionCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlacedPlayerSessions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PlacedPlayerSession, PlacedPlayerSessionUnmarshaller>(PlacedPlayerSessionUnmarshaller.Instance);
                    unmarshalledObject.PlacedPlayerSessions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlacementId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlacementId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlayerLatencies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PlayerLatency, PlayerLatencyUnmarshaller>(PlayerLatencyUnmarshaller.Instance);
                    unmarshalledObject.PlayerLatencies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GameSessionPlacementUnmarshaller _instance = new GameSessionPlacementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GameSessionPlacementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}