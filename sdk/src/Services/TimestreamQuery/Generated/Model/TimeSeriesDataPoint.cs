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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// The timeseries data type represents the values of a measure over time. A time series
    /// is an array of rows of timestamps and measure values, with rows sorted in ascending
    /// order of time. A TimeSeriesDataPoint is a single data point in the time series. It
    /// represents a tuple of (time, measure value) in a time series.
    /// </summary>
    public partial class TimeSeriesDataPoint
    {
        private string _time;
        private Datum _value;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp when the measure value was collected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The measure value for the data point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Datum Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}