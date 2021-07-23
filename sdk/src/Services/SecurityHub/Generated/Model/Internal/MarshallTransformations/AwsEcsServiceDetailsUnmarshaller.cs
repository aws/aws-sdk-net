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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcsServiceDetails Object
    /// </summary>  
    public class AwsEcsServiceDetailsUnmarshaller : IUnmarshaller<AwsEcsServiceDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEcsServiceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEcsServiceDetails IUnmarshaller<AwsEcsServiceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEcsServiceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEcsServiceDetails unmarshalledObject = new AwsEcsServiceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CapacityProviderStrategy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsServiceCapacityProviderStrategyDetails, AwsEcsServiceCapacityProviderStrategyDetailsUnmarshaller>(AwsEcsServiceCapacityProviderStrategyDetailsUnmarshaller.Instance);
                    unmarshalledObject.CapacityProviderStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cluster", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentConfiguration", targetDepth))
                {
                    var unmarshaller = AwsEcsServiceDeploymentConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.DeploymentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentController", targetDepth))
                {
                    var unmarshaller = AwsEcsServiceDeploymentControllerDetailsUnmarshaller.Instance;
                    unmarshalledObject.DeploymentController = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DesiredCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DesiredCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableEcsManagedTags", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableEcsManagedTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableExecuteCommand", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableExecuteCommand = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthCheckGracePeriodSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckGracePeriodSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LaunchType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoadBalancers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsServiceLoadBalancersDetails, AwsEcsServiceLoadBalancersDetailsUnmarshaller>(AwsEcsServiceLoadBalancersDetailsUnmarshaller.Instance);
                    unmarshalledObject.LoadBalancers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkConfiguration", targetDepth))
                {
                    var unmarshaller = AwsEcsServiceNetworkConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlacementConstraints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsServicePlacementConstraintsDetails, AwsEcsServicePlacementConstraintsDetailsUnmarshaller>(AwsEcsServicePlacementConstraintsDetailsUnmarshaller.Instance);
                    unmarshalledObject.PlacementConstraints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlacementStrategies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsServicePlacementStrategiesDetails, AwsEcsServicePlacementStrategiesDetailsUnmarshaller>(AwsEcsServicePlacementStrategiesDetailsUnmarshaller.Instance);
                    unmarshalledObject.PlacementStrategies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlatformVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PropagateTags", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PropagateTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchedulingStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchedulingStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRegistries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsServiceServiceRegistriesDetails, AwsEcsServiceServiceRegistriesDetailsUnmarshaller>(AwsEcsServiceServiceRegistriesDetailsUnmarshaller.Instance);
                    unmarshalledObject.ServiceRegistries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskDefinition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEcsServiceDetailsUnmarshaller _instance = new AwsEcsServiceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcsServiceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}