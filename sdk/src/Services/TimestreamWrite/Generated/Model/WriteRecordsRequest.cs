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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Container for the parameters to the WriteRecords operation.
    /// Enables you to write your time-series data into Timestream. You can specify a single
    /// data point or a batch of data points to be inserted into the system. Timestream offers
    /// you a flexible schema that auto detects the column names and data types for your Timestream
    /// tables based on the dimension names and data types of the data points you specify
    /// when invoking writes into the database. 
    /// 
    ///  
    /// <para>
    /// Timestream supports eventual consistency read semantics. This means that when you
    /// query data immediately after writing a batch of data into Timestream, the query results
    /// might not reflect the results of a recently completed write operation. The results
    /// may also include some stale data. If you repeat the query request after a short time,
    /// the results should return the latest data. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
    /// quotas apply</a>. 
    /// </para>
    ///  
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.write.html">code
    /// sample</a> for details.
    /// </para>
    ///  
    /// <para>
    ///  <b>Upserts</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>Version</c> parameter in a <c>WriteRecords</c> request to update
    /// data points. Timestream tracks a version number with each record. <c>Version</c> defaults
    /// to <c>1</c> when it's not specified for the record in the request. Timestream updates
    /// an existing record’s measure value along with its <c>Version</c> when it receives
    /// a write request with a higher <c>Version</c> number for that record. When it receives
    /// an update request where the measure value is the same as that of the existing record,
    /// Timestream still updates <c>Version</c>, if it is greater than the existing value
    /// of <c>Version</c>. You can update a data point as many times as desired, as long as
    /// the value of <c>Version</c> continuously increases. 
    /// </para>
    ///  
    /// <para>
    ///  For example, suppose you write a new record without indicating <c>Version</c> in
    /// the request. Timestream stores this record, and set <c>Version</c> to <c>1</c>. Now,
    /// suppose you try to update this record with a <c>WriteRecords</c> request of the same
    /// record with a different measure value but, like before, do not provide <c>Version</c>.
    /// In this case, Timestream will reject this update with a <c>RejectedRecordsException</c>
    /// since the updated record’s version is not greater than the existing value of Version.
    /// 
    /// </para>
    ///  
    /// <para>
    /// However, if you were to resend the update request with <c>Version</c> set to <c>2</c>,
    /// Timestream would then succeed in updating the record’s value, and the <c>Version</c>
    /// would be set to <c>2</c>. Next, suppose you sent a <c>WriteRecords</c> request with
    /// this same record and an identical measure value, but with <c>Version</c> set to <c>3</c>.
    /// In this case, Timestream would only update <c>Version</c> to <c>3</c>. Any further
    /// updates would need to send a version number greater than <c>3</c>, or the update requests
    /// would receive a <c>RejectedRecordsException</c>. 
    /// </para>
    /// </summary>
    public partial class WriteRecordsRequest : AmazonTimestreamWriteRequest
    {
        private Record _commonAttributes;
        private string _databaseName;
        private List<Record> _records = AWSConfigs.InitializeCollections ? new List<Record>() : null;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CommonAttributes. 
        /// <para>
        /// A record that contains the common measure, dimension, time, and version attributes
        /// shared across all the records in the request. The measure and dimension attributes
        /// specified will be merged with the measure and dimension attributes in the records
        /// object when the data is written into Timestream. Dimensions may not overlap, or a
        /// <c>ValidationException</c> will be thrown. In other words, a record must contain dimensions
        /// with unique names. 
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
        /// Gets and sets the property Records. 
        /// <para>
        /// An array of records that contain the unique measure, dimension, time, and version
        /// attributes for each time-series data point. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}