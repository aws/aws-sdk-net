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
    /// Container for the parameters to the CreatePolicyStoreAlias operation.
    /// Creates a policy store alias for the specified policy store. A policy store alias
    /// is an alternative identifier that you can use to reference a policy store in API operations.
    /// 
    ///  
    /// <para>
    /// This operation is idempotent. If multiple CreatePolicyStoreAlias requests are made
    /// where the <c>aliasName</c> and <c>policyStoreId</c> fields are the same between the
    /// requests, subsequent requests will be ignored. For each duplicate CreatePolicyStoreAlias
    /// request, a Success response will be returned and a new policy store alias will not
    /// be created.
    /// </para>
    ///  <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePolicyStoreAliasRequest : AmazonVerifiedPermissionsRequest
    {
        private string _aliasName;
        private string _policyStoreId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// Specifies the name of the policy store alias to create. The name must be unique within
        /// your Amazon Web Services account and Amazon Web Services Region.
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

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store to associate with the alias.
        /// </para>
        ///  <note> 
        /// <para>
        /// The associated policy store must be specified using its ID. The alias name cannot
        /// be used.
        /// </para>
        ///  </note>
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