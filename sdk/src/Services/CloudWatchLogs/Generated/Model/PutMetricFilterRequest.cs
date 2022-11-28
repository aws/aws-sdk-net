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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricFilter operation.
    /// Creates or updates a metric filter and associates it with the specified log group.
    /// With metric filters, you can configure rules to extract metric data from log events
    /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
    /// 
    ///  
    /// <para>
    /// The maximum number of metric filters that can be associated with a log group is 100.
    /// </para>
    ///  
    /// <para>
    /// When you create a metric filter, you can also optionally assign a unit and dimensions
    /// to the metric that is created.
    /// </para>
    ///  <important> 
    /// <para>
    /// Metrics extracted from log events are charged as custom metrics. To prevent unexpected
    /// high charges, do not specify high-cardinality fields such as <code>IPAddress</code>
    /// or <code>requestID</code> as dimensions. Each different value found for a dimension
    /// is treated as a separate metric and accrues charges as a separate custom metric. 
    /// </para>
    ///  
    /// <para>
    /// CloudWatch Logs disables a metric filter if it generates 1,000 different name/value
    /// pairs for your specified dimensions within a certain amount of time. This helps to
    /// prevent accidental high charges.
    /// </para>
    ///  
    /// <para>
    /// You can also set up a billing alarm to alert you if your charges are higher than expected.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/monitor_estimated_charges_with_cloudwatch.html">
    /// Creating a Billing Alarm to Monitor Your Estimated Amazon Web Services Charges</a>.
    /// 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutMetricFilterRequest : AmazonCloudWatchLogsRequest
    {
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private List<MetricTransformation> _metricTransformations = new List<MetricTransformation>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutMetricFilterRequest() { }

        /// <summary>
        /// Instantiates PutMetricFilterRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        /// <param name="filterName">A name for the metric filter.</param>
        /// <param name="filterPattern">A filter pattern for extracting metric data out of ingested log events.</param>
        /// <param name="metricTransformations">A collection of information that defines how metric data gets emitted.</param>
        public PutMetricFilterRequest(string logGroupName, string filterName, string filterPattern, List<MetricTransformation> metricTransformations)
        {
            _logGroupName = logGroupName;
            _filterName = filterName;
            _filterPattern = filterPattern;
            _metricTransformations = metricTransformations;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// A name for the metric filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// A filter pattern for extracting metric data out of ingested log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricTransformations. 
        /// <para>
        /// A collection of information that defines how metric data gets emitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<MetricTransformation> MetricTransformations
        {
            get { return this._metricTransformations; }
            set { this._metricTransformations = value; }
        }

        // Check to see if MetricTransformations property is set
        internal bool IsSetMetricTransformations()
        {
            return this._metricTransformations != null && this._metricTransformations.Count > 0; 
        }

    }
}