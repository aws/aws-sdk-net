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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation. Attaches a named
    /// resource policy to an event bus — the only resource type that supports policies; other
    /// resource ARNs are rejected. Each bus holds two named policies: "default" (customer-managed,
    /// full IAM policy language including Deny) and "AWS_RAM" (written exclusively by AWS
    /// Resource Access Manager to reflect resource shares). Both policies are evaluated on
    /// cross-account authorization; an explicit Deny in either overrides an Allow in the
    /// other. Operations that omit PolicyName target "default". A "default" policy that would
    /// grant public access is rejected with PublicPolicyException and is not attached; this
    /// check is always on and cannot be disabled.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. The write succeeds only if the named
        /// policy's current revision ID matches this value; a policy that does not exist yet
        /// matches only the sentinel "NO_POLICY" (create-only). On mismatch the operation fails
        /// with ConflictException. When omitted, the write is unconditional. Every attempt stores
        /// a newly generated revision ID, so retrying an unanswered request can conflict with
        /// the caller's own earlier attempt; read the policy back and compare it with the one
        /// you intended before treating a conflict as another writer's change.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ExpectedRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRevisionId property is set.
        /// </summary>
        internal bool IsSetExpectedRevisionId() => this.ExpectedRevisionId != null;

        /// <summary>
        /// Gets and sets the property PolicyDocument.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 389120)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyName. Which named policy to write. Defaults to "default",
        /// the customer-managed policy, when omitted (a write AWS Resource Access Manager makes
        /// on the owner's behalf resolves to "AWS_RAM" instead). The two writers are exclusive
        /// in both directions — only Resource Access Manager can write "AWS_RAM", and only the
        /// bus owner can write "default" — so naming the other party's policy fails with AccessDeniedException.
        /// A well-formed name that is neither of the two fails with InvalidInputException.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property ResourceArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
