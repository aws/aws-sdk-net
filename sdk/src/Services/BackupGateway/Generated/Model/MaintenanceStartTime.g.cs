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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// This is your gateway's weekly maintenance start time including the day and time of
    /// the week. Note that values are in terms of the gateway's time zone. Can be weekly
    /// or monthly.
    /// </summary>
    public partial class MaintenanceStartTime
    {
        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month component of the maintenance start time represented as an ordinal
        /// number from 1 to 28, where 1 represents the first day of the month and 28 represents
        /// the last day of the month.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 31)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the DayOfMonth property is set.
        /// </summary>
        internal bool IsSetDayOfMonth() => this.DayOfMonth.HasValue;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// An ordinal number between 0 and 6 that represents the day of the week, where 0 represents
        /// Sunday and 6 represents Saturday. The day of week is in the time zone of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6)]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// Checks to see if the DayOfWeek property is set.
        /// </summary>
        internal bool IsSetDayOfWeek() => this.DayOfWeek.HasValue;

        /// <summary>
        /// Gets and sets the property HourOfDay. 
        /// <para>
        /// The hour component of the maintenance start time represented as <i>hh</i>, where <i>hh</i>
        /// is the hour (0 to 23). The hour of the day is in the time zone of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 23)]
        public int? HourOfDay { get; set; }

        /// <summary>
        /// Checks to see if the HourOfDay property is set.
        /// </summary>
        internal bool IsSetHourOfDay() => this.HourOfDay.HasValue;

        /// <summary>
        /// Gets and sets the property MinuteOfHour. 
        /// <para>
        /// The minute component of the maintenance start time represented as <i>mm</i>, where
        /// <i>mm</i> is the minute (0 to 59). The minute of the hour is in the time zone of the
        /// gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 59)]
        public int? MinuteOfHour { get; set; }

        /// <summary>
        /// Checks to see if the MinuteOfHour property is set.
        /// </summary>
        internal bool IsSetMinuteOfHour() => this.MinuteOfHour.HasValue;
    }
}
