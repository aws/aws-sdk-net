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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>GetAccountSummary</a> action.
    /// </summary>
    public partial class GetAccountSummaryResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, int> _summaryMap = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property SummaryMap. 
        /// <para>
        /// A set of key value pairs containing information about IAM entity usage and IAM quotas.
        /// </para>
        ///  
        /// <para>
        ///  <code>SummaryMap</code> contains the following keys: <ul> <li> 
        /// <para>
        /// <b>AccessKeysPerUserQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of active access keys allowed for each IAM user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AccountAccessKeysPresent</b>
        /// </para>
        ///  
        /// <para>
        /// This value is 1 if the AWS account (root) has an access key, otherwise it is 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AccountMFAEnabled</b>
        /// </para>
        ///  
        /// <para>
        /// This value is 1 if the AWS account (root) has an MFA device assigned, otherwise it
        /// is 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AccountSigningCertificatesPresent</b>
        /// </para>
        ///  
        /// <para>
        /// This value is 1 if the AWS account (root) has a signing certificate, otherwise it
        /// is 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AssumeRolePolicySizeQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed size for assume role policy documents (trust policies), in non-whitespace
        /// characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AttachedPoliciesPerGroupQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of managed policies that can be attached to an IAM group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AttachedPoliciesPerRoleQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of managed policies that can be attached to an IAM role. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>AttachedPoliciesPerUserQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of managed policies that can be attached to an IAM user. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>GroupPolicySizeQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed size for the aggregate of all inline policies embedded in an IAM
        /// group, in non-whitespace characters. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Groups</b>
        /// </para>
        ///  
        /// <para>
        /// The number of IAM groups in the AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>GroupsPerUserQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of IAM groups each IAM user can belong to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>GroupsQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of IAM groups allowed in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>InstanceProfiles</b>
        /// </para>
        ///  
        /// <para>
        /// The number of instance profiles in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>InstanceProfilesQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of instance profiles allowed in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>MFADevices</b>
        /// </para>
        ///  
        /// <para>
        /// The number of MFA devices in the AWS account, including those assigned and unassigned.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>MFADevicesInUse</b>
        /// </para>
        ///  
        /// <para>
        /// The number of MFA devices that have been assigned to an IAM user or to the AWS account
        /// (root). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Policies</b>
        /// </para>
        ///  
        /// <para>
        /// The number of customer managed policies in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>PoliciesQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of customer managed policies allowed in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>PolicySizeQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed size of a customer managed policy, in non-whitespace characters.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>PolicyVersionsInUse</b>
        /// </para>
        ///  
        /// <para>
        /// The number of managed policies that are attached to IAM users, groups, or roles in
        /// the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>PolicyVersionsInUseQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of managed policies that can be attached to IAM users, groups,
        /// or roles in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Providers</b>
        /// </para>
        ///  
        /// <para>
        /// The number of identity providers in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>RolePolicySizeQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed size for the aggregate of all inline policies (access policies,
        /// not the trust policy) embedded in an IAM role, in non-whitespace characters. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Roles</b>
        /// </para>
        ///  
        /// <para>
        /// The number of IAM roles in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>RolesQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of IAM roles allowed in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>ServerCertificates</b>
        /// </para>
        ///  
        /// <para>
        /// The number of server certificates in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>ServerCertificatesQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of server certificates allowed in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>SigningCertificatesPerUserQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of X.509 signing certificates allowed for each IAM user. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>UserPolicySizeQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed size for the aggregate of all inline policies embedded in an IAM
        /// user, in non-whitespace characters. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Users</b>
        /// </para>
        ///  
        /// <para>
        /// The number of IAM users in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>UsersQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of IAM users allowed in the AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>VersionsPerPolicyQuota</b>
        /// </para>
        ///  
        /// <para>
        /// The maximum number of policy versions allowed for each managed policy. 
        /// </para>
        ///  </li> </ul> 
        /// </para>
        /// </summary>
        public Dictionary<string, int> SummaryMap
        {
            get { return this._summaryMap; }
            set { this._summaryMap = value; }
        }

        // Check to see if SummaryMap property is set
        internal bool IsSetSummaryMap()
        {
            return this._summaryMap != null && this._summaryMap.Count > 0; 
        }

    }
}