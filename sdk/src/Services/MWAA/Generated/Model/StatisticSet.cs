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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// <b>Internal only</b>. Represents a set of statistics that describe a specific metric.
    /// To learn more about the metrics published to Amazon CloudWatch, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/cw-metrics.html">Amazon
    /// MWAA performance metrics in Amazon CloudWatch</a>.
    /// </summary>
    public partial class StatisticSet
    {
        private double? _maximum;
        private double? _minimum;
        private int? _sampleCount;
        private double? _sum;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        ///  <b>Internal only</b>. The maximum value of the sample set.
        /// </para>
        /// </summary>
        public double Maximum
        {
            get { return this._maximum.GetValueOrDefault(); }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        ///  <b>Internal only</b>. The minimum value of the sample set.
        /// </para>
        /// </summary>
        public double Minimum
        {
            get { return this._minimum.GetValueOrDefault(); }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleCount. 
        /// <para>
        ///  <b>Internal only</b>. The number of samples used for the statistic set.
        /// </para>
        /// </summary>
        public int SampleCount
        {
            get { return this._sampleCount.GetValueOrDefault(); }
            set { this._sampleCount = value; }
        }

        // Check to see if SampleCount property is set
        internal bool IsSetSampleCount()
        {
            return this._sampleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        ///  <b>Internal only</b>. The sum of values for the sample set.
        /// </para>
        /// </summary>
        public double Sum
        {
            get { return this._sum.GetValueOrDefault(); }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

    }
}