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
    /// Provides a comprehensive analysis of the quality and completeness of an Automated
    /// Reasoning policy definition, highlighting potential issues and optimization opportunities.
    /// </summary>
    public partial class AutomatedReasoningPolicyDefinitionQualityReport
    {
        /// <summary>
        /// Gets and sets the property ConflictingRules. 
        /// <para>
        /// A list of rules that may conflict with each other, potentially leading to inconsistent
        /// policy behavior.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public List<string> ConflictingRules { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConflictingRules property is set.
        /// </summary>
        internal bool IsSetConflictingRules() => this.ConflictingRules != null && (this.ConflictingRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisjointRuleSets. 
        /// <para>
        /// Groups of rules that operate on completely separate sets of variables, indicating
        /// the policy may be addressing multiple unrelated concerns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutomatedReasoningPolicyDisjointRuleSet> DisjointRuleSets { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyDisjointRuleSet>() : null;

        /// <summary>
        /// Checks to see if the DisjointRuleSets property is set.
        /// </summary>
        internal bool IsSetDisjointRuleSets() => this.DisjointRuleSets != null && (this.DisjointRuleSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleCount. 
        /// <para>
        /// The total number of rules defined in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? RuleCount { get; set; }

        /// <summary>
        /// Checks to see if the RuleCount property is set.
        /// </summary>
        internal bool IsSetRuleCount() => this.RuleCount.HasValue;

        /// <summary>
        /// Gets and sets the property TypeCount. 
        /// <para>
        /// The total number of custom types defined in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TypeCount { get; set; }

        /// <summary>
        /// Checks to see if the TypeCount property is set.
        /// </summary>
        internal bool IsSetTypeCount() => this.TypeCount.HasValue;

        /// <summary>
        /// Gets and sets the property UnusedTypeValues. 
        /// <para>
        /// A list of type values that are defined but never used in any rules, indicating potential
        /// cleanup opportunities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 22500)]
        public List<AutomatedReasoningPolicyDefinitionTypeValuePair> UnusedTypeValues { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyDefinitionTypeValuePair>() : null;

        /// <summary>
        /// Checks to see if the UnusedTypeValues property is set.
        /// </summary>
        internal bool IsSetUnusedTypeValues() => this.UnusedTypeValues != null && (this.UnusedTypeValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnusedTypes. 
        /// <para>
        /// A list of custom types that are defined but not referenced by any variables or rules,
        /// suggesting they may be unnecessary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 150)]
        public List<string> UnusedTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UnusedTypes property is set.
        /// </summary>
        internal bool IsSetUnusedTypes() => this.UnusedTypes != null && (this.UnusedTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnusedVariables. 
        /// <para>
        /// A list of variables that are defined but not referenced by any rules, suggesting they
        /// may be unnecessary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 600)]
        public List<string> UnusedVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UnusedVariables property is set.
        /// </summary>
        internal bool IsSetUnusedVariables() => this.UnusedVariables != null && (this.UnusedVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VariableCount. 
        /// <para>
        /// The total number of variables defined in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? VariableCount { get; set; }

        /// <summary>
        /// Checks to see if the VariableCount property is set.
        /// </summary>
        internal bool IsSetVariableCount() => this.VariableCount.HasValue;
    }
}
