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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAssociatedTranscripts operation. Search
    /// for associated transcripts that meet the specified criteria.
    /// </summary>
    public partial class SearchAssociatedTranscriptsRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot associated with the transcripts that you are searching.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        /// The unique identifier of the bot recommendation associated with the transcripts to
        /// search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotRecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the BotRecommendationId property is set.
        /// </summary>
        internal bool IsSetBotRecommendationId() => this.BotRecommendationId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot containing the transcripts that you are searching.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filter objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<AssociatedTranscriptFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedTranscriptFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale of the transcripts to search. The string
        /// must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of bot recommendations to return in each page of results. If there
        /// are fewer results than the max page size, only the actual number of results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextIndex. 
        /// <para>
        /// If the response from the SearchAssociatedTranscriptsRequest operation contains more
        /// results than specified in the maxResults parameter, an index is returned in the response.
        /// Use that index in the nextIndex parameter to return the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public int? NextIndex { get; set; }

        /// <summary>
        /// Checks to see if the NextIndex property is set.
        /// </summary>
        internal bool IsSetNextIndex() => this.NextIndex.HasValue;

        /// <summary>
        /// Gets and sets the property SearchOrder. 
        /// <para>
        /// How SearchResults are ordered. Valid values are Ascending or Descending. The default
        /// is Descending.
        /// </para>
        /// </summary>
        public SearchOrder SearchOrder { get; set; }

        /// <summary>
        /// Checks to see if the SearchOrder property is set.
        /// </summary>
        internal bool IsSetSearchOrder() => this.SearchOrder != null;
    }
}
