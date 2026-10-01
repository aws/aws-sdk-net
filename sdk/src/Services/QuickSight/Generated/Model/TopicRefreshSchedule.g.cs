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
    /// A structure that represents a topic refresh schedule.
    /// </summary>
    public partial class TopicRefreshSchedule
    {
        /// <summary>
        /// Gets and sets the property BasedOnSpiceSchedule. 
        /// <para>
        /// A Boolean value that controls whether to schedule runs at the same schedule that is
        /// specified in SPICE dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? BasedOnSpiceSchedule { get; set; }

        /// <summary>
        /// Checks to see if the BasedOnSpiceSchedule property is set.
        /// </summary>
        internal bool IsSetBasedOnSpiceSchedule() => this.BasedOnSpiceSchedule.HasValue;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A Boolean value that controls whether to schedule is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RepeatAt. 
        /// <para>
        /// The time of day when the refresh should run, for example, Monday-Sunday.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RepeatAt { get; set; }

        /// <summary>
        /// Checks to see if the RepeatAt property is set.
        /// </summary>
        internal bool IsSetRepeatAt() => this.RepeatAt != null;

        /// <summary>
        /// Gets and sets the property StartingAt. 
        /// <para>
        /// The starting date and time for the refresh schedule.
        /// </para>
        /// </summary>
        public DateTime? StartingAt { get; set; }

        /// <summary>
        /// Checks to see if the StartingAt property is set.
        /// </summary>
        internal bool IsSetStartingAt() => this.StartingAt.HasValue;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone that you want the refresh schedule to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property TopicScheduleType. 
        /// <para>
        /// The type of refresh schedule. Valid values for this structure are <c>HOURLY</c>, <c>DAILY</c>,
        /// <c>WEEKLY</c>, and <c>MONTHLY</c>.
        /// </para>
        /// </summary>
        public TopicScheduleType TopicScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the TopicScheduleType property is set.
        /// </summary>
        internal bool IsSetTopicScheduleType() => this.TopicScheduleType != null;
    }
}
