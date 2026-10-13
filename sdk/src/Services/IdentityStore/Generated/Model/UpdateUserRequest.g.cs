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
    /// Container for the parameters to the UpdateUser operation. Updates the specified user
    /// metadata and attributes in the specified identity store.
    /// </summary>
    public partial class UpdateUserRequest : AmazonIdentityStoreRequest
    {
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
        /// Gets and sets the property Operations. 
        /// <para>
        /// A list of <c>AttributeOperation</c> objects to apply to the requested user. These
        /// operations might add, replace, or remove an attribute. For more information on the
        /// attributes that can be added, replaced, or removed, see <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_User.html">User</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<AttributeOperation> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeOperation>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The expected current revision of the user. When you provide this value, the update
        /// is applied only if it matches the current revision of the user in the identity store,
        /// which prevents you from overwriting concurrent changes. If the value doesn't match,
        /// the operation fails with a <c>ConflictException</c>. If you don't provide this value,
        /// the update is applied unconditionally.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
