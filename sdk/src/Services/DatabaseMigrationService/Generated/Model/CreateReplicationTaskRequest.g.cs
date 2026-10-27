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
    /// Container for the parameters to the CreateReplicationTask operation. Creates a replication
    /// task using the specified parameters.
    /// </summary>
    public partial class CreateReplicationTaskRequest : AmazonDatabaseMigrationServiceRequest
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
        [AWSProperty(Required = true)]
        public MigrationTypeValue MigrationType { get; set; }

        /// <summary>
        /// Checks to see if the MigrationType property is set.
        /// </summary>
        internal bool IsSetMigrationType() => this.MigrationType != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a replication instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        /// An identifier for the replication task.
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
        [AWSProperty(Required = true)]
        public string ReplicationTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationTaskIdentifier() => this.ReplicationTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskSettings. 
        /// <para>
        /// Overall settings for the task, in JSON format. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TaskSettings.html">Specifying
        /// Task Settings for Database Migration Service Tasks</a> in the <i>Database Migration
        /// Service User Guide.</i> 
        /// </para>
        /// </summary>
        public string ReplicationTaskSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskSettings property is set.
        /// </summary>
        internal bool IsSetReplicationTaskSettings() => this.ReplicationTaskSettings != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A friendly name for the resource identifier at the end of the <c>EndpointArn</c> response
        /// parameter that is returned in the created <c>Endpoint</c> object. The value for this
        /// parameter can have up to 31 characters. It can contain only ASCII letters, digits,
        /// and hyphen ('-'). Also, it can't end with a hyphen or contain two consecutive hyphens,
        /// and can only begin with a letter, such as <c>Example-App-ARN1</c>. For example, this
        /// value might result in the <c>EndpointArn</c> value <c>arn:aws:dms:eu-west-1:012345678901:rep:Example-App-ARN1</c>.
        /// If you don't specify a <c>ResourceIdentifier</c> value, DMS generates a default identifier
        /// value for the end of <c>EndpointArn</c>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;

        /// <summary>
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// The table mappings for the task, in JSON format. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TableMapping.html">Using
        /// Table Mapping to Specify Task Settings</a> in the <i>Database Migration Service User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableMappings { get; set; }

        /// <summary>
        /// Checks to see if the TableMappings property is set.
        /// </summary>
        internal bool IsSetTableMappings() => this.TableMappings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the replication task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the target endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpointArn property is set.
        /// </summary>
        internal bool IsSetTargetEndpointArn() => this.TargetEndpointArn != null;

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
