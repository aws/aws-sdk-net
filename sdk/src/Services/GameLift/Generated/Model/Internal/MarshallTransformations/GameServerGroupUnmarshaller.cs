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
    /// Response Unmarshaller for GameServerGroup Object
    /// </summary>  
    public class GameServerGroupUnmarshaller : ICborUnmarshaller<GameServerGroup, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GameServerGroup Unmarshall(CborUnmarshallerContext context)
        {
            GameServerGroup unmarshalledObject = new GameServerGroup();
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
                    case "AutoScalingGroupArn":
                        {
                            context.AddPathSegment("AutoScalingGroupArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AutoScalingGroupArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BalancingStrategy":
                        {
                            context.AddPathSegment("BalancingStrategy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BalancingStrategy = unmarshaller.Unmarshall(context);
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
                    case "GameServerProtectionPolicy":
                        {
                            context.AddPathSegment("GameServerProtectionPolicy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerProtectionPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceDefinitions":
                        {
                            context.AddPathSegment("InstanceDefinitions");
                            var unmarshaller = new CborListUnmarshaller<InstanceDefinition, InstanceDefinitionUnmarshaller>(InstanceDefinitionUnmarshaller.Instance);
                            unmarshalledObject.InstanceDefinitions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastUpdatedTime":
                        {
                            context.AddPathSegment("LastUpdatedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RoleArn":
                        {
                            context.AddPathSegment("RoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
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
                    case "SuspendedActions":
                        {
                            context.AddPathSegment("SuspendedActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.SuspendedActions = unmarshaller.Unmarshall(context);
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


        private static GameServerGroupUnmarshaller _instance = new GameServerGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GameServerGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}