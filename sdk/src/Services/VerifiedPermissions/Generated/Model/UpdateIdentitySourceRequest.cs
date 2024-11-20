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
    /// Container for the parameters to the UpdateIdentitySource operation.
    /// Updates the specified identity source to use a new identity provider (IdP), or to
    /// change the mapping of identities from the IdP to a different principal entity type.
    /// 
    ///  <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateIdentitySourceRequest : AmazonVerifiedPermissionsRequest
    {
        private string _identitySourceId;
        private string _policyStoreId;
        private string _principalEntityType;
        private UpdateConfiguration _updateConfiguration;

        /// <summary>
        /// Gets and sets the property IdentitySourceId. 
        /// <para>
        /// Specifies the ID of the identity source that you want to update.
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
        /// to update.
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

        /// <summary>
        /// Gets and sets the property PrincipalEntityType. 
        /// <para>
        /// Specifies the data type of principals generated for identities authenticated by the
        /// identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string PrincipalEntityType
        {
            get { return this._principalEntityType; }
            set { this._principalEntityType = value; }
        }

        // Check to see if PrincipalEntityType property is set
        internal bool IsSetPrincipalEntityType()
        {
            return this._principalEntityType != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateConfiguration. 
        /// <para>
        /// Specifies the details required to communicate with the identity provider (IdP) associated
        /// with this identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateConfiguration UpdateConfiguration
        {
            get { return this._updateConfiguration; }
            set { this._updateConfiguration = value; }
        }

        // Check to see if UpdateConfiguration property is set
        internal bool IsSetUpdateConfiguration()
        {
            return this._updateConfiguration != null;
        }

    }
}