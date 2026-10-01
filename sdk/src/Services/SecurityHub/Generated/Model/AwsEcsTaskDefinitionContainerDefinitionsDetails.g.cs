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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A container definition that describes a container in the task.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsDetails
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that is passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null && (this.Command.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units reserved for the container.
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// The dependencies that are defined for container startup and shutdown.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisableNetworking. 
        /// <para>
        /// Whether to disable networking within the container.
        /// </para>
        /// </summary>
        public bool? DisableNetworking { get; set; }

        /// <summary>
        /// Checks to see if the DisableNetworking property is set.
        /// </summary>
        internal bool IsSetDisableNetworking() => this.DisableNetworking.HasValue;

        /// <summary>
        /// Gets and sets the property DnsSearchDomains. 
        /// <para>
        /// A list of DNS search domains that are presented to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsSearchDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsSearchDomains property is set.
        /// </summary>
        internal bool IsSetDnsSearchDomains() => this.DnsSearchDomains != null && (this.DnsSearchDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// A list of DNS servers that are presented to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsServers property is set.
        /// </summary>
        internal bool IsSetDnsServers() => this.DnsServers != null && (this.DnsServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DockerLabels. 
        /// <para>
        /// A key-value map of labels to add to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DockerLabels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DockerLabels property is set.
        /// </summary>
        internal bool IsSetDockerLabels() => this.DockerLabels != null && (this.DockerLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DockerSecurityOptions. 
        /// <para>
        /// A list of strings to provide custom labels for SELinux and AppArmor multi-level security
        /// systems.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DockerSecurityOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DockerSecurityOptions property is set.
        /// </summary>
        internal bool IsSetDockerSecurityOptions() => this.DockerSecurityOptions != null && (this.DockerSecurityOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The entry point that is passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntryPoint { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntryPoint property is set.
        /// </summary>
        internal bool IsSetEntryPoint() => this.EntryPoint != null && (this.EntryPoint.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetails> Environment { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetails>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetails> EnvironmentFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetails>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentFiles property is set.
        /// </summary>
        internal bool IsSetEnvironmentFiles() => this.EnvironmentFiles != null && (this.EnvironmentFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// Whether the container is essential. All tasks must have at least one essential container.
        /// </para>
        /// </summary>
        public bool? Essential { get; set; }

        /// <summary>
        /// Checks to see if the Essential property is set.
        /// </summary>
        internal bool IsSetEssential() => this.Essential.HasValue;

        /// <summary>
        /// Gets and sets the property ExtraHosts. 
        /// <para>
        /// A list of hostnames and IP address mappings to append to the <b>/etc/hosts</b> file
        /// on the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetails> ExtraHosts { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetails>() : null;

        /// <summary>
        /// Checks to see if the ExtraHosts property is set.
        /// </summary>
        internal bool IsSetExtraHosts() => this.ExtraHosts != null && (this.ExtraHosts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. Specifies and configures a log router
        /// for container logs.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetails FirelensConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FirelensConfiguration property is set.
        /// </summary>
        internal bool IsSetFirelensConfiguration() => this.FirelensConfiguration != null;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The container health check command and associated configuration parameters for the
        /// container.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetails HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname to use for the container.
        /// </para>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start the container.
        /// </para>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// If set to true, then containerized applications can be deployed that require <c>stdin</c>
        /// or a <c>tty</c> to be allocated.
        /// </para>
        /// </summary>
        public bool? Interactive { get; set; }

        /// <summary>
        /// Checks to see if the Interactive property is set.
        /// </summary>
        internal bool IsSetInteractive() => this.Interactive.HasValue;

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// A list of links for the container in the form <c> <i>container_name</i>:<i>alias</i>
        /// </c>. Allows containers to communicate with each other without the need for port mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Links { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Links property is set.
        /// </summary>
        internal bool IsSetLinks() => this.Links != null && (this.Links.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as Linux kernel
        /// capabilities.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails LinuxParameters { get; set; }

        /// <summary>
        /// Checks to see if the LinuxParameters property is set.
        /// </summary>
        internal bool IsSetLinuxParameters() => this.LinuxParameters != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration specification for the container.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount (in MiB) of memory to present to the container. If the container attempts
        /// to exceed the memory specified here, the container is shut down. The total amount
        /// of memory reserved for all containers within a task must be lower than the task memory
        /// value, if one is specified.
        /// </para>
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory to reserve for the container.
        /// </para>
        /// </summary>
        public int? MemoryReservation { get; set; }

        /// <summary>
        /// Checks to see if the MemoryReservation property is set.
        /// </summary>
        internal bool IsSetMemoryReservation() => this.MemoryReservation.HasValue;

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for the data volumes in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails> MountPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails>() : null;

        /// <summary>
        /// Checks to see if the MountPoints property is set.
        /// </summary>
        internal bool IsSetMountPoints() => this.MountPoints != null && (this.MountPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PortMappings. 
        /// <para>
        /// The list of port mappings for the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails> PortMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails>() : null;

        /// <summary>
        /// Checks to see if the PortMappings property is set.
        /// </summary>
        internal bool IsSetPortMappings() => this.PortMappings != null && (this.PortMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// Whether the container is given elevated privileges on the host container instance.
        /// The elevated privileges are similar to the root user.
        /// </para>
        /// </summary>
        public bool? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property PseudoTerminal. 
        /// <para>
        /// Whether to allocate a TTY to the container.
        /// </para>
        /// </summary>
        public bool? PseudoTerminal { get; set; }

        /// <summary>
        /// Checks to see if the PseudoTerminal property is set.
        /// </summary>
        internal bool IsSetPseudoTerminal() => this.PseudoTerminal.HasValue;

        /// <summary>
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// Whether the container is given read-only access to its root file system.
        /// </para>
        /// </summary>
        public bool? ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// Checks to see if the ReadonlyRootFilesystem property is set.
        /// </summary>
        internal bool IsSetReadonlyRootFilesystem() => this.ReadonlyRootFilesystem.HasValue;

        /// <summary>
        /// Gets and sets the property RepositoryCredentials. 
        /// <para>
        /// The private repository authentication credentials to use.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsRepositoryCredentialsDetails RepositoryCredentials { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryCredentials property is set.
        /// </summary>
        internal bool IsSetRepositoryCredentials() => this.RepositoryCredentials != null;

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of a resource to assign to a container. The only supported resource
        /// is a GPU.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetails> ResourceRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetails>() : null;

        /// <summary>
        /// Checks to see if the ResourceRequirements property is set.
        /// </summary>
        internal bool IsSetResourceRequirements() => this.ResourceRequirements != null && (this.ResourceRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsSecretsDetails> Secrets { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsSecretsDetails>() : null;

        /// <summary>
        /// Checks to see if the Secrets property is set.
        /// </summary>
        internal bool IsSetSecrets() => this.Secrets != null && (this.Secrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTimeout. 
        /// <para>
        /// The number of seconds to wait before giving up on resolving dependencies for a container.
        /// 
        /// </para>
        /// </summary>
        public int? StartTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeout property is set.
        /// </summary>
        internal bool IsSetStartTimeout() => this.StartTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property StopTimeout. 
        /// <para>
        /// The number of seconds to wait before the container is stopped if it doesn't shut down
        /// normally on its own.
        /// </para>
        /// </summary>
        public int? StopTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StopTimeout property is set.
        /// </summary>
        internal bool IsSetStopTimeout() => this.StopTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property SystemControls. 
        /// <para>
        /// A list of namespaced kernel parameters to set in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetails> SystemControls { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetails>() : null;

        /// <summary>
        /// Checks to see if the SystemControls property is set.
        /// </summary>
        internal bool IsSetSystemControls() => this.SystemControls != null && (this.SystemControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of ulimits to set in the container. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails> Ulimits { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails>() : null;

        /// <summary>
        /// Checks to see if the Ulimits property is set.
        /// </summary>
        internal bool IsSetUlimits() => this.Ulimits != null && (this.Ulimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user to use inside the container.
        /// </para>
        ///  
        /// <para>
        /// The value can use one of the following formats.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c> <i>user</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>user</i> </c>:<c> <i>group</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>uid</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>uid</i> </c>:<c> <i>gid</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>user</i> </c>:<c> <i>gid</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>uid</i> </c>:<c> <i>group</i> </c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;

        /// <summary>
        /// Gets and sets the property VolumesFrom. 
        /// <para>
        /// Data volumes to mount from another container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails> VolumesFrom { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails>() : null;

        /// <summary>
        /// Checks to see if the VolumesFrom property is set.
        /// </summary>
        internal bool IsSetVolumesFrom() => this.VolumesFrom != null && (this.VolumesFrom.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory in which to run commands inside the container.
        /// </para>
        /// </summary>
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
