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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Database Migration Service (DMS) replication task. A replication
    /// task moves a set of data from the source endpoint to the target endpoint.
    /// </summary>
    public partial class AwsDmsReplicationTaskDetails
    {
        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        ///  Indicates when you want a change data capture (CDC) operation to start. <c>CCdcStartPosition</c>
        /// or <c>CCdcStartTime</c> specifies when you want a CDC operation to start. Only a value
        /// for one of these fields is included.
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
        ///  Indicates the start time for a CDC operation. <c>CdcStartPosition</c> or <c>CCdcStartTime</c>
        /// specifies when you want a CDC operation to start. Only a value for one of these fields
        /// is included.
        /// </para>
        /// </summary>
        public string CdcStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartTime property is set.
        /// </summary>
        internal bool IsSetCdcStartTime() => this.CdcStartTime != null;

        /// <summary>
        /// Gets and sets the property CdcStopPosition. 
        /// <para>
        ///  Indicates when you want a CDC operation to stop. The value can be either server time
        /// or commit time.
        /// </para>
        /// </summary>
        public string CdcStopPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStopPosition property is set.
        /// </summary>
        internal bool IsSetCdcStopPosition() => this.CdcStopPosition != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the replication task.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        ///  The migration type. 
        /// </para>
        /// </summary>
        public string MigrationType { get; set; }

        /// <summary>
        /// Checks to see if the MigrationType property is set.
        /// </summary>
        internal bool IsSetMigrationType() => this.MigrationType != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a replication instance. 
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        ///  The user-defined replication task identifier or name.
        /// </para>
        /// </summary>
        public string ReplicationTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationTaskIdentifier() => this.ReplicationTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskSettings. 
        /// <para>
        ///  The settings for the replication task.
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
        ///  A display name for the resource identifier at the end of the <c>EndpointArn</c> response
        /// parameter. If you don't specify a <c>ResourceIdentifier</c> value, DMS generates a
        /// default identifier value for the end of <c>EndpointArn</c>.
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
        ///  The ARN of the source endpoint.
        /// </para>
        /// </summary>
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;

        /// <summary>
        /// Gets and sets the property TableMappings. 
        /// <para>
        ///  The table mappings for the replication task, in JSON format.
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
        ///  The ARN of the target endpoint.
        /// </para>
        /// </summary>
        public string TargetEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpointArn property is set.
        /// </summary>
        internal bool IsSetTargetEndpointArn() => this.TargetEndpointArn != null;

        /// <summary>
        /// Gets and sets the property TaskData. 
        /// <para>
        ///  Supplemental information that the task requires to migrate the data for certain source
        /// and target endpoints.
        /// </para>
        /// </summary>
        public string TaskData { get; set; }

        /// <summary>
        /// Checks to see if the TaskData property is set.
        /// </summary>
        internal bool IsSetTaskData() => this.TaskData != null;
    }
}
