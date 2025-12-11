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
    /// Container for the parameters to the DescribeUser operation.
    /// Retrieves the user metadata and attributes from the <c>UserId</c> in an identity store.
    /// 
    ///  <note> 
    /// <para>
    /// If you have access to a member account, you can use this API operation from the member
    /// account. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/manage-your-accounts.html#limiting-access-from-member-accounts">Limiting
    /// access to the identity store from member accounts</a> in the <i> IAM Identity Center
    /// User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeUserRequest : AmazonIdentityStoreRequest
    {
        private List<string> _extensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identityStoreId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// A collection of extension names indicating what extensions the service should retrieve
        /// alongside other user attributes. <c>aws:identitystore:enterprise</c> is the only supported
        /// extension name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }

        // Check to see if Extensions property is set
        internal bool IsSetExtensions()
        {
            return this._extensions != null && (this._extensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store, such as <c>d-1234567890</c>.
        /// In this example, <c>d-</c> is a fixed prefix, and <c>1234567890</c> is a randomly
        /// generated string that contains numbers and lower case letters. This value is generated
        /// at the time that a new identity store is created.
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for a user in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=47)]
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