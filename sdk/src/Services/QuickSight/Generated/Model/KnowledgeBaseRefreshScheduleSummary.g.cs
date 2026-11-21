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
    /// A summary of a knowledge base refresh schedule, including its identifier, frequency,
    /// start time, and state. The <c>DescribeKnowledgeBaseRefreshSchedule</c> and <c>ListKnowledgeBaseRefreshSchedules</c>
    /// operations return this summary.
    /// </summary>
    public partial class KnowledgeBaseRefreshScheduleSummary
    {
        /// <summary>
        /// Gets and sets the property ScheduleFrequency. 
        /// <para>
        /// The frequency configuration for the refresh schedule. The frequency configuration
        /// specifies how often the schedule runs and, for weekly or monthly schedules, the day
        /// on which it runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseRefreshFrequency ScheduleFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleFrequency property is set.
        /// </summary>
        internal bool IsSetScheduleFrequency() => this.ScheduleFrequency != null;

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// The unique identifier for the refresh schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleId property is set.
        /// </summary>
        internal bool IsSetScheduleId() => this.ScheduleId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time, in ISO 8601 format, after which the schedule can start refreshing
        /// the knowledge base.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the refresh schedule. A schedule that isn't <c>ENABLED</c> doesn't
        /// run refreshes.
        /// </para>
        /// </summary>
        public ScheduleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
