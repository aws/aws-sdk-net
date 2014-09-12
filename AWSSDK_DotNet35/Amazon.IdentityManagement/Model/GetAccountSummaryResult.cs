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
    public partial class GetAccountSummaryResult : AmazonWebServiceResponse
    {
        private Dictionary<string, int> _summaryMap = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property SummaryMap. 
        /// <para>
        /// A set of key value pairs containing account-level information.
        /// </para>
        ///  
        /// <para>
        ///  <code>SummaryMap</code> contains the following keys: <ul> <li>
        /// <para>
        /// <code>AccessKeysPerUserQuota</code> - Maximum number of access keys that can be created
        /// per user
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>AccountMFAEnabled</code> - 1 if the root account has an MFA device assigned
        /// to it, 0 otherwise
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>AssumeRolePolicySizeQuota</code> - Maximum allowed size for assume role policy
        /// documents (in kilobytes) 
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupPolicySizeQuota</code> - Maximum allowed size for Group policy documents
        /// (in kilobytes)
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Groups</code> - Number of Groups for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupsPerUserQuota</code> - Maximum number of groups a user can belong to
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupsQuota</code> - Maximum groups allowed for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>InstanceProfiles</code> - Number of instance profiles for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>InstanceProfilesQuota</code> - Maximum instance profiles allowed for the AWS
        /// account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>MFADevices</code> - Number of MFA devices, either assigned or unassigned
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>MFADevicesInUse</code> - Number of MFA devices that have been assigned to an
        /// IAM user or to the root account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>RolePolicySizeQuota</code> - Maximum allowed size for role policy documents
        /// (in kilobytes) 
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Roles</code> - Number of roles for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>RolesQuota</code> - Maximum roles allowed for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>ServerCertificates</code> - Number of server certificates for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>ServerCertificatesQuota</code> - Maximum server certificates allowed for the
        /// AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>SigningCertificatesPerUserQuota</code> - Maximum number of X509 certificates
        /// allowed for a user
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>UserPolicySizeQuota</code> - Maximum allowed size for user policy documents
        /// (in kilobytes) 
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Users</code> - Number of users for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>UsersQuota</code> - Maximum users allowed for the AWS account
        /// </para>
        /// </li> </ul> 
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