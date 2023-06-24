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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Indicates whether a resource is a member of a group in the identity store.
    /// </summary>
    public partial class GroupMembershipExistenceResult
    {
        private string _groupId;
        private MemberId _memberId;
        private bool? _membershipExists;

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
        /// Gets and sets the property MemberId. 
        /// <para>
        /// An object that contains the identifier of a group member. Setting the <code>UserID</code>
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
        /// Gets and sets the property MembershipExists. 
        /// <para>
        /// Indicates whether a membership relation exists or not.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool MembershipExists
        {
            get { return this._membershipExists.GetValueOrDefault(); }
            set { this._membershipExists = value; }
        }

        // Check to see if MembershipExists property is set
        internal bool IsSetMembershipExists()
        {
            return this._membershipExists.HasValue; 
        }

    }
}