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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private CedarPolicy _cedar;

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
        public CedarPolicy Cedar
        {
            get { return this._cedar; }
            set { this._cedar = value; }
        }

        // Check to see if Cedar property is set
        internal bool IsSetCedar()
        {
            return this._cedar != null;
        }

    }
}