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

namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// Represents one authorization requirement considered during an evaluation and its result.
    /// </summary>
    public partial class Check
    {
        /// <summary>
        /// Gets and sets the property CheckType. 
        /// <para>
        /// The type of requirement that the check evaluates. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SERVICE_CONTROL_POLICY</c> - The service control policies (SCPs) attached to one
        /// organization target, such as a root, organizational unit, or account, that apply to
        /// the principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_CONTROL_POLICY</c> - The resource control policies (RCPs) attached to
        /// one organization target that apply to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VPC_ENDPOINT</c> - The VPC endpoint policy for the endpoint through which the
        /// request passes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE</c> - The resource owner's resource-based policies, when the owner must
        /// allow the request separately, such as a cross-account request or a request to an AWS
        /// KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRINCIPAL</c> - The principal's identity-based policies attached to the IAM user
        /// or role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERMISSIONS_BOUNDARY</c> - The permissions boundary on the IAM user or role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SESSION</c> - The role session that made the request, decided by its session policies.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public CheckType CheckType { get; set; }

        /// <summary>
        /// Checks to see if the CheckType property is set.
        /// </summary>
        internal bool IsSetCheckType() => this.CheckType != null;

        /// <summary>
        /// Gets and sets the property EvaluatedEffect. 
        /// <para>
        /// The result of evaluating this requirement. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - A statement that applies to this check allows the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPLICIT_DENY</c> - A deny statement that applies to this check matches.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPLICIT_DENY</c> - The check required an allow and nothing that applies to it
        /// allows the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_IMPACT</c> - No statement in this check matched, and no allow was needed because
        /// another path allowed the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public CheckEffect EvaluatedEffect { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatedEffect property is set.
        /// </summary>
        internal bool IsSetEvaluatedEffect() => this.EvaluatedEffect != null;

        /// <summary>
        /// Gets and sets the property MatchedPolicies. 
        /// <para>
        /// Policies in this list have statements that matched for this check. Each URI corresponds
        /// to an entry in the top-level <c>policies</c> list. Only policies in the top-level
        /// list are included. The check effect can reflect a matched policy omitted from this
        /// list, so this list can be empty even when the effect is <c>ALLOW</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchedPolicy> MatchedPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<MatchedPolicy>() : null;

        /// <summary>
        /// Checks to see if the MatchedPolicies property is set.
        /// </summary>
        internal bool IsSetMatchedPolicies() => this.MatchedPolicies != null && (this.MatchedPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelevantPolicyTypes. 
        /// <para>
        /// The policy types used to satisfy this check, plus the type of every policy with a
        /// statement that matched in it. <c>matchedPolicies</c> lists matching policies in the
        /// top-level <c>policies</c> list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelevantPolicyTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelevantPolicyTypes property is set.
        /// </summary>
        internal bool IsSetRelevantPolicyTypes() => this.RelevantPolicyTypes != null && (this.RelevantPolicyTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The ARN that distinguishes this check from other checks of the same type. This value
        /// is absent when the check type alone identifies the check. For SCP and RCP checks,
        /// this is the AWS Organizations ARN of the root, organizational unit, or account that
        /// the evaluated policies are attached to.
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
