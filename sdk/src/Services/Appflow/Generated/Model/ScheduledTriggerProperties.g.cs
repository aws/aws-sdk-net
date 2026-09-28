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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies the configuration details of a schedule-triggered flow as defined by the
    /// user. Currently, these settings only apply to the <c>Scheduled</c> trigger type.
    /// </summary>
    public partial class ScheduledTriggerProperties
    {
        /// <summary>
        /// Gets and sets the property DataPullMode. 
        /// <para>
        ///  Specifies whether a scheduled flow has an incremental data transfer or a complete
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
        ///  Specifies the date range for the records to import from the connector in the first
        /// flow run. 
        /// </para>
        /// </summary>
        public DateTime? FirstExecutionFrom { get; set; }

        /// <summary>
        /// Checks to see if the FirstExecutionFrom property is set.
        /// </summary>
        internal bool IsSetFirstExecutionFrom() => this.FirstExecutionFrom.HasValue;

        /// <summary>
        /// Gets and sets the property FlowErrorDeactivationThreshold. 
        /// <para>
        /// Defines how many times a scheduled flow fails consecutively before Amazon AppFlow
        /// deactivates it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? FlowErrorDeactivationThreshold { get; set; }

        /// <summary>
        /// Checks to see if the FlowErrorDeactivationThreshold property is set.
        /// </summary>
        internal bool IsSetFlowErrorDeactivationThreshold() => this.FlowErrorDeactivationThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleEndTime. 
        /// <para>
        /// The time at which the scheduled flow ends. The time is formatted as a timestamp that
        /// follows the ISO 8601 standard, such as <c>2022-04-27T13:00:00-07:00</c>.
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
        ///  The scheduling expression that determines the rate at which the schedule will run,
        /// for example <c>rate(5minutes)</c>. 
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
        ///  Specifies the optional offset that is added to the time interval for a schedule-triggered
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
        /// The time at which the scheduled flow starts. The time is formatted as a timestamp
        /// that follows the ISO 8601 standard, such as <c>2022-04-26T13:00:00-07:00</c>.
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
        /// Specifies the time zone used when referring to the dates and times of a scheduled
        /// flow, such as <c>America/New_York</c>. This time zone is only a descriptive label.
        /// It doesn't affect how Amazon AppFlow interprets the timestamps that you specify to
        /// schedule the flow.
        /// </para>
        ///  
        /// <para>
        /// If you want to schedule a flow by using times in a particular time zone, indicate
        /// the time zone as a UTC offset in your timestamps. For example, the UTC offsets for
        /// the <c>America/New_York</c> timezone are <c>-04:00</c> EDT and <c>-05:00 EST</c>.
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
