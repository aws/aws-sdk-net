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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A facet value with display information and a count of matching listings. Used to build
    /// filter and browse experiences.
    /// </summary>
    public partial class ListingFacet
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of listings matching this facet value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name of the facet value, suitable for display in a user interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Parent. 
        /// <para>
        /// The parent facet value for hierarchical facets, such as subcategories.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Parent { get; set; }

        /// <summary>
        /// Checks to see if the Parent property is set.
        /// </summary>
        internal bool IsSetParent() => this.Parent != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The internal value used for filtering when passed back in a search filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
