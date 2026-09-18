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
    /// A container for various mutation operations that can be applied to an Automated Reasoning
    /// policy, including adding, updating, and deleting policy elements.
    /// </summary>
    public partial class AutomatedReasoningPolicyMutation
    {
        /// <summary>
        /// Gets and sets the property AddRule. 
        /// <para>
        /// A mutation to add a new rule to the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddRuleMutation AddRule { get; set; }

        /// <summary>
        /// Checks to see if the AddRule property is set.
        /// </summary>
        internal bool IsSetAddRule() => this.AddRule != null;

        /// <summary>
        /// Gets and sets the property AddType. 
        /// <para>
        /// A mutation to add a new custom type to the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddTypeMutation AddType { get; set; }

        /// <summary>
        /// Checks to see if the AddType property is set.
        /// </summary>
        internal bool IsSetAddType() => this.AddType != null;

        /// <summary>
        /// Gets and sets the property AddVariable. 
        /// <para>
        /// A mutation to add a new variable to the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddVariableMutation AddVariable { get; set; }

        /// <summary>
        /// Checks to see if the AddVariable property is set.
        /// </summary>
        internal bool IsSetAddVariable() => this.AddVariable != null;

        /// <summary>
        /// Gets and sets the property DeleteRule. 
        /// <para>
        /// A mutation to remove a rule from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteRuleMutation DeleteRule { get; set; }

        /// <summary>
        /// Checks to see if the DeleteRule property is set.
        /// </summary>
        internal bool IsSetDeleteRule() => this.DeleteRule != null;

        /// <summary>
        /// Gets and sets the property DeleteType. 
        /// <para>
        /// A mutation to remove a custom type from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteTypeMutation DeleteType { get; set; }

        /// <summary>
        /// Checks to see if the DeleteType property is set.
        /// </summary>
        internal bool IsSetDeleteType() => this.DeleteType != null;

        /// <summary>
        /// Gets and sets the property DeleteVariable. 
        /// <para>
        /// A mutation to remove a variable from the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteVariableMutation DeleteVariable { get; set; }

        /// <summary>
        /// Checks to see if the DeleteVariable property is set.
        /// </summary>
        internal bool IsSetDeleteVariable() => this.DeleteVariable != null;

        /// <summary>
        /// Gets and sets the property UpdateRule. 
        /// <para>
        /// A mutation to modify an existing rule in the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateRuleMutation UpdateRule { get; set; }

        /// <summary>
        /// Checks to see if the UpdateRule property is set.
        /// </summary>
        internal bool IsSetUpdateRule() => this.UpdateRule != null;

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// A mutation to modify an existing custom type in the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateTypeMutation UpdateType { get; set; }

        /// <summary>
        /// Checks to see if the UpdateType property is set.
        /// </summary>
        internal bool IsSetUpdateType() => this.UpdateType != null;

        /// <summary>
        /// Gets and sets the property UpdateVariable. 
        /// <para>
        /// A mutation to modify an existing variable in the policy.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateVariableMutation UpdateVariable { get; set; }

        /// <summary>
        /// Checks to see if the UpdateVariable property is set.
        /// </summary>
        internal bool IsSetUpdateVariable() => this.UpdateVariable != null;
    }
}
