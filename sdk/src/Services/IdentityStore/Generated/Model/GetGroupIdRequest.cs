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
    /// Container for the parameters to the GetGroupId operation.
    /// Retrieves <code>GroupId</code> in an identity store.
    /// </summary>
    public partial class GetGroupIdRequest : AmazonIdentityStoreRequest
    {
        private AlternateIdentifier _alternateIdentifier;
        private string _identityStoreId;

        /// <summary>
        /// Gets and sets the property AlternateIdentifier. 
        /// <para>
        /// A unique identifier for a user or group that is not the primary identifier. This value
        /// can be an identifier from an external identity provider (IdP) that is associated with
        /// the user, the group, or a unique attribute. For the unique attribute, the only valid
        /// path is <code>displayName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlternateIdentifier AlternateIdentifier
        {
            get { return this._alternateIdentifier; }
            set { this._alternateIdentifier = value; }
        }

        // Check to see if AlternateIdentifier property is set
        internal bool IsSetAlternateIdentifier()
        {
            return this._alternateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
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

    }
}