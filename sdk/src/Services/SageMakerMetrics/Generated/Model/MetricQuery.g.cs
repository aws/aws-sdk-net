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

namespace Amazon.SageMakerMetrics.Model
{
    /// <summary>
    /// Specifies a query to retrieve training metrics from SageMaker.
    /// </summary>
    public partial class MetricQuery
    {
        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time of metrics to retrieve.
        /// </para>
        /// </summary>
        public long? End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End.HasValue;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricStat. 
        /// <para>
        /// The metrics stat type of metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricStatistic MetricStat { get; set; }

        /// <summary>
        /// Checks to see if the MetricStat property is set.
        /// </summary>
        internal bool IsSetMetricStat() => this.MetricStat != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time period of metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Period Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the SageMaker resource to retrieve metrics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time of metrics to retrieve.
        /// </para>
        /// </summary>
        public long? Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start.HasValue;

        /// <summary>
        /// Gets and sets the property XAxisType. 
        /// <para>
        /// The x-axis type of metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public XAxisType XAxisType { get; set; }

        /// <summary>
        /// Checks to see if the XAxisType property is set.
        /// </summary>
        internal bool IsSetXAxisType() => this.XAxisType != null;
    }
}
