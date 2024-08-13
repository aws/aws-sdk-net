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
    /// An autocomplete suggestion that matches the query string specified in a <c>SuggestRequest</c>.
    /// </summary>
    public partial class SuggestionMatch
    {
        private string _id;
        private long? _score;
        private string _suggestion;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The document ID of the suggested document.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The relevance score of a suggested match.
        /// </para>
        /// </summary>
        public long? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Suggestion. 
        /// <para>
        /// The string that matches the query string specified in the <c>SuggestRequest</c>. 
        /// </para>
        /// </summary>
        public string Suggestion
        {
            get { return this._suggestion; }
            set { this._suggestion = value; }
        }

        // Check to see if Suggestion property is set
        internal bool IsSetSuggestion()
        {
            return this._suggestion != null;
        }

    }
}