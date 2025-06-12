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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the CloudWatch alarm that Amazon Route
    /// 53 is monitoring for this health check.
    /// </summary>
    public partial class CloudWatchAlarmConfiguration
    {
        private int? _evaluationPeriods;
        private double? _threshold;
        private ComparisonOperator _comparisonOperator;
        private int? _period;
        private string _metricName;
        private string _awsNamespace;
        private Statistic _statistic;
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// For the metric that the CloudWatch alarm is associated with, the number of periods
        /// that the metric is compared to the threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? EvaluationPeriods
        {
            get { return this._evaluationPeriods; }
            set { this._evaluationPeriods = value; }
        }

        // Check to see if EvaluationPeriods property is set
        internal bool IsSetEvaluationPeriods()
        {
            return this._evaluationPeriods.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// For the metric that the CloudWatch alarm is associated with, the value the metric
        /// is compared with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// For the metric that the CloudWatch alarm is associated with, the arithmetic operation
        /// that is used for the comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// For the metric that the CloudWatch alarm is associated with, the duration of one evaluation
        /// period in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the CloudWatch metric that the alarm is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The namespace of the metric that the alarm is associated with. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Namespaces, Dimensions, and Metrics Reference</a> in the <i>Amazon CloudWatch
        /// User Guide</i>.
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// For the metric that the CloudWatch alarm is associated with, the statistic that is
        /// applied to the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Statistic Statistic
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
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// For the metric that the CloudWatch alarm is associated with, a complex type that contains
        /// information about the dimensions for the metric. For information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Namespaces, Dimensions, and Metrics Reference</a> in the <i>Amazon CloudWatch
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}