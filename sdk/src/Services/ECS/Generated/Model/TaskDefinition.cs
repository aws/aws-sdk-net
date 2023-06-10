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
    /// The details of a task definition which describes the container and volume definitions
    /// of an Amazon Elastic Container Service task. You can specify which Docker images to
    /// use, the required resources, and other configurations related to launching the task
    /// definition through an Amazon ECS service or task.
    /// </summary>
    public partial class TaskDefinition
    {
        private List<string> _compatibilities = new List<string>();
        private List<ContainerDefinition> _containerDefinitions = new List<ContainerDefinition>();
        private string _cpu;
        private DateTime? _deregisteredAt;
        private EphemeralStorage _ephemeralStorage;
        private string _executionRoleArn;
        private string _family;
        private List<InferenceAccelerator> _inferenceAccelerators = new List<InferenceAccelerator>();
        private IpcMode _ipcMode;
        private string _memory;
        private NetworkMode _networkMode;
        private PidMode _pidMode;
        private List<TaskDefinitionPlacementConstraint> _placementConstraints = new List<TaskDefinitionPlacementConstraint>();
        private ProxyConfiguration _proxyConfiguration;
        private DateTime? _registeredAt;
        private string _registeredBy;
        private List<Attribute> _requiresAttributes = new List<Attribute>();
        private List<string> _requiresCompatibilities = new List<string>();
        private int? _revision;
        private RuntimePlatform _runtimePlatform;
        private TaskDefinitionStatus _status;
        private string _taskDefinitionArn;
        private string _taskRoleArn;
        private List<Volume> _volumes = new List<Volume>();

        /// <summary>
        /// Gets and sets the property Compatibilities. 
        /// <para>
        /// The task launch types the task definition validated against during task definition
        /// registration. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<string> Compatibilities
        {
            get { return this._compatibilities; }
            set { this._compatibilities = value; }
        }

        // Check to see if Compatibilities property is set
        internal bool IsSetCompatibilities()
        {
            return this._compatibilities != null && this._compatibilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the different containers
        /// that make up your task. For more information about container definition parameters
        /// and defaults, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<ContainerDefinition> ContainerDefinitions
        {
            get { return this._containerDefinitions; }
            set { this._containerDefinitions = value; }
        }

        // Check to see if ContainerDefinitions property is set
        internal bool IsSetContainerDefinitions()
        {
            return this._containerDefinitions != null && this._containerDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of <code>cpu</code> units used by the task. If you use the EC2 launch type,
        /// this field is optional. Any value can be used. If you use the Fargate launch type,
        /// this field is required. You must use one of the following values. The value that you
        /// choose determines your range of valid values for the <code>memory</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// The CPU units cannot be less than 1 vCPU when you use Windows containers on Fargate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 256 (.25 vCPU) - Available <code>memory</code> values: 512 (0.5 GB), 1024 (1 GB),
        /// 2048 (2 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 512 (.5 vCPU) - Available <code>memory</code> values: 1024 (1 GB), 2048 (2 GB), 3072
        /// (3 GB), 4096 (4 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1024 (1 vCPU) - Available <code>memory</code> values: 2048 (2 GB), 3072 (3 GB), 4096
        /// (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7 GB), 8192 (8 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2048 (2 vCPU) - Available <code>memory</code> values: 4096 (4 GB) and 16384 (16 GB)
        /// in increments of 1024 (1 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4096 (4 vCPU) - Available <code>memory</code> values: 8192 (8 GB) and 30720 (30 GB)
        /// in increments of 1024 (1 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 8192 (8 vCPU) - Available <code>memory</code> values: 16 GB and 60 GB in 4 GB increments
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 16384 (16vCPU) - Available <code>memory</code> values: 32GB and 120 GB in 8 GB increments
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property DeregisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the task definition was deregistered.
        /// </para>
        /// </summary>
        public DateTime DeregisteredAt
        {
            get { return this._deregisteredAt.GetValueOrDefault(); }
            set { this._deregisteredAt = value; }
        }

        // Check to see if DeregisteredAt property is set
        internal bool IsSetDeregisteredAt()
        {
            return this._deregisteredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The ephemeral storage settings to use for tasks run with the task definition.
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
        /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS
        /// container agent permission to make Amazon Web Services API calls on your behalf. The
        /// task execution IAM role is required depending on the requirements of your task. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_execution_IAM_role.html">Amazon
        /// ECS task execution IAM role</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
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
        /// Gets and sets the property Family. 
        /// <para>
        /// The name of a family that this task definition is registered to. Up to 255 characters
        /// are allowed. Letters (both uppercase and lowercase letters), numbers, hyphens (-),
        /// and underscores (_) are allowed.
        /// </para>
        ///  
        /// <para>
        /// A family groups multiple versions of a task definition. Amazon ECS gives the first
        /// task definition that you registered to a family a revision number of 1. Amazon ECS
        /// gives sequential revision numbers to each task definition that you add.
        /// </para>
        /// </summary>
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }

        // Check to see if Family property is set
        internal bool IsSetFamily()
        {
            return this._family != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceAccelerators. 
        /// <para>
        /// The Elastic Inference accelerator that's associated with the task.
        /// </para>
        /// </summary>
        public List<InferenceAccelerator> InferenceAccelerators
        {
            get { return this._inferenceAccelerators; }
            set { this._inferenceAccelerators = value; }
        }

        // Check to see if InferenceAccelerators property is set
        internal bool IsSetInferenceAccelerators()
        {
            return this._inferenceAccelerators != null && this._inferenceAccelerators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IpcMode. 
        /// <para>
        /// The IPC resource namespace to use for the containers in the task. The valid values
        /// are <code>host</code>, <code>task</code>, or <code>none</code>. If <code>host</code>
        /// is specified, then all containers within the tasks that specified the <code>host</code>
        /// IPC mode on the same container instance share the same IPC resources with the host
        /// Amazon EC2 instance. If <code>task</code> is specified, all containers within the
        /// specified task share the same IPC resources. If <code>none</code> is specified, then
        /// IPC resources within the containers of a task are private and not shared with other
        /// containers in a task or on the container instance. If no value is specified, then
        /// the IPC resource namespace sharing depends on the Docker daemon setting on the container
        /// instance. For more information, see <a href="https://docs.docker.com/engine/reference/run/#ipc-settings---ipc">IPC
        /// settings</a> in the <i>Docker run reference</i>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>host</code> IPC mode is used, be aware that there is a heightened risk
        /// of undesired IPC namespace expose. For more information, see <a href="https://docs.docker.com/engine/security/security/">Docker
        /// security</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are setting namespaced kernel parameters using <code>systemControls</code>
        /// for the containers in the task, the following will apply to your IPC resource namespace.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html">System
        /// Controls</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For tasks that use the <code>host</code> IPC mode, IPC namespace related <code>systemControls</code>
        /// are not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For tasks that use the <code>task</code> IPC mode, IPC namespace related <code>systemControls</code>
        /// will apply to all containers within a task.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This parameter is not supported for Windows containers or tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public IpcMode IpcMode
        {
            get { return this._ipcMode; }
            set { this._ipcMode = value; }
        }

        // Check to see if IpcMode property is set
        internal bool IsSetIpcMode()
        {
            return this._ipcMode != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount (in MiB) of memory used by the task.
        /// </para>
        ///  
        /// <para>
        /// If your tasks runs on Amazon EC2 instances, you must specify either a task-level memory
        /// value or a container-level memory value. This field is optional and any value can
        /// be used. If a task-level memory value is specified, the container-level memory value
        /// is optional. For more information regarding container-level memory and memory reservation,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html">ContainerDefinition</a>.
        /// </para>
        ///  
        /// <para>
        /// If your tasks runs on Fargate, this field is required. You must use one of the following
        /// values. The value you choose determines your range of valid values for the <code>cpu</code>
        /// parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 512 (0.5 GB), 1024 (1 GB), 2048 (2 GB) - Available <code>cpu</code> values: 256 (.25
        /// vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1024 (1 GB), 2048 (2 GB), 3072 (3 GB), 4096 (4 GB) - Available <code>cpu</code> values:
        /// 512 (.5 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2048 (2 GB), 3072 (3 GB), 4096 (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7 GB), 8192
        /// (8 GB) - Available <code>cpu</code> values: 1024 (1 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 4096 (4 GB) and 16384 (16 GB) in increments of 1024 (1 GB) - Available <code>cpu</code>
        /// values: 2048 (2 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 8192 (8 GB) and 30720 (30 GB) in increments of 1024 (1 GB) - Available <code>cpu</code>
        /// values: 4096 (4 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 16 GB and 60 GB in 4 GB increments - Available <code>cpu</code> values: 8192
        /// (8 vCPU)
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 32GB and 120 GB in 8 GB increments - Available <code>cpu</code> values: 16384
        /// (16 vCPU)
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMode. 
        /// <para>
        /// The Docker networking mode to use for the containers in the task. The valid values
        /// are <code>none</code>, <code>bridge</code>, <code>awsvpc</code>, and <code>host</code>.
        /// If no network mode is specified, the default is <code>bridge</code>.
        /// </para>
        ///  
        /// <para>
        /// For Amazon ECS tasks on Fargate, the <code>awsvpc</code> network mode is required.
        /// For Amazon ECS tasks on Amazon EC2 Linux instances, any network mode can be used.
        /// For Amazon ECS tasks on Amazon EC2 Windows instances, <code>&lt;default&gt;</code>
        /// or <code>awsvpc</code> can be used. If the network mode is set to <code>none</code>,
        /// you cannot specify port mappings in your container definitions, and the tasks containers
        /// do not have external connectivity. The <code>host</code> and <code>awsvpc</code> network
        /// modes offer the highest networking performance for containers because they use the
        /// EC2 network stack instead of the virtualized network stack provided by the <code>bridge</code>
        /// mode.
        /// </para>
        ///  
        /// <para>
        /// With the <code>host</code> and <code>awsvpc</code> network modes, exposed container
        /// ports are mapped directly to the corresponding host port (for the <code>host</code>
        /// network mode) or the attached elastic network interface port (for the <code>awsvpc</code>
        /// network mode), so you cannot take advantage of dynamic host port mappings. 
        /// </para>
        ///  <important> 
        /// <para>
        /// When using the <code>host</code> network mode, you should not run containers using
        /// the root user (UID 0). It is considered best practice to use a non-root user.
        /// </para>
        ///  </important> 
        /// <para>
        /// If the network mode is <code>awsvpc</code>, the task is allocated an elastic network
        /// interface, and you must specify a <a>NetworkConfiguration</a> value when you create
        /// a service or run a task with the task definition. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the network mode is <code>host</code>, you cannot run multiple instantiations of
        /// the same task on a single container instance when port mappings are used.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.docker.com/engine/reference/run/#network-settings">Network
        /// settings</a> in the <i>Docker run reference</i>.
        /// </para>
        /// </summary>
        public NetworkMode NetworkMode
        {
            get { return this._networkMode; }
            set { this._networkMode = value; }
        }

        // Check to see if NetworkMode property is set
        internal bool IsSetNetworkMode()
        {
            return this._networkMode != null;
        }

        /// <summary>
        /// Gets and sets the property PidMode. 
        /// <para>
        /// The process namespace to use for the containers in the task. The valid values are
        /// <code>host</code> or <code>task</code>. If <code>host</code> is specified, then all
        /// containers within the tasks that specified the <code>host</code> PID mode on the same
        /// container instance share the same process namespace with the host Amazon EC2 instance.
        /// If <code>task</code> is specified, all containers within the specified task share
        /// the same process namespace. If no value is specified, the default is a private namespace.
        /// For more information, see <a href="https://docs.docker.com/engine/reference/run/#pid-settings---pid">PID
        /// settings</a> in the <i>Docker run reference</i>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>host</code> PID mode is used, be aware that there is a heightened risk
        /// of undesired process namespace expose. For more information, see <a href="https://docs.docker.com/engine/security/security/">Docker
        /// security</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers or tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public PidMode PidMode
        {
            get { return this._pidMode; }
            set { this._pidMode = value; }
        }

        // Check to see if PidMode property is set
        internal bool IsSetPidMode()
        {
            return this._pidMode != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// An array of placement constraint objects to use for tasks.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't supported for tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public List<TaskDefinitionPlacementConstraint> PlacementConstraints
        {
            get { return this._placementConstraints; }
            set { this._placementConstraints = value; }
        }

        // Check to see if PlacementConstraints property is set
        internal bool IsSetPlacementConstraints()
        {
            return this._placementConstraints != null && this._placementConstraints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// The configuration details for the App Mesh proxy.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon ECS container instances require at least version 1.26.0 of the container
        /// agent and at least version 1.26.0-1 of the <code>ecs-init</code> package to use a
        /// proxy configuration. If your container instances are launched from the Amazon ECS
        /// optimized AMI version <code>20190301</code> or later, they contain the required versions
        /// of the container agent and <code>ecs-init</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ProxyConfiguration ProxyConfiguration
        {
            get { return this._proxyConfiguration; }
            set { this._proxyConfiguration = value; }
        }

        // Check to see if ProxyConfiguration property is set
        internal bool IsSetProxyConfiguration()
        {
            return this._proxyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the task definition was registered.
        /// </para>
        /// </summary>
        public DateTime RegisteredAt
        {
            get { return this._registeredAt.GetValueOrDefault(); }
            set { this._registeredAt = value; }
        }

        // Check to see if RegisteredAt property is set
        internal bool IsSetRegisteredAt()
        {
            return this._registeredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// The principal that registered the task definition.
        /// </para>
        /// </summary>
        public string RegisteredBy
        {
            get { return this._registeredBy; }
            set { this._registeredBy = value; }
        }

        // Check to see if RegisteredBy property is set
        internal bool IsSetRegisteredBy()
        {
            return this._registeredBy != null;
        }

        /// <summary>
        /// Gets and sets the property RequiresAttributes. 
        /// <para>
        /// The container instance attributes required by your task. When an Amazon EC2 instance
        /// is registered to your cluster, the Amazon ECS container agent assigns some standard
        /// attributes to the instance. You can apply custom attributes. These are specified as
        /// key-value pairs using the Amazon ECS console or the <a>PutAttributes</a> API. These
        /// attributes are used when determining task placement for tasks hosted on Amazon EC2
        /// instances. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't supported for tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Attribute> RequiresAttributes
        {
            get { return this._requiresAttributes; }
            set { this._requiresAttributes = value; }
        }

        // Check to see if RequiresAttributes property is set
        internal bool IsSetRequiresAttributes()
        {
            return this._requiresAttributes != null && this._requiresAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequiresCompatibilities. 
        /// <para>
        /// The task launch types the task definition was validated against. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<string> RequiresCompatibilities
        {
            get { return this._requiresCompatibilities; }
            set { this._requiresCompatibilities = value; }
        }

        // Check to see if RequiresCompatibilities property is set
        internal bool IsSetRequiresCompatibilities()
        {
            return this._requiresCompatibilities != null && this._requiresCompatibilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the task in a particular family. The revision is a version number
        /// of a task definition in a family. When you register a task definition for the first
        /// time, the revision is <code>1</code>. Each time that you register a new revision of
        /// a task definition in the same family, the revision value always increases by one.
        /// This is even if you deregistered previous revisions in this family.
        /// </para>
        /// </summary>
        public int Revision
        {
            get { return this._revision.GetValueOrDefault(); }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// The operating system that your task definitions are running on. A platform family
        /// is specified only for tasks using the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        /// When you specify a task in a service, this value must match the <code>runtimePlatform</code>
        /// value of the service.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task definition.
        /// </para>
        /// </summary>
        public TaskDefinitionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the task definition.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn
        {
            get { return this._taskDefinitionArn; }
            set { this._taskDefinitionArn = value; }
        }

        // Check to see if TaskDefinitionArn property is set
        internal bool IsSetTaskDefinitionArn()
        {
            return this._taskDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the Identity and Access Management
        /// role that grants containers in the task permission to call Amazon Web Services APIs
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">Amazon
        /// ECS Task Role</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// IAM roles for tasks on Windows require that the <code>-EnableTaskIAMRole</code> option
        /// is set when you launch the Amazon ECS-optimized Windows AMI. Your containers must
        /// also run some configuration code to use the feature. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/windows_task_IAM_roles.html">Windows
        /// IAM roles for tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TaskRoleArn
        {
            get { return this._taskRoleArn; }
            set { this._taskRoleArn = value; }
        }

        // Check to see if TaskRoleArn property is set
        internal bool IsSetTaskRoleArn()
        {
            return this._taskRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The list of data volume definitions for the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html">Using
        /// data volumes in tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>host</code> and <code>sourcePath</code> parameters aren't supported for
        /// tasks run on Fargate. 
        /// </para>
        ///  </note>
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