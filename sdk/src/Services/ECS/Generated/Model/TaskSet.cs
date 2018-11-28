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
    /// Information about a set of Amazon ECS tasks in an AWS CodeDeploy deployment. An Amazon
    /// ECS task set includes details such as the desired number of tasks, how many tasks
    /// are running, and whether the task set serves production traffic.
    /// </summary>
    public partial class TaskSet
    {
        private int? _computedDesiredCount;
        private DateTime? _createdAt;
        private string _externalId;
        private string _id;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private NetworkConfiguration _networkConfiguration;
        private int? _pendingCount;
        private string _platformVersion;
        private int? _runningCount;
        private Scale _scale;
        private StabilityStatus _stabilityStatus;
        private DateTime? _stabilityStatusAt;
        private string _startedBy;
        private string _status;
        private string _taskDefinition;
        private string _taskSetArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ComputedDesiredCount. 
        /// <para>
        /// The computed desired count for the task set. This is calculated by multiplying the
        /// service's <code>desiredCount</code> by the task set's <code>scale</code> percentage.
        /// </para>
        /// </summary>
        public int ComputedDesiredCount
        {
            get { return this._computedDesiredCount.GetValueOrDefault(); }
            set { this._computedDesiredCount = value; }
        }

        // Check to see if ComputedDesiredCount property is set
        internal bool IsSetComputedDesiredCount()
        {
            return this._computedDesiredCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for when the task set was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The deployment ID of the AWS CodeDeploy deployment.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the task set.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the tasks in the task set are using. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS Launch Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public LaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// Details on a load balancer that is used with a task set.
        /// </para>
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && this._loadBalancers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the task set.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PendingCount. 
        /// <para>
        /// The number of tasks in the task set that are in the <code>PENDING</code> status during
        /// a deployment. A task in the <code>PENDING</code> state is preparing to enter the <code>RUNNING</code>
        /// state. A task set enters the <code>PENDING</code> status when it launches for the
        /// first time, or when it is restarted after being in the <code>STOPPED</code> state.
        /// </para>
        /// </summary>
        public int PendingCount
        {
            get { return this._pendingCount.GetValueOrDefault(); }
            set { this._pendingCount = value; }
        }

        // Check to see if PendingCount property is set
        internal bool IsSetPendingCount()
        {
            return this._pendingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version on which the tasks in the task set are running. A platform version
        /// is only specified for tasks using the Fargate launch type. If one is not specified,
        /// the <code>LATEST</code> platform version is used by default. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
        /// Fargate Platform Versions</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the task set that are in the <code>RUNNING</code> status during
        /// a deployment. A task in the <code>RUNNING</code> state is running and ready for use.
        /// </para>
        /// </summary>
        public int RunningCount
        {
            get { return this._runningCount.GetValueOrDefault(); }
            set { this._runningCount = value; }
        }

        // Check to see if RunningCount property is set
        internal bool IsSetRunningCount()
        {
            return this._runningCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// A floating-point percentage of the desired number of tasks to place and keep running
        /// in the service.
        /// </para>
        /// </summary>
        public Scale Scale
        {
            get { return this._scale; }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale != null;
        }

        /// <summary>
        /// Gets and sets the property StabilityStatus. 
        /// <para>
        /// The stability status, which indicates whether the task set has reached a steady state.
        /// If the following conditions are met, the task set will be in <code>STEADY_STATE</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The task <code>runningCount</code> is equal to the <code>computedDesiredCount</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>pendingCount</code> is <code>0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are no tasks running on container instances in the <code>DRAINING</code> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All tasks are reporting a healthy status from the load balancers, service discovery,
        /// and container health checks.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If any of those conditions are not met, the stability status returns <code>STABILIZING</code>.
        /// </para>
        /// </summary>
        public StabilityStatus StabilityStatus
        {
            get { return this._stabilityStatus; }
            set { this._stabilityStatus = value; }
        }

        // Check to see if StabilityStatus property is set
        internal bool IsSetStabilityStatus()
        {
            return this._stabilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StabilityStatusAt. 
        /// <para>
        /// The Unix timestamp for when the task set stability status was retrieved.
        /// </para>
        /// </summary>
        public DateTime StabilityStatusAt
        {
            get { return this._stabilityStatusAt.GetValueOrDefault(); }
            set { this._stabilityStatusAt = value; }
        }

        // Check to see if StabilityStatusAt property is set
        internal bool IsSetStabilityStatusAt()
        {
            return this._stabilityStatusAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The tag specified when a task set is started. If the task is started by an AWS CodeDeploy
        /// deployment, then the <code>startedBy</code> parameter is <code>CODE_DEPLOY</code>.
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task set. The following describes each state:
        /// </para>
        ///  <dl> <dt>PRIMARY</dt> <dd> 
        /// <para>
        /// The task set is serving production traffic.
        /// </para>
        ///  </dd> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The task set is not serving production traffic.
        /// </para>
        ///  </dd> <dt>DRAINING</dt> <dd> 
        /// <para>
        /// The tasks in the task set are being stopped and their corresponding targets are being
        /// deregistered from their target group.
        /// </para>
        ///  </dd> </dl>
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition the task set is using.
        /// </para>
        /// </summary>
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property TaskSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task set.
        /// </para>
        /// </summary>
        public string TaskSetArn
        {
            get { return this._taskSetArn; }
            set { this._taskSetArn = value; }
        }

        // Check to see if TaskSetArn property is set
        internal bool IsSetTaskSetArn()
        {
            return this._taskSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for when the task set was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}