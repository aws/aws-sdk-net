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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The details for the container in this task attempt.
    /// </summary>
    public partial class TaskContainerDetails
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container. This parameter maps to <c>Cmd</c> in the
        /// <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>COMMAND</c> parameter to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#cmd">https://docs.docker.com/engine/reference/builder/#cmd</a>.
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
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of containers that this container depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskContainerDependency> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskContainerDependency>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container. This parameter maps to <c>Env</c>
        /// in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--env</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We don't recommend using plaintext environment variables for sensitive information,
        /// such as credential data.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Environment { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public bool? Essential { get; set; }

        /// <summary>
        /// Checks to see if the Essential property is set.
        /// </summary>
        internal bool IsSetEssential() => this.Essential.HasValue;

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned upon completion.
        /// </para>
        /// </summary>
        public int? ExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ExitCode property is set.
        /// </summary>
        internal bool IsSetExitCode() => this.ExitCode.HasValue;

        /// <summary>
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. This is used to specify and configure
        /// a log router for container logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
        /// log</a> routing in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public FirelensConfiguration FirelensConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FirelensConfiguration property is set.
        /// </summary>
        internal bool IsSetFirelensConfiguration() => this.FirelensConfiguration != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. By default, images in the Docker Hub registry are available. Other repositories
        /// are specified with either <c>repository-url/image:tag</c> or <c>repository-url/image@digest</c>.
        /// Up to 255 letters (uppercase and lowercase), numbers, hyphens, underscores, colons,
        /// periods, forward slashes, and number signs are allowed. This parameter maps to <c>Image</c>
        /// in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>IMAGE</c> parameter of the <a href="https://docs.docker.com/engine/reference/run/#security-configuration">
        /// <i>docker run</i> </a>.
        /// </para>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as Linux kernel
        /// capabilities. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html">KernelCapabilities</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public LinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// Checks to see if the LinuxParameters property is set.
        /// </summary>
        internal bool IsSetLinuxParameters() => this.LinuxParameters != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration specification for the container.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>LogConfig</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
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
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the CloudWatch Logs log stream that's associated with the container. The
        /// log group for Batch jobs is /aws/batch/job. Each container attempt receives a log
        /// stream name when they reach the <c>RUNNING</c> status. 
        /// </para>
        /// </summary>
        public string LogStreamName { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamName property is set.
        /// </summary>
        internal bool IsSetLogStreamName() => this.LogStreamName != null;

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>Volumes</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MountPoint> MountPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<MountPoint>() : null;

        /// <summary>
        /// Checks to see if the MountPoints property is set.
        /// </summary>
        internal bool IsSetMountPoints() => this.MountPoints != null && (this.MountPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a container.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces that are associated with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is <c>true</c>, the container is given elevated privileges on
        /// the host container instance (similar to the <c>root</c> user). This parameter maps
        /// to <c>Privileged</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--privileged</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers or tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// When this parameter is true, the container is given read-only access to its root file
        /// system. This parameter maps to <c>ReadonlyRootfs</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--read-only</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// Checks to see if the ReadonlyRootFilesystem property is set.
        /// </summary>
        internal bool IsSetReadonlyRootFilesystem() => this.ReadonlyRootFilesystem.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (255 max characters) human-readable string to provide additional details for
        /// a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property RepositoryCredentials. 
        /// <para>
        /// The private repository authentication credentials to use.
        /// </para>
        /// </summary>
        public RepositoryCredentials RepositoryCredentials { get; set; }

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
        public List<ResourceRequirement> ResourceRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceRequirement>() : null;

        /// <summary>
        /// Checks to see if the ResourceRequirements property is set.
        /// </summary>
        internal bool IsSetResourceRequirements() => this.ResourceRequirements != null && (this.ResourceRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the Amazon Elastic Container Service Developer Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> Secrets { get; set; } = AWSConfigs.InitializeCollections ? new List<Secret>() : null;

        /// <summary>
        /// Checks to see if the Secrets property is set.
        /// </summary>
        internal bool IsSetSecrets() => this.Secrets != null && (this.Secrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTimeout. 
        /// <para>
        /// Time duration (in seconds) to wait before giving up on resolving dependencies for
        /// a container. The minimum value is 2 seconds and the maximum value for Fargate is 120
        /// seconds.
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
        /// Time duration (in seconds) to wait before the container is forcefully killed if it
        /// doesn't exit normally on its own. The minimum value is 2 seconds and the maximum value
        /// for Fargate is 120 seconds. If the parameter is not specified, the default value of
        /// 30 seconds is used. For tasks that use the EC2 launch type, if the <c>stopTimeout</c>
        /// parameter isn't specified, the value set for the Amazon ECS container agent configuration
        /// variable <c>ECS_CONTAINER_STOP_TIMEOUT</c> is used. If neither the <c>stopTimeout</c>
        /// parameter nor the <c>ECS_CONTAINER_STOP_TIMEOUT</c> agent configuration variable are
        /// set, then the default value of 30 seconds is used.
        /// </para>
        /// </summary>
        public int? StopTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StopTimeout property is set.
        /// </summary>
        internal bool IsSetStopTimeout() => this.StopTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <c>ulimits</c> to set in the container. If a <c>ulimit</c> value is specified
        /// in a task definition, it overrides the default values set by Docker. This parameter
        /// maps to <c>Ulimits</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ulimit> Ulimits { get; set; } = AWSConfigs.InitializeCollections ? new List<Ulimit>() : null;

        /// <summary>
        /// Checks to see if the Ulimits property is set.
        /// </summary>
        internal bool IsSetUlimits() => this.Ulimits != null && (this.Ulimits.Count > 0 || !AWSConfigs.InitializeCollections);

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
        ///  </li> <li> 
        /// <para>
        ///  <c></c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
