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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// If the interval for this service level objective is a calendar interval, this structure
    /// contains the interval specifications.
    /// </summary>
    public partial class CalendarInterval
    {
        private int? _duration;
        private DurationUnit _durationUnit;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Specifies the duration of each calendar interval. For example, if <c>Duration</c>
        /// is <c>1</c> and <c>DurationUnit</c> is <c>MONTH</c>, each interval is one month, aligned
        /// with the calendar.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationUnit. 
        /// <para>
        /// Specifies the calendar interval unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DurationUnit DurationUnit
        {
            get { return this._durationUnit; }
            set { this._durationUnit = value; }
        }

        // Check to see if DurationUnit property is set
        internal bool IsSetDurationUnit()
        {
            return this._durationUnit != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when you want the first interval to start. Be sure to choose a time
        /// that configures the intervals the way that you want. For example, if you want weekly
        /// intervals starting on Mondays at 6 a.m., be sure to specify a start time that is a
        /// Monday at 6 a.m.
        /// </para>
        ///  
        /// <para>
        /// When used in a raw HTTP Query API, it is formatted as be epoch time in seconds. For
        /// example: <c>1698778057</c> 
        /// </para>
        ///  
        /// <para>
        /// As soon as one calendar interval ends, another automatically begins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}