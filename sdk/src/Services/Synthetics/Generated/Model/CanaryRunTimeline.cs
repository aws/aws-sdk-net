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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains the start and end times of a single canary run.
    /// </summary>
    public partial class CanaryRunTimeline
    {
        private DateTime? _completed;
        private DateTime? _metricTimestampForRunAndRetries;
        private DateTime? _started;

        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The end time of the run.
        /// </para>
        /// </summary>
        public DateTime? Completed
        {
            get { return this._completed; }
            set { this._completed = value; }
        }

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this._completed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricTimestampForRunAndRetries. 
        /// <para>
        /// The time at which the metrics will be generated for this run or retries.
        /// </para>
        /// </summary>
        public DateTime? MetricTimestampForRunAndRetries
        {
            get { return this._metricTimestampForRunAndRetries; }
            set { this._metricTimestampForRunAndRetries = value; }
        }

        // Check to see if MetricTimestampForRunAndRetries property is set
        internal bool IsSetMetricTimestampForRunAndRetries()
        {
            return this._metricTimestampForRunAndRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The start time of the run.
        /// </para>
        /// </summary>
        public DateTime? Started
        {
            get { return this._started; }
            set { this._started = value; }
        }

        // Check to see if Started property is set
        internal bool IsSetStarted()
        {
            return this._started.HasValue; 
        }

    }
}