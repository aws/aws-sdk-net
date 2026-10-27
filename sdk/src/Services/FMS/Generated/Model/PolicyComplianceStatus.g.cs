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
        /// <summary>
        /// Gets and sets the property EvaluationResults. 
        /// <para>
        /// An array of <c>EvaluationResult</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationResult> EvaluationResults { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationResult>() : null;

        /// <summary>
        /// Checks to see if the EvaluationResults property is set.
        /// </summary>
        internal bool IsSetEvaluationResults() => this.EvaluationResults != null && (this.EvaluationResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IssueInfoMap. 
        /// <para>
        /// Details about problems with dependent services, such as WAF or Config, and the error
        /// message received that indicates the problem with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IssueInfoMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IssueInfoMap property is set.
        /// </summary>
        internal bool IsSetIssueInfoMap() => this.IssueInfoMap != null && (this.IssueInfoMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Timestamp of the last update to the <c>EvaluationResult</c> objects.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The member account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string MemberAccount { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccount property is set.
        /// </summary>
        internal bool IsSetMemberAccount() => this.MemberAccount != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyOwner. 
        /// <para>
        /// The Amazon Web Services account that created the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PolicyOwner { get; set; }

        /// <summary>
        /// Checks to see if the PolicyOwner property is set.
        /// </summary>
        internal bool IsSetPolicyOwner() => this.PolicyOwner != null;
    }
}
