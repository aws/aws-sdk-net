/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a <a>RestoreTableFromClusterSnapshot</a> operation.
    /// </summary>
    public partial class TableRestoreStatus
    {
        private string _clusterIdentifier;
        private string _message;
        private string _newTableName;
        private long? _progressInMegaBytes;
        private DateTime? _requestTime;
        private string _snapshotIdentifier;
        private string _sourceDatabaseName;
        private string _sourceSchemaName;
        private string _sourceTableName;
        private TableRestoreStatusType _status;
        private string _tableRestoreRequestId;
        private string _targetDatabaseName;
        private string _targetSchemaName;
        private long? _totalDataInMegaBytes;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the Amazon Redshift cluster that the table is being restored to.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the table restore request. Status values include <code>SUCCEEDED</code>,
        /// <code>FAILED</code>, <code>CANCELLED</code>, <code>PENDING</code>, <code>IN_PROGRESS</code>.
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
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create as a result of the table restore request.
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
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier of the snapshot that the table is being restored from.
        /// </para>
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database that contains the table being restored.
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
        /// The name of the source schema that contains the table being restored.
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
        /// The name of the source table being restored.
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
        /// A value that describes the current state of the table restore request.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>SUCCEEDED</code>, <code>FAILED</code>, <code>CANCELLED</code>,
        /// <code>PENDING</code>, <code>IN_PROGRESS</code>
        /// </para>
        /// </summary>
        public TableRestoreStatusType Status
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
        /// The unique identifier for the table restore request.
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
        /// The name of the database to restore the table to.
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
        /// The name of the schema to restore the table to.
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

    }
}