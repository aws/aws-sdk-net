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
    /// Container properties are used for Amazon ECS based job definitions. These properties
    /// to describe the container that's launched as part of a job.
    /// </summary>
    public partial class ContainerProperties
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
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether execute command functionality is turned on for this task. If <c>true</c>,
        /// execute command functionality is turned on all the containers in the task.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand { get; set; }

        /// <summary>
        /// Checks to see if the EnableExecuteCommand property is set.
        /// </summary>
        internal bool IsSetEnableExecuteCommand() => this.EnableExecuteCommand.HasValue;

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
        ///  </important> <note> 
        /// <para>
        /// Environment variables cannot start with "<c>AWS_BATCH</c>". This naming convention
        /// is reserved for variables that Batch sets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The amount of ephemeral storage to allocate for the task. This parameter is used to
        /// expand the total amount of ephemeral storage available, beyond the default amount,
        /// for tasks hosted on Fargate.
        /// </para>
        /// </summary>
        public EphemeralStorage EphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the EphemeralStorage property is set.
        /// </summary>
        internal bool IsSetEphemeralStorage() => this.EphemeralStorage != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role that Batch can assume. For jobs
        /// that run on Fargate resources, you must provide an execution role. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/execution-IAM-role.html">Batch
        /// execution IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property FargatePlatformConfiguration. 
        /// <para>
        /// The platform configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on Amazon EC2 resources must not specify this parameter.
        /// </para>
        /// </summary>
        public FargatePlatformConfiguration FargatePlatformConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FargatePlatformConfiguration property is set.
        /// </summary>
        internal bool IsSetFargatePlatformConfiguration() => this.FargatePlatformConfiguration != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// Required. The image used to start a container. This string is passed directly to the
        /// Docker daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with <c> <i>repository-url</i>/<i>image</i>:<i>tag</i> </c>. It can
        /// be 255 characters long. It can contain uppercase and lowercase letters, numbers, hyphens
        /// (-), underscores (_), colons (:), periods (.), forward slashes (/), and number signs
        /// (#). This parameter maps to <c>Image</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>IMAGE</c> parameter of <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Docker image architecture must match the processor architecture of the compute resources
        /// that they're scheduled on. For example, ARM-based Docker images can only run on ARM-based
        /// compute resources.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// Images in Amazon ECR Public repositories use the full <c>registry/repository[:tag]</c>
        /// or <c>registry/repository[@digest]</c> naming conventions. For example, <c>public.ecr.aws/<i>registry_alias</i>/<i>my-web-app</i>:<i>latest</i>
        /// </c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in Amazon ECR repositories use the full registry and repository URI (for example,
        /// <c>123456789012.dkr.ecr.<region-name>.amazonaws.com/<repository-name></c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in official repositories on Docker Hub use a single name (for example, <c>ubuntu</c>
        /// or <c>mongo</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other repositories on Docker Hub are qualified with an organization name
        /// (for example, <c>amazon/amazon-ecs-agent</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other online repositories are qualified further by a domain name (for example,
        /// <c>quay.io/assemblyline/ubuntu</c>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use for a multi-node parallel job. All node groups in a multi-node
        /// parallel job must use the same instance type.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to single-node container jobs or jobs that run on
        /// Fargate resources, and shouldn't be provided.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property JobRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the container can assume for Amazon
        /// Web Services permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// roles for tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string JobRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the JobRoleArn property is set.
        /// </summary>
        internal bool IsSetJobRoleArn() => this.JobRoleArn != null;

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as details for
        /// device mappings.
        /// </para>
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
        /// Remote API</a> and the <c>--log-driver</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. By default, containers use the same logging driver that the Docker daemon
        /// uses. However the container might use a different logging driver than the Docker daemon
        /// by specifying a log driver with this parameter in the container definition. To use
        /// a different logging driver for a container, the log system must be configured properly
        /// on the container instance (or on a different log server for remote logging options).
        /// For more information on the options for different supported log drivers, see <a href="https://docs.docker.com/engine/admin/logging/overview/">Configure
        /// logging drivers</a> in the Docker documentation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Batch currently supports a subset of the logging drivers available to the Docker daemon
        /// (shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-logconfiguration.html">LogConfiguration</a>
        /// data type).
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <c>sudo docker version |
        /// grep "Server API version"</c> 
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
        /// Gets and sets the property Memory. 
        /// <para>
        /// This parameter is deprecated, use <c>resourceRequirements</c> to specify the memory
        /// requirements for the job definition. It's not supported for jobs running on Fargate
        /// resources. For jobs that run on Amazon EC2 resources, it specifies the memory hard
        /// limit (in MiB) for a container. If your container attempts to exceed the specified
        /// number, it's terminated. You must specify at least 4 MiB of memory for a job using
        /// this parameter. The memory hard limit can be specified in several places. It must
        /// be specified for each node at least once.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use resourceRequirements instead.")]
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container. This parameter maps to <c>Volumes</c>
        /// in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--volume</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on Amazon EC2 resources must not specify this parameter.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated permissions on the host
        /// container instance (similar to the <c>root</c> user). This parameter maps to <c>Privileged</c>
        /// in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--privileged</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. The default value is false.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources and
        /// shouldn't be provided, or specified as false.
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
        /// Remote API</a> and the <c>--read-only</c> option to <c>docker run</c>.
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
        public RepositoryCredentials RepositoryCredentials { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryCredentials property is set.
        /// </summary>
        internal bool IsSetRepositoryCredentials() => this.RepositoryCredentials != null;

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of resources to assign to a container. The supported resources
        /// include <c>GPU</c>, <c>MEMORY</c>, and <c>VCPU</c>.
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
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// An object that represents the compute environment architecture for Batch jobs on Fargate.
        /// </para>
        /// </summary>
        public RuntimePlatform RuntimePlatform { get; set; }

        /// <summary>
        /// Checks to see if the RuntimePlatform property is set.
        /// </summary>
        internal bool IsSetRuntimePlatform() => this.RuntimePlatform != null;

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets for the container. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/specifying-sensitive-data.html">Specifying
        /// sensitive data</a> in the <i>Batch User Guide</i>.
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
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <c>ulimits</c> to set in the container. This parameter maps to <c>Ulimits</c>
        /// in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--ulimit</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources and
        /// shouldn't be provided.
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
        /// The user name to use inside the container. This parameter maps to <c>User</c> in the
        /// <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--user</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;

        /// <summary>
        /// Gets and sets the property Vcpus. 
        /// <para>
        /// This parameter is deprecated, use <c>resourceRequirements</c> to specify the vCPU
        /// requirements for the job definition. It's not supported for jobs running on Fargate
        /// resources. For jobs running on Amazon EC2 resources, it specifies the number of vCPUs
        /// reserved for the job.
        /// </para>
        ///  
        /// <para>
        /// Each vCPU is equivalent to 1,024 CPU shares. This parameter maps to <c>CpuShares</c>
        /// in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/latest/">Docker
        /// Remote API</a> and the <c>--cpu-shares</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. The number of vCPUs must be specified but can be specified in several places.
        /// You must specify it at least once for each node.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use resourceRequirements instead.")]
        public int? Vcpus { get; set; }

        /// <summary>
        /// Checks to see if the Vcpus property is set.
        /// </summary>
        internal bool IsSetVcpus() => this.Vcpus.HasValue;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// A list of data volumes used in a job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Volume> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
