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
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Deletes the named resource policy attached to an event bus.
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonEventBridgeV2Request
    {
        private string _expectedRevisionId;
        private string _policyName;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// The delete succeeds only if the named policy's current revision ID matches this value;
        /// if it differs or the policy does not exist, the operation fails with ConflictException.
        /// The &quot;NO_POLICY&quot; sentinel is not valid here. When omitted, deleting an absent
        /// policy is an idempotent success. Supplying this value makes the delete non-idempotent:
        /// once it succeeds the expected revision no longer exists, so retrying an unanswered
        /// request fails with ConflictException even though the policy was deleted. To establish
        /// the outcome, read the policy back: ResourceNotFoundException means the delete took
        /// effect.
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
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Which named policy to delete. Defaults to &quot;default&quot; when omitted (a delete
        /// AWS Resource Access Manager makes on the owner's behalf resolves to &quot;AWS_RAM&quot;
        /// instead). The two writers are exclusive in both directions — only Resource Access
        /// Manager can delete &quot;AWS_RAM&quot;, and only the bus owner can delete &quot;default&quot;
        /// — so naming the other party's policy fails with AccessDeniedException. A well-formed
        /// name that is neither of the two fails with InvalidInputException.
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