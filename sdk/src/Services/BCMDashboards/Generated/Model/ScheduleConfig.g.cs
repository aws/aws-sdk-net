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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Defines the schedule for a scheduled report, including the cron expression, time zone,
    /// active period, and the schedule state.
    /// </summary>
    public partial class ScheduleConfig
    {
        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The schedule expression that specifies when to trigger the scheduled report run. This
        /// value must be a cron expression consisting of six fields separated by white spaces:
        /// <c>cron(minutes hours day_of_month month day_of_week year)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimeZone. 
        /// <para>
        /// The time zone for the schedule expression, for example, <c>UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ScheduleExpressionTimeZone { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpressionTimeZone property is set.
        /// </summary>
        internal bool IsSetScheduleExpressionTimeZone() => this.ScheduleExpressionTimeZone != null;

        /// <summary>
        /// Gets and sets the property SchedulePeriod. 
        /// <para>
        /// The time period during which the schedule is active.
        /// </para>
        /// </summary>
        public SchedulePeriod SchedulePeriod { get; set; }

        /// <summary>
        /// Checks to see if the SchedulePeriod property is set.
        /// </summary>
        internal bool IsSetSchedulePeriod() => this.SchedulePeriod != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the schedule. <c>ENABLED</c> means the scheduled report runs according
        /// to its schedule expression. <c>DISABLED</c> means the scheduled report is paused and
        /// will not run until re-enabled.
        /// </para>
        /// </summary>
        public ScheduleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
