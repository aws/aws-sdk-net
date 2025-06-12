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
    /// This is the response object from the GetInsightRuleReport operation.
    /// </summary>
    public partial class GetInsightRuleReportResponse : AmazonWebServiceResponse
    {
        private double? _aggregateValue;
        private string _aggregationStatistic;
        private long? _approximateUniqueCount;
        private List<InsightRuleContributor> _contributors = AWSConfigs.InitializeCollections ? new List<InsightRuleContributor>() : null;
        private List<string> _keyLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<InsightRuleMetricDatapoint> _metricDatapoints = AWSConfigs.InitializeCollections ? new List<InsightRuleMetricDatapoint>() : null;

        /// <summary>
        /// Gets and sets the property AggregateValue. 
        /// <para>
        /// The sum of the values from all individual contributors that match the rule.
        /// </para>
        /// </summary>
        public double? AggregateValue
        {
            get { return this._aggregateValue; }
            set { this._aggregateValue = value; }
        }

        // Check to see if AggregateValue property is set
        internal bool IsSetAggregateValue()
        {
            return this._aggregateValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AggregationStatistic. 
        /// <para>
        /// Specifies whether this rule aggregates contributor data by COUNT or SUM.
        /// </para>
        /// </summary>
        public string AggregationStatistic
        {
            get { return this._aggregationStatistic; }
            set { this._aggregationStatistic = value; }
        }

        // Check to see if AggregationStatistic property is set
        internal bool IsSetAggregationStatistic()
        {
            return this._aggregationStatistic != null;
        }

        /// <summary>
        /// Gets and sets the property ApproximateUniqueCount. 
        /// <para>
        /// An approximate count of the unique contributors found by this rule in this time period.
        /// </para>
        /// </summary>
        public long? ApproximateUniqueCount
        {
            get { return this._approximateUniqueCount; }
            set { this._approximateUniqueCount = value; }
        }

        // Check to see if ApproximateUniqueCount property is set
        internal bool IsSetApproximateUniqueCount()
        {
            return this._approximateUniqueCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Contributors. 
        /// <para>
        /// An array of the unique contributors found by this rule in this time period. If the
        /// rule contains multiple keys, each combination of values for the keys counts as a unique
        /// contributor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightRuleContributor> Contributors
        {
            get { return this._contributors; }
            set { this._contributors = value; }
        }

        // Check to see if Contributors property is set
        internal bool IsSetContributors()
        {
            return this._contributors != null && (this._contributors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyLabels. 
        /// <para>
        /// An array of the strings used as the keys for this rule. The keys are the dimensions
        /// used to classify contributors. If the rule contains more than one key, then each unique
        /// combination of values for the keys is counted as a unique contributor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyLabels
        {
            get { return this._keyLabels; }
            set { this._keyLabels = value; }
        }

        // Check to see if KeyLabels property is set
        internal bool IsSetKeyLabels()
        {
            return this._keyLabels != null && (this._keyLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricDatapoints. 
        /// <para>
        /// A time series of metric data points that matches the time period in the rule request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightRuleMetricDatapoint> MetricDatapoints
        {
            get { return this._metricDatapoints; }
            set { this._metricDatapoints = value; }
        }

        // Check to see if MetricDatapoints property is set
        internal bool IsSetMetricDatapoints()
        {
            return this._metricDatapoints != null && (this._metricDatapoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}