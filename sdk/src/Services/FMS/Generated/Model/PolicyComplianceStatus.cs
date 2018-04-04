/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Indicates whether the account is compliant with the specified policy. An account is
    /// considered non-compliant if it includes resources that are not protected by the policy.
    /// </summary>
    public partial class PolicyComplianceStatus
    {
        private List<EvaluationResult> _evaluationResults = new List<EvaluationResult>();
        private DateTime? _lastUpdated;
        private string _memberAccount;
        private string _policyId;
        private string _policyName;
        private string _policyOwner;

        /// <summary>
        /// Gets and sets the property EvaluationResults. 
        /// <para>
        /// An array of <code>EvaluationResult</code> objects.
        /// </para>
        /// </summary>
        public List<EvaluationResult> EvaluationResults
        {
            get { return this._evaluationResults; }
            set { this._evaluationResults = value; }
        }

        // Check to see if EvaluationResults property is set
        internal bool IsSetEvaluationResults()
        {
            return this._evaluationResults != null && this._evaluationResults.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Time stamp of the last update to the <code>EvaluationResult</code> objects.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The member account ID.
        /// </para>
        /// </summary>
        public string MemberAccount
        {
            get { return this._memberAccount; }
            set { this._memberAccount = value; }
        }

        // Check to see if MemberAccount property is set
        internal bool IsSetMemberAccount()
        {
            return this._memberAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The friendly name of the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PolicyOwner. 
        /// <para>
        /// The AWS account that created the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
        public string PolicyOwner
        {
            get { return this._policyOwner; }
            set { this._policyOwner = value; }
        }

        // Check to see if PolicyOwner property is set
        internal bool IsSetPolicyOwner()
        {
            return this._policyOwner != null;
        }

    }
}