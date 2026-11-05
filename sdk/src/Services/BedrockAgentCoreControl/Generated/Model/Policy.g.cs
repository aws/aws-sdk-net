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
    /// Represents a complete policy resource within the AgentCore Policy system. Policies
    /// are ARN-able resources that contain Cedar or Dogwood policy statements and associated
    /// metadata for controlling agent behavior and access decisions. Each policy belongs
    /// to a policy engine and defines fine-grained authorization rules that are evaluated
    /// in real-time as agents interact with tools through Gateway. Policies use Cedar or
    /// Dogwood to specify who (principals based on OAuth claims like username, role, or scope)
    /// can perform what actions (tool calls) on which resources (Gateways), with optional
    /// conditions for attribute-based access control. Multiple policies can apply to a single
    /// request, with forbid-wins semantics ensuring that security restrictions are never
    /// accidentally overridden.
    /// </summary>
    public partial class Policy
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the policy was originally created. This is automatically set by
        /// the service and used for auditing and lifecycle management.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Cedar or Dogwood policy statement that defines the access control rules. This
        /// contains the actual policy logic used for agent behavior control and access decisions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the policy's purpose and functionality. Limited to
        /// 4,096 characters, this helps administrators understand and manage the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnforcementMode. 
        /// <para>
        /// The current enforcement mode of the policy.
        /// </para>
        /// </summary>
        public EnforcementMode EnforcementMode { get; set; }

        /// <summary>
        /// Checks to see if the EnforcementMode property is set.
        /// </summary>
        internal bool IsSetEnforcementMode() => this.EnforcementMode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned immutable name for the policy. This human-readable identifier
        /// must be unique within the account and cannot exceed 48 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy. This globally unique identifier can
        /// be used for cross-service references and IAM policy statements.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 96, Max = 203)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine that manages this policy. This establishes the
        /// policy engine context for policy evaluation and management.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyEngineId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineId property is set.
        /// </summary>
        internal bool IsSetPolicyEngineId() => this.PolicyEngineId != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier for the policy. This system-generated identifier consists of
        /// the user name plus a 10-character generated suffix and serves as the primary key for
        /// policy operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Additional information about the policy status. This provides details about any failures
        /// or the current state of the policy lifecycle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the policy was last modified. This tracks the most recent changes
        /// to the policy configuration or metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
