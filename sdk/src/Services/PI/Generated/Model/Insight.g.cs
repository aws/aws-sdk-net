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

namespace Amazon.PI.Model
{
    /// <summary>
    /// Retrieves the list of performance issues which are identified.
    /// </summary>
    public partial class Insight
    {
        /// <summary>
        /// Gets and sets the property BaselineData. 
        /// <para>
        ///  Metric names and values from the timeframe used as baseline to generate the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Data> BaselineData { get; set; } = AWSConfigs.InitializeCollections ? new List<Data>() : null;

        /// <summary>
        /// Checks to see if the BaselineData property is set.
        /// </summary>
        internal bool IsSetBaselineData() => this.BaselineData != null && (this.BaselineData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Indicates if the insight is causal or correlated insight.
        /// </para>
        /// </summary>
        public ContextType Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the insight. For example: <c>A high severity Insight found between
        /// 02:00 to 02:30, where there was an unusually high DB load 600x above baseline. Likely
        /// performance impact</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 8000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the insight. For example, <c>2018-10-30T00:00:00Z</c>.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InsightData. 
        /// <para>
        /// List of data objects containing metrics and references from the time range while generating
        /// the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Data> InsightData { get; set; } = AWSConfigs.InitializeCollections ? new List<Data>() : null;

        /// <summary>
        /// Checks to see if the InsightData property is set.
        /// </summary>
        internal bool IsSetInsightData() => this.InsightData != null && (this.InsightData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The unique identifier for the insight. For example, <c>insight-12345678901234567</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property InsightType. 
        /// <para>
        /// The type of insight. For example, <c>HighDBLoad</c>, <c>HighCPU</c>, or <c>DominatingSQLs</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InsightType { get; set; }

        /// <summary>
        /// Checks to see if the InsightType property is set.
        /// </summary>
        internal bool IsSetInsightType() => this.InsightType != null;

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// List of recommendations for the insight. For example, <c>Investigate the following
        /// SQLs that contributed to 100% of the total DBLoad during that time period: sql-id</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Recommendation> Recommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;

        /// <summary>
        /// Checks to see if the Recommendations property is set.
        /// </summary>
        internal bool IsSetRecommendations() => this.Recommendations != null && (this.Recommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the insight. The values are: <c>Low</c>, <c>Medium</c>, or <c>High</c>.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the insight. For example, <c>2018-10-30T00:00:00Z</c>.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SupportingInsights. 
        /// <para>
        /// List of supporting insights that provide additional factors for the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Insight> SupportingInsights { get; set; } = AWSConfigs.InitializeCollections ? new List<Insight>() : null;

        /// <summary>
        /// Checks to see if the SupportingInsights property is set.
        /// </summary>
        internal bool IsSetSupportingInsights() => this.SupportingInsights != null && (this.SupportingInsights.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
