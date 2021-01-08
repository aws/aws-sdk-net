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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.Write(requestObjectCommandListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("cpu");
                context.Writer.Write(requestObject.Cpu);
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("dependsOn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ContainerDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDisableNetworking())
            {
                context.Writer.WritePropertyName("disableNetworking");
                context.Writer.Write(requestObject.DisableNetworking);
            }

            if(requestObject.IsSetDnsSearchDomains())
            {
                context.Writer.WritePropertyName("dnsSearchDomains");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDnsSearchDomainsListValue in requestObject.DnsSearchDomains)
                {
                        context.Writer.Write(requestObjectDnsSearchDomainsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDnsServers())
            {
                context.Writer.WritePropertyName("dnsServers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDnsServersListValue in requestObject.DnsServers)
                {
                        context.Writer.Write(requestObjectDnsServersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDockerLabels())
            {
                context.Writer.WritePropertyName("dockerLabels");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDockerLabelsKvp in requestObject.DockerLabels)
                {
                    context.Writer.WritePropertyName(requestObjectDockerLabelsKvp.Key);
                    var requestObjectDockerLabelsValue = requestObjectDockerLabelsKvp.Value;

                        context.Writer.Write(requestObjectDockerLabelsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDockerSecurityOptions())
            {
                context.Writer.WritePropertyName("dockerSecurityOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDockerSecurityOptionsListValue in requestObject.DockerSecurityOptions)
                {
                        context.Writer.Write(requestObjectDockerSecurityOptionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntryPoint())
            {
                context.Writer.WritePropertyName("entryPoint");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntryPointListValue in requestObject.EntryPoint)
                {
                        context.Writer.Write(requestObjectEntryPointListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KeyValuePairMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironmentFiles())
            {
                context.Writer.WritePropertyName("environmentFiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentFilesListValue in requestObject.EnvironmentFiles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EnvironmentFileMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentFilesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("essential");
                context.Writer.Write(requestObject.Essential);
            }

            if(requestObject.IsSetExtraHosts())
            {
                context.Writer.WritePropertyName("extraHosts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExtraHostsListValue in requestObject.ExtraHosts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HostEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtraHostsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFirelensConfiguration())
            {
                context.Writer.WritePropertyName("firelensConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FirelensConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FirelensConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("healthCheck");
                context.Writer.WriteObjectStart();

                var marshaller = HealthCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHostname())
            {
                context.Writer.WritePropertyName("hostname");
                context.Writer.Write(requestObject.Hostname);
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.Write(requestObject.Image);
            }

            if(requestObject.IsSetInteractive())
            {
                context.Writer.WritePropertyName("interactive");
                context.Writer.Write(requestObject.Interactive);
            }

            if(requestObject.IsSetLinks())
            {
                context.Writer.WritePropertyName("links");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLinksListValue in requestObject.Links)
                {
                        context.Writer.Write(requestObjectLinksListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLinuxParameters())
            {
                context.Writer.WritePropertyName("linuxParameters");
                context.Writer.WriteObjectStart();

                var marshaller = LinuxParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("logConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("memory");
                context.Writer.Write(requestObject.Memory);
            }

            if(requestObject.IsSetMemoryReservation())
            {
                context.Writer.WritePropertyName("memoryReservation");
                context.Writer.Write(requestObject.MemoryReservation);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("mountPoints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPortMappings())
            {
                context.Writer.WritePropertyName("portMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPortMappingsListValue in requestObject.PortMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PortMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("privileged");
                context.Writer.Write(requestObject.Privileged);
            }

            if(requestObject.IsSetPseudoTerminal())
            {
                context.Writer.WritePropertyName("pseudoTerminal");
                context.Writer.Write(requestObject.PseudoTerminal);
            }

            if(requestObject.IsSetReadonlyRootFilesystem())
            {
                context.Writer.WritePropertyName("readonlyRootFilesystem");
                context.Writer.Write(requestObject.ReadonlyRootFilesystem);
            }

            if(requestObject.IsSetRepositoryCredentials())
            {
                context.Writer.WritePropertyName("repositoryCredentials");
                context.Writer.WriteObjectStart();

                var marshaller = RepositoryCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryCredentials, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("resourceRequirements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecrets())
            {
                context.Writer.WritePropertyName("secrets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecretsListValue in requestObject.Secrets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SecretMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStartTimeout())
            {
                context.Writer.WritePropertyName("startTimeout");
                context.Writer.Write(requestObject.StartTimeout);
            }

            if(requestObject.IsSetStopTimeout())
            {
                context.Writer.WritePropertyName("stopTimeout");
                context.Writer.Write(requestObject.StopTimeout);
            }

            if(requestObject.IsSetSystemControls())
            {
                context.Writer.WritePropertyName("systemControls");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSystemControlsListValue in requestObject.SystemControls)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SystemControlMarshaller.Instance;
                    marshaller.Marshall(requestObjectSystemControlsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUlimits())
            {
                context.Writer.WritePropertyName("ulimits");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUlimitsListValue in requestObject.Ulimits)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = UlimitMarshaller.Instance;
                    marshaller.Marshall(requestObjectUlimitsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.Write(requestObject.User);
            }

            if(requestObject.IsSetVolumesFrom())
            {
                context.Writer.WritePropertyName("volumesFrom");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVolumesFromListValue in requestObject.VolumesFrom)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VolumeFromMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesFromListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWorkingDirectory())
            {
                context.Writer.WritePropertyName("workingDirectory");
                context.Writer.Write(requestObject.WorkingDirectory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ContainerDefinitionMarshaller Instance = new ContainerDefinitionMarshaller();

    }
}