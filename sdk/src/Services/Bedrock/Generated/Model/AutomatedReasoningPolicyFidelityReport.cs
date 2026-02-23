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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// A comprehensive analysis report that measures how accurately a generated policy represents
    /// the source documents. The report includes coverage and accuracy scores, detailed grounding
    /// information linking policy elements to source statements, and annotated document content.
    /// </summary>
    public partial class AutomatedReasoningPolicyFidelityReport
    {
        private double? _accuracyScore;
        private double? _coverageScore;
        private List<AutomatedReasoningPolicyReportSourceDocument> _documentSources = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyReportSourceDocument>() : null;
        private Dictionary<string, AutomatedReasoningPolicyRuleReport> _ruleReports = AWSConfigs.InitializeCollections ? new Dictionary<string, AutomatedReasoningPolicyRuleReport>() : null;
        private Dictionary<string, AutomatedReasoningPolicyVariableReport> _variableReports = AWSConfigs.InitializeCollections ? new Dictionary<string, AutomatedReasoningPolicyVariableReport>() : null;

        /// <summary>
        /// Gets and sets the property AccuracyScore. 
        /// <para>
        /// A score from 0.0 to 1.0 indicating how accurate the policy rules are relative to the
        /// source documents. A higher score means the policy rules more faithfully represent
        /// the source material.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double AccuracyScore
        {
            get { return this._accuracyScore.GetValueOrDefault(); }
            set { this._accuracyScore = value; }
        }

        // Check to see if AccuracyScore property is set
        internal bool IsSetAccuracyScore()
        {
            return this._accuracyScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CoverageScore. 
        /// <para>
        /// A score from 0.0 to 1.0 indicating how well the policy covers the statements in the
        /// source documents. A higher score means more of the source content is represented in
        /// the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double CoverageScore
        {
            get { return this._coverageScore.GetValueOrDefault(); }
            set { this._coverageScore = value; }
        }

        // Check to see if CoverageScore property is set
        internal bool IsSetCoverageScore()
        {
            return this._coverageScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentSources. 
        /// <para>
        /// A list of source documents with their content broken down into atomic statements and
        /// annotated with line numbers for precise referencing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningPolicyReportSourceDocument> DocumentSources
        {
            get { return this._documentSources; }
            set { this._documentSources = value; }
        }

        // Check to see if DocumentSources property is set
        internal bool IsSetDocumentSources()
        {
            return this._documentSources != null && (this._documentSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleReports. 
        /// <para>
        /// A mapping from rule identifiers to detailed fidelity reports for each rule, showing
        /// which source statements ground each rule and how accurate it is.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, AutomatedReasoningPolicyRuleReport> RuleReports
        {
            get { return this._ruleReports; }
            set { this._ruleReports = value; }
        }

        // Check to see if RuleReports property is set
        internal bool IsSetRuleReports()
        {
            return this._ruleReports != null && (this._ruleReports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VariableReports. 
        /// <para>
        /// A mapping from variable names to detailed fidelity reports for each variable, showing
        /// which source statements ground each variable and how accurate it is.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, AutomatedReasoningPolicyVariableReport> VariableReports
        {
            get { return this._variableReports; }
            set { this._variableReports = value; }
        }

        // Check to see if VariableReports property is set
        internal bool IsSetVariableReports()
        {
            return this._variableReports != null && (this._variableReports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}