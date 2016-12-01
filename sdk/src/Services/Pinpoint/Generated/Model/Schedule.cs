/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Schedule
    {
        private string _endTime;
        private Frequency _frequency;
        private bool? _isLocalTime;
        private QuietTime _quietTime;
        private string _startTime;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property EndTime. The scheduled time that the campaign ends in ISO
        /// 8601 format.
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency. How often the campaign delivers messages.Valid
        /// values: ONCE, HOURLY, DAILY, WEEKLY, MONTHLY
        /// </summary>
        public Frequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property IsLocalTime. Indicates whether the campaign schedule takes
        /// effect according to each user's local time.
        /// </summary>
        public bool IsLocalTime
        {
            get { return this._isLocalTime.GetValueOrDefault(); }
            set { this._isLocalTime = value; }
        }

        // Check to see if IsLocalTime property is set
        internal bool IsSetIsLocalTime()
        {
            return this._isLocalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuietTime. The time during which the campaign sends no
        /// messages.
        /// </summary>
        public QuietTime QuietTime
        {
            get { return this._quietTime; }
            set { this._quietTime = value; }
        }

        // Check to see if QuietTime property is set
        internal bool IsSetQuietTime()
        {
            return this._quietTime != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. The scheduled time that the campaign begins
        /// in ISO 8601 format.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. The starting UTC offset for the schedule if the
        /// value for isLocalTime is trueValid values: UTCUTC+01UTC+02UTC+03UTC+03:30UTC+04UTC+04:30UTC+05UTC+05:30UTC+05:45UTC+06UTC+06:30UTC+07UTC+08UTC+09UTC+09:30UTC+10UTC+10:30UTC+11UTC+12UTC+13UTC-02UTC-03UTC-04UTC-05UTC-06UTC-07UTC-08UTC-09UTC-10UTC-11
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}