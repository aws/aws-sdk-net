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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Describes the noncompliant resources in a member account for a specific Firewall Manager
    /// policy. A maximum of 100 entries are displayed. If more than 100 resources are noncompliant,
    /// <c>EvaluationLimitExceeded</c> is set to <c>True</c>.
    /// </summary>
    public partial class PolicyComplianceDetail
    {
        private bool? _evaluationLimitExceeded;
        private DateTime? _expiredAt;
        private Dictionary<string, string> _issueInfoMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _memberAccount;
        private string _policyId;
        private string _policyOwner;
        private List<ComplianceViolator> _violators = AWSConfigs.InitializeCollections ? new List<ComplianceViolator>() : null;

        /// <summary>
        /// Gets and sets the property EvaluationLimitExceeded. 
        /// <para>
        /// Indicates if over 100 resources are noncompliant with the Firewall Manager policy.
        /// </para>
        /// </summary>
        public bool? EvaluationLimitExceeded
        {
            get { return this._evaluationLimitExceeded; }
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
        /// A timestamp that indicates when the returned information should be considered out
        /// of date.
        /// </para>
        /// </summary>
        public DateTime? ExpiredAt
        {
            get { return this._expiredAt; }
            set { this._expiredAt = value; }
        }

        // Check to see if ExpiredAt property is set
        internal bool IsSetExpiredAt()
        {
            return this._expiredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IssueInfoMap. 
        /// <para>
        /// Details about problems with dependent services, such as WAF or Config, and the error
        /// message received that indicates the problem with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IssueInfoMap
        {
            get { return this._issueInfoMap; }
            set { this._issueInfoMap = value; }
        }

        // Check to see if IssueInfoMap property is set
        internal bool IsSetIssueInfoMap()
        {
            return this._issueInfoMap != null && (this._issueInfoMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The ID of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// The Amazon Web Services account that created the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// An array of resources that aren't protected by the WAF or Shield Advanced policy or
        /// that aren't in compliance with the security group policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComplianceViolator> Violators
        {
            get { return this._violators; }
            set { this._violators = value; }
        }

        // Check to see if Violators property is set
        internal bool IsSetViolators()
        {
            return this._violators != null && (this._violators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}