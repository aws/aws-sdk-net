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
    /// Container for the parameters to the DeleteTable operation.
    /// Deletes a given Timestream table. This is an irreversible operation. After a Timestream
    /// database table is deleted, the time-series data stored in the table cannot be recovered.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// Due to the nature of distributed retries, the operation can return either success
    /// or a ResourceNotFoundException. Clients should consider them equivalent.
    /// </para>
    ///  </note> 
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.delete-table.html">code
    /// sample</a> for details.
    /// </para>
    /// </summary>
    public partial class DeleteTableRequest : AmazonTimestreamWriteRequest
    {
        private string _databaseName;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database where the Timestream database is to be deleted.
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the Timestream table to be deleted.
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