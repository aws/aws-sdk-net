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
    /// The properties for a task definition that describes the container and volume definitions
    /// of an Amazon ECS task. You can specify which Docker images to use, the required resources,
    /// and other configurations related to launching the task definition through an Amazon
    /// ECS service or task.
    /// </summary>
    public partial class EcsTaskProperties
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// This object is a list of containers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TaskContainerProperties> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskContainerProperties>() : null;

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
        /// The amount of ephemeral storage to allocate for the task. This parameter is used to
        /// expand the total amount of ephemeral storage available, beyond the default amount,
        /// for tasks hosted on Fargate.
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
        /// The Amazon Resource Name (ARN) of the execution role that Batch can assume. For jobs
        /// that run on Fargate resources, you must provide an execution role. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/execution-IAM-role.html">Batch
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
        /// are <c>host</c>, <c>task</c>, or <c>none</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>host</c> is specified, all containers within the tasks that specified the <c>host</c>
        /// IPC mode on the same container instance share the same IPC resources with the host
        /// Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// If <c>task</c> is specified, all containers within the specified <c>task</c> share
        /// the same IPC resources.
        /// </para>
        ///  
        /// <para>
        /// If <c>none</c> is specified, the IPC resources within the containers of a task are
        /// private, and are not shared with other containers in a task or on the container instance.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, then the IPC resource namespace sharing depends on the Docker
        /// daemon setting on the container instance. For more information, see <a href="https://docs.docker.com/engine/reference/run/#ipc-settings---ipc">IPC
        /// settings</a> in the Docker run reference.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for jobs that run on Fargate resources.
        /// </para>
        ///  </note>
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
        /// are running on Amazon EC2 resources or Amazon ECS Managed Instances must not specify
        /// this parameter.
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
        /// The network mode to use for the task. Valid values: <c>host</c>. When not specified,
        /// the default is <c>host</c>.
        /// </para>
        ///  
        /// <para>
        /// With <c>host</c> mode, the container shares the host instance's network stack directly.
        /// When running tasks that use the <c>host</c> network mode, do not run containers using
        /// the root user (UID 0). Running as root grants unrestricted access to host resources
        /// and increases the attack surface.
        /// </para>
        ///  
        /// <para>
        /// This parameter only applies to jobs running on Amazon ECS Managed Instances (<c>MANAGED_INSTANCES</c>
        /// platform capability). It cannot be specified for Fargate or Amazon EC2 platform job
        /// definitions.
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
        /// <c>host</c> or <c>task</c>. For example, monitoring sidecars might need <c>pidMode</c>
        /// to access information about other containers running in the same task.
        /// </para>
        ///  
        /// <para>
        /// If <c>host</c> is specified, all containers within the tasks that specified the <c>host</c>
        /// PID mode on the same container instance share the process namespace with the host
        /// Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// If <c>task</c> is specified, all containers within the specified task share the same
        /// process namespace.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the default is a private namespace for each container. For
        /// more information, see <a href="https://docs.docker.com/engine/reference/run/#pid-settings---pid">PID
        /// settings</a> in the Docker run reference.
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
        /// The Fargate platform version where the jobs are running. A platform version is specified
        /// only for jobs that are running on Fargate resources. If one isn't specified, the <c>LATEST</c>
        /// platform version is used by default. This uses a recent, approved version of the Fargate
        /// platform for compute resources. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// platform versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// or Amazon ECS Managed Instances. Use this to specify the operating system family (<c>operatingSystemFamily</c>)
        /// and CPU architecture (<c>cpuArchitecture</c>).
        /// </para>
        ///  
        /// <para>
        /// For Amazon ECS Managed Instances, the valid value for <c>operatingSystemFamily</c>
        /// is <c>LINUX</c> (default). The valid values for <c>cpuArchitecture</c> are <c>X86_64</c>
        /// and <c>ARM64</c>.
        /// </para>
        /// </summary>
        public RuntimePlatform RuntimePlatform { get; set; }

        /// <summary>
        /// Checks to see if the RuntimePlatform property is set.
        /// </summary>
        internal bool IsSetRuntimePlatform() => this.RuntimePlatform != null;

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that's associated with the Amazon ECS task.
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
        /// A list of volumes that are associated with the job.
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
