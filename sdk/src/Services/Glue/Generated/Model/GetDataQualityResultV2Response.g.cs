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
    /// This is the response object from the GetDataQualityResultV2 operation.
    /// </summary>
    public partial class GetDataQualityResultV2Response : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AggregatedMetrics. 
        /// <para>
        /// A summary of <c>DataQualityAggregatedMetrics</c> objects showing the total counts
        /// of processed rows and rules, including their pass/fail statistics based on row-level
        /// results.
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
        /// A list of <c>DataQualityAnalyzerResult</c> objects representing the results for each
        /// analyzer.
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
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The table associated with the data quality result, if any.
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// A map of user-provided descriptors that add contextual metadata and configuration
        /// to the data quality result, such as database name, table name, team, or environment.
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
        /// A map of platform-specific identifiers, such as cluster, application, workgroup, or
        /// project IDs, that identify where the data quality evaluation ran.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context for the data quality result. This value identifies a specific
        /// data quality result, or a series of related results, within a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property ExecutionCompletedOn. 
        /// <para>
        /// The date and time when this data quality run completed.
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
        /// The date and time when this data quality run started.
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
        /// A list of <c>DataQualityObservation</c> objects representing the anomaly detection
        /// observations generated after evaluating the rules and analyzers.
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
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The Profile ID for the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// A unique result ID for the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResultId { get; set; }

        /// <summary>
        /// Checks to see if the ResultId property is set.
        /// </summary>
        internal bool IsSetResultId() => this.ResultId != null;

        /// <summary>
        /// Gets and sets the property ResultPublishedOn. 
        /// <para>
        /// The date and time when this data quality result was published.
        /// </para>
        /// </summary>
        public DateTime? ResultPublishedOn { get; set; }

        /// <summary>
        /// Checks to see if the ResultPublishedOn property is set.
        /// </summary>
        internal bool IsSetResultPublishedOn() => this.ResultPublishedOn.HasValue;

        /// <summary>
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// A list of <c>DataQualityRuleResult</c> objects representing the results for each rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<DataQualityRuleResult> RuleResults { get; set; } = AWSConfigs.InitializeCollections ? new List<DataQualityRuleResult>() : null;

        /// <summary>
        /// Checks to see if the RuleResults property is set.
        /// </summary>
        internal bool IsSetRuleResults() => this.RuleResults != null && (this.RuleResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RulesetName. 
        /// <para>
        /// The name of the ruleset associated with the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RulesetName { get; set; }

        /// <summary>
        /// Checks to see if the RulesetName property is set.
        /// </summary>
        internal bool IsSetRulesetName() => this.RulesetName != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// An aggregate data quality score. Represents the ratio of rules that passed to the
        /// total number of rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags associated with the data quality result.
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
    }
}
