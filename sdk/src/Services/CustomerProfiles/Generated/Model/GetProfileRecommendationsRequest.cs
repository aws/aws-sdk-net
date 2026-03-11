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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
    /// Container for the parameters to the GetProfileRecommendations operation.
    /// Fetches the recommendations for a profile in the input Customer Profiles domain. Fetches
    /// all the profile recommendations
    /// </summary>
    public partial class GetProfileRecommendationsRequest : AmazonCustomerProfilesRequest
    {
        private List<string> _candidateIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _domainName;
        private int? _maxResults;
        private MetadataConfig _metadataConfig;
        private string _profileId;
        private List<RecommenderFilter> _recommenderFilters = AWSConfigs.InitializeCollections ? new List<RecommenderFilter>() : null;
        private string _recommenderName;
        private List<RecommenderPromotionalFilter> _recommenderPromotionalFilters = AWSConfigs.InitializeCollections ? new List<RecommenderPromotionalFilter>() : null;

        /// <summary>
        /// Gets and sets the property CandidateIds. 
        /// <para>
        /// A list of item IDs to rank for the user. Use this when you want to re-rank a specific
        /// set of items rather than getting recommendations from the full item catalog. Required
        /// for personalized-ranking use cases.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> CandidateIds
        {
            get { return this._candidateIds; }
            set { this._candidateIds = value; }
        }

        // Check to see if CandidateIds property is set
        internal bool IsSetCandidateIds()
        {
            return this._candidateIds != null && (this._candidateIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The contextual metadata used to provide dynamic runtime information to tailor recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && (this._context.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendations to return. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataConfig. 
        /// <para>
        /// Configuration for including item metadata in the recommendation response. Use this
        /// to specify which metadata columns to return alongside recommended items.
        /// </para>
        /// </summary>
        public MetadataConfig MetadataConfig
        {
            get { return this._metadataConfig; }
            set { this._metadataConfig = value; }
        }

        // Check to see if MetadataConfig property is set
        internal bool IsSetMetadataConfig()
        {
            return this._metadataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile for which to retrieve recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderFilters. 
        /// <para>
        /// A list of filters to apply to the returned recommendations. Filters define criteria
        /// for including or excluding items from the recommendation results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<RecommenderFilter> RecommenderFilters
        {
            get { return this._recommenderFilters; }
            set { this._recommenderFilters = value; }
        }

        // Check to see if RecommenderFilters property is set
        internal bool IsSetRecommenderFilters()
        {
            return this._recommenderFilters != null && (this._recommenderFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommenderName. 
        /// <para>
        /// The unique name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RecommenderName
        {
            get { return this._recommenderName; }
            set { this._recommenderName = value; }
        }

        // Check to see if RecommenderName property is set
        internal bool IsSetRecommenderName()
        {
            return this._recommenderName != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderPromotionalFilters. 
        /// <para>
        /// A list of promotional filters to apply to the recommendations. Promotional filters
        /// allow you to promote specific items within a configurable subset of recommendation
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<RecommenderPromotionalFilter> RecommenderPromotionalFilters
        {
            get { return this._recommenderPromotionalFilters; }
            set { this._recommenderPromotionalFilters = value; }
        }

        // Check to see if RecommenderPromotionalFilters property is set
        internal bool IsSetRecommenderPromotionalFilters()
        {
            return this._recommenderPromotionalFilters != null && (this._recommenderPromotionalFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}