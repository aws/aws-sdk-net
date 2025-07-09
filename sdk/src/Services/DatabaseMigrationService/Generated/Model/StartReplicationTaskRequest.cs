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
    /// Container for the parameters to the StartReplicationTask operation.
    /// Starts the replication task.
    /// 
    ///  
    /// <para>
    /// For more information about DMS tasks, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.html">Working
    /// with Migration Tasks </a> in the <i>Database Migration Service User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class StartReplicationTaskRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _cdcStartPosition;
        private DateTime? _cdcStartTime;
        private string _cdcStopPosition;
        private string _replicationTaskArn;
        private StartReplicationTaskTypeValue _startReplicationTaskType;

        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to start. Use either
        /// CdcStartPosition or CdcStartTime to specify when you want a CDC operation to start.
        /// Specifying both values results in an error.
        /// </para>
        ///  
        /// <para>
        ///  The value can be in date, checkpoint, or LSN/SCN format.
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
        ///  <note> 
        /// <para>
        /// When you use this task setting with a source PostgreSQL database, a logical replication
        /// slot should already be created and associated with the source endpoint. You can verify
        /// this by setting the <c>slotName</c> extra connection attribute to the name of this
        /// logical replication slot. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.PostgreSQL.html#CHAP_Source.PostgreSQL.ConnectionAttrib">Extra
        /// Connection Attributes When Using PostgreSQL as a Source for DMS</a>.
        /// </para>
        ///  </note>
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
        /// Indicates the start time for a change data capture (CDC) operation. Use either CdcStartTime
        /// or CdcStartPosition to specify when you want a CDC operation to start. Specifying
        /// both values results in an error.
        /// </para>
        ///  
        /// <para>
        /// Timestamp Example: --cdc-start-time “2018-03-08T12:12:12”
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
        ///  
        /// <para>
        /// Server time example: --cdc-stop-position “server_time:2018-02-09T12:12:12”
        /// </para>
        ///  
        /// <para>
        /// Commit time example: --cdc-stop-position “commit_time:2018-02-09T12:12:12“
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
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task to be started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StartReplicationTaskType. 
        /// <para>
        /// The type of replication task to start.
        /// </para>
        ///  
        /// <para>
        ///  <c>start-replication</c> is the only valid action that can be used for the first
        /// time a task with the migration type of <c>full-load</c>full-load, <c>full-load-and-cdc</c>
        /// or <c>cdc</c> is run. Any other action used for the first time on a given task, such
        /// as <c>resume-processing</c> and reload-target will result in data errors.
        /// </para>
        ///  
        /// <para>
        /// You can also use <a>ReloadTables</a> to reload specific tables that failed during
        /// migration instead of restarting the task.
        /// </para>
        ///  
        /// <para>
        /// For a <c>full-load</c> task, the resume-processing option will reload any tables that
        /// were partially loaded or not yet loaded during the full load phase.
        /// </para>
        ///  
        /// <para>
        /// For a <c>full-load-and-cdc</c> task, DMS migrates table data, and then applies data
        /// changes that occur on the source. To load all the tables again, and start capturing
        /// source changes, use <c>reload-target</c>. Otherwise use <c>resume-processing</c>,
        /// to replicate the changes from the last stop position.
        /// </para>
        ///  
        /// <para>
        /// For a <c>cdc</c> only task, to start from a specific position, you must use start-replication
        /// and also specify the start position. Check the source endpoint DMS documentation for
        /// any limitations. For example, not all sources support starting from a time.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>resume-processing</c> is only available for previously executed tasks.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public StartReplicationTaskTypeValue StartReplicationTaskType
        {
            get { return this._startReplicationTaskType; }
            set { this._startReplicationTaskType = value; }
        }

        // Check to see if StartReplicationTaskType property is set
        internal bool IsSetStartReplicationTaskType()
        {
            return this._startReplicationTaskType != null;
        }

    }
}