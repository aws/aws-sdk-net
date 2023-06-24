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
    /// The details about a member account.
    /// </summary>
    public partial class Member
    {
        private string _accountId;
        private string _administratorId;
        private string _email;
        private DateTime? _invitedAt;
        private string _masterId;
        private string _memberStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the member account.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The Amazon Web Services account ID of the Security Hub administrator account associated
        /// with this member account.
        /// </para>
        /// </summary>
        public string AdministratorId
        {
            get { return this._administratorId; }
            set { this._administratorId = value; }
        }

        // Check to see if AdministratorId property is set
        internal bool IsSetAdministratorId()
        {
            return this._administratorId != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the member account.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property InvitedAt. 
        /// <para>
        /// A timestamp for the date and time when the invitation was sent to the member account.
        /// </para>
        /// </summary>
        public DateTime InvitedAt
        {
            get { return this._invitedAt.GetValueOrDefault(); }
            set { this._invitedAt = value; }
        }

        // Check to see if InvitedAt property is set
        internal bool IsSetInvitedAt()
        {
            return this._invitedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterId. 
        /// <para>
        /// This is replaced by <code>AdministratorID</code>.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services account ID of the Security Hub administrator account associated
        /// with this member account.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use AdministratorId instead.")]
        public string MasterId
        {
            get { return this._masterId; }
            set { this._masterId = value; }
        }

        // Check to see if MasterId property is set
        internal bool IsSetMasterId()
        {
            return this._masterId != null;
        }

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
        ///  <code>Created</code> - Indicates that the administrator account added the member
        /// account, but has not yet invited the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invited</code> - Indicates that the administrator account invited the member
        /// account. The member account has not yet responded to the invitation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Enabled</code> - Indicates that the member account is currently active. For
        /// manually invited member accounts, indicates that the member account accepted the invitation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removed</code> - Indicates that the administrator account disassociated the
        /// member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Resigned</code> - Indicates that the member account disassociated themselves
        /// from the administrator account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deleted</code> - Indicates that the administrator account deleted the member
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccountSuspended</code> - Indicates that an organization account was suspended
        /// from Amazon Web Services at the same time that the administrator account tried to
        /// enable the organization account as a member account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MemberStatus
        {
            get { return this._memberStatus; }
            set { this._memberStatus = value; }
        }

        // Check to see if MemberStatus property is set
        internal bool IsSetMemberStatus()
        {
            return this._memberStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp for the date and time when the member account was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}