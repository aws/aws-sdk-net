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
    /// Response Unmarshaller for GameServer Object
    /// </summary>
    public partial class GameServerUnmarshaller : ICborUnmarshaller<GameServer, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GameServer Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GameServer();
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
                    case "ClaimStatus":
                        context.AddPathSegment("ClaimStatus");
                        unmarshalledObject.ClaimStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConnectionInfo":
                        context.AddPathSegment("ConnectionInfo");
                        unmarshalledObject.ConnectionInfo = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerData":
                        context.AddPathSegment("GameServerData");
                        unmarshalledObject.GameServerData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerGroupArn":
                        context.AddPathSegment("GameServerGroupArn");
                        unmarshalledObject.GameServerGroupArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerGroupName":
                        context.AddPathSegment("GameServerGroupName");
                        unmarshalledObject.GameServerGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerId":
                        context.AddPathSegment("GameServerId");
                        unmarshalledObject.GameServerId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceId":
                        context.AddPathSegment("InstanceId");
                        unmarshalledObject.InstanceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastClaimTime":
                        context.AddPathSegment("LastClaimTime");
                        unmarshalledObject.LastClaimTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastHealthCheckTime":
                        context.AddPathSegment("LastHealthCheckTime");
                        unmarshalledObject.LastHealthCheckTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistrationTime":
                        context.AddPathSegment("RegistrationTime");
                        unmarshalledObject.RegistrationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UtilizationStatus":
                        context.AddPathSegment("UtilizationStatus");
                        unmarshalledObject.UtilizationStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static GameServerUnmarshaller _instance = new GameServerUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GameServerUnmarshaller Instance => _instance;
    }
}
