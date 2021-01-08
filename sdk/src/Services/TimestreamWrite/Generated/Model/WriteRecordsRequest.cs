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
    /// Container for the parameters to the WriteRecords operation.
    /// The WriteRecords operation enables you to write your time series data into Timestream.
    /// You can specify a single data point or a batch of data points to be inserted into
    /// the system. Timestream offers you with a flexible schema that auto detects the column
    /// names and data types for your Timestream tables based on the dimension names and data
    /// types of the data points you specify when invoking writes into the database. Timestream
    /// support eventual consistency read semantics. This means that when you query data immediately
    /// after writing a batch of data into Timestream, the query results might not reflect
    /// the results of a recently completed write operation. The results may also include
    /// some stale data. If you repeat the query request after a short time, the results should
    /// return the latest data. Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
    /// Management</a> in the Timestream Developer Guide.
    /// </summary>
    public partial class WriteRecordsRequest : AmazonTimestreamWriteRequest
    {
        private Record _commonAttributes;
        private string _databaseName;
        private List<Record> _records = new List<Record>();
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CommonAttributes. 
        /// <para>
        /// A record containing the common measure and dimension attributes shared across all
        /// the records in the request. The measure and dimension attributes specified in here
        /// will be merged with the measure and dimension attributes in the records object when
        /// the data is written into Timestream. 
        /// </para>
        /// </summary>
        public Record CommonAttributes
        {
            get { return this._commonAttributes; }
            set { this._commonAttributes = value; }
        }

        // Check to see if CommonAttributes property is set
        internal bool IsSetCommonAttributes()
        {
            return this._commonAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
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
        /// Gets and sets the property Records. 
        /// <para>
        /// An array of records containing the unique dimension and measure attributes for each
        /// time series data point. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the Timesream table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
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

    }
}