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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Specifies the detailed pattern for event recurrence. Use this to define complex scheduling
    /// rules such as "every 2nd Tuesday of the month" or "every 3 months on the 15th".
    /// </summary>
    public partial class RecurrencePattern
    {
        private List<int> _byMonth = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _byMonthDay = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _byWeekdayOccurrence = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private RecurrenceFrequency _frequency;
        private int? _interval;

        /// <summary>
        /// Gets and sets the property ByMonth. 
        /// <para>
        /// Specifies which month the event should occur in (1-12, where 1=January, 12=December).
        /// Used with YEARLY frequency to schedule events in specific month. 
        /// </para>
        ///  
        /// <para>
        /// Note: It does not accept multiple values in the same list
        /// </para>
        /// </summary>
        public List<int> ByMonth
        {
            get { return this._byMonth; }
            set { this._byMonth = value; }
        }

        // Check to see if ByMonth property is set
        internal bool IsSetByMonth()
        {
            return this._byMonth != null && (this._byMonth.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ByMonthDay. 
        /// <para>
        /// Specifies which day of the month the event should occur on (1-31). Used with MONTHLY
        /// or YEARLY frequency to schedule events on specific date within a month.
        /// </para>
        ///  
        /// <para>
        ///  Examples: [15] for events on the 15th of each month, [-1] for events on the last
        /// day of month. 
        /// </para>
        ///  
        /// <para>
        /// Note: It does not accept multiple values in the same list. If a specified day doesn't
        /// exist in a particular month (e.g., day 31 in February), the event will be skipped
        /// for that month. This field cannot be used simultaneously with ByWeekdayOccurrence
        /// as they represent different scheduling approaches (specific dates vs. relative weekday
        /// positions).
        /// </para>
        /// </summary>
        public List<int> ByMonthDay
        {
            get { return this._byMonthDay; }
            set { this._byMonthDay = value; }
        }

        // Check to see if ByMonthDay property is set
        internal bool IsSetByMonthDay()
        {
            return this._byMonthDay != null && (this._byMonthDay.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ByWeekdayOccurrence. 
        /// <para>
        /// Specifies which occurrence of a weekday within the month the event should occur on.
        /// Must be used with MONTHLY or YEARLY frequency. 
        /// </para>
        ///  
        /// <para>
        /// Example: 2 corresponds to second occurrence of the weekday in the month. -1 corresponds
        /// to last occurrence of the weekday in the month 
        /// </para>
        ///  
        /// <para>
        /// The weekday itself is specified separately in the HoursOfOperationConfig. Example:
        /// To schedule the recurring event for the 2nd Thursday of April every year, set ByWeekdayOccurrence=[2],
        /// Day=THURSDAY, ByMonth=[4], Frequency: YEARLY and INTERVAL=1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<int> ByWeekdayOccurrence
        {
            get { return this._byWeekdayOccurrence; }
            set { this._byWeekdayOccurrence = value; }
        }

        // Check to see if ByWeekdayOccurrence property is set
        internal bool IsSetByWeekdayOccurrence()
        {
            return this._byWeekdayOccurrence != null && (this._byWeekdayOccurrence.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Defines how often the pattern repeats. This is the base unit for the recurrence schedule
        /// and works in conjunction with the Interval field to determine the exact repetition
        /// sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecurrenceFrequency Frequency
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
        /// Gets and sets the property Interval. 
        /// <para>
        /// Specifies the number of frequency units between each occurrence. Must be a positive
        /// integer. 
        /// </para>
        ///  
        /// <para>
        ///  Examples: To repeat every week, set Interval=1 with WEEKLY frequency. To repeat every
        /// two months, set Interval=2 with MONTHLY frequency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
        public int Interval
        {
            get { return this._interval.GetValueOrDefault(); }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

    }
}