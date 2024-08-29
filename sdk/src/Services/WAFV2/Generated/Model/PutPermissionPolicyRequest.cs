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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutPermissionPolicy operation.
    /// Use this to share a rule group with other accounts.
    /// 
    ///  
    /// <para>
    /// This action attaches an IAM policy to the specified resource. You must be the owner
    /// of the rule group to perform this operation.
    /// </para>
    ///  
    /// <para>
    /// This action is subject to the following restrictions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
    /// must exist in the same Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user making the request must be the owner of the rule group.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If a rule group has been shared with your account, you can access it through the call
    /// <c>GetRuleGroup</c>, and you can reference it in <c>CreateWebACL</c> and <c>UpdateWebACL</c>.
    /// Rule groups that are shared with you don't appear in your WAF console rule groups
    /// listing. 
    /// </para>
    /// </summary>
    public partial class PutPermissionPolicyRequest : AmazonWAFV2Request
    {
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy to attach to the specified rule group. 
        /// </para>
        ///  
        /// <para>
        /// The policy specifications must conform to the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <c>Effect</c>, <c>Action</c>, and <c>Principal</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Action</c> must specify <c>wafv2:CreateWebACL</c>, <c>wafv2:UpdateWebACL</c>,
        /// and <c>wafv2:PutFirewallManagerRuleGroups</c> and may optionally specify <c>wafv2:GetRuleGroup</c>.
        /// WAF rejects any extra actions or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=395000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a>RuleGroup</a> to which you want to attach
        /// the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}