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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the SearchTypes operation.
    /// </summary>
    public partial class SearchTypesResponse : AmazonWebServiceResponse
    {
        private List<SearchTypesResultItem> _items = AWSConfigs.InitializeCollections ? new List<SearchTypesResultItem>() : null;
        private string _nextToken;
        private int? _totalMatchCount;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The results of the <c>SearchTypes</c> action.
        /// </para>
        /// </summary>
        public List<SearchTypesResultItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of results is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of results, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>SearchTypes</c>
        /// to list the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property TotalMatchCount. 
        /// <para>
        /// Total number of search results.
        /// </para>
        /// </summary>
        public int TotalMatchCount
        {
            get { return this._totalMatchCount.GetValueOrDefault(); }
            set { this._totalMatchCount = value; }
        }

        // Check to see if TotalMatchCount property is set
        internal bool IsSetTotalMatchCount()
        {
            return this._totalMatchCount.HasValue; 
        }

    }
}