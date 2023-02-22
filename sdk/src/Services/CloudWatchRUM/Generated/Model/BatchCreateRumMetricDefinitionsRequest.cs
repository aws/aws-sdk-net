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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateRumMetricDefinitions operation.
    /// Specifies the extended metrics and custom metrics that you want a CloudWatch RUM app
    /// monitor to send to a destination. Valid destinations include CloudWatch and Evidently.
    /// 
    ///  
    /// <para>
    /// By default, RUM app monitors send some metrics to CloudWatch. These default metrics
    /// are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-metrics.html">CloudWatch
    /// metrics that you can collect with CloudWatch RUM</a>.
    /// </para>
    ///  
    /// <para>
    /// In addition to these default metrics, you can choose to send extended metrics or custom
    /// metrics or both.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Extended metrics enable you to send metrics with additional dimensions not included
    /// in the default metrics. You can also send extended metrics to Evidently as well as
    /// CloudWatch. The valid dimension names for the additional dimensions for extended metrics
    /// are <code>BrowserName</code>, <code>CountryCode</code>, <code>DeviceType</code>, <code>FileType</code>,
    /// <code>OSName</code>, and <code>PageId</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
    /// Extended metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom metrics are metrics that you define. You can send custom metrics to CloudWatch
    /// or to CloudWatch Evidently or to both. With custom metrics, you can use any metric
    /// name and namespace, and to derive the metrics you can use any custom events, built-in
    /// events, custom attributes, or default attributes. 
    /// </para>
    ///  
    /// <para>
    /// You can't send custom metrics to the <code>AWS/RUM</code> namespace. You must send
    /// custom metrics to a custom namespace that you define. The namespace that you use can't
    /// start with <code>AWS/</code>. CloudWatch RUM prepends <code>RUM/CustomMetrics/</code>
    /// to the custom namespace that you define, so the final namespace for your metrics in
    /// CloudWatch is <code>RUM/CustomMetrics/<i>your-custom-namespace</i> </code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The maximum number of metric definitions that you can specify in one <code>BatchCreateRumMetricDefinitions</code>
    /// operation is 200.
    /// </para>
    ///  
    /// <para>
    /// The maximum number of metric definitions that one destination can contain is 2000.
    /// </para>
    ///  
    /// <para>
    /// Extended metrics sent to CloudWatch and RUM custom metrics are charged as CloudWatch
    /// custom metrics. Each combination of additional dimension name and dimension value
    /// counts as a custom metric. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
    /// CloudWatch Pricing</a>.
    /// </para>
    ///  
    /// <para>
    /// You must have already created a destination for the metrics before you send them.
    /// For more information, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_PutRumMetricsDestination.html">PutRumMetricsDestination</a>.
    /// </para>
    ///  
    /// <para>
    /// If some metric definitions specified in a <code>BatchCreateRumMetricDefinitions</code>
    /// operations are not valid, those metric definitions fail and return errors, but all
    /// valid metric definitions in the same operation still succeed.
    /// </para>
    /// </summary>
    public partial class BatchCreateRumMetricDefinitionsRequest : AmazonCloudWatchRUMRequest
    {
        private string _appMonitorName;
        private MetricDestination _destination;
        private string _destinationArn;
        private List<MetricDefinitionRequest> _metricDefinitions = new List<MetricDefinitionRequest>();

        /// <summary>
        /// Gets and sets the property AppMonitorName. 
        /// <para>
        /// The name of the CloudWatch RUM app monitor that is to send the metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AppMonitorName
        {
            get { return this._appMonitorName; }
            set { this._appMonitorName = value; }
        }

        // Check to see if AppMonitorName property is set
        internal bool IsSetAppMonitorName()
        {
            return this._appMonitorName != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination to send the metrics to. Valid values are <code>CloudWatch</code> and
        /// <code>Evidently</code>. If you specify <code>Evidently</code>, you must also specify
        /// the ARN of the CloudWatchEvidently experiment that will receive the metrics and an
        /// IAM role that has permission to write to the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// This parameter is required if <code>Destination</code> is <code>Evidently</code>.
        /// If <code>Destination</code> is <code>CloudWatch</code>, do not use this parameter.
        /// </para>
        ///  
        /// <para>
        /// This parameter specifies the ARN of the Evidently experiment that is to receive the
        /// metrics. You must have already defined this experiment as a valid destination. For
        /// more information, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_PutRumMetricsDestination.html">PutRumMetricsDestination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// An array of structures which define the metrics that you want to send.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricDefinitionRequest> MetricDefinitions
        {
            get { return this._metricDefinitions; }
            set { this._metricDefinitions = value; }
        }

        // Check to see if MetricDefinitions property is set
        internal bool IsSetMetricDefinitions()
        {
            return this._metricDefinitions != null && this._metricDefinitions.Count > 0; 
        }

    }
}