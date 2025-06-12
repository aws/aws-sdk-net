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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the InviteMembers operation.
    /// <note> 
    /// <para>
    /// We recommend using Organizations instead of Security Hub invitations to manage your
    /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
    /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
    /// Hub User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Invites other Amazon Web Services accounts to become member accounts for the Security
    /// Hub administrator account that the invitation is sent from.
    /// </para>
    ///  
    /// <para>
    /// This operation is only used to invite accounts that don't belong to an Amazon Web
    /// Services organization. Organization accounts don't receive invitations.
    /// </para>
    ///  
    /// <para>
    /// Before you can use this action to invite a member, you must first use the <c>CreateMembers</c>
    /// action to create the member account in Security Hub.
    /// </para>
    ///  
    /// <para>
    /// When the account owner enables Security Hub and accepts the invitation to become a
    /// member account, the administrator account can view the findings generated in the member
    /// account.
    /// </para>
    /// </summary>
    public partial class InviteMembersRequest : AmazonSecurityHubRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The list of account IDs of the Amazon Web Services accounts to invite to Security
        /// Hub as members. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}