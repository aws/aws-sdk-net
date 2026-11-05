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
    /// Provides a collection of table statistics in response to a request by the <c>DescribeTableStatistics</c>
    /// operation.
    /// </summary>
    public partial class TableStatistics
    {
        /// <summary>
        /// Gets and sets the property AppliedDdls. 
        /// <para>
        /// The number of data definition language (DDL) statements used to build and modify the
        /// structure of your tables applied on the target.
        /// </para>
        /// </summary>
        public long? AppliedDdls { get; set; }

        /// <summary>
        /// Checks to see if the AppliedDdls property is set.
        /// </summary>
        internal bool IsSetAppliedDdls() => this.AppliedDdls.HasValue;

        /// <summary>
        /// Gets and sets the property AppliedDeletes. 
        /// <para>
        /// The number of delete actions applied on a target table.
        /// </para>
        /// </summary>
        public long? AppliedDeletes { get; set; }

        /// <summary>
        /// Checks to see if the AppliedDeletes property is set.
        /// </summary>
        internal bool IsSetAppliedDeletes() => this.AppliedDeletes.HasValue;

        /// <summary>
        /// Gets and sets the property AppliedInserts. 
        /// <para>
        /// The number of insert actions applied on a target table.
        /// </para>
        /// </summary>
        public long? AppliedInserts { get; set; }

        /// <summary>
        /// Checks to see if the AppliedInserts property is set.
        /// </summary>
        internal bool IsSetAppliedInserts() => this.AppliedInserts.HasValue;

        /// <summary>
        /// Gets and sets the property AppliedUpdates. 
        /// <para>
        /// The number of update actions applied on a target table.
        /// </para>
        /// </summary>
        public long? AppliedUpdates { get; set; }

        /// <summary>
        /// Checks to see if the AppliedUpdates property is set.
        /// </summary>
        internal bool IsSetAppliedUpdates() => this.AppliedUpdates.HasValue;

        /// <summary>
        /// Gets and sets the property Ddls. 
        /// <para>
        /// The data definition language (DDL) used to build and modify the structure of your
        /// tables.
        /// </para>
        /// </summary>
        public long? Ddls { get; set; }

        /// <summary>
        /// Checks to see if the Ddls property is set.
        /// </summary>
        internal bool IsSetDdls() => this.Ddls.HasValue;

        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// The number of delete actions performed on a table.
        /// </para>
        /// </summary>
        public long? Deletes { get; set; }

        /// <summary>
        /// Checks to see if the Deletes property is set.
        /// </summary>
        internal bool IsSetDeletes() => this.Deletes.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadCondtnlChkFailedRows. 
        /// <para>
        /// The number of rows that failed conditional checks during the full load operation (valid
        /// only for migrations where DynamoDB is the target).
        /// </para>
        /// </summary>
        public long? FullLoadCondtnlChkFailedRows { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadCondtnlChkFailedRows property is set.
        /// </summary>
        internal bool IsSetFullLoadCondtnlChkFailedRows() => this.FullLoadCondtnlChkFailedRows.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadEndTime. 
        /// <para>
        /// The time when the full load operation completed.
        /// </para>
        /// </summary>
        public DateTime? FullLoadEndTime { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadEndTime property is set.
        /// </summary>
        internal bool IsSetFullLoadEndTime() => this.FullLoadEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadErrorRows. 
        /// <para>
        /// The number of rows that failed to load during the full load operation (valid only
        /// for migrations where DynamoDB is the target).
        /// </para>
        /// </summary>
        public long? FullLoadErrorRows { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadErrorRows property is set.
        /// </summary>
        internal bool IsSetFullLoadErrorRows() => this.FullLoadErrorRows.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadReloaded. 
        /// <para>
        /// A value that indicates if the table was reloaded (<c>true</c>) or loaded as part of
        /// a new full load operation (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? FullLoadReloaded { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadReloaded property is set.
        /// </summary>
        internal bool IsSetFullLoadReloaded() => this.FullLoadReloaded.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadRows. 
        /// <para>
        /// The number of rows added during the full load operation.
        /// </para>
        /// </summary>
        public long? FullLoadRows { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadRows property is set.
        /// </summary>
        internal bool IsSetFullLoadRows() => this.FullLoadRows.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadStartTime. 
        /// <para>
        /// The time when the full load operation started.
        /// </para>
        /// </summary>
        public DateTime? FullLoadStartTime { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadStartTime property is set.
        /// </summary>
        internal bool IsSetFullLoadStartTime() => this.FullLoadStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Inserts. 
        /// <para>
        /// The number of insert actions performed on a table.
        /// </para>
        /// </summary>
        public long? Inserts { get; set; }

        /// <summary>
        /// Checks to see if the Inserts property is set.
        /// </summary>
        internal bool IsSetInserts() => this.Inserts.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time a table was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResyncProgress. 
        /// <para>
        /// Calculates the percentage of failed validations that were successfully resynced to
        /// the system.
        /// </para>
        /// </summary>
        public double? ResyncProgress { get; set; }

        /// <summary>
        /// Checks to see if the ResyncProgress property is set.
        /// </summary>
        internal bool IsSetResyncProgress() => this.ResyncProgress.HasValue;

        /// <summary>
        /// Gets and sets the property ResyncRowsAttempted. 
        /// <para>
        /// Records the total number of mismatched data rows where the system attempted to apply
        /// fixes in the target database.
        /// </para>
        /// </summary>
        public long? ResyncRowsAttempted { get; set; }

        /// <summary>
        /// Checks to see if the ResyncRowsAttempted property is set.
        /// </summary>
        internal bool IsSetResyncRowsAttempted() => this.ResyncRowsAttempted.HasValue;

        /// <summary>
        /// Gets and sets the property ResyncRowsFailed. 
        /// <para>
        /// Records the total number of mismatched data rows where fix attempts failed in the
        /// target database.
        /// </para>
        /// </summary>
        public long? ResyncRowsFailed { get; set; }

        /// <summary>
        /// Checks to see if the ResyncRowsFailed property is set.
        /// </summary>
        internal bool IsSetResyncRowsFailed() => this.ResyncRowsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property ResyncRowsSucceeded. 
        /// <para>
        /// Records the total number of mismatched data rows where fixes were successfully applied
        /// in the target database.
        /// </para>
        /// </summary>
        public long? ResyncRowsSucceeded { get; set; }

        /// <summary>
        /// Checks to see if the ResyncRowsSucceeded property is set.
        /// </summary>
        internal bool IsSetResyncRowsSucceeded() => this.ResyncRowsSucceeded.HasValue;

        /// <summary>
        /// Gets and sets the property ResyncState. 
        /// <para>
        /// Records the current state of table resynchronization in the migration task.
        /// </para>
        ///  
        /// <para>
        /// This parameter can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Not enabled – Resync is not enabled for the table in the migration task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending – The tables are waiting for resync.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In progress – Resync in progress for some records in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No primary key – The table could not be resynced because it has no primary key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Last resync at: <c>date/time</c> – Resync session is finished at time. Time provided
        /// in UTC format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResyncState { get; set; }

        /// <summary>
        /// Checks to see if the ResyncState property is set.
        /// </summary>
        internal bool IsSetResyncState() => this.ResyncState != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The schema name.
        /// </para>
        /// </summary>
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TableState. 
        /// <para>
        /// The state of the tables described.
        /// </para>
        ///  
        /// <para>
        /// Valid states: Table does not exist | Before load | Full load | Table completed | Table
        /// cancelled | Table error | Table is being reloaded
        /// </para>
        /// </summary>
        public string TableState { get; set; }

        /// <summary>
        /// Checks to see if the TableState property is set.
        /// </summary>
        internal bool IsSetTableState() => this.TableState != null;

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// The number of update actions performed on a table.
        /// </para>
        /// </summary>
        public long? Updates { get; set; }

        /// <summary>
        /// Checks to see if the Updates property is set.
        /// </summary>
        internal bool IsSetUpdates() => this.Updates.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationFailedRecords. 
        /// <para>
        /// The number of records that failed validation.
        /// </para>
        /// </summary>
        public long? ValidationFailedRecords { get; set; }

        /// <summary>
        /// Checks to see if the ValidationFailedRecords property is set.
        /// </summary>
        internal bool IsSetValidationFailedRecords() => this.ValidationFailedRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationPendingRecords. 
        /// <para>
        /// The number of records that have yet to be validated.
        /// </para>
        /// </summary>
        public long? ValidationPendingRecords { get; set; }

        /// <summary>
        /// Checks to see if the ValidationPendingRecords property is set.
        /// </summary>
        internal bool IsSetValidationPendingRecords() => this.ValidationPendingRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationState. 
        /// <para>
        /// The validation state of the table.
        /// </para>
        ///  
        /// <para>
        /// This parameter can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Not enabled – Validation isn't enabled for the table in the migration task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending records – Some records in the table are waiting for validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Mismatched records – Some records in the table don't match between the source and
        /// target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Suspended records – Some records in the table couldn't be validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No primary key –The table couldn't be validated because it has no primary key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table error – The table wasn't validated because it's in an error state and some data
        /// wasn't migrated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validated – All rows in the table are validated. If the table is updated, the status
        /// can change from Validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Error – The table couldn't be validated because of an unexpected error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending validation – The table is waiting validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Preparing table – Preparing the table enabled in the migration task for validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending revalidation – All rows in the table are pending validation after the table
        /// was updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ValidationState { get; set; }

        /// <summary>
        /// Checks to see if the ValidationState property is set.
        /// </summary>
        internal bool IsSetValidationState() => this.ValidationState != null;

        /// <summary>
        /// Gets and sets the property ValidationStateDetails. 
        /// <para>
        /// Additional details about the state of validation.
        /// </para>
        /// </summary>
        public string ValidationStateDetails { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStateDetails property is set.
        /// </summary>
        internal bool IsSetValidationStateDetails() => this.ValidationStateDetails != null;

        /// <summary>
        /// Gets and sets the property ValidationSuspendedRecords. 
        /// <para>
        /// The number of records that couldn't be validated.
        /// </para>
        /// </summary>
        public long? ValidationSuspendedRecords { get; set; }

        /// <summary>
        /// Checks to see if the ValidationSuspendedRecords property is set.
        /// </summary>
        internal bool IsSetValidationSuspendedRecords() => this.ValidationSuspendedRecords.HasValue;
    }
}
