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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container definitions are used in task definitions to describe the different containers
    /// that are launched as part of a task.
    /// </summary>
    public partial class ContainerDefinition
    {
        private List<string> _command = new List<string>();
        private int? _cpu;
        private List<ContainerDependency> _dependsOn = new List<ContainerDependency>();
        private bool? _disableNetworking;
        private List<string> _dnsSearchDomains = new List<string>();
        private List<string> _dnsServers = new List<string>();
        private Dictionary<string, string> _dockerLabels = new Dictionary<string, string>();
        private List<string> _dockerSecurityOptions = new List<string>();
        private List<string> _entryPoint = new List<string>();
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
        private List<EnvironmentFile> _environmentFiles = new List<EnvironmentFile>();
        private bool? _essential;
        private List<HostEntry> _extraHosts = new List<HostEntry>();
        private FirelensConfiguration _firelensConfiguration;
        private HealthCheck _healthCheck;
        private string _hostname;
        private string _image;
        private bool? _interactive;
        private List<string> _links = new List<string>();
        private LinuxParameters _linuxParameters;
        private LogConfiguration _logConfiguration;
        private int? _memory;
        private int? _memoryReservation;
        private List<MountPoint> _mountPoints = new List<MountPoint>();
        private string _name;
        private List<PortMapping> _portMappings = new List<PortMapping>();
        private bool? _privileged;
        private bool? _pseudoTerminal;
        private bool? _readonlyRootFilesystem;
        private RepositoryCredentials _repositoryCredentials;
        private List<ResourceRequirement> _resourceRequirements = new List<ResourceRequirement>();
        private List<Secret> _secrets = new List<Secret>();
        private int? _startTimeout;
        private int? _stopTimeout;
        private List<SystemControl> _systemControls = new List<SystemControl>();
        private List<Ulimit> _ulimits = new List<Ulimit>();
        private string _user;
        private List<VolumeFrom> _volumesFrom = new List<VolumeFrom>();
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container. This parameter maps to <code>Cmd</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>COMMAND</code> parameter to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#cmd">https://docs.docker.com/engine/reference/builder/#cmd</a>.
        /// If there are multiple arguments, each argument is a separated string in the array.
        /// </para>
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && this._command.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of <code>cpu</code> units reserved for the container. This parameter maps
        /// to <code>CpuShares</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--cpu-shares</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// This field is optional for tasks using the Fargate launch type, and the only requirement
        /// is that the total amount of CPU reserved for all containers within a task be lower
        /// than the task-level <code>cpu</code> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can determine the number of CPU units that are available per EC2 instance type
        /// by multiplying the vCPUs listed for that instance type on the <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instances</a> detail page by 1,024.
        /// </para>
        ///  </note> 
        /// <para>
        /// Linux containers share unallocated CPU units with other containers on the container
        /// instance with the same ratio as their allocated amount. For example, if you run a
        /// single-container task on a single-core instance type with 512 CPU units specified
        /// for that container, and that's the only task running on the container instance, that
        /// container could use the full 1,024 CPU unit share at any given time. However, if you
        /// launched another copy of the same task on that container instance, each task is guaranteed
        /// a minimum of 512 CPU units when needed. Moreover, each container could float to higher
        /// CPU usage if the other container was not using it. If both tasks were 100% active
        /// all of the time, they would be limited to 512 CPU units.
        /// </para>
        ///  
        /// <para>
        /// On Linux container instances, the Docker daemon on the container instance uses the
        /// CPU value to calculate the relative CPU share ratios for running containers. For more
        /// information, see <a href="https://docs.docker.com/engine/reference/run/#cpu-share-constraint">CPU
        /// share constraint</a> in the Docker documentation. The minimum valid CPU share value
        /// that the Linux kernel allows is 2. However, the CPU parameter isn't required, and
        /// you can use CPU values below 2 in your container definitions. For CPU values below
        /// 2 (including null), the behavior varies based on your Amazon ECS container agent version:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Agent versions less than or equal to 1.1.0:</b> Null and zero CPU values are passed
        /// to Docker as 0, which Docker then converts to 1,024 CPU shares. CPU values of 1 are
        /// passed to Docker as 1, which the Linux kernel converts to two CPU shares.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Agent versions greater than or equal to 1.2.0:</b> Null, zero, and CPU values
        /// of 1 are passed to Docker as 2.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// On Windows container instances, the CPU limit is enforced as an absolute limit, or
        /// a quota. Windows containers only have access to the specified amount of CPU that's
        /// described in the task definition. A null or zero CPU value is passed to Docker as
        /// <code>0</code>, which Windows interprets as 1% of one CPU.
        /// </para>
        /// </summary>
        public int Cpu
        {
            get { return this._cpu.GetValueOrDefault(); }
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
        /// The dependencies defined for container startup and shutdown. A container can contain
        /// multiple dependencies on other containers in a task definition. When a dependency
        /// is defined for container startup, for container shutdown it is reversed.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the EC2 launch type, the container instances require at least version
        /// 1.26.0 of the container agent to turn on container dependencies. However, we recommend
        /// using the latest container agent version. For information about checking your agent
        /// version and updating to the latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
        /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
        /// at least version 1.26.0-1 of the <code>ecs-init</code> package. If your container
        /// instances are launched from version <code>20190301</code> or later, then they contain
        /// the required versions of the container agent and <code>ecs-init</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the Fargate launch type, the task or service requires the following
        /// platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <code>1.3.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <code>1.0.0</code> or later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<ContainerDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisableNetworking. 
        /// <para>
        /// When this parameter is true, networking is disabled within the container. This parameter
        /// maps to <code>NetworkDisabled</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public bool DisableNetworking
        {
            get { return this._disableNetworking.GetValueOrDefault(); }
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
        /// A list of DNS search domains that are presented to the container. This parameter maps
        /// to <code>DnsSearch</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--dns-search</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> DnsSearchDomains
        {
            get { return this._dnsSearchDomains; }
            set { this._dnsSearchDomains = value; }
        }

        // Check to see if DnsSearchDomains property is set
        internal bool IsSetDnsSearchDomains()
        {
            return this._dnsSearchDomains != null && this._dnsSearchDomains.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// A list of DNS servers that are presented to the container. This parameter maps to
        /// <code>Dns</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--dns</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }

        // Check to see if DnsServers property is set
        internal bool IsSetDnsServers()
        {
            return this._dnsServers != null && this._dnsServers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DockerLabels. 
        /// <para>
        /// A key/value map of labels to add to the container. This parameter maps to <code>Labels</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--label</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. This parameter requires version 1.18 of the Docker Remote API or greater
        /// on your container instance. To check the Docker Remote API version on your container
        /// instance, log in to your container instance and run the following command: <code>sudo
        /// docker version --format '{{.Server.APIVersion}}'</code> 
        /// </para>
        /// </summary>
        public Dictionary<string, string> DockerLabels
        {
            get { return this._dockerLabels; }
            set { this._dockerLabels = value; }
        }

        // Check to see if DockerLabels property is set
        internal bool IsSetDockerLabels()
        {
            return this._dockerLabels != null && this._dockerLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DockerSecurityOptions. 
        /// <para>
        /// A list of strings to provide custom labels for SELinux and AppArmor multi-level security
        /// systems. This field isn't valid for containers in tasks using the Fargate launch type.
        /// </para>
        ///  
        /// <para>
        /// With Windows containers, this parameter can be used to reference a credential spec
        /// file when configuring a container for Active Directory authentication. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/windows-gmsa.html">Using
        /// gMSAs for Windows Containers</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <code>SecurityOpt</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--security-opt</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent running on a container instance must register with
        /// the <code>ECS_SELINUX_CAPABLE=true</code> or <code>ECS_APPARMOR_CAPABLE=true</code>
        /// environment variables before containers placed on that instance can use these security
        /// options. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about valid values, see <a href="https://docs.docker.com/engine/reference/run/#security-configuration">Docker
        /// Run Security Configuration</a>. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: "no-new-privileges" | "apparmor:PROFILE" | "label:value" | "credentialspec:CredentialSpecFilePath"
        /// </para>
        /// </summary>
        public List<string> DockerSecurityOptions
        {
            get { return this._dockerSecurityOptions; }
            set { this._dockerSecurityOptions = value; }
        }

        // Check to see if DockerSecurityOptions property is set
        internal bool IsSetDockerSecurityOptions()
        {
            return this._dockerSecurityOptions != null && this._dockerSecurityOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. <important> 
        /// <para>
        /// Early versions of the Amazon ECS container agent don't properly handle <code>entryPoint</code>
        /// parameters. If you have problems using <code>entryPoint</code>, update your container
        /// agent or enter your commands and arguments as <code>command</code> array items instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// The entry point that's passed to the container. This parameter maps to <code>Entrypoint</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--entrypoint</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#entrypoint">https://docs.docker.com/engine/reference/builder/#entrypoint</a>.
        /// </para>
        /// </summary>
        public List<string> EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null && this._entryPoint.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container. This parameter maps to <code>Env</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--env</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We don't recommend that you use plaintext environment variables for sensitive information,
        /// such as credential data.
        /// </para>
        ///  </important>
        /// </summary>
        public List<KeyValuePair> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container. This
        /// parameter maps to the <code>--env-file</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to ten environment files. The file must have a <code>.env</code>
        /// file extension. Each line in an environment file contains an environment variable
        /// in <code>VARIABLE=VALUE</code> format. Lines beginning with <code>#</code> are treated
        /// as comments and are ignored. For more information about the environment variable file
        /// syntax, see <a href="https://docs.docker.com/compose/env-file/">Declare default environment
        /// variables in file</a>.
        /// </para>
        ///  
        /// <para>
        /// If there are environment variables specified using the <code>environment</code> parameter
        /// in a container definition, they take precedence over the variables contained within
        /// an environment file. If multiple environment files are specified that contain the
        /// same variable, they're processed from the top down. We recommend that you use unique
        /// variable names. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/taskdef-envfiles.html">Specifying
        /// Environment Variables</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<EnvironmentFile> EnvironmentFiles
        {
            get { return this._environmentFiles; }
            set { this._environmentFiles = value; }
        }

        // Check to see if EnvironmentFiles property is set
        internal bool IsSetEnvironmentFiles()
        {
            return this._environmentFiles != null && this._environmentFiles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// If the <code>essential</code> parameter of a container is marked as <code>true</code>,
        /// and that container fails or stops for any reason, all other containers that are part
        /// of the task are stopped. If the <code>essential</code> parameter of a container is
        /// marked as <code>false</code>, its failure doesn't affect the rest of the containers
        /// in a task. If this parameter is omitted, a container is assumed to be essential.
        /// </para>
        ///  
        /// <para>
        /// All tasks must have at least one essential container. If you have an application that's
        /// composed of multiple containers, group containers that are used for a common purpose
        /// into components, and separate the different components into multiple task definitions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/application_architecture.html">Application
        /// Architecture</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool Essential
        {
            get { return this._essential.GetValueOrDefault(); }
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
        /// A list of hostnames and IP address mappings to append to the <code>/etc/hosts</code>
        /// file on the container. This parameter maps to <code>ExtraHosts</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--add-host</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't supported for Windows containers or tasks that use the <code>awsvpc</code>
        /// network mode.
        /// </para>
        ///  </note>
        /// </summary>
        public List<HostEntry> ExtraHosts
        {
            get { return this._extraHosts; }
            set { this._extraHosts = value; }
        }

        // Check to see if ExtraHosts property is set
        internal bool IsSetExtraHosts()
        {
            return this._extraHosts != null && this._extraHosts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. This is used to specify and configure
        /// a log router for container logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
        /// Log Routing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public FirelensConfiguration FirelensConfiguration
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
        /// container. This parameter maps to <code>HealthCheck</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>HEALTHCHECK</code> parameter of <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public HealthCheck HealthCheck
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
        /// The hostname to use for your container. This parameter maps to <code>Hostname</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--hostname</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>hostname</code> parameter is not supported if you're using the <code>awsvpc</code>
        /// network mode.
        /// </para>
        ///  </note>
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
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. By default, images in the Docker Hub registry are available. Other repositories
        /// are specified with either <code> <i>repository-url</i>/<i>image</i>:<i>tag</i> </code>
        /// or <code> <i>repository-url</i>/<i>image</i>@<i>digest</i> </code>. Up to 255 letters
        /// (uppercase and lowercase), numbers, hyphens, underscores, colons, periods, forward
        /// slashes, and number signs are allowed. This parameter maps to <code>Image</code> in
        /// the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>IMAGE</code> parameter of <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When a new task starts, the Amazon ECS container agent pulls the latest version of
        /// the specified image and tag for the container to use. However, subsequent updates
        /// to a repository image aren't propagated to already running tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in Amazon ECR repositories can be specified by either using the full <code>registry/repository:tag</code>
        /// or <code>registry/repository@digest</code>. For example, <code>012345678910.dkr.ecr.&lt;region-name&gt;.amazonaws.com/&lt;repository-name&gt;:latest</code>
        /// or <code>012345678910.dkr.ecr.&lt;region-name&gt;.amazonaws.com/&lt;repository-name&gt;@sha256:94afd1f2e64d908bc90dbca0035a5b567EXAMPLE</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in official repositories on Docker Hub use a single name (for example, <code>ubuntu</code>
        /// or <code>mongo</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other repositories on Docker Hub are qualified with an organization name
        /// (for example, <code>amazon/amazon-ecs-agent</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other online repositories are qualified further by a domain name (for example,
        /// <code>quay.io/assemblyline/ubuntu</code>).
        /// </para>
        ///  </li> </ul>
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
        /// When this parameter is <code>true</code>, you can deploy containerized applications
        /// that require <code>stdin</code> or a <code>tty</code> to be allocated. This parameter
        /// maps to <code>OpenStdin</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--interactive</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public bool Interactive
        {
            get { return this._interactive.GetValueOrDefault(); }
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
        /// The <code>links</code> parameter allows containers to communicate with each other
        /// without the need for port mappings. This parameter is only supported if the network
        /// mode of a task definition is <code>bridge</code>. The <code>name:internalName</code>
        /// construct is analogous to <code>name:alias</code> in Docker links. Up to 255 letters
        /// (uppercase and lowercase), numbers, underscores, and hyphens are allowed. For more
        /// information about linking Docker containers, go to <a href="https://docs.docker.com/network/links/">Legacy
        /// container links</a> in the Docker documentation. This parameter maps to <code>Links</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--link</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Containers that are collocated on a single container instance may be able to communicate
        /// with each other without requiring links or host port mappings. Network isolation is
        /// achieved on the container instance using security groups and VPC settings.
        /// </para>
        ///  </important>
        /// </summary>
        public List<string> Links
        {
            get { return this._links; }
            set { this._links = value; }
        }

        // Check to see if Links property is set
        internal bool IsSetLinks()
        {
            return this._links != null && this._links.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as Linux kernel
        /// capabilities. For more information see <a>KernelCapabilities</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public LinuxParameters LinuxParameters
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
        ///  
        /// <para>
        /// This parameter maps to <code>LogConfig</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--log-driver</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. By default, containers use the same logging driver that the Docker daemon
        /// uses. However the container can use a different logging driver than the Docker daemon
        /// by specifying a log driver with this parameter in the container definition. To use
        /// a different logging driver for a container, the log system must be configured properly
        /// on the container instance (or on a different log server for remote logging options).
        /// For more information about the options for different supported log drivers, see <a
        /// href="https://docs.docker.com/engine/admin/logging/overview/">Configure logging drivers</a>
        /// in the Docker documentation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon ECS currently supports a subset of the logging drivers available to the Docker
        /// daemon (shown in the <a>LogConfiguration</a> data type). Additional log drivers may
        /// be available in future releases of the Amazon ECS container agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <code>sudo docker version
        /// --format '{{.Server.APIVersion}}'</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent running on a container instance must register the logging
        /// drivers available on that instance with the <code>ECS_AVAILABLE_LOGGING_DRIVERS</code>
        /// environment variable before containers placed on that instance can use these log configuration
        /// options. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public LogConfiguration LogConfiguration
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
        /// The amount (in MiB) of memory to present to the container. If your container attempts
        /// to exceed the memory specified here, the container is killed. The total amount of
        /// memory reserved for all containers within a task must be lower than the task <code>memory</code>
        /// value, if one is specified. This parameter maps to <code>Memory</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--memory</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// If using the Fargate launch type, this parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If using the EC2 launch type, you must specify either a task-level memory value or
        /// a container-level memory value. If you specify both a container-level <code>memory</code>
        /// and <code>memoryReservation</code> value, <code>memory</code> must be greater than
        /// <code>memoryReservation</code>. If you specify <code>memoryReservation</code>, then
        /// that value is subtracted from the available memory resources for the container instance
        /// where the container is placed. Otherwise, the value of <code>memory</code> is used.
        /// </para>
        ///  
        /// <para>
        /// The Docker 20.10.0 or later daemon reserves a minimum of 6 MiB of memory for a container.
        /// So, don't specify less than 6 MiB of memory for your containers. 
        /// </para>
        ///  
        /// <para>
        /// The Docker 19.03.13-ce or earlier daemon reserves a minimum of 4 MiB of memory for
        /// a container. So, don't specify less than 4 MiB of memory for your containers.
        /// </para>
        /// </summary>
        public int Memory
        {
            get { return this._memory.GetValueOrDefault(); }
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
        /// The soft limit (in MiB) of memory to reserve for the container. When system memory
        /// is under heavy contention, Docker attempts to keep the container memory to this soft
        /// limit. However, your container can consume more memory when it needs to, up to either
        /// the hard limit specified with the <code>memory</code> parameter (if applicable), or
        /// all of the available memory on the container instance, whichever comes first. This
        /// parameter maps to <code>MemoryReservation</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--memory-reservation</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// If a task-level memory value is not specified, you must specify a non-zero integer
        /// for one or both of <code>memory</code> or <code>memoryReservation</code> in a container
        /// definition. If you specify both, <code>memory</code> must be greater than <code>memoryReservation</code>.
        /// If you specify <code>memoryReservation</code>, then that value is subtracted from
        /// the available memory resources for the container instance where the container is placed.
        /// Otherwise, the value of <code>memory</code> is used.
        /// </para>
        ///  
        /// <para>
        /// For example, if your container normally uses 128 MiB of memory, but occasionally bursts
        /// to 256 MiB of memory for short periods of time, you can set a <code>memoryReservation</code>
        /// of 128 MiB, and a <code>memory</code> hard limit of 300 MiB. This configuration would
        /// allow the container to only reserve 128 MiB of memory from the remaining resources
        /// on the container instance, but also allow the container to consume more memory resources
        /// when needed.
        /// </para>
        ///  
        /// <para>
        /// The Docker 20.10.0 or later daemon reserves a minimum of 6 MiB of memory for a container.
        /// So, don't specify less than 6 MiB of memory for your containers. 
        /// </para>
        ///  
        /// <para>
        /// The Docker 19.03.13-ce or earlier daemon reserves a minimum of 4 MiB of memory for
        /// a container. So, don't specify less than 4 MiB of memory for your containers.
        /// </para>
        /// </summary>
        public int MemoryReservation
        {
            get { return this._memoryReservation.GetValueOrDefault(); }
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
        /// The mount points for data volumes in your container.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <code>Volumes</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--volume</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// Windows containers can mount whole directories on the same drive as <code>$env:ProgramData</code>.
        /// Windows containers can't mount directories on a different drive, and mount point can't
        /// be across drives.
        /// </para>
        /// </summary>
        public List<MountPoint> MountPoints
        {
            get { return this._mountPoints; }
            set { this._mountPoints = value; }
        }

        // Check to see if MountPoints property is set
        internal bool IsSetMountPoints()
        {
            return this._mountPoints != null && this._mountPoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a container. If you're linking multiple containers together in a task
        /// definition, the <code>name</code> of one container can be entered in the <code>links</code>
        /// of another container to connect the containers. Up to 255 letters (uppercase and lowercase),
        /// numbers, underscores, and hyphens are allowed. This parameter maps to <code>name</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--name</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. 
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
        /// The list of port mappings for the container. Port mappings allow containers to access
        /// ports on the host container instance to send or receive traffic.
        /// </para>
        ///  
        /// <para>
        /// For task definitions that use the <code>awsvpc</code> network mode, only specify the
        /// <code>containerPort</code>. The <code>hostPort</code> can be left blank or it must
        /// be the same value as the <code>containerPort</code>.
        /// </para>
        ///  
        /// <para>
        /// Port mappings on Windows use the <code>NetNAT</code> gateway address rather than <code>localhost</code>.
        /// There's no loopback for port mappings on Windows, so you can't access a container's
        /// mapped port from the host itself. 
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <code>PortBindings</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--publish</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. If the network mode of a task definition is set to <code>none</code>, then
        /// you can't specify port mappings. If the network mode of a task definition is set to
        /// <code>host</code>, then host ports must either be undefined or they must match the
        /// container port in the port mapping.
        /// </para>
        ///  <note> 
        /// <para>
        /// After a task reaches the <code>RUNNING</code> status, manual and automatic host and
        /// container port assignments are visible in the <b>Network Bindings</b> section of a
        /// container description for a selected task in the Amazon ECS console. The assignments
        /// are also visible in the <code>networkBindings</code> section <a>DescribeTasks</a>
        /// responses.
        /// </para>
        ///  </note>
        /// </summary>
        public List<PortMapping> PortMappings
        {
            get { return this._portMappings; }
            set { this._portMappings = value; }
        }

        // Check to see if PortMappings property is set
        internal bool IsSetPortMappings()
        {
            return this._portMappings != null && this._portMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated privileges on the host
        /// container instance (similar to the <code>root</code> user). This parameter maps to
        /// <code>Privileged</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--privileged</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers or tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public bool Privileged
        {
            get { return this._privileged.GetValueOrDefault(); }
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
        /// When this parameter is <code>true</code>, a TTY is allocated. This parameter maps
        /// to <code>Tty</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--tty</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public bool PseudoTerminal
        {
            get { return this._pseudoTerminal.GetValueOrDefault(); }
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
        /// When this parameter is true, the container is given read-only access to its root file
        /// system. This parameter maps to <code>ReadonlyRootfs</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--read-only</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public bool ReadonlyRootFilesystem
        {
            get { return this._readonlyRootFilesystem.GetValueOrDefault(); }
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
        public RepositoryCredentials RepositoryCredentials
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
        /// </summary>
        public List<ResourceRequirement> ResourceRequirements
        {
            get { return this._resourceRequirements; }
            set { this._resourceRequirements = value; }
        }

        // Check to see if ResourceRequirements property is set
        internal bool IsSetResourceRequirements()
        {
            return this._resourceRequirements != null && this._resourceRequirements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<Secret> Secrets
        {
            get { return this._secrets; }
            set { this._secrets = value; }
        }

        // Check to see if Secrets property is set
        internal bool IsSetSecrets()
        {
            return this._secrets != null && this._secrets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeout. 
        /// <para>
        /// Time duration (in seconds) to wait before giving up on resolving dependencies for
        /// a container. For example, you specify two containers in a task definition with containerA
        /// having a dependency on containerB reaching a <code>COMPLETE</code>, <code>SUCCESS</code>,
        /// or <code>HEALTHY</code> status. If a <code>startTimeout</code> value is specified
        /// for containerB and it doesn't reach the desired status within that time then containerA
        /// gives up and not start. This results in the task transitioning to a <code>STOPPED</code>
        /// state.
        /// </para>
        ///  <note> 
        /// <para>
        /// When the <code>ECS_CONTAINER_START_TIMEOUT</code> container agent configuration variable
        /// is used, it's enforced independently from this start timeout value.
        /// </para>
        ///  </note> 
        /// <para>
        /// For tasks using the Fargate launch type, the task or service requires the following
        /// platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <code>1.3.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <code>1.0.0</code> or later.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For tasks using the EC2 launch type, your container instances require at least version
        /// <code>1.26.0</code> of the container agent to use a container start timeout value.
        /// However, we recommend using the latest container agent version. For information about
        /// checking your agent version and updating to the latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
        /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
        /// at least version <code>1.26.0-1</code> of the <code>ecs-init</code> package. If your
        /// container instances are launched from version <code>20190301</code> or later, then
        /// they contain the required versions of the container agent and <code>ecs-init</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public int StartTimeout
        {
            get { return this._startTimeout.GetValueOrDefault(); }
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
        /// Time duration (in seconds) to wait before the container is forcefully killed if it
        /// doesn't exit normally on its own.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the Fargate launch type, the task or service requires the following
        /// platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <code>1.3.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <code>1.0.0</code> or later.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The max stop timeout value is 120 seconds and if the parameter is not specified, the
        /// default value of 30 seconds is used.
        /// </para>
        ///  
        /// <para>
        /// For tasks that use the EC2 launch type, if the <code>stopTimeout</code> parameter
        /// isn't specified, the value set for the Amazon ECS container agent configuration variable
        /// <code>ECS_CONTAINER_STOP_TIMEOUT</code> is used. If neither the <code>stopTimeout</code>
        /// parameter or the <code>ECS_CONTAINER_STOP_TIMEOUT</code> agent configuration variable
        /// are set, then the default values of 30 seconds for Linux containers and 30 seconds
        /// on Windows containers are used. Your container instances require at least version
        /// 1.26.0 of the container agent to use a container stop timeout value. However, we recommend
        /// using the latest container agent version. For information about checking your agent
        /// version and updating to the latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
        /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
        /// at least version 1.26.0-1 of the <code>ecs-init</code> package. If your container
        /// instances are launched from version <code>20190301</code> or later, then they contain
        /// the required versions of the container agent and <code>ecs-init</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public int StopTimeout
        {
            get { return this._stopTimeout.GetValueOrDefault(); }
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
        /// A list of namespaced kernel parameters to set in the container. This parameter maps
        /// to <code>Sysctls</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--sysctl</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// We don't recommended that you specify network-related <code>systemControls</code>
        /// parameters for multiple containers in a single task that also uses either the <code>awsvpc</code>
        /// or <code>host</code> network modes. For tasks that use the <code>awsvpc</code> network
        /// mode, the container that's started last determines which <code>systemControls</code>
        /// parameters take effect. For tasks that use the <code>host</code> network mode, it
        /// changes the container instance's namespaced kernel parameters as well as the containers.
        /// </para>
        ///  </note>
        /// </summary>
        public List<SystemControl> SystemControls
        {
            get { return this._systemControls; }
            set { this._systemControls = value; }
        }

        // Check to see if SystemControls property is set
        internal bool IsSetSystemControls()
        {
            return this._systemControls != null && this._systemControls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <code>ulimits</code> to set in the container. If a <code>ulimit</code> value
        /// is specified in a task definition, it overrides the default values set by Docker.
        /// This parameter maps to <code>Ulimits</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--ulimit</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. Valid naming values are displayed in the <a>Ulimit</a> data type.
        /// </para>
        ///  
        /// <para>
        /// Amazon ECS tasks hosted on Fargate use the default resource limit values set by the
        /// operating system with the exception of the <code>nofile</code> resource limit parameter
        /// which Fargate overrides. The <code>nofile</code> resource limit sets a restriction
        /// on the number of open files that a container can use. The default <code>nofile</code>
        /// soft limit is <code>1024</code> and hard limit is <code>4096</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <code>sudo docker version
        /// --format '{{.Server.APIVersion}}'</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Ulimit> Ulimits
        {
            get { return this._ulimits; }
            set { this._ulimits = value; }
        }

        // Check to see if Ulimits property is set
        internal bool IsSetUlimits()
        {
            return this._ulimits != null && this._ulimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user to use inside the container. This parameter maps to <code>User</code> in
        /// the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--user</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// When running tasks using the <code>host</code> network mode, don't run containers
        /// using the root user (UID 0). We recommend using a non-root user for better security.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can specify the <code>user</code> using the following formats. If specifying a
        /// UID or GID, you must specify it as a positive integer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>user</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>user:group</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uid</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uid:gid</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>user:gid</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uid:group</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
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
        /// Data volumes to mount from another container. This parameter maps to <code>VolumesFrom</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--volumes-from</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public List<VolumeFrom> VolumesFrom
        {
            get { return this._volumesFrom; }
            set { this._volumesFrom = value; }
        }

        // Check to see if VolumesFrom property is set
        internal bool IsSetVolumesFrom()
        {
            return this._volumesFrom != null && this._volumesFrom.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory to run commands inside the container in. This parameter maps
        /// to <code>WorkingDir</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--workdir</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
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