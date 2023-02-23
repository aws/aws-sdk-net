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
    /// Container for the parameters to the RegisterTaskDefinition operation.
    /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
    /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
    /// parameter. For more information about task definition parameters and defaults, see
    /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
    /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can specify a role for your task with the <code>taskRoleArn</code> parameter.
    /// When you specify a role for a task, its containers can then use the latest versions
    /// of the CLI or SDKs to make API requests to the Amazon Web Services services that are
    /// specified in the policy that's associated with the role. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
    /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can specify a Docker networking mode for the containers in your task definition
    /// with the <code>networkMode</code> parameter. The available network modes correspond
    /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
    /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
    /// mode, the task is allocated an elastic network interface, and you must specify a <a>NetworkConfiguration</a>
    /// when you create a service or run a task with the task definition. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
    /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterTaskDefinitionRequest : AmazonECSRequest
    {
        private List<ContainerDefinition> _containerDefinitions = new List<ContainerDefinition>();
        private string _cpu;
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
        private List<string> _requiresCompatibilities = new List<string>();
        private RuntimePlatform _runtimePlatform;
        private List<Tag> _tags = new List<Tag>();
        private string _taskRoleArn;
        private List<Volume> _volumes = new List<Volume>();

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the different containers
        /// that make up your task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The number of CPU units used by the task. It can be expressed as an integer using
        /// CPU units (for example, <code>1024</code>) or as a string using vCPUs (for example,
        /// <code>1 vCPU</code> or <code>1 vcpu</code>) in a task definition. String values are
        /// converted to an integer indicating the CPU units when the task definition is registered.
        /// </para>
        ///  <note> 
        /// <para>
        /// Task-level CPU and memory parameters are ignored for Windows containers. We recommend
        /// specifying container-level resources for Windows containers.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you're using the EC2 launch type, this field is optional. Supported values are
        /// between <code>128</code> CPU units (<code>0.125</code> vCPUs) and <code>10240</code>
        /// CPU units (<code>10</code> vCPUs). If you do not specify a value, the parameter is
        /// ignored.
        /// </para>
        ///  
        /// <para>
        /// If you're using the Fargate launch type, this field is required and you must use one
        /// of the following values, which determines your range of supported values for the <code>memory</code>
        /// parameter:
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The amount of ephemeral storage to allocate for the task. This parameter is used to
        /// expand the total amount of ephemeral storage available, beyond the default amount,
        /// for tasks hosted on Fargate. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/userguide/using_data_volumes.html">Fargate
        /// task storage</a> in the <i>Amazon ECS User Guide for Fargate</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported for tasks hosted on Fargate using the following platform
        /// versions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <code>1.4.0</code> or later.
        /// </para>
        ///  </li> </ul> </note>
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
        /// You must specify a <code>family</code> for a task definition. You can use it track
        /// multiple versions of the same task definition. The <code>family</code> is used as
        /// a name for your task definition. Up to 255 letters (uppercase and lowercase), numbers,
        /// underscores, and hyphens are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The Elastic Inference accelerators to use for the containers in the task.
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
        /// The amount of memory (in MiB) used by the task. It can be expressed as an integer
        /// using MiB (for example ,<code>1024</code>) or as a string using GB (for example, <code>1GB</code>
        /// or <code>1 GB</code>) in a task definition. String values are converted to an integer
        /// indicating the MiB when the task definition is registered.
        /// </para>
        ///  <note> 
        /// <para>
        /// Task-level CPU and memory parameters are ignored for Windows containers. We recommend
        /// specifying container-level resources for Windows containers.
        /// </para>
        ///  </note> 
        /// <para>
        /// If using the EC2 launch type, this field is optional.
        /// </para>
        ///  
        /// <para>
        /// If using the Fargate launch type, this field is required and you must use one of the
        /// following values. This determines your range of supported values for the <code>cpu</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// The CPU units cannot be less than 1 vCPU when you use Windows containers on Fargate.
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
        /// An array of placement constraint objects to use for the task. You can specify a maximum
        /// of 10 constraints for each task. This limit includes constraints in the task definition
        /// and those specified at runtime.
        /// </para>
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
        /// For tasks hosted on Amazon EC2 instances, the container instances require at least
        /// version <code>1.26.0</code> of the container agent and at least version <code>1.26.0-1</code>
        /// of the <code>ecs-init</code> package to use a proxy configuration. If your container
        /// instances are launched from the Amazon ECS-optimized AMI version <code>20190301</code>
        /// or later, then they contain the required versions of the container agent and <code>ecs-init</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-ami-versions.html">Amazon
        /// ECS-optimized AMI versions</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
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
        /// Gets and sets the property RequiresCompatibilities. 
        /// <para>
        /// The task launch type that Amazon ECS validates the task definition against. A client
        /// exception is returned if the task definition doesn't validate against the compatibilities
        /// specified. If no value is specified, the parameter is omitted from the response.
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
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// The operating system that your tasks definitions run on. A platform family is specified
        /// only for tasks using the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        /// When you specify a task definition in a service, this value must match the <code>runtimePlatform</code>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task definition to help you categorize and organize
        /// them. Each tag consists of a key and an optional value. You define both of them.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for either keys or values as it is reserved for Amazon Web Services
        /// use. You cannot edit or delete tag keys or values with this prefix. Tags with this
        /// prefix do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the IAM role that containers
        /// in this task can assume. All containers in this task are granted the permissions that
        /// are specified in this role. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// A list of volume definitions in JSON format that containers in your task might use.
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