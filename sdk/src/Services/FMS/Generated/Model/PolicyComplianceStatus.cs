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
    /// Indicates whether the account is compliant with the specified policy. An account is
    /// considered noncompliant if it includes resources that are not protected by the policy,
    /// for WAF and Shield Advanced policies, or that are noncompliant with the policy, for
    /// security group policies.
    /// </summary>
    public partial class PolicyComplianceStatus
    {
        private List<EvaluationResult> _evaluationResults = AWSConfigs.InitializeCollections ? new List<EvaluationResult>() : null;
        private Dictionary<string, string> _issueInfoMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _lastUpdated;
        private string _memberAccount;
        private string _policyId;
        private string _policyName;
        private string _policyOwner;

        /// <summary>
        /// Gets and sets the property EvaluationResults. 
        /// <para>
        /// An array of <c>EvaluationResult</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationResult> EvaluationResults
        {
            get { return this._evaluationResults; }
            set { this._evaluationResults = value; }
        }

        // Check to see if EvaluationResults property is set
        internal bool IsSetEvaluationResults()
        {
            return this._evaluationResults != null && (this._evaluationResults.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Timestamp of the last update to the <c>EvaluationResult</c> objects.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
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
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}