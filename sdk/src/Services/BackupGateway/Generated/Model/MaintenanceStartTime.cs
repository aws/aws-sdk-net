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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// This is your gateway's weekly maintenance start time including the day and time of
    /// the week. Note that values are in terms of the gateway's time zone. Can be weekly
    /// or monthly.
    /// </summary>
    public partial class MaintenanceStartTime
    {
        private int? _dayOfMonth;
        private int? _dayOfWeek;
        private int? _hourOfDay;
        private int? _minuteOfHour;

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month component of the maintenance start time represented as an ordinal
        /// number from 1 to 28, where 1 represents the first day of the month and 28 represents
        /// the last day of the month.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=31)]
        public int DayOfMonth
        {
            get { return this._dayOfMonth.GetValueOrDefault(); }
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
        /// An ordinal number between 0 and 6 that represents the day of the week, where 0 represents
        /// Sunday and 6 represents Saturday. The day of week is in the time zone of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public int DayOfWeek
        {
            get { return this._dayOfWeek.GetValueOrDefault(); }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HourOfDay. 
        /// <para>
        /// The hour component of the maintenance start time represented as <i>hh</i>, where <i>hh</i>
        /// is the hour (0 to 23). The hour of the day is in the time zone of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int HourOfDay
        {
            get { return this._hourOfDay.GetValueOrDefault(); }
            set { this._hourOfDay = value; }
        }

        // Check to see if HourOfDay property is set
        internal bool IsSetHourOfDay()
        {
            return this._hourOfDay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinuteOfHour. 
        /// <para>
        /// The minute component of the maintenance start time represented as <i>mm</i>, where
        /// <i>mm</i> is the minute (0 to 59). The minute of the hour is in the time zone of the
        /// gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=59)]
        public int MinuteOfHour
        {
            get { return this._minuteOfHour.GetValueOrDefault(); }
            set { this._minuteOfHour = value; }
        }

        // Check to see if MinuteOfHour property is set
        internal bool IsSetMinuteOfHour()
        {
            return this._minuteOfHour.HasValue; 
        }

    }
}