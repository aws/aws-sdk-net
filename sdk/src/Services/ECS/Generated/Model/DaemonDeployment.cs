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
    /// Information about a daemon deployment. A daemon deployment orchestrates the progressive
    /// rollout of daemon task updates across container instances.
    /// </summary>
    public partial class DaemonDeployment
    {
        private DaemonDeploymentAlarms _alarms;
        private DaemonCircuitBreaker _circuitBreaker;
        private string _clusterArn;
        private DateTime? _createdAt;
        private string _daemonDeploymentArn;
        private DaemonDeploymentConfiguration _deploymentConfiguration;
        private DateTime? _finishedAt;
        private DaemonRollback _rollback;
        private List<DaemonDeploymentRevisionDetail> _sourceDaemonRevisions = AWSConfigs.InitializeCollections ? new List<DaemonDeploymentRevisionDetail>() : null;
        private DateTime? _startedAt;
        private DaemonDeploymentStatus _status;
        private string _statusReason;
        private DateTime? _stoppedAt;
        private DaemonDeploymentRevisionDetail _targetDaemonRevision;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms that determine when a daemon deployment fails.
        /// </para>
        /// </summary>
        public DaemonDeploymentAlarms Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null;
        }

        /// <summary>
        /// Gets and sets the property CircuitBreaker. 
        /// <para>
        /// The circuit breaker configuration that determines when a daemon deployment has failed.
        /// </para>
        /// </summary>
        public DaemonCircuitBreaker CircuitBreaker
        {
            get { return this._circuitBreaker; }
            set { this._circuitBreaker = value; }
        }

        // Check to see if CircuitBreaker property is set
        internal bool IsSetCircuitBreaker()
        {
            return this._circuitBreaker != null;
        }

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
        /// The time the daemon deployment was created. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
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
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The deployment configuration used for this daemon deployment.
        /// </para>
        /// </summary>
        public DaemonDeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The time the daemon deployment finished. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
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
        /// Gets and sets the property Rollback. 
        /// <para>
        /// The rollback options for the daemon deployment.
        /// </para>
        /// </summary>
        public DaemonRollback Rollback
        {
            get { return this._rollback; }
            set { this._rollback = value; }
        }

        // Check to see if Rollback property is set
        internal bool IsSetRollback()
        {
            return this._rollback != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDaemonRevisions. 
        /// <para>
        /// The currently deployed daemon revisions that are being replaced.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonDeploymentRevisionDetail> SourceDaemonRevisions
        {
            get { return this._sourceDaemonRevisions; }
            set { this._sourceDaemonRevisions = value; }
        }

        // Check to see if SourceDaemonRevisions property is set
        internal bool IsSetSourceDaemonRevisions()
        {
            return this._sourceDaemonRevisions != null && (this._sourceDaemonRevisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the daemon deployment started. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
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
        /// The time the daemon deployment stopped. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
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
        /// Gets and sets the property TargetDaemonRevision. 
        /// <para>
        /// The daemon revision being deployed.
        /// </para>
        /// </summary>
        public DaemonDeploymentRevisionDetail TargetDaemonRevision
        {
            get { return this._targetDaemonRevision; }
            set { this._targetDaemonRevision = value; }
        }

        // Check to see if TargetDaemonRevision property is set
        internal bool IsSetTargetDaemonRevision()
        {
            return this._targetDaemonRevision != null;
        }

    }
}