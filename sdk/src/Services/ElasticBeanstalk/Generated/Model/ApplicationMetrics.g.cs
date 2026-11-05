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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Application request metrics for an Elastic Beanstalk environment.
    /// </summary>
    public partial class ApplicationMetrics
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The amount of time that the metrics cover (usually 10 seconds). For example, you might
        /// have 5 requests (<c>request_count</c>) within the most recent time slice of 10 seconds
        /// (<c>duration</c>).
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Latency. 
        /// <para>
        /// Represents the average latency for the slowest X percent of requests over the last
        /// 10 seconds. Latencies are in seconds with one millisecond resolution.
        /// </para>
        /// </summary>
        public Latency Latency { get; set; }

        /// <summary>
        /// Checks to see if the Latency property is set.
        /// </summary>
        internal bool IsSetLatency() => this.Latency != null;

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// Average number of requests handled by the web server per second over the last 10 seconds.
        /// </para>
        /// </summary>
        public int? RequestCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestCount property is set.
        /// </summary>
        internal bool IsSetRequestCount() => this.RequestCount.HasValue;

        /// <summary>
        /// Gets and sets the property StatusCodes. 
        /// <para>
        /// Represents the percentage of requests over the last 10 seconds that resulted in each
        /// type of status code response.
        /// </para>
        /// </summary>
        public StatusCodes StatusCodes { get; set; }

        /// <summary>
        /// Checks to see if the StatusCodes property is set.
        /// </summary>
        internal bool IsSetStatusCodes() => this.StatusCodes != null;
    }
}
