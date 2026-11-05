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
    /// Response Unmarshaller for ContainerFleet Object
    /// </summary>
    public partial class ContainerFleetUnmarshaller : ICborUnmarshaller<ContainerFleet, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ContainerFleet Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ContainerFleet();
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
                    case "BillingType":
                        context.AddPathSegment("BillingType");
                        unmarshalledObject.BillingType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeploymentDetails":
                        context.AddPathSegment("DeploymentDetails");
                        unmarshalledObject.DeploymentDetails = DeploymentDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetArn":
                        context.AddPathSegment("FleetArn");
                        unmarshalledObject.FleetArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetId":
                        context.AddPathSegment("FleetId");
                        unmarshalledObject.FleetId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetRoleArn":
                        context.AddPathSegment("FleetRoleArn");
                        unmarshalledObject.FleetRoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerContainerGroupDefinitionArn":
                        context.AddPathSegment("GameServerContainerGroupDefinitionArn");
                        unmarshalledObject.GameServerContainerGroupDefinitionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerContainerGroupDefinitionName":
                        context.AddPathSegment("GameServerContainerGroupDefinitionName");
                        unmarshalledObject.GameServerContainerGroupDefinitionName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerContainerGroupsPerInstance":
                        context.AddPathSegment("GameServerContainerGroupsPerInstance");
                        unmarshalledObject.GameServerContainerGroupsPerInstance = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionCreationLimitPolicy":
                        context.AddPathSegment("GameSessionCreationLimitPolicy");
                        unmarshalledObject.GameSessionCreationLimitPolicy = GameSessionCreationLimitPolicyUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceConnectionPortRange":
                        context.AddPathSegment("InstanceConnectionPortRange");
                        unmarshalledObject.InstanceConnectionPortRange = ConnectionPortRangeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceInboundPermissions":
                        context.AddPathSegment("InstanceInboundPermissions");
                        unmarshalledObject.InstanceInboundPermissions = new CborListUnmarshaller<IpPermission, IpPermissionUnmarshaller>(IpPermissionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceType":
                        context.AddPathSegment("InstanceType");
                        unmarshalledObject.InstanceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LocationAttributes":
                        context.AddPathSegment("LocationAttributes");
                        unmarshalledObject.LocationAttributes = new CborListUnmarshaller<ContainerFleetLocationAttributes, ContainerFleetLocationAttributesUnmarshaller>(ContainerFleetLocationAttributesUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogConfiguration":
                        context.AddPathSegment("LogConfiguration");
                        unmarshalledObject.LogConfiguration = LogConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaximumGameServerContainerGroupsPerInstance":
                        context.AddPathSegment("MaximumGameServerContainerGroupsPerInstance");
                        unmarshalledObject.MaximumGameServerContainerGroupsPerInstance = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MetricGroups":
                        context.AddPathSegment("MetricGroups");
                        unmarshalledObject.MetricGroups = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NewGameSessionProtectionPolicy":
                        context.AddPathSegment("NewGameSessionProtectionPolicy");
                        unmarshalledObject.NewGameSessionProtectionPolicy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PerInstanceContainerGroupDefinitionArn":
                        context.AddPathSegment("PerInstanceContainerGroupDefinitionArn");
                        unmarshalledObject.PerInstanceContainerGroupDefinitionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PerInstanceContainerGroupDefinitionName":
                        context.AddPathSegment("PerInstanceContainerGroupDefinitionName");
                        unmarshalledObject.PerInstanceContainerGroupDefinitionName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlayerGatewayMode":
                        context.AddPathSegment("PlayerGatewayMode");
                        unmarshalledObject.PlayerGatewayMode = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ContainerFleetUnmarshaller _instance = new ContainerFleetUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ContainerFleetUnmarshaller Instance => _instance;
    }
}
