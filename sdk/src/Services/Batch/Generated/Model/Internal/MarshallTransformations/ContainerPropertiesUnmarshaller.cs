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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContainerProperties Object
    /// </summary>  
    public class ContainerPropertiesUnmarshaller : IJsonUnmarshaller<ContainerProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerProperties Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ContainerProperties unmarshalledObject = new ContainerProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("command", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("enableExecuteCommand", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableExecuteCommand = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ephemeralStorage", targetDepth, ref reader))
                {
                    var unmarshaller = EphemeralStorageUnmarshaller.Instance;
                    unmarshalledObject.EphemeralStorage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionRoleArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fargatePlatformConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = FargatePlatformConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FargatePlatformConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("image", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("jobRoleArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("linuxParameters", targetDepth, ref reader))
                {
                    var unmarshaller = LinuxParametersUnmarshaller.Instance;
                    unmarshalledObject.LinuxParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memory", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mountPoints", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<MountPoint, MountPointUnmarshaller>(MountPointUnmarshaller.Instance);
                    unmarshalledObject.MountPoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privileged", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Privileged = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("readonlyRootFilesystem", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ReadonlyRootFilesystem = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("repositoryCredentials", targetDepth, ref reader))
                {
                    var unmarshaller = RepositoryCredentialsUnmarshaller.Instance;
                    unmarshalledObject.RepositoryCredentials = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceRequirements", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceRequirement, ResourceRequirementUnmarshaller>(ResourceRequirementUnmarshaller.Instance);
                    unmarshalledObject.ResourceRequirements = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("runtimePlatform", targetDepth, ref reader))
                {
                    var unmarshaller = RuntimePlatformUnmarshaller.Instance;
                    unmarshalledObject.RuntimePlatform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("secrets", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Secret, SecretUnmarshaller>(SecretUnmarshaller.Instance);
                    unmarshalledObject.Secrets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ulimits", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Ulimit, UlimitUnmarshaller>(UlimitUnmarshaller.Instance);
                    unmarshalledObject.Ulimits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("user", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vcpus", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Vcpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("volumes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Volume, VolumeUnmarshaller>(VolumeUnmarshaller.Instance);
                    unmarshalledObject.Volumes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContainerPropertiesUnmarshaller _instance = new ContainerPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}