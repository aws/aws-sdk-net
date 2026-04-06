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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Controls how real-time and historical traffic data is used when calculating reachable
    /// areas. This affects both the size and shape of isolines by accounting for expected
    /// travel speeds based on congestion patterns.
    /// </summary>
    public partial class IsolineTrafficOptions
    {
        private long? _flowEventThresholdOverride;
        private TrafficUsage _usage;

        /// <summary>
        /// Gets and sets the property FlowEventThresholdOverride. 
        /// <para>
        /// The duration in seconds that real-time congestion data is considered valid before
        /// reverting to historical traffic patterns. This helps balance between using current
        /// conditions and more predictable historical data when calculating travel times.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? FlowEventThresholdOverride
        {
            get { return this._flowEventThresholdOverride; }
            set { this._flowEventThresholdOverride = value; }
        }

        // Check to see if FlowEventThresholdOverride property is set
        internal bool IsSetFlowEventThresholdOverride()
        {
            return this._flowEventThresholdOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Controls whether traffic data is used in calculations. <c>UseTrafficData</c> considers
        /// both real-time congestion and historical patterns, while <c>IgnoreTrafficData</c>
        /// calculates routes based solely on road types and speed limits. Using traffic data
        /// provides more accurate real-world estimates but may produce different results at different
        /// times of day.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>UseTrafficData</c> 
        /// </para>
        /// </summary>
        public TrafficUsage Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}