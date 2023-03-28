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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about when an on-call rotation is in effect and how long the rotation
    /// period lasts.
    /// </summary>
    public partial class RecurrenceSettings
    {
        private List<HandOffTime> _dailySettings = new List<HandOffTime>();
        private List<MonthlySetting> _monthlySettings = new List<MonthlySetting>();
        private int? _numberOfOnCalls;
        private int? _recurrenceMultiplier;
        private Dictionary<string, List<CoverageTime>> _shiftCoverages = new Dictionary<string, List<CoverageTime>>();
        private List<WeeklySetting> _weeklySettings = new List<WeeklySetting>();

        /// <summary>
        /// Gets and sets the property DailySettings. 
        /// <para>
        /// Information about on-call rotations that recur daily.
        /// </para>
        /// </summary>
        public List<HandOffTime> DailySettings
        {
            get { return this._dailySettings; }
            set { this._dailySettings = value; }
        }

        // Check to see if DailySettings property is set
        internal bool IsSetDailySettings()
        {
            return this._dailySettings != null && this._dailySettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MonthlySettings. 
        /// <para>
        /// Information about on-call rotations that recur monthly.
        /// </para>
        /// </summary>
        public List<MonthlySetting> MonthlySettings
        {
            get { return this._monthlySettings; }
            set { this._monthlySettings = value; }
        }

        // Check to see if MonthlySettings property is set
        internal bool IsSetMonthlySettings()
        {
            return this._monthlySettings != null && this._monthlySettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfOnCalls. 
        /// <para>
        /// The number of contacts, or shift team members designated to be on call concurrently
        /// during a shift. For example, in an on-call schedule containing ten contacts, a value
        /// of <code>2</code> designates that two of them are on call at any given time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int NumberOfOnCalls
        {
            get { return this._numberOfOnCalls.GetValueOrDefault(); }
            set { this._numberOfOnCalls = value; }
        }

        // Check to see if NumberOfOnCalls property is set
        internal bool IsSetNumberOfOnCalls()
        {
            return this._numberOfOnCalls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecurrenceMultiplier. 
        /// <para>
        /// The number of days, weeks, or months a single rotation lasts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public int RecurrenceMultiplier
        {
            get { return this._recurrenceMultiplier.GetValueOrDefault(); }
            set { this._recurrenceMultiplier = value; }
        }

        // Check to see if RecurrenceMultiplier property is set
        internal bool IsSetRecurrenceMultiplier()
        {
            return this._recurrenceMultiplier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShiftCoverages. 
        /// <para>
        /// Information about the days of the week included in on-call rotation coverage.
        /// </para>
        /// </summary>
        public Dictionary<string, List<CoverageTime>> ShiftCoverages
        {
            get { return this._shiftCoverages; }
            set { this._shiftCoverages = value; }
        }

        // Check to see if ShiftCoverages property is set
        internal bool IsSetShiftCoverages()
        {
            return this._shiftCoverages != null && this._shiftCoverages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WeeklySettings. 
        /// <para>
        /// Information about on-call rotations that recur weekly.
        /// </para>
        /// </summary>
        public List<WeeklySetting> WeeklySettings
        {
            get { return this._weeklySettings; }
            set { this._weeklySettings = value; }
        }

        // Check to see if WeeklySettings property is set
        internal bool IsSetWeeklySettings()
        {
            return this._weeklySettings != null && this._weeklySettings.Count > 0; 
        }

    }
}