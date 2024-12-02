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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The Snowflake table schema.
    /// </summary>
    public partial class SnowflakeTableSchemaV1
    {
        private string _columnName;
        private string _columnType;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        ///  The column name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnType. 
        /// <para>
        ///  The column's data type. Supported data types: <c>ARRAY</c>, <c>BIGINT</c>, <c>BOOLEAN</c>,
        /// <c>CHAR</c>, <c>DATE</c>, <c>DECIMAL</c>, <c>DOUBLE</c>, <c>DOUBLE PRECISION</c>,
        /// <c>FLOAT</c>, <c>FLOAT4</c>, <c>INT</c>, <c>INTEGER</c>, <c>MAP</c>, <c>NUMERIC</c>,
        /// <c>NUMBER</c>, <c>REAL</c>, <c>SMALLINT</c>, <c>STRING</c>, <c>TIMESTAMP</c>, <c>TIMESTAMP_LTZ</c>,
        /// <c>TIMESTAMP_NTZ</c>, <c>DATETIME</c>, <c>TINYINT</c>, <c>VARCHAR</c>, <c>TEXT</c>,
        /// <c>CHARACTER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string ColumnType
        {
            get { return this._columnType; }
            set { this._columnType = value; }
        }

        // Check to see if ColumnType property is set
        internal bool IsSetColumnType()
        {
            return this._columnType != null;
        }

    }
}