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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Contains information about a table restore request.
    /// </summary>
    public partial class TableRestoreStatus
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that explains the returned status. For example, if the status of the operation
        /// is <c>FAILED</c>, the message explains why the operation failed.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The namespace of the table being restored from.
        /// </para>
        /// </summary>
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create from the restore operation.
        /// </para>
        /// </summary>
        public string NewTableName { get; set; }

        /// <summary>
        /// Checks to see if the NewTableName property is set.
        /// </summary>
        internal bool IsSetNewTableName() => this.NewTableName != null;

        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        /// The amount of data restored to the new table so far, in megabytes (MB).
        /// </para>
        /// </summary>
        public long? ProgressInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the ProgressInMegaBytes property is set.
        /// </summary>
        internal bool IsSetProgressInMegaBytes() => this.ProgressInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RecoveryPointId. 
        /// <para>
        /// The ID of the recovery point being restored from.
        /// </para>
        /// </summary>
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointId property is set.
        /// </summary>
        internal bool IsSetRecoveryPointId() => this.RecoveryPointId != null;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// The time that the table restore request was made, in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot being restored from.
        /// </para>
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database being restored from.
        /// </para>
        /// </summary>
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatabaseName property is set.
        /// </summary>
        internal bool IsSetSourceDatabaseName() => this.SourceDatabaseName != null;

        /// <summary>
        /// Gets and sets the property SourceSchemaName. 
        /// <para>
        /// The name of the source schema being restored from.
        /// </para>
        /// </summary>
        public string SourceSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SourceSchemaName property is set.
        /// </summary>
        internal bool IsSetSourceSchemaName() => this.SourceSchemaName != null;

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table being restored from.
        /// </para>
        /// </summary>
        public string SourceTableName { get; set; }

        /// <summary>
        /// Checks to see if the SourceTableName property is set.
        /// </summary>
        internal bool IsSetSourceTableName() => this.SourceTableName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A value that describes the current state of the table restore request. Possible values
        /// are <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELED</c>, <c>PENDING</c>, and <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TableRestoreRequestId. 
        /// <para>
        /// The ID of the RestoreTableFromSnapshot request.
        /// </para>
        /// </summary>
        public string TableRestoreRequestId { get; set; }

        /// <summary>
        /// Checks to see if the TableRestoreRequestId property is set.
        /// </summary>
        internal bool IsSetTableRestoreRequestId() => this.TableRestoreRequestId != null;

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// The name of the database to restore to.
        /// </para>
        /// </summary>
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDatabaseName property is set.
        /// </summary>
        internal bool IsSetTargetDatabaseName() => this.TargetDatabaseName != null;

        /// <summary>
        /// Gets and sets the property TargetSchemaName. 
        /// <para>
        /// The name of the schema to restore to.
        /// </para>
        /// </summary>
        public string TargetSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the TargetSchemaName property is set.
        /// </summary>
        internal bool IsSetTargetSchemaName() => this.TargetSchemaName != null;

        /// <summary>
        /// Gets and sets the property TotalDataInMegaBytes. 
        /// <para>
        /// The total amount of data to restore to the new table, in megabytes (MB).
        /// </para>
        /// </summary>
        public long? TotalDataInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalDataInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalDataInMegaBytes() => this.TotalDataInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup being restored from.
        /// </para>
        /// </summary>
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}
