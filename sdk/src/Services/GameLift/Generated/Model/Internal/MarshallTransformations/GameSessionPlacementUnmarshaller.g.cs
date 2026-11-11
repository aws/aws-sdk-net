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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.GameLift.Model;
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
    public partial class GameSessionPlacementUnmarshaller : ICborUnmarshaller<GameSessionPlacement, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GameSessionPlacement Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GameSessionPlacement();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "DnsName":
                        context.AddPathSegment("DnsName");
                        unmarshalledObject.DnsName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameProperties":
                        context.AddPathSegment("GameProperties");
                        unmarshalledObject.GameProperties = new CborListUnmarshaller<GameProperty, GamePropertyUnmarshaller>(GamePropertyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionArn":
                        context.AddPathSegment("GameSessionArn");
                        unmarshalledObject.GameSessionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionData":
                        context.AddPathSegment("GameSessionData");
                        unmarshalledObject.GameSessionData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionId":
                        context.AddPathSegment("GameSessionId");
                        unmarshalledObject.GameSessionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionName":
                        context.AddPathSegment("GameSessionName");
                        unmarshalledObject.GameSessionName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionQueueName":
                        context.AddPathSegment("GameSessionQueueName");
                        unmarshalledObject.GameSessionQueueName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionRegion":
                        context.AddPathSegment("GameSessionRegion");
                        unmarshalledObject.GameSessionRegion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IpAddress":
                        context.AddPathSegment("IpAddress");
                        unmarshalledObject.IpAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MatchmakerData":
                        context.AddPathSegment("MatchmakerData");
                        unmarshalledObject.MatchmakerData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaximumPlayerSessionCount":
                        context.AddPathSegment("MaximumPlayerSessionCount");
                        unmarshalledObject.MaximumPlayerSessionCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlacedPlayerSessions":
                        context.AddPathSegment("PlacedPlayerSessions");
                        unmarshalledObject.PlacedPlayerSessions = new CborListUnmarshaller<PlacedPlayerSession, PlacedPlayerSessionUnmarshaller>(PlacedPlayerSessionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlacementId":
                        context.AddPathSegment("PlacementId");
                        unmarshalledObject.PlacementId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlayerGatewayStatus":
                        context.AddPathSegment("PlayerGatewayStatus");
                        unmarshalledObject.PlayerGatewayStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlayerLatencies":
                        context.AddPathSegment("PlayerLatencies");
                        unmarshalledObject.PlayerLatencies = new CborListUnmarshaller<PlayerLatency, PlayerLatencyUnmarshaller>(PlayerLatencyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Port":
                        context.AddPathSegment("Port");
                        unmarshalledObject.Port = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PriorityConfigurationOverride":
                        context.AddPathSegment("PriorityConfigurationOverride");
                        unmarshalledObject.PriorityConfigurationOverride = PriorityConfigurationOverrideUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static GameSessionPlacementUnmarshaller Instance => _instance;
    }
}
