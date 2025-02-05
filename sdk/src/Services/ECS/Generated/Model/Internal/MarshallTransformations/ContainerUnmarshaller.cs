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
    /// Response Unmarshaller for Container Object
    /// </summary>  
    public class ContainerUnmarshaller : IJsonUnmarshaller<Container, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Container Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Container unmarshalledObject = new Container();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("containerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContainerArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpu", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("exitCode", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ExitCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gpuIds", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GpuIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("healthStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("image", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageDigest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageDigest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("managedAgents", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ManagedAgent, ManagedAgentUnmarshaller>(ManagedAgentUnmarshaller.Instance);
                    unmarshalledObject.ManagedAgents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryReservation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MemoryReservation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkBindings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<NetworkBinding, NetworkBindingUnmarshaller>(NetworkBindingUnmarshaller.Instance);
                    unmarshalledObject.NetworkBindings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkInterfaces", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<NetworkInterface, NetworkInterfaceUnmarshaller>(NetworkInterfaceUnmarshaller.Instance);
                    unmarshalledObject.NetworkInterfaces = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("runtimeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuntimeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContainerUnmarshaller _instance = new ContainerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}