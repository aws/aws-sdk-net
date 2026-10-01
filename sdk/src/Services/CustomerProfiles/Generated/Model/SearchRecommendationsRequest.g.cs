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
    /// Container for the parameters to the SearchRecommendations operation. Retrieves recommendations
    /// for a profile in a specific domain. The profile is identified using a search key,
    /// which consists of a <c>KeyName</c> and a <c>KeyValues</c> list. The <c>KeyName</c>
    /// can be a predefined key (for example, <c>_profileId</c>, <c>_phone</c>, <c>_email</c>)
    /// or a custom-defined key. <para> The search key must match exactly one profile. If
    /// no profile matches the search key, the operation returns a <c>ResourceNotFoundException</c>.
    /// If more than one profile matches the search key, the operation returns a <c>BadRequestException</c>.
    /// You can use the SearchProfiles API to review the matching profiles. </para>
    /// </summary>
    public partial class SearchRecommendationsRequest : AmazonCustomerProfilesRequest
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
        /// Gets and sets the property Diversity. 
        /// <para>
        /// Runtime diversity configuration for this request. Enables diversity-aware recommendations
        /// and optionally supplies values for placeholder-based diversity caps configured on
        /// the recommender.
        /// </para>
        /// </summary>
        public RecommendationDiversityConfig Diversity { get; set; }

        /// <summary>
        /// Checks to see if the Diversity property is set.
        /// </summary>
        internal bool IsSetDiversity() => this.Diversity != null;

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
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A searchable identifier of a customer profile. You can use a predefined key, such
        /// as <c>_profileId</c>, <c>_phone</c>, or <c>_email</c>, or a custom-defined key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property KeyValues. 
        /// <para>
        /// A list of key values. Provide one value for each field of the search key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 10)]
        public List<string> KeyValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyValues property is set.
        /// </summary>
        internal bool IsSetKeyValues() => this.KeyValues != null && (this.KeyValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxRecommendations. 
        /// <para>
        /// The maximum number of recommendations to return. The default value is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxRecommendations { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecommendations property is set.
        /// </summary>
        internal bool IsSetMaxRecommendations() => this.MaxRecommendations.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Configuration for metadata to include in recommendation responses.
        /// </para>
        /// </summary>
        public RecommendationMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Recommender. 
        /// <para>
        /// The recommender used to generate the recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Recommender Recommender { get; set; }

        /// <summary>
        /// Checks to see if the Recommender property is set.
        /// </summary>
        internal bool IsSetRecommender() => this.Recommender != null;
    }
}
