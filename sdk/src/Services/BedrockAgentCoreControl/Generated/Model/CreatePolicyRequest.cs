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
    /// Container for the parameters to the CreatePolicy operation.
    /// Creates a policy within the AgentCore Policy system. Policies provide real-time, deterministic
    /// control over agentic interactions with AgentCore Gateway. Using the Cedar policy language,
    /// you can define fine-grained policies that specify which interactions with Gateway
    /// tools are permitted based on input parameters and OAuth claims, ensuring agents operate
    /// within defined boundaries and business rules. The policy is validated during creation
    /// against the Cedar schema generated from the Gateway's tools' input schemas, which
    /// defines the available tools, their parameters, and expected data types. This is an
    /// asynchronous operation. Use the <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
    /// operation to poll the <c>status</c> field to track completion.
    /// </summary>
    public partial class CreatePolicyRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private PolicyDefinition _definition;
        private string _description;
        private string _name;
        private string _policyEngineId;
        private PolicyValidationMode _validationMode;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure the idempotency of the request. The
        /// AWS SDK automatically generates this token, so you don't need to provide it in most
        /// cases. If you retry a request with the same client token, the service returns the
        /// same response without creating a duplicate policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Cedar policy statement that defines the access control rules. This contains the
        /// actual policy logic written in Cedar policy language, specifying effect (permit or
        /// forbid), principals, actions, resources, and conditions for agent behavior control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the policy's purpose and functionality (1-4,096 characters).
        /// This helps policy administrators understand the policy's intent, business rules, and
        /// operational scope. Use this field to document why the policy exists, what business
        /// requirement it addresses, and any special considerations for maintenance. Clear descriptions
        /// are essential for policy governance, auditing, and troubleshooting.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned immutable name for the policy. Must be unique within the account.
        /// This name is used for policy identification and cannot be changed after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine which contains this policy. Policy engines group
        /// related policies and provide the execution context for policy evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyEngineId
        {
            get { return this._policyEngineId; }
            set { this._policyEngineId = value; }
        }

        // Check to see if PolicyEngineId property is set
        internal bool IsSetPolicyEngineId()
        {
            return this._policyEngineId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMode. 
        /// <para>
        /// The validation mode for the policy creation. Determines how Cedar analyzer validation
        /// results are handled during policy creation. FAIL_ON_ANY_FINDINGS (default) runs the
        /// Cedar analyzer to validate the policy against the Cedar schema and tool context, failing
        /// creation if the analyzer detects any validation issues to ensure strict conformance.
        /// IGNORE_ALL_FINDINGS runs the Cedar analyzer but allows policy creation even if validation
        /// issues are detected, useful for testing or when the policy schema is evolving. Use
        /// FAIL_ON_ANY_FINDINGS for production policies to ensure correctness, and IGNORE_ALL_FINDINGS
        /// only when you understand and accept the analyzer findings.
        /// </para>
        /// </summary>
        public PolicyValidationMode ValidationMode
        {
            get { return this._validationMode; }
            set { this._validationMode = value; }
        }

        // Check to see if ValidationMode property is set
        internal bool IsSetValidationMode()
        {
            return this._validationMode != null;
        }

    }
}