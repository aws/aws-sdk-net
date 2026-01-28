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
    /// Container for the parameters to the UpdatePolicy operation.
    /// Updates an existing policy within the AgentCore Policy system. This operation allows
    /// modification of the policy description and definition while maintaining the policy's
    /// identity. The updated policy is validated against the Cedar schema before being applied.
    /// This is an asynchronous operation. Use the <c>GetPolicy</c> operation to poll the
    /// <c>status</c> field to track completion.
    /// </summary>
    public partial class UpdatePolicyRequest : AmazonBedrockAgentCoreControlRequest
    {
        private PolicyDefinition _definition;
        private string _description;
        private string _policyEngineId;
        private string _policyId;
        private PolicyValidationMode _validationMode;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The new Cedar policy statement that defines the access control rules. This replaces
        /// the existing policy definition with new logic while maintaining the policy's identity.
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
        /// The new human-readable description for the policy. This optional field allows updating
        /// the policy's documentation while keeping the same policy logic.
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
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine that manages the policy to be updated. This ensures
        /// the policy is updated within the correct policy engine context.
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
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier of the policy to be updated. This must be a valid policy ID
        /// that exists within the specified policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMode. 
        /// <para>
        /// The validation mode for the policy update. Determines how Cedar analyzer validation
        /// results are handled during policy updates. FAIL_ON_ANY_FINDINGS runs the Cedar analyzer
        /// and fails the update if validation issues are detected, ensuring the policy conforms
        /// to the Cedar schema and tool context. IGNORE_ALL_FINDINGS runs the Cedar analyzer
        /// but allows updates despite validation warnings. Use FAIL_ON_ANY_FINDINGS to ensure
        /// policy correctness during updates, especially when modifying policy logic or conditions.
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