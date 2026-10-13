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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the PublishDataQualityResultV2 operation. <note> <para>
    /// This operation is intended for internal use. Do not call it directly. </para> </note>
    /// <para> AWS Glue Data Quality uses this operation to publish a data quality result.
    /// </para>
    /// </summary>
    public partial class PublishDataQualityResultV2Request : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AggregatedMetrics. 
        /// <para>
        /// The aggregated metrics for the result.
        /// </para>
        /// </summary>
        public DataQualityAggregatedMetrics AggregatedMetrics { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedMetrics property is set.
        /// </summary>
        internal bool IsSetAggregatedMetrics() => this.AggregatedMetrics != null;

        /// <summary>
        /// Gets and sets the property AnalyzerResults. 
        /// <para>
        /// The analyzer level results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<DataQualityAnalyzerResult> AnalyzerResults { get; set; } = AWSConfigs.InitializeCollections ? new List<DataQualityAnalyzerResult>() : null;

        /// <summary>
        /// Checks to see if the AnalyzerResults property is set.
        /// </summary>
        internal bool IsSetAnalyzerResults() => this.AnalyzerResults != null && (this.AnalyzerResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataQualitySecurityConfiguration. 
        /// <para>
        /// The security configuration for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DataQualitySecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataQualitySecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetDataQualitySecurityConfiguration() => this.DataQualitySecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The descriptors for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> Descriptors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null && (this.Descriptors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property ExecutionCompletedOn. 
        /// <para>
        /// The time execution completed for the result.
        /// </para>
        /// </summary>
        public DateTime? ExecutionCompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionCompletedOn property is set.
        /// </summary>
        internal bool IsSetExecutionCompletedOn() => this.ExecutionCompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionStartedOn. 
        /// <para>
        /// The time execution started for the result.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartedOn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartedOn property is set.
        /// </summary>
        internal bool IsSetExecutionStartedOn() => this.ExecutionStartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Observations. 
        /// <para>
        /// The observations for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<DataQualityObservation> Observations { get; set; } = AWSConfigs.InitializeCollections ? new List<DataQualityObservation>() : null;

        /// <summary>
        /// Checks to see if the Observations property is set.
        /// </summary>
        internal bool IsSetObservations() => this.Observations != null && (this.Observations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// The rule level results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2000)]
        public List<DataQualityRuleResult> RuleResults { get; set; } = AWSConfigs.InitializeCollections ? new List<DataQualityRuleResult>() : null;

        /// <summary>
        /// Checks to see if the RuleResults property is set.
        /// </summary>
        internal bool IsSetRuleResults() => this.RuleResults != null && (this.RuleResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RulesetName. 
        /// <para>
        /// The ruleset name for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RulesetName { get; set; }

        /// <summary>
        /// Checks to see if the RulesetName property is set.
        /// </summary>
        internal bool IsSetRulesetName() => this.RulesetName != null;

        /// <summary>
        /// Gets and sets the property RunConfiguration. 
        /// <para>
        /// The run configuration for the result.
        /// </para>
        /// </summary>
        public DataQualityConfigurationV2 RunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RunConfiguration property is set.
        /// </summary>
        internal bool IsSetRunConfiguration() => this.RunConfiguration != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The score for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatisticSummary> Statistics { get; set; } = AWSConfigs.InitializeCollections ? new List<StatisticSummary>() : null;

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null && (this.Statistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Telemetry.
        /// </summary>
        public DataQualityTelemetry Telemetry { get; set; }

        /// <summary>
        /// Checks to see if the Telemetry property is set.
        /// </summary>
        internal bool IsSetTelemetry() => this.Telemetry != null;
    }
}
