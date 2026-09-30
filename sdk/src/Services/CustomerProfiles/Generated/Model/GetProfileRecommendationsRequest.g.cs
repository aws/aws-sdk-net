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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the GetProfileRecommendations operation. Fetches the
    /// recommendations for a profile in the input Customer Profiles domain. Fetches all the
    /// profile recommendations
    /// </summary>
    public partial class GetProfileRecommendationsRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property CandidateIds. 
        /// <para>
        /// A list of item IDs to rank for the user. Use this when you want to re-rank a specific
        /// set of items rather than getting recommendations from the full item catalog. Required
        /// for personalized-ranking use cases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> CandidateIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CandidateIds property is set.
        /// </summary>
        internal bool IsSetCandidateIds() => this.CandidateIds != null && (this.CandidateIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The contextual metadata used to provide dynamic runtime information to tailor recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Context { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null && (this.Context.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DiversityConfig. 
        /// <para>
        /// Runtime diversity configuration for this request. Enables diversity-aware recommendations
        /// and optionally supplies values for placeholder-based diversity caps configured on
        /// the recommender.
        /// </para>
        /// </summary>
        public RecommendationDiversityConfig DiversityConfig { get; set; }

        /// <summary>
        /// Checks to see if the DiversityConfig property is set.
        /// </summary>
        internal bool IsSetDiversityConfig() => this.DiversityConfig != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendations to return. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataConfig. 
        /// <para>
        /// Configuration for including item metadata in the recommendation response. Use this
        /// to specify which metadata columns to return alongside recommended items.
        /// </para>
        /// </summary>
        public MetadataConfig MetadataConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetadataConfig property is set.
        /// </summary>
        internal bool IsSetMetadataConfig() => this.MetadataConfig != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile for which to retrieve recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property RecommenderFilters. 
        /// <para>
        /// A list of filters to apply to the returned recommendations. Filters define criteria
        /// for including or excluding items from the recommendation results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<RecommenderFilter> RecommenderFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommenderFilter>() : null;

        /// <summary>
        /// Checks to see if the RecommenderFilters property is set.
        /// </summary>
        internal bool IsSetRecommenderFilters() => this.RecommenderFilters != null && (this.RecommenderFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommenderName. 
        /// <para>
        /// The unique name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecommenderName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderName property is set.
        /// </summary>
        internal bool IsSetRecommenderName() => this.RecommenderName != null;

        /// <summary>
        /// Gets and sets the property RecommenderPromotionalFilters. 
        /// <para>
        /// A list of promotional filters to apply to the recommendations. Promotional filters
        /// allow you to promote specific items within a configurable subset of recommendation
        /// results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<RecommenderPromotionalFilter> RecommenderPromotionalFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommenderPromotionalFilter>() : null;

        /// <summary>
        /// Checks to see if the RecommenderPromotionalFilters property is set.
        /// </summary>
        internal bool IsSetRecommenderPromotionalFilters() => this.RecommenderPromotionalFilters != null && (this.RecommenderPromotionalFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
