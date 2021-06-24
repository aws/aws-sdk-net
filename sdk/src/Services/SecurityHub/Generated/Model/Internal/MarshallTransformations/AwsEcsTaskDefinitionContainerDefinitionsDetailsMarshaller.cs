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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.Write(requestObjectCommandListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("Cpu");
                context.Writer.Write(requestObject.Cpu);
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("DependsOn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDisableNetworking())
            {
                context.Writer.WritePropertyName("DisableNetworking");
                context.Writer.Write(requestObject.DisableNetworking);
            }

            if(requestObject.IsSetDnsSearchDomains())
            {
                context.Writer.WritePropertyName("DnsSearchDomains");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDnsSearchDomainsListValue in requestObject.DnsSearchDomains)
                {
                        context.Writer.Write(requestObjectDnsSearchDomainsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDnsServers())
            {
                context.Writer.WritePropertyName("DnsServers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDnsServersListValue in requestObject.DnsServers)
                {
                        context.Writer.Write(requestObjectDnsServersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDockerLabels())
            {
                context.Writer.WritePropertyName("DockerLabels");
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
                context.Writer.WritePropertyName("DockerSecurityOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDockerSecurityOptionsListValue in requestObject.DockerSecurityOptions)
                {
                        context.Writer.Write(requestObjectDockerSecurityOptionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntryPoint())
            {
                context.Writer.WritePropertyName("EntryPoint");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntryPointListValue in requestObject.EntryPoint)
                {
                        context.Writer.Write(requestObjectEntryPointListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironmentFiles())
            {
                context.Writer.WritePropertyName("EnvironmentFiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentFilesListValue in requestObject.EnvironmentFiles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentFilesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("Essential");
                context.Writer.Write(requestObject.Essential);
            }

            if(requestObject.IsSetExtraHosts())
            {
                context.Writer.WritePropertyName("ExtraHosts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExtraHostsListValue in requestObject.ExtraHosts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtraHostsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFirelensConfiguration())
            {
                context.Writer.WritePropertyName("FirelensConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.FirelensConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("HealthCheck");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHostname())
            {
                context.Writer.WritePropertyName("Hostname");
                context.Writer.Write(requestObject.Hostname);
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("Image");
                context.Writer.Write(requestObject.Image);
            }

            if(requestObject.IsSetInteractive())
            {
                context.Writer.WritePropertyName("Interactive");
                context.Writer.Write(requestObject.Interactive);
            }

            if(requestObject.IsSetLinks())
            {
                context.Writer.WritePropertyName("Links");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLinksListValue in requestObject.Links)
                {
                        context.Writer.Write(requestObjectLinksListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLinuxParameters())
            {
                context.Writer.WritePropertyName("LinuxParameters");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("LogConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("Memory");
                context.Writer.Write(requestObject.Memory);
            }

            if(requestObject.IsSetMemoryReservation())
            {
                context.Writer.WritePropertyName("MemoryReservation");
                context.Writer.Write(requestObject.MemoryReservation);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("MountPoints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPortMappings())
            {
                context.Writer.WritePropertyName("PortMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPortMappingsListValue in requestObject.PortMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("Privileged");
                context.Writer.Write(requestObject.Privileged);
            }

            if(requestObject.IsSetPseudoTerminal())
            {
                context.Writer.WritePropertyName("PseudoTerminal");
                context.Writer.Write(requestObject.PseudoTerminal);
            }

            if(requestObject.IsSetReadonlyRootFilesystem())
            {
                context.Writer.WritePropertyName("ReadonlyRootFilesystem");
                context.Writer.Write(requestObject.ReadonlyRootFilesystem);
            }

            if(requestObject.IsSetRepositoryCredentials())
            {
                context.Writer.WritePropertyName("RepositoryCredentials");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsRepositoryCredentialsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryCredentials, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("ResourceRequirements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecrets())
            {
                context.Writer.WritePropertyName("Secrets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecretsListValue in requestObject.Secrets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsSecretsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStartTimeout())
            {
                context.Writer.WritePropertyName("StartTimeout");
                context.Writer.Write(requestObject.StartTimeout);
            }

            if(requestObject.IsSetStopTimeout())
            {
                context.Writer.WritePropertyName("StopTimeout");
                context.Writer.Write(requestObject.StopTimeout);
            }

            if(requestObject.IsSetSystemControls())
            {
                context.Writer.WritePropertyName("SystemControls");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSystemControlsListValue in requestObject.SystemControls)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSystemControlsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUlimits())
            {
                context.Writer.WritePropertyName("Ulimits");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUlimitsListValue in requestObject.Ulimits)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectUlimitsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("User");
                context.Writer.Write(requestObject.User);
            }

            if(requestObject.IsSetVolumesFrom())
            {
                context.Writer.WritePropertyName("VolumesFrom");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVolumesFromListValue in requestObject.VolumesFrom)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesFromListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWorkingDirectory())
            {
                context.Writer.WritePropertyName("WorkingDirectory");
                context.Writer.Write(requestObject.WorkingDirectory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEcsTaskDefinitionContainerDefinitionsDetailsMarshaller Instance = new AwsEcsTaskDefinitionContainerDefinitionsDetailsMarshaller();

    }
}