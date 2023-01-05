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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a CloudWatch metric of your choosing for a target tracking scaling policy
    /// to use with Application Auto Scaling.
    /// 
    ///  
    /// <para>
    /// For information about the available metrics for a service, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/aws-services-cloudwatch-metrics.html">Amazon
    /// Web Services services that publish CloudWatch metrics</a> in the <i>Amazon CloudWatch
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To create your customized metric specification:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Add values for each required parameter from CloudWatch. You can use an existing metric,
    /// or a new metric that you create. To use your own metric, you must first publish the
    /// metric to CloudWatch. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publish
    /// custom metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Choose a metric that changes proportionally with capacity. The value of the metric
    /// should increase or decrease in inverse proportion to the number of capacity units.
    /// That is, the value of the metric should decrease when capacity increases, and increase
    /// when capacity decreases. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For an example of how creating new metrics can be useful, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-using-sqs-queue.html">Scaling
    /// based on Amazon SQS</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. This topic
    /// mentions Auto Scaling groups, but the same scenario for Amazon SQS can apply to the
    /// target tracking scaling policies that you create for a Spot Fleet by using the Application
    /// Auto Scaling API.
    /// </para>
    ///  
    /// <para>
    /// For more information about the CloudWatch terminology below, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html">Amazon
    /// CloudWatch concepts</a> in the <i>Amazon CloudWatch User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CustomizedMetricSpecification
    {
        private List<MetricDimension> _dimensions = new List<MetricDimension>();
        private string _metricName;
        private string _awsNamespace;
        private MetricStatistic _statistic;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions of the metric. 
        /// </para>
        ///  
        /// <para>
        /// Conditional: If you published your metric with dimensions, you must specify the same
        /// dimensions in your scaling policy.
        /// </para>
        /// </summary>
        public List<MetricDimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric. To get the exact metric name, namespace, and dimensions, inspect
        /// the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Metric.html">Metric</a>
        /// object that is returned by a call to <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_ListMetrics.html">ListMetrics</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricStatistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the metric. For a complete list of the units that CloudWatch supports,
        /// see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_MetricDatum.html">MetricDatum</a>
        /// data type in the <i>Amazon CloudWatch API Reference</i>.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}