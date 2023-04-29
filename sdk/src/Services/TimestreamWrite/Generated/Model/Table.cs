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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents a database table in Timestream. Tables contain one or more related time
    /// series. You can modify the retention duration of the memory store and the magnetic
    /// store for a table.
    /// </summary>
    public partial class Table
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _databaseName;
        private DateTime? _lastUpdatedTime;
        private MagneticStoreWriteProperties _magneticStoreWriteProperties;
        private RetentionProperties _retentionProperties;
        private string _tableName;
        private TableStatus _tableStatus;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name that uniquely identifies this table.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the Timestream table was created. 
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Timestream database that contains this table.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the Timestream table was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MagneticStoreWriteProperties. 
        /// <para>
        /// Contains properties to set on the table when enabling magnetic store writes.
        /// </para>
        /// </summary>
        public MagneticStoreWriteProperties MagneticStoreWriteProperties
        {
            get { return this._magneticStoreWriteProperties; }
            set { this._magneticStoreWriteProperties = value; }
        }

        // Check to see if MagneticStoreWriteProperties property is set
        internal bool IsSetMagneticStoreWriteProperties()
        {
            return this._magneticStoreWriteProperties != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionProperties. 
        /// <para>
        /// The retention duration for the memory store and magnetic store.
        /// </para>
        /// </summary>
        public RetentionProperties RetentionProperties
        {
            get { return this._retentionProperties; }
            set { this._retentionProperties = value; }
        }

        // Check to see if RetentionProperties property is set
        internal bool IsSetRetentionProperties()
        {
            return this._retentionProperties != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the Timestream table.
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
        /// Gets and sets the property TableStatus. 
        /// <para>
        /// The current state of the table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DELETING</code> - The table is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> - The table is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TableStatus TableStatus
        {
            get { return this._tableStatus; }
            set { this._tableStatus = value; }
        }

        // Check to see if TableStatus property is set
        internal bool IsSetTableStatus()
        {
            return this._tableStatus != null;
        }

    }
}