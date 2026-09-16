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
    /// Container for the parameters to the SearchRecommendations operation.
    /// Retrieves recommendations for a profile in a specific domain. The profile is identified
    /// using a search key, which consists of a <c>KeyName</c> and a <c>KeyValues</c> list.
    /// The <c>KeyName</c> can be a predefined key (for example, <c>_profileId</c>, <c>_phone</c>,
    /// <c>_email</c>) or a custom-defined key.
    /// 
    ///  
    /// <para>
    /// The search key must match exactly one profile. If no profile matches the search key,
    /// the operation returns a <c>ResourceNotFoundException</c>. If more than one profile
    /// matches the search key, the operation returns a <c>BadRequestException</c>. You can
    /// use the SearchProfiles API to review the matching profiles.
    /// </para>
    /// </summary>
    public partial class SearchRecommendationsRequest : AmazonCustomerProfilesRequest
    {
        private List<string> _candidateIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RecommendationDiversityConfig _diversity;
        private string _domainName;
        private string _keyName;
        private List<string> _keyValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxRecommendations;
        private RecommendationMetadata _metadata;
        private Recommender _recommender;

        /// <summary>
        /// Gets and sets the property CandidateIds. 
        /// <para>
        /// A list of item IDs to rank for the user. Use this when you want to re-rank a specific
        /// set of items rather than getting recommendations from the full item catalog. Required
        /// for personalized-ranking use cases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Diversity. 
        /// <para>
        /// Runtime diversity configuration for this request. Enables diversity-aware recommendations
        /// and optionally supplies values for placeholder-based diversity caps configured on
        /// the recommender.
        /// </para>
        /// </summary>
        public RecommendationDiversityConfig Diversity
        {
            get { return this._diversity; }
            set { this._diversity = value; }
        }

        // Check to see if Diversity property is set
        internal bool IsSetDiversity()
        {
            return this._diversity != null;
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
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A searchable identifier of a customer profile. You can use a predefined key, such
        /// as <c>_profileId</c>, <c>_phone</c>, or <c>_email</c>, or a custom-defined key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyValues. 
        /// <para>
        /// A list of key values. Provide one value for each field of the search key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10)]
        public List<string> KeyValues
        {
            get { return this._keyValues; }
            set { this._keyValues = value; }
        }

        // Check to see if KeyValues property is set
        internal bool IsSetKeyValues()
        {
            return this._keyValues != null && (this._keyValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxRecommendations. 
        /// <para>
        /// The maximum number of recommendations to return. The default value is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxRecommendations
        {
            get { return this._maxRecommendations; }
            set { this._maxRecommendations = value; }
        }

        // Check to see if MaxRecommendations property is set
        internal bool IsSetMaxRecommendations()
        {
            return this._maxRecommendations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Configuration for metadata to include in recommendation responses.
        /// </para>
        /// </summary>
        public RecommendationMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Recommender. 
        /// <para>
        /// The recommender used to generate the recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Recommender Recommender
        {
            get { return this._recommender; }
            set { this._recommender = value; }
        }

        // Check to see if Recommender property is set
        internal bool IsSetRecommender()
        {
            return this._recommender != null;
        }

    }
}