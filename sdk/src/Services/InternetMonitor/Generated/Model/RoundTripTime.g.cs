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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Round-trip time (RTT) is how long it takes for a request from the user to return a
    /// response to the user. Amazon CloudWatch Internet Monitor calculates RTT at different
    /// percentiles: p50, p90, and p95.
    /// </summary>
    public partial class RoundTripTime
    {
        /// <summary>
        /// Gets and sets the property P50. 
        /// <para>
        /// RTT at the 50th percentile (p50).
        /// </para>
        /// </summary>
        public double? P50 { get; set; }

        /// <summary>
        /// Checks to see if the P50 property is set.
        /// </summary>
        internal bool IsSetP50() => this.P50.HasValue;

        /// <summary>
        /// Gets and sets the property P90. 
        /// <para>
        /// RTT at the 90th percentile (p90). 
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
        /// RTT at the 95th percentile (p95). 
        /// </para>
        /// </summary>
        public double? P95 { get; set; }

        /// <summary>
        /// Checks to see if the P95 property is set.
        /// </summary>
        internal bool IsSetP95() => this.P95.HasValue;
    }
}
