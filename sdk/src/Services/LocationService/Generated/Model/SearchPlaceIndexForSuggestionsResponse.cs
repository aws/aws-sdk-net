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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the SearchPlaceIndexForSuggestions operation.
    /// </summary>
    public partial class SearchPlaceIndexForSuggestionsResponse : AmazonWebServiceResponse
    {
        private List<SearchForSuggestionsResult> _results = new List<SearchForSuggestionsResult>();
        private SearchPlaceIndexForSuggestionsSummary _summary;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// A list of place suggestions that best match the search text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SearchForSuggestionsResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Contains a summary of the request. Echoes the input values for <code>BiasPosition</code>,
        /// <code>FilterBBox</code>, <code>FilterCountries</code>, <code>Language</code>, <code>MaxResults</code>,
        /// and <code>Text</code>. Also includes the <code>DataSource</code> of the place index.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchPlaceIndexForSuggestionsSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}