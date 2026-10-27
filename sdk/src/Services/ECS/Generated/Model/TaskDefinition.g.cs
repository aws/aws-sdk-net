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
        /// <summary>
        /// Gets and sets the property Compatibilities. 
        /// <para>
        /// Amazon ECS validates the task definition parameters with those supported by the launch
        /// type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Compatibilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Compatibilities property is set.
        /// </summary>
        internal bool IsSetCompatibilities() => this.Compatibilities != null && (this.Compatibilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the different containers
        /// that make up your task. For more information about container definition parameters
        /// and defaults, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerDefinition> ContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerDefinition>() : null;

        /// <summary>
        /// Checks to see if the ContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetContainerDefinitions() => this.ContainerDefinitions != null && (this.ContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of <c>cpu</c> units used by the task. If you use the EC2 launch type, this
        /// field is optional. Any value can be used. If you use the Fargate launch type, this
        /// field is required. You must use one of the following values. The value that you choose
        /// determines your range of valid values for the <c>memory</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you're using the EC2 launch type or the external launch type, this field is optional.
        /// Supported values are between <c>128</c> CPU units (<c>0.125</c> vCPUs) and <c>196608</c>
        /// CPU units (<c>192</c> vCPUs). 
        /// </para>
        ///  
        /// <para>
        /// This field is required for Fargate. For information about the valid values, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_size">Task
        /// size</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property DeleteRequestedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task definition delete was requested.
        /// </para>
        /// </summary>
        public DateTime? DeleteRequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the DeleteRequestedAt property is set.
        /// </summary>
        internal bool IsSetDeleteRequestedAt() => this.DeleteRequestedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeregisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the task definition was deregistered.
        /// </para>
        /// </summary>
        public DateTime? DeregisteredAt { get; set; }

        /// <summary>
        /// Checks to see if the DeregisteredAt property is set.
        /// </summary>
        internal bool IsSetDeregisteredAt() => this.DeregisteredAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnableFaultInjection. 
        /// <para>
        /// Enables fault injection and allows for fault injection requests to be accepted from
        /// the task's containers. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableFaultInjection { get; set; }

        /// <summary>
        /// Checks to see if the EnableFaultInjection property is set.
        /// </summary>
        internal bool IsSetEnableFaultInjection() => this.EnableFaultInjection.HasValue;

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The ephemeral storage settings to use for tasks run with the task definition.
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
        /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS
        /// container agent permission to make Amazon Web Services API calls on your behalf. For
        /// informationabout the required IAM roles for Amazon ECS, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/security-ecs-iam-role-overview.html">IAM
        /// roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

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
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property InferenceAccelerators. 
        /// <para>
        /// The Elastic Inference accelerator that's associated with the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InferenceAccelerator> InferenceAccelerators { get; set; } = AWSConfigs.InitializeCollections ? new List<InferenceAccelerator>() : null;

        /// <summary>
        /// Checks to see if the InferenceAccelerators property is set.
        /// </summary>
        internal bool IsSetInferenceAccelerators() => this.InferenceAccelerators != null && (this.InferenceAccelerators.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public IpcMode IpcMode { get; set; }

        /// <summary>
        /// Checks to see if the IpcMode property is set.
        /// </summary>
        internal bool IsSetIpcMode() => this.IpcMode != null;

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
        /// values. The value you choose determines your range of valid values for the <c>cpu</c>
        /// parameter.
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
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

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
        public NetworkMode NetworkMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMode property is set.
        /// </summary>
        internal bool IsSetNetworkMode() => this.NetworkMode != null;

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
        /// If no value is specified, the The default is a private namespace for each container.
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
        public PidMode PidMode { get; set; }

        /// <summary>
        /// Checks to see if the PidMode property is set.
        /// </summary>
        internal bool IsSetPidMode() => this.PidMode != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskDefinitionPlacementConstraint> PlacementConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskDefinitionPlacementConstraint>() : null;

        /// <summary>
        /// Checks to see if the PlacementConstraints property is set.
        /// </summary>
        internal bool IsSetPlacementConstraints() => this.PlacementConstraints != null && (this.PlacementConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// The configuration details for the App Mesh proxy.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon ECS container instances require at least version 1.26.0 of the container
        /// agent and at least version 1.26.0-1 of the <c>ecs-init</c> package to use a proxy
        /// configuration. If your container instances are launched from the Amazon ECS optimized
        /// AMI version <c>20190301</c> or later, they contain the required versions of the container
        /// agent and <c>ecs-init</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ProxyConfiguration ProxyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfiguration property is set.
        /// </summary>
        internal bool IsSetProxyConfiguration() => this.ProxyConfiguration != null;

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the task definition was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredAt property is set.
        /// </summary>
        internal bool IsSetRegisteredAt() => this.RegisteredAt.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// The principal that registered the task definition.
        /// </para>
        /// </summary>
        public string RegisteredBy { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredBy property is set.
        /// </summary>
        internal bool IsSetRegisteredBy() => this.RegisteredBy != null;

        /// <summary>
        /// Gets and sets the property RequiresAttributes. 
        /// <para>
        /// The container instance attributes required by your task. When an Amazon EC2 instance
        /// is registered to your cluster, the Amazon ECS container agent assigns some standard
        /// attributes to the instance. You can apply custom attributes. These are specified as
        /// key-value pairs using the Amazon ECS console or the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAttributes.html">PutAttributes</a>
        /// API. These attributes are used when determining task placement for tasks hosted on
        /// Amazon EC2 instances. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't supported for tasks run on Fargate.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> RequiresAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the RequiresAttributes property is set.
        /// </summary>
        internal bool IsSetRequiresAttributes() => this.RequiresAttributes != null && (this.RequiresAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequiresCompatibilities. 
        /// <para>
        /// The task launch types the task definition was validated against. The valid values
        /// are <c>MANAGED_INSTANCES</c>, <c>EC2</c>, <c>FARGATE</c>, and <c>EXTERNAL</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequiresCompatibilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiresCompatibilities property is set.
        /// </summary>
        internal bool IsSetRequiresCompatibilities() => this.RequiresCompatibilities != null && (this.RequiresCompatibilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the task in a particular family. The revision is a version number
        /// of a task definition in a family. When you register a task definition for the first
        /// time, the revision is <c>1</c>. Each time that you register a new revision of a task
        /// definition in the same family, the revision value always increases by one. This is
        /// even if you deregistered previous revisions in this family.
        /// </para>
        /// </summary>
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// The operating system that your task definitions are running on. A platform family
        /// is specified only for tasks using the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        /// When you specify a task in a service, this value must match the <c>runtimePlatform</c>
        /// value of the service.
        /// </para>
        /// </summary>
        public RuntimePlatform RuntimePlatform { get; set; }

        /// <summary>
        /// Checks to see if the RuntimePlatform property is set.
        /// </summary>
        internal bool IsSetRuntimePlatform() => this.RuntimePlatform != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task definition.
        /// </para>
        /// </summary>
        public TaskDefinitionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the task definition.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetTaskDefinitionArn() => this.TaskDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the Identity and Access Management
        /// role that grants containers in the task permission to call Amazon Web Services APIs
        /// on your behalf. For informationabout the required IAM roles for Amazon ECS, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/security-ecs-iam-role-overview.html">IAM
        /// roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TaskRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskRoleArn property is set.
        /// </summary>
        internal bool IsSetTaskRoleArn() => this.TaskRoleArn != null;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The list of data volume definitions for the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html">Using
        /// data volumes in tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>host</c> and <c>sourcePath</c> parameters aren't supported for tasks run on
        /// Fargate. 
        /// </para>
        ///  </note>
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
