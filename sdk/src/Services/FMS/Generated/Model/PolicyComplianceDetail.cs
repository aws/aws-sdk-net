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
    /// Describes the non-compliant resources in a member account for a specific AWS Firewall
    /// Manager policy. A maximum of 100 entries are displayed. If more than 100 resources
    /// are non-compliant, <code>EvaluationLimitExceeded</code> is set to <code>True</code>.
    /// </summary>
    public partial class PolicyComplianceDetail
    {
        private bool? _evaluationLimitExceeded;
        private DateTime? _expiredAt;
        private string _memberAccount;
        private string _policyId;
        private string _policyOwner;
        private List<ComplianceViolator> _violators = new List<ComplianceViolator>();

        /// <summary>
        /// Gets and sets the property EvaluationLimitExceeded. 
        /// <para>
        /// Indicates if over 100 resources are non-compliant with the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
        public bool EvaluationLimitExceeded
        {
            get { return this._evaluationLimitExceeded.GetValueOrDefault(); }
            set { this._evaluationLimitExceeded = value; }
        }

        // Check to see if EvaluationLimitExceeded property is set
        internal bool IsSetEvaluationLimitExceeded()
        {
            return this._evaluationLimitExceeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiredAt. 
        /// <para>
        /// A time stamp that indicates when the returned information should be considered out-of-date.
        /// </para>
        /// </summary>
        public DateTime ExpiredAt
        {
            get { return this._expiredAt.GetValueOrDefault(); }
            set { this._expiredAt = value; }
        }

        // Check to see if ExpiredAt property is set
        internal bool IsSetExpiredAt()
        {
            return this._expiredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The AWS account ID.
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

        /// <summary>
        /// Gets and sets the property Violators. 
        /// <para>
        /// An array of resources that are not protected by the policy.
        /// </para>
        /// </summary>
        public List<ComplianceViolator> Violators
        {
            get { return this._violators; }
            set { this._violators = value; }
        }

        // Check to see if Violators property is set
        internal bool IsSetViolators()
        {
            return this._violators != null && this._violators.Count > 0; 
        }

    }
}