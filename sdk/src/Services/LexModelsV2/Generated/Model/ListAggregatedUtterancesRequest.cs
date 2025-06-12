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
    /// Container for the parameters to the ListAggregatedUtterances operation.
    /// Provides a list of utterances that users have sent to the bot.
    /// 
    ///  
    /// <para>
    /// Utterances are aggregated by the text of the utterance. For example, all instances
    /// where customers used the phrase "I want to order pizza" are aggregated into the same
    /// line in the response.
    /// </para>
    ///  
    /// <para>
    /// You can see both detected utterances and missed utterances. A detected utterance is
    /// where the bot properly recognized the utterance and activated the associated intent.
    /// A missed utterance was not recognized by the bot and didn't activate an intent.
    /// </para>
    ///  
    /// <para>
    /// Utterances can be aggregated for a bot alias or for a bot version, but not both at
    /// the same time.
    /// </para>
    ///  
    /// <para>
    /// Utterances statistics are not generated under the following conditions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>childDirected</c> field was set to true when the bot was created.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You are using slot obfuscation with one or more slots.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You opted out of participating in improving Amazon Lex.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListAggregatedUtterancesRequest : AmazonLexModelsV2Request
    {
        private UtteranceAggregationDuration _aggregationDuration;
        private string _botAliasId;
        private string _botId;
        private string _botVersion;
        private List<AggregatedUtterancesFilter> _filters = AWSConfigs.InitializeCollections ? new List<AggregatedUtterancesFilter>() : null;
        private string _localeId;
        private int? _maxResults;
        private string _nextToken;
        private AggregatedUtterancesSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property AggregationDuration. 
        /// <para>
        /// The time window for aggregating the utterance information. You can specify a time
        /// between one hour and two weeks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UtteranceAggregationDuration AggregationDuration
        {
            get { return this._aggregationDuration; }
            set { this._aggregationDuration = value; }
        }

        // Check to see if AggregationDuration property is set
        internal bool IsSetAggregationDuration()
        {
            return this._aggregationDuration != null;
        }

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the bot alias associated with this request. If you specify the bot
        /// alias, you can't specify the bot version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotAliasId
        {
            get { return this._botAliasId; }
            set { this._botAliasId = value; }
        }

        // Check to see if BotAliasId property is set
        internal bool IsSetBotAliasId()
        {
            return this._botAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot associated with this request.
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The identifier of the bot version associated with this request. If you specify the
        /// bot version, you can't specify the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// Provides the specification of a filter used to limit the utterances in the response
        /// to only those that match the filter specification. You can only specify one filter
        /// and one string to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AggregatedUtterancesFilter> Filters
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
        /// The identifier of the language and locale where the utterances were collected. For
        /// more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
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
        /// The maximum number of utterances to return in each page of results. If there are fewer
        /// results than the maximum page size, only the actual number of results are returned.
        /// If you don't specify the <c>maxResults</c> parameter, 1,000 results are returned.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from the <c>ListAggregatedUtterances</c> operation contains more results
        /// that specified in the <c>maxResults</c> parameter, a token is returned in the response.
        /// Use that token in the <c>nextToken</c> parameter to return the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies sorting parameters for the list of utterances. You can sort by the hit count,
        /// the missed count, or the number of distinct sessions the utterance appeared in.
        /// </para>
        /// </summary>
        public AggregatedUtterancesSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

    }
}