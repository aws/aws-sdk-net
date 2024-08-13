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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListFleets operation.
    /// Gets a list of compute fleet names with each compute fleet name representing a single
    /// compute fleet.
    /// </summary>
    public partial class ListFleetsRequest : AmazonCodeBuildRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private FleetSortByType _sortBy;
        private SortOrderType _sortOrder;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of paginated compute fleets returned per response. Use <c>nextToken</c>
        /// to iterate pages in the list of returned compute fleets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// During a previous call, if there are more than 100 items in the list, only the first
        /// 100 items are returned, along with a unique string called a <i>nextToken</i>. To get
        /// the next batch of items in the list, call this operation again, adding the next token
        /// to the call. To get all of the items in the list, keep calling this operation with
        /// each subsequent next token that is returned, until no more next tokens are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The criterion to be used to list compute fleet names. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED_TIME</c>: List based on when each compute fleet was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAST_MODIFIED_TIME</c>: List based on when information about each compute fleet
        /// was last changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAME</c>: List based on each compute fleet's name.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use <c>sortOrder</c> to specify in what order to list the compute fleet names based
        /// on the preceding criteria.
        /// </para>
        /// </summary>
        public FleetSortByType SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which to list compute fleets. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASCENDING</c>: List in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESCENDING</c>: List in descending order.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use <c>sortBy</c> to specify the criterion to be used to list compute fleet names.
        /// </para>
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