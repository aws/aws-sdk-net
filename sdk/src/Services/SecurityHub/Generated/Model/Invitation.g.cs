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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Details about an invitation.
    /// </summary>
    public partial class Invitation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the Security Hub CSPM administrator account that the invitation
        /// was sent from.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The ID of the invitation sent to the member account.
        /// </para>
        /// </summary>
        public string InvitationId { get; set; }

        /// <summary>
        /// Checks to see if the InvitationId property is set.
        /// </summary>
        internal bool IsSetInvitationId() => this.InvitationId != null;

        /// <summary>
        /// Gets and sets the property InvitedAt. 
        /// <para>
        /// The timestamp of when the invitation was sent.
        /// </para>
        /// </summary>
        public DateTime? InvitedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvitedAt property is set.
        /// </summary>
        internal bool IsSetInvitedAt() => this.InvitedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MemberStatus. 
        /// <para>
        /// The current status of the association between the member and administrator accounts.
        /// </para>
        /// </summary>
        public string MemberStatus { get; set; }

        /// <summary>
        /// Checks to see if the MemberStatus property is set.
        /// </summary>
        internal bool IsSetMemberStatus() => this.MemberStatus != null;
    }
}
