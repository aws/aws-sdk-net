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
    /// This is the response object from the GetQuerySuggestions operation.
    /// </summary>
    public partial class GetQuerySuggestionsResponse : AmazonWebServiceResponse
    {
        private string _querySuggestionsId;
        private List<Suggestion> _suggestions = new List<Suggestion>();

        /// <summary>
        /// Gets and sets the property QuerySuggestionsId. 
        /// <para>
        /// The identifier for a list of query suggestions for an index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string QuerySuggestionsId
        {
            get { return this._querySuggestionsId; }
            set { this._querySuggestionsId = value; }
        }

        // Check to see if QuerySuggestionsId property is set
        internal bool IsSetQuerySuggestionsId()
        {
            return this._querySuggestionsId != null;
        }

        /// <summary>
        /// Gets and sets the property Suggestions. 
        /// <para>
        /// A list of query suggestions for an index.
        /// </para>
        /// </summary>
        public List<Suggestion> Suggestions
        {
            get { return this._suggestions; }
            set { this._suggestions = value; }
        }

        // Check to see if Suggestions property is set
        internal bool IsSetSuggestions()
        {
            return this._suggestions != null && this._suggestions.Count > 0; 
        }

    }
}