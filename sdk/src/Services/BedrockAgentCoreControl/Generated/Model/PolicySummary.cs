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
    /// Represents a metadata-only summary of a policy resource. This structure contains resource
    /// identifiers, status, and timestamps without customer-encrypted fields such as definition,
    /// description, or status reasons. Policy summaries are returned by operations that do
    /// not require access to the customer's KMS key.
    /// </summary>
    public partial class PolicySummary
    {
        private DateTime? _createdAt;
        private EnforcementMode _enforcementMode;
        private string _name;
        private string _policyArn;
        private string _policyEngineId;
        private string _policyId;
        private PolicyStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the policy was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnforcementMode. 
        /// <para>
        /// The current enforcement mode of the policy.
        /// </para>
        /// </summary>
        public EnforcementMode EnforcementMode
        {
            get { return this._enforcementMode; }
            set { this._enforcementMode = value; }
        }

        // Check to see if EnforcementMode property is set
        internal bool IsSetEnforcementMode()
        {
            return this._enforcementMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned name of the policy.
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
        /// The Amazon Resource Name (ARN) of the policy.
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
        /// The identifier of the policy engine that manages this policy.
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
        /// The unique identifier for the policy.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the policy was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}