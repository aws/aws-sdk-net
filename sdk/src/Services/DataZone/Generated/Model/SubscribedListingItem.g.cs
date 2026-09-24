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
    /// The published asset for which the subscription grant is created.
    /// </summary>
    public partial class SubscribedListingItem
    {
        /// <summary>
        /// Gets and sets the property AssetListing. 
        /// <para>
        /// The asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public SubscribedAssetListing AssetListing { get; set; }

        /// <summary>
        /// Checks to see if the AssetListing property is set.
        /// </summary>
        internal bool IsSetAssetListing() => this.AssetListing != null;

        /// <summary>
        /// Gets and sets the property ProductListing. 
        /// <para>
        /// The data product listing.
        /// </para>
        /// </summary>
        public SubscribedProductListing ProductListing { get; set; }

        /// <summary>
        /// Checks to see if the ProductListing property is set.
        /// </summary>
        internal bool IsSetProductListing() => this.ProductListing != null;
    }
}
