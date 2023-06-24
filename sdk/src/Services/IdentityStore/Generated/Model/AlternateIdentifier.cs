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
    /// A unique identifier for a user or group that is not the primary identifier. This value
    /// can be an identifier from an external identity provider (IdP) that is associated with
    /// the user, the group, or a unique attribute.
    /// </summary>
    public partial class AlternateIdentifier
    {
        private ExternalId _externalId;
        private UniqueAttribute _uniqueAttribute;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The identifier issued to this resource by an external identity provider.
        /// </para>
        /// </summary>
        public ExternalId ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueAttribute. 
        /// <para>
        /// An entity attribute that's unique to a specific entity.
        /// </para>
        /// </summary>
        public UniqueAttribute UniqueAttribute
        {
            get { return this._uniqueAttribute; }
            set { this._uniqueAttribute = value; }
        }

        // Check to see if UniqueAttribute property is set
        internal bool IsSetUniqueAttribute()
        {
            return this._uniqueAttribute != null;
        }

    }
}