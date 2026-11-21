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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A principal to assign a policy to in a <c>BatchPutPolicyAssignmentByPolicy</c> request.
    /// </summary>
    public partial class PutAssignmentEntry
    {
        /// <summary>
        /// Gets and sets the property ExistingPolicyArn. 
        /// <para>
        /// The ARN of the policy that you expect the principal to have before this request. If
        /// the principal has a different policy of the same type, or no policy of that type,
        /// this entry fails with a <c>ConflictException</c> error code and makes no change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExistingPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the ExistingPolicyArn property is set.
        /// </summary>
        internal bool IsSetExistingPolicyArn() => this.ExistingPolicyArn != null;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the user, group, or account to assign the policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the assignment from your most recent read. If the assignment has changed
        /// since that revision, this entry fails with a <c>ConflictException</c> error code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;
    }
}
