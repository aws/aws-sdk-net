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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// <b>Internal only</b>. Represents a set of statistics that describe a specific metric.
    /// To learn more about the metrics published to Amazon CloudWatch, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/cw-metrics.html">Amazon
    /// MWAA performance metrics in Amazon CloudWatch</a>.
    /// </summary>
    [Obsolete("This type is for internal use and not meant for public use. Data set for this type will be ignored.")]
    public partial class StatisticSet
    {
        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        ///  <b>Internal only</b>. The maximum value of the sample set.
        /// </para>
        /// </summary>
        public double? Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum.HasValue;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        ///  <b>Internal only</b>. The minimum value of the sample set.
        /// </para>
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

        /// <summary>
        /// Gets and sets the property SampleCount. 
        /// <para>
        ///  <b>Internal only</b>. The number of samples used for the statistic set.
        /// </para>
        /// </summary>
        public int? SampleCount { get; set; }

        /// <summary>
        /// Checks to see if the SampleCount property is set.
        /// </summary>
        internal bool IsSetSampleCount() => this.SampleCount.HasValue;

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        ///  <b>Internal only</b>. The sum of values for the sample set.
        /// </para>
        /// </summary>
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;
    }
}
