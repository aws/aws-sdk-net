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
    /// The details about a member account.
    /// </summary>
    public partial class Member
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the member account.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The Amazon Web Services account ID of the Security Hub CSPM administrator account
        /// associated with this member account.
        /// </para>
        /// </summary>
        public string AdministratorId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorId property is set.
        /// </summary>
        internal bool IsSetAdministratorId() => this.AdministratorId != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the member account.
        /// </para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property InvitedAt. 
        /// <para>
        /// A timestamp for the date and time when the invitation was sent to the member account.
        /// </para>
        /// </summary>
        public DateTime? InvitedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvitedAt property is set.
        /// </summary>
        internal bool IsSetInvitedAt() => this.InvitedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MasterId. 
        /// <para>
        /// This is replaced by <c>AdministratorID</c>.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services account ID of the Security Hub CSPM administrator account
        /// associated with this member account.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use AdministratorId instead.")]
        public string MasterId { get; set; }

        /// <summary>
        /// Checks to see if the MasterId property is set.
        /// </summary>
        internal bool IsSetMasterId() => this.MasterId != null;

        /// <summary>
        /// Gets and sets the property MemberStatus. 
        /// <para>
        /// The status of the relationship between the member account and its administrator account.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The status can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Created</c> - Indicates that the administrator account added the member account,
        /// but has not yet invited the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Invited</c> - Indicates that the administrator account invited the member account.
        /// The member account has not yet responded to the invitation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Enabled</c> - Indicates that the member account is currently active. For manually
        /// invited member accounts, indicates that the member account accepted the invitation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removed</c> - Indicates that the administrator account disassociated the member
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Resigned</c> - Indicates that the member account disassociated themselves from
        /// the administrator account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleted</c> - Indicates that the administrator account deleted the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountSuspended</c> - Indicates that an organization account was suspended from
        /// Amazon Web Services at the same time that the administrator account tried to enable
        /// the organization account as a member account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MemberStatus { get; set; }

        /// <summary>
        /// Checks to see if the MemberStatus property is set.
        /// </summary>
        internal bool IsSetMemberStatus() => this.MemberStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp for the date and time when the member account was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
