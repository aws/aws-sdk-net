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
    /// Represents a single element in an Automated Reasoning policy definition, such as a
    /// rule, variable, or type definition.
    /// </summary>
    public partial class AutomatedReasoningPolicyDefinitionElement
    {
        /// <summary>
        /// Gets and sets the property PolicyDefinitionRule. 
        /// <para>
        /// A rule element within the policy definition that contains a formal logical expression
        /// used for validation.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionRule PolicyDefinitionRule { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDefinitionRule property is set.
        /// </summary>
        internal bool IsSetPolicyDefinitionRule() => this.PolicyDefinitionRule != null;

        /// <summary>
        /// Gets and sets the property PolicyDefinitionType. 
        /// <para>
        /// A custom type element within the policy definition that defines a set of possible
        /// values for variables.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionType PolicyDefinitionType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDefinitionType property is set.
        /// </summary>
        internal bool IsSetPolicyDefinitionType() => this.PolicyDefinitionType != null;

        /// <summary>
        /// Gets and sets the property PolicyDefinitionVariable. 
        /// <para>
        /// A variable element within the policy definition that represents a concept used in
        /// logical expressions and rules.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionVariable PolicyDefinitionVariable { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDefinitionVariable property is set.
        /// </summary>
        internal bool IsSetPolicyDefinitionVariable() => this.PolicyDefinitionVariable != null;
    }
}
