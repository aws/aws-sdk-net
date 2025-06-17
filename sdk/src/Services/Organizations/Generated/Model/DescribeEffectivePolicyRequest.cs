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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEffectivePolicy operation.
    /// Returns the contents of the effective policy for specified policy type and account.
    /// The effective policy is the aggregation of any policies of the specified type that
    /// the account inherits, plus any policy of that type that is directly attached to the
    /// account.
    /// 
    ///  
    /// <para>
    /// This operation applies only to management policies. It does not apply to authorization
    /// policies: service control policies (SCPs) and resource control policies (RCPs).
    /// </para>
    ///  
    /// <para>
    /// For more information about policy inheritance, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_inheritance_mgmt.html">Understanding
    /// management policy inheritance</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called from any account in the organization.
    /// </para>
    /// </summary>
    public partial class DescribeEffectivePolicyRequest : AmazonOrganizationsRequest
    {
        private EffectivePolicyType _policyType;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy that you want information about. You can specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_declarative.html">DECLARATIVE_POLICY_EC2</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_backup.html">BACKUP_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">TAG_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_chatbot.html">CHATBOT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_ai-opt-out.html">AISERVICES_OPT_OUT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_security_hub.html">SECURITYHUB_POLICY</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EffectivePolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// When you're signed in as the management account, specify the ID of the account that
        /// you want details about. Specifying an organization root or organizational unit (OU)
        /// as the target is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}