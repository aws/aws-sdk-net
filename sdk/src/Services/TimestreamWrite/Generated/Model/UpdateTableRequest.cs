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
    /// Container for the parameters to the UpdateTable operation.
    /// Modifies the retention duration of the memory store and magnetic store for your Timestream
    /// table. Note that the change in retention duration takes effect immediately. For example,
    /// if the retention period of the memory store was initially set to 2 hours and then
    /// changed to 24 hours, the memory store will be capable of holding 24 hours of data,
    /// but will be populated with 24 hours of data 22 hours after this change was made. Timestream
    /// does not retrieve data from the magnetic store to populate the memory store. 
    /// 
    ///  
    /// <para>
    /// Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
    /// Management</a> in the Timestream Developer Guide.
    /// </para>
    /// </summary>
    public partial class UpdateTableRequest : AmazonTimestreamWriteRequest
    {
        private string _databaseName;
        private RetentionProperties _retentionProperties;
        private string _tableName;

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
        /// Gets and sets the property RetentionProperties. 
        /// <para>
        /// The retention duration of the memory store and the magnetic store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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