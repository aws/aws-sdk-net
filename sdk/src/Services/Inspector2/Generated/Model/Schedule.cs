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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private DailySchedule _daily;
        private MonthlySchedule _monthly;
        private OneTimeSchedule _oneTime;
        private WeeklySchedule _weekly;

        /// <summary>
        /// Gets and sets the property Daily. 
        /// <para>
        /// The schedule's daily.
        /// </para>
        /// </summary>
        public DailySchedule Daily
        {
            get { return this._daily; }
            set { this._daily = value; }
        }

        // Check to see if Daily property is set
        internal bool IsSetDaily()
        {
            return this._daily != null;
        }

        /// <summary>
        /// Gets and sets the property Monthly. 
        /// <para>
        /// The schedule's monthly.
        /// </para>
        /// </summary>
        public MonthlySchedule Monthly
        {
            get { return this._monthly; }
            set { this._monthly = value; }
        }

        // Check to see if Monthly property is set
        internal bool IsSetMonthly()
        {
            return this._monthly != null;
        }

        /// <summary>
        /// Gets and sets the property OneTime. 
        /// <para>
        /// The schedule's one time.
        /// </para>
        /// </summary>
        public OneTimeSchedule OneTime
        {
            get { return this._oneTime; }
            set { this._oneTime = value; }
        }

        // Check to see if OneTime property is set
        internal bool IsSetOneTime()
        {
            return this._oneTime != null;
        }

        /// <summary>
        /// Gets and sets the property Weekly. 
        /// <para>
        /// The schedule's weekly.
        /// </para>
        /// </summary>
        public WeeklySchedule Weekly
        {
            get { return this._weekly; }
            set { this._weekly = value; }
        }

        // Check to see if Weekly property is set
        internal bool IsSetWeekly()
        {
            return this._weekly != null;
        }

    }
}