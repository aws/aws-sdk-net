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
    /// This is the response object from the ListQuerySuggestionsBlockLists operation.
    /// </summary>
    public partial class ListQuerySuggestionsBlockListsResponse : AmazonWebServiceResponse
    {
        private List<QuerySuggestionsBlockListSummary> _blockListSummaryItems = AWSConfigs.InitializeCollections ? new List<QuerySuggestionsBlockListSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BlockListSummaryItems. 
        /// <para>
        /// Summary items for a block list.
        /// </para>
        ///  
        /// <para>
        /// This includes summary items on the block list ID, block list name, when the block
        /// list was created, when the block list was last updated, and the count of block words/phrases
        /// in the block list.
        /// </para>
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QuerySuggestionsBlockListSummary> BlockListSummaryItems
        {
            get { return this._blockListSummaryItems; }
            set { this._blockListSummaryItems = value; }
        }

        // Check to see if BlockListSummaryItems property is set
        internal bool IsSetBlockListSummaryItems()
        {
            return this._blockListSummaryItems != null && (this._blockListSummaryItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Kendra returns this token that you can use in
        /// the subsequent request to retrieve the next set of block lists.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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