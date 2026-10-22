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
    /// Container for the parameters to the ModifyReplicationTask operation. Modifies the
    /// specified replication task. <para> You can't modify the task endpoints. The task must
    /// be stopped before you can modify it. </para> <para> For more information about DMS
    /// tasks, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.html">Working
    /// with Migration Tasks</a> in the <i>Database Migration Service User Guide</i>. </para>
    /// </summary>
    public partial class ModifyReplicationTaskRequest : AmazonDatabaseMigrationServiceRequest
    {
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
        public string CdcStartPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartPosition property is set.
        /// </summary>
        internal bool IsSetCdcStartPosition() => this.CdcStartPosition != null;

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
        /// Gets and sets the property MigrationType. 
        /// <para>
        /// The migration type. Valid values: <c>full-load</c> | <c>cdc</c> | <c>full-load-and-cdc</c>
        /// 
        /// </para>
        /// </summary>
        public MigrationTypeValue MigrationType { get; set; }

        /// <summary>
        /// Checks to see if the MigrationType property is set.
        /// </summary>
        internal bool IsSetMigrationType() => this.MigrationType != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskArn() => this.ReplicationTaskArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        /// The replication task identifier.
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
        /// JSON file that contains settings for the task, such as task metadata settings.
        /// </para>
        /// </summary>
        public string ReplicationTaskSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskSettings property is set.
        /// </summary>
        internal bool IsSetReplicationTaskSettings() => this.ReplicationTaskSettings != null;

        /// <summary>
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// When using the CLI or boto3, provide the path of the JSON file that contains the table
        /// mappings. Precede the path with <c>file://</c>. For example, <c>--table-mappings file://mappingfile.json</c>.
        /// When working with the DMS API, provide the JSON as the parameter value. 
        /// </para>
        /// </summary>
        public string TableMappings { get; set; }

        /// <summary>
        /// Checks to see if the TableMappings property is set.
        /// </summary>
        internal bool IsSetTableMappings() => this.TableMappings != null;

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
