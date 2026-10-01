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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Object containing all the filter fields for container products. Client can add only
    /// one wildcard filter and a maximum of 8 filters in a single <c>ListEntities</c> request.
    /// </summary>
    public partial class ContainerProductFilters
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Unique identifier for the container product.
        /// </para>
        /// </summary>
        public ContainerProductEntityIdFilter EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last date on which the container product was modified.
        /// </para>
        /// </summary>
        public ContainerProductLastModifiedDateFilter LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property ProductTitle. 
        /// <para>
        /// The title of the container product.
        /// </para>
        /// </summary>
        public ContainerProductTitleFilter ProductTitle { get; set; }

        /// <summary>
        /// Checks to see if the ProductTitle property is set.
        /// </summary>
        internal bool IsSetProductTitle() => this.ProductTitle != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the container product.
        /// </para>
        /// </summary>
        public ContainerProductVisibilityFilter Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
