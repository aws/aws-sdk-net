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
    /// The details of the resource assessed under the Listing Quality framework.
    /// </summary>
    public partial class ListingQualitySummary
    {
        /// <summary>
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The revision of the entity that the tier was evaluated against. To check whether the
        /// tier is out of date, compare this value with the current revision of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityRevision { get; set; }

        /// <summary>
        /// Checks to see if the EntityRevision property is set.
        /// </summary>
        internal bool IsSetEntityRevision() => this.EntityRevision != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The quality tier of the listing. Valid values are <c>NEEDS_IMPROVEMENT</c>, <c>BASIC</c>,
        /// <c>STRONG</c>, and <c>EXCELLENT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ListingQualityTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
