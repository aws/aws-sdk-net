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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// A comprehensive analysis report that measures how accurately a generated policy represents
    /// the source documents. The report includes coverage and accuracy scores, detailed grounding
    /// information linking policy elements to source statements, and annotated document content.
    /// </summary>
    public partial class AutomatedReasoningPolicyFidelityReport
    {
        /// <summary>
        /// Gets and sets the property AccuracyScore. 
        /// <para>
        /// A score from 0.0 to 1.0 indicating how accurate the policy rules are relative to the
        /// source documents. A higher score means the policy rules more faithfully represent
        /// the source material.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? AccuracyScore { get; set; }

        /// <summary>
        /// Checks to see if the AccuracyScore property is set.
        /// </summary>
        internal bool IsSetAccuracyScore() => this.AccuracyScore.HasValue;

        /// <summary>
        /// Gets and sets the property CoverageScore. 
        /// <para>
        /// A score from 0.0 to 1.0 indicating how well the policy covers the statements in the
        /// source documents. A higher score means more of the source content is represented in
        /// the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? CoverageScore { get; set; }

        /// <summary>
        /// Checks to see if the CoverageScore property is set.
        /// </summary>
        internal bool IsSetCoverageScore() => this.CoverageScore.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentSources. 
        /// <para>
        /// A list of source documents with their content broken down into atomic statements and
        /// annotated with line numbers for precise referencing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutomatedReasoningPolicyReportSourceDocument> DocumentSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyReportSourceDocument>() : null;

        /// <summary>
        /// Checks to see if the DocumentSources property is set.
        /// </summary>
        internal bool IsSetDocumentSources() => this.DocumentSources != null && (this.DocumentSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleReports. 
        /// <para>
        /// A mapping from rule identifiers to detailed fidelity reports for each rule, showing
        /// which source statements ground each rule and how accurate it is.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, AutomatedReasoningPolicyRuleReport> RuleReports { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AutomatedReasoningPolicyRuleReport>() : null;

        /// <summary>
        /// Checks to see if the RuleReports property is set.
        /// </summary>
        internal bool IsSetRuleReports() => this.RuleReports != null && (this.RuleReports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VariableReports. 
        /// <para>
        /// A mapping from variable names to detailed fidelity reports for each variable, showing
        /// which source statements ground each variable and how accurate it is.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, AutomatedReasoningPolicyVariableReport> VariableReports { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AutomatedReasoningPolicyVariableReport>() : null;

        /// <summary>
        /// Checks to see if the VariableReports property is set.
        /// </summary>
        internal bool IsSetVariableReports() => this.VariableReports != null && (this.VariableReports.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
