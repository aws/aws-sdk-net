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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about a task definition. A task definition describes the container and volume
    /// definitions of an Amazon Elastic Container Service task.
    /// </summary>
    public partial class AwsEcsTaskDefinitionDetails
    {
        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// The container definitions that describe the containers that make up the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsDetails> ContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsDetails>() : null;

        /// <summary>
        /// Checks to see if the ContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetContainerDefinitions() => this.ContainerDefinitions != null && (this.ContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the task execution role that grants the container agent permission to make
        /// API calls on behalf of the container user.
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
        /// The name of a family that this task definition is registered to.
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
        /// The Elastic Inference accelerators to use for the containers in the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionInferenceAcceleratorsDetails> InferenceAccelerators { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionInferenceAcceleratorsDetails>() : null;

        /// <summary>
        /// Checks to see if the InferenceAccelerators property is set.
        /// </summary>
        internal bool IsSetInferenceAccelerators() => this.InferenceAccelerators != null && (this.InferenceAccelerators.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string IpcMode { get; set; }

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
        /// For tasks that are hosted on Amazon EC2, you can provide a task-level memory value
        /// or a container-level memory value. For tasks that are hosted on Fargate, you must
        /// use one of the <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_size">specified
        /// values</a> in the <i> <i>Amazon Elastic Container Service Developer Guide</i> </i>,
        /// which determines your range of supported values for the <c>Cpu</c> and <c>Memory</c>
        /// parameters.
        /// </para>
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

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
        public string NetworkMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMode property is set.
        /// </summary>
        internal bool IsSetNetworkMode() => this.NetworkMode != null;

        /// <summary>
        /// Gets and sets the property PidMode. 
        /// <para>
        /// The process namespace to use for the containers in the task. Valid values are <c>host</c>
        /// or <c>task</c>.
        /// </para>
        /// </summary>
        public string PidMode { get; set; }

        /// <summary>
        /// Checks to see if the PidMode property is set.
        /// </summary>
        internal bool IsSetPidMode() => this.PidMode != null;

        /// <summary>
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// The placement constraint objects to use for tasks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionPlacementConstraintsDetails> PlacementConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionPlacementConstraintsDetails>() : null;

        /// <summary>
        /// Checks to see if the PlacementConstraints property is set.
        /// </summary>
        internal bool IsSetPlacementConstraints() => this.PlacementConstraints != null && (this.PlacementConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// The configuration details for the App Mesh proxy.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionProxyConfigurationDetails ProxyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfiguration property is set.
        /// </summary>
        internal bool IsSetProxyConfiguration() => this.ProxyConfiguration != null;

        /// <summary>
        /// Gets and sets the property RequiresCompatibilities. 
        /// <para>
        /// The task launch types that the task definition was validated against.
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the task definition. 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or ARN of the IAM role that grants containers in the task permission
        /// to call Amazon Web Services API operations on your behalf.
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
        /// The data volume definitions for the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionVolumesDetails> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionVolumesDetails>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
