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
    /// Container for the parameters to the AttachPolicy operation.
    /// Attaches a policy to a root, an organizational unit (OU), or an individual account.
    /// How the policy affects accounts depends on the type of policy:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Service control policy (SCP)</b> - An SCP specifies what permissions can be delegated
    /// to users in affected member accounts. The scope of influence for a policy depends
    /// on what you attach the policy to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you attach an SCP to a root, it affects all accounts in the organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you attach an SCP to an OU, it affects all accounts in that OU and in any child
    /// OUs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you attach the policy directly to an account, then it affects only that account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// SCPs essentially are permission "filters". When you attach one SCP to a higher level
    /// root or OU, and you also attach a different SCP to a child OU or to an account, the
    /// child policy can further restrict only the permissions that pass through the parent
    /// filter and are available to the child. An SCP that is attached to a child cannot grant
    /// a permission that is not already granted by the parent. For example, imagine that
    /// the parent SCP allows permissions A, B, C, D, and E. The child SCP allows C, D, E,
    /// F, and G. The result is that the accounts affected by the child SCP are allowed to
    /// use only C, D, and E. They cannot use A or B because they were filtered out by the
    /// child OU. They also cannot use F and G because they were filtered out by the parent
    /// OU. They cannot be granted back by the child SCP; child SCPs can only filter the permissions
    /// they receive from the parent SCP.
    /// </para>
    ///  
    /// <para>
    /// AWS Organizations attaches a default SCP named <code>"FullAWSAccess</code> to every
    /// root, OU, and account. This default SCP allows all services and actions, enabling
    /// any new child OU or account to inherit the permissions of the parent root or OU. If
    /// you detach the default policy, you must replace it with a policy that specifies the
    /// permissions that you want to allow in that OU or account.
    /// </para>
    ///  
    /// <para>
    /// For more information about how Organizations policies permissions work, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scp.html">Using
    /// Service Control Policies</a> in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation can be called only from the organization's master account.
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