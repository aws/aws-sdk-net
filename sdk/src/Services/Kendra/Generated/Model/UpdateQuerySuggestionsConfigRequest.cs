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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
    /// Container for the parameters to the UpdateQuerySuggestionsConfig operation.
    /// Updates the settings of query suggestions for an index.
    /// 
    ///  
    /// <para>
    /// Amazon Kendra supports partial updates, so you only need to provide the fields you
    /// want to update.
    /// </para>
    ///  
    /// <para>
    /// If an update is currently processing, you need to wait for the update to finish before
    /// making another update.
    /// </para>
    ///  
    /// <para>
    /// Updates to query suggestions settings might not take effect right away. The time for
    /// your updated settings to take effect depends on the updates made and the number of
    /// search queries in your index.
    /// </para>
    ///  
    /// <para>
    /// You can still enable/disable query suggestions at any time.
    /// </para>
    ///  
    /// <para>
    ///  <c>UpdateQuerySuggestionsConfig</c> is currently not supported in the Amazon Web
    /// Services GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class UpdateQuerySuggestionsConfigRequest : AmazonKendraRequest
    {
        private AttributeSuggestionsUpdateConfig _attributeSuggestionsConfig;
        private bool? _includeQueriesWithoutUserInformation;
        private string _indexId;
        private int? _minimumNumberOfQueryingUsers;
        private int? _minimumQueryCount;
        private Mode _mode;
        private int? _queryLogLookBackWindowInDays;

        /// <summary>
        /// Gets and sets the property AttributeSuggestionsConfig. 
        /// <para>
        /// Configuration information for the document fields/attributes that you want to base
        /// query suggestions on.
        /// </para>
        /// </summary>
        public AttributeSuggestionsUpdateConfig AttributeSuggestionsConfig
        {
            get { return this._attributeSuggestionsConfig; }
            set { this._attributeSuggestionsConfig = value; }
        }

        // Check to see if AttributeSuggestionsConfig property is set
        internal bool IsSetAttributeSuggestionsConfig()
        {
            return this._attributeSuggestionsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeQueriesWithoutUserInformation. 
        /// <para>
        ///  <c>TRUE</c> to include queries without user information (i.e. all queries, irrespective
        /// of the user), otherwise <c>FALSE</c> to only include queries with user information.
        /// </para>
        ///  
        /// <para>
        /// If you pass user information to Amazon Kendra along with the queries, you can set
        /// this flag to <c>FALSE</c> and instruct Amazon Kendra to only consider queries with
        /// user information.
        /// </para>
        ///  
        /// <para>
        /// If you set to <c>FALSE</c>, Amazon Kendra only considers queries searched at least
        /// <c>MinimumQueryCount</c> times across <c>MinimumNumberOfQueryingUsers</c> unique users
        /// for suggestions.
        /// </para>
        ///  
        /// <para>
        /// If you set to <c>TRUE</c>, Amazon Kendra ignores all user information and learns from
        /// all queries.
        /// </para>
        /// </summary>
        public bool? IncludeQueriesWithoutUserInformation
        {
            get { return this._includeQueriesWithoutUserInformation; }
            set { this._includeQueriesWithoutUserInformation = value; }
        }

        // Check to see if IncludeQueriesWithoutUserInformation property is set
        internal bool IsSetIncludeQueriesWithoutUserInformation()
        {
            return this._includeQueriesWithoutUserInformation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        ///  The identifier of the index with query suggestions you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumNumberOfQueryingUsers. 
        /// <para>
        /// The minimum number of unique users who must search a query in order for the query
        /// to be eligible to suggest to your users.
        /// </para>
        ///  
        /// <para>
        /// Increasing this number might decrease the number of suggestions. However, this ensures
        /// a query is searched by many users and is truly popular to suggest to users.
        /// </para>
        ///  
        /// <para>
        /// How you tune this setting depends on your specific needs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MinimumNumberOfQueryingUsers
        {
            get { return this._minimumNumberOfQueryingUsers; }
            set { this._minimumNumberOfQueryingUsers = value; }
        }

        // Check to see if MinimumNumberOfQueryingUsers property is set
        internal bool IsSetMinimumNumberOfQueryingUsers()
        {
            return this._minimumNumberOfQueryingUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumQueryCount. 
        /// <para>
        /// The the minimum number of times a query must be searched in order to be eligible to
        /// suggest to your users.
        /// </para>
        ///  
        /// <para>
        /// Decreasing this number increases the number of suggestions. However, this affects
        /// the quality of suggestions as it sets a low bar for a query to be considered popular
        /// to suggest to users.
        /// </para>
        ///  
        /// <para>
        /// How you tune this setting depends on your specific needs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MinimumQueryCount
        {
            get { return this._minimumQueryCount; }
            set { this._minimumQueryCount = value; }
        }

        // Check to see if MinimumQueryCount property is set
        internal bool IsSetMinimumQueryCount()
        {
            return this._minimumQueryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Set the mode to <c>ENABLED</c> or <c>LEARN_ONLY</c>.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon Kendra enables query suggestions. <c>LEARN_ONLY</c> mode allows
        /// you to turn off query suggestions. You can to update this at any time.
        /// </para>
        ///  
        /// <para>
        /// In <c>LEARN_ONLY</c> mode, Amazon Kendra continues to learn from new queries to keep
        /// suggestions up to date for when you are ready to switch to ENABLED mode again.
        /// </para>
        /// </summary>
        public Mode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property QueryLogLookBackWindowInDays. 
        /// <para>
        /// How recent your queries are in your query log time window.
        /// </para>
        ///  
        /// <para>
        /// The time window is the number of days from current day to past days.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon Kendra sets this to 180.
        /// </para>
        /// </summary>
        public int? QueryLogLookBackWindowInDays
        {
            get { return this._queryLogLookBackWindowInDays; }
            set { this._queryLogLookBackWindowInDays = value; }
        }

        // Check to see if QueryLogLookBackWindowInDays property is set
        internal bool IsSetQueryLogLookBackWindowInDays()
        {
            return this._queryLogLookBackWindowInDays.HasValue; 
        }

    }
}