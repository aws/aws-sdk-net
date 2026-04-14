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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// A container definition for a daemon task. Daemon container definitions describe the
    /// containers that run as part of a daemon task on container instances managed by capacity
    /// providers.
    /// </summary>
    public partial class DaemonContainerDefinition
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _cpu;
        private List<ContainerDependency> _dependsOn = AWSConfigs.InitializeCollections ? new List<ContainerDependency>() : null;
        private List<string> _entryPoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<KeyValuePair> _environment = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private List<EnvironmentFile> _environmentFiles = AWSConfigs.InitializeCollections ? new List<EnvironmentFile>() : null;
        private bool? _essential;
        private FirelensConfiguration _firelensConfiguration;
        private HealthCheck _healthCheck;
        private string _image;
        private bool? _interactive;
        private DaemonLinuxParameters _linuxParameters;
        private LogConfiguration _logConfiguration;
        private int? _memory;
        private int? _memoryReservation;
        private List<MountPoint> _mountPoints = AWSConfigs.InitializeCollections ? new List<MountPoint>() : null;
        private string _name;
        private bool? _privileged;
        private bool? _pseudoTerminal;
        private bool? _readonlyRootFilesystem;
        private RepositoryCredentials _repositoryCredentials;
        private ContainerRestartPolicy _restartPolicy;
        private List<Secret> _secrets = AWSConfigs.InitializeCollections ? new List<Secret>() : null;
        private int? _startTimeout;
        private int? _stopTimeout;
        private List<SystemControl> _systemControls = AWSConfigs.InitializeCollections ? new List<SystemControl>() : null;
        private List<Ulimit> _ulimits = AWSConfigs.InitializeCollections ? new List<Ulimit>() : null;
        private string _user;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container.
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
        /// The number of <c>cpu</c> units reserved for the container.
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
        /// The dependencies defined for container startup and shutdown. A container can contain
        /// multiple dependencies on other containers in a task definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerDependency> DependsOn
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
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The entry point that's passed to the container.
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
        [AWSProperty(Sensitive=true)]
        public List<KeyValuePair> Environment
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
        public List<EnvironmentFile> EnvironmentFiles
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
        /// If the <c>essential</c> parameter of a container is marked as <c>true</c>, and that
        /// container fails or stops for any reason, all other containers that are part of the
        /// task are stopped.
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
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. This is used to specify and configure
        /// a log router for container logs.
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
        /// container.
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
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start the container. This string is passed directly to the Docker
        /// daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with either <c> <i>repository-url</i>/<i>image</i>:<i>tag</i> </c> or
        /// <c> <i>repository-url</i>/<i>image</i>@<i>digest</i> </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// When this parameter is <c>true</c>, you can deploy containerized applications that
        /// require <c>stdin</c> or a <c>tty</c> to be allocated.
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
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container configuration, such
        /// as Linux kernel capabilities.
        /// </para>
        /// </summary>
        public DaemonLinuxParameters LinuxParameters
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
        /// The amount (in MiB) of memory to present to the container. If the container attempts
        /// to exceed the memory specified here, the container is killed.
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
        /// The mount points for data volumes in your container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MountPoint> MountPoints
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
        /// The name of the container. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed.
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
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated privileges on the host
        /// container instance (similar to the <c>root</c> user).
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
        /// When this parameter is <c>true</c>, a TTY is allocated.
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
        /// When this parameter is true, the container is given read-only access to its root file
        /// system.
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
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property RestartPolicy. 
        /// <para>
        /// The restart policy for the container. When you set up a restart policy, Amazon ECS
        /// can restart the container without needing to replace the task.
        /// </para>
        /// </summary>
        public ContainerRestartPolicy RestartPolicy
        {
            get { return this._restartPolicy; }
            set { this._restartPolicy = value; }
        }

        // Check to see if RestartPolicy property is set
        internal bool IsSetRestartPolicy()
        {
            return this._restartPolicy != null;
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
        public List<Secret> Secrets
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
        /// Time duration (in seconds) to wait before giving up on resolving dependencies for
        /// a container.
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
        /// Time duration (in seconds) to wait before the container is forcefully killed if it
        /// doesn't exit normally on its own.
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
        public List<SystemControl> SystemControls
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
        /// A list of <c>ulimits</c> to set in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ulimit> Ulimits
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
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory to run commands inside the container in.
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