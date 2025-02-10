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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcsTaskDefinitionDetails Object
    /// </summary>  
    public class AwsEcsTaskDefinitionDetailsUnmarshaller : IJsonUnmarshaller<AwsEcsTaskDefinitionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEcsTaskDefinitionDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEcsTaskDefinitionDetails unmarshalledObject = new AwsEcsTaskDefinitionDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ContainerDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsDetails, AwsEcsTaskDefinitionContainerDefinitionsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsDetailsUnmarshaller.Instance);
                    unmarshalledObject.ContainerDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Cpu", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Family", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Family = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InferenceAccelerators", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionInferenceAcceleratorsDetails, AwsEcsTaskDefinitionInferenceAcceleratorsDetailsUnmarshaller>(AwsEcsTaskDefinitionInferenceAcceleratorsDetailsUnmarshaller.Instance);
                    unmarshalledObject.InferenceAccelerators = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IpcMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpcMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Memory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PidMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PidMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlacementConstraints", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionPlacementConstraintsDetails, AwsEcsTaskDefinitionPlacementConstraintsDetailsUnmarshaller>(AwsEcsTaskDefinitionPlacementConstraintsDetailsUnmarshaller.Instance);
                    unmarshalledObject.PlacementConstraints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProxyConfiguration", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionProxyConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.ProxyConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RequiresCompatibilities", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RequiresCompatibilities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Volumes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionVolumesDetails, AwsEcsTaskDefinitionVolumesDetailsUnmarshaller>(AwsEcsTaskDefinitionVolumesDetailsUnmarshaller.Instance);
                    unmarshalledObject.Volumes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEcsTaskDefinitionDetailsUnmarshaller _instance = new AwsEcsTaskDefinitionDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcsTaskDefinitionDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}