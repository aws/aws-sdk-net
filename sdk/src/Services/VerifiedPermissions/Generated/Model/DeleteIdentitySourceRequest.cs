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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIdentitySource operation.
    /// Deletes an identity source that references an identity provider (IdP) such as Amazon
    /// Cognito. After you delete the identity source, you can no longer use tokens for identities
    /// from that identity source to represent principals in authorization queries made using
    /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>.
    /// operations.
    /// </summary>
    public partial class DeleteIdentitySourceRequest : AmazonVerifiedPermissionsRequest
    {
        private string _identitySourceId;
        private string _policyStoreId;

        /// <summary>
        /// Gets and sets the property IdentitySourceId. 
        /// <para>
        /// Specifies the ID of the identity source that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string IdentitySourceId
        {
            get { return this._identitySourceId; }
            set { this._identitySourceId = value; }
        }

        // Check to see if IdentitySourceId property is set
        internal bool IsSetIdentitySourceId()
        {
            return this._identitySourceId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store that contains the identity source that you want
        /// to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

    }
}