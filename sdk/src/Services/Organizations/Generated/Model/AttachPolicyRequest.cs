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
    /// Container for the parameters to the AttachPolicy operation.
    /// Attaches a policy to a root, an organizational unit (OU), or an individual account.
    /// How the policy affects accounts depends on the type of policy. Refer to the <i>Organizations
    /// User Guide</i> for information about each policy type:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scp.html">SERVICE_CONTROL_POLICY</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_rcps.html">RESOURCE_CONTROL_POLICY</a>
    /// 
    /// </para>
    ///  </li> <li> 
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
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class AttachPolicyRequest : AmazonOrganizationsRequest
    {
        private string _policyId;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier (ID) of the policy that you want to attach to the target. You
        /// can get the ID for the policy by calling the <a>ListPolicies</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a policy ID string
        /// requires "p-" followed by from 8 to 128 lowercase or uppercase letters, digits, or
        /// the underscore character (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=130)]
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
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier (ID) of the root, OU, or account that you want to attach the
        /// policy to. You can get the ID by calling the <a>ListRoots</a>, <a>ListOrganizationalUnitsForParent</a>,
        /// or <a>ListAccounts</a> operations.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a target ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> - A string that begins with "r-" followed by from 4 to 32 lowercase letters
        /// or digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> - A string that consists of exactly 12 digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Organizational unit (OU)</b> - A string that begins with "ou-" followed by from
        /// 4 to 32 lowercase letters or digits (the ID of the root that the OU is in). This string
        /// is followed by a second "-" dash and from 8 to 32 additional lowercase letters or
        /// digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
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