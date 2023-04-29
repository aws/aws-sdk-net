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
    /// Container for the parameters to the CreateTable operation.
    /// Adds a new table to an existing database in your account. In an Amazon Web Services
    /// account, table names must be at least unique within each Region if they are in the
    /// same database. You might have identical table names in the same Region if the tables
    /// are in separate databases. While creating the table, you must specify the table name,
    /// database name, and the retention properties. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
    /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-table.html">code
    /// sample</a> for details.
    /// </summary>
    public partial class CreateTableRequest : AmazonTimestreamWriteRequest
    {
        private string _databaseName;
        private MagneticStoreWriteProperties _magneticStoreWriteProperties;
        private RetentionProperties _retentionProperties;
        private string _tableName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The duration for which your time-series data must be stored in the memory store and
        /// the magnetic store.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of key-value pairs to label the table. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}