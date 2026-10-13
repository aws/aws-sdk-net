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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about when an on-call rotation is in effect and how long the rotation
    /// period lasts.
    /// </summary>
    public partial class RecurrenceSettings
    {
        /// <summary>
        /// Gets and sets the property DailySettings. 
        /// <para>
        /// Information about on-call rotations that recur daily.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandOffTime> DailySettings { get; set; } = AWSConfigs.InitializeCollections ? new List<HandOffTime>() : null;

        /// <summary>
        /// Checks to see if the DailySettings property is set.
        /// </summary>
        internal bool IsSetDailySettings() => this.DailySettings != null && (this.DailySettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MonthlySettings. 
        /// <para>
        /// Information about on-call rotations that recur monthly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonthlySetting> MonthlySettings { get; set; } = AWSConfigs.InitializeCollections ? new List<MonthlySetting>() : null;

        /// <summary>
        /// Checks to see if the MonthlySettings property is set.
        /// </summary>
        internal bool IsSetMonthlySettings() => this.MonthlySettings != null && (this.MonthlySettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfOnCalls. 
        /// <para>
        /// The number of contacts, or shift team members designated to be on call concurrently
        /// during a shift. For example, in an on-call schedule that contains ten contacts, a
        /// value of <c>2</c> designates that two of them are on call at any given time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? NumberOfOnCalls { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfOnCalls property is set.
        /// </summary>
        internal bool IsSetNumberOfOnCalls() => this.NumberOfOnCalls.HasValue;

        /// <summary>
        /// Gets and sets the property RecurrenceMultiplier. 
        /// <para>
        /// The number of days, weeks, or months a single rotation lasts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? RecurrenceMultiplier { get; set; }

        /// <summary>
        /// Checks to see if the RecurrenceMultiplier property is set.
        /// </summary>
        internal bool IsSetRecurrenceMultiplier() => this.RecurrenceMultiplier.HasValue;

        /// <summary>
        /// Gets and sets the property ShiftCoverages. 
        /// <para>
        /// Information about the days of the week that the on-call rotation coverage includes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<CoverageTime>> ShiftCoverages { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<CoverageTime>>() : null;

        /// <summary>
        /// Checks to see if the ShiftCoverages property is set.
        /// </summary>
        internal bool IsSetShiftCoverages() => this.ShiftCoverages != null && (this.ShiftCoverages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WeeklySettings. 
        /// <para>
        /// Information about on-call rotations that recur weekly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WeeklySetting> WeeklySettings { get; set; } = AWSConfigs.InitializeCollections ? new List<WeeklySetting>() : null;

        /// <summary>
        /// Checks to see if the WeeklySettings property is set.
        /// </summary>
        internal bool IsSetWeeklySettings() => this.WeeklySettings != null && (this.WeeklySettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
