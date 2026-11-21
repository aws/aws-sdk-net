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
    /// A principal that a <c>BatchPutPolicyAssignmentByPolicy</c> request assigned the policy
    /// to.
    /// </summary>
    public partial class BatchPutPolicyAssignmentSuccess
    {
        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property ReplacedPolicyArn. 
        /// <para>
        /// The ARN of the policy that this assignment replaced. This value is absent if the principal
        /// had no policy of this type before the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ReplacedPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplacedPolicyArn property is set.
        /// </summary>
        internal bool IsSetReplacedPolicyArn() => this.ReplacedPolicyArn != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the assignment after this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;
    }
}
