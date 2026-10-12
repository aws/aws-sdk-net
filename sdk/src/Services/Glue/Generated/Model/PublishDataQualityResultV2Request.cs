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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Container for the parameters to the PublishDataQualityResultV2 operation.
    /// <note> 
    /// <para>
    /// This operation is intended for internal use. Do not call it directly.
    /// </para>
    ///  </note> 
    /// <para>
    /// AWS Glue Data Quality uses this operation to publish a data quality result.
    /// </para>
    /// </summary>
    public partial class PublishDataQualityResultV2Request : AmazonGlueRequest
    {
        private DataQualityAggregatedMetrics _aggregatedMetrics;
        private List<DataQualityAnalyzerResult> _analyzerResults = AWSConfigs.InitializeCollections ? new List<DataQualityAnalyzerResult>() : null;
        private string _clientToken;
        private string _dataQualitySecurityConfiguration;
        private Dictionary<string, string> _descriptors = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _evaluationContext;
        private DateTime? _executionCompletedOn;
        private DateTime? _executionStartedOn;
        private List<DataQualityObservation> _observations = AWSConfigs.InitializeCollections ? new List<DataQualityObservation>() : null;
        private List<DataQualityRuleResult> _ruleResults = AWSConfigs.InitializeCollections ? new List<DataQualityRuleResult>() : null;
        private string _rulesetName;
        private DataQualityConfigurationV2 _runConfiguration;
        private double? _score;
        private List<StatisticSummary> _statistics = AWSConfigs.InitializeCollections ? new List<StatisticSummary>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DataQualityTelemetry _telemetry;

        /// <summary>
        /// Gets and sets the property AggregatedMetrics. 
        /// <para>
        /// The aggregated metrics for the result.
        /// </para>
        /// </summary>
        public DataQualityAggregatedMetrics AggregatedMetrics
        {
            get { return this._aggregatedMetrics; }
            set { this._aggregatedMetrics = value; }
        }

        // Check to see if AggregatedMetrics property is set
        internal bool IsSetAggregatedMetrics()
        {
            return this._aggregatedMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property AnalyzerResults. 
        /// <para>
        /// The analyzer level results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public List<DataQualityAnalyzerResult> AnalyzerResults
        {
            get { return this._analyzerResults; }
            set { this._analyzerResults = value; }
        }

        // Check to see if AnalyzerResults property is set
        internal bool IsSetAnalyzerResults()
        {
            return this._analyzerResults != null && (this._analyzerResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataQualitySecurityConfiguration. 
        /// <para>
        /// The security configuration for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DataQualitySecurityConfiguration
        {
            get { return this._dataQualitySecurityConfiguration; }
            set { this._dataQualitySecurityConfiguration = value; }
        }

        // Check to see if DataQualitySecurityConfiguration property is set
        internal bool IsSetDataQualitySecurityConfiguration()
        {
            return this._dataQualitySecurityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The descriptors for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> Descriptors
        {
            get { return this._descriptors; }
            set { this._descriptors = value; }
        }

        // Check to see if Descriptors property is set
        internal bool IsSetDescriptors()
        {
            return this._descriptors != null && (this._descriptors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public Dictionary<string, string> Dimensions
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
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EvaluationContext
        {
            get { return this._evaluationContext; }
            set { this._evaluationContext = value; }
        }

        // Check to see if EvaluationContext property is set
        internal bool IsSetEvaluationContext()
        {
            return this._evaluationContext != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionCompletedOn. 
        /// <para>
        /// The time execution completed for the result.
        /// </para>
        /// </summary>
        public DateTime? ExecutionCompletedOn
        {
            get { return this._executionCompletedOn; }
            set { this._executionCompletedOn = value; }
        }

        // Check to see if ExecutionCompletedOn property is set
        internal bool IsSetExecutionCompletedOn()
        {
            return this._executionCompletedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartedOn. 
        /// <para>
        /// The time execution started for the result.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartedOn
        {
            get { return this._executionStartedOn; }
            set { this._executionStartedOn = value; }
        }

        // Check to see if ExecutionStartedOn property is set
        internal bool IsSetExecutionStartedOn()
        {
            return this._executionStartedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Observations. 
        /// <para>
        /// The observations for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<DataQualityObservation> Observations
        {
            get { return this._observations; }
            set { this._observations = value; }
        }

        // Check to see if Observations property is set
        internal bool IsSetObservations()
        {
            return this._observations != null && (this._observations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// The rule level results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2000)]
        public List<DataQualityRuleResult> RuleResults
        {
            get { return this._ruleResults; }
            set { this._ruleResults = value; }
        }

        // Check to see if RuleResults property is set
        internal bool IsSetRuleResults()
        {
            return this._ruleResults != null && (this._ruleResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RulesetName. 
        /// <para>
        /// The ruleset name for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RulesetName
        {
            get { return this._rulesetName; }
            set { this._rulesetName = value; }
        }

        // Check to see if RulesetName property is set
        internal bool IsSetRulesetName()
        {
            return this._rulesetName != null;
        }

        /// <summary>
        /// Gets and sets the property RunConfiguration. 
        /// <para>
        /// The run configuration for the result.
        /// </para>
        /// </summary>
        public DataQualityConfigurationV2 RunConfiguration
        {
            get { return this._runConfiguration; }
            set { this._runConfiguration = value; }
        }

        // Check to see if RunConfiguration property is set
        internal bool IsSetRunConfiguration()
        {
            return this._runConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The score for the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatisticSummary> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && (this._statistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Telemetry.
        /// </summary>
        public DataQualityTelemetry Telemetry
        {
            get { return this._telemetry; }
            set { this._telemetry = value; }
        }

        // Check to see if Telemetry property is set
        internal bool IsSetTelemetry()
        {
            return this._telemetry != null;
        }

    }
}