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
    /// Container for the parameters to the StartTask operation. Starts a new task from the
    /// specified task definition on the specified container instance or instances. <note>
    /// <para> On March 21, 2024, a change was made to resolve the task definition revision
    /// before authorization. When a task definition revision is not specified, authorization
    /// will occur using the latest revision of a task definition. </para> </note> <note>
    /// <para> Amazon Elastic Inference (EI) is no longer available to customers. </para>
    /// </note> <para> Alternatively, you can use<c>RunTask</c> to place tasks for you. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
    /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>. </para>
    /// <para> You can attach Amazon EBS volumes to Amazon ECS tasks by configuring the volume
    /// when creating or updating a service. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volume-types">Amazon
    /// EBS volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>. </para>
    /// </summary>
    public partial class StartTaskRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster where to start your
        /// task. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property ContainerInstances. 
        /// <para>
        /// The container instance IDs or full ARN entries for the container instances where you
        /// would like to place your task. You can specify up to 10 container instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ContainerInstances { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContainerInstances property is set.
        /// </summary>
        internal bool IsSetContainerInstances() => this.ContainerInstances != null && (this.ContainerInstances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether to use Amazon ECS managed tags for the task. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableECSManagedTags { get; set; }

        /// <summary>
        /// Checks to see if the EnableECSManagedTags property is set.
        /// </summary>
        internal bool IsSetEnableECSManagedTags() => this.EnableECSManagedTags.HasValue;

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Whether or not the execute command functionality is turned on for the task. If <c>true</c>,
        /// this turns on the execute command functionality on all containers in the task.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand { get; set; }

        /// <summary>
        /// Checks to see if the EnableExecuteCommand property is set.
        /// </summary>
        internal bool IsSetEnableExecuteCommand() => this.EnableExecuteCommand.HasValue;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the task group to associate with the task. The default value is the family
        /// name of the task definition (for example, family:my-family-name).
        /// </para>
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The VPC subnet and security group configuration for tasks that receive their own elastic
        /// network interface by using the <c>awsvpc</c> networking mode.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of container overrides in JSON format that specify the name of a container
        /// in the specified task definition and the overrides it receives. You can override the
        /// default command for a container (that's specified in the task definition or Docker
        /// image) with a <c>command</c> override. You can also override existing environment
        /// variables (that are specified in the task definition or Docker image) on a container
        /// or add new environment variables to it with an <c>environment</c> override.
        /// </para>
        ///  <note> 
        /// <para>
        /// A total of 8192 characters are allowed for overrides. This limit includes the JSON
        /// formatting characters of the override structure.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskOverride Overrides { get; set; }

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the task definition or the service to
        /// the task. If no value is specified, the tags aren't propagated.
        /// </para>
        /// </summary>
        public PropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// This parameter is only used by Amazon ECS. It is not intended for use by customers.
        /// </para>
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// An optional tag specified when a task is started. For example, if you automatically
        /// trigger a task to run a batch process job, you could apply a unique identifier for
        /// that job to your task with the <c>startedBy</c> parameter. You can then identify which
        /// tasks belong to that job by filtering the results of a <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListTasks.html">ListTasks</a>
        /// call with the <c>startedBy</c> value. Up to 36 letters (uppercase and lowercase),
        /// numbers, hyphens (-), forward slash (/), and underscores (_) are allowed.
        /// </para>
        ///  
        /// <para>
        /// If a task is started by an Amazon ECS service, the <c>startedBy</c> parameter contains
        /// the deployment ID of the service that starts it.
        /// </para>
        /// </summary>
        public string StartedBy { get; set; }

        /// <summary>
        /// Checks to see if the StartedBy property is set.
        /// </summary>
        internal bool IsSetStartedBy() => this.StartedBy != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task to help you categorize and organize them.
        /// Each tag consists of a key and an optional value, both of which you define.
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <c>family</c> and <c>revision</c> (<c>family:revision</c>) or full ARN of the
        /// task definition to start. If a <c>revision</c> isn't specified, the latest <c>ACTIVE</c>
        /// revision is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinition property is set.
        /// </summary>
        internal bool IsSetTaskDefinition() => this.TaskDefinition != null;

        /// <summary>
        /// Gets and sets the property VolumeConfigurations. 
        /// <para>
        /// The details of the volume that was <c>configuredAtLaunch</c>. You can configure the
        /// size, volumeType, IOPS, throughput, snapshot and encryption in <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TaskManagedEBSVolumeConfiguration.html">TaskManagedEBSVolumeConfiguration</a>.
        /// The <c>name</c> of the volume must match the <c>name</c> from the task definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskVolumeConfiguration> VolumeConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskVolumeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the VolumeConfigurations property is set.
        /// </summary>
        internal bool IsSetVolumeConfigurations() => this.VolumeConfigurations != null && (this.VolumeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
