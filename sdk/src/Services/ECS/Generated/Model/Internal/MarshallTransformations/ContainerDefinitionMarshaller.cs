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
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerDefinition Marshaller
    /// </summary>
    public class ContainerDefinitionMarshaller : IRequestMarshaller<ContainerDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.WriteStringValue(requestObjectCommandListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("cpu");
                context.Writer.WriteNumberValue(requestObject.Cpu.Value);
            }

            if(requestObject.IsSetCredentialSpecs())
            {
                context.Writer.WritePropertyName("credentialSpecs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCredentialSpecsListValue in requestObject.CredentialSpecs)
                {
                        context.Writer.WriteStringValue(requestObjectCredentialSpecsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("dependsOn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContainerDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDisableNetworking())
            {
                context.Writer.WritePropertyName("disableNetworking");
                context.Writer.WriteBooleanValue(requestObject.DisableNetworking.Value);
            }

            if(requestObject.IsSetDnsSearchDomains())
            {
                context.Writer.WritePropertyName("dnsSearchDomains");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDnsSearchDomainsListValue in requestObject.DnsSearchDomains)
                {
                        context.Writer.WriteStringValue(requestObjectDnsSearchDomainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDnsServers())
            {
                context.Writer.WritePropertyName("dnsServers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDnsServersListValue in requestObject.DnsServers)
                {
                        context.Writer.WriteStringValue(requestObjectDnsServersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDockerLabels())
            {
                context.Writer.WritePropertyName("dockerLabels");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDockerLabelsKvp in requestObject.DockerLabels)
                {
                    context.Writer.WritePropertyName(requestObjectDockerLabelsKvp.Key);
                    var requestObjectDockerLabelsValue = requestObjectDockerLabelsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDockerLabelsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDockerSecurityOptions())
            {
                context.Writer.WritePropertyName("dockerSecurityOptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDockerSecurityOptionsListValue in requestObject.DockerSecurityOptions)
                {
                        context.Writer.WriteStringValue(requestObjectDockerSecurityOptionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntryPoint())
            {
                context.Writer.WritePropertyName("entryPoint");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntryPointListValue in requestObject.EntryPoint)
                {
                        context.Writer.WriteStringValue(requestObjectEntryPointListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KeyValuePairMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnvironmentFiles())
            {
                context.Writer.WritePropertyName("environmentFiles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentFilesListValue in requestObject.EnvironmentFiles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentFileMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentFilesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("essential");
                context.Writer.WriteBooleanValue(requestObject.Essential.Value);
            }

            if(requestObject.IsSetExtraHosts())
            {
                context.Writer.WritePropertyName("extraHosts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExtraHostsListValue in requestObject.ExtraHosts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HostEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtraHostsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFirelensConfiguration())
            {
                context.Writer.WritePropertyName("firelensConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FirelensConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FirelensConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("healthCheck");
                context.Writer.WriteStartObject();

                var marshaller = HealthCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHostname())
            {
                context.Writer.WritePropertyName("hostname");
                context.Writer.WriteStringValue(requestObject.Hostname);
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetInteractive())
            {
                context.Writer.WritePropertyName("interactive");
                context.Writer.WriteBooleanValue(requestObject.Interactive.Value);
            }

            if(requestObject.IsSetLinks())
            {
                context.Writer.WritePropertyName("links");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLinksListValue in requestObject.Links)
                {
                        context.Writer.WriteStringValue(requestObjectLinksListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLinuxParameters())
            {
                context.Writer.WritePropertyName("linuxParameters");
                context.Writer.WriteStartObject();

                var marshaller = LinuxParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("logConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("memory");
                context.Writer.WriteNumberValue(requestObject.Memory.Value);
            }

            if(requestObject.IsSetMemoryReservation())
            {
                context.Writer.WritePropertyName("memoryReservation");
                context.Writer.WriteNumberValue(requestObject.MemoryReservation.Value);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("mountPoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPortMappings())
            {
                context.Writer.WritePropertyName("portMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPortMappingsListValue in requestObject.PortMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PortMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("privileged");
                context.Writer.WriteBooleanValue(requestObject.Privileged.Value);
            }

            if(requestObject.IsSetPseudoTerminal())
            {
                context.Writer.WritePropertyName("pseudoTerminal");
                context.Writer.WriteBooleanValue(requestObject.PseudoTerminal.Value);
            }

            if(requestObject.IsSetReadonlyRootFilesystem())
            {
                context.Writer.WritePropertyName("readonlyRootFilesystem");
                context.Writer.WriteBooleanValue(requestObject.ReadonlyRootFilesystem.Value);
            }

            if(requestObject.IsSetRepositoryCredentials())
            {
                context.Writer.WritePropertyName("repositoryCredentials");
                context.Writer.WriteStartObject();

                var marshaller = RepositoryCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryCredentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("resourceRequirements");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRestartPolicy())
            {
                context.Writer.WritePropertyName("restartPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ContainerRestartPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.RestartPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecrets())
            {
                context.Writer.WritePropertyName("secrets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecretsListValue in requestObject.Secrets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SecretMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStartTimeout())
            {
                context.Writer.WritePropertyName("startTimeout");
                context.Writer.WriteNumberValue(requestObject.StartTimeout.Value);
            }

            if(requestObject.IsSetStopTimeout())
            {
                context.Writer.WritePropertyName("stopTimeout");
                context.Writer.WriteNumberValue(requestObject.StopTimeout.Value);
            }

            if(requestObject.IsSetSystemControls())
            {
                context.Writer.WritePropertyName("systemControls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSystemControlsListValue in requestObject.SystemControls)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SystemControlMarshaller.Instance;
                    marshaller.Marshall(requestObjectSystemControlsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUlimits())
            {
                context.Writer.WritePropertyName("ulimits");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUlimitsListValue in requestObject.Ulimits)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UlimitMarshaller.Instance;
                    marshaller.Marshall(requestObjectUlimitsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.WriteStringValue(requestObject.User);
            }

            if(requestObject.IsSetVersionConsistency())
            {
                context.Writer.WritePropertyName("versionConsistency");
                context.Writer.WriteStringValue(requestObject.VersionConsistency);
            }

            if(requestObject.IsSetVolumesFrom())
            {
                context.Writer.WritePropertyName("volumesFrom");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumesFromListValue in requestObject.VolumesFrom)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VolumeFromMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesFromListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWorkingDirectory())
            {
                context.Writer.WritePropertyName("workingDirectory");
                context.Writer.WriteStringValue(requestObject.WorkingDirectory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerDefinitionMarshaller Instance = new ContainerDefinitionMarshaller();

    }
}