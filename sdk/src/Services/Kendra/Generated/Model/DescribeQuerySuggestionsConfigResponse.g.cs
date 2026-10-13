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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the DescribeQuerySuggestionsConfig operation.
    /// </summary>
    public partial class DescribeQuerySuggestionsConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttributeSuggestionsConfig. 
        /// <para>
        /// Configuration information for the document fields/attributes that you want to base
        /// query suggestions on.
        /// </para>
        /// </summary>
        public AttributeSuggestionsDescribeConfig AttributeSuggestionsConfig { get; set; }

        /// <summary>
        /// Checks to see if the AttributeSuggestionsConfig property is set.
        /// </summary>
        internal bool IsSetAttributeSuggestionsConfig() => this.AttributeSuggestionsConfig != null;

        /// <summary>
        /// Gets and sets the property IncludeQueriesWithoutUserInformation. 
        /// <para>
        ///  <c>TRUE</c> to use all queries, otherwise use only queries that include user information
        /// to generate the query suggestions.
        /// </para>
        /// </summary>
        public bool? IncludeQueriesWithoutUserInformation { get; set; }

        /// <summary>
        /// Checks to see if the IncludeQueriesWithoutUserInformation property is set.
        /// </summary>
        internal bool IsSetIncludeQueriesWithoutUserInformation() => this.IncludeQueriesWithoutUserInformation.HasValue;

        /// <summary>
        /// Gets and sets the property LastClearTime. 
        /// <para>
        /// The Unix timestamp when query suggestions for an index was last cleared.
        /// </para>
        ///  
        /// <para>
        /// After you clear suggestions, Amazon Kendra learns new suggestions based on new queries
        /// added to the query log from the time you cleared suggestions. Amazon Kendra only considers
        /// re-occurences of a query from the time you cleared suggestions. 
        /// </para>
        /// </summary>
        public DateTime? LastClearTime { get; set; }

        /// <summary>
        /// Checks to see if the LastClearTime property is set.
        /// </summary>
        internal bool IsSetLastClearTime() => this.LastClearTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuggestionsBuildTime. 
        /// <para>
        /// The Unix timestamp when query suggestions for an index was last updated.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra automatically updates suggestions every 24 hours, after you change a
        /// setting or after you apply a <a href="https://docs.aws.amazon.com/kendra/latest/dg/query-suggestions.html#query-suggestions-blocklist">block
        /// list</a>.
        /// </para>
        /// </summary>
        public DateTime? LastSuggestionsBuildTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuggestionsBuildTime property is set.
        /// </summary>
        internal bool IsSetLastSuggestionsBuildTime() => this.LastSuggestionsBuildTime.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumNumberOfQueryingUsers. 
        /// <para>
        /// The minimum number of unique users who must search a query in order for the query
        /// to be eligible to suggest to your users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MinimumNumberOfQueryingUsers { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNumberOfQueryingUsers property is set.
        /// </summary>
        internal bool IsSetMinimumNumberOfQueryingUsers() => this.MinimumNumberOfQueryingUsers.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumQueryCount. 
        /// <para>
        /// The minimum number of times a query must be searched in order for the query to be
        /// eligible to suggest to your users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MinimumQueryCount { get; set; }

        /// <summary>
        /// Checks to see if the MinimumQueryCount property is set.
        /// </summary>
        internal bool IsSetMinimumQueryCount() => this.MinimumQueryCount.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Whether query suggestions are currently in <c>ENABLED</c> mode or <c>LEARN_ONLY</c>
        /// mode.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon Kendra enables query suggestions.<c>LEARN_ONLY</c> turns off query
        /// suggestions for your users. You can change the mode using the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateQuerySuggestionsConfig.html">UpdateQuerySuggestionsConfig</a>
        /// API.
        /// </para>
        /// </summary>
        public Mode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property QueryLogLookBackWindowInDays. 
        /// <para>
        /// How recent your queries are in your query log time window (in days).
        /// </para>
        /// </summary>
        public int? QueryLogLookBackWindowInDays { get; set; }

        /// <summary>
        /// Checks to see if the QueryLogLookBackWindowInDays property is set.
        /// </summary>
        internal bool IsSetQueryLogLookBackWindowInDays() => this.QueryLogLookBackWindowInDays.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the status of query suggestions settings is currently <c>ACTIVE</c> or <c>UPDATING</c>.
        /// </para>
        ///  
        /// <para>
        /// Active means the current settings apply and Updating means your changed settings are
        /// in the process of applying.
        /// </para>
        /// </summary>
        public QuerySuggestionsStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalSuggestionsCount. 
        /// <para>
        /// The current total count of query suggestions for an index.
        /// </para>
        ///  
        /// <para>
        /// This count can change when you update your query suggestions settings, if you filter
        /// out certain queries from suggestions using a block list, and as the query log accumulates
        /// more queries for Amazon Kendra to learn from.
        /// </para>
        ///  
        /// <para>
        /// If the count is much lower than you expected, it could be because Amazon Kendra needs
        /// more queries in the query history to learn from or your current query suggestions
        /// settings are too strict.
        /// </para>
        /// </summary>
        public int? TotalSuggestionsCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalSuggestionsCount property is set.
        /// </summary>
        internal bool IsSetTotalSuggestionsCount() => this.TotalSuggestionsCount.HasValue;
    }
}
