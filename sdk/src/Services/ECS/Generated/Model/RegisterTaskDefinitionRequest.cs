/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTaskDefinition operation.
    /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
    /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
    /// parameter. For more information about task definition parameters and defaults, see
    /// <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
    /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
    /// When you specify an IAM role for a task, its containers can then use the latest versions
    /// of the AWS CLI or SDKs to make API requests to the AWS services that are specified
    /// in the IAM policy associated with the role. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
    /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can specify a Docker networking mode for the containers in your task definition
    /// with the <code>networkMode</code> parameter. The available network modes correspond
    /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
    /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
    /// mode, the task is allocated an Elastic Network Interface, and you must specify a <a>NetworkConfiguration</a>
    /// when you create a service or run a task with the task definition. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
    /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterTaskDefinitionRequest : AmazonECSRequest
    {
        private List<ContainerDefinition> _containerDefinitions = new List<ContainerDefinition>();
        private string _cpu;
        private string _executionRoleArn;
        private string _family;
        private string _memory;
        private NetworkMode _networkMode;
        private List<TaskDefinitionPlacementConstraint> _placementConstraints = new List<TaskDefinitionPlacementConstraint>();
        private List<string> _requiresCompatibilities = new List<string>();
        private string _taskRoleArn;
        private List<Volume> _volumes = new List<Volume>();

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the different containers
        /// that make up your task.
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
        /// The number of CPU units used by the task. It can be expressed as an integer using
        /// CPU units, for example <code>1024</code>, or as a string using vCPUs, for example
        /// <code>1 vCPU</code> or <code>1 vcpu</code>, in a task definition but will be converted
        /// to an integer indicating the CPU units when the task definition is registered.
        /// </para>
        ///  <note> 
        /// <para>
        /// Task-level CPU and memory parameters are ignored for Windows containers. We recommend
        /// specifying container-level resources for Windows containers.
        /// </para>
        ///  </note> 
        /// <para>
        /// If using the EC2 launch type, this field is optional. Supported values are between
        /// <code>128</code> CPU units (<code>0.125</code> vCPUs) and <code>10240</code> CPU units
        /// (<code>10</code> vCPUs).
        /// </para>
        ///  
        /// <para>
        /// If using the Fargate launch type, this field is required and you must use one of the
        /// following values, which determines your range of supported values for the <code>memory</code>
        /// parameter:
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
        /// 2048 (2 vCPU) - Available <code>memory</code> values: Between 4096 (4 GB) and 16384
        /// (16 GB) in increments of 1024 (1 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4096 (4 vCPU) - Available <code>memory</code> values: Between 8192 (8 GB) and 30720
        /// (30 GB) in increments of 1024 (1 GB)
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution role that the Amazon ECS container
        /// agent and the Docker daemon can assume.
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
        /// You must specify a <code>family</code> for a task definition, which allows you to
        /// track multiple versions of the same task definition. The <code>family</code> is used
        /// as a name for your task definition. Up to 255 letters (uppercase and lowercase), numbers,
        /// hyphens, and underscores are allowed.
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
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) used by the task. It can be expressed as an integer
        /// using MiB, for example <code>1024</code>, or as a string using GB, for example <code>1GB</code>
        /// or <code>1 GB</code>, in a task definition but will be converted to an integer indicating
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
        /// following values, which determines your range of supported values for the <code>cpu</code>
        /// parameter:
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
        /// The default Docker network mode is <code>bridge</code>. If using the Fargate launch
        /// type, the <code>awsvpc</code> network mode is required. If using the EC2 launch type,
        /// any network mode can be used. If the network mode is set to <code>none</code>, you
        /// can't specify port mappings in your container definitions, and the task's containers
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
        ///  
        /// <para>
        /// If the network mode is <code>awsvpc</code>, the task is allocated an Elastic Network
        /// Interface, and you must specify a <a>NetworkConfiguration</a> when you create a service
        /// or run a task with the task definition. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the network mode is <code>host</code>, you can't run multiple instantiations of
        /// the same task on a single container instance when port mappings are used.
        /// </para>
        ///  
        /// <para>
        /// Docker for Windows uses different network modes than Docker for Linux. When you register
        /// a task definition with Windows containers, you must not specify a network mode.
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
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// An array of placement constraint objects to use for the task. You can specify a maximum
        /// of 10 constraints per task (this limit includes constraints in the task definition
        /// and those specified at run time).
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
        /// Gets and sets the property RequiresCompatibilities. 
        /// <para>
        /// The launch type required by the task. If no value is specified, it defaults to <code>EC2</code>.
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
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the IAM role that containers
        /// in this task can assume. All containers in this task are granted the permissions that
        /// are specified in this role. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
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
        /// A list of volume definitions in JSON format that containers in your task may use.
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