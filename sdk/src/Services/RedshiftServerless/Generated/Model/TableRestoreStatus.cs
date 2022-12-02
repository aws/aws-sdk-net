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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Contains information about a table restore request.
    /// </summary>
    public partial class TableRestoreStatus
    {
        private string _message;
        private string _namespaceName;
        private string _newTableName;
        private long? _progressInMegaBytes;
        private DateTime? _requestTime;
        private string _snapshotName;
        private string _sourceDatabaseName;
        private string _sourceSchemaName;
        private string _sourceTableName;
        private string _status;
        private string _tableRestoreRequestId;
        private string _targetDatabaseName;
        private string _targetSchemaName;
        private long? _totalDataInMegaBytes;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the table restore request. Status values include <code>SUCCEEDED</code>,
        /// <code>FAILED</code>, <code>CANCELED</code>, <code>PENDING</code>, <code>IN_PROGRESS</code>.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The namespace of the table being restored from.
        /// </para>
        /// </summary>
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create from the restore operation.
        /// </para>
        /// </summary>
        public string NewTableName
        {
            get { return this._newTableName; }
            set { this._newTableName = value; }
        }

        // Check to see if NewTableName property is set
        internal bool IsSetNewTableName()
        {
            return this._newTableName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        /// The amount of data restored to the new table so far, in megabytes (MB).
        /// </para>
        /// </summary>
        public long ProgressInMegaBytes
        {
            get { return this._progressInMegaBytes.GetValueOrDefault(); }
            set { this._progressInMegaBytes = value; }
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this._progressInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// The time that the table restore request was made, in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public DateTime RequestTime
        {
            get { return this._requestTime.GetValueOrDefault(); }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot being restored from.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database being restored from.
        /// </para>
        /// </summary>
        public string SourceDatabaseName
        {
            get { return this._sourceDatabaseName; }
            set { this._sourceDatabaseName = value; }
        }

        // Check to see if SourceDatabaseName property is set
        internal bool IsSetSourceDatabaseName()
        {
            return this._sourceDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSchemaName. 
        /// <para>
        /// The name of the source schema being restored from.
        /// </para>
        /// </summary>
        public string SourceSchemaName
        {
            get { return this._sourceSchemaName; }
            set { this._sourceSchemaName = value; }
        }

        // Check to see if SourceSchemaName property is set
        internal bool IsSetSourceSchemaName()
        {
            return this._sourceSchemaName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table being restored from.
        /// </para>
        /// </summary>
        public string SourceTableName
        {
            get { return this._sourceTableName; }
            set { this._sourceTableName = value; }
        }

        // Check to see if SourceTableName property is set
        internal bool IsSetSourceTableName()
        {
            return this._sourceTableName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A value that describes the current state of the table restore request. Possible values
        /// include <code>SUCCEEDED</code>, <code>FAILED</code>, <code>CANCELED</code>, <code>PENDING</code>,
        /// <code>IN_PROGRESS</code>.
        /// </para>
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
        /// Gets and sets the property TableRestoreRequestId. 
        /// <para>
        /// The ID of the RestoreTableFromSnapshot request.
        /// </para>
        /// </summary>
        public string TableRestoreRequestId
        {
            get { return this._tableRestoreRequestId; }
            set { this._tableRestoreRequestId = value; }
        }

        // Check to see if TableRestoreRequestId property is set
        internal bool IsSetTableRestoreRequestId()
        {
            return this._tableRestoreRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// The name of the database to restore to.
        /// </para>
        /// </summary>
        public string TargetDatabaseName
        {
            get { return this._targetDatabaseName; }
            set { this._targetDatabaseName = value; }
        }

        // Check to see if TargetDatabaseName property is set
        internal bool IsSetTargetDatabaseName()
        {
            return this._targetDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSchemaName. 
        /// <para>
        /// The name of the schema to restore to.
        /// </para>
        /// </summary>
        public string TargetSchemaName
        {
            get { return this._targetSchemaName; }
            set { this._targetSchemaName = value; }
        }

        // Check to see if TargetSchemaName property is set
        internal bool IsSetTargetSchemaName()
        {
            return this._targetSchemaName != null;
        }

        /// <summary>
        /// Gets and sets the property TotalDataInMegaBytes. 
        /// <para>
        /// The total amount of data to restore to the new table, in megabytes (MB).
        /// </para>
        /// </summary>
        public long TotalDataInMegaBytes
        {
            get { return this._totalDataInMegaBytes.GetValueOrDefault(); }
            set { this._totalDataInMegaBytes = value; }
        }

        // Check to see if TotalDataInMegaBytes property is set
        internal bool IsSetTotalDataInMegaBytes()
        {
            return this._totalDataInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup being restored from.
        /// </para>
        /// </summary>
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}