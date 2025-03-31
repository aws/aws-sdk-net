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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Searches for a particular search term.
    /// </summary>
    public partial class SearchTermFilterExpression
    {
        private SearchTermMatchingType _matchType;
        private string _searchTerm;

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// Specifies how Deadline Cloud matches your search term in the results. If you don't
        /// specify a <c>matchType</c> the default is <c>FUZZY_MATCH</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FUZZY_MATCH</c> - Matches if a portion of the search term is found in the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTAINS</c> - Matches if the exact search term is contained in the result.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SearchTermMatchingType MatchType
        {
            get { return this._matchType; }
            set { this._matchType = value; }
        }

        // Check to see if MatchType property is set
        internal bool IsSetMatchType()
        {
            return this._matchType != null;
        }

        /// <summary>
        /// Gets and sets the property SearchTerm. 
        /// <para>
        /// The term to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SearchTerm
        {
            get { return this._searchTerm; }
            set { this._searchTerm = value; }
        }

        // Check to see if SearchTerm property is set
        internal bool IsSetSearchTerm()
        {
            return this._searchTerm != null;
        }

    }
}