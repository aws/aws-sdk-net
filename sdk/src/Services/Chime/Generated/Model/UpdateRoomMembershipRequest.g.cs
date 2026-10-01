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
    /// Container for the parameters to the UpdateRoomMembership operation. Updates room membership
    /// details, such as the member role, for a room in an Amazon Chime Enterprise account.
    /// The member role designates whether the member is a chat room administrator or a general
    /// chat room member. The member role can be updated only for user IDs.
    /// </summary>
    public partial class UpdateRoomMembershipRequest : AmazonChimeRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The member ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the member.
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
        [AWSProperty(Required = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// Checks to see if the RoomId property is set.
        /// </summary>
        internal bool IsSetRoomId() => this.RoomId != null;
    }
}
