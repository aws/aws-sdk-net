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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceRevision Object
    /// </summary>  
    public class ServiceRevisionUnmarshaller : IUnmarshaller<ServiceRevision, XmlUnmarshallerContext>, IUnmarshaller<ServiceRevision, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceRevision IUnmarshaller<ServiceRevision, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceRevision Unmarshall(JsonUnmarshallerContext context)
        {
            ServiceRevision unmarshalledObject = new ServiceRevision();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("capacityProviderStrategy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CapacityProviderStrategyItem, CapacityProviderStrategyItemUnmarshaller>(CapacityProviderStrategyItemUnmarshaller.Instance);
                    unmarshalledObject.CapacityProviderStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("containerImages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContainerImage, ContainerImageUnmarshaller>(ContainerImageUnmarshaller.Instance);
                    unmarshalledObject.ContainerImages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecsManagedResources", targetDepth))
                {
                    var unmarshaller = ECSManagedResourcesUnmarshaller.Instance;
                    unmarshalledObject.EcsManagedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fargateEphemeralStorage", targetDepth))
                {
                    var unmarshaller = DeploymentEphemeralStorageUnmarshaller.Instance;
                    unmarshalledObject.FargateEphemeralStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("guardDutyEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.GuardDutyEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loadBalancers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LoadBalancer, LoadBalancerUnmarshaller>(LoadBalancerUnmarshaller.Instance);
                    unmarshalledObject.LoadBalancers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkConfiguration", targetDepth))
                {
                    var unmarshaller = NetworkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformFamily = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resolvedConfiguration", targetDepth))
                {
                    var unmarshaller = ResolvedConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResolvedConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceConnectConfiguration", targetDepth))
                {
                    var unmarshaller = ServiceConnectConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ServiceConnectConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceRegistries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceRegistry, ServiceRegistryUnmarshaller>(ServiceRegistryUnmarshaller.Instance);
                    unmarshalledObject.ServiceRegistries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceRevisionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRevisionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskDefinition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumeConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceVolumeConfiguration, ServiceVolumeConfigurationUnmarshaller>(ServiceVolumeConfigurationUnmarshaller.Instance);
                    unmarshalledObject.VolumeConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcLatticeConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VpcLatticeConfiguration, VpcLatticeConfigurationUnmarshaller>(VpcLatticeConfigurationUnmarshaller.Instance);
                    unmarshalledObject.VpcLatticeConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceRevisionUnmarshaller _instance = new ServiceRevisionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceRevisionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}