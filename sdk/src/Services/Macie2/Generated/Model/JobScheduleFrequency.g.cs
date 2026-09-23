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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the recurrence pattern for running a classification job.
    /// </summary>
    public partial class JobScheduleFrequency
    {
        /// <summary>
        /// Gets and sets the property DailySchedule. 
        /// <para>
        /// Specifies a daily recurrence pattern for running the job.
        /// </para>
        /// </summary>
        public DailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Checks to see if the DailySchedule property is set.
        /// </summary>
        internal bool IsSetDailySchedule() => this.DailySchedule != null;

        /// <summary>
        /// Gets and sets the property MonthlySchedule. 
        /// <para>
        /// Specifies a monthly recurrence pattern for running the job.
        /// </para>
        /// </summary>
        public MonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Checks to see if the MonthlySchedule property is set.
        /// </summary>
        internal bool IsSetMonthlySchedule() => this.MonthlySchedule != null;

        /// <summary>
        /// Gets and sets the property WeeklySchedule. 
        /// <para>
        /// Specifies a weekly recurrence pattern for running the job.
        /// </para>
        /// </summary>
        public WeeklySchedule WeeklySchedule { get; set; }

        /// <summary>
        /// Checks to see if the WeeklySchedule property is set.
        /// </summary>
        internal bool IsSetWeeklySchedule() => this.WeeklySchedule != null;
    }
}
