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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
        private double? _avg;
        private double? _max;
        private double? _min;
        private double? _p90;
        private double? _std;
        private double? _sum;

        /// <summary>
        /// Gets and sets the property Avg. 
        /// <para>
        /// The average of the values of all data points collected during the aggregation period.
        /// </para>
        /// </summary>
        public double? Avg
        {
            get { return this._avg; }
            set { this._avg = value; }
        }

        // Check to see if Avg property is set
        internal bool IsSetAvg()
        {
            return this._avg.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum of the values of all the data points collected during the aggregation
        /// period.
        /// </para>
        /// </summary>
        public double? Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum of the values of all data points collected during the aggregation period.
        /// </para>
        /// </summary>
        public double? Min
        {
            get { return this._min; }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P90. 
        /// <para>
        /// The 90th percentile of the values of all data points collected during the aggregation
        /// period.
        /// </para>
        /// </summary>
        public double? P90
        {
            get { return this._p90; }
            set { this._p90 = value; }
        }

        // Check to see if P90 property is set
        internal bool IsSetP90()
        {
            return this._p90.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Std. 
        /// <para>
        /// The standard deviation of the values of all data points collected during the aggregation
        /// period.
        /// </para>
        /// </summary>
        public double? Std
        {
            get { return this._std; }
            set { this._std = value; }
        }

        // Check to see if Std property is set
        internal bool IsSetStd()
        {
            return this._std.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the values of all data points collected during the aggregation period.
        /// </para>
        /// </summary>
        public double? Sum
        {
            get { return this._sum; }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

    }
}