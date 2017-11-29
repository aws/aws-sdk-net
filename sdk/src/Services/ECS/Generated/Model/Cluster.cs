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
    /// A regional grouping of one or more container instances on which you can run task requests.
    /// Each account receives a default cluster the first time you use the Amazon ECS service,
    /// but you may also create other clusters. Clusters may contain more than one instance
    /// type simultaneously.
    /// </summary>
    public partial class Cluster
    {
        private int? _activeServicesCount;
        private string _clusterArn;
        private string _clusterName;
        private int? _pendingTasksCount;
        private int? _registeredContainerInstancesCount;
        private int? _runningTasksCount;
        private List<KeyValuePair> _statistics = new List<KeyValuePair>();
        private string _status;

        /// <summary>
        /// Gets and sets the property ActiveServicesCount. 
        /// <para>
        /// The number of services that are running on the cluster in an <code>ACTIVE</code> state.
        /// You can view these services with <a>ListServices</a>.
        /// </para>
        /// </summary>
        public int ActiveServicesCount
        {
            get { return this._activeServicesCount.GetValueOrDefault(); }
            set { this._activeServicesCount = value; }
        }

        // Check to see if ActiveServicesCount property is set
        internal bool IsSetActiveServicesCount()
        {
            return this._activeServicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster. The ARN contains the <code>arn:aws:ecs</code>
        /// namespace, followed by the region of the cluster, the AWS account ID of the cluster
        /// owner, the <code>cluster</code> namespace, and then the cluster name. For example,
        /// <code>arn:aws:ecs:<i>region</i>:<i>012345678910</i>:cluster/<i>test</i> </code>..
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A user-generated string that you use to identify your cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property PendingTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <code>PENDING</code> state.
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
        /// Gets and sets the property RegisteredContainerInstancesCount. 
        /// <para>
        /// The number of container instances registered into the cluster.
        /// </para>
        /// </summary>
        public int RegisteredContainerInstancesCount
        {
            get { return this._registeredContainerInstancesCount.GetValueOrDefault(); }
            set { this._registeredContainerInstancesCount = value; }
        }

        // Check to see if RegisteredContainerInstancesCount property is set
        internal bool IsSetRegisteredContainerInstancesCount()
        {
            return this._registeredContainerInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <code>RUNNING</code> state.
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
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Additional information about your clusters that are separated by launch type, including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// runningEC2TasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RunningFargateTasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pendingEC2TasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pendingFargateTasksCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// activeEC2ServiceCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// activeFargateServiceCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// drainingEC2ServiceCount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// drainingFargateServiceCount
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<KeyValuePair> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. The valid values are <code>ACTIVE</code> or <code>INACTIVE</code>.
        /// <code>ACTIVE</code> indicates that you can register container instances with the cluster
        /// and the associated instances can accept tasks.
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

    }
}