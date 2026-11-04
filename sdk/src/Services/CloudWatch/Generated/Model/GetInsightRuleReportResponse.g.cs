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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AggregateValue. 
        /// <para>
        /// The sum of the values from all individual contributors that match the rule.
        /// </para>
        /// </summary>
        public double? AggregateValue { get; set; }

        /// <summary>
        /// Checks to see if the AggregateValue property is set.
        /// </summary>
        internal bool IsSetAggregateValue() => this.AggregateValue.HasValue;

        /// <summary>
        /// Gets and sets the property AggregationStatistic. 
        /// <para>
        /// Specifies whether this rule aggregates contributor data by COUNT or SUM.
        /// </para>
        /// </summary>
        public string AggregationStatistic { get; set; }

        /// <summary>
        /// Checks to see if the AggregationStatistic property is set.
        /// </summary>
        internal bool IsSetAggregationStatistic() => this.AggregationStatistic != null;

        /// <summary>
        /// Gets and sets the property ApproximateUniqueCount. 
        /// <para>
        /// An approximate count of the unique contributors found by this rule in this time period.
        /// </para>
        /// </summary>
        public long? ApproximateUniqueCount { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateUniqueCount property is set.
        /// </summary>
        internal bool IsSetApproximateUniqueCount() => this.ApproximateUniqueCount.HasValue;

        /// <summary>
        /// Gets and sets the property Contributors. 
        /// <para>
        /// An array of the unique contributors found by this rule in this time period. If the
        /// rule contains multiple keys, each combination of values for the keys counts as a unique
        /// contributor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightRuleContributor> Contributors { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightRuleContributor>() : null;

        /// <summary>
        /// Checks to see if the Contributors property is set.
        /// </summary>
        internal bool IsSetContributors() => this.Contributors != null && (this.Contributors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyLabels. 
        /// <para>
        /// An array of the strings used as the keys for this rule. The keys are the dimensions
        /// used to classify contributors. If the rule contains more than one key, then each unique
        /// combination of values for the keys is counted as a unique contributor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyLabels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyLabels property is set.
        /// </summary>
        internal bool IsSetKeyLabels() => this.KeyLabels != null && (this.KeyLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricDatapoints. 
        /// <para>
        /// A time series of metric data points that matches the time period in the rule request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightRuleMetricDatapoint> MetricDatapoints { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightRuleMetricDatapoint>() : null;

        /// <summary>
        /// Checks to see if the MetricDatapoints property is set.
        /// </summary>
        internal bool IsSetMetricDatapoints() => this.MetricDatapoints != null && (this.MetricDatapoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
