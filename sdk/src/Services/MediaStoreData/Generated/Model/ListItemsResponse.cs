/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// This is the response object from the ListItems operation.
    /// </summary>
    public partial class ListItemsResponse : AmazonWebServiceResponse
    {
        private List<Item> _items = new List<Item>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The metadata entries for the folders and objects at the requested path.
        /// </para>
        /// </summary>
        public List<Item> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that can be used in a request to view the next set of results. For example,
        /// you submit a <code>ListItems</code> request that matches 2,000 items with <code>MaxResults</code>
        /// set at 500. The service returns the first batch of results (up to 500) and a <code>NextToken</code>
        /// value that can be used to fetch the next batch of results.
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

    }
}