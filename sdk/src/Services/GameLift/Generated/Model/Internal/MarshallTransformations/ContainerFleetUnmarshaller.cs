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
    /// Response Unmarshaller for ContainerFleet Object
    /// </summary>  
    public class ContainerFleetUnmarshaller : ICborUnmarshaller<ContainerFleet, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerFleet Unmarshall(CborUnmarshallerContext context)
        {
            ContainerFleet unmarshalledObject = new ContainerFleet();
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
                    case "BillingType":
                        {
                            context.AddPathSegment("BillingType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BillingType = unmarshaller.Unmarshall(context);
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
                    case "DeploymentDetails":
                        {
                            context.AddPathSegment("DeploymentDetails");
                            var unmarshaller = DeploymentDetailsUnmarshaller.Instance;
                            unmarshalledObject.DeploymentDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
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
                    case "FleetRoleArn":
                        {
                            context.AddPathSegment("FleetRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerContainerGroupDefinitionArn":
                        {
                            context.AddPathSegment("GameServerContainerGroupDefinitionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerContainerGroupDefinitionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerContainerGroupDefinitionName":
                        {
                            context.AddPathSegment("GameServerContainerGroupDefinitionName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerContainerGroupDefinitionName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerContainerGroupsPerInstance":
                        {
                            context.AddPathSegment("GameServerContainerGroupsPerInstance");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.GameServerContainerGroupsPerInstance = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionCreationLimitPolicy":
                        {
                            context.AddPathSegment("GameSessionCreationLimitPolicy");
                            var unmarshaller = GameSessionCreationLimitPolicyUnmarshaller.Instance;
                            unmarshalledObject.GameSessionCreationLimitPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceConnectionPortRange":
                        {
                            context.AddPathSegment("InstanceConnectionPortRange");
                            var unmarshaller = ConnectionPortRangeUnmarshaller.Instance;
                            unmarshalledObject.InstanceConnectionPortRange = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceInboundPermissions":
                        {
                            context.AddPathSegment("InstanceInboundPermissions");
                            var unmarshaller = new CborListUnmarshaller<IpPermission, IpPermissionUnmarshaller>(IpPermissionUnmarshaller.Instance);
                            unmarshalledObject.InstanceInboundPermissions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceType":
                        {
                            context.AddPathSegment("InstanceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LocationAttributes":
                        {
                            context.AddPathSegment("LocationAttributes");
                            var unmarshaller = new CborListUnmarshaller<ContainerFleetLocationAttributes, ContainerFleetLocationAttributesUnmarshaller>(ContainerFleetLocationAttributesUnmarshaller.Instance);
                            unmarshalledObject.LocationAttributes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogConfiguration":
                        {
                            context.AddPathSegment("LogConfiguration");
                            var unmarshaller = LogConfigurationUnmarshaller.Instance;
                            unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaximumGameServerContainerGroupsPerInstance":
                        {
                            context.AddPathSegment("MaximumGameServerContainerGroupsPerInstance");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MaximumGameServerContainerGroupsPerInstance = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricGroups":
                        {
                            context.AddPathSegment("MetricGroups");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.MetricGroups = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NewGameSessionProtectionPolicy":
                        {
                            context.AddPathSegment("NewGameSessionProtectionPolicy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NewGameSessionProtectionPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PerInstanceContainerGroupDefinitionArn":
                        {
                            context.AddPathSegment("PerInstanceContainerGroupDefinitionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PerInstanceContainerGroupDefinitionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PerInstanceContainerGroupDefinitionName":
                        {
                            context.AddPathSegment("PerInstanceContainerGroupDefinitionName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PerInstanceContainerGroupDefinitionName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlayerGatewayMode":
                        {
                            context.AddPathSegment("PlayerGatewayMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlayerGatewayMode = unmarshaller.Unmarshall(context);
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


        private static ContainerFleetUnmarshaller _instance = new ContainerFleetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerFleetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}