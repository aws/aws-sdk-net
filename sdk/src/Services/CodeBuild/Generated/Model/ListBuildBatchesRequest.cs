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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListBuildBatches operation.
    /// Retrieves the identifiers of your build batches in the current region.
    /// </summary>
    public partial class ListBuildBatchesRequest : AmazonCodeBuildRequest
    {
        private BuildBatchFilter _filter;
        private int? _maxResults;
        private string _nextToken;
        private SortOrderType _sortOrder;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A <code>BuildBatchFilter</code> object that specifies the filters for the search.
        /// </para>
        /// </summary>
        public BuildBatchFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous call to <code>ListBuildBatches</code>.
        /// This specifies the next item to return. To return the beginning of the list, exclude
        /// this parameter.
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

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the sort order of the returned items. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASCENDING</code>: List the batch build identifiers in ascending order by identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DESCENDING</code>: List the batch build identifiers in descending order by
        /// identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SortOrderType SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}