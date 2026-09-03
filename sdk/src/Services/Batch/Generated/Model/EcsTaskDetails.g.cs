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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The details of a task definition that describes the container and volume definitions
    /// of an Amazon ECS task.
    /// </summary>
    public partial class EcsTaskDetails
    {
        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance that hosts the task.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerInstanceArn property is set.
        /// </summary>
        internal bool IsSetContainerInstanceArn() => this.ContainerInstanceArn != null;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// A list of containers that are included in the <c>taskProperties</c> list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskContainerDetails> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskContainerDetails>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether execute command functionality is turned on for this task. If <c>true</c>,
        /// execute command functionality is turned on all the containers in the task.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand { get; set; }

        /// <summary>
        /// Checks to see if the EnableExecuteCommand property is set.
        /// </summary>
        internal bool IsSetEnableExecuteCommand() => this.EnableExecuteCommand.HasValue;

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The amount of ephemeral storage allocated for the task.
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
        /// The Amazon Resource Name (ARN) of the execution role that Batch can assume. For more
        /// information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/execution-IAM-role.html">Batch
        /// execution IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property IpcMode. 
        /// <para>
        /// The IPC resource namespace to use for the containers in the task. The valid values
        /// are <c>host</c>, <c>task</c>, or <c>none</c>. For more information see <c>ipcMode</c>
        /// in <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_EcsTaskProperties.html">EcsTaskProperties</a>.
        /// </para>
        /// </summary>
        public string IpcMode { get; set; }

        /// <summary>
        /// Checks to see if the IpcMode property is set.
        /// </summary>
        internal bool IsSetIpcMode() => this.IpcMode != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on Amazon EC2 resources must not specify this parameter.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkMode. 
        /// <para>
        /// The network mode configured for the task. This field is populated for jobs running
        /// on Amazon ECS Managed Instances (<c>MANAGED_INSTANCES</c> platform capability) and
        /// always returns <c>host</c>.
        /// </para>
        /// </summary>
        public string NetworkMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMode property is set.
        /// </summary>
        internal bool IsSetNetworkMode() => this.NetworkMode != null;

        /// <summary>
        /// Gets and sets the property PidMode. 
        /// <para>
        /// The process namespace to use for the containers in the task. The valid values are
        /// <c>host</c>, or <c>task</c>. For more information see <c>pidMode</c> in <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_EcsTaskProperties.html">EcsTaskProperties</a>.
        /// </para>
        /// </summary>
        public string PidMode { get; set; }

        /// <summary>
        /// Checks to see if the PidMode property is set.
        /// </summary>
        internal bool IsSetPidMode() => this.PidMode != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The Fargate platform version where the jobs are running.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// An object that represents the compute environment architecture for Batch jobs on Fargate
        /// or Amazon ECS Managed Instances. Contains the operating system family and CPU architecture
        /// of the task.
        /// </para>
        /// </summary>
        public RuntimePlatform RuntimePlatform { get; set; }

        /// <summary>
        /// Checks to see if the RuntimePlatform property is set.
        /// </summary>
        internal bool IsSetRuntimePlatform() => this.RuntimePlatform != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the Amazon ECS task.
        /// </para>
        /// </summary>
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the container can assume for Amazon
        /// Web Services permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// roles for tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is object is comparable to <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_ContainerProperties.html">ContainerProperties:jobRoleArn</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string TaskRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskRoleArn property is set.
        /// </summary>
        internal bool IsSetTaskRoleArn() => this.TaskRoleArn != null;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// A list of data volumes used in a job.
        /// </para>
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
