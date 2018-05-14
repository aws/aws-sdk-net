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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DetachPolicy operation.
    /// Detaches a policy from a target root, organizational unit (OU), or account. If the
    /// policy being detached is a service control policy (SCP), the changes to permissions
    /// for IAM users and roles in affected accounts are immediate.
    /// 
    ///  
    /// <para>
    ///  <b>Note:</b> Every root, OU, and account must have at least one SCP attached. If
    /// you want to replace the default <code>FullAWSAccess</code> policy with one that limits
    /// the permissions that can be delegated, then you must attach the replacement policy
    /// before you can remove the default one. This is the authorization strategy of <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_about-scps.html#orgs_policies_whitelist">whitelisting</a>.
    /// If you instead attach a second SCP and leave the <code>FullAWSAccess</code> SCP still
    /// attached, and specify <code>"Effect": "Deny"</code> in the second SCP to override
    /// the <code>"Effect": "Allow"</code> in the <code>FullAWSAccess</code> policy (or any
    /// other attached SCP), then you are using the authorization strategy of <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_about-scps.html#orgs_policies_blacklist">blacklisting</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    /// </summary>
    public partial class DetachPolicyRequest : AmazonOrganizationsRequest
    {
        private string _policyId;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier (ID) of the policy you want to detach. You can get the ID from
        /// the <a>ListPolicies</a> or <a>ListPoliciesForTarget</a> operations.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a policy ID string
        /// requires "p-" followed by from 8 to 128 lower-case letters or digits.
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
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier (ID) of the root, OU, or account from which you want to detach
        /// the policy. You can get the ID from the <a>ListRoots</a>, <a>ListOrganizationalUnitsForParent</a>,
        /// or <a>ListAccounts</a> operations.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a target ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Root: a string that begins with "r-" followed by from 4 to 32 lower-case letters or
        /// digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Account: a string that consists of exactly 12 digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU): a string that begins with "ou-" followed by from 4 to 32
        /// lower-case letters or digits (the ID of the root that the OU is in) followed by a
        /// second "-" dash and from 8 to 32 additional lower-case letters or digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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