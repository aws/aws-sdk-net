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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// The metadata and rows that make up a query result set. The metadata describes the
    /// column structure and data types. To return a <c>ResultSet</c> object, use <a>GetQueryResults</a>.
    /// </summary>
    public partial class ResultSet
    {
        private ResultSetMetadata _resultSetMetadata;
        private List<Row> _rows = AWSConfigs.InitializeCollections ? new List<Row>() : null;

        /// <summary>
        /// Gets and sets the property ResultSetMetadata. 
        /// <para>
        /// The metadata that describes the column structure and data types of a table of query
        /// results.
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

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        /// The rows in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Row> Rows
        {
            get { return this._rows; }
            set { this._rows = value; }
        }

        // Check to see if Rows property is set
        internal bool IsSetRows()
        {
            return this._rows != null && (this._rows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}