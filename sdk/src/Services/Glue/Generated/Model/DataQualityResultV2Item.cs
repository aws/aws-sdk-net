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
    /// Describes a data quality result returned by <c>BatchGetDataQualityResultV2</c>.
    /// </summary>
    public partial class DataQualityResultV2Item
    {
        private DataQualityAggregatedMetrics _aggregatedMetrics;
        private List<DataQualityAnalyzerResult> _analyzerResults = AWSConfigs.InitializeCollections ? new List<DataQualityAnalyzerResult>() : null;
        private DataSource _dataSource;
        private Dictionary<string, string> _descriptors = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _evaluationContext;
        private DateTime? _executionCompletedOn;
        private DateTime? _executionStartedOn;
        private List<DataQualityObservation> _observations = AWSConfigs.InitializeCollections ? new List<DataQualityObservation>() : null;
        private string _resultId;
        private DateTime? _resultPublishedOn;
        private List<DataQualityRuleResult> _ruleResults = AWSConfigs.InitializeCollections ? new List<DataQualityRuleResult>() : null;
        private string _rulesetName;
        private double? _score;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AggregatedMetrics. 
        /// <para>
        /// A summary of <c>DataQualityAggregatedMetrics</c> objects showing the total counts
        /// of processed rows and rules, including their pass/fail statistics based on row-level
        /// results.
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
        /// A list of <c>DataQualityAnalyzerResult</c> objects representing the results for each
        /// analyzer.
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
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The table associated with the data quality result, if any.
        /// </para>
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// A map of user-provided descriptors that add contextual metadata and configuration
        /// to the data quality result, such as database name, table name, team, or environment.
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
        /// A map of platform-specific identifiers, such as cluster, application, workgroup, or
        /// project IDs, that identify where the data quality evaluation ran.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// The evaluation context for the data quality result. This value identifies a specific
        /// data quality result, or a series of related results, within a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The date and time when this data quality run completed.
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
        /// The date and time when this data quality run started.
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
        /// A list of <c>DataQualityObservation</c> objects representing the anomaly detection
        /// observations generated after evaluating the rules and analyzers.
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
        /// Gets and sets the property ResultId. 
        /// <para>
        /// A unique result ID for the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ResultId
        {
            get { return this._resultId; }
            set { this._resultId = value; }
        }

        // Check to see if ResultId property is set
        internal bool IsSetResultId()
        {
            return this._resultId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultPublishedOn. 
        /// <para>
        /// The date and time when this data quality result was published.
        /// </para>
        /// </summary>
        public DateTime? ResultPublishedOn
        {
            get { return this._resultPublishedOn; }
            set { this._resultPublishedOn = value; }
        }

        // Check to see if ResultPublishedOn property is set
        internal bool IsSetResultPublishedOn()
        {
            return this._resultPublishedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// A list of <c>DataQualityRuleResult</c> objects representing the results for each rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
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
        /// The name of the ruleset associated with the data quality result.
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
        /// Gets and sets the property Score. 
        /// <para>
        /// An aggregate data quality score. Represents the ratio of rules that passed to the
        /// total number of rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags associated with the data quality result.
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

    }
}