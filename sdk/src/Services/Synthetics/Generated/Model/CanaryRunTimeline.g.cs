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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains the start and end times of a single canary run.
    /// </summary>
    public partial class CanaryRunTimeline
    {
        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The end time of the run.
        /// </para>
        /// </summary>
        public DateTime? Completed { get; set; }

        /// <summary>
        /// Checks to see if the Completed property is set.
        /// </summary>
        internal bool IsSetCompleted() => this.Completed.HasValue;

        /// <summary>
        /// Gets and sets the property MetricTimestampForRunAndRetries. 
        /// <para>
        /// The time at which the metrics will be generated for this run or retries.
        /// </para>
        /// </summary>
        public DateTime? MetricTimestampForRunAndRetries { get; set; }

        /// <summary>
        /// Checks to see if the MetricTimestampForRunAndRetries property is set.
        /// </summary>
        internal bool IsSetMetricTimestampForRunAndRetries() => this.MetricTimestampForRunAndRetries.HasValue;

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The start time of the run.
        /// </para>
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Checks to see if the Started property is set.
        /// </summary>
        internal bool IsSetStarted() => this.Started.HasValue;
    }
}
