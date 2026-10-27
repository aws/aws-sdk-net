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
    /// Details on a task in a cluster.
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The Elastic Network Adapter that's associated with the task if the task uses the <c>awsvpc</c>
        /// network mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<Attachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the task
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the task.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The capacity provider that's associated with the task.
        /// </para>
        /// </summary>
        public string CapacityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderName property is set.
        /// </summary>
        internal bool IsSetCapacityProviderName() => this.CapacityProviderName != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN of the cluster that hosts the task.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        /// The connectivity status of a task.
        /// </para>
        /// </summary>
        public Connectivity Connectivity { get; set; }

        /// <summary>
        /// Checks to see if the Connectivity property is set.
        /// </summary>
        internal bool IsSetConnectivity() => this.Connectivity != null;

        /// <summary>
        /// Gets and sets the property ConnectivityAt. 
        /// <para>
        /// The Unix timestamp for the time when the task last went into <c>CONNECTED</c> status.
        /// </para>
        /// </summary>
        public DateTime? ConnectivityAt { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityAt property is set.
        /// </summary>
        internal bool IsSetConnectivityAt() => this.ConnectivityAt.HasValue;

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The ARN of the container instances that host the task.
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
        /// The containers that's associated with the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Container> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<Container>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the task as expressed in a task definition. It can
        /// be expressed as an integer using CPU units (for example, <c>1024</c>). It can also
        /// be expressed as a string using vCPUs (for example, <c>1 vCPU</c> or <c>1 vcpu</c>).
        /// String values are converted to an integer that indicates the CPU units when the task
        /// definition is registered.
        /// </para>
        ///  
        /// <para>
        /// If you're using the EC2 launch type or the external launch type, this field is optional.
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
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task was created. More specifically, it's
        /// for the time when the task entered the <c>PENDING</c> state.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredStatus. 
        /// <para>
        /// The desired status of the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-lifecycle.html">Task
        /// Lifecycle</a>.
        /// </para>
        /// </summary>
        public string DesiredStatus { get; set; }

        /// <summary>
        /// Checks to see if the DesiredStatus property is set.
        /// </summary>
        internal bool IsSetDesiredStatus() => this.DesiredStatus != null;

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
        /// The ephemeral storage settings for the task.
        /// </para>
        /// </summary>
        public EphemeralStorage EphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the EphemeralStorage property is set.
        /// </summary>
        internal bool IsSetEphemeralStorage() => this.EphemeralStorage != null;

        /// <summary>
        /// Gets and sets the property ExecutionStoppedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task execution stopped.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStoppedAt property is set.
        /// </summary>
        internal bool IsSetExecutionStoppedAt() => this.ExecutionStoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FargateEphemeralStorage. 
        /// <para>
        /// The Fargate ephemeral storage settings for the task.
        /// </para>
        /// </summary>
        public TaskEphemeralStorage FargateEphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the FargateEphemeralStorage property is set.
        /// </summary>
        internal bool IsSetFargateEphemeralStorage() => this.FargateEphemeralStorage != null;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the task group that's associated with the task.
        /// </para>
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status for the task. It's determined by the health of the essential containers
        /// in the task. If all essential containers in the task are reporting as <c>HEALTHY</c>,
        /// the task status also reports as <c>HEALTHY</c>. If any essential containers in the
        /// task are reporting as <c>UNHEALTHY</c> or <c>UNKNOWN</c>, the task status also reports
        /// as <c>UNHEALTHY</c> or <c>UNKNOWN</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent doesn't monitor or report on Docker health checks that
        /// are embedded in a container image and not specified in the container definition. For
        /// example, this includes those specified in a parent image or from the image's Dockerfile.
        /// Health check parameters that are specified in a container definition override any
        /// Docker health checks that are found in the container image.
        /// </para>
        ///  </note>
        /// </summary>
        public HealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

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
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status for the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-lifecycle.html">Task
        /// Lifecycle</a>.
        /// </para>
        /// </summary>
        public string LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The infrastructure where your task runs on. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public LaunchType LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) that the task uses as expressed in a task definition.
        /// It can be expressed as an integer using MiB (for example, <c>1024</c>). If it's expressed
        /// as a string using GB (for example, <c>1GB</c> or <c>1 GB</c>), it's converted to an
        /// integer indicating the MiB when the task definition is registered.
        /// </para>
        ///  
        /// <para>
        /// If you use the EC2 launch type, this field is optional.
        /// </para>
        ///  
        /// <para>
        /// If you use the Fargate launch type, this field is required. You must use one of the
        /// following values. The value that you choose determines the range of supported values
        /// for the <c>cpu</c> parameter.
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
        /// Gets and sets the property Overrides. 
        /// <para>
        /// One or more container overrides.
        /// </para>
        /// </summary>
        public TaskOverride Overrides { get; set; }

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null;

        /// <summary>
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The operating system that your tasks are running on. A platform family is specified
        /// only for tasks that use the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks that run as part of this service must use the same <c>platformFamily</c>
        /// value as the service (for example, <c>LINUX.</c>).
        /// </para>
        /// </summary>
        public string PlatformFamily { get; set; }

        /// <summary>
        /// Checks to see if the PlatformFamily property is set.
        /// </summary>
        internal bool IsSetPlatformFamily() => this.PlatformFamily != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version where your task runs on. A platform version is only specified
        /// for tasks that use the Fargate launch type. If you didn't specify one, the <c>LATEST</c>
        /// platform version is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// Platform Versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property PullStartedAt. 
        /// <para>
        /// The Unix timestamp for the time when the container image pull began.
        /// </para>
        /// </summary>
        public DateTime? PullStartedAt { get; set; }

        /// <summary>
        /// Checks to see if the PullStartedAt property is set.
        /// </summary>
        internal bool IsSetPullStartedAt() => this.PullStartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PullStoppedAt. 
        /// <para>
        /// The Unix timestamp for the time when the container image pull completed.
        /// </para>
        /// </summary>
        public DateTime? PullStoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the PullStoppedAt property is set.
        /// </summary>
        internal bool IsSetPullStoppedAt() => this.PullStoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task started. More specifically, it's for
        /// the time when the task transitioned from the <c>PENDING</c> state to the <c>RUNNING</c>
        /// state.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The tag specified when a task is started. If an Amazon ECS service started the task,
        /// the <c>startedBy</c> parameter contains the deployment ID of that service.
        /// </para>
        /// </summary>
        public string StartedBy { get; set; }

        /// <summary>
        /// Checks to see if the StartedBy property is set.
        /// </summary>
        internal bool IsSetStartedBy() => this.StartedBy != null;

        /// <summary>
        /// Gets and sets the property StopCode. 
        /// <para>
        /// The stop code indicating why a task was stopped. The <c>stoppedReason</c> might contain
        /// additional details. 
        /// </para>
        ///  
        /// <para>
        /// For more information about stop code, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/stopped-task-error-codes.html">Stopped
        /// tasks error codes</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public TaskStopCode StopCode { get; set; }

        /// <summary>
        /// Checks to see if the StopCode property is set.
        /// </summary>
        internal bool IsSetStopCode() => this.StopCode != null;

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task was stopped. More specifically, it's
        /// for the time when the task transitioned from the <c>RUNNING</c> state to the <c>STOPPED</c>
        /// state.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StoppedReason. 
        /// <para>
        /// The reason that the task was stopped.
        /// </para>
        /// </summary>
        public string StoppedReason { get; set; }

        /// <summary>
        /// Checks to see if the StoppedReason property is set.
        /// </summary>
        internal bool IsSetStoppedReason() => this.StoppedReason != null;

        /// <summary>
        /// Gets and sets the property StoppingAt. 
        /// <para>
        /// The Unix timestamp for the time when the task stops. More specifically, it's for the
        /// time when the task transitions from the <c>RUNNING</c> state to <c>STOPPING</c>.
        /// </para>
        /// </summary>
        public DateTime? StoppingAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppingAt property is set.
        /// </summary>
        internal bool IsSetStoppingAt() => this.StoppingAt.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task to help you categorize and organize the task.
        /// Each tag consists of a key and an optional value. You define both the key and value.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of the task definition that creates the task.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetTaskDefinitionArn() => this.TaskDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version counter for the task. Every time a task experiences a change that starts
        /// a CloudWatch event, the version counter is incremented. If you replicate your Amazon
        /// ECS task state with CloudWatch Events, you can compare the version of a task reported
        /// by the Amazon ECS API actions with the version reported in CloudWatch Events for the
        /// task (inside the <c>detail</c> object) to verify that the version in your event stream
        /// is current.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
