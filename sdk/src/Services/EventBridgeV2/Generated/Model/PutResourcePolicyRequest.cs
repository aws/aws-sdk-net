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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches a named resource policy to an event bus — the only resource type that supports
    /// policies; other resource ARNs are rejected. Each bus holds two named policies: &quot;default&quot;
    /// (customer-managed, full IAM policy language including Deny) and &quot;AWS_RAM&quot;
    /// (written exclusively by AWS Resource Access Manager to reflect resource shares). Both
    /// policies are evaluated on cross-account authorization; an explicit Deny in either
    /// overrides an Allow in the other. Operations that omit PolicyName target &quot;default&quot;.
    /// A &quot;default&quot; policy that would grant public access is rejected with PublicPolicyException
    /// and is not attached; this check is always on and cannot be disabled.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonEventBridgeV2Request
    {
        private string _expectedRevisionId;
        private string _policyDocument;
        private string _policyName;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// The write succeeds only if the named policy's current revision ID matches this value;
        /// a policy that does not exist yet matches only the sentinel &quot;NO_POLICY&quot; (create-only).
        /// On mismatch the operation fails with ConflictException. When omitted, the write is
        /// unconditional. Every attempt stores a newly generated revision ID, so retrying an
        /// unanswered request can conflict with the caller's own earlier attempt; read the policy
        /// back and compare it with the one you intended before treating a conflict as another
        /// writer's change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ExpectedRevisionId
        {
            get { return this._expectedRevisionId; }
            set { this._expectedRevisionId = value; }
        }

        // Check to see if ExpectedRevisionId property is set
        internal bool IsSetExpectedRevisionId()
        {
            return this._expectedRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=389120)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Which named policy to write. Defaults to &quot;default&quot;, the customer-managed
        /// policy, when omitted (a write AWS Resource Access Manager makes on the owner's behalf
        /// resolves to &quot;AWS_RAM&quot; instead). The two writers are exclusive in both directions
        /// — only Resource Access Manager can write &quot;AWS_RAM&quot;, and only the bus owner
        /// can write &quot;default&quot; — so naming the other party's policy fails with AccessDeniedException.
        /// A well-formed name that is neither of the two fails with InvalidInputException.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}