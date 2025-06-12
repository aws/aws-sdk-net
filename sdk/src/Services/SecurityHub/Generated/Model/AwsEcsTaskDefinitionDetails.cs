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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about a task definition. A task definition describes the container and volume
    /// definitions of an Amazon Elastic Container Service task.
    /// </summary>
    public partial class AwsEcsTaskDefinitionDetails
    {
        private List<AwsEcsTaskDefinitionContainerDefinitionsDetails> _containerDefinitions = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsDetails>() : null;
        private string _cpu;
        private string _executionRoleArn;
        private string _family;
        private List<AwsEcsTaskDefinitionInferenceAcceleratorsDetails> _inferenceAccelerators = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionInferenceAcceleratorsDetails>() : null;
        private string _ipcMode;
        private string _memory;
        private string _networkMode;
        private string _pidMode;
        private List<AwsEcsTaskDefinitionPlacementConstraintsDetails> _placementConstraints = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionPlacementConstraintsDetails>() : null;
        private AwsEcsTaskDefinitionProxyConfigurationDetails _proxyConfiguration;
        private List<string> _requiresCompatibilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _status;
        private string _taskRoleArn;
        private List<AwsEcsTaskDefinitionVolumesDetails> _volumes = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionVolumesDetails>() : null;

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// The container definitions that describe the containers that make up the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsDetails> ContainerDefinitions
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
        /// The number of CPU units used by the task.Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>256 (.25 vCPU)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>512 (.5 vCPU)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1024 (1 vCPU)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2048 (2 vCPU)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>4096 (4 vCPU)</c> 
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
        /// The ARN of the task execution role that grants the container agent permission to make
        /// API calls on behalf of the container user.
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
        /// The name of a family that this task definition is registered to.
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
        /// The Elastic Inference accelerators to use for the containers in the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionInferenceAcceleratorsDetails> InferenceAccelerators
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
        /// The inter-process communication (IPC) resource namespace to use for the containers
        /// in the task. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>host</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>none</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>task</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string IpcMode
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
        /// For tasks that are hosted on Amazon EC2, you can provide a task-level memory value
        /// or a container-level memory value. For tasks that are hosted on Fargate, you must
        /// use one of the <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_size">specified
        /// values</a> in the <i> <i>Amazon Elastic Container Service Developer Guide</i> </i>,
        /// which determines your range of supported values for the <c>Cpu</c> and <c>Memory</c>
        /// parameters.
        /// </para>
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
        /// The Docker networking mode to use for the containers in the task. Valid values are
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>awsvpc</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bridge</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>host</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>none</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string NetworkMode
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
        /// The process namespace to use for the containers in the task. Valid values are <c>host</c>
        /// or <c>task</c>.
        /// </para>
        /// </summary>
        public string PidMode
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
        /// The placement constraint objects to use for tasks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionPlacementConstraintsDetails> PlacementConstraints
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
        /// </summary>
        public AwsEcsTaskDefinitionProxyConfigurationDetails ProxyConfiguration
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
        /// The task launch types that the task definition was validated against.
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the task definition. 
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or ARN of the IAM role that grants containers in the task permission
        /// to call Amazon Web Services API operations on your behalf.
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
        /// The data volume definitions for the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionVolumesDetails> Volumes
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