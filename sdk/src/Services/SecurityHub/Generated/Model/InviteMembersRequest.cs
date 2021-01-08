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
    /// Container for the parameters to the InviteMembers operation.
    /// Invites other AWS accounts to become member accounts for the Security Hub master account
    /// that the invitation is sent from.
    /// 
    ///  
    /// <para>
    /// This operation is only used to invite accounts that do not belong to an organization.
    /// Organization accounts do not receive invitations.
    /// </para>
    ///  
    /// <para>
    /// Before you can use this action to invite a member, you must first use the <code> <a>CreateMembers</a>
    /// </code> action to create the member account in Security Hub.
    /// </para>
    ///  
    /// <para>
    /// When the account owner enables Security Hub and accepts the invitation to become a
    /// member account, the master account can view the findings generated from the member
    /// account.
    /// </para>
    /// </summary>
    public partial class InviteMembersRequest : AmazonSecurityHubRequest
    {
        private List<string> _accountIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The list of account IDs of the AWS accounts to invite to Security Hub as members.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

    }
}