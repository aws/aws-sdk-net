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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Round-trip time (RTT) is how long it takes for a request from the user to return a
    /// response to the user. Amazon CloudWatch Internet Monitor calculates RTT at different
    /// percentiles: p50, p90, and p95.
    /// </summary>
    public partial class RoundTripTime
    {
        private double? _p50;
        private double? _p90;
        private double? _p95;

        /// <summary>
        /// Gets and sets the property P50. 
        /// <para>
        /// RTT at the 50th percentile (p50).
        /// </para>
        /// </summary>
        public double P50
        {
            get { return this._p50.GetValueOrDefault(); }
            set { this._p50 = value; }
        }

        // Check to see if P50 property is set
        internal bool IsSetP50()
        {
            return this._p50.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P90. 
        /// <para>
        /// RTT at the 90th percentile (p90). 
        /// </para>
        /// </summary>
        public double P90
        {
            get { return this._p90.GetValueOrDefault(); }
            set { this._p90 = value; }
        }

        // Check to see if P90 property is set
        internal bool IsSetP90()
        {
            return this._p90.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P95. 
        /// <para>
        /// RTT at the 95th percentile (p95). 
        /// </para>
        /// </summary>
        public double P95
        {
            get { return this._p95.GetValueOrDefault(); }
            set { this._p95 = value; }
        }

        // Check to see if P95 property is set
        internal bool IsSetP95()
        {
            return this._p95.HasValue; 
        }

    }
}