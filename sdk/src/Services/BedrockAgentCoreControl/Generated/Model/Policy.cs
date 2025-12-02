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
    /// Represents a complete policy resource within the AgentCore Policy system. Policies
    /// are ARN-able resources that contain Cedar policy statements and associated metadata
    /// for controlling agent behavior and access decisions. Each policy belongs to a policy
    /// engine and defines fine-grained authorization rules that are evaluated in real-time
    /// as agents interact with tools through Gateway. Policies use the Cedar policy language
    /// to specify who (principals based on OAuth claims like username, role, or scope) can
    /// perform what actions (tool calls) on which resources (Gateways), with optional conditions
    /// for attribute-based access control. Multiple policies can apply to a single request,
    /// with Cedar's forbid-wins semantics ensuring that security restrictions are never accidentally
    /// overridden.
    /// </summary>
    public partial class Policy
    {
        private DateTime? _createdAt;
        private PolicyDefinition _definition;
        private string _description;
        private string _name;
        private string _policyArn;
        private string _policyEngineId;
        private string _policyId;
        private PolicyStatus _status;
        private List<string> _statusReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the policy was originally created. This is automatically set by
        /// the service and used for auditing and lifecycle management.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Cedar policy statement that defines the access control rules. This contains the
        /// actual policy logic used for agent behavior control and access decisions.
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
        /// A human-readable description of the policy's purpose and functionality. Limited to
        /// 4,096 characters, this helps administrators understand and manage the policy.
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
        /// The customer-assigned immutable name for the policy. This human-readable identifier
        /// must be unique within the account and cannot exceed 48 characters.
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
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy. This globally unique identifier can
        /// be used for cross-service references and IAM policy statements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=96, Max=203)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine that manages this policy. This establishes the
        /// policy engine context for policy evaluation and management.
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
        /// The unique identifier for the policy. This system-generated identifier consists of
        /// the user name plus a 10-character generated suffix and serves as the primary key for
        /// policy operations.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Additional information about the policy status. This provides details about any failures
        /// or the current state of the policy lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StatusReasons
        {
            get { return this._statusReasons; }
            set { this._statusReasons = value; }
        }

        // Check to see if StatusReasons property is set
        internal bool IsSetStatusReasons()
        {
            return this._statusReasons != null && (this._statusReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the policy was last modified. This tracks the most recent changes
        /// to the policy configuration or metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}