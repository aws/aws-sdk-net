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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
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
namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Contains the identifiers for a group, a group member, and a <c>GroupMembership</c>
    /// object in the identity store.
    /// </summary>
    public partial class GroupMembership
    {
        private string _groupId;
        private string _identityStoreId;
        private MemberId _memberId;
        private string _membershipId;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier for a group in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// An object that contains the identifier of a group member. Setting the <c>UserID</c>
        /// field to the specific identifier for a user indicates that the user is a member of
        /// the group.
        /// </para>
        /// </summary>
        public MemberId MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The identifier for a <c>GroupMembership</c> object in an identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

    }
}