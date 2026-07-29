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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
        private long? _endTimeOffset;
        private string _scheduleExpression;
        private long? _startTimeOffset;

        /// <summary>
        /// Gets and sets the property EndTimeOffset. 
        /// <para>
        /// The offset, in seconds, before the scheduled execution time at which the query time
        /// range ends. Must be non-negative and less than <c>StartTimeOffset</c>. The default
        /// is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2592000)]
        public long? EndTimeOffset
        {
            get { return this._endTimeOffset; }
            set { this._endTimeOffset = value; }
        }

        // Check to see if EndTimeOffset property is set
        internal bool IsSetEndTimeOffset()
        {
            return this._endTimeOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The schedule expression that defines how often the underlying CloudWatch Logs scheduled
        /// query runs. Specify a <c>rate()</c> expression, for example <c>rate(5 minutes)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property StartTimeOffset. 
        /// <para>
        /// The offset, in seconds, before the scheduled execution time at which the query time
        /// range begins. For example, an offset of 360 (6 minutes) on a query running at 12:05:00
        /// starts the query time range at 11:59:00.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2592000)]
        public long? StartTimeOffset
        {
            get { return this._startTimeOffset; }
            set { this._startTimeOffset = value; }
        }

        // Check to see if StartTimeOffset property is set
        internal bool IsSetStartTimeOffset()
        {
            return this._startTimeOffset.HasValue; 
        }

    }
}