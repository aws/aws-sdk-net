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
    /// A container for various mutation operations that can be applied to an Automated Reasoning
    /// policy, including adding, updating, and deleting policy elements.
    /// </summary>
    public partial class AutomatedReasoningPolicyMutation
    {
        private AutomatedReasoningPolicyAddRuleMutation _addRule;
        private AutomatedReasoningPolicyAddTypeMutation _addType;
        private AutomatedReasoningPolicyAddVariableMutation _addVariable;
        private AutomatedReasoningPolicyDeleteRuleMutation _deleteRule;
        private AutomatedReasoningPolicyDeleteTypeMutation _deleteType;
        private AutomatedReasoningPolicyDeleteVariableMutation _deleteVariable;
        private AutomatedReasoningPolicyUpdateRuleMutation _updateRule;
        private AutomatedReasoningPolicyUpdateTypeMutation _updateType;
        private AutomatedReasoningPolicyUpdateVariableMutation _updateVariable;

        /// <summary>
        /// Gets and sets the property AddRule. 
        /// <para>
        /// A mutation to add a new rule to the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddRuleMutation AddRule
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
        /// Gets and sets the property AddType. 
        /// <para>
        /// A mutation to add a new custom type to the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddTypeMutation AddType
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
        /// A mutation to add a new variable to the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddVariableMutation AddVariable
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
        /// A mutation to remove a rule from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteRuleMutation DeleteRule
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
        /// A mutation to remove a custom type from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteTypeMutation DeleteType
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
        /// A mutation to remove a variable from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteVariableMutation DeleteVariable
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
        /// Gets and sets the property UpdateRule. 
        /// <para>
        /// A mutation to modify an existing rule in the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateRuleMutation UpdateRule
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
        /// A mutation to modify an existing custom type in the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateTypeMutation UpdateType
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
        /// A mutation to modify an existing variable in the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateVariableMutation UpdateVariable
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