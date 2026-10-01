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
    /// Container for the parameters to the DeleteUser operation.
    /// Deletes a user within an identity store given <c>UserId</c>.
    /// </summary>
    public partial class DeleteUserRequest : AmazonIdentityStoreRequest
    {
        private string _identityStoreId;
        private string _revision;
        private string _userId;

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
        [AWSProperty(Required=true, Min=1, Max=93)]
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
        /// Gets and sets the property Revision. 
        /// <para>
        /// The expected current revision of the user. When you provide this value, the user is
        /// deleted only if it matches the current revision of the user in the identity store.
        /// If the value doesn't match, the operation fails with a <c>ConflictException</c>. If
        /// you don't provide this value, the user is deleted regardless of its current revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for a user in the identity store.
        /// </para>
        ///  
        /// <para>
        /// You can specify the user by ID or by Amazon Resource Name (ARN). For example, user
        /// ID <c>a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c> or user ARN <c>arn:aws:identitystore:::user/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}