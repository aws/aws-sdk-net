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
    /// The recommendations that a listing recommendations control produced. Exactly one member
    /// is set, corresponding to the control: content recommendations for a product, content
    /// recommendations for a solution, or feature recommendations.
    /// </summary>
    public partial class ListingRecommendations
    {
        /// <summary>
        /// Gets and sets the property FeatureRecommendations. 
        /// <para>
        /// The recommendations for AWS Marketplace features to use with the listing, for a product
        /// or a solution.
        /// </para>
        /// </summary>
        public FeatureRecommendations FeatureRecommendations { get; set; }

        /// <summary>
        /// Checks to see if the FeatureRecommendations property is set.
        /// </summary>
        internal bool IsSetFeatureRecommendations() => this.FeatureRecommendations != null;

        /// <summary>
        /// Gets and sets the property ProductContentRecommendations. 
        /// <para>
        /// The content recommendations for a product listing.
        /// </para>
        /// </summary>
        public ProductContentRecommendations ProductContentRecommendations { get; set; }

        /// <summary>
        /// Checks to see if the ProductContentRecommendations property is set.
        /// </summary>
        internal bool IsSetProductContentRecommendations() => this.ProductContentRecommendations != null;

        /// <summary>
        /// Gets and sets the property SolutionContentRecommendations. 
        /// <para>
        /// The content recommendations for a solution listing.
        /// </para>
        /// </summary>
        public SolutionContentRecommendations SolutionContentRecommendations { get; set; }

        /// <summary>
        /// Checks to see if the SolutionContentRecommendations property is set.
        /// </summary>
        internal bool IsSetSolutionContentRecommendations() => this.SolutionContentRecommendations != null;
    }
}
