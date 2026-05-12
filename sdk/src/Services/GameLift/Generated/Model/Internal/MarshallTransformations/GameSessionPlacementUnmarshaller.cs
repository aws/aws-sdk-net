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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GameSessionPlacement Object
    /// </summary>  
    public class GameSessionPlacementUnmarshaller : ICborUnmarshaller<GameSessionPlacement, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GameSessionPlacement Unmarshall(CborUnmarshallerContext context)
        {
            GameSessionPlacement unmarshalledObject = new GameSessionPlacement();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "DnsName":
                        {
                            context.AddPathSegment("DnsName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameProperties":
                        {
                            context.AddPathSegment("GameProperties");
                            var unmarshaller = new CborListUnmarshaller<GameProperty, GamePropertyUnmarshaller>(GamePropertyUnmarshaller.Instance);
                            unmarshalledObject.GameProperties = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionArn":
                        {
                            context.AddPathSegment("GameSessionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionData":
                        {
                            context.AddPathSegment("GameSessionData");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionId":
                        {
                            context.AddPathSegment("GameSessionId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionName":
                        {
                            context.AddPathSegment("GameSessionName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionQueueName":
                        {
                            context.AddPathSegment("GameSessionQueueName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionQueueName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionRegion":
                        {
                            context.AddPathSegment("GameSessionRegion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionRegion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IpAddress":
                        {
                            context.AddPathSegment("IpAddress");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MatchmakerData":
                        {
                            context.AddPathSegment("MatchmakerData");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MatchmakerData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaximumPlayerSessionCount":
                        {
                            context.AddPathSegment("MaximumPlayerSessionCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MaximumPlayerSessionCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlacedPlayerSessions":
                        {
                            context.AddPathSegment("PlacedPlayerSessions");
                            var unmarshaller = new CborListUnmarshaller<PlacedPlayerSession, PlacedPlayerSessionUnmarshaller>(PlacedPlayerSessionUnmarshaller.Instance);
                            unmarshalledObject.PlacedPlayerSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlacementId":
                        {
                            context.AddPathSegment("PlacementId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlacementId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlayerGatewayStatus":
                        {
                            context.AddPathSegment("PlayerGatewayStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlayerGatewayStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlayerLatencies":
                        {
                            context.AddPathSegment("PlayerLatencies");
                            var unmarshaller = new CborListUnmarshaller<PlayerLatency, PlayerLatencyUnmarshaller>(PlayerLatencyUnmarshaller.Instance);
                            unmarshalledObject.PlayerLatencies = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Port":
                        {
                            context.AddPathSegment("Port");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PriorityConfigurationOverride":
                        {
                            context.AddPathSegment("PriorityConfigurationOverride");
                            var unmarshaller = PriorityConfigurationOverrideUnmarshaller.Instance;
                            unmarshalledObject.PriorityConfigurationOverride = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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