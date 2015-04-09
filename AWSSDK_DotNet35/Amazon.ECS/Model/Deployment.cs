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
    /// 
    /// </summary>
    public partial class Deployment
    {
        private DateTime? _createdAt;
        private int? _desiredCount;
        private string _id;
        private int? _pendingCount;
        private int? _runningCount;
        private string _status;
        private string _taskDefinition;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix time in seconds and milliseconds when the service was created.
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
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The most recent desired count of tasks that was specified for the service to deploy
        /// and/or maintain.
        /// </para>
        /// </summary>
        public int DesiredCount
        {
            get { return this._desiredCount.GetValueOrDefault(); }
            set { this._desiredCount = value; }
        }

        // Check to see if DesiredCount property is set
        internal bool IsSetDesiredCount()
        {
            return this._desiredCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the deployment.
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
        /// Gets and sets the property PendingCount. 
        /// <para>
        /// The number of tasks in the deployment that are in the <code>PENDING</code> status.
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
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the deployment that are in the <code>RUNNING</code> status.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment. Valid values are <code>PRIMARY</code> (for the most
        /// recent deployment), <code>ACTIVE</code> (for previous deployments that still have
        /// tasks running, but are being replaced with the <code>PRIMARY</code> deployment), and
        /// <code>INACTIVE</code> (for deployments that have been completely replaced).
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The most recent task definition that was specified for the service to use.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix time in seconds and milliseconds when the service was last updated.
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