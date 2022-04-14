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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// By default, a metric stream always sends the <code>MAX</code>, <code>MIN</code>, <code>SUM</code>,
    /// and <code>SAMPLECOUNT</code> statistics for each metric that is streamed. This structure
    /// contains information for one metric that includes additional statistics in the stream.
    /// For more information about statistics, see CloudWatch, listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html.html">
    /// CloudWatch statistics definitions</a>.
    /// </summary>
    public partial class MetricStreamStatisticsConfiguration
    {
        private List<string> _additionalStatistics = new List<string>();
        private List<MetricStreamStatisticsMetric> _includeMetrics = new List<MetricStreamStatisticsMetric>();

        /// <summary>
        /// Gets and sets the property AdditionalStatistics. 
        /// <para>
        /// The list of additional statistics that are to be streamed for the metrics listed in
        /// the <code>IncludeMetrics</code> array in this structure. This list can include as
        /// many as 20 statistics.
        /// </para>
        ///  
        /// <para>
        /// If the <code>OutputFormat</code> for the stream is <code>opentelemetry0.7</code>,
        /// the only valid values are <code>p<i>??</i> </code> percentile statistics such as <code>p90</code>,
        /// <code>p99</code> and so on.
        /// </para>
        ///  
        /// <para>
        /// If the <code>OutputFormat</code> for the stream is <code>json</code>, the valid values
        /// include the abbreviations for all of the statistics listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html.html">
        /// CloudWatch statistics definitions</a>. For example, this includes <code>tm98, </code>
        /// <code>wm90</code>, <code>PR(:300)</code>, and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AdditionalStatistics
        {
            get { return this._additionalStatistics; }
            set { this._additionalStatistics = value; }
        }

        // Check to see if AdditionalStatistics property is set
        internal bool IsSetAdditionalStatistics()
        {
            return this._additionalStatistics != null && this._additionalStatistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMetrics. 
        /// <para>
        /// An array of metric name and namespace pairs that stream the additional statistics
        /// listed in the value of the <code>AdditionalStatistics</code> parameter. There can
        /// be as many as 100 pairs in the array.
        /// </para>
        ///  
        /// <para>
        /// All metrics that match the combination of metric name and namespace will be streamed
        /// with the additional statistics, no matter their dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricStreamStatisticsMetric> IncludeMetrics
        {
            get { return this._includeMetrics; }
            set { this._includeMetrics = value; }
        }

        // Check to see if IncludeMetrics property is set
        internal bool IsSetIncludeMetrics()
        {
            return this._includeMetrics != null && this._includeMetrics.Count > 0; 
        }

    }
}