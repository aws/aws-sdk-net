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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _existingPolicy;
        private string _existingPolicyId;
        private DateTime? _policyUpdatedAt;
        private string _recommendedAction;
        private string _recommendedPolicy;

        /// <summary>
        /// Gets and sets the property ExistingPolicy. 
        /// <para>
        /// The contents of the existing policy identified by <c>ExistingPolicyId</c> which needs
        /// to be replaced, when the <c>RecommendedAction</c> is <c>CREATE_POLICY</c>.
        /// </para>
        /// </summary>
        public string ExistingPolicy
        {
            get { return this._existingPolicy; }
            set { this._existingPolicy = value; }
        }

        // Check to see if ExistingPolicy property is set
        internal bool IsSetExistingPolicy()
        {
            return this._existingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExistingPolicyId. 
        /// <para>
        /// The ID of an existing policy to be replaced or detached.
        /// </para>
        /// </summary>
        public string ExistingPolicyId
        {
            get { return this._existingPolicyId; }
            set { this._existingPolicyId = value; }
        }

        // Check to see if ExistingPolicyId property is set
        internal bool IsSetExistingPolicyId()
        {
            return this._existingPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyUpdatedAt. 
        /// <para>
        /// The time at which the existing policy for the unused permissions finding was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? PolicyUpdatedAt
        {
            get { return this._policyUpdatedAt; }
            set { this._policyUpdatedAt = value; }
        }

        // Check to see if PolicyUpdatedAt property is set
        internal bool IsSetPolicyUpdatedAt()
        {
            return this._policyUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedAction. 
        /// <para>
        /// A recommendation of whether to create or detach a policy for an unused permissions
        /// finding.
        /// </para>
        /// </summary>
        public string RecommendedAction
        {
            get { return this._recommendedAction; }
            set { this._recommendedAction = value; }
        }

        // Check to see if RecommendedAction property is set
        internal bool IsSetRecommendedAction()
        {
            return this._recommendedAction != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedPolicy. 
        /// <para>
        /// The contents of the least-privileged recommended replacement for <c>ExistingPolicyId</c>,
        /// when the <c>RecommendedAction</c> is <c>CREATE_POLICY</c>.
        /// </para>
        /// </summary>
        public string RecommendedPolicy
        {
            get { return this._recommendedPolicy; }
            set { this._recommendedPolicy = value; }
        }

        // Check to see if RecommendedPolicy property is set
        internal bool IsSetRecommendedPolicy()
        {
            return this._recommendedPolicy != null;
        }

    }
}