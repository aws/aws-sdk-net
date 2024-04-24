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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the recurrence pattern for running a classification job.
    /// </summary>
    public partial class JobScheduleFrequency
    {
        private DailySchedule _dailySchedule;
        private MonthlySchedule _monthlySchedule;
        private WeeklySchedule _weeklySchedule;

        /// <summary>
        /// Gets and sets the property DailySchedule. 
        /// <para>
        /// Specifies a daily recurrence pattern for running the job.
        /// </para>
        /// </summary>
        public DailySchedule DailySchedule
        {
            get { return this._dailySchedule; }
            set { this._dailySchedule = value; }
        }

        // Check to see if DailySchedule property is set
        internal bool IsSetDailySchedule()
        {
            return this._dailySchedule != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlySchedule. 
        /// <para>
        /// Specifies a monthly recurrence pattern for running the job.
        /// </para>
        /// </summary>
        public MonthlySchedule MonthlySchedule
        {
            get { return this._monthlySchedule; }
            set { this._monthlySchedule = value; }
        }

        // Check to see if MonthlySchedule property is set
        internal bool IsSetMonthlySchedule()
        {
            return this._monthlySchedule != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklySchedule. 
        /// <para>
        /// Specifies a weekly recurrence pattern for running the job.
        /// </para>
        /// </summary>
        public WeeklySchedule WeeklySchedule
        {
            get { return this._weeklySchedule; }
            set { this._weeklySchedule = value; }
        }

        // Check to see if WeeklySchedule property is set
        internal bool IsSetWeeklySchedule()
        {
            return this._weeklySchedule != null;
        }

    }
}