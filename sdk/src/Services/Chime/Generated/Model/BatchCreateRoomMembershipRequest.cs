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
    /// Container for the parameters to the BatchCreateRoomMembership operation.
    /// Adds up to 50 members to a chat room in an Amazon Chime Enterprise account. Members
    /// can be users or bots. The member role designates whether the member is a chat room
    /// administrator or a general chat room member.
    /// </summary>
    public partial class BatchCreateRoomMembershipRequest : AmazonChimeRequest
    {
        private string _accountId;
        private List<MembershipItem> _membershipItemList = AWSConfigs.InitializeCollections ? new List<MembershipItem>() : null;
        private string _roomId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MembershipItemList. 
        /// <para>
        /// The list of membership items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public List<MembershipItem> MembershipItemList
        {
            get { return this._membershipItemList; }
            set { this._membershipItemList = value; }
        }

        // Check to see if MembershipItemList property is set
        internal bool IsSetMembershipItemList()
        {
            return this._membershipItemList != null && (this._membershipItemList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoomId. 
        /// <para>
        /// The room ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}