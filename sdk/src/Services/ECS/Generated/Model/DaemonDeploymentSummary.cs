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
    /// A summary of a daemon deployment.
    /// </summary>
    public partial class DaemonDeploymentSummary
    {
        private string _clusterArn;
        private DateTime? _createdAt;
        private string _daemonArn;
        private string _daemonDeploymentArn;
        private DateTime? _finishedAt;
        private DateTime? _startedAt;
        private DaemonDeploymentStatus _status;
        private string _statusReason;
        private DateTime? _stoppedAt;
        private string _targetDaemonRevisionArn;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that hosts the daemon.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the daemon deployment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon.
        /// </para>
        /// </summary>
        public string DaemonArn
        {
            get { return this._daemonArn; }
            set { this._daemonArn = value; }
        }

        // Check to see if DaemonArn property is set
        internal bool IsSetDaemonArn()
        {
            return this._daemonArn != null;
        }

        /// <summary>
        /// Gets and sets the property DaemonDeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon deployment.
        /// </para>
        /// </summary>
        public string DaemonDeploymentArn
        {
            get { return this._daemonDeploymentArn; }
            set { this._daemonDeploymentArn = value; }
        }

        // Check to see if DaemonDeploymentArn property is set
        internal bool IsSetDaemonDeploymentArn()
        {
            return this._daemonDeploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The time the daemon deployment finished.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt
        {
            get { return this._finishedAt; }
            set { this._finishedAt = value; }
        }

        // Check to see if FinishedAt property is set
        internal bool IsSetFinishedAt()
        {
            return this._finishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the daemon deployment started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the daemon deployment.
        /// </para>
        /// </summary>
        public DaemonDeploymentStatus Status
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
        /// Information about why the daemon deployment is in the current status.
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
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The time the daemon deployment stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetDaemonRevisionArn. 
        /// <para>
        /// The ARN of the daemon revision being deployed.
        /// </para>
        /// </summary>
        public string TargetDaemonRevisionArn
        {
            get { return this._targetDaemonRevisionArn; }
            set { this._targetDaemonRevisionArn = value; }
        }

        // Check to see if TargetDaemonRevisionArn property is set
        internal bool IsSetTargetDaemonRevisionArn()
        {
            return this._targetDaemonRevisionArn != null;
        }

    }
}