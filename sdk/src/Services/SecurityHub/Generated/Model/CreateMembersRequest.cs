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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMembers operation.
    /// Creates a member association in Security Hub between the specified accounts and the
    /// account used to make the request, which is the master account. If you are integrated
    /// with Organizations, then the master account is the Security Hub administrator account
    /// that is designated by the organization management account.
    /// 
    ///  
    /// <para>
    ///  <code>CreateMembers</code> is always used to add accounts that are not organization
    /// members.
    /// </para>
    ///  
    /// <para>
    /// For accounts that are part of an organization, <code>CreateMembers</code> is only
    /// used in the following cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Security Hub is not configured to automatically add new accounts in an organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The account was disassociated or deleted in Security Hub.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This action can only be used by an account that has Security Hub enabled. To enable
    /// Security Hub, you can use the <code> <a>EnableSecurityHub</a> </code> operation.
    /// </para>
    ///  
    /// <para>
    /// For accounts that are not organization members, you create the account association
    /// and then send an invitation to the member account. To send the invitation, you use
    /// the <code> <a>InviteMembers</a> </code> operation. If the account owner accepts the
    /// invitation, the account becomes a member account in Security Hub.
    /// </para>
    ///  
    /// <para>
    /// Accounts that are part of an organization do not receive an invitation. They automatically
    /// become a member account in Security Hub.
    /// </para>
    ///  
    /// <para>
    /// A permissions policy is added that permits the master account to view the findings
    /// generated in the member account. When Security Hub is enabled in a member account,
    /// findings are sent to both the member and master accounts. 
    /// </para>
    ///  
    /// <para>
    /// To remove the association between the master and member accounts, use the <code> <a>DisassociateFromMasterAccount</a>
    /// </code> or <code> <a>DisassociateMembers</a> </code> operation.
    /// </para>
    /// </summary>
    public partial class CreateMembersRequest : AmazonSecurityHubRequest
    {
        private List<AccountDetails> _accountDetails = new List<AccountDetails>();

        /// <summary>
        /// Gets and sets the property AccountDetails. 
        /// <para>
        /// The list of accounts to associate with the Security Hub master account. For each account,
        /// the list includes the account ID and optionally the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AccountDetails> AccountDetails
        {
            get { return this._accountDetails; }
            set { this._accountDetails = value; }
        }

        // Check to see if AccountDetails property is set
        internal bool IsSetAccountDetails()
        {
            return this._accountDetails != null && this._accountDetails.Count > 0; 
        }

    }
}