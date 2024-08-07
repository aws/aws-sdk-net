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
    /// This is the response object from the GetDataQualityResult operation.
    /// </summary>
    public partial class GetDataQualityResultResponse : AmazonWebServiceResponse
    {
        private List<DataQualityAnalyzerResult> _analyzerResults = AWSConfigs.InitializeCollections ? new List<DataQualityAnalyzerResult>() : null;
        private DateTime? _completedOn;
        private DataSource _dataSource;
        private string _evaluationContext;
        private string _jobName;
        private string _jobRunId;
        private List<DataQualityObservation> _observations = AWSConfigs.InitializeCollections ? new List<DataQualityObservation>() : null;
        private string _profileId;
        private string _resultId;
        private List<DataQualityRuleResult> _ruleResults = AWSConfigs.InitializeCollections ? new List<DataQualityRuleResult>() : null;
        private string _rulesetEvaluationRunId;
        private string _rulesetName;
        private double? _score;
        private DateTime? _startedOn;

        /// <summary>
        /// Gets and sets the property AnalyzerResults. 
        /// <para>
        /// A list of <c>DataQualityAnalyzerResult</c> objects representing the results for each
        /// analyzer. 
        /// </para>
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
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when the run for this data quality result was completed.
        /// </para>
        /// </summary>
        public DateTime CompletedOn
        {
            get { return this._completedOn.GetValueOrDefault(); }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
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
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// In the context of a job in Glue Studio, each node in the canvas is typically assigned
        /// some sort of name and data quality nodes will have names. In the case of multiple
        /// nodes, the <c>evaluationContext</c> can differentiate the nodes.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name associated with the data quality result, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The job run ID associated with the data quality result, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string JobRunId
        {
            get { return this._jobRunId; }
            set { this._jobRunId = value; }
        }

        // Check to see if JobRunId property is set
        internal bool IsSetJobRunId()
        {
            return this._jobRunId != null;
        }

        /// <summary>
        /// Gets and sets the property Observations. 
        /// <para>
        /// A list of <c>DataQualityObservation</c> objects representing the observations generated
        /// after evaluating the rules and analyzers. 
        /// </para>
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
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The Profile ID for the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// A unique result ID for the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property RuleResults. 
        /// <para>
        /// A list of <c>DataQualityRuleResult</c> objects representing the results for each rule.
        /// 
        /// </para>
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
        /// Gets and sets the property RulesetEvaluationRunId. 
        /// <para>
        /// The unique run ID associated with the ruleset evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RulesetEvaluationRunId
        {
            get { return this._rulesetEvaluationRunId; }
            set { this._rulesetEvaluationRunId = value; }
        }

        // Check to see if RulesetEvaluationRunId property is set
        internal bool IsSetRulesetEvaluationRunId()
        {
            return this._rulesetEvaluationRunId != null;
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
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when the run for this data quality result started.
        /// </para>
        /// </summary>
        public DateTime StartedOn
        {
            get { return this._startedOn.GetValueOrDefault(); }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

    }
}