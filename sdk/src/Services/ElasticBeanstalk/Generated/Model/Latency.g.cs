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
    /// Represents the average latency for the slowest X percent of requests over the last
    /// 10 seconds.
    /// </summary>
    public partial class Latency
    {
        /// <summary>
        /// Gets and sets the property P10. 
        /// <para>
        /// The average latency for the slowest 90 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P10 { get; set; }

        /// <summary>
        /// Checks to see if the P10 property is set.
        /// </summary>
        internal bool IsSetP10() => this.P10.HasValue;

        /// <summary>
        /// Gets and sets the property P50. 
        /// <para>
        /// The average latency for the slowest 50 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P50 { get; set; }

        /// <summary>
        /// Checks to see if the P50 property is set.
        /// </summary>
        internal bool IsSetP50() => this.P50.HasValue;

        /// <summary>
        /// Gets and sets the property P75. 
        /// <para>
        /// The average latency for the slowest 25 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P75 { get; set; }

        /// <summary>
        /// Checks to see if the P75 property is set.
        /// </summary>
        internal bool IsSetP75() => this.P75.HasValue;

        /// <summary>
        /// Gets and sets the property P85. 
        /// <para>
        /// The average latency for the slowest 15 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P85 { get; set; }

        /// <summary>
        /// Checks to see if the P85 property is set.
        /// </summary>
        internal bool IsSetP85() => this.P85.HasValue;

        /// <summary>
        /// Gets and sets the property P90. 
        /// <para>
        /// The average latency for the slowest 10 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P90 { get; set; }

        /// <summary>
        /// Checks to see if the P90 property is set.
        /// </summary>
        internal bool IsSetP90() => this.P90.HasValue;

        /// <summary>
        /// Gets and sets the property P95. 
        /// <para>
        /// The average latency for the slowest 5 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P95 { get; set; }

        /// <summary>
        /// Checks to see if the P95 property is set.
        /// </summary>
        internal bool IsSetP95() => this.P95.HasValue;

        /// <summary>
        /// Gets and sets the property P99. 
        /// <para>
        /// The average latency for the slowest 1 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P99 { get; set; }

        /// <summary>
        /// Checks to see if the P99 property is set.
        /// </summary>
        internal bool IsSetP99() => this.P99.HasValue;

        /// <summary>
        /// Gets and sets the property P999. 
        /// <para>
        /// The average latency for the slowest 0.1 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P999 { get; set; }

        /// <summary>
        /// Checks to see if the P999 property is set.
        /// </summary>
        internal bool IsSetP999() => this.P999.HasValue;
    }
}
