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
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _cpu;
        private List<AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails> _dependsOn = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails>() : null;
        private bool? _disableNetworking;
        private List<string> _dnsSearchDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _dnsServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _dockerLabels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _dockerSecurityOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _entryPoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetails> _environment = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetails>() : null;
        private List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetails> _environmentFiles = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetails>() : null;
        private bool? _essential;
        private List<AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetails> _extraHosts = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetails>() : null;
        private AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetails _firelensConfiguration;
        private AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetails _healthCheck;
        private string _hostname;
        private string _image;
        private bool? _interactive;
        private List<string> _links = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails _linuxParameters;
        private AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails _logConfiguration;
        private int? _memory;
        private int? _memoryReservation;
        private List<AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails> _mountPoints = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails>() : null;
        private string _name;
        private List<AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails> _portMappings = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails>() : null;
        private bool? _privileged;
        private bool? _pseudoTerminal;
        private bool? _readonlyRootFilesystem;
        private AwsEcsTaskDefinitionContainerDefinitionsRepositoryCredentialsDetails _repositoryCredentials;
        private List<AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetails> _resourceRequirements = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetails>() : null;
        private List<AwsEcsTaskDefinitionContainerDefinitionsSecretsDetails> _secrets = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsSecretsDetails>() : null;
        private int? _startTimeout;
        private int? _stopTimeout;
        private List<AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetails> _systemControls = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetails>() : null;
        private List<AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails> _ulimits = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails>() : null;
        private string _user;
        private List<AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails> _volumesFrom = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails>() : null;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that is passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units reserved for the container.
        /// </para>
        /// </summary>
        public int? Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// The dependencies that are defined for container startup and shutdown.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && (this._dependsOn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisableNetworking. 
        /// <para>
        /// Whether to disable networking within the container.
        /// </para>
        /// </summary>
        public bool? DisableNetworking
        {
            get { return this._disableNetworking; }
            set { this._disableNetworking = value; }
        }

        // Check to see if DisableNetworking property is set
        internal bool IsSetDisableNetworking()
        {
            return this._disableNetworking.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsSearchDomains. 
        /// <para>
        /// A list of DNS search domains that are presented to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsSearchDomains
        {
            get { return this._dnsSearchDomains; }
            set { this._dnsSearchDomains = value; }
        }

        // Check to see if DnsSearchDomains property is set
        internal bool IsSetDnsSearchDomains()
        {
            return this._dnsSearchDomains != null && (this._dnsSearchDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// A list of DNS servers that are presented to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }

        // Check to see if DnsServers property is set
        internal bool IsSetDnsServers()
        {
            return this._dnsServers != null && (this._dnsServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DockerLabels. 
        /// <para>
        /// A key-value map of labels to add to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DockerLabels
        {
            get { return this._dockerLabels; }
            set { this._dockerLabels = value; }
        }

        // Check to see if DockerLabels property is set
        internal bool IsSetDockerLabels()
        {
            return this._dockerLabels != null && (this._dockerLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DockerSecurityOptions. 
        /// <para>
        /// A list of strings to provide custom labels for SELinux and AppArmor multi-level security
        /// systems.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DockerSecurityOptions
        {
            get { return this._dockerSecurityOptions; }
            set { this._dockerSecurityOptions = value; }
        }

        // Check to see if DockerSecurityOptions property is set
        internal bool IsSetDockerSecurityOptions()
        {
            return this._dockerSecurityOptions != null && (this._dockerSecurityOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The entry point that is passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null && (this._entryPoint.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentDetails> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsEnvironmentFilesDetails> EnvironmentFiles
        {
            get { return this._environmentFiles; }
            set { this._environmentFiles = value; }
        }

        // Check to see if EnvironmentFiles property is set
        internal bool IsSetEnvironmentFiles()
        {
            return this._environmentFiles != null && (this._environmentFiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// Whether the container is essential. All tasks must have at least one essential container.
        /// </para>
        /// </summary>
        public bool? Essential
        {
            get { return this._essential; }
            set { this._essential = value; }
        }

        // Check to see if Essential property is set
        internal bool IsSetEssential()
        {
            return this._essential.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtraHosts. 
        /// <para>
        /// A list of hostnames and IP address mappings to append to the <b>/etc/hosts</b> file
        /// on the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsExtraHostsDetails> ExtraHosts
        {
            get { return this._extraHosts; }
            set { this._extraHosts = value; }
        }

        // Check to see if ExtraHosts property is set
        internal bool IsSetExtraHosts()
        {
            return this._extraHosts != null && (this._extraHosts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. Specifies and configures a log router
        /// for container logs.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetails FirelensConfiguration
        {
            get { return this._firelensConfiguration; }
            set { this._firelensConfiguration = value; }
        }

        // Check to see if FirelensConfiguration property is set
        internal bool IsSetFirelensConfiguration()
        {
            return this._firelensConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The container health check command and associated configuration parameters for the
        /// container.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetails HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname to use for the container.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start the container.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// If set to true, then containerized applications can be deployed that require <c>stdin</c>
        /// or a <c>tty</c> to be allocated.
        /// </para>
        /// </summary>
        public bool? Interactive
        {
            get { return this._interactive; }
            set { this._interactive = value; }
        }

        // Check to see if Interactive property is set
        internal bool IsSetInteractive()
        {
            return this._interactive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// A list of links for the container in the form <c> <i>container_name</i>:<i>alias</i>
        /// </c>. Allows containers to communicate with each other without the need for port mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Links
        {
            get { return this._links; }
            set { this._links = value; }
        }

        // Check to see if Links property is set
        internal bool IsSetLinks()
        {
            return this._links != null && (this._links.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as Linux kernel
        /// capabilities.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails LinuxParameters
        {
            get { return this._linuxParameters; }
            set { this._linuxParameters = value; }
        }

        // Check to see if LinuxParameters property is set
        internal bool IsSetLinuxParameters()
        {
            return this._linuxParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration specification for the container.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount (in MiB) of memory to present to the container. If the container attempts
        /// to exceed the memory specified here, the container is shut down. The total amount
        /// of memory reserved for all containers within a task must be lower than the task memory
        /// value, if one is specified.
        /// </para>
        /// </summary>
        public int? Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory to reserve for the container.
        /// </para>
        /// </summary>
        public int? MemoryReservation
        {
            get { return this._memoryReservation; }
            set { this._memoryReservation = value; }
        }

        // Check to see if MemoryReservation property is set
        internal bool IsSetMemoryReservation()
        {
            return this._memoryReservation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for the data volumes in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails> MountPoints
        {
            get { return this._mountPoints; }
            set { this._mountPoints = value; }
        }

        // Check to see if MountPoints property is set
        internal bool IsSetMountPoints()
        {
            return this._mountPoints != null && (this._mountPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PortMappings. 
        /// <para>
        /// The list of port mappings for the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails> PortMappings
        {
            get { return this._portMappings; }
            set { this._portMappings = value; }
        }

        // Check to see if PortMappings property is set
        internal bool IsSetPortMappings()
        {
            return this._portMappings != null && (this._portMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// Whether the container is given elevated privileges on the host container instance.
        /// The elevated privileges are similar to the root user.
        /// </para>
        /// </summary>
        public bool? Privileged
        {
            get { return this._privileged; }
            set { this._privileged = value; }
        }

        // Check to see if Privileged property is set
        internal bool IsSetPrivileged()
        {
            return this._privileged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PseudoTerminal. 
        /// <para>
        /// Whether to allocate a TTY to the container.
        /// </para>
        /// </summary>
        public bool? PseudoTerminal
        {
            get { return this._pseudoTerminal; }
            set { this._pseudoTerminal = value; }
        }

        // Check to see if PseudoTerminal property is set
        internal bool IsSetPseudoTerminal()
        {
            return this._pseudoTerminal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// Whether the container is given read-only access to its root file system.
        /// </para>
        /// </summary>
        public bool? ReadonlyRootFilesystem
        {
            get { return this._readonlyRootFilesystem; }
            set { this._readonlyRootFilesystem = value; }
        }

        // Check to see if ReadonlyRootFilesystem property is set
        internal bool IsSetReadonlyRootFilesystem()
        {
            return this._readonlyRootFilesystem.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RepositoryCredentials. 
        /// <para>
        /// The private repository authentication credentials to use.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsRepositoryCredentialsDetails RepositoryCredentials
        {
            get { return this._repositoryCredentials; }
            set { this._repositoryCredentials = value; }
        }

        // Check to see if RepositoryCredentials property is set
        internal bool IsSetRepositoryCredentials()
        {
            return this._repositoryCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of a resource to assign to a container. The only supported resource
        /// is a GPU.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsResourceRequirementsDetails> ResourceRequirements
        {
            get { return this._resourceRequirements; }
            set { this._resourceRequirements = value; }
        }

        // Check to see if ResourceRequirements property is set
        internal bool IsSetResourceRequirements()
        {
            return this._resourceRequirements != null && (this._resourceRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsSecretsDetails> Secrets
        {
            get { return this._secrets; }
            set { this._secrets = value; }
        }

        // Check to see if Secrets property is set
        internal bool IsSetSecrets()
        {
            return this._secrets != null && (this._secrets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTimeout. 
        /// <para>
        /// The number of seconds to wait before giving up on resolving dependencies for a container.
        /// 
        /// </para>
        /// </summary>
        public int? StartTimeout
        {
            get { return this._startTimeout; }
            set { this._startTimeout = value; }
        }

        // Check to see if StartTimeout property is set
        internal bool IsSetStartTimeout()
        {
            return this._startTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopTimeout. 
        /// <para>
        /// The number of seconds to wait before the container is stopped if it doesn't shut down
        /// normally on its own.
        /// </para>
        /// </summary>
        public int? StopTimeout
        {
            get { return this._stopTimeout; }
            set { this._stopTimeout = value; }
        }

        // Check to see if StopTimeout property is set
        internal bool IsSetStopTimeout()
        {
            return this._stopTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SystemControls. 
        /// <para>
        /// A list of namespaced kernel parameters to set in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsSystemControlsDetails> SystemControls
        {
            get { return this._systemControls; }
            set { this._systemControls = value; }
        }

        // Check to see if SystemControls property is set
        internal bool IsSetSystemControls()
        {
            return this._systemControls != null && (this._systemControls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of ulimits to set in the container. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails> Ulimits
        {
            get { return this._ulimits; }
            set { this._ulimits = value; }
        }

        // Check to see if Ulimits property is set
        internal bool IsSetUlimits()
        {
            return this._ulimits != null && (this._ulimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

        /// <summary>
        /// Gets and sets the property VolumesFrom. 
        /// <para>
        /// Data volumes to mount from another container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails> VolumesFrom
        {
            get { return this._volumesFrom; }
            set { this._volumesFrom = value; }
        }

        // Check to see if VolumesFrom property is set
        internal bool IsSetVolumesFrom()
        {
            return this._volumesFrom != null && (this._volumesFrom.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory in which to run commands inside the container.
        /// </para>
        /// </summary>
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}