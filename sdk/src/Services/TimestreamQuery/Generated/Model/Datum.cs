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
    /// Datum represents a single data point in a query result.
    /// </summary>
    public partial class Datum
    {
        private List<Datum> _arrayValue = new List<Datum>();
        private bool? _nullValue;
        private Row _rowValue;
        private string _scalarValue;
        private List<TimeSeriesDataPoint> _timeSeriesValue = new List<TimeSeriesDataPoint>();

        /// <summary>
        /// Gets and sets the property ArrayValue. 
        /// <para>
        ///  Indicates if the data point is an array. 
        /// </para>
        /// </summary>
        public List<Datum> ArrayValue
        {
            get { return this._arrayValue; }
            set { this._arrayValue = value; }
        }

        // Check to see if ArrayValue property is set
        internal bool IsSetArrayValue()
        {
            return this._arrayValue != null && this._arrayValue.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NullValue. 
        /// <para>
        ///  Indicates if the data point is null. 
        /// </para>
        /// </summary>
        public bool NullValue
        {
            get { return this._nullValue.GetValueOrDefault(); }
            set { this._nullValue = value; }
        }

        // Check to see if NullValue property is set
        internal bool IsSetNullValue()
        {
            return this._nullValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowValue. 
        /// <para>
        ///  Indicates if the data point is a row. 
        /// </para>
        /// </summary>
        public Row RowValue
        {
            get { return this._rowValue; }
            set { this._rowValue = value; }
        }

        // Check to see if RowValue property is set
        internal bool IsSetRowValue()
        {
            return this._rowValue != null;
        }

        /// <summary>
        /// Gets and sets the property ScalarValue. 
        /// <para>
        ///  Indicates if the data point is a scalar value such as integer, string, double, or
        /// boolean. 
        /// </para>
        /// </summary>
        public string ScalarValue
        {
            get { return this._scalarValue; }
            set { this._scalarValue = value; }
        }

        // Check to see if ScalarValue property is set
        internal bool IsSetScalarValue()
        {
            return this._scalarValue != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesValue. 
        /// <para>
        ///  Indicates if the data point is of timeseries data type. 
        /// </para>
        /// </summary>
        public List<TimeSeriesDataPoint> TimeSeriesValue
        {
            get { return this._timeSeriesValue; }
            set { this._timeSeriesValue = value; }
        }

        // Check to see if TimeSeriesValue property is set
        internal bool IsSetTimeSeriesValue()
        {
            return this._timeSeriesValue != null && this._timeSeriesValue.Count > 0; 
        }

    }
}