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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Structured schedule specification. Select exactly one schedule form.
    /// </summary>
    public partial class ScheduleSpec
    {
        /// <summary>
        /// Gets and sets the property Cron. 
        /// <para>
        /// Runs on an EventBridge cron or rate cadence
        /// </para>
        /// </summary>
        public CronSchedule Cron { get; set; }

        /// <summary>
        /// Checks to see if the Cron property is set.
        /// </summary>
        internal bool IsSetCron() => this.Cron != null;

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// Runs within a recurring time-of-day window
        /// </para>
        /// </summary>
        public TimeRangeSchedule TimeRange { get; set; }

        /// <summary>
        /// Checks to see if the TimeRange property is set.
        /// </summary>
        internal bool IsSetTimeRange() => this.TimeRange != null;
    }
}
