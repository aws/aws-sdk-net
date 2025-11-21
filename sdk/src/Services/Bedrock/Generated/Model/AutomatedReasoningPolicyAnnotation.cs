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
    /// Contains the various operations that can be performed on an Automated Reasoning policy,
    /// including adding, updating, and deleting rules, variables, and types.
    /// </summary>
    public partial class AutomatedReasoningPolicyAnnotation
    {
        private AutomatedReasoningPolicyAddRuleAnnotation _addRule;
        private AutomatedReasoningPolicyAddRuleFromNaturalLanguageAnnotation _addRuleFromNaturalLanguage;
        private AutomatedReasoningPolicyAddTypeAnnotation _addType;
        private AutomatedReasoningPolicyAddVariableAnnotation _addVariable;
        private AutomatedReasoningPolicyDeleteRuleAnnotation _deleteRule;
        private AutomatedReasoningPolicyDeleteTypeAnnotation _deleteType;
        private AutomatedReasoningPolicyDeleteVariableAnnotation _deleteVariable;
        private AutomatedReasoningPolicyIngestContentAnnotation _ingestContent;
        private AutomatedReasoningPolicyUpdateFromRuleFeedbackAnnotation _updateFromRulesFeedback;
        private AutomatedReasoningPolicyUpdateFromScenarioFeedbackAnnotation _updateFromScenarioFeedback;
        private AutomatedReasoningPolicyUpdateRuleAnnotation _updateRule;
        private AutomatedReasoningPolicyUpdateTypeAnnotation _updateType;
        private AutomatedReasoningPolicyUpdateVariableAnnotation _updateVariable;

        /// <summary>
        /// Gets and sets the property AddRule. 
        /// <para>
        /// An operation to add a new logical rule to the policy using formal mathematical expressions.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddRuleAnnotation AddRule
        {
            get { return this._addRule; }
            set { this._addRule = value; }
        }

        // Check to see if AddRule property is set
        internal bool IsSetAddRule()
        {
            return this._addRule != null;
        }

        /// <summary>
        /// Gets and sets the property AddRuleFromNaturalLanguage. 
        /// <para>
        /// An operation to add a new rule by converting natural language descriptions into formal
        /// logical expressions.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddRuleFromNaturalLanguageAnnotation AddRuleFromNaturalLanguage
        {
            get { return this._addRuleFromNaturalLanguage; }
            set { this._addRuleFromNaturalLanguage = value; }
        }

        // Check to see if AddRuleFromNaturalLanguage property is set
        internal bool IsSetAddRuleFromNaturalLanguage()
        {
            return this._addRuleFromNaturalLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property AddType. 
        /// <para>
        /// An operation to add a new custom type to the policy, defining a set of possible values
        /// for policy variables.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddTypeAnnotation AddType
        {
            get { return this._addType; }
            set { this._addType = value; }
        }

        // Check to see if AddType property is set
        internal bool IsSetAddType()
        {
            return this._addType != null;
        }

        /// <summary>
        /// Gets and sets the property AddVariable. 
        /// <para>
        /// An operation to add a new variable to the policy, which can be used in rule expressions
        /// to represent dynamic values.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddVariableAnnotation AddVariable
        {
            get { return this._addVariable; }
            set { this._addVariable = value; }
        }

        // Check to see if AddVariable property is set
        internal bool IsSetAddVariable()
        {
            return this._addVariable != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteRule. 
        /// <para>
        /// An operation to remove a rule from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteRuleAnnotation DeleteRule
        {
            get { return this._deleteRule; }
            set { this._deleteRule = value; }
        }

        // Check to see if DeleteRule property is set
        internal bool IsSetDeleteRule()
        {
            return this._deleteRule != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteType. 
        /// <para>
        /// An operation to remove a custom type from the policy. The type must not be referenced
        /// by any variables or rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteTypeAnnotation DeleteType
        {
            get { return this._deleteType; }
            set { this._deleteType = value; }
        }

        // Check to see if DeleteType property is set
        internal bool IsSetDeleteType()
        {
            return this._deleteType != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteVariable. 
        /// <para>
        /// An operation to remove a variable from the policy. The variable must not be referenced
        /// by any rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteVariableAnnotation DeleteVariable
        {
            get { return this._deleteVariable; }
            set { this._deleteVariable = value; }
        }

        // Check to see if DeleteVariable property is set
        internal bool IsSetDeleteVariable()
        {
            return this._deleteVariable != null;
        }

        /// <summary>
        /// Gets and sets the property IngestContent. 
        /// <para>
        /// An operation to process and incorporate new content into the policy, extracting additional
        /// rules and concepts.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyIngestContentAnnotation IngestContent
        {
            get { return this._ingestContent; }
            set { this._ingestContent = value; }
        }

        // Check to see if IngestContent property is set
        internal bool IsSetIngestContent()
        {
            return this._ingestContent != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateFromRulesFeedback. 
        /// <para>
        /// An operation to update the policy based on feedback about how specific rules performed
        /// during testing or validation.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateFromRuleFeedbackAnnotation UpdateFromRulesFeedback
        {
            get { return this._updateFromRulesFeedback; }
            set { this._updateFromRulesFeedback = value; }
        }

        // Check to see if UpdateFromRulesFeedback property is set
        internal bool IsSetUpdateFromRulesFeedback()
        {
            return this._updateFromRulesFeedback != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateFromScenarioFeedback. 
        /// <para>
        /// An operation to update the policy based on feedback about how it performed on specific
        /// test scenarios.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateFromScenarioFeedbackAnnotation UpdateFromScenarioFeedback
        {
            get { return this._updateFromScenarioFeedback; }
            set { this._updateFromScenarioFeedback = value; }
        }

        // Check to see if UpdateFromScenarioFeedback property is set
        internal bool IsSetUpdateFromScenarioFeedback()
        {
            return this._updateFromScenarioFeedback != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateRule. 
        /// <para>
        /// An operation to modify an existing rule in the policy, such as changing its logical
        /// expression or conditions.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateRuleAnnotation UpdateRule
        {
            get { return this._updateRule; }
            set { this._updateRule = value; }
        }

        // Check to see if UpdateRule property is set
        internal bool IsSetUpdateRule()
        {
            return this._updateRule != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// An operation to modify an existing custom type in the policy, such as changing its
        /// name, description, or allowed values.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateTypeAnnotation UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateVariable. 
        /// <para>
        /// An operation to modify an existing variable in the policy, such as changing its name,
        /// type, or description.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateVariableAnnotation UpdateVariable
        {
            get { return this._updateVariable; }
            set { this._updateVariable = value; }
        }

        // Check to see if UpdateVariable property is set
        internal bool IsSetUpdateVariable()
        {
            return this._updateVariable != null;
        }

    }
}