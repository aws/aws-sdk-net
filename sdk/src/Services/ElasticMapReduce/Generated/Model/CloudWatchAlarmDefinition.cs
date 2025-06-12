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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The definition of a CloudWatch metric alarm, which determines when an automatic scaling
    /// activity is triggered. When the defined alarm conditions are satisfied, scaling activity
    /// begins.
    /// </summary>
    public partial class CloudWatchAlarmDefinition
    {
        private ComparisonOperator _comparisonOperator;
        private List<MetricDimension> _dimensions = AWSConfigs.InitializeCollections ? new List<MetricDimension>() : null;
        private int? _evaluationPeriods;
        private string _metricName;
        private string _awsNamespace;
        private int? _period;
        private Statistic _statistic;
        private double? _threshold;
        private Unit _unit;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// Determines how the metric specified by <c>MetricName</c> is compared to the value
        /// specified by <c>Threshold</c>.
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
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A CloudWatch metric dimension.
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
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// The number of periods, in five-minute increments, during which the alarm condition
        /// must exist before the alarm triggers automatic scaling activity. The default value
        /// is <c>1</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the CloudWatch metric that is watched to determine an alarm condition.
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
        /// The namespace for the CloudWatch metric. The default is <c>AWS/ElasticMapReduce</c>.
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
        /// Gets and sets the property Period. 
        /// <para>
        /// The period, in seconds, over which the statistic is applied. CloudWatch metrics for
        /// Amazon EMR are emitted every five minutes (300 seconds), so if you specify a CloudWatch
        /// metric, specify <c>300</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic to apply to the metric associated with the alarm. The default is <c>AVERAGE</c>.
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
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value against which the specified statistic is compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measure associated with the CloudWatch metric being watched. The value
        /// specified for <c>Unit</c> must correspond to the units specified in the CloudWatch
        /// metric.
        /// </para>
        /// </summary>
        public Unit Unit
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