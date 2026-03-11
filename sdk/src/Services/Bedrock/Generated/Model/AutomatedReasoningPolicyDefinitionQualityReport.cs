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
    /// Provides a comprehensive analysis of the quality and completeness of an Automated
    /// Reasoning policy definition, highlighting potential issues and optimization opportunities.
    /// </summary>
    public partial class AutomatedReasoningPolicyDefinitionQualityReport
    {
        private List<string> _conflictingRules = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AutomatedReasoningPolicyDisjointRuleSet> _disjointRuleSets = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyDisjointRuleSet>() : null;
        private int? _ruleCount;
        private int? _typeCount;
        private List<string> _unusedTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AutomatedReasoningPolicyDefinitionTypeValuePair> _unusedTypeValues = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyDefinitionTypeValuePair>() : null;
        private List<string> _unusedVariables = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _variableCount;

        /// <summary>
        /// Gets and sets the property ConflictingRules. 
        /// <para>
        /// A list of rules that may conflict with each other, potentially leading to inconsistent
        /// policy behavior.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public List<string> ConflictingRules
        {
            get { return this._conflictingRules; }
            set { this._conflictingRules = value; }
        }

        // Check to see if ConflictingRules property is set
        internal bool IsSetConflictingRules()
        {
            return this._conflictingRules != null && (this._conflictingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisjointRuleSets. 
        /// <para>
        /// Groups of rules that operate on completely separate sets of variables, indicating
        /// the policy may be addressing multiple unrelated concerns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningPolicyDisjointRuleSet> DisjointRuleSets
        {
            get { return this._disjointRuleSets; }
            set { this._disjointRuleSets = value; }
        }

        // Check to see if DisjointRuleSets property is set
        internal bool IsSetDisjointRuleSets()
        {
            return this._disjointRuleSets != null && (this._disjointRuleSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleCount. 
        /// <para>
        /// The total number of rules defined in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RuleCount
        {
            get { return this._ruleCount; }
            set { this._ruleCount = value; }
        }

        // Check to see if RuleCount property is set
        internal bool IsSetRuleCount()
        {
            return this._ruleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypeCount. 
        /// <para>
        /// The total number of custom types defined in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TypeCount
        {
            get { return this._typeCount; }
            set { this._typeCount = value; }
        }

        // Check to see if TypeCount property is set
        internal bool IsSetTypeCount()
        {
            return this._typeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnusedTypes. 
        /// <para>
        /// A list of custom types that are defined but not referenced by any variables or rules,
        /// suggesting they may be unnecessary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public List<string> UnusedTypes
        {
            get { return this._unusedTypes; }
            set { this._unusedTypes = value; }
        }

        // Check to see if UnusedTypes property is set
        internal bool IsSetUnusedTypes()
        {
            return this._unusedTypes != null && (this._unusedTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnusedTypeValues. 
        /// <para>
        /// A list of type values that are defined but never used in any rules, indicating potential
        /// cleanup opportunities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=22500)]
        public List<AutomatedReasoningPolicyDefinitionTypeValuePair> UnusedTypeValues
        {
            get { return this._unusedTypeValues; }
            set { this._unusedTypeValues = value; }
        }

        // Check to see if UnusedTypeValues property is set
        internal bool IsSetUnusedTypeValues()
        {
            return this._unusedTypeValues != null && (this._unusedTypeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnusedVariables. 
        /// <para>
        /// A list of variables that are defined but not referenced by any rules, suggesting they
        /// may be unnecessary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=600)]
        public List<string> UnusedVariables
        {
            get { return this._unusedVariables; }
            set { this._unusedVariables = value; }
        }

        // Check to see if UnusedVariables property is set
        internal bool IsSetUnusedVariables()
        {
            return this._unusedVariables != null && (this._unusedVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VariableCount. 
        /// <para>
        /// The total number of variables defined in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? VariableCount
        {
            get { return this._variableCount; }
            set { this._variableCount = value; }
        }

        // Check to see if VariableCount property is set
        internal bool IsSetVariableCount()
        {
            return this._variableCount.HasValue; 
        }

    }
}