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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
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
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The result set returned by a SQL statement.
    /// 
    ///  <note> 
    /// <para>
    /// This data structure is only used with the deprecated <c>ExecuteSql</c> operation.
    /// Use the <c>BatchExecuteStatement</c> or <c>ExecuteStatement</c> operation instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResultFrame
    {
        private List<Record> _records = AWSConfigs.InitializeCollections ? new List<Record>() : null;
        private ResultSetMetadata _resultSetMetadata;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The records in the result set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property ResultSetMetadata. 
        /// <para>
        /// The result-set metadata in the result set.
        /// </para>
        /// </summary>
        public ResultSetMetadata ResultSetMetadata
        {
            get { return this._resultSetMetadata; }
            set { this._resultSetMetadata = value; }
        }

        // Check to see if ResultSetMetadata property is set
        internal bool IsSetResultSetMetadata()
        {
            return this._resultSetMetadata != null;
        }

    }
}