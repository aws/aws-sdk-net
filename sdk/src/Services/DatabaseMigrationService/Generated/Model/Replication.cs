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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a serverless replication created by the <c>CreateReplication</c>
    /// operation.
    /// </summary>
    public partial class Replication
    {
        private string _cdcStartPosition;
        private DateTime? _cdcStartTime;
        private string _cdcStopPosition;
        private List<string> _failureMessages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<PremigrationAssessmentStatus> _premigrationAssessmentStatuses = AWSConfigs.InitializeCollections ? new List<PremigrationAssessmentStatus>() : null;
        private ProvisionData _provisionData;
        private string _recoveryCheckpoint;
        private string _replicationConfigArn;
        private string _replicationConfigIdentifier;
        private DateTime? _replicationCreateTime;
        private DateTime? _replicationDeprovisionTime;
        private DateTime? _replicationLastStopTime;
        private ReplicationStats _replicationStats;
        private MigrationTypeValue _replicationType;
        private DateTime? _replicationUpdateTime;
        private string _sourceEndpointArn;
        private string _startReplicationType;
        private string _status;
        private string _stopReason;
        private string _targetEndpointArn;

        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        /// Indicates the start time for a change data capture (CDC) operation. Use either <c>CdcStartTime</c>
        /// or <c>CdcStartPosition</c> to specify when you want a CDC operation to start. Specifying
        /// both values results in an error.
        /// </para>
        /// </summary>
        public string CdcStartPosition
        {
            get { return this._cdcStartPosition; }
            set { this._cdcStartPosition = value; }
        }

        // Check to see if CdcStartPosition property is set
        internal bool IsSetCdcStartPosition()
        {
            return this._cdcStartPosition != null;
        }

        /// <summary>
        /// Gets and sets the property CdcStartTime. 
        /// <para>
        /// Indicates the start time for a change data capture (CDC) operation. Use either <c>CdcStartTime</c>
        /// or <c>CdcStartPosition</c> to specify when you want a CDC operation to start. Specifying
        /// both values results in an error.
        /// </para>
        /// </summary>
        public DateTime? CdcStartTime
        {
            get { return this._cdcStartTime; }
            set { this._cdcStartTime = value; }
        }

        // Check to see if CdcStartTime property is set
        internal bool IsSetCdcStartTime()
        {
            return this._cdcStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdcStopPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to stop. The value can
        /// be either server time or commit time.
        /// </para>
        /// </summary>
        public string CdcStopPosition
        {
            get { return this._cdcStopPosition; }
            set { this._cdcStopPosition = value; }
        }

        // Check to see if CdcStopPosition property is set
        internal bool IsSetCdcStopPosition()
        {
            return this._cdcStopPosition != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessages. 
        /// <para>
        /// Error and other information about why a serverless replication failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureMessages
        {
            get { return this._failureMessages; }
            set { this._failureMessages = value; }
        }

        // Check to see if FailureMessages property is set
        internal bool IsSetFailureMessages()
        {
            return this._failureMessages != null && (this._failureMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PremigrationAssessmentStatuses. 
        /// <para>
        /// The status output of premigration assessment in describe-replications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PremigrationAssessmentStatus> PremigrationAssessmentStatuses
        {
            get { return this._premigrationAssessmentStatuses; }
            set { this._premigrationAssessmentStatuses = value; }
        }

        // Check to see if PremigrationAssessmentStatuses property is set
        internal bool IsSetPremigrationAssessmentStatuses()
        {
            return this._premigrationAssessmentStatuses != null && (this._premigrationAssessmentStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisionData. 
        /// <para>
        /// Information about provisioning resources for an DMS serverless replication.
        /// </para>
        /// </summary>
        public ProvisionData ProvisionData
        {
            get { return this._provisionData; }
            set { this._provisionData = value; }
        }

        // Check to see if ProvisionData property is set
        internal bool IsSetProvisionData()
        {
            return this._provisionData != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryCheckpoint. 
        /// <para>
        /// Indicates the last checkpoint that occurred during a change data capture (CDC) operation.
        /// You can provide this value to the <c>CdcStartPosition</c> parameter to start a CDC
        /// operation that begins at that checkpoint.
        /// </para>
        /// </summary>
        public string RecoveryCheckpoint
        {
            get { return this._recoveryCheckpoint; }
            set { this._recoveryCheckpoint = value; }
        }

        // Check to see if RecoveryCheckpoint property is set
        internal bool IsSetRecoveryCheckpoint()
        {
            return this._recoveryCheckpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// The Amazon Resource Name for the <c>ReplicationConfig</c> associated with the replication.
        /// </para>
        /// </summary>
        public string ReplicationConfigArn
        {
            get { return this._replicationConfigArn; }
            set { this._replicationConfigArn = value; }
        }

        // Check to see if ReplicationConfigArn property is set
        internal bool IsSetReplicationConfigArn()
        {
            return this._replicationConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigIdentifier. 
        /// <para>
        /// The identifier for the <c>ReplicationConfig</c> associated with the replication.
        /// </para>
        /// </summary>
        public string ReplicationConfigIdentifier
        {
            get { return this._replicationConfigIdentifier; }
            set { this._replicationConfigIdentifier = value; }
        }

        // Check to see if ReplicationConfigIdentifier property is set
        internal bool IsSetReplicationConfigIdentifier()
        {
            return this._replicationConfigIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationCreateTime. 
        /// <para>
        /// The time the serverless replication was created.
        /// </para>
        /// </summary>
        public DateTime? ReplicationCreateTime
        {
            get { return this._replicationCreateTime; }
            set { this._replicationCreateTime = value; }
        }

        // Check to see if ReplicationCreateTime property is set
        internal bool IsSetReplicationCreateTime()
        {
            return this._replicationCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationDeprovisionTime. 
        /// <para>
        /// The timestamp when DMS will deprovision the replication.
        /// </para>
        /// </summary>
        public DateTime? ReplicationDeprovisionTime
        {
            get { return this._replicationDeprovisionTime; }
            set { this._replicationDeprovisionTime = value; }
        }

        // Check to see if ReplicationDeprovisionTime property is set
        internal bool IsSetReplicationDeprovisionTime()
        {
            return this._replicationDeprovisionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationLastStopTime. 
        /// <para>
        /// The timestamp when replication was last stopped.
        /// </para>
        /// </summary>
        public DateTime? ReplicationLastStopTime
        {
            get { return this._replicationLastStopTime; }
            set { this._replicationLastStopTime = value; }
        }

        // Check to see if ReplicationLastStopTime property is set
        internal bool IsSetReplicationLastStopTime()
        {
            return this._replicationLastStopTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationStats. 
        /// <para>
        /// This object provides a collection of statistics about a serverless replication.
        /// </para>
        /// </summary>
        public ReplicationStats ReplicationStats
        {
            get { return this._replicationStats; }
            set { this._replicationStats = value; }
        }

        // Check to see if ReplicationStats property is set
        internal bool IsSetReplicationStats()
        {
            return this._replicationStats != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// The type of the serverless replication.
        /// </para>
        /// </summary>
        public MigrationTypeValue ReplicationType
        {
            get { return this._replicationType; }
            set { this._replicationType = value; }
        }

        // Check to see if ReplicationType property is set
        internal bool IsSetReplicationType()
        {
            return this._replicationType != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationUpdateTime. 
        /// <para>
        /// The time the serverless replication was updated.
        /// </para>
        /// </summary>
        public DateTime? ReplicationUpdateTime
        {
            get { return this._replicationUpdateTime; }
            set { this._replicationUpdateTime = value; }
        }

        // Check to see if ReplicationUpdateTime property is set
        internal bool IsSetReplicationUpdateTime()
        {
            return this._replicationUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name for an existing <c>Endpoint</c> the serverless replication
        /// uses for its data source.
        /// </para>
        /// </summary>
        public string SourceEndpointArn
        {
            get { return this._sourceEndpointArn; }
            set { this._sourceEndpointArn = value; }
        }

        // Check to see if SourceEndpointArn property is set
        internal bool IsSetSourceEndpointArn()
        {
            return this._sourceEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartReplicationType. 
        /// <para>
        /// The type of replication to start.
        /// </para>
        /// </summary>
        public string StartReplicationType
        {
            get { return this._startReplicationType; }
            set { this._startReplicationType = value; }
        }

        // Check to see if StartReplicationType property is set
        internal bool IsSetStartReplicationType()
        {
            return this._startReplicationType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the serverless replication.
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
        /// Gets and sets the property StopReason. 
        /// <para>
        /// The reason the replication task was stopped. This response parameter can return one
        /// of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"Stop Reason NORMAL"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason RECOVERABLE_ERROR"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason FATAL_ERROR"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason FULL_LOAD_ONLY_FINISHED"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_AFTER_FULL_LOAD"</c> – Full load completed, with cached changes
        /// not applied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_AFTER_CACHED_EVENTS"</c> – Full load completed, with cached
        /// changes applied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason EXPRESS_LICENSE_LIMITS_REACHED"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_AFTER_DDL_APPLY"</c> – User-defined stop task after DDL applied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_DUE_TO_LOW_MEMORY"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_DUE_TO_LOW_DISK"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_AT_SERVER_TIME"</c> – User-defined server time for stopping
        /// task
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason STOPPED_AT_COMMIT_TIME"</c> – User-defined commit time for stopping
        /// task
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason RECONFIGURATION_RESTART"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Stop Reason RECYCLE_TASK"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StopReason
        {
            get { return this._stopReason; }
            set { this._stopReason = value; }
        }

        // Check to see if StopReason property is set
        internal bool IsSetStopReason()
        {
            return this._stopReason != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The Amazon Resource Name for an existing <c>Endpoint</c> the serverless replication
        /// uses for its data target.
        /// </para>
        /// </summary>
        public string TargetEndpointArn
        {
            get { return this._targetEndpointArn; }
            set { this._targetEndpointArn = value; }
        }

        // Check to see if TargetEndpointArn property is set
        internal bool IsSetTargetEndpointArn()
        {
            return this._targetEndpointArn != null;
        }

    }
}