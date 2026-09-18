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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the action to take for a policy in an unused permissions
    /// finding.
    /// </summary>
    public partial class UnusedPermissionsRecommendationStep
    {
        /// <summary>
        /// Gets and sets the property ExistingPolicy. 
        /// <para>
        /// The contents of the existing policy identified by <c>ExistingPolicyId</c> which needs
        /// to be replaced, when the <c>RecommendedAction</c> is <c>CREATE_POLICY</c>.
        /// </para>
        /// </summary>
        public string ExistingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ExistingPolicy property is set.
        /// </summary>
        internal bool IsSetExistingPolicy() => this.ExistingPolicy != null;

        /// <summary>
        /// Gets and sets the property ExistingPolicyId. 
        /// <para>
        /// The ID of an existing policy to be replaced or detached.
        /// </para>
        /// </summary>
        public string ExistingPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the ExistingPolicyId property is set.
        /// </summary>
        internal bool IsSetExistingPolicyId() => this.ExistingPolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyUpdatedAt. 
        /// <para>
        /// The time at which the existing policy for the unused permissions finding was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? PolicyUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the PolicyUpdatedAt property is set.
        /// </summary>
        internal bool IsSetPolicyUpdatedAt() => this.PolicyUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedAction. 
        /// <para>
        /// A recommendation of whether to create or detach a policy for an unused permissions
        /// finding.
        /// </para>
        /// </summary>
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedAction property is set.
        /// </summary>
        internal bool IsSetRecommendedAction() => this.RecommendedAction != null;

        /// <summary>
        /// Gets and sets the property RecommendedPolicy. 
        /// <para>
        /// The contents of the least-privileged recommended replacement for <c>ExistingPolicyId</c>,
        /// when the <c>RecommendedAction</c> is <c>CREATE_POLICY</c>.
        /// </para>
        /// </summary>
        public string RecommendedPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedPolicy property is set.
        /// </summary>
        internal bool IsSetRecommendedPolicy() => this.RecommendedPolicy != null;
    }
}
