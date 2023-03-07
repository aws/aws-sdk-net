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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a replication task created by the <code>CreateReplicationTask</code>
    /// operation.
    /// </summary>
    public partial class ReplicationTask
    {
        private string _cdcStartPosition;
        private string _cdcStopPosition;
        private string _lastFailureMessage;
        private MigrationTypeValue _migrationType;
        private string _recoveryCheckpoint;
        private string _replicationInstanceArn;
        private string _replicationTaskArn;
        private DateTime? _replicationTaskCreationDate;
        private string _replicationTaskIdentifier;
        private string _replicationTaskSettings;
        private DateTime? _replicationTaskStartDate;
        private ReplicationTaskStats _replicationTaskStats;
        private string _sourceEndpointArn;
        private string _status;
        private string _stopReason;
        private string _tableMappings;
        private string _targetEndpointArn;
        private string _targetReplicationInstanceArn;
        private string _taskData;

        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to start. Use either
        /// <code>CdcStartPosition</code> or <code>CdcStartTime</code> to specify when you want
        /// the CDC operation to start. Specifying both values results in an error.
        /// </para>
        ///  
        /// <para>
        /// The value can be in date, checkpoint, or LSN/SCN format.
        /// </para>
        ///  
        /// <para>
        /// Date Example: --cdc-start-position “2018-03-08T12:12:12”
        /// </para>
        ///  
        /// <para>
        /// Checkpoint Example: --cdc-start-position "checkpoint:V1#27#mysql-bin-changelog.157832:1975:-1:2002:677883278264080:mysql-bin-changelog.157832:1876#0#0#*#0#93"
        /// </para>
        ///  
        /// <para>
        /// LSN Example: --cdc-start-position “mysql-bin-changelog.000024:373”
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
        /// Gets and sets the property CdcStopPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to stop. The value can
        /// be either server time or commit time.
        /// </para>
        ///  
        /// <para>
        /// Server time example: --cdc-stop-position “server_time:2018-02-09T12:12:12”
        /// </para>
        ///  
        /// <para>
        /// Commit time example: --cdc-stop-position “commit_time: 2018-02-09T12:12:12“
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
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The last error (failure) message generated for the replication task.
        /// </para>
        /// </summary>
        public string LastFailureMessage
        {
            get { return this._lastFailureMessage; }
            set { this._lastFailureMessage = value; }
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this._lastFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        /// The type of migration.
        /// </para>
        /// </summary>
        public MigrationTypeValue MigrationType
        {
            get { return this._migrationType; }
            set { this._migrationType = value; }
        }

        // Check to see if MigrationType property is set
        internal bool IsSetMigrationType()
        {
            return this._migrationType != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryCheckpoint. 
        /// <para>
        /// Indicates the last checkpoint that occurred during a change data capture (CDC) operation.
        /// You can provide this value to the <code>CdcStartPosition</code> parameter to start
        /// a CDC operation that begins at that checkpoint.
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
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The ARN of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskCreationDate. 
        /// <para>
        /// The date the replication task was created.
        /// </para>
        /// </summary>
        public DateTime ReplicationTaskCreationDate
        {
            get { return this._replicationTaskCreationDate.GetValueOrDefault(); }
            set { this._replicationTaskCreationDate = value; }
        }

        // Check to see if ReplicationTaskCreationDate property is set
        internal bool IsSetReplicationTaskCreationDate()
        {
            return this._replicationTaskCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        /// The user-assigned replication task identifier or name.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1-255 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ReplicationTaskIdentifier
        {
            get { return this._replicationTaskIdentifier; }
            set { this._replicationTaskIdentifier = value; }
        }

        // Check to see if ReplicationTaskIdentifier property is set
        internal bool IsSetReplicationTaskIdentifier()
        {
            return this._replicationTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskSettings. 
        /// <para>
        /// The settings for the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskSettings
        {
            get { return this._replicationTaskSettings; }
            set { this._replicationTaskSettings = value; }
        }

        // Check to see if ReplicationTaskSettings property is set
        internal bool IsSetReplicationTaskSettings()
        {
            return this._replicationTaskSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskStartDate. 
        /// <para>
        /// The date the replication task is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime ReplicationTaskStartDate
        {
            get { return this._replicationTaskStartDate.GetValueOrDefault(); }
            set { this._replicationTaskStartDate = value; }
        }

        // Check to see if ReplicationTaskStartDate property is set
        internal bool IsSetReplicationTaskStartDate()
        {
            return this._replicationTaskStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskStats. 
        /// <para>
        /// The statistics for the task, including elapsed time, tables loaded, and table errors.
        /// </para>
        /// </summary>
        public ReplicationTaskStats ReplicationTaskStats
        {
            get { return this._replicationTaskStats; }
            set { this._replicationTaskStats = value; }
        }

        // Check to see if ReplicationTaskStats property is set
        internal bool IsSetReplicationTaskStats()
        {
            return this._replicationTaskStats != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the endpoint.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the replication task. This response parameter can return one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"moving"</code> – The task is being moved in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_MoveReplicationTask.html">
        /// <code>MoveReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"creating"</code> – The task is being created in response to running the <a
        /// href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateReplicationTask.html">
        /// <code>CreateReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"deleting"</code> – The task is being deleted in response to running the <a
        /// href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DeleteReplicationTask.html">
        /// <code>DeleteReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"failed"</code> – The task failed to successfully complete the database migration
        /// in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <code>StartReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"failed-move"</code> – The task failed to move in response to running the <a
        /// href="https://docs.aws.amazon.com/dms/latest/APIReference/API_MoveReplicationTask.html">
        /// <code>MoveReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"modifying"</code> – The task definition is being modified in response to running
        /// the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_ModifyReplicationTask.html">
        /// <code>ModifyReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"ready"</code> – The task is in a <code>ready</code> state where it can respond
        /// to other task operations, such as <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <code>StartReplicationTask</code> </a> or <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DeleteReplicationTask.html">
        /// <code>DeleteReplicationTask</code> </a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"running"</code> – The task is performing a database migration in response
        /// to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <code>StartReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"starting"</code> – The task is preparing to perform a database migration in
        /// response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <code>StartReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"stopped"</code> – The task has stopped in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StopReplicationTask.html">
        /// <code>StopReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"stopping"</code> – The task is preparing to stop in response to running the
        /// <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StopReplicationTask.html">
        /// <code>StopReplicationTask</code> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"testing"</code> – The database migration specified for this task is being
        /// tested in response to running either the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessmentRun.html">
        /// <code>StartReplicationTaskAssessmentRun</code> </a> or the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessment.html">
        /// <code>StartReplicationTaskAssessment</code> </a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessmentRun.html">
        /// <code>StartReplicationTaskAssessmentRun</code> </a> is an improved premigration task
        /// assessment operation. The <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessment.html">
        /// <code>StartReplicationTaskAssessment</code> </a> operation assesses data type compatibility
        /// only between the source and target database of a given migration task. In contrast,
        /// <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessmentRun.html">
        /// <code>StartReplicationTaskAssessmentRun</code> </a> enables you to specify a variety
        /// of premigration task assessments in addition to data type compatibility. These assessments
        /// include ones for the validity of primary key definitions and likely issues with database
        /// migration performance, among others.
        /// </para>
        ///  </note> </li> </ul>
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
        ///  <code>"Stop Reason NORMAL"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason RECOVERABLE_ERROR"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason FATAL_ERROR"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason FULL_LOAD_ONLY_FINISHED"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_AFTER_FULL_LOAD"</code> – Full load completed, with cached
        /// changes not applied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_AFTER_CACHED_EVENTS"</code> – Full load completed, with
        /// cached changes applied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason EXPRESS_LICENSE_LIMITS_REACHED"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_AFTER_DDL_APPLY"</code> – User-defined stop task after
        /// DDL applied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_DUE_TO_LOW_MEMORY"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_DUE_TO_LOW_DISK"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_AT_SERVER_TIME"</code> – User-defined server time for
        /// stopping task
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason STOPPED_AT_COMMIT_TIME"</code> – User-defined commit time for
        /// stopping task
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason RECONFIGURATION_RESTART"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"Stop Reason RECYCLE_TASK"</code> 
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
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// Table mappings specified in the task.
        /// </para>
        /// </summary>
        public string TableMappings
        {
            get { return this._tableMappings; }
            set { this._tableMappings = value; }
        }

        // Check to see if TableMappings property is set
        internal bool IsSetTableMappings()
        {
            return this._tableMappings != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The ARN that uniquely identifies the endpoint.
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

        /// <summary>
        /// Gets and sets the property TargetReplicationInstanceArn. 
        /// <para>
        /// The ARN of the replication instance to which this task is moved in response to running
        /// the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_MoveReplicationTask.html">
        /// <code>MoveReplicationTask</code> </a> operation. Otherwise, this response parameter
        /// isn't a member of the <code>ReplicationTask</code> object.
        /// </para>
        /// </summary>
        public string TargetReplicationInstanceArn
        {
            get { return this._targetReplicationInstanceArn; }
            set { this._targetReplicationInstanceArn = value; }
        }

        // Check to see if TargetReplicationInstanceArn property is set
        internal bool IsSetTargetReplicationInstanceArn()
        {
            return this._targetReplicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskData. 
        /// <para>
        /// Supplemental information that the task requires to migrate the data for certain source
        /// and target endpoints. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.TaskData.html">Specifying
        /// Supplemental Data for Task Settings</a> in the <i>Database Migration Service User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        public string TaskData
        {
            get { return this._taskData; }
            set { this._taskData = value; }
        }

        // Check to see if TaskData property is set
        internal bool IsSetTaskData()
        {
            return this._taskData != null;
        }

    }
}