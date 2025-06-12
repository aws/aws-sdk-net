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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricData operation.
    /// Publishes metric data to Amazon CloudWatch. CloudWatch associates the data with the
    /// specified metric. If the specified metric does not exist, CloudWatch creates the metric.
    /// When CloudWatch creates a metric, it can take up to fifteen minutes for the metric
    /// to appear in calls to <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_ListMetrics.html">ListMetrics</a>.
    /// 
    ///  
    /// <para>
    /// You can publish metrics with associated entity data (so that related telemetry can
    /// be found and viewed together), or publish metric data by itself. To send entity data
    /// with your metrics, use the <c>EntityMetricData</c> parameter. To send metrics without
    /// entity data, use the <c>MetricData</c> parameter. The <c>EntityMetricData</c> structure
    /// includes <c>MetricData</c> structures for the metric data.
    /// </para>
    ///  
    /// <para>
    /// You can publish either individual values in the <c>Value</c> field, or arrays of values
    /// and the number of times each value occurred during the period by using the <c>Values</c>
    /// and <c>Counts</c> fields in the <c>MetricData</c> structure. Using the <c>Values</c>
    /// and <c>Counts</c> method enables you to publish up to 150 values per metric with one
    /// <c>PutMetricData</c> request, and supports retrieving percentile statistics on this
    /// data.
    /// </para>
    ///  
    /// <para>
    /// Each <c>PutMetricData</c> request is limited to 1 MB in size for HTTP POST requests.
    /// You can send a payload compressed by gzip. Each request is also limited to no more
    /// than 1000 different metrics (across both the <c>MetricData</c> and <c>EntityMetricData</c>
    /// properties).
    /// </para>
    ///  
    /// <para>
    /// Although the <c>Value</c> parameter accepts numbers of type <c>Double</c>, CloudWatch
    /// rejects values that are either too small or too large. Values must be in the range
    /// of -2^360 to 2^360. In addition, special values (for example, NaN, +Infinity, -Infinity)
    /// are not supported.
    /// </para>
    ///  
    /// <para>
    /// You can use up to 30 dimensions per metric to further clarify what data the metric
    /// collects. Each dimension consists of a Name and Value pair. For more information about
    /// specifying dimensions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publishing
    /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You specify the time stamp to be associated with each data point. You can specify
    /// time stamps that are as much as two weeks before the current date, and as much as
    /// 2 hours after the current day and time.
    /// </para>
    ///  
    /// <para>
    /// Data points with time stamps from 24 hours ago or longer can take at least 48 hours
    /// to become available for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
    /// from the time they are submitted. Data points with time stamps between 3 and 24 hours
    /// ago can take as much as 2 hours to become available for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
    /// data using a statistic set instead, you can only retrieve percentile statistics for
    /// this data if one of the following conditions is true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>SampleCount</c> value of the statistic set is 1 and <c>Min</c>, <c>Max</c>,
    /// and <c>Sum</c> are all equal.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Min</c> and <c>Max</c> are equal, and <c>Sum</c> is equal to <c>Min</c> multiplied
    /// by <c>SampleCount</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutMetricDataRequest : AmazonCloudWatchRequest
    {
        private List<EntityMetricData> _entityMetricData = AWSConfigs.InitializeCollections ? new List<EntityMetricData>() : null;
        private List<MetricDatum> _metricData = AWSConfigs.InitializeCollections ? new List<MetricDatum>() : null;
        private string _awsNamespace;
        private bool? _strictEntityValidation;

        /// <summary>
        /// Gets and sets the property EntityMetricData. 
        /// <para>
        /// Data for metrics that contain associated entity information. You can include up to
        /// two <c>EntityMetricData</c> objects, each of which can contain a single <c>Entity</c>
        /// and associated metrics.
        /// </para>
        ///  
        /// <para>
        /// The limit of metrics allowed, 1000, is the sum of both <c>EntityMetricData</c> and
        /// <c>MetricData</c> metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntityMetricData> EntityMetricData
        {
            get { return this._entityMetricData; }
            set { this._entityMetricData = value; }
        }

        // Check to see if EntityMetricData property is set
        internal bool IsSetEntityMetricData()
        {
            return this._entityMetricData != null && (this._entityMetricData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricData. 
        /// <para>
        /// The data for the metrics. Use this parameter if your metrics do not contain associated
        /// entities. The array can include no more than 1000 metrics per call.
        /// </para>
        ///  
        /// <para>
        /// The limit of metrics allowed, 1000, is the sum of both <c>EntityMetricData</c> and
        /// <c>MetricData</c> metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDatum> MetricData
        {
            get { return this._metricData; }
            set { this._metricData = value; }
        }

        // Check to see if MetricData property is set
        internal bool IsSetMetricData()
        {
            return this._metricData != null && (this._metricData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace for the metric data. You can use ASCII characters for the namespace,
        /// except for control characters which are not supported.
        /// </para>
        ///  
        /// <para>
        /// To avoid conflicts with Amazon Web Services service namespaces, you should not specify
        /// a namespace that begins with <c>AWS/</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property StrictEntityValidation. 
        /// <para>
        /// Whether to accept valid metric data when an invalid entity is sent.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When set to <c>true</c>: Any validation error (for entity or metric data) will fail
        /// the entire request, and no data will be ingested. The failed operation will return
        /// a 400 result with the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When set to <c>false</c>: Validation errors in the entity will not associate the metric
        /// with the entity, but the metric data will still be accepted and ingested. Validation
        /// errors in the metric data will fail the entire request, and no data will be ingested.
        /// </para>
        ///  
        /// <para>
        /// In the case of an invalid entity, the operation will return a <c>200</c> status, but
        /// an additional response header will contain information about the validation errors.
        /// The new header, <c>X-Amzn-Failure-Message</c> is an enumeration of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InvalidEntity</c> - The provided entity is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidKeyAttributes</c> - The provided <c>KeyAttributes</c> of an entity is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidAttributes</c> - The provided <c>Attributes</c> of an entity is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidTypeValue</c> - The provided <c>Type</c> in the <c>KeyAttributes</c> of
        /// an entity is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EntitySizeTooLarge</c> - The number of <c>EntityMetricData</c> objects allowed
        /// is 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MissingRequiredFields</c> - There are missing required fields in the <c>KeyAttributes</c>
        /// for the provided <c>Type</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details of the requirements for specifying an entity, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/adding-your-own-related-telemetry.html">How
        /// to add related information to telemetry</a> in the <i>CloudWatch User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This parameter is <i>required</i> when <c>EntityMetricData</c> is included.
        /// </para>
        /// </summary>
        public bool? StrictEntityValidation
        {
            get { return this._strictEntityValidation; }
            set { this._strictEntityValidation = value; }
        }

        // Check to see if StrictEntityValidation property is set
        internal bool IsSetStrictEntityValidation()
        {
            return this._strictEntityValidation.HasValue; 
        }

    }
}