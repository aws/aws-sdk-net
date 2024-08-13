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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The time boundary Forecast uses to align and aggregate your data to match your forecast
    /// frequency. Provide the unit of time and the time boundary as a key value pair. If
    /// you don't provide a time boundary, Forecast uses a set of <a href="https://docs.aws.amazon.com/forecast/latest/dg/data-aggregation.html#default-time-boundaries">Default
    /// Time Boundaries</a>. 
    /// 
    ///  
    /// <para>
    /// For more information about aggregation, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/data-aggregation.html">Data
    /// Aggregation for Different Forecast Frequencies</a>. For more information setting a
    /// custom time boundary, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/data-aggregation.html#specifying-time-boundary">Specifying
    /// a Time Boundary</a>. 
    /// </para>
    /// </summary>
    public partial class TimeAlignmentBoundary
    {
        private int? _dayOfMonth;
        private DayOfWeek _dayOfWeek;
        private int? _hour;
        private Month _month;

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month to use for time alignment during aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=28)]
        public int? DayOfMonth
        {
            get { return this._dayOfMonth; }
            set { this._dayOfMonth = value; }
        }

        // Check to see if DayOfMonth property is set
        internal bool IsSetDayOfMonth()
        {
            return this._dayOfMonth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of week to use for time alignment during aggregation. The day must be in uppercase.
        /// </para>
        /// </summary>
        public DayOfWeek DayOfWeek
        {
            get { return this._dayOfWeek; }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek != null;
        }

        /// <summary>
        /// Gets and sets the property Hour. 
        /// <para>
        /// The hour of day to use for time alignment during aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
        public int? Hour
        {
            get { return this._hour; }
            set { this._hour = value; }
        }

        // Check to see if Hour property is set
        internal bool IsSetHour()
        {
            return this._hour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Month. 
        /// <para>
        /// The month to use for time alignment during aggregation. The month must be in uppercase.
        /// </para>
        /// </summary>
        public Month Month
        {
            get { return this._month; }
            set { this._month = value; }
        }

        // Check to see if Month property is set
        internal bool IsSetMonth()
        {
            return this._month != null;
        }

    }
}