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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation. Creates or replaces
    /// the resource policy attached to a Continuum resource.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. The ARN of a resource in the caller's account.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. Optional optimistic-concurrency token
        /// for the currently observed policy.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ExpectedRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRevisionId property is set.
        /// </summary>
        internal bool IsSetExpectedRevisionId() => this.ExpectedRevisionId != null;

        /// <summary>
        /// Gets and sets the property Policy. Omit or supply an empty Statement array to clear
        /// resource-policy grants and store the canonical empty-statement policy. Cross-account
        /// access is denied; same-account access remains subject to identity policies. Use an
        /// explicit Deny statement to deny same-account principals too.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 131072)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;
    }
}
