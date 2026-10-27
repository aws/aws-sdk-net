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
    /// Describes the noncompliant resources in a member account for a specific Firewall Manager
    /// policy. A maximum of 100 entries are displayed. If more than 100 resources are noncompliant,
    /// <c>EvaluationLimitExceeded</c> is set to <c>True</c>.
    /// </summary>
    public partial class PolicyComplianceDetail
    {
        /// <summary>
        /// Gets and sets the property EvaluationLimitExceeded. 
        /// <para>
        /// Indicates if over 100 resources are noncompliant with the Firewall Manager policy.
        /// </para>
        /// </summary>
        public bool? EvaluationLimitExceeded { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationLimitExceeded property is set.
        /// </summary>
        internal bool IsSetEvaluationLimitExceeded() => this.EvaluationLimitExceeded.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiredAt. 
        /// <para>
        /// A timestamp that indicates when the returned information should be considered out
        /// of date.
        /// </para>
        /// </summary>
        public DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiredAt property is set.
        /// </summary>
        internal bool IsSetExpiredAt() => this.ExpiredAt.HasValue;

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
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The Amazon Web Services account ID.
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

        /// <summary>
        /// Gets and sets the property Violators. 
        /// <para>
        /// An array of resources that aren't protected by the WAF or Shield Advanced policy or
        /// that aren't in compliance with the security group policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComplianceViolator> Violators { get; set; } = AWSConfigs.InitializeCollections ? new List<ComplianceViolator>() : null;

        /// <summary>
        /// Checks to see if the Violators property is set.
        /// </summary>
        internal bool IsSetViolators() => this.Violators != null && (this.Violators.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
