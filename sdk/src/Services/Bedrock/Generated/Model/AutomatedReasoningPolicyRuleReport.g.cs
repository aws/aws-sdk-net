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
    /// Provides detailed fidelity analysis for a specific policy rule, including which source
    /// document statements support it and how accurate the rule is.
    /// </summary>
    public partial class AutomatedReasoningPolicyRuleReport
    {
        /// <summary>
        /// Gets and sets the property AccuracyJustification. 
        /// <para>
        /// A textual explanation of the accuracy score, describing why the rule received this
        /// particular accuracy rating.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string AccuracyJustification { get; set; }

        /// <summary>
        /// Checks to see if the AccuracyJustification property is set.
        /// </summary>
        internal bool IsSetAccuracyJustification() => this.AccuracyJustification != null;

        /// <summary>
        /// Gets and sets the property AccuracyScore. 
        /// <para>
        /// A score from 0.0 to 1.0 indicating how accurately this rule represents the source
        /// material.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? AccuracyScore { get; set; }

        /// <summary>
        /// Checks to see if the AccuracyScore property is set.
        /// </summary>
        internal bool IsSetAccuracyScore() => this.AccuracyScore.HasValue;

        /// <summary>
        /// Gets and sets the property GroundingJustifications. 
        /// <para>
        /// Explanations describing how the source statements support and justify this specific
        /// rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroundingJustifications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GroundingJustifications property is set.
        /// </summary>
        internal bool IsSetGroundingJustifications() => this.GroundingJustifications != null && (this.GroundingJustifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroundingStatements. 
        /// <para>
        /// References to statements from the source documents that provide the basis or justification
        /// for this rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningPolicyStatementReference> GroundingStatements { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyStatementReference>() : null;

        /// <summary>
        /// Checks to see if the GroundingStatements property is set.
        /// </summary>
        internal bool IsSetGroundingStatements() => this.GroundingStatements != null && (this.GroundingStatements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The identifier of the policy rule being analyzed in this report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;
    }
}
