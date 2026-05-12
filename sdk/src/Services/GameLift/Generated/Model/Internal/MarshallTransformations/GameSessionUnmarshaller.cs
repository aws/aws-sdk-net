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
    /// Response Unmarshaller for GameSession Object
    /// </summary>  
    public class GameSessionUnmarshaller : ICborUnmarshaller<GameSession, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GameSession Unmarshall(CborUnmarshallerContext context)
        {
            GameSession unmarshalledObject = new GameSession();
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
                    case "ComputeName":
                        {
                            context.AddPathSegment("ComputeName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComputeName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatorId":
                        {
                            context.AddPathSegment("CreatorId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CreatorId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CurrentPlayerSessionCount":
                        {
                            context.AddPathSegment("CurrentPlayerSessionCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.CurrentPlayerSessionCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DnsName":
                        {
                            context.AddPathSegment("DnsName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetArn":
                        {
                            context.AddPathSegment("FleetArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetId":
                        {
                            context.AddPathSegment("FleetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetId = unmarshaller.Unmarshall(context);
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
                    case "IpAddress":
                        {
                            context.AddPathSegment("IpAddress");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Location":
                        {
                            context.AddPathSegment("Location");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Location = unmarshaller.Unmarshall(context);
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
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
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
                    case "PlayerSessionCreationPolicy":
                        {
                            context.AddPathSegment("PlayerSessionCreationPolicy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlayerSessionCreationPolicy = unmarshaller.Unmarshall(context);
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
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatusReason":
                        {
                            context.AddPathSegment("StatusReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TerminationTime":
                        {
                            context.AddPathSegment("TerminationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.TerminationTime = unmarshaller.Unmarshall(context);
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


        private static GameSessionUnmarshaller _instance = new GameSessionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GameSessionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}