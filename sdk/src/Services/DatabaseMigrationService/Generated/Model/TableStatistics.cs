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
    /// Provides a collection of table statistics in response to a request by the <c>DescribeTableStatistics</c>
    /// operation.
    /// </summary>
    public partial class TableStatistics
    {
        private long? _appliedDdls;
        private long? _appliedDeletes;
        private long? _appliedInserts;
        private long? _appliedUpdates;
        private long? _ddls;
        private long? _deletes;
        private long? _fullLoadCondtnlChkFailedRows;
        private DateTime? _fullLoadEndTime;
        private long? _fullLoadErrorRows;
        private bool? _fullLoadReloaded;
        private long? _fullLoadRows;
        private DateTime? _fullLoadStartTime;
        private long? _inserts;
        private DateTime? _lastUpdateTime;
        private double? _resyncProgress;
        private long? _resyncRowsAttempted;
        private long? _resyncRowsFailed;
        private long? _resyncRowsSucceeded;
        private string _resyncState;
        private string _schemaName;
        private string _tableName;
        private string _tableState;
        private long? _updates;
        private long? _validationFailedRecords;
        private long? _validationPendingRecords;
        private string _validationState;
        private string _validationStateDetails;
        private long? _validationSuspendedRecords;

        /// <summary>
        /// Gets and sets the property AppliedDdls. 
        /// <para>
        /// The number of data definition language (DDL) statements used to build and modify the
        /// structure of your tables applied on the target.
        /// </para>
        /// </summary>
        public long? AppliedDdls
        {
            get { return this._appliedDdls; }
            set { this._appliedDdls = value; }
        }

        // Check to see if AppliedDdls property is set
        internal bool IsSetAppliedDdls()
        {
            return this._appliedDdls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppliedDeletes. 
        /// <para>
        /// The number of delete actions applied on a target table.
        /// </para>
        /// </summary>
        public long? AppliedDeletes
        {
            get { return this._appliedDeletes; }
            set { this._appliedDeletes = value; }
        }

        // Check to see if AppliedDeletes property is set
        internal bool IsSetAppliedDeletes()
        {
            return this._appliedDeletes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppliedInserts. 
        /// <para>
        /// The number of insert actions applied on a target table.
        /// </para>
        /// </summary>
        public long? AppliedInserts
        {
            get { return this._appliedInserts; }
            set { this._appliedInserts = value; }
        }

        // Check to see if AppliedInserts property is set
        internal bool IsSetAppliedInserts()
        {
            return this._appliedInserts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppliedUpdates. 
        /// <para>
        /// The number of update actions applied on a target table.
        /// </para>
        /// </summary>
        public long? AppliedUpdates
        {
            get { return this._appliedUpdates; }
            set { this._appliedUpdates = value; }
        }

        // Check to see if AppliedUpdates property is set
        internal bool IsSetAppliedUpdates()
        {
            return this._appliedUpdates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ddls. 
        /// <para>
        /// The data definition language (DDL) used to build and modify the structure of your
        /// tables.
        /// </para>
        /// </summary>
        public long? Ddls
        {
            get { return this._ddls; }
            set { this._ddls = value; }
        }

        // Check to see if Ddls property is set
        internal bool IsSetDdls()
        {
            return this._ddls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// The number of delete actions performed on a table.
        /// </para>
        /// </summary>
        public long? Deletes
        {
            get { return this._deletes; }
            set { this._deletes = value; }
        }

        // Check to see if Deletes property is set
        internal bool IsSetDeletes()
        {
            return this._deletes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadCondtnlChkFailedRows. 
        /// <para>
        /// The number of rows that failed conditional checks during the full load operation (valid
        /// only for migrations where DynamoDB is the target).
        /// </para>
        /// </summary>
        public long? FullLoadCondtnlChkFailedRows
        {
            get { return this._fullLoadCondtnlChkFailedRows; }
            set { this._fullLoadCondtnlChkFailedRows = value; }
        }

        // Check to see if FullLoadCondtnlChkFailedRows property is set
        internal bool IsSetFullLoadCondtnlChkFailedRows()
        {
            return this._fullLoadCondtnlChkFailedRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadEndTime. 
        /// <para>
        /// The time when the full load operation completed.
        /// </para>
        /// </summary>
        public DateTime? FullLoadEndTime
        {
            get { return this._fullLoadEndTime; }
            set { this._fullLoadEndTime = value; }
        }

        // Check to see if FullLoadEndTime property is set
        internal bool IsSetFullLoadEndTime()
        {
            return this._fullLoadEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadErrorRows. 
        /// <para>
        /// The number of rows that failed to load during the full load operation (valid only
        /// for migrations where DynamoDB is the target).
        /// </para>
        /// </summary>
        public long? FullLoadErrorRows
        {
            get { return this._fullLoadErrorRows; }
            set { this._fullLoadErrorRows = value; }
        }

        // Check to see if FullLoadErrorRows property is set
        internal bool IsSetFullLoadErrorRows()
        {
            return this._fullLoadErrorRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadReloaded. 
        /// <para>
        /// A value that indicates if the table was reloaded (<c>true</c>) or loaded as part of
        /// a new full load operation (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? FullLoadReloaded
        {
            get { return this._fullLoadReloaded; }
            set { this._fullLoadReloaded = value; }
        }

        // Check to see if FullLoadReloaded property is set
        internal bool IsSetFullLoadReloaded()
        {
            return this._fullLoadReloaded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadRows. 
        /// <para>
        /// The number of rows added during the full load operation.
        /// </para>
        /// </summary>
        public long? FullLoadRows
        {
            get { return this._fullLoadRows; }
            set { this._fullLoadRows = value; }
        }

        // Check to see if FullLoadRows property is set
        internal bool IsSetFullLoadRows()
        {
            return this._fullLoadRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadStartTime. 
        /// <para>
        /// The time when the full load operation started.
        /// </para>
        /// </summary>
        public DateTime? FullLoadStartTime
        {
            get { return this._fullLoadStartTime; }
            set { this._fullLoadStartTime = value; }
        }

        // Check to see if FullLoadStartTime property is set
        internal bool IsSetFullLoadStartTime()
        {
            return this._fullLoadStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Inserts. 
        /// <para>
        /// The number of insert actions performed on a table.
        /// </para>
        /// </summary>
        public long? Inserts
        {
            get { return this._inserts; }
            set { this._inserts = value; }
        }

        // Check to see if Inserts property is set
        internal bool IsSetInserts()
        {
            return this._inserts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time a table was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResyncProgress. 
        /// <para>
        /// Calculates the percentage of failed validations that were successfully resynced to
        /// the system.
        /// </para>
        /// </summary>
        public double? ResyncProgress
        {
            get { return this._resyncProgress; }
            set { this._resyncProgress = value; }
        }

        // Check to see if ResyncProgress property is set
        internal bool IsSetResyncProgress()
        {
            return this._resyncProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResyncRowsAttempted. 
        /// <para>
        /// Records the total number of mismatched data rows where the system attempted to apply
        /// fixes in the target database.
        /// </para>
        /// </summary>
        public long? ResyncRowsAttempted
        {
            get { return this._resyncRowsAttempted; }
            set { this._resyncRowsAttempted = value; }
        }

        // Check to see if ResyncRowsAttempted property is set
        internal bool IsSetResyncRowsAttempted()
        {
            return this._resyncRowsAttempted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResyncRowsFailed. 
        /// <para>
        /// Records the total number of mismatched data rows where fix attempts failed in the
        /// target database.
        /// </para>
        /// </summary>
        public long? ResyncRowsFailed
        {
            get { return this._resyncRowsFailed; }
            set { this._resyncRowsFailed = value; }
        }

        // Check to see if ResyncRowsFailed property is set
        internal bool IsSetResyncRowsFailed()
        {
            return this._resyncRowsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResyncRowsSucceeded. 
        /// <para>
        /// Records the total number of mismatched data rows where fixes were successfully applied
        /// in the target database.
        /// </para>
        /// </summary>
        public long? ResyncRowsSucceeded
        {
            get { return this._resyncRowsSucceeded; }
            set { this._resyncRowsSucceeded = value; }
        }

        // Check to see if ResyncRowsSucceeded property is set
        internal bool IsSetResyncRowsSucceeded()
        {
            return this._resyncRowsSucceeded.HasValue; 
        }

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
        public string ResyncState
        {
            get { return this._resyncState; }
            set { this._resyncState = value; }
        }

        // Check to see if ResyncState property is set
        internal bool IsSetResyncState()
        {
            return this._resyncState != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The schema name.
        /// </para>
        /// </summary>
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

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
        public string TableState
        {
            get { return this._tableState; }
            set { this._tableState = value; }
        }

        // Check to see if TableState property is set
        internal bool IsSetTableState()
        {
            return this._tableState != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// The number of update actions performed on a table.
        /// </para>
        /// </summary>
        public long? Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationFailedRecords. 
        /// <para>
        /// The number of records that failed validation.
        /// </para>
        /// </summary>
        public long? ValidationFailedRecords
        {
            get { return this._validationFailedRecords; }
            set { this._validationFailedRecords = value; }
        }

        // Check to see if ValidationFailedRecords property is set
        internal bool IsSetValidationFailedRecords()
        {
            return this._validationFailedRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationPendingRecords. 
        /// <para>
        /// The number of records that have yet to be validated.
        /// </para>
        /// </summary>
        public long? ValidationPendingRecords
        {
            get { return this._validationPendingRecords; }
            set { this._validationPendingRecords = value; }
        }

        // Check to see if ValidationPendingRecords property is set
        internal bool IsSetValidationPendingRecords()
        {
            return this._validationPendingRecords.HasValue; 
        }

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
        public string ValidationState
        {
            get { return this._validationState; }
            set { this._validationState = value; }
        }

        // Check to see if ValidationState property is set
        internal bool IsSetValidationState()
        {
            return this._validationState != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStateDetails. 
        /// <para>
        /// Additional details about the state of validation.
        /// </para>
        /// </summary>
        public string ValidationStateDetails
        {
            get { return this._validationStateDetails; }
            set { this._validationStateDetails = value; }
        }

        // Check to see if ValidationStateDetails property is set
        internal bool IsSetValidationStateDetails()
        {
            return this._validationStateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationSuspendedRecords. 
        /// <para>
        /// The number of records that couldn't be validated.
        /// </para>
        /// </summary>
        public long? ValidationSuspendedRecords
        {
            get { return this._validationSuspendedRecords; }
            set { this._validationSuspendedRecords = value; }
        }

        // Check to see if ValidationSuspendedRecords property is set
        internal bool IsSetValidationSuspendedRecords()
        {
            return this._validationSuspendedRecords.HasValue; 
        }

    }
}