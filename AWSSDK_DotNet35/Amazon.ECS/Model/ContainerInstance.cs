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
    /// An Amazon EC2 instance that is running the Amazon ECS agent and has been registered
    /// with a cluster.
    /// </summary>
    public partial class ContainerInstance
    {
        private bool? _agentConnected;
        private AgentUpdateStatus _agentUpdateStatus;
        private string _containerInstanceArn;
        private string _ec2InstanceId;
        private int? _pendingTasksCount;
        private List<Resource> _registeredResources = new List<Resource>();
        private List<Resource> _remainingResources = new List<Resource>();
        private int? _runningTasksCount;
        private string _status;
        private VersionInfo _versionInfo;

        /// <summary>
        /// Gets and sets the property AgentConnected. 
        /// <para>
        /// This parameter returns <code>true</code> if the agent is actually connected to Amazon
        /// ECS. Registered instances with an agent that may be unhealthy or stopped will return
        /// <code>false</code>, and instances without a connected agent cannot accept placement
        /// request.
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
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance. The ARN contains the <code>arn:aws:ecs</code>
        /// namespace, followed by the region of the container instance, the AWS account ID of
        /// the container instance owner, the <code>container-instance</code> namespace, and then
        /// the container instance UUID. For example, arn:aws:ecs:<i>region</i>:<i>aws_account_id</i>:container-instance/<i>container_instance_UUID</i>.
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
        /// The Amazon EC2 instance ID of the container instance.
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
        /// Gets and sets the property RegisteredResources. 
        /// <para>
        /// The registered resources on the container instance that are in use by current tasks.
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
        /// The remaining resources of the container instance that are available for new tasks.
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
        /// The status of the container instance. The valid values are <code>ACTIVE</code> or
        /// <code>INACTIVE</code>. <code>ACTIVE</code> indicates that the container instance can
        /// accept tasks.
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