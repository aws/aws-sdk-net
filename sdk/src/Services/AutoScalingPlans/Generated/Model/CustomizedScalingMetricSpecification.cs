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
    /// Represents a CloudWatch metric of your choosing that can be used for dynamic scaling
    /// as part of a target tracking scaling policy. 
    /// 
    ///  
    /// <para>
    /// To create your customized scaling metric specification:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Add values for each required parameter from CloudWatch. You can use an existing metric,
    /// or a new metric that you create. To use your own metric, you must first publish the
    /// metric to CloudWatch. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publish
    /// Custom Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Choose a metric that changes proportionally with capacity. The value of the metric
    /// should increase or decrease in inverse proportion to the number of capacity units.
    /// That is, the value of the metric should decrease when capacity increases. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about terminology, available metrics, or how to publish new metrics,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html">Amazon
    /// CloudWatch Concepts</a> in the <i>Amazon CloudWatch User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CustomizedScalingMetricSpecification
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
        /// dimensions in your customized scaling metric specification.
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