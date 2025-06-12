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
    /// An Amazon EC2 or External instance that's running the Amazon ECS agent and has been
    /// registered with a cluster.
    /// </summary>
    public partial class ContainerInstance
    {
        private bool? _agentConnected;
        private AgentUpdateStatus _agentUpdateStatus;
        private List<Attachment> _attachments = AWSConfigs.InitializeCollections ? new List<Attachment>() : null;
        private List<Attribute> _attributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;
        private string _capacityProviderName;
        private string _containerInstanceArn;
        private string _ec2InstanceId;
        private ContainerInstanceHealthStatus _healthStatus;
        private int? _pendingTasksCount;
        private DateTime? _registeredAt;
        private List<Resource> _registeredResources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private List<Resource> _remainingResources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private int? _runningTasksCount;
        private string _status;
        private string _statusReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private long? _version;
        private VersionInfo _versionInfo;

        /// <summary>
        /// Gets and sets the property AgentConnected. 
        /// <para>
        /// This parameter returns <c>true</c> if the agent is connected to Amazon ECS. An instance
        /// with an agent that may be unhealthy or stopped return <c>false</c>. Only instances
        /// connected to an agent can accept task placement requests.
        /// </para>
        /// </summary>
        public bool? AgentConnected
        {
            get { return this._agentConnected; }
            set { this._agentConnected = value; }
        }

        // Check to see if AgentConnected property is set
        internal bool IsSetAgentConnected()
        {
            return this._agentConnected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AgentUpdateStatus. 
        /// <para>
        /// The status of the most recent agent update. If an update wasn't ever requested, this
        /// value is <c>NULL</c>.
        /// </para>
        /// </summary>
        public AgentUpdateStatus AgentUpdateStatus
        {
            get { return this._agentUpdateStatus; }
            set { this._agentUpdateStatus = value; }
        }

        // Check to see if AgentUpdateStatus property is set
        internal bool IsSetAgentUpdateStatus()
        {
            return this._agentUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The resources attached to a container instance, such as an elastic network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes set for the container instance, either by the Amazon ECS container
        /// agent at instance registration or manually with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAttributes.html">PutAttributes</a>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The capacity provider that's associated with the container instance.
        /// </para>
        /// </summary>
        public string CapacityProviderName
        {
            get { return this._capacityProviderName; }
            set { this._capacityProviderName = value; }
        }

        // Check to see if CapacityProviderName property is set
        internal bool IsSetCapacityProviderName()
        {
            return this._capacityProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance. For more information about
        /// the ARN format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn
        {
            get { return this._containerInstanceArn; }
            set { this._containerInstanceArn = value; }
        }

        // Check to see if ContainerInstanceArn property is set
        internal bool IsSetContainerInstanceArn()
        {
            return this._containerInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The ID of the container instance. For Amazon EC2 instances, this value is the Amazon
        /// EC2 instance ID. For external instances, this value is the Amazon Web Services Systems
        /// Manager managed instance ID.
        /// </para>
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// An object representing the health status of the container instance.
        /// </para>
        /// </summary>
        public ContainerInstanceHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PendingTasksCount. 
        /// <para>
        /// The number of tasks on the container instance that are in the <c>PENDING</c> status.
        /// </para>
        /// </summary>
        public int? PendingTasksCount
        {
            get { return this._pendingTasksCount; }
            set { this._pendingTasksCount = value; }
        }

        // Check to see if PendingTasksCount property is set
        internal bool IsSetPendingTasksCount()
        {
            return this._pendingTasksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the container instance was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt
        {
            get { return this._registeredAt; }
            set { this._registeredAt = value; }
        }

        // Check to see if RegisteredAt property is set
        internal bool IsSetRegisteredAt()
        {
            return this._registeredAt.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> RegisteredResources
        {
            get { return this._registeredResources; }
            set { this._registeredResources = value; }
        }

        // Check to see if RegisteredResources property is set
        internal bool IsSetRegisteredResources()
        {
            return this._registeredResources != null && (this._registeredResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> RemainingResources
        {
            get { return this._remainingResources; }
            set { this._remainingResources = value; }
        }

        // Check to see if RemainingResources property is set
        internal bool IsSetRemainingResources()
        {
            return this._remainingResources != null && (this._remainingResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks on the container instance that have a desired status (<c>desiredStatus</c>)
        /// of <c>RUNNING</c>.
        /// </para>
        /// </summary>
        public int? RunningTasksCount
        {
            get { return this._runningTasksCount; }
            set { this._runningTasksCount = value; }
        }

        // Check to see if RunningTasksCount property is set
        internal bool IsSetRunningTasksCount()
        {
            return this._runningTasksCount.HasValue; 
        }

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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that the container instance reached its current status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

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
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionInfo. 
        /// <para>
        /// The version information for the Amazon ECS container agent and Docker daemon running
        /// on the container instance.
        /// </para>
        /// </summary>
        public VersionInfo VersionInfo
        {
            get { return this._versionInfo; }
            set { this._versionInfo = value; }
        }

        // Check to see if VersionInfo property is set
        internal bool IsSetVersionInfo()
        {
            return this._versionInfo != null;
        }

    }
}