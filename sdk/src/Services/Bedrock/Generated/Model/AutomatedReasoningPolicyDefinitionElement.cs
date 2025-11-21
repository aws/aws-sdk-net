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
    /// Represents a single element in an Automated Reasoning policy definition, such as a
    /// rule, variable, or type definition.
    /// </summary>
    public partial class AutomatedReasoningPolicyDefinitionElement
    {
        private AutomatedReasoningPolicyDefinitionRule _policyDefinitionRule;
        private AutomatedReasoningPolicyDefinitionType _policyDefinitionType;
        private AutomatedReasoningPolicyDefinitionVariable _policyDefinitionVariable;

        /// <summary>
        /// Gets and sets the property PolicyDefinitionRule. 
        /// <para>
        /// A rule element within the policy definition that contains a formal logical expression
        /// used for validation.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionRule PolicyDefinitionRule
        {
            get { return this._policyDefinitionRule; }
            set { this._policyDefinitionRule = value; }
        }

        // Check to see if PolicyDefinitionRule property is set
        internal bool IsSetPolicyDefinitionRule()
        {
            return this._policyDefinitionRule != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDefinitionType. 
        /// <para>
        /// A custom type element within the policy definition that defines a set of possible
        /// values for variables.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionType PolicyDefinitionType
        {
            get { return this._policyDefinitionType; }
            set { this._policyDefinitionType = value; }
        }

        // Check to see if PolicyDefinitionType property is set
        internal bool IsSetPolicyDefinitionType()
        {
            return this._policyDefinitionType != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDefinitionVariable. 
        /// <para>
        /// A variable element within the policy definition that represents a concept used in
        /// logical expressions and rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionVariable PolicyDefinitionVariable
        {
            get { return this._policyDefinitionVariable; }
            set { this._policyDefinitionVariable = value; }
        }

        // Check to see if PolicyDefinitionVariable property is set
        internal bool IsSetPolicyDefinitionVariable()
        {
            return this._policyDefinitionVariable != null;
        }

    }
}