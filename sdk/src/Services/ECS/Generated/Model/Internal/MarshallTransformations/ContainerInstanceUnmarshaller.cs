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
    /// Response Unmarshaller for ContainerInstance Object
    /// </summary>  
    public class ContainerInstanceUnmarshaller : IJsonUnmarshaller<ContainerInstance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerInstance Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ContainerInstance unmarshalledObject = new ContainerInstance();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("agentConnected", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AgentConnected = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("agentUpdateStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentUpdateStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("attachments", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Attachment, AttachmentUnmarshaller>(AttachmentUnmarshaller.Instance);
                    unmarshalledObject.Attachments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("attributes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Attribute, AttributeUnmarshaller>(AttributeUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("capacityProviderName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CapacityProviderName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containerInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContainerInstanceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("healthStatus", targetDepth))
                {
                    var unmarshaller = ContainerInstanceHealthStatusUnmarshaller.Instance;
                    unmarshalledObject.HealthStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pendingTasksCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PendingTasksCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("registeredAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.RegisteredAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("registeredResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Resource, ResourceUnmarshaller>(ResourceUnmarshaller.Instance);
                    unmarshalledObject.RegisteredResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remainingResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Resource, ResourceUnmarshaller>(ResourceUnmarshaller.Instance);
                    unmarshalledObject.RemainingResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("runningTasksCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RunningTasksCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("versionInfo", targetDepth))
                {
                    var unmarshaller = VersionInfoUnmarshaller.Instance;
                    unmarshalledObject.VersionInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContainerInstanceUnmarshaller _instance = new ContainerInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}