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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContainerFleet Object
    /// </summary>  
    public class ContainerFleetUnmarshaller : IUnmarshaller<ContainerFleet, XmlUnmarshallerContext>, IUnmarshaller<ContainerFleet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ContainerFleet IUnmarshaller<ContainerFleet, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerFleet Unmarshall(JsonUnmarshallerContext context)
        {
            ContainerFleet unmarshalledObject = new ContainerFleet();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BillingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BillingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentDetails", targetDepth))
                {
                    var unmarshaller = DeploymentDetailsUnmarshaller.Instance;
                    unmarshalledObject.DeploymentDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FleetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FleetArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FleetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FleetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FleetRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FleetRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameServerContainerGroupDefinitionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameServerContainerGroupDefinitionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameServerContainerGroupDefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GameServerContainerGroupDefinitionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameServerContainerGroupsPerInstance", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GameServerContainerGroupsPerInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GameSessionCreationLimitPolicy", targetDepth))
                {
                    var unmarshaller = GameSessionCreationLimitPolicyUnmarshaller.Instance;
                    unmarshalledObject.GameSessionCreationLimitPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceConnectionPortRange", targetDepth))
                {
                    var unmarshaller = ConnectionPortRangeUnmarshaller.Instance;
                    unmarshalledObject.InstanceConnectionPortRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceInboundPermissions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpPermission, IpPermissionUnmarshaller>(IpPermissionUnmarshaller.Instance);
                    unmarshalledObject.InstanceInboundPermissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocationAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContainerFleetLocationAttributes, ContainerFleetLocationAttributesUnmarshaller>(ContainerFleetLocationAttributesUnmarshaller.Instance);
                    unmarshalledObject.LocationAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogConfiguration", targetDepth))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumGameServerContainerGroupsPerInstance", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumGameServerContainerGroupsPerInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MetricGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NewGameSessionProtectionPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NewGameSessionProtectionPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerInstanceContainerGroupDefinitionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PerInstanceContainerGroupDefinitionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerInstanceContainerGroupDefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PerInstanceContainerGroupDefinitionName = unmarshaller.Unmarshall(context);
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