/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// For CLOUDWATCH_METRIC health checks, a complex type that contains information about
    /// the CloudWatch alarm that you're associating with the health check.
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
        private List<Dimension> _dimensions = new List<Dimension>();

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// The number of periods over which data is compared to the specified threshold.
        /// </para>
        /// </summary>
        public int EvaluationPeriods
        {
            get { return this._evaluationPeriods.GetValueOrDefault(); }
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
        /// The value that the metric is compared with to determine the state of the alarm. For
        /// example, if you want the health check to fail if the average TCP connection time is
        /// greater than 500 milliseconds for more than 60 seconds, the threshold is 500.
        /// </para>
        /// </summary>
        public double Threshold
        {
            get { return this._threshold.GetValueOrDefault(); }
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
        /// The arithmetic operation to use when comparing the specified Statistic and Threshold.
        /// </para>
        ///  
        /// <para>
        /// Valid Values are <code>GreaterThanOrEqualToThreshold</code>, <code>GreaterThanThreshold</code>,
        /// <code>LessThanThreshold</code> and <code>LessThanOrEqualToThreshold</code>
        /// </para>
        /// </summary>
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
        /// An integer that represents the period in seconds over which the statistic is applied.
        /// </para>
        /// </summary>
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
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
        /// The name of the CloudWatch metric that is associated with the CloudWatch alarm.
        /// </para>
        /// </summary>
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
        /// The namespace of the CloudWatch metric that is associated with the CloudWatch alarm.
        /// </para>
        /// </summary>
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
        /// The statistic to apply to the CloudWatch metric that is associated with the CloudWatch
        /// alarm.
        /// </para>
        ///  
        /// <para>
        /// Valid Values are <code>SampleCount</code>, <code>Average</code>, <code>Sum</code>,
        /// <code>Minimum</code> and <code>Maximum</code>
        /// </para>
        /// </summary>
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
        /// A list of <code>Dimension</code> elements for the CloudWatch metric that is associated
        /// with the CloudWatch alarm. For information about the metrics and dimensions that CloudWatch
        /// supports, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Namespaces, Dimensions, and Metrics Reference</a>.
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

    }
}