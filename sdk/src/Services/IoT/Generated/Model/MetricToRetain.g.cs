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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The metric you want to retain. Dimensions are optional.
    /// </summary>
    public partial class MetricToRetain
    {
        /// <summary>
        /// Gets and sets the property ExportMetric. 
        /// <para>
        /// The value indicates exporting metrics related to the <c>MetricToRetain </c> when it's
        /// true.
        /// </para>
        /// </summary>
        public bool? ExportMetric { get; set; }

        /// <summary>
        /// Checks to see if the ExportMetric property is set.
        /// </summary>
        internal bool IsSetExportMetric() => this.ExportMetric.HasValue;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// What is measured by the behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property MetricDimension. 
        /// <para>
        /// The dimension of a metric. This can't be used with custom metrics.
        /// </para>
        /// </summary>
        public MetricDimension MetricDimension { get; set; }

        /// <summary>
        /// Checks to see if the MetricDimension property is set.
        /// </summary>
        internal bool IsSetMetricDimension() => this.MetricDimension != null;
    }
}
