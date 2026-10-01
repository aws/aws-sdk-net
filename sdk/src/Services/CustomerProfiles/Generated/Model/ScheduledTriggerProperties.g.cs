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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Specifies the configuration details of a scheduled-trigger flow that you define. Currently,
    /// these settings only apply to the scheduled-trigger type.
    /// </summary>
    public partial class ScheduledTriggerProperties
    {
        /// <summary>
        /// Gets and sets the property DataPullMode. 
        /// <para>
        /// Specifies whether a scheduled flow has an incremental data transfer or a complete
        /// data transfer for each flow run.
        /// </para>
        /// </summary>
        public DataPullMode DataPullMode { get; set; }

        /// <summary>
        /// Checks to see if the DataPullMode property is set.
        /// </summary>
        internal bool IsSetDataPullMode() => this.DataPullMode != null;

        /// <summary>
        /// Gets and sets the property FirstExecutionFrom. 
        /// <para>
        /// Specifies the date range for the records to import from the connector in the first
        /// flow run.
        /// </para>
        /// </summary>
        public DateTime? FirstExecutionFrom { get; set; }

        /// <summary>
        /// Checks to see if the FirstExecutionFrom property is set.
        /// </summary>
        internal bool IsSetFirstExecutionFrom() => this.FirstExecutionFrom.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleEndTime. 
        /// <para>
        /// Specifies the scheduled end time for a scheduled-trigger flow.
        /// </para>
        /// </summary>
        public DateTime? ScheduleEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleEndTime property is set.
        /// </summary>
        internal bool IsSetScheduleEndTime() => this.ScheduleEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The scheduling expression that determines the rate at which the schedule will run,
        /// for example rate (5 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleOffset. 
        /// <para>
        /// Specifies the optional offset that is added to the time interval for a schedule-triggered
        /// flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36000)]
        public long? ScheduleOffset { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleOffset property is set.
        /// </summary>
        internal bool IsSetScheduleOffset() => this.ScheduleOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleStartTime. 
        /// <para>
        /// Specifies the scheduled start time for a scheduled-trigger flow.
        /// </para>
        /// </summary>
        public DateTime? ScheduleStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleStartTime property is set.
        /// </summary>
        internal bool IsSetScheduleStartTime() => this.ScheduleStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// Specifies the time zone used when referring to the date and time of a scheduled-triggered
        /// flow, such as America/New_York.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
