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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Represents the definition structure for policies within the AgentCore Policy system.
    /// This structure encapsulates different policy formats and languages that can be used
    /// to define access control rules.
    /// </summary>
    public partial class PolicyDefinition
    {
        /// <summary>
        /// Gets and sets the property Cedar. 
        /// <para>
        /// The Cedar policy definition within the policy definition structure. This contains
        /// the Cedar policy statement that defines the authorization logic using Cedar's human-readable,
        /// analyzable policy language. Cedar policies specify principals (who can access), actions
        /// (what operations are allowed), resources (what can be accessed), and optional conditions
        /// for fine-grained control. Cedar provides a formal policy language designed for authorization
        /// with deterministic evaluation, making policies testable, reviewable, and auditable.
        /// All Cedar policies follow a default-deny model where actions are denied unless explicitly
        /// permitted, and forbid policies always override permit policies.
        /// </para>
        /// </summary>
        public CedarPolicy Cedar { get; set; }

        /// <summary>
        /// Checks to see if the Cedar property is set.
        /// </summary>
        internal bool IsSetCedar() => this.Cedar != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The Dogwood policy statement that defines the access control rules. This policy definition
        /// can include Dogwood policies and supports temporal conditions and information providers
        /// such as guardrails.
        /// </para>
        /// </summary>
        public PolicyStatement Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property PolicyGeneration. 
        /// <para>
        /// The generated policy asset information within the policy definition structure. This
        /// contains information identifying a generated policy asset from the AI-powered policy
        /// generation process within the AgentCore Policy system. Each asset contains a Dogwood
        /// policy statement generated from natural language input, along with associated metadata
        /// and analysis findings to help users evaluate and select the most appropriate policy
        /// option.
        /// </para>
        /// </summary>
        public PolicyGenerationDetails PolicyGeneration { get; set; }

        /// <summary>
        /// Checks to see if the PolicyGeneration property is set.
        /// </summary>
        internal bool IsSetPolicyGeneration() => this.PolicyGeneration != null;
    }
}
