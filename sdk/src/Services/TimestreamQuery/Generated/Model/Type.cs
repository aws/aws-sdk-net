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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Contains the data type of a column in a query result set. The data type can be scalar
    /// or complex. The supported scalar data types are integers, boolean, string, double,
    /// timestamp, date, time, and intervals. The supported complex data types are arrays,
    /// rows, and timeseries.
    /// </summary>
    public partial class Type
    {
        private ColumnInfo _arrayColumnInfo;
        private List<ColumnInfo> _rowColumnInfo = new List<ColumnInfo>();
        private ScalarType _scalarType;
        private ColumnInfo _timeSeriesMeasureValueColumnInfo;

        /// <summary>
        /// Gets and sets the property ArrayColumnInfo. 
        /// <para>
        /// Indicates if the column is an array.
        /// </para>
        /// </summary>
        public ColumnInfo ArrayColumnInfo
        {
            get { return this._arrayColumnInfo; }
            set { this._arrayColumnInfo = value; }
        }

        // Check to see if ArrayColumnInfo property is set
        internal bool IsSetArrayColumnInfo()
        {
            return this._arrayColumnInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RowColumnInfo. 
        /// <para>
        /// Indicates if the column is a row.
        /// </para>
        /// </summary>
        public List<ColumnInfo> RowColumnInfo
        {
            get { return this._rowColumnInfo; }
            set { this._rowColumnInfo = value; }
        }

        // Check to see if RowColumnInfo property is set
        internal bool IsSetRowColumnInfo()
        {
            return this._rowColumnInfo != null && this._rowColumnInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScalarType. 
        /// <para>
        /// Indicates if the column is of type string, integer, boolean, double, timestamp, date,
        /// time. 
        /// </para>
        /// </summary>
        public ScalarType ScalarType
        {
            get { return this._scalarType; }
            set { this._scalarType = value; }
        }

        // Check to see if ScalarType property is set
        internal bool IsSetScalarType()
        {
            return this._scalarType != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesMeasureValueColumnInfo. 
        /// <para>
        /// Indicates if the column is a timeseries data type.
        /// </para>
        /// </summary>
        public ColumnInfo TimeSeriesMeasureValueColumnInfo
        {
            get { return this._timeSeriesMeasureValueColumnInfo; }
            set { this._timeSeriesMeasureValueColumnInfo = value; }
        }

        // Check to see if TimeSeriesMeasureValueColumnInfo property is set
        internal bool IsSetTimeSeriesMeasureValueColumnInfo()
        {
            return this._timeSeriesMeasureValueColumnInfo != null;
        }

    }
}