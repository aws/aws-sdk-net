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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// The room membership details.
    /// </summary>
    public partial class RoomMembership
    {
        private string _invitedBy;
        private Member _member;
        private RoomMembershipRole _role;
        private string _roomId;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property InvitedBy. 
        /// <para>
        /// The identifier of the user that invited the room member.
        /// </para>
        /// </summary>
        public string InvitedBy
        {
            get { return this._invitedBy; }
            set { this._invitedBy = value; }
        }

        // Check to see if InvitedBy property is set
        internal bool IsSetInvitedBy()
        {
            return this._invitedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The member details, such as email address, name, member ID, and member type.
        /// </para>
        /// </summary>
        public Member Member
        {
            get { return this._member; }
            set { this._member = value; }
        }

        // Check to see if Member property is set
        internal bool IsSetMember()
        {
            return this._member != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The membership role.
        /// </para>
        /// </summary>
        public RoomMembershipRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property RoomId. 
        /// <para>
        /// The room ID.
        /// </para>
        /// </summary>
        public string RoomId
        {
            get { return this._roomId; }
            set { this._roomId = value; }
        }

        // Check to see if RoomId property is set
        internal bool IsSetRoomId()
        {
            return this._roomId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The room membership update timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}