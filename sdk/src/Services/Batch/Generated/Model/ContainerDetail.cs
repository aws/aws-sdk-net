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
    /// An object that represents the details of a container that's part of a job.
    /// </summary>
    public partial class ContainerDetail
    {
        private List<string> _command = new List<string>();
        private string _containerInstanceArn;
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
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
        private List<MountPoint> _mountPoints = new List<MountPoint>();
        private NetworkConfiguration _networkConfiguration;
        private List<NetworkInterface> _networkInterfaces = new List<NetworkInterface>();
        private bool? _privileged;
        private bool? _readonlyRootFilesystem;
        private string _reason;
        private List<ResourceRequirement> _resourceRequirements = new List<ResourceRequirement>();
        private List<Secret> _secrets = new List<Secret>();
        private string _taskArn;
        private List<Ulimit> _ulimits = new List<Ulimit>();
        private string _user;
        private int? _vcpus;
        private List<Volume> _volumes = new List<Volume>();

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container.
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        ///  <note> 
        /// <para>
        /// Environment variables cannot start with "<code>AWS_BATCH</code>". This naming convention
        /// is reserved for variables that Batch sets.
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
        /// Gets and sets the property EphemeralStorage.
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
        /// The exit code to return upon completion.
        /// </para>
        /// </summary>
        public int ExitCode
        {
            get { return this._exitCode.GetValueOrDefault(); }
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
        /// are running on EC2 resources must not specify this parameter.
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
        /// This parameter maps to <code>LogConfig</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--log-driver</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
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
        /// (shown in the <a>LogConfiguration</a> data type). Additional log drivers might be
        /// available in future releases of the Amazon ECS container agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <code>sudo docker version
        /// | grep "Server API version"</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent running on a container instance must register the logging
        /// drivers available on that instance with the <code>ECS_AVAILABLE_LOGGING_DRIVERS</code>
        /// environment variable before containers placed on that instance can use these log configuration
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
        /// The log group for Batch jobs is <code>/aws/batch/job</code>. Each container attempt
        /// receives a log stream name when they reach the <code>RUNNING</code> status.
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
        /// For jobs running on EC2 resources that didn't specify memory requirements using <code>resourceRequirements</code>,
        /// the number of MiB of memory reserved for the job. For other jobs, including all run
        /// on Fargate resources, see <code>resourceRequirements</code>.
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
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container.
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
        /// The network configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on EC2 resources must not specify this parameter.
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
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated permissions on the host
        /// container instance (similar to the <code>root</code> user). The default value is <code>false</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources and
        /// shouldn't be provided, or specified as <code>false</code>.
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
        /// Remote API</a> and the <code>--read-only</code> option to <a href="https://docs.docker.com/engine/reference/commandline/run/">
        /// <code>docker run</code> </a>.
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
        /// The secrets to pass to the container. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/specifying-sensitive-data.html">Specifying
        /// sensitive data</a> in the <i>Batch User Guide</i>.
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon ECS task that's associated with the container
        /// job. Each container attempt receives a task ARN when they reach the <code>STARTING</code>
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
        /// A list of <code>ulimit</code> values to set in the container. This parameter maps
        /// to <code>Ulimits</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--ulimit</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources.
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
        /// The number of vCPUs reserved for the container. For jobs that run on EC2 resources,
        /// you can specify the vCPU requirement for the job using <code>resourceRequirements</code>,
        /// but you can't specify the vCPU requirements in both the <code>vcpus</code> and <code>resourceRequirements</code>
        /// object. This parameter maps to <code>CpuShares</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--cpu-shares</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. You must specify at least one
        /// vCPU. This is required but can be specified in several places. It must be specified
        /// for each node at least once.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that run on Fargate resources. For jobs that
        /// run on Fargate resources, you must specify the vCPU requirement for the job using
        /// <code>resourceRequirements</code>.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// A list of volumes that are associated with the job.
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