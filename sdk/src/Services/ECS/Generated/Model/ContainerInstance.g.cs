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
    /// An Amazon EC2 or External instance that's running the Amazon ECS agent and has been
    /// registered with a cluster.
    /// </summary>
    public partial class ContainerInstance
    {
        /// <summary>
        /// Gets and sets the property AgentConnected. 
        /// <para>
        /// This parameter returns <c>true</c> if the agent is connected to Amazon ECS. An instance
        /// with an agent that may be unhealthy or stopped return <c>false</c>. Only instances
        /// connected to an agent can accept task placement requests.
        /// </para>
        /// </summary>
        public bool? AgentConnected { get; set; }

        /// <summary>
        /// Checks to see if the AgentConnected property is set.
        /// </summary>
        internal bool IsSetAgentConnected() => this.AgentConnected.HasValue;

        /// <summary>
        /// Gets and sets the property AgentUpdateStatus. 
        /// <para>
        /// The status of the most recent agent update. If an update wasn't ever requested, this
        /// value is <c>NULL</c>.
        /// </para>
        /// </summary>
        public AgentUpdateStatus AgentUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentUpdateStatus property is set.
        /// </summary>
        internal bool IsSetAgentUpdateStatus() => this.AgentUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The resources attached to a container instance, such as an elastic network interface.
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
        /// The attributes set for the container instance, either by the Amazon ECS container
        /// agent at instance registration or manually with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAttributes.html">PutAttributes</a>
        /// operation.
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
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The capacity provider that's associated with the container instance.
        /// </para>
        /// </summary>
        public string CapacityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderName property is set.
        /// </summary>
        internal bool IsSetCapacityProviderName() => this.CapacityProviderName != null;

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance. For more information about
        /// the ARN format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerInstanceArn property is set.
        /// </summary>
        internal bool IsSetContainerInstanceArn() => this.ContainerInstanceArn != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The ID of the container instance. For Amazon EC2 instances, this value is the Amazon
        /// EC2 instance ID. For external instances, this value is the Amazon Web Services Systems
        /// Manager managed instance ID.
        /// </para>
        /// </summary>
        public string Ec2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceId property is set.
        /// </summary>
        internal bool IsSetEc2InstanceId() => this.Ec2InstanceId != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// An object representing the health status of the container instance.
        /// </para>
        /// </summary>
        public ContainerInstanceHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property PendingTasksCount. 
        /// <para>
        /// The number of tasks on the container instance that are in the <c>PENDING</c> status.
        /// </para>
        /// </summary>
        public int? PendingTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingTasksCount property is set.
        /// </summary>
        internal bool IsSetPendingTasksCount() => this.PendingTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the container instance was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredAt property is set.
        /// </summary>
        internal bool IsSetRegisteredAt() => this.RegisteredAt.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredResources. 
        /// <para>
        /// For CPU and memory resource types, this parameter describes the amount of each resource
        /// that was available on the container instance when the container agent registered it
        /// with Amazon ECS. This value represents the total amount of CPU and memory that can
        /// be allocated on this container instance to tasks. For port resource types, this parameter
        /// describes the ports that were reserved by the Amazon ECS container agent when it registered
        /// the container instance with Amazon ECS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> RegisteredResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the RegisteredResources property is set.
        /// </summary>
        internal bool IsSetRegisteredResources() => this.RegisteredResources != null && (this.RegisteredResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemainingResources. 
        /// <para>
        /// For CPU and memory resource types, this parameter describes the remaining CPU and
        /// memory that wasn't already allocated to tasks and is therefore available for new tasks.
        /// For port resource types, this parameter describes the ports that were reserved by
        /// the Amazon ECS container agent (at instance registration time) and any task containers
        /// that have reserved port mappings on the host (with the <c>host</c> or <c>bridge</c>
        /// network mode). Any port that's not specified here is available for new tasks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> RemainingResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the RemainingResources property is set.
        /// </summary>
        internal bool IsSetRemainingResources() => this.RemainingResources != null && (this.RemainingResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks on the container instance that have a desired status (<c>desiredStatus</c>)
        /// of <c>RUNNING</c>.
        /// </para>
        /// </summary>
        public int? RunningTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningTasksCount property is set.
        /// </summary>
        internal bool IsSetRunningTasksCount() => this.RunningTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the container instance. The valid values are <c>REGISTERING</c>, <c>REGISTRATION_FAILED</c>,
        /// <c>ACTIVE</c>, <c>INACTIVE</c>, <c>DEREGISTERING</c>, or <c>DRAINING</c>.
        /// </para>
        ///  
        /// <para>
        /// If your account has opted in to the <c>awsvpcTrunking</c> account setting, then any
        /// newly registered container instance will transition to a <c>REGISTERING</c> status
        /// while the trunk elastic network interface is provisioned for the instance. If the
        /// registration fails, the instance will transition to a <c>REGISTRATION_FAILED</c> status.
        /// You can describe the container instance and see the reason for failure in the <c>statusReason</c>
        /// parameter. Once the container instance is terminated, the instance transitions to
        /// a <c>DEREGISTERING</c> status while the trunk elastic network interface is deprovisioned.
        /// The instance then transitions to an <c>INACTIVE</c> status.
        /// </para>
        ///  
        /// <para>
        /// The <c>ACTIVE</c> status indicates that the container instance can accept tasks. The
        /// <c>DRAINING</c> indicates that new tasks aren't placed on the container instance and
        /// any service tasks running on the container instance are removed if possible. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-draining.html">Container
        /// instance draining</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that the container instance reached its current status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the container instance to help you categorize and organize
        /// them. Each tag consists of a key and an optional value. You define both.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version counter for the container instance. Every time a container instance experiences
        /// a change that triggers a CloudWatch event, the version counter is incremented. If
        /// you're replicating your Amazon ECS container instance state with CloudWatch Events,
        /// you can compare the version of a container instance reported by the Amazon ECS APIs
        /// with the version reported in CloudWatch Events for the container instance (inside
        /// the <c>detail</c> object) to verify that the version in your event stream is current.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;

        /// <summary>
        /// Gets and sets the property VersionInfo. 
        /// <para>
        /// The version information for the Amazon ECS container agent and Docker daemon running
        /// on the container instance.
        /// </para>
        /// </summary>
        public VersionInfo VersionInfo { get; set; }

        /// <summary>
        /// Checks to see if the VersionInfo property is set.
        /// </summary>
        internal bool IsSetVersionInfo() => this.VersionInfo != null;
    }
}
