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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of the metrics of a trial component.
    /// </summary>
    public partial class TrialComponentMetricSummary
    {
        /// <summary>
        /// Gets and sets the property Avg. 
        /// <para>
        /// The average value of the metric.
        /// </para>
        /// </summary>
        public double? Avg { get; set; }

        /// <summary>
        /// Checks to see if the Avg property is set.
        /// </summary>
        internal bool IsSetAvg() => this.Avg.HasValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of samples used to generate the metric.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Last. 
        /// <para>
        /// The most recent value of the metric.
        /// </para>
        /// </summary>
        public double? Last { get; set; }

        /// <summary>
        /// Checks to see if the Last property is set.
        /// </summary>
        internal bool IsSetLast() => this.Last.HasValue;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum value of the metric.
        /// </para>
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum value of the metric.
        /// </para>
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min.HasValue;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property StdDev. 
        /// <para>
        /// The standard deviation of the metric.
        /// </para>
        /// </summary>
        public double? StdDev { get; set; }

        /// <summary>
        /// Checks to see if the StdDev property is set.
        /// </summary>
        internal bool IsSetStdDev() => this.StdDev.HasValue;

        /// <summary>
        /// Gets and sets the property TimeStamp. 
        /// <para>
        /// When the metric was last updated.
        /// </para>
        /// </summary>
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the TimeStamp property is set.
        /// </summary>
        internal bool IsSetTimeStamp() => this.TimeStamp.HasValue;
    }
}
