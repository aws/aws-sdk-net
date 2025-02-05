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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EcsParameters Object
    /// </summary>  
    public class EcsParametersUnmarshaller : IJsonUnmarshaller<EcsParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EcsParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EcsParameters unmarshalledObject = new EcsParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CapacityProviderStrategy", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CapacityProviderStrategyItem, CapacityProviderStrategyItemUnmarshaller>(CapacityProviderStrategyItemUnmarshaller.Instance);
                    unmarshalledObject.CapacityProviderStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnableECSManagedTags", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableECSManagedTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnableExecuteCommand", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableExecuteCommand = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Group", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Group = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LaunchType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkConfiguration", targetDepth))
                {
                    var unmarshaller = NetworkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlacementConstraints", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PlacementConstraint, PlacementConstraintUnmarshaller>(PlacementConstraintUnmarshaller.Instance);
                    unmarshalledObject.PlacementConstraints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlacementStrategy", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PlacementStrategy, PlacementStrategyUnmarshaller>(PlacementStrategyUnmarshaller.Instance);
                    unmarshalledObject.PlacementStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlatformVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PropagateTags", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PropagateTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReferenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReferenceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TaskCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskDefinitionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskDefinitionArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EcsParametersUnmarshaller _instance = new EcsParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EcsParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}