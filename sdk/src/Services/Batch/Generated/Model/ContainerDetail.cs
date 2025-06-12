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
    /// An object that represents the details of a container that's part of a job.
    /// </summary>
    public partial class ContainerDetail
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _containerInstanceArn;
        private bool? _enableExecuteCommand;
        private List<KeyValuePair> _environment = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private EphemeralStorage _ephemeralStorage;
        private string _executionRoleArn;
        private int? _exitCode;
        private FargatePlatformConfiguration _fargatePlatformConfiguration;
        private string _image;
        private string _instanceType;
        private string _jobRoleArn;
        private LinuxParameters _linuxParameters;
        private LogConfiguration _logConfiguration;
        private string _logStreamName;
        private int? _memory;
        private List<MountPoint> _mountPoints = AWSConfigs.InitializeCollections ? new List<MountPoint>() : null;
        private NetworkConfiguration _networkConfiguration;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private bool? _privileged;
        private bool? _readonlyRootFilesystem;
        private string _reason;
        private RepositoryCredentials _repositoryCredentials;
        private List<ResourceRequirement> _resourceRequirements = AWSConfigs.InitializeCollections ? new List<ResourceRequirement>() : null;
        private RuntimePlatform _runtimePlatform;
        private List<Secret> _secrets = AWSConfigs.InitializeCollections ? new List<Secret>() : null;
        private string _taskArn;
        private List<Ulimit> _ulimits = AWSConfigs.InitializeCollections ? new List<Ulimit>() : null;
        private string _user;
        private int? _vcpus;
        private List<Volume> _volumes = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

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
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance that the container is running
        /// on.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn
        {
            get { return this._containerInstanceArn; }
            set { this._containerInstanceArn = value; }
        }

        // Check to see if ContainerInstanceArn property is set
        internal bool IsSetContainerInstanceArn()
        {
            return this._containerInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether execute command functionality is turned on for this task. If <c>true</c>,
        /// execute command functionality is turned on all the containers in the task.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand
        {
            get { return this._enableExecuteCommand; }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        ///  <note> 
        /// <para>
        /// Environment variables cannot start with "<c>AWS_BATCH</c>". This naming convention
        /// is reserved for variables that Batch sets.
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The amount of ephemeral storage allocated for the task. This parameter is used to
        /// expand the total amount of ephemeral storage available, beyond the default amount,
        /// for tasks hosted on Fargate.
        /// </para>
        /// </summary>
        public EphemeralStorage EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role that Batch can assume. For more
        /// information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/execution-IAM-role.html">Batch
        /// execution IAM role</a> in the <i>Batch User Guide</i>.
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
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned upon completion.
        /// </para>
        /// </summary>
        public int? ExitCode
        {
            get { return this._exitCode; }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FargatePlatformConfiguration. 
        /// <para>
        /// The platform configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on Amazon EC2 resources must not specify this parameter.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the underlying host infrastructure of a multi-node parallel job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources.
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
        /// The Amazon Resource Name (ARN) that's associated with the job when run.
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
        /// This parameter maps to <c>LogConfig</c> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--log-driver</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. By default, containers use the same logging driver that the Docker daemon
        /// uses. However, the container might use a different logging driver than the Docker
        /// daemon by specifying a log driver with this parameter in the container definition.
        /// To use a different logging driver for a container, the log system must be configured
        /// properly on the container instance. Or, alternatively, it must be configured on a
        /// different log server for remote logging options. For more information on the options
        /// for different supported log drivers, see <a href="https://docs.docker.com/engine/admin/logging/overview/">Configure
        /// logging drivers</a> in the Docker documentation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Batch currently supports a subset of the logging drivers available to the Docker daemon
        /// (shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-logconfiguration.html">LogConfiguration</a>
        /// data type). Additional log drivers might be available in future releases of the Amazon
        /// ECS container agent.
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
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the Amazon CloudWatch Logs log stream that's associated with the container.
        /// The log group for Batch jobs is <c>/aws/batch/job</c>. Each container attempt receives
        /// a log stream name when they reach the <c>RUNNING</c> status.
        /// </para>
        /// </summary>
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// For jobs running on Amazon EC2 resources that didn't specify memory requirements using
        /// <c>resourceRequirements</c>, the number of MiB of memory reserved for the job. For
        /// other jobs, including all run on Fargate resources, see <c>resourceRequirements</c>.
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on Amazon EC2 resources must not specify this parameter.
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
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces that are associated with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated permissions on the host
        /// container instance (similar to the <c>root</c> user). The default value is <c>false</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources and
        /// shouldn't be provided, or specified as <c>false</c>.
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
        /// system. This parameter maps to <c>ReadonlyRootfs</c> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--read-only</c> option to <a href="https://docs.docker.com/engine/reference/commandline/run/">
        /// <c>docker run</c> </a>.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (255 max characters) human-readable string to provide additional details for
        /// a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
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
        /// The type and amount of resources to assign to a container. The supported resources
        /// include <c>GPU</c>, <c>MEMORY</c>, and <c>VCPU</c>.
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
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// An object that represents the compute environment architecture for Batch jobs on Fargate.
        /// </para>
        /// </summary>
        public RuntimePlatform RuntimePlatform
        {
            get { return this._runtimePlatform; }
            set { this._runtimePlatform = value; }
        }

        // Check to see if RuntimePlatform property is set
        internal bool IsSetRuntimePlatform()
        {
            return this._runtimePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/specifying-sensitive-data.html">Specifying
        /// sensitive data</a> in the <i>Batch User Guide</i>.
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon ECS task that's associated with the container
        /// job. Each container attempt receives a task ARN when they reach the <c>STARTING</c>
        /// status.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <c>ulimit</c> values to set in the container. This parameter maps to <c>Ulimits</c>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--ulimit</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources.
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
        /// The user name to use inside the container. This parameter maps to <c>User</c> in the
        /// <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create a container</a>
        /// section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker Remote API</a>
        /// and the <c>--user</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
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
        /// The number of vCPUs reserved for the container. For jobs that run on Amazon EC2 resources,
        /// you can specify the vCPU requirement for the job using <c>resourceRequirements</c>,
        /// but you can't specify the vCPU requirements in both the <c>vcpus</c> and <c>resourceRequirements</c>
        /// object. This parameter maps to <c>CpuShares</c> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--cpu-shares</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. You must specify at least one
        /// vCPU. This is required but can be specified in several places. It must be specified
        /// for each node at least once.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that run on Fargate resources. For jobs that
        /// run on Fargate resources, you must specify the vCPU requirement for the job using
        /// <c>resourceRequirements</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public int? Vcpus
        {
            get { return this._vcpus; }
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
        /// A list of volumes that are associated with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}