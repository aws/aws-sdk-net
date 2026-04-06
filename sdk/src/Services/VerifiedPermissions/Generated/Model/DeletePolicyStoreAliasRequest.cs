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
    /// Container for the parameters to the DeletePolicyStoreAlias operation.
    /// Deletes the specified policy store alias.
    /// 
    ///  
    /// <para>
    /// This operation is idempotent. If you specify a policy store alias that does not exist,
    /// the request response will still return a successful HTTP 200 status code.
    /// </para>
    ///  
    /// <para>
    /// When a policy store alias is deleted, it enters the <c>PendingDeletion</c> state.
    /// When a policy store alias is in the <c>PendingDeletion</c> state, new policy store
    /// aliases cannot be created with the same name. If the policy store alias is used in
    /// an API that has a <c>policyStoreId</c> field, the operation will fail with a <c>ResourceNotFound</c>
    /// exception.
    /// </para>
    /// </summary>
    public partial class DeletePolicyStoreAliasRequest : AmazonVerifiedPermissionsRequest
    {
        private string _aliasName;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// Specifies the name of the policy store alias that you want to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// The alias name must always be prefixed with <c>policy-store-alias/</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

    }
}