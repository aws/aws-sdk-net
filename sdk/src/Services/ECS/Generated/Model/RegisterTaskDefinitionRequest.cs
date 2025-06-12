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
    /// Container for the parameters to the RegisterTaskDefinition operation.
    /// Registers a new task definition from the supplied <c>family</c> and <c>containerDefinitions</c>.
    /// Optionally, you can add data volumes to your containers with the <c>volumes</c> parameter.
    /// For more information about task definition parameters and defaults, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
    /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can specify a role for your task with the <c>taskRoleArn</c> parameter. When you
    /// specify a role for a task, its containers can then use the latest versions of the
    /// CLI or SDKs to make API requests to the Amazon Web Services services that are specified
    /// in the policy that's associated with the role. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
    /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can specify a Docker networking mode for the containers in your task definition
    /// with the <c>networkMode</c> parameter. If you specify the <c>awsvpc</c> network mode,
    /// the task is allocated an elastic network interface, and you must specify a <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_NetworkConfiguration.html">NetworkConfiguration</a>
    /// when you create a service or run a task with the task definition. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
    /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterTaskDefinitionRequest : AmazonECSRequest
    {
        private List<ContainerDefinition> _containerDefinitions = AWSConfigs.InitializeCollections ? new List<ContainerDefinition>() : null;
        private string _cpu;
        private bool? _enableFaultInjection;
        private EphemeralStorage _ephemeralStorage;
        private string _executionRoleArn;
        private string _family;
        private List<InferenceAccelerator> _inferenceAccelerators = AWSConfigs.InitializeCollections ? new List<InferenceAccelerator>() : null;
        private IpcMode _ipcMode;
        private string _memory;
        private NetworkMode _networkMode;
        private PidMode _pidMode;
        private List<TaskDefinitionPlacementConstraint> _placementConstraints = AWSConfigs.InitializeCollections ? new List<TaskDefinitionPlacementConstraint>() : null;
        private ProxyConfiguration _proxyConfiguration;
        private List<string> _requiresCompatibilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RuntimePlatform _runtimePlatform;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _taskRoleArn;
        private List<Volume> _volumes = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the different containers
        /// that make up your task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._containerDefinitions != null && (this._containerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the task. It can be expressed as an integer using
        /// CPU units (for example, <c>1024</c>) or as a string using vCPUs (for example, <c>1
        /// vCPU</c> or <c>1 vcpu</c>) in a task definition. String values are converted to an
        /// integer indicating the CPU units when the task definition is registered.
        /// </para>
        ///  <note> 
        /// <para>
        /// Task-level CPU and memory parameters are ignored for Windows containers. We recommend
        /// specifying container-level resources for Windows containers.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you're using the EC2 launch type or external launch type, this field is optional.
        /// Supported values are between <c>128</c> CPU units (<c>0.125</c> vCPUs) and <c>196608</c>
        /// CPU units (<c>192</c> vCPUs). If you do not specify a value, the parameter is ignored.
        /// </para>
        ///  
        /// <para>
        /// This field is required for Fargate. For information about the valid values, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_size">Task
        /// size</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
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
        /// Gets and sets the property EnableFaultInjection. 
        /// <para>
        /// Enables fault injection when you register your task definition and allows for fault
        /// injection requests to be accepted from the task's containers. The default value is
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableFaultInjection
        {
            get { return this._enableFaultInjection; }
            set { this._enableFaultInjection = value; }
        }

        // Check to see if EnableFaultInjection property is set
        internal bool IsSetEnableFaultInjection()
        {
            return this._enableFaultInjection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The amount of ephemeral storage to allocate for the task. This parameter is used to
        /// expand the total amount of ephemeral storage available, beyond the default amount,
        /// for tasks hosted on Fargate. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html">Using
        /// data volumes in tasks</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For tasks using the Fargate launch type, the task requires the following platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <c>1.4.0</c> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <c>1.0.0</c> or later.
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
        /// container agent permission to make Amazon Web Services API calls on your behalf. For
        /// informationabout the required IAM roles for Amazon ECS, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/security-ecs-iam-role-overview.html">IAM
        /// roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// You must specify a <c>family</c> for a task definition. You can use it track multiple
        /// versions of the same task definition. The <c>family</c> is used as a name for your
        /// task definition. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InferenceAccelerator> InferenceAccelerators
        {
            get { return this._inferenceAccelerators; }
            set { this._inferenceAccelerators = value; }
        }

        // Check to see if InferenceAccelerators property is set
        internal bool IsSetInferenceAccelerators()
        {
            return this._inferenceAccelerators != null && (this._inferenceAccelerators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpcMode. 
        /// <para>
        /// The IPC resource namespace to use for the containers in the task. The valid values
        /// are <c>host</c>, <c>task</c>, or <c>none</c>. If <c>host</c> is specified, then all
        /// containers within the tasks that specified the <c>host</c> IPC mode on the same container
        /// instance share the same IPC resources with the host Amazon EC2 instance. If <c>task</c>
        /// is specified, all containers within the specified task share the same IPC resources.
        /// If <c>none</c> is specified, then IPC resources within the containers of a task are
        /// private and not shared with other containers in a task or on the container instance.
        /// If no value is specified, then the IPC resource namespace sharing depends on the Docker
        /// daemon setting on the container instance.
        /// </para>
        ///  
        /// <para>
        /// If the <c>host</c> IPC mode is used, be aware that there is a heightened risk of undesired
        /// IPC namespace expose.
        /// </para>
        ///  
        /// <para>
        /// If you are setting namespaced kernel parameters using <c>systemControls</c> for the
        /// containers in the task, the following will apply to your IPC resource namespace. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html">System
        /// Controls</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For tasks that use the <c>host</c> IPC mode, IPC namespace related <c>systemControls</c>
        /// are not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For tasks that use the <c>task</c> IPC mode, IPC namespace related <c>systemControls</c>
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
        /// using MiB (for example ,<c>1024</c>) or as a string using GB (for example, <c>1GB</c>
        /// or <c>1 GB</c>) in a task definition. String values are converted to an integer indicating
        /// the MiB when the task definition is registered.
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
        /// following values. This determines your range of supported values for the <c>cpu</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// The CPU units cannot be less than 1 vCPU when you use Windows containers on Fargate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 512 (0.5 GB), 1024 (1 GB), 2048 (2 GB) - Available <c>cpu</c> values: 256 (.25 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1024 (1 GB), 2048 (2 GB), 3072 (3 GB), 4096 (4 GB) - Available <c>cpu</c> values:
        /// 512 (.5 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2048 (2 GB), 3072 (3 GB), 4096 (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7 GB), 8192
        /// (8 GB) - Available <c>cpu</c> values: 1024 (1 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 4096 (4 GB) and 16384 (16 GB) in increments of 1024 (1 GB) - Available <c>cpu</c>
        /// values: 2048 (2 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 8192 (8 GB) and 30720 (30 GB) in increments of 1024 (1 GB) - Available <c>cpu</c>
        /// values: 4096 (4 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 16 GB and 60 GB in 4 GB increments - Available <c>cpu</c> values: 8192 (8
        /// vCPU)
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <c>1.4.0</c> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 32GB and 120 GB in 8 GB increments - Available <c>cpu</c> values: 16384 (16
        /// vCPU)
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <c>1.4.0</c> or later.
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
        /// are <c>none</c>, <c>bridge</c>, <c>awsvpc</c>, and <c>host</c>. If no network mode
        /// is specified, the default is <c>bridge</c>.
        /// </para>
        ///  
        /// <para>
        /// For Amazon ECS tasks on Fargate, the <c>awsvpc</c> network mode is required. For Amazon
        /// ECS tasks on Amazon EC2 Linux instances, any network mode can be used. For Amazon
        /// ECS tasks on Amazon EC2 Windows instances, <c>&lt;default&gt;</c> or <c>awsvpc</c>
        /// can be used. If the network mode is set to <c>none</c>, you cannot specify port mappings
        /// in your container definitions, and the tasks containers do not have external connectivity.
        /// The <c>host</c> and <c>awsvpc</c> network modes offer the highest networking performance
        /// for containers because they use the EC2 network stack instead of the virtualized network
        /// stack provided by the <c>bridge</c> mode.
        /// </para>
        ///  
        /// <para>
        /// With the <c>host</c> and <c>awsvpc</c> network modes, exposed container ports are
        /// mapped directly to the corresponding host port (for the <c>host</c> network mode)
        /// or the attached elastic network interface port (for the <c>awsvpc</c> network mode),
        /// so you cannot take advantage of dynamic host port mappings. 
        /// </para>
        ///  <important> 
        /// <para>
        /// When using the <c>host</c> network mode, you should not run containers using the root
        /// user (UID 0). It is considered best practice to use a non-root user.
        /// </para>
        ///  </important> 
        /// <para>
        /// If the network mode is <c>awsvpc</c>, the task is allocated an elastic network interface,
        /// and you must specify a <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_NetworkConfiguration.html">NetworkConfiguration</a>
        /// value when you create a service or run a task with the task definition. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the network mode is <c>host</c>, you cannot run multiple instantiations of the
        /// same task on a single container instance when port mappings are used.
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
        /// <c>host</c> or <c>task</c>. On Fargate for Linux containers, the only valid value
        /// is <c>task</c>. For example, monitoring sidecars might need <c>pidMode</c> to access
        /// information about other containers running in the same task.
        /// </para>
        ///  
        /// <para>
        /// If <c>host</c> is specified, all containers within the tasks that specified the <c>host</c>
        /// PID mode on the same container instance share the same process namespace with the
        /// host Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// If <c>task</c> is specified, all containers within the specified task share the same
        /// process namespace.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the default is a private namespace for each container.
        /// </para>
        ///  
        /// <para>
        /// If the <c>host</c> PID mode is used, there's a heightened risk of undesired process
        /// namespace exposure.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This parameter is only supported for tasks that are hosted on Fargate if the tasks
        /// are using platform version <c>1.4.0</c> or later (Linux). This isn't supported for
        /// Windows containers on Fargate.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskDefinitionPlacementConstraint> PlacementConstraints
        {
            get { return this._placementConstraints; }
            set { this._placementConstraints = value; }
        }

        // Check to see if PlacementConstraints property is set
        internal bool IsSetPlacementConstraints()
        {
            return this._placementConstraints != null && (this._placementConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// The configuration details for the App Mesh proxy.
        /// </para>
        ///  
        /// <para>
        /// For tasks hosted on Amazon EC2 instances, the container instances require at least
        /// version <c>1.26.0</c> of the container agent and at least version <c>1.26.0-1</c>
        /// of the <c>ecs-init</c> package to use a proxy configuration. If your container instances
        /// are launched from the Amazon ECS-optimized AMI version <c>20190301</c> or later, then
        /// they contain the required versions of the container agent and <c>ecs-init</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-ami-versions.html">Amazon
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequiresCompatibilities
        {
            get { return this._requiresCompatibilities; }
            set { this._requiresCompatibilities = value; }
        }

        // Check to see if RequiresCompatibilities property is set
        internal bool IsSetRequiresCompatibilities()
        {
            return this._requiresCompatibilities != null && (this._requiresCompatibilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// The operating system that your tasks definitions run on. A platform family is specified
        /// only for tasks using the Fargate launch type. 
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
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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