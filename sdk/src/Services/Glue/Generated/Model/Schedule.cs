/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A scheduling object using a <code>cron</code> statement to schedule an event.
    /// </summary>
    public partial class Schedule
    {
        private string _scheduleExpression;
        private ScheduleState _state;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A <code>cron</code> expression that can be used as a Cloudwatch event to schedule
        /// something (see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html">CloudWatch
        /// Schedule Expression Syntax</a>. For example, to run something every day at 12:15 UTC,
        /// you would specify: <code>cron(15 12 * * ? *)</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the schedule.
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