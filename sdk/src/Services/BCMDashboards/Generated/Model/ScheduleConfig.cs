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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
        private string _scheduleExpression;
        private string _scheduleExpressionTimeZone;
        private SchedulePeriod _schedulePeriod;
        private ScheduleState _state;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The schedule expression that specifies when to trigger the scheduled report run. This
        /// value must be a cron expression consisting of six fields separated by white spaces:
        /// <c>cron(minutes hours day_of_month month day_of_week year)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimeZone. 
        /// <para>
        /// The time zone for the schedule expression, for example, <c>UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ScheduleExpressionTimeZone
        {
            get { return this._scheduleExpressionTimeZone; }
            set { this._scheduleExpressionTimeZone = value; }
        }

        // Check to see if ScheduleExpressionTimeZone property is set
        internal bool IsSetScheduleExpressionTimeZone()
        {
            return this._scheduleExpressionTimeZone != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulePeriod. 
        /// <para>
        /// The time period during which the schedule is active.
        /// </para>
        /// </summary>
        public SchedulePeriod SchedulePeriod
        {
            get { return this._schedulePeriod; }
            set { this._schedulePeriod = value; }
        }

        // Check to see if SchedulePeriod property is set
        internal bool IsSetSchedulePeriod()
        {
            return this._schedulePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the schedule. <c>ENABLED</c> means the scheduled report runs according
        /// to its schedule expression. <c>DISABLED</c> means the scheduled report is paused and
        /// will not run until re-enabled.
        /// </para>
        /// </summary>
        public ScheduleState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}