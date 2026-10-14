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
    /// Container for the parameters to the CreateGroupMembership operation. Creates a relationship
    /// between a member and a group. The following identifiers must be specified: <c>GroupId</c>,
    /// <c>IdentityStoreId</c>, and <c>MemberId</c>.
    /// </summary>
    public partial class CreateGroupMembershipRequest : AmazonIdentityStoreRequest
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier for a group in the identity store.
        /// </para>
        ///  
        /// <para>
        /// You can specify the group by ID or by Amazon Resource Name (ARN). For example, group
        /// ID <c>a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c> or group ARN <c>arn:aws:identitystore:::group/a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        ///  
        /// <para>
        /// You can specify the identity store by ID or by Amazon Resource Name (ARN). For example,
        /// identity store ID <c>d-1234567890</c> or identity store ARN <c>arn:aws:identitystore::111122223333:identitystore/d-1234567890</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 93)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// An object that contains the identifier of a group member. Setting the <c>UserID</c>
        /// field to the specific identifier for a user indicates that the user is a member of
        /// the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemberId MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;
    }
}
