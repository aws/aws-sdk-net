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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a serverless replication created by the <c>CreateReplication</c>
    /// operation.
    /// </summary>
    public partial class Replication
    {
        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        /// Indicates the start time for a change data capture (CDC) operation. Use either <c>CdcStartTime</c>
        /// or <c>CdcStartPosition</c> to specify when you want a CDC operation to start. Specifying
        /// both values results in an error.
        /// </para>
        /// </summary>
        public string CdcStartPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartPosition property is set.
        /// </summary>
        internal bool IsSetCdcStartPosition() => this.CdcStartPosition != null;

        /// <summary>
        /// Gets and sets the property CdcStartTime. 
        /// <para>
        /// Indicates the start time for a change data capture (CDC) operation. Use either <c>CdcStartTime</c>
        /// or <c>CdcStartPosition</c> to specify when you want a CDC operation to start. Specifying
        /// both values results in an error.
        /// </para>
        /// </summary>
        public DateTime? CdcStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartTime property is set.
        /// </summary>
        internal bool IsSetCdcStartTime() => this.CdcStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CdcStopPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to stop. The value can
        /// be either server time or commit time.
        /// </para>
        /// </summary>
        public string CdcStopPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStopPosition property is set.
        /// </summary>
        internal bool IsSetCdcStopPosition() => this.CdcStopPosition != null;

        /// <summary>
        /// Gets and sets the property FailureMessages. 
        /// <para>
        /// Error and other information about why a serverless replication failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureMessages property is set.
        /// </summary>
        internal bool IsSetFailureMessages() => this.FailureMessages != null && (this.FailureMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsReadOnly. 
        /// <para>
        /// Indicates whether the serverless replication is read-only. When set to <c>true</c>,
        /// this replication is managed by DMS as part of a zero-ETL integration and cannot be
        /// modified or deleted directly. You can only modify or delete read-only replications
        /// through their associated zero-ETL integration.
        /// </para>
        /// </summary>
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the IsReadOnly property is set.
        /// </summary>
        internal bool IsSetIsReadOnly() => this.IsReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property PremigrationAssessmentStatuses. 
        /// <para>
        /// The status output of premigration assessment in describe-replications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PremigrationAssessmentStatus> PremigrationAssessmentStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<PremigrationAssessmentStatus>() : null;

        /// <summary>
        /// Checks to see if the PremigrationAssessmentStatuses property is set.
        /// </summary>
        internal bool IsSetPremigrationAssessmentStatuses() => this.PremigrationAssessmentStatuses != null && (this.PremigrationAssessmentStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisionData. 
        /// <para>
        /// Information about provisioning resources for an DMS serverless replication.
        /// </para>
        /// </summary>
        public ProvisionData ProvisionData { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionData property is set.
        /// </summary>
        internal bool IsSetProvisionData() => this.ProvisionData != null;

        /// <summary>
        /// Gets and sets the property RecoveryCheckpoint. 
        /// <para>
        /// Indicates the last checkpoint that occurred during a change data capture (CDC) operation.
        /// You can provide this value to the <c>CdcStartPosition</c> parameter to start a CDC
        /// operation that begins at that checkpoint.
        /// </para>
        /// </summary>
        public string RecoveryCheckpoint { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryCheckpoint property is set.
        /// </summary>
        internal bool IsSetRecoveryCheckpoint() => this.RecoveryCheckpoint != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// The Amazon Resource Name for the <c>ReplicationConfig</c> associated with the replication.
        /// </para>
        /// </summary>
        public string ReplicationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigArn property is set.
        /// </summary>
        internal bool IsSetReplicationConfigArn() => this.ReplicationConfigArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigIdentifier. 
        /// <para>
        /// The identifier for the <c>ReplicationConfig</c> associated with the replication.
        /// </para>
        /// </summary>
        public string ReplicationConfigIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationConfigIdentifier() => this.ReplicationConfigIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationCreateTime. 
        /// <para>
        /// The time the serverless replication was created.
        /// </para>
        /// </summary>
        public DateTime? ReplicationCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationCreateTime property is set.
        /// </summary>
        internal bool IsSetReplicationCreateTime() => this.ReplicationCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationDeprovisionTime. 
        /// <para>
        /// The timestamp when DMS will deprovision the replication.
        /// </para>
        /// </summary>
        public DateTime? ReplicationDeprovisionTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationDeprovisionTime property is set.
        /// </summary>
        internal bool IsSetReplicationDeprovisionTime() => this.ReplicationDeprovisionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationLastStopTime. 
        /// <para>
        /// The timestamp when replication was last stopped.
        /// </para>
        /// </summary>
        public DateTime? ReplicationLastStopTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationLastStopTime property is set.
        /// </summary>
        internal bool IsSetReplicationLastStopTime() => this.ReplicationLastStopTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationStats. 
        /// <para>
        /// This object provides a collection of statistics about a serverless replication.
        /// </para>
        /// </summary>
        public ReplicationStats ReplicationStats { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStats property is set.
        /// </summary>
        internal bool IsSetReplicationStats() => this.ReplicationStats != null;

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// The type of the serverless replication.
        /// </para>
        /// </summary>
        public MigrationTypeValue ReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationType property is set.
        /// </summary>
        internal bool IsSetReplicationType() => this.ReplicationType != null;

        /// <summary>
        /// Gets and sets the property ReplicationUpdateTime. 
        /// <para>
        /// The time the serverless replication was updated.
        /// </para>
        /// </summary>
        public DateTime? ReplicationUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationUpdateTime property is set.
        /// </summary>
        internal bool IsSetReplicationUpdateTime() => this.ReplicationUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name for an existing <c>Endpoint</c> the serverless replication
        /// uses for its data source.
        /// </para>
        /// </summary>
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;

        /// <summary>
        /// Gets and sets the property StartReplicationType. 
        /// <para>
        /// The type of replication to start.
        /// </para>
        /// </summary>
        public string StartReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the StartReplicationType property is set.
        /// </summary>
        internal bool IsSetStartReplicationType() => this.StartReplicationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the serverless replication.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        public string StopReason { get; set; }

        /// <summary>
        /// Checks to see if the StopReason property is set.
        /// </summary>
        internal bool IsSetStopReason() => this.StopReason != null;

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The Amazon Resource Name for an existing <c>Endpoint</c> the serverless replication
        /// uses for its data target.
        /// </para>
        /// </summary>
        public string TargetEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpointArn property is set.
        /// </summary>
        internal bool IsSetTargetEndpointArn() => this.TargetEndpointArn != null;
    }
}
