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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Container for the suggestion information returned in a <c>SuggestResponse</c>.
    /// </summary>
    public partial class SuggestModel
    {
        private long? _found;
        private string _query;
        private List<SuggestionMatch> _suggestions = AWSConfigs.InitializeCollections ? new List<SuggestionMatch>() : null;

        /// <summary>
        /// Gets and sets the property Found. 
        /// <para>
        /// The number of documents that were found to match the query string.
        /// </para>
        /// </summary>
        public long? Found
        {
            get { return this._found; }
            set { this._found = value; }
        }

        // Check to see if Found property is set
        internal bool IsSetFound()
        {
            return this._found.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query string specified in the suggest request.
        /// </para>
        /// </summary>
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property Suggestions. 
        /// <para>
        /// The documents that match the query string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuggestionMatch> Suggestions
        {
            get { return this._suggestions; }
            set { this._suggestions = value; }
        }

        // Check to see if Suggestions property is set
        internal bool IsSetSuggestions()
        {
            return this._suggestions != null && (this._suggestions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}