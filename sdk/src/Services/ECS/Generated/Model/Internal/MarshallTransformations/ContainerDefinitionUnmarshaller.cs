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
    /// Response Unmarshaller for ContainerDefinition Object
    /// </summary>  
    public class ContainerDefinitionUnmarshaller : IJsonUnmarshaller<ContainerDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ContainerDefinition unmarshalledObject = new ContainerDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("command", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpu", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("credentialSpecs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CredentialSpecs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dependsOn", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ContainerDependency, ContainerDependencyUnmarshaller>(ContainerDependencyUnmarshaller.Instance);
                    unmarshalledObject.DependsOn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("disableNetworking", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableNetworking = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dnsSearchDomains", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsSearchDomains = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dnsServers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsServers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dockerLabels", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.DockerLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dockerSecurityOptions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DockerSecurityOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("entryPoint", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EntryPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("environmentFiles", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EnvironmentFile, EnvironmentFileUnmarshaller>(EnvironmentFileUnmarshaller.Instance);
                    unmarshalledObject.EnvironmentFiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("essential", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Essential = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("extraHosts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HostEntry, HostEntryUnmarshaller>(HostEntryUnmarshaller.Instance);
                    unmarshalledObject.ExtraHosts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("firelensConfiguration", targetDepth))
                {
                    var unmarshaller = FirelensConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FirelensConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("healthCheck", targetDepth))
                {
                    var unmarshaller = HealthCheckUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("image", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("interactive", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Interactive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("links", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Links = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("linuxParameters", targetDepth))
                {
                    var unmarshaller = LinuxParametersUnmarshaller.Instance;
                    unmarshalledObject.LinuxParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logConfiguration", targetDepth))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memory", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryReservation", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MemoryReservation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mountPoints", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MountPoint, MountPointUnmarshaller>(MountPointUnmarshaller.Instance);
                    unmarshalledObject.MountPoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("portMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PortMapping, PortMappingUnmarshaller>(PortMappingUnmarshaller.Instance);
                    unmarshalledObject.PortMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privileged", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Privileged = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pseudoTerminal", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.PseudoTerminal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("readonlyRootFilesystem", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ReadonlyRootFilesystem = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("repositoryCredentials", targetDepth))
                {
                    var unmarshaller = RepositoryCredentialsUnmarshaller.Instance;
                    unmarshalledObject.RepositoryCredentials = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceRequirements", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceRequirement, ResourceRequirementUnmarshaller>(ResourceRequirementUnmarshaller.Instance);
                    unmarshalledObject.ResourceRequirements = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("restartPolicy", targetDepth))
                {
                    var unmarshaller = ContainerRestartPolicyUnmarshaller.Instance;
                    unmarshalledObject.RestartPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("secrets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Secret, SecretUnmarshaller>(SecretUnmarshaller.Instance);
                    unmarshalledObject.Secrets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startTimeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.StartTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stopTimeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.StopTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemControls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SystemControl, SystemControlUnmarshaller>(SystemControlUnmarshaller.Instance);
                    unmarshalledObject.SystemControls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ulimits", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Ulimit, UlimitUnmarshaller>(UlimitUnmarshaller.Instance);
                    unmarshalledObject.Ulimits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("user", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("versionConsistency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VersionConsistency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("volumesFrom", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<VolumeFrom, VolumeFromUnmarshaller>(VolumeFromUnmarshaller.Instance);
                    unmarshalledObject.VolumesFrom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workingDirectory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkingDirectory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContainerDefinitionUnmarshaller _instance = new ContainerDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}