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
    /// Contains the various operations that can be performed on an Automated Reasoning policy,
    /// including adding, updating, and deleting rules, variables, and types.
    /// </summary>
    public partial class AutomatedReasoningPolicyAnnotation
    {
        /// <summary>
        /// Gets and sets the property AddRule. 
        /// <para>
        /// An operation to add a new logical rule to the policy using formal mathematical expressions.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddRuleAnnotation AddRule { get; set; }

        /// <summary>
        /// Checks to see if the AddRule property is set.
        /// </summary>
        internal bool IsSetAddRule() => this.AddRule != null;

        /// <summary>
        /// Gets and sets the property AddRuleFromNaturalLanguage. 
        /// <para>
        /// An operation to add a new rule by converting natural language descriptions into formal
        /// logical expressions.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddRuleFromNaturalLanguageAnnotation AddRuleFromNaturalLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AddRuleFromNaturalLanguage property is set.
        /// </summary>
        internal bool IsSetAddRuleFromNaturalLanguage() => this.AddRuleFromNaturalLanguage != null;

        /// <summary>
        /// Gets and sets the property AddType. 
        /// <para>
        /// An operation to add a new custom type to the policy, defining a set of possible values
        /// for policy variables.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddTypeAnnotation AddType { get; set; }

        /// <summary>
        /// Checks to see if the AddType property is set.
        /// </summary>
        internal bool IsSetAddType() => this.AddType != null;

        /// <summary>
        /// Gets and sets the property AddVariable. 
        /// <para>
        /// An operation to add a new variable to the policy, which can be used in rule expressions
        /// to represent dynamic values.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddVariableAnnotation AddVariable { get; set; }

        /// <summary>
        /// Checks to see if the AddVariable property is set.
        /// </summary>
        internal bool IsSetAddVariable() => this.AddVariable != null;

        /// <summary>
        /// Gets and sets the property DeleteRule. 
        /// <para>
        /// An operation to remove a rule from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteRuleAnnotation DeleteRule { get; set; }

        /// <summary>
        /// Checks to see if the DeleteRule property is set.
        /// </summary>
        internal bool IsSetDeleteRule() => this.DeleteRule != null;

        /// <summary>
        /// Gets and sets the property DeleteType. 
        /// <para>
        /// An operation to remove a custom type from the policy. The type must not be referenced
        /// by any variables or rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteTypeAnnotation DeleteType { get; set; }

        /// <summary>
        /// Checks to see if the DeleteType property is set.
        /// </summary>
        internal bool IsSetDeleteType() => this.DeleteType != null;

        /// <summary>
        /// Gets and sets the property DeleteVariable. 
        /// <para>
        /// An operation to remove a variable from the policy. The variable must not be referenced
        /// by any rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteVariableAnnotation DeleteVariable { get; set; }

        /// <summary>
        /// Checks to see if the DeleteVariable property is set.
        /// </summary>
        internal bool IsSetDeleteVariable() => this.DeleteVariable != null;

        /// <summary>
        /// Gets and sets the property IngestContent. 
        /// <para>
        /// An operation to process and incorporate new content into the policy, extracting additional
        /// rules and concepts.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyIngestContentAnnotation IngestContent { get; set; }

        /// <summary>
        /// Checks to see if the IngestContent property is set.
        /// </summary>
        internal bool IsSetIngestContent() => this.IngestContent != null;

        /// <summary>
        /// Gets and sets the property UpdateFromRulesFeedback. 
        /// <para>
        /// An operation to update the policy based on feedback about how specific rules performed
        /// during testing or validation.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateFromRuleFeedbackAnnotation UpdateFromRulesFeedback { get; set; }

        /// <summary>
        /// Checks to see if the UpdateFromRulesFeedback property is set.
        /// </summary>
        internal bool IsSetUpdateFromRulesFeedback() => this.UpdateFromRulesFeedback != null;

        /// <summary>
        /// Gets and sets the property UpdateFromScenarioFeedback. 
        /// <para>
        /// An operation to update the policy based on feedback about how it performed on specific
        /// test scenarios.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateFromScenarioFeedbackAnnotation UpdateFromScenarioFeedback { get; set; }

        /// <summary>
        /// Checks to see if the UpdateFromScenarioFeedback property is set.
        /// </summary>
        internal bool IsSetUpdateFromScenarioFeedback() => this.UpdateFromScenarioFeedback != null;

        /// <summary>
        /// Gets and sets the property UpdateRule. 
        /// <para>
        /// An operation to modify an existing rule in the policy, such as changing its logical
        /// expression or conditions.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateRuleAnnotation UpdateRule { get; set; }

        /// <summary>
        /// Checks to see if the UpdateRule property is set.
        /// </summary>
        internal bool IsSetUpdateRule() => this.UpdateRule != null;

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// An operation to modify an existing custom type in the policy, such as changing its
        /// name, description, or allowed values.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateTypeAnnotation UpdateType { get; set; }

        /// <summary>
        /// Checks to see if the UpdateType property is set.
        /// </summary>
        internal bool IsSetUpdateType() => this.UpdateType != null;

        /// <summary>
        /// Gets and sets the property UpdateVariable. 
        /// <para>
        /// An operation to modify an existing variable in the policy, such as changing its name,
        /// type, or description.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateVariableAnnotation UpdateVariable { get; set; }

        /// <summary>
        /// Checks to see if the UpdateVariable property is set.
        /// </summary>
        internal bool IsSetUpdateVariable() => this.UpdateVariable != null;
    }
}
