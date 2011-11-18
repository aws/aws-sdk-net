/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetAccountSummary action.</para>
    /// </summary>
    public class GetAccountSummaryResult  
    {
        
        private Dictionary<string,int> summaryMap = new Dictionary<string,int>();

        /// <summary>
        /// A set of key value pairs containing account-level information. <c>SummaryMap</c> contains the following keys: <ul> <li><c>Users</c> - Number
        /// of users for the AWS account</li> <li><c>UsersQuota</c> - Maximum users allowed for the AWS account</li> <li><c>Groups</c> - Number of
        /// Groups for the AWS account</li> <li><c>GroupsQuota</c> - Maximum Groups allowed for the AWS account</li> <li><c>ServerCertificates</c> -
        /// Number of Server Certificates for the AWS account</li> <li><c>ServerCertificatesQuota</c> - Maximum Server Certificates allowed for the AWS
        /// account</li> <li><c>UserPolicySizeQuota</c> - Maximum allowed size for user policy documents (in kilobytes) </li>
        /// <li><c>GroupPolicySizeQuota</c> - Maximum allowed size for Group policy documents (in kilobytes)</li> <li><c>GroupsPerUserQuota</c> -
        /// Maximum number of groups a user can belong to</li> <li><c>SigningCertificatesPerUserQuota</c> - Maximum number of X509 certificates allowed
        /// for a user</li> <li><c>AccessKeysPerUserQuota</c> - Maximum number of access keys that can be created per user</li>
        /// <li><c>MFADevicesInUse</c> - Number of MFA devices that have been assigned to an IAM user or to the root account</li> <li><c>MFADevices</c>
        /// - Number of MFA devices, either assigned or unassigned</li> <li><c>AccountMFAEnabled</c> - 1 if the root account has an MFA device assigned
        /// to it, 0 otherwise</li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,int> SummaryMap
        {
            get { return this.summaryMap; }
            set { this.summaryMap = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the SummaryMap dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the SummaryMap dictionary.</param>
        /// <returns>this instance</returns>
        public GetAccountSummaryResult WithSummaryMap(params KeyValuePair<string, int>[] pairs)
        {
            foreach (KeyValuePair<string, int> pair in pairs)
            {
                this.SummaryMap[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if SummaryMap property is set
        internal bool IsSetSummaryMap()
        {
            return this.summaryMap != null;       
        }
    }
}
