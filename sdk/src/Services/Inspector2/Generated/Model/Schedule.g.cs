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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A schedule.
    /// </summary>
    public partial class Schedule
    {
        /// <summary>
        /// Gets and sets the property Daily. 
        /// <para>
        /// The schedule's daily.
        /// </para>
        /// </summary>
        public DailySchedule Daily { get; set; }

        /// <summary>
        /// Checks to see if the Daily property is set.
        /// </summary>
        internal bool IsSetDaily() => this.Daily != null;

        /// <summary>
        /// Gets and sets the property Monthly. 
        /// <para>
        /// The schedule's monthly.
        /// </para>
        /// </summary>
        public MonthlySchedule Monthly { get; set; }

        /// <summary>
        /// Checks to see if the Monthly property is set.
        /// </summary>
        internal bool IsSetMonthly() => this.Monthly != null;

        /// <summary>
        /// Gets and sets the property OneTime. 
        /// <para>
        /// The schedule's one time.
        /// </para>
        /// </summary>
        public OneTimeSchedule OneTime { get; set; }

        /// <summary>
        /// Checks to see if the OneTime property is set.
        /// </summary>
        internal bool IsSetOneTime() => this.OneTime != null;

        /// <summary>
        /// Gets and sets the property Weekly. 
        /// <para>
        /// The schedule's weekly.
        /// </para>
        /// </summary>
        public WeeklySchedule Weekly { get; set; }

        /// <summary>
        /// Checks to see if the Weekly property is set.
        /// </summary>
        internal bool IsSetWeekly() => this.Weekly != null;
    }
}
