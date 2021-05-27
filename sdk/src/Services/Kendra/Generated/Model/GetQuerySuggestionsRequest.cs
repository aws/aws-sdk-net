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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the GetQuerySuggestions operation.
    /// Fetches the queries that are suggested to your users.
    /// </summary>
    public partial class GetQuerySuggestionsRequest : AmazonKendraRequest
    {
        private string _indexId;
        private int? _maxSuggestionsCount;
        private string _queryText;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index you want to get query suggestions from.
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
        /// Gets and sets the property MaxSuggestionsCount. 
        /// <para>
        /// The maximum number of query suggestions you want to show to your users.
        /// </para>
        /// </summary>
        public int MaxSuggestionsCount
        {
            get { return this._maxSuggestionsCount.GetValueOrDefault(); }
            set { this._maxSuggestionsCount = value; }
        }

        // Check to see if MaxSuggestionsCount property is set
        internal bool IsSetMaxSuggestionsCount()
        {
            return this._maxSuggestionsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The text of a user's query to generate query suggestions.
        /// </para>
        ///  
        /// <para>
        /// A query is suggested if the query prefix matches what a user starts to type as their
        /// query.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra does not show any suggestions if a user types fewer than two characters
        /// or more than 60 characters. A query must also have at least one search result and
        /// contain at least one word of more than four characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

    }
}