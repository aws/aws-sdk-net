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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The aggregated values of the metric.
    /// </summary>
    public partial class MetricQueryValue
    {
        /// <summary>
        /// Gets and sets the property Avg. 
        /// <para>
        /// The average of the values of all data points collected during the aggregation period.
        /// </para>
        /// </summary>
        public double? Avg { get; set; }

        /// <summary>
        /// Checks to see if the Avg property is set.
        /// </summary>
        internal bool IsSetAvg() => this.Avg.HasValue;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum of the values of all the data points collected during the aggregation
        /// period.
        /// </para>
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum of the values of all data points collected during the aggregation period.
        /// </para>
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min.HasValue;

        /// <summary>
        /// Gets and sets the property P90. 
        /// <para>
        /// The 90th percentile of the values of all data points collected during the aggregation
        /// period.
        /// </para>
        /// </summary>
        public double? P90 { get; set; }

        /// <summary>
        /// Checks to see if the P90 property is set.
        /// </summary>
        internal bool IsSetP90() => this.P90.HasValue;

        /// <summary>
        /// Gets and sets the property Std. 
        /// <para>
        /// The standard deviation of the values of all data points collected during the aggregation
        /// period.
        /// </para>
        /// </summary>
        public double? Std { get; set; }

        /// <summary>
        /// Checks to see if the Std property is set.
        /// </summary>
        internal bool IsSetStd() => this.Std.HasValue;

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the values of all data points collected during the aggregation period.
        /// </para>
        /// </summary>
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;
    }
}
