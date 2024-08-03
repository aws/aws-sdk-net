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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the action to take for a policy in an unused permissions
    /// finding.
    /// </summary>
    public partial class UnusedPermissionsRecommendedStep
    {
        private string _existingPolicyId;
        private DateTime? _policyUpdatedAt;
        private RecommendedRemediationAction _recommendedAction;
        private string _recommendedPolicy;

        /// <summary>
        /// Gets and sets the property ExistingPolicyId. 
        /// <para>
        /// If the recommended action for the unused permissions finding is to detach a policy,
        /// the ID of an existing policy to be detached.
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
        [AWSProperty(Required=true)]
        public RecommendedRemediationAction RecommendedAction
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
        /// If the recommended action for the unused permissions finding is to replace the existing
        /// policy, the contents of the recommended policy to replace the policy specified in
        /// the <c>existingPolicyId</c> field.
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