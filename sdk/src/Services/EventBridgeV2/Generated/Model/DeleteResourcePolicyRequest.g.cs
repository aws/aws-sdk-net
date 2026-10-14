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
    /// Container for the parameters to the DeleteResourcePolicy operation. Deletes the named
    /// resource policy attached to an event bus.
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. The delete succeeds only if the named
        /// policy's current revision ID matches this value; if it differs or the policy does
        /// not exist, the operation fails with ConflictException. The "NO_POLICY" sentinel is
        /// not valid here. When omitted, deleting an absent policy is an idempotent success.
        /// Supplying this value makes the delete non-idempotent: once it succeeds the expected
        /// revision no longer exists, so retrying an unanswered request fails with ConflictException
        /// even though the policy was deleted. To establish the outcome, read the policy back:
        /// ResourceNotFoundException means the delete took effect.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ExpectedRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRevisionId property is set.
        /// </summary>
        internal bool IsSetExpectedRevisionId() => this.ExpectedRevisionId != null;

        /// <summary>
        /// Gets and sets the property PolicyName. Which named policy to delete. Defaults to "default"
        /// when omitted (a delete AWS Resource Access Manager makes on the owner's behalf resolves
        /// to "AWS_RAM" instead). The two writers are exclusive in both directions — only Resource
        /// Access Manager can delete "AWS_RAM", and only the bus owner can delete "default" —
        /// so naming the other party's policy fails with AccessDeniedException. A well-formed
        /// name that is neither of the two fails with InvalidInputException.
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
