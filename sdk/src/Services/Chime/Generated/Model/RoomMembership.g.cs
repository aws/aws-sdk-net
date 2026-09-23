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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The room membership details.
    /// </summary>
    public partial class RoomMembership
    {
        /// <summary>
        /// Gets and sets the property InvitedBy. 
        /// <para>
        /// The identifier of the user that invited the room member.
        /// </para>
        /// </summary>
        public string InvitedBy { get; set; }

        /// <summary>
        /// Checks to see if the InvitedBy property is set.
        /// </summary>
        internal bool IsSetInvitedBy() => this.InvitedBy != null;

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The member details, such as email address, name, member ID, and member type.
        /// </para>
        /// </summary>
        public Member Member { get; set; }

        /// <summary>
        /// Checks to see if the Member property is set.
        /// </summary>
        internal bool IsSetMember() => this.Member != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The membership role.
        /// </para>
        /// </summary>
        public RoomMembershipRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property RoomId. 
        /// <para>
        /// The room ID.
        /// </para>
        /// </summary>
        public string RoomId { get; set; }

        /// <summary>
        /// Checks to see if the RoomId property is set.
        /// </summary>
        internal bool IsSetRoomId() => this.RoomId != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The room membership update timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
