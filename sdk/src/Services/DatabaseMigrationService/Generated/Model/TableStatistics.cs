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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TableStatistics
    {
        private long? _ddls;
        private long? _deletes;
        private long? _fullLoadCondtnlChkFailedRows;
        private long? _fullLoadErrorRows;
        private long? _fullLoadRows;
        private long? _inserts;
        private DateTime? _lastUpdateTime;
        private string _schemaName;
        private string _tableName;
        private string _tableState;
        private long? _updates;

        /// <summary>
        /// Gets and sets the property Ddls. 
        /// <para>
        /// The Data Definition Language (DDL) used to build and modify the structure of your
        /// tables.
        /// </para>
        /// </summary>
        public long Ddls
        {
            get { return this._ddls.GetValueOrDefault(); }
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
        public long Deletes
        {
            get { return this._deletes.GetValueOrDefault(); }
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
        /// The number of rows that failed conditional checks during the Full Load operation (valid
        /// only for DynamoDB as a target migrations).
        /// </para>
        /// </summary>
        public long FullLoadCondtnlChkFailedRows
        {
            get { return this._fullLoadCondtnlChkFailedRows.GetValueOrDefault(); }
            set { this._fullLoadCondtnlChkFailedRows = value; }
        }

        // Check to see if FullLoadCondtnlChkFailedRows property is set
        internal bool IsSetFullLoadCondtnlChkFailedRows()
        {
            return this._fullLoadCondtnlChkFailedRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadErrorRows. 
        /// <para>
        /// The number of rows that failed to load during the Full Load operation (valid only
        /// for DynamoDB as a target migrations).
        /// </para>
        /// </summary>
        public long FullLoadErrorRows
        {
            get { return this._fullLoadErrorRows.GetValueOrDefault(); }
            set { this._fullLoadErrorRows = value; }
        }

        // Check to see if FullLoadErrorRows property is set
        internal bool IsSetFullLoadErrorRows()
        {
            return this._fullLoadErrorRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadRows. 
        /// <para>
        /// The number of rows added during the Full Load operation.
        /// </para>
        /// </summary>
        public long FullLoadRows
        {
            get { return this._fullLoadRows.GetValueOrDefault(); }
            set { this._fullLoadRows = value; }
        }

        // Check to see if FullLoadRows property is set
        internal bool IsSetFullLoadRows()
        {
            return this._fullLoadRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Inserts. 
        /// <para>
        /// The number of insert actions performed on a table.
        /// </para>
        /// </summary>
        public long Inserts
        {
            get { return this._inserts.GetValueOrDefault(); }
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
        /// The last time the table was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
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
        /// The state of the table.
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
        public long Updates
        {
            get { return this._updates.GetValueOrDefault(); }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates.HasValue; 
        }

    }
}