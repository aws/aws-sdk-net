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
    /// Provides information that describes a replication task created by the <c>CreateReplicationTask</c>
    /// operation.
    /// </summary>
    public partial class ReplicationTask
    {
        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to start. Use either
        /// <c>CdcStartPosition</c> or <c>CdcStartTime</c> to specify when you want the CDC operation
        /// to start. Specifying both values results in an error.
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
        public string CdcStartPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartPosition property is set.
        /// </summary>
        internal bool IsSetCdcStartPosition() => this.CdcStartPosition != null;

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
        /// Commit time example: --cdc-stop-position “commit_time:2018-02-09T12:12:12“
        /// </para>
        /// </summary>
        public string CdcStopPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStopPosition property is set.
        /// </summary>
        internal bool IsSetCdcStopPosition() => this.CdcStopPosition != null;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The last error (failure) message generated for the replication task.
        /// </para>
        /// </summary>
        public string LastFailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureMessage property is set.
        /// </summary>
        internal bool IsSetLastFailureMessage() => this.LastFailureMessage != null;

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        /// The type of migration.
        /// </para>
        /// </summary>
        public MigrationTypeValue MigrationType { get; set; }

        /// <summary>
        /// Checks to see if the MigrationType property is set.
        /// </summary>
        internal bool IsSetMigrationType() => this.MigrationType != null;

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
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The ARN of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskArn() => this.ReplicationTaskArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskCreationDate. 
        /// <para>
        /// The date the replication task was created.
        /// </para>
        /// </summary>
        public DateTime? ReplicationTaskCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskCreationDate property is set.
        /// </summary>
        internal bool IsSetReplicationTaskCreationDate() => this.ReplicationTaskCreationDate.HasValue;

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
        public string ReplicationTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationTaskIdentifier() => this.ReplicationTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskSettings. 
        /// <para>
        /// The settings for the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskSettings property is set.
        /// </summary>
        internal bool IsSetReplicationTaskSettings() => this.ReplicationTaskSettings != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskStartDate. 
        /// <para>
        /// The date the replication task is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime? ReplicationTaskStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskStartDate property is set.
        /// </summary>
        internal bool IsSetReplicationTaskStartDate() => this.ReplicationTaskStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationTaskStats. 
        /// <para>
        /// The statistics for the task, including elapsed time, tables loaded, and table errors.
        /// </para>
        /// </summary>
        public ReplicationTaskStats ReplicationTaskStats { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskStats property is set.
        /// </summary>
        internal bool IsSetReplicationTaskStats() => this.ReplicationTaskStats != null;

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the replication task. This response parameter can return one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"moving"</c> – The task is being moved in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_MoveReplicationTask.html">
        /// <c>MoveReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"creating"</c> – The task is being created in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateReplicationTask.html">
        /// <c>CreateReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"deleting"</c> – The task is being deleted in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DeleteReplicationTask.html">
        /// <c>DeleteReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"failed"</c> – The task failed to successfully complete the database migration
        /// in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <c>StartReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"failed-move"</c> – The task failed to move in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_MoveReplicationTask.html">
        /// <c>MoveReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"modifying"</c> – The task definition is being modified in response to running
        /// the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_ModifyReplicationTask.html">
        /// <c>ModifyReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"ready"</c> – The task is in a <c>ready</c> state where it can respond to other
        /// task operations, such as <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <c>StartReplicationTask</c> </a> or <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DeleteReplicationTask.html">
        /// <c>DeleteReplicationTask</c> </a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"running"</c> – The task is performing a database migration in response to running
        /// the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <c>StartReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"starting"</c> – The task is preparing to perform a database migration in response
        /// to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">
        /// <c>StartReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"stopped"</c> – The task has stopped in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StopReplicationTask.html">
        /// <c>StopReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"stopping"</c> – The task is preparing to stop in response to running the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StopReplicationTask.html">
        /// <c>StopReplicationTask</c> </a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"testing"</c> – The database migration specified for this task is being tested
        /// in response to running either the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessmentRun.html">
        /// <c>StartReplicationTaskAssessmentRun</c> </a> or the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessment.html">
        /// <c>StartReplicationTaskAssessment</c> </a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessmentRun.html">
        /// <c>StartReplicationTaskAssessmentRun</c> </a> is an improved premigration task assessment
        /// operation. The <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessment.html">
        /// <c>StartReplicationTaskAssessment</c> </a> operation assesses data type compatibility
        /// only between the source and target database of a given migration task. In contrast,
        /// <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTaskAssessmentRun.html">
        /// <c>StartReplicationTaskAssessmentRun</c> </a> enables you to specify a variety of
        /// premigration task assessments in addition to data type compatibility. These assessments
        /// include ones for the validity of primary key definitions and likely issues with database
        /// migration performance, among others.
        /// </para>
        ///  </note> </li> </ul>
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
        ///  <c>"Stop Reason NORMAL"</c> – The task completed successfully with no additional
        /// information returned.
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
        ///  <c>"Stop Reason FULL_LOAD_ONLY_FINISHED"</c> – The task completed the full load phase.
        /// DMS applied cached changes if you set <c>StopTaskCachedChangesApplied</c> to <c>true</c>.
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
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// Table mappings specified in the task.
        /// </para>
        /// </summary>
        public string TableMappings { get; set; }

        /// <summary>
        /// Checks to see if the TableMappings property is set.
        /// </summary>
        internal bool IsSetTableMappings() => this.TableMappings != null;

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The ARN that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string TargetEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpointArn property is set.
        /// </summary>
        internal bool IsSetTargetEndpointArn() => this.TargetEndpointArn != null;

        /// <summary>
        /// Gets and sets the property TargetReplicationInstanceArn. 
        /// <para>
        /// The ARN of the replication instance to which this task is moved in response to running
        /// the <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_MoveReplicationTask.html">
        /// <c>MoveReplicationTask</c> </a> operation. Otherwise, this response parameter isn't
        /// a member of the <c>ReplicationTask</c> object.
        /// </para>
        /// </summary>
        public string TargetReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetTargetReplicationInstanceArn() => this.TargetReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property TaskData. 
        /// <para>
        /// Supplemental information that the task requires to migrate the data for certain source
        /// and target endpoints. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.TaskData.html">Specifying
        /// Supplemental Data for Task Settings</a> in the <i>Database Migration Service User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        public string TaskData { get; set; }

        /// <summary>
        /// Checks to see if the TaskData property is set.
        /// </summary>
        internal bool IsSetTaskData() => this.TaskData != null;
    }
}
