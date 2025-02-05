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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskSet Object
    /// </summary>  
    public class TaskSetUnmarshaller : IJsonUnmarshaller<TaskSet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TaskSet Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TaskSet unmarshalledObject = new TaskSet();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("capacityProviderStrategy", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CapacityProviderStrategyItem, CapacityProviderStrategyItemUnmarshaller>(CapacityProviderStrategyItemUnmarshaller.Instance);
                    unmarshalledObject.CapacityProviderStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("computedDesiredCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ComputedDesiredCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("externalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExternalId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fargateEphemeralStorage", targetDepth))
                {
                    var unmarshaller = DeploymentEphemeralStorageUnmarshaller.Instance;
                    unmarshalledObject.FargateEphemeralStorage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("launchType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("loadBalancers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LoadBalancer, LoadBalancerUnmarshaller>(LoadBalancerUnmarshaller.Instance);
                    unmarshalledObject.LoadBalancers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkConfiguration", targetDepth))
                {
                    var unmarshaller = NetworkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pendingCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PendingCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("platformFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformFamily = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("platformVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("runningCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RunningCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scale", targetDepth))
                {
                    var unmarshaller = ScaleUnmarshaller.Instance;
                    unmarshalledObject.Scale = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceRegistries", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ServiceRegistry, ServiceRegistryUnmarshaller>(ServiceRegistryUnmarshaller.Instance);
                    unmarshalledObject.ServiceRegistries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stabilityStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StabilityStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stabilityStatusAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StabilityStatusAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskDefinition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskSetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskSetArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TaskSetUnmarshaller _instance = new TaskSetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TaskSetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}