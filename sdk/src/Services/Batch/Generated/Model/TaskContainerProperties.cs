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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container properties are used for Amazon ECS-based job definitions. These properties
    /// to describe the container that's launched as part of a job.
    /// </summary>
    public partial class TaskContainerProperties
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TaskContainerDependency> _dependsOn = AWSConfigs.InitializeCollections ? new List<TaskContainerDependency>() : null;
        private List<KeyValuePair> _environment = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private bool? _essential;
        private FirelensConfiguration _firelensConfiguration;
        private string _image;
        private LinuxParameters _linuxParameters;
        private LogConfiguration _logConfiguration;
        private List<MountPoint> _mountPoints = AWSConfigs.InitializeCollections ? new List<MountPoint>() : null;
        private string _name;
        private bool? _privileged;
        private bool? _readonlyRootFilesystem;
        private RepositoryCredentials _repositoryCredentials;
        private List<ResourceRequirement> _resourceRequirements = AWSConfigs.InitializeCollections ? new List<ResourceRequirement>() : null;
        private List<Secret> _secrets = AWSConfigs.InitializeCollections ? new List<Secret>() : null;
        private List<Ulimit> _ulimits = AWSConfigs.InitializeCollections ? new List<Ulimit>() : null;
        private string _user;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container. This parameter maps to <c>Cmd</c> in the
        /// <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create a container</a>
        /// section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker Remote API</a>
        /// and the <c>COMMAND</c> parameter to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#cmd">Dockerfile
        /// reference: CMD</a>.
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
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of containers that this container depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskContainerDependency> DependsOn
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container. This parameter maps to Env in the
        /// <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create a container</a>
        /// section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker Remote API</a>
        /// and the <c>--env</c> parameter to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// We don't recommend using plaintext environment variables for sensitive information,
        /// such as credential data.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Environment variables cannot start with <c>AWS_BATCH</c>. This naming convention is
        /// reserved for variables that Batch sets.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Essential. 
        /// <para>
        /// If the essential parameter of a container is marked as <c>true</c>, and that container
        /// fails or stops for any reason, all other containers that are part of the task are
        /// stopped. If the <c>essential</c> parameter of a container is marked as false, its
        /// failure doesn't affect the rest of the containers in a task. If this parameter is
        /// omitted, a container is assumed to be essential.
        /// </para>
        ///  
        /// <para>
        /// All jobs must have at least one essential container. If you have an application that's
        /// composed of multiple containers, group containers that are used for a common purpose
        /// into components, and separate the different components into multiple task definitions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/application_architecture.html">Application
        /// Architecture</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// a log router for container logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
        /// log</a> routing in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. By default, images in the Docker Hub registry are available. Other repositories
        /// are specified with either <c>repository-url/image:tag</c> or <c>repository-url/image@digest</c>.
        /// Up to 255 letters (uppercase and lowercase), numbers, hyphens, underscores, colons,
        /// periods, forward slashes, and number signs are allowed. This parameter maps to <c>Image</c>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <c>IMAGE</c> parameter of the <a href="https://docs.docker.com/engine/reference/run/#security-configuration">
        /// <i>docker run</i> </a>.
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
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as Linux kernel
        /// capabilities. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html">KernelCapabilities</a>.
        /// </para>
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
        /// This parameter maps to <c>LogConfig</c> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <c>--log-driver</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, containers use the same logging driver that the Docker daemon uses. However
        /// the container can use a different logging driver than the Docker daemon by specifying
        /// a log driver with this parameter in the container definition. To use a different logging
        /// driver for a container, the log system must be configured properly on the container
        /// instance (or on a different log server for remote logging options). For more information
        /// about the options for different supported log drivers, see <a href="https://docs.docker.com/engine/admin/logging/overview/">Configure
        /// logging drivers </a> in the <i>Docker documentation</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon ECS currently supports a subset of the logging drivers available to the Docker
        /// daemon (shown in the <c>LogConfiguration</c> data type). Additional log drivers may
        /// be available in future releases of the Amazon ECS container agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: sudo docker version <c>--format
        /// '{{.Server.APIVersion}}'</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent running on a container instance must register the logging
        /// drivers available on that instance with the <c>ECS_AVAILABLE_LOGGING_DRIVERS</c> environment
        /// variable before containers placed on that instance can use these log configuration
        /// options. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS container agent configuration</a> in the <i>Amazon Elastic Container Service Developer
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
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>Volumes</c> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <a href="">--volume</a> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// Windows containers can mount whole directories on the same drive as <c>$env:ProgramData</c>.
        /// Windows containers can't mount directories on a different drive, and mount point can't
        /// be across drives.
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
        /// The name of a container. The name can be used as a unique identifier to target your
        /// <c>dependsOn</c> and <c>Overrides</c> objects. 
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
        /// When this parameter is <c>true</c>, the container is given elevated privileges on
        /// the host container instance (similar to the <c>root</c> user). This parameter maps
        /// to <c>Privileged</c> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <c>--privileged</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers or tasks run on Fargate.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// When this parameter is true, the container is given read-only access to its root file
        /// system. This parameter maps to <c>ReadonlyRootfs</c> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <c>--read-only</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceRequirement> ResourceRequirements
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
        /// The secrets to pass to the container. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the Amazon Elastic Container Service Developer Guide.
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
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <c>ulimits</c> to set in the container. If a <c>ulimit</c> value is specified
        /// in a task definition, it overrides the default values set by Docker. This parameter
        /// maps to <c>Ulimits</c> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <c>--ulimit</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon ECS tasks hosted on Fargate use the default resource limit values set by the
        /// operating system with the exception of the nofile resource limit parameter which Fargate
        /// overrides. The <c>nofile</c> resource limit sets a restriction on the number of open
        /// files that a container can use. The default <c>nofile</c> soft limit is <c>1024</c>
        /// and the default hard limit is <c>65535</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: sudo docker version <c>--format
        /// '{{.Server.APIVersion}}'</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
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
        /// The user to use inside the container. This parameter maps to User in the Create a
        /// container section of the Docker Remote API and the --user option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// When running tasks using the <c>host</c> network mode, don't run containers using
        /// the <c>root user (UID 0)</c>. We recommend using a non-root user for better security.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify the <c>user</c> using the following formats. If specifying a UID or
        /// GID, you must specify it as a positive integer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>user</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>user:group</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uid</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uid:gid</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>user:gi</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uid:group</c> 
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

    }
}