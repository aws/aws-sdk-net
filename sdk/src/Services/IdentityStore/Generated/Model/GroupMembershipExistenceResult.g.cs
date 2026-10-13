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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Indicates whether a resource is a member of a group in the identity store.
    /// </summary>
    public partial class GroupMembershipExistenceResult
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier for a group in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// An object that contains the identifier of a group member. Setting the <c>UserID</c>
        /// field to the specific identifier for a user indicates that the user is a member of
        /// the group.
        /// </para>
        /// </summary>
        public MemberId MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;

        /// <summary>
        /// Gets and sets the property MembershipExists. 
        /// <para>
        /// Indicates whether a membership relation exists or not.
        /// </para>
        /// </summary>
        public bool? MembershipExists { get; set; }

        /// <summary>
        /// Checks to see if the MembershipExists property is set.
        /// </summary>
        internal bool IsSetMembershipExists() => this.MembershipExists.HasValue;
    }
}
