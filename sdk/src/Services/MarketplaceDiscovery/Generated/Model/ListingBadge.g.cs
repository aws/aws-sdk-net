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
    /// A badge indicating a special attribute of a listing, such as free tier eligibility
    /// or Quick Launch support.
    /// </summary>
    public partial class ListingBadge
    {
        /// <summary>
        /// Gets and sets the property BadgeType. 
        /// <para>
        /// The machine-readable type of the badge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ListingBadgeType BadgeType { get; set; }

        /// <summary>
        /// Checks to see if the BadgeType property is set.
        /// </summary>
        internal bool IsSetBadgeType() => this.BadgeType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name of the badge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;
    }
}
