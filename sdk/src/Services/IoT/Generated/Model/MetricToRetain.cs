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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private bool? _exportMetric;
        private string _metric;
        private MetricDimension _metricDimension;

        /// <summary>
        /// Gets and sets the property ExportMetric. 
        /// <para>
        /// The value indicates exporting metrics related to the <c>MetricToRetain </c> when it's
        /// true.
        /// </para>
        /// </summary>
        public bool? ExportMetric
        {
            get { return this._exportMetric; }
            set { this._exportMetric = value; }
        }

        // Check to see if ExportMetric property is set
        internal bool IsSetExportMetric()
        {
            return this._exportMetric.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// What is measured by the behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDimension. 
        /// <para>
        /// The dimension of a metric. This can't be used with custom metrics.
        /// </para>
        /// </summary>
        public MetricDimension MetricDimension
        {
            get { return this._metricDimension; }
            set { this._metricDimension = value; }
        }

        // Check to see if MetricDimension property is set
        internal bool IsSetMetricDimension()
        {
            return this._metricDimension != null;
        }

    }
}