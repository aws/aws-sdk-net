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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The listing of the asset in a data product.
    /// </summary>
    public partial class AssetInDataProductListingItem
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The entity ID of the listing of the asset in a data product.
        /// </para>
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The entity revision of the listing of the asset in a data product.
        /// </para>
        /// </summary>
        public string EntityRevision { get; set; }

        /// <summary>
        /// Checks to see if the EntityRevision property is set.
        /// </summary>
        internal bool IsSetEntityRevision() => this.EntityRevision != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The entity type of the listing of the asset in a data product.
        /// </para>
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;
    }
}
