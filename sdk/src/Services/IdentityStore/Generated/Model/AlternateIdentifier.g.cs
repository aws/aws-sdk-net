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
    /// A unique identifier for a user or group that is not the primary identifier. This value
    /// can be an identifier from an external identity provider (IdP) that is associated with
    /// the user, the group, or a unique attribute.
    /// </summary>
    public partial class AlternateIdentifier
    {
        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The identifier issued to this resource by an external identity provider.
        /// </para>
        /// </summary>
        public ExternalId ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property UniqueAttribute. 
        /// <para>
        /// An entity attribute that's unique to a specific entity.
        /// </para>
        /// </summary>
        public UniqueAttribute UniqueAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UniqueAttribute property is set.
        /// </summary>
        internal bool IsSetUniqueAttribute() => this.UniqueAttribute != null;
    }
}
