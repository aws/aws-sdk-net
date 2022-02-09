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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListExports operation.
    /// Lists the exports for a bot, bot locale, or custom vocabulary. Exports are kept in
    /// the list for 7 days.
    /// </summary>
    public partial class ListExportsRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private List<ExportFilter> _filters = new List<ExportFilter>();
        private string _localeId;
        private int? _maxResults;
        private string _nextToken;
        private ExportSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier that Amazon Lex assigned to the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
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
        /// The version of the bot to list exports for. 
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
        /// Provides the specification of a filter used to limit the exports in the response to
        /// only those that match the filter specification. You can only specify one filter and
        /// one string to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ExportFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// Specifies the resources that should be exported. If you don't specify a resource type
        /// in the <code>filters</code> parameter, both bot locales and custom vocabularies are
        /// exported.
        /// </para>
        /// </summary>
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
        /// The maximum number of exports to return in each page of results. If there are fewer
        /// results than the max page size, only the actual number of results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from the <code>ListExports</code> operation contains more results
        /// that specified in the <code>maxResults</code> parameter, a token is returned in the
        /// response. 
        /// </para>
        ///  
        /// <para>
        /// Use the returned token in the <code>nextToken</code> parameter of a <code>ListExports</code>
        /// request to return the next page of results. For a complete set of results, call the
        /// <code>ListExports</code> operation until the <code>nextToken</code> returned in the
        /// response is null.
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
        /// Determines the field that the list of exports is sorted by. You can sort by the <code>LastUpdatedDateTime</code>
        /// field in ascending or descending order.
        /// </para>
        /// </summary>
        public ExportSortBy SortBy
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