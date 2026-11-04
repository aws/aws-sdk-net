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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a <a>RestoreTableFromClusterSnapshot</a> operation.
    /// </summary>
    public partial class TableRestoreStatus
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the Amazon Redshift cluster that the table is being restored to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the table restore request. Status values include <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>CANCELED</c>, <c>PENDING</c>, <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create as a result of the table restore request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
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
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier of the snapshot that the table is being restored from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotIdentifier() => this.SnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database that contains the table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatabaseName property is set.
        /// </summary>
        internal bool IsSetSourceDatabaseName() => this.SourceDatabaseName != null;

        /// <summary>
        /// Gets and sets the property SourceSchemaName. 
        /// <para>
        /// The name of the source schema that contains the table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SourceSchemaName property is set.
        /// </summary>
        internal bool IsSetSourceSchemaName() => this.SourceSchemaName != null;

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// Checks to see if the SourceTableName property is set.
        /// </summary>
        internal bool IsSetSourceTableName() => this.SourceTableName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A value that describes the current state of the table restore request.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELED</c>, <c>PENDING</c>, <c>IN_PROGRESS</c>
        /// 
        /// </para>
        /// </summary>
        public TableRestoreStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TableRestoreRequestId. 
        /// <para>
        /// The unique identifier for the table restore request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TableRestoreRequestId { get; set; }

        /// <summary>
        /// Checks to see if the TableRestoreRequestId property is set.
        /// </summary>
        internal bool IsSetTableRestoreRequestId() => this.TableRestoreRequestId != null;

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// The name of the database to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDatabaseName property is set.
        /// </summary>
        internal bool IsSetTargetDatabaseName() => this.TargetDatabaseName != null;

        /// <summary>
        /// Gets and sets the property TargetSchemaName. 
        /// <para>
        /// The name of the schema to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
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
    }
}
