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
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsTaskDefinitionContainerDefinitionsDetails Marshaller
    /// </summary>
    public class AwsEcsTaskDefinitionContainerDefinitionsDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDefinitionContainerDefinitionsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDefinitionContainerDefinitionsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.WriteStringValue(requestObjectCommandListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("Cpu");
                context.Writer.WriteNumberValue(requestObject.Cpu.Value);
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("DependsOn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDisableNetworking())
            {
                context.Writer.WritePropertyName("DisableNetworking");
                context.Writer.WriteBooleanValue(requestObject.DisableNetworking.Value);
            }

            if(requestObject.IsSetDnsSearchDomains())
            {
                context.Writer.WritePropertyName("DnsSearchDomains");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDnsSearchDomainsListValue in requestObject.DnsSearchDomains)
                {
                        context.Writer.WriteStringValue(requestObjectDnsSearchDomainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDnsServers())
            {
                context.Writer.WritePropertyName("DnsServers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDnsServersListValue in requestObject.DnsServers)
                {
                        context.Writer.WriteStringValue(requestObjectDnsServersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDockerLabels())
            {
                context.Writer.WritePropertyName("DockerLabels");
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
                context.Writer.WritePropertyName("DockerSecurityOptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDockerSecurityOptionsListValue in requestObject.DockerSecurityOptions)
                {
                        context.Writer.WriteStringValue(requestObjectDockerSecurityOptionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntryPoint())
            {
                context.Writer.WritePropertyName("EntryPoint");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntryPointListValue in requestObject.EntryPoint)
                {
                        context.Writer.WriteStringValue(requestObjectEntryPointListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnvironmentFiles())
            {
                context.Writer.WritePropertyName("EnvironmentFiles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentFilesListValue in requestObject.EnvironmentFiles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentFilesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("Essential");
                context.Writer.WriteBooleanValue(requestObject.Essential.Value);
            }

            if(requestObject.IsSetExtraHosts())
            {
                context.Writer.WritePropertyName("ExtraHosts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExtraHostsListValue in requestObject.ExtraHosts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtraHostsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFirelensConfiguration())
            {
                context.Writer.WritePropertyName("FirelensConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.FirelensConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("HealthCheck");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHostname())
            {
                context.Writer.WritePropertyName("Hostname");
                context.Writer.WriteStringValue(requestObject.Hostname);
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("Image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetInteractive())
            {
                context.Writer.WritePropertyName("Interactive");
                context.Writer.WriteBooleanValue(requestObject.Interactive.Value);
            }

            if(requestObject.IsSetLinks())
            {
                context.Writer.WritePropertyName("Links");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLinksListValue in requestObject.Links)
                {
                        context.Writer.WriteStringValue(requestObjectLinksListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLinuxParameters())
            {
                context.Writer.WritePropertyName("LinuxParameters");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("LogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("Memory");
                context.Writer.WriteNumberValue(requestObject.Memory.Value);
            }

            if(requestObject.IsSetMemoryReservation())
            {
                context.Writer.WritePropertyName("MemoryReservation");
                context.Writer.WriteNumberValue(requestObject.MemoryReservation.Value);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("MountPoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPortMappings())
            {
                context.Writer.WritePropertyName("PortMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPortMappingsListValue in requestObject.PortMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("Privileged");
                context.Writer.WriteBooleanValue(requestObject.Privileged.Value);
            }

            if(requestObject.IsSetPseudoTerminal())
            {
                context.Writer.WritePropertyName("PseudoTerminal");
                context.Writer.WriteBooleanValue(requestObject.PseudoTerminal.Value);
            }

            if(requestObject.IsSetReadonlyRootFilesystem())
            {
                context.Writer.WritePropertyName("ReadonlyRootFilesystem");
                context.Writer.WriteBooleanValue(requestObject.ReadonlyRootFilesystem.Value);
            }

            if(requestObject.IsSetRepositoryCredentials())
            {
                context.Writer.WritePropertyName("RepositoryCredentials");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsRepositoryCredentialsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryCredentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("ResourceRequirements");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecrets())
            {
                context.Writer.WritePropertyName("Secrets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecretsListValue in requestObject.Secrets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsSecretsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStartTimeout())
            {
                context.Writer.WritePropertyName("StartTimeout");
                context.Writer.WriteNumberValue(requestObject.StartTimeout.Value);
            }

            if(requestObject.IsSetStopTimeout())
            {
                context.Writer.WritePropertyName("StopTimeout");
                context.Writer.WriteNumberValue(requestObject.StopTimeout.Value);
            }

            if(requestObject.IsSetSystemControls())
            {
                context.Writer.WritePropertyName("SystemControls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSystemControlsListValue in requestObject.SystemControls)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSystemControlsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUlimits())
            {
                context.Writer.WritePropertyName("Ulimits");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUlimitsListValue in requestObject.Ulimits)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectUlimitsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("User");
                context.Writer.WriteStringValue(requestObject.User);
            }

            if(requestObject.IsSetVolumesFrom())
            {
                context.Writer.WritePropertyName("VolumesFrom");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumesFromListValue in requestObject.VolumesFrom)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesFromListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWorkingDirectory())
            {
                context.Writer.WritePropertyName("WorkingDirectory");
                context.Writer.WriteStringValue(requestObject.WorkingDirectory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsTaskDefinitionContainerDefinitionsDetailsMarshaller Instance = new AwsEcsTaskDefinitionContainerDefinitionsDetailsMarshaller();

    }
}