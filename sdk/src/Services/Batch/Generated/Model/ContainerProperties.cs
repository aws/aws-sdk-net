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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container properties are used in job definitions to describe the container that's
    /// launched as part of a job.
    /// </summary>
    public partial class ContainerProperties
    {
        private List<string> _command = new List<string>();
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
        private string _executionRoleArn;
        private FargatePlatformConfiguration _fargatePlatformConfiguration;
        private string _image;
        private string _instanceType;
        private string _jobRoleArn;
        private LinuxParameters _linuxParameters;
        private LogConfiguration _logConfiguration;
        private int? _memory;
        private List<MountPoint> _mountPoints = new List<MountPoint>();
        private NetworkConfiguration _networkConfiguration;
        private bool? _privileged;
        private bool? _readonlyRootFilesystem;
        private List<ResourceRequirement> _resourceRequirements = new List<ResourceRequirement>();
        private List<Secret> _secrets = new List<Secret>();
        private List<Ulimit> _ulimits = new List<Ulimit>();
        private string _user;
        private int? _vcpus;
        private List<Volume> _volumes = new List<Volume>();

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container. This parameter maps to <code>Cmd</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>COMMAND</code> parameter to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#cmd">https://docs.docker.com/engine/reference/builder/#cmd</a>.
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container. This parameter maps to <code>Env</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--env</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We don't recommend using plaintext environment variables for sensitive information,
        /// such as credential data.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Environment variables must not start with <code>AWS_BATCH</code>; this naming convention
        /// is reserved for variables that are set by the AWS Batch service.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role that AWS Batch can assume. Jobs
        /// running on Fargate resources must provide an execution role. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/execution-IAM-role.html">AWS
        /// Batch execution IAM role</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FargatePlatformConfiguration. 
        /// <para>
        /// The platform configuration for jobs running on Fargate resources. Jobs running on
        /// EC2 resources must not specify this parameter.
        /// </para>
        /// </summary>
        public FargatePlatformConfiguration FargatePlatformConfiguration
        {
            get { return this._fargatePlatformConfiguration; }
            set { this._fargatePlatformConfiguration = value; }
        }

        // Check to see if FargatePlatformConfiguration property is set
        internal bool IsSetFargatePlatformConfiguration()
        {
            return this._fargatePlatformConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with <code> <i>repository-url</i>/<i>image</i>:<i>tag</i> </code>. Up
        /// to 255 letters (uppercase and lowercase), numbers, hyphens, underscores, colons, periods,
        /// forward slashes, and number signs are allowed. This parameter maps to <code>Image</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>IMAGE</code> parameter of <a href="https://docs.docker.com/engine/reference/run/">docker
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
        /// Images in Amazon ECR repositories use the full registry and repository URI (for example,
        /// <code>012345678910.dkr.ecr.&lt;region-name&gt;.amazonaws.com/&lt;repository-name&gt;</code>).
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use for a multi-node parallel job. All node groups in a multi-node
        /// parallel job must use the same instance type.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to single-node container jobs or for jobs running
        /// on Fargate resources and shouldn't be provided.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property JobRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the container can assume for AWS
        /// permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string JobRoleArn
        {
            get { return this._jobRoleArn; }
            set { this._jobRoleArn = value; }
        }

        // Check to see if JobRoleArn property is set
        internal bool IsSetJobRoleArn()
        {
            return this._jobRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container, such as details for
        /// device mappings.
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
        /// This parameter maps to <code>LogConfig</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--log-driver</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
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
        /// AWS Batch currently supports a subset of the logging drivers available to the Docker
        /// daemon (shown in the <a>LogConfiguration</a> data type).
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log into
        /// your container instance and run the following command: <code>sudo docker version |
        /// grep "Server API version"</code> 
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
        /// This parameter is deprecated and not supported for jobs run on Fargate resources,
        /// use <code>ResourceRequirement</code>. For jobs run on EC2 resources can specify the
        /// memory requirement using the <code>ResourceRequirement</code> structure. The hard
        /// limit (in MiB) of memory to present to the container. If your container attempts to
        /// exceed the memory specified here, the container is killed. This parameter maps to
        /// <code>Memory</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--memory</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. You must specify at least 4 MiB of memory for a job. This is required but
        /// can be specified in several places; it must be specified for each node at least once.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're trying to maximize your resource utilization by providing your jobs as much
        /// memory as possible for a particular instance type, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/memory-management.html">Memory
        /// Management</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("This field is deprecated, use resourceRequirements instead.")]
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
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container. This parameter maps to <code>Volumes</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--volume</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for jobs running on Fargate resources. Jobs running on EC2
        /// resources must not specify this parameter.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated permissions on the host
        /// container instance (similar to the <code>root</code> user). This parameter maps to
        /// <code>Privileged</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--privileged</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. The default value is false.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided, or specified as false.
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
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// When this parameter is true, the container is given read-only access to its root file
        /// system. This parameter maps to <code>ReadonlyRootfs</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--read-only</code> option to <code>docker run</code>.
        /// </para>
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
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of resources to assign to a container. The supported resources
        /// include <code>GPU</code>, <code>MEMORY</code>, and <code>VCPU</code>.
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
        /// The secrets for the container. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/specifying-sensitive-data.html">Specifying
        /// sensitive data</a> in the <i>AWS Batch User Guide</i>.
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
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <code>ulimits</code> to set in the container. This parameter maps to <code>Ulimits</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--ulimit</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
        /// The user name to use inside the container. This parameter maps to <code>User</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--user</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
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
        /// Gets and sets the property Vcpus. 
        /// <para>
        /// This parameter is deprecated and not supported for jobs run on Fargate resources,
        /// see <code>resourceRequirement</code>. The number of vCPUs reserved for the container.
        /// Jobs running on EC2 resources can specify the vCPU requirement for the job using <code>resourceRequirements</code>
        /// but the vCPU requirements can't be specified both here and in the <code>resourceRequirement</code>
        /// structure. This parameter maps to <code>CpuShares</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--cpu-shares</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. You must specify at least one
        /// vCPU. This is required but can be specified in several places. It must be specified
        /// for each node at least once.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided. Jobs running on Fargate resources must specify the vCPU requirement for
        /// the job using <code>resourceRequirements</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("This field is deprecated, use resourceRequirements instead.")]
        public int Vcpus
        {
            get { return this._vcpus.GetValueOrDefault(); }
            set { this._vcpus = value; }
        }

        // Check to see if Vcpus property is set
        internal bool IsSetVcpus()
        {
            return this._vcpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// A list of data volumes used in a job.
        /// </para>
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && this._volumes.Count > 0; 
        }

    }
}