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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Specifies how often a knowledge base refresh schedule runs and, for weekly or monthly
    /// schedules, which day the refresh runs.
    /// </summary>
    public partial class KnowledgeBaseRefreshFrequency
    {
        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval at which the schedule refreshes the knowledge base. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DAILY</c> – The schedule refreshes the knowledge base once each day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WEEKLY</c> – The schedule refreshes the knowledge base once each week, on the
        /// day that you specify in <c>RefreshOnDay.DayOfWeek</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MONTHLY</c> – The schedule refreshes the knowledge base once each month, on the
        /// day that you specify in <c>RefreshOnDay.DayOfMonth</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOURLY</c> – The schedule refreshes the knowledge base once each hour. Available
        /// only if your account is enabled for hourly refresh. Otherwise, the request fails with
        /// an <c>InvalidParameterValueException</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For <c>DAILY</c>, <c>WEEKLY</c>, and <c>MONTHLY</c> intervals, the service chooses
        /// the time of day at which the refresh runs. You can't specify the time of day.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KbRefreshInterval Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval != null;

        /// <summary>
        /// Gets and sets the property RefreshOnDay. 
        /// <para>
        /// The day on which the refresh runs. This parameter is required for a <c>WEEKLY</c>
        /// or <c>MONTHLY</c> interval: specify the day of the week for <c>WEEKLY</c> or the day
        /// of the month for <c>MONTHLY</c>. If you don't specify it for one of these intervals,
        /// the request fails. This parameter isn't used for a <c>DAILY</c> or <c>HOURLY</c> interval.
        /// </para>
        /// </summary>
        public KnowledgeBaseScheduleRefreshOnEntity RefreshOnDay { get; set; }

        /// <summary>
        /// Checks to see if the RefreshOnDay property is set.
        /// </summary>
        internal bool IsSetRefreshOnDay() => this.RefreshOnDay != null;
    }
}
