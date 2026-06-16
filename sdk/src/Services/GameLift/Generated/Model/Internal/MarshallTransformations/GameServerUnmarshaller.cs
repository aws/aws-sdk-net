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
    /// Response Unmarshaller for GameServer Object
    /// </summary>  
    public class GameServerUnmarshaller : ICborUnmarshaller<GameServer, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GameServer Unmarshall(CborUnmarshallerContext context)
        {
            GameServer unmarshalledObject = new GameServer();
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
                    case "ClaimStatus":
                        {
                            context.AddPathSegment("ClaimStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ClaimStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ConnectionInfo":
                        {
                            context.AddPathSegment("ConnectionInfo");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ConnectionInfo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerData":
                        {
                            context.AddPathSegment("GameServerData");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerGroupArn":
                        {
                            context.AddPathSegment("GameServerGroupArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerGroupArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerGroupName":
                        {
                            context.AddPathSegment("GameServerGroupName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerGroupName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerId":
                        {
                            context.AddPathSegment("GameServerId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceId":
                        {
                            context.AddPathSegment("InstanceId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastClaimTime":
                        {
                            context.AddPathSegment("LastClaimTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastClaimTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastHealthCheckTime":
                        {
                            context.AddPathSegment("LastHealthCheckTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastHealthCheckTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RegistrationTime":
                        {
                            context.AddPathSegment("RegistrationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.RegistrationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UtilizationStatus":
                        {
                            context.AddPathSegment("UtilizationStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UtilizationStatus = unmarshaller.Unmarshall(context);
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


        private static GameServerUnmarshaller _instance = new GameServerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GameServerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}