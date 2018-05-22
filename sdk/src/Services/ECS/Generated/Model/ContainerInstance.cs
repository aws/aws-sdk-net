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
    /// An EC2 instance that is running the Amazon ECS agent and has been registered with
    /// a cluster.
    /// </summary>
    public partial class ContainerInstance
    {
        private bool? _agentConnected;
        private AgentUpdateStatus _agentUpdateStatus;
        private List<Attachment> _attachments = new List<Attachment>();
        private List<Attribute> _attributes = new List<Attribute>();
        private string _containerInstanceArn;
        private string _ec2InstanceId;
        private int? _pendingTasksCount;
        private DateTime? _registeredAt;
        private List<Resource> _registeredResources = new List<Resource>();
        private List<Resource> _remainingResources = new List<Resource>();
        private int? _runningTasksCount;
        private string _status;
        private long? _version;
        private VersionInfo _versionInfo;

        /// <summary>
        /// Gets and sets the property AgentConnected. 
        /// <para>
        /// This parameter returns <code>true</code> if the agent is connected to Amazon ECS.
        /// Registered instances with an agent that may be unhealthy or stopped return <code>false</code>.
        /// Instances without a connected agent can't accept placement requests.
        /// </para>
        /// </summary>
        public bool AgentConnected
        {
            get { return this._agentConnected.GetValueOrDefault(); }
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
        /// The status of the most recent agent update. If an update has never been requested,
        /// this value is <code>NULL</code>.
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
        /// The Elastic Network Interfaces associated with the container instance.
        /// </para>
        /// </summary>
        public List<Attachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes set for the container instance, either by the Amazon ECS container
        /// agent at instance registration or manually with the <a>PutAttributes</a> operation.
        /// </para>
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance. The ARN contains the <code>arn:aws:ecs</code>
        /// namespace, followed by the region of the container instance, the AWS account ID of
        /// the container instance owner, the <code>container-instance</code> namespace, and then
        /// the container instance ID. For example, <code>arn:aws:ecs:<i>region</i>:<i>aws_account_id</i>:container-instance/<i>container_instance_ID</i>
        /// </code>.
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
        /// The EC2 instance ID of the container instance.
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
        /// Gets and sets the property PendingTasksCount. 
        /// <para>
        /// The number of tasks on the container instance that are in the <code>PENDING</code>
        /// status.
        /// </para>
        /// </summary>
        public int PendingTasksCount
        {
            get { return this._pendingTasksCount.GetValueOrDefault(); }
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
        /// The Unix time stamp for when the container instance was registered.
        /// </para>
        /// </summary>
        public DateTime RegisteredAt
        {
            get { return this._registeredAt.GetValueOrDefault(); }
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
        /// with Amazon ECS; this value represents the total amount of CPU and memory that can
        /// be allocated on this container instance to tasks. For port resource types, this parameter
        /// describes the ports that were reserved by the Amazon ECS container agent when it registered
        /// the container instance with Amazon ECS.
        /// </para>
        /// </summary>
        public List<Resource> RegisteredResources
        {
            get { return this._registeredResources; }
            set { this._registeredResources = value; }
        }

        // Check to see if RegisteredResources property is set
        internal bool IsSetRegisteredResources()
        {
            return this._registeredResources != null && this._registeredResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemainingResources. 
        /// <para>
        /// For CPU and memory resource types, this parameter describes the remaining CPU and
        /// memory that has not already been allocated to tasks and is therefore available for
        /// new tasks. For port resource types, this parameter describes the ports that were reserved
        /// by the Amazon ECS container agent (at instance registration time) and any task containers
        /// that have reserved port mappings on the host (with the <code>host</code> or <code>bridge</code>
        /// network mode). Any port that is not specified here is available for new tasks.
        /// </para>
        /// </summary>
        public List<Resource> RemainingResources
        {
            get { return this._remainingResources; }
            set { this._remainingResources = value; }
        }

        // Check to see if RemainingResources property is set
        internal bool IsSetRemainingResources()
        {
            return this._remainingResources != null && this._remainingResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks on the container instance that are in the <code>RUNNING</code>
        /// status.
        /// </para>
        /// </summary>
        public int RunningTasksCount
        {
            get { return this._runningTasksCount.GetValueOrDefault(); }
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
        /// The status of the container instance. The valid values are <code>ACTIVE</code>, <code>INACTIVE</code>,
        /// or <code>DRAINING</code>. <code>ACTIVE</code> indicates that the container instance
        /// can accept tasks. <code>DRAINING</code> indicates that new tasks are not placed on
        /// the container instance and any service tasks running on the container instance are
        /// removed if possible. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-draining.html">Container
        /// Instance Draining</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version counter for the container instance. Every time a container instance experiences
        /// a change that triggers a CloudWatch event, the version counter is incremented. If
        /// you are replicating your Amazon ECS container instance state with CloudWatch Events,
        /// you can compare the version of a container instance reported by the Amazon ECS APIs
        /// with the version reported in CloudWatch Events for the container instance (inside
        /// the <code>detail</code> object) to verify that the version in your event stream is
        /// current.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
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