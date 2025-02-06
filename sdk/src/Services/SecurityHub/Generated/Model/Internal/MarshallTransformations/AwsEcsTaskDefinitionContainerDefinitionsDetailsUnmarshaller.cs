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
    /// Response Unmarshaller for AwsEcsTaskDefinitionContainerDefinitionsDetails Object
    /// </summary>  
    public class AwsEcsTaskDefinitionContainerDefinitionsDetailsUnmarshaller : IJsonUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEcsTaskDefinitionContainerDefinitionsDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEcsTaskDefinitionContainerDefinitionsDetails unmarshalledObject = new AwsEcsTaskDefinitionContainerDefinitionsDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Command", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Cpu", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DependsOn", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails, AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetailsUnmarshaller.Instance);
                    unmarshalledObject.DependsOn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DisableNetworking", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableNetworking = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsSearchDomains", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsSearchDomains = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsServers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsServers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DockerLabels", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.DockerLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DockerSecurityOptions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DockerSecurityOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EntryPoint", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EntryPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetails, AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetailsUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnvironmentFiles", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetails, AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetailsUnmarshaller.Instance);
                    unmarshalledObject.EnvironmentFiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Essential", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Essential = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExtraHosts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetails, AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetailsUnmarshaller.Instance);
                    unmarshalledObject.ExtraHosts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirelensConfiguration", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.FirelensConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HealthCheck", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetailsUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Image", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Interactive", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Interactive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Links", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Links = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LinuxParameters", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsUnmarshaller.Instance;
                    unmarshalledObject.LinuxParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LogConfiguration", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Memory", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MemoryReservation", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MemoryReservation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MountPoints", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails, AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetailsUnmarshaller.Instance);
                    unmarshalledObject.MountPoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PortMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails, AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetailsUnmarshaller.Instance);
                    unmarshalledObject.PortMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Privileged", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Privileged = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PseudoTerminal", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.PseudoTerminal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReadonlyRootFilesystem", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ReadonlyRootFilesystem = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RepositoryCredentials", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsRepositoryCredentialsDetailsUnmarshaller.Instance;
                    unmarshalledObject.RepositoryCredentials = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceRequirements", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetails, AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetailsUnmarshaller.Instance);
                    unmarshalledObject.ResourceRequirements = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Secrets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsSecretsDetails, AwsEcsTaskDefinitionContainerDefinitionsSecretsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsSecretsDetailsUnmarshaller.Instance);
                    unmarshalledObject.Secrets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTimeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.StartTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StopTimeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.StopTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SystemControls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetails, AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetailsUnmarshaller.Instance);
                    unmarshalledObject.SystemControls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ulimits", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails, AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetailsUnmarshaller.Instance);
                    unmarshalledObject.Ulimits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("User", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumesFrom", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails, AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetailsUnmarshaller.Instance);
                    unmarshalledObject.VolumesFrom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkingDirectory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkingDirectory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEcsTaskDefinitionContainerDefinitionsDetailsUnmarshaller _instance = new AwsEcsTaskDefinitionContainerDefinitionsDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcsTaskDefinitionContainerDefinitionsDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}