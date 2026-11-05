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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Contains the schedule expression and time-range offsets that define when a scheduled
    /// query runs and what time range each execution covers.
    /// </summary>
    public partial class ScheduleConfiguration
    {
        /// <summary>
        /// Gets and sets the property EndTimeOffset. 
        /// <para>
        /// The offset, in seconds, before the scheduled execution time at which the query time
        /// range ends. Must be non-negative and less than <c>StartTimeOffset</c>. The default
        /// is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2592000)]
        public long? EndTimeOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeOffset property is set.
        /// </summary>
        internal bool IsSetEndTimeOffset() => this.EndTimeOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The schedule expression that defines how often the underlying CloudWatch Logs scheduled
        /// query runs. Specify a <c>rate()</c> expression, for example <c>rate(5 minutes)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property StartTimeOffset. 
        /// <para>
        /// The offset, in seconds, before the scheduled execution time at which the query time
        /// range begins. For example, an offset of 360 (6 minutes) on a query running at 12:05:00
        /// starts the query time range at 11:59:00.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2592000)]
        public long? StartTimeOffset { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeOffset property is set.
        /// </summary>
        internal bool IsSetStartTimeOffset() => this.StartTimeOffset.HasValue;
    }
}
