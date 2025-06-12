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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
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
namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Represents a CloudWatch metric of your choosing that can be used for predictive scaling.
    /// 
    /// 
    ///  
    /// <para>
    /// For predictive scaling to work with a customized load metric specification, AWS Auto
    /// Scaling needs access to the <c>Sum</c> and <c>Average</c> statistics that CloudWatch
    /// computes from metric data.
    /// </para>
    ///  
    /// <para>
    /// When you choose a load metric, make sure that the required <c>Sum</c> and <c>Average</c>
    /// statistics for your metric are available in CloudWatch and that they provide relevant
    /// data for predictive scaling. The <c>Sum</c> statistic must represent the total load
    /// on the resource, and the <c>Average</c> statistic must represent the average load
    /// per capacity unit of the resource. For example, there is a metric that counts the
    /// number of requests processed by your Auto Scaling group. If the <c>Sum</c> statistic
    /// represents the total request count processed by the group, then the <c>Average</c>
    /// statistic for the specified metric must represent the average request count processed
    /// by each instance of the group. 
    /// </para>
    ///  
    /// <para>
    /// If you publish your own metrics, you can aggregate the data points at a given interval
    /// and then publish the aggregated data points to CloudWatch. Before AWS Auto Scaling
    /// generates the forecast, it sums up all the metric data points that occurred within
    /// each hour to match the granularity period that is used in the forecast (60 minutes).
    /// </para>
    ///  
    /// <para>
    /// For information about terminology, available metrics, or how to publish new metrics,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html">Amazon
    /// CloudWatch Concepts</a> in the <i>Amazon CloudWatch User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// After creating your scaling plan, you can use the AWS Auto Scaling console to visualize
    /// forecasts for the specified metric. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/plans/userguide/gs-create-scaling-plan.html#gs-view-resource">View
    /// Scaling Information for a Resource</a> in the <i>AWS Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CustomizedLoadMetricSpecification
    {
        private List<MetricDimension> _dimensions = AWSConfigs.InitializeCollections ? new List<MetricDimension>() : null;
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
        /// dimensions in your customized load metric specification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
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
        /// The statistic of the metric. The only valid value is <c>Sum</c>.
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
        /// The unit of the metric.
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