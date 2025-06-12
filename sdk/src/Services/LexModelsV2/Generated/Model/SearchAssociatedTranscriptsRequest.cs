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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Container for the parameters to the SearchAssociatedTranscripts operation.
    /// Search for associated transcripts that meet the specified criteria.
    /// </summary>
    public partial class SearchAssociatedTranscriptsRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botRecommendationId;
        private string _botVersion;
        private List<AssociatedTranscriptFilter> _filters = AWSConfigs.InitializeCollections ? new List<AssociatedTranscriptFilter>() : null;
        private string _localeId;
        private int? _maxResults;
        private int? _nextIndex;
        private SearchOrder _searchOrder;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot associated with the transcripts that you are searching.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        /// The unique identifier of the bot recommendation associated with the transcripts to
        /// search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotRecommendationId
        {
            get { return this._botRecommendationId; }
            set { this._botRecommendationId = value; }
        }

        // Check to see if BotRecommendationId property is set
        internal bool IsSetBotRecommendationId()
        {
            return this._botRecommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot containing the transcripts that you are searching.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filter objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<AssociatedTranscriptFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale of the transcripts to search. The string
        /// must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of bot recommendations to return in each page of results. If there
        /// are fewer results than the max page size, only the actual number of results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextIndex. 
        /// <para>
        /// If the response from the SearchAssociatedTranscriptsRequest operation contains more
        /// results than specified in the maxResults parameter, an index is returned in the response.
        /// Use that index in the nextIndex parameter to return the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public int? NextIndex
        {
            get { return this._nextIndex; }
            set { this._nextIndex = value; }
        }

        // Check to see if NextIndex property is set
        internal bool IsSetNextIndex()
        {
            return this._nextIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchOrder. 
        /// <para>
        /// How SearchResults are ordered. Valid values are Ascending or Descending. The default
        /// is Descending.
        /// </para>
        /// </summary>
        public SearchOrder SearchOrder
        {
            get { return this._searchOrder; }
            set { this._searchOrder = value; }
        }

        // Check to see if SearchOrder property is set
        internal bool IsSetSearchOrder()
        {
            return this._searchOrder != null;
        }

    }
}