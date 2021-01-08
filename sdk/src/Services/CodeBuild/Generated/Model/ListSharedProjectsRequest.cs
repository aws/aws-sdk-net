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
    /// Container for the parameters to the ListSharedProjects operation.
    /// Gets a list of projects that are shared with other AWS accounts or users.
    /// </summary>
    public partial class ListSharedProjectsRequest : AmazonCodeBuildRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private SharedResourceSortByType _sortBy;
        private SortOrderType _sortOrder;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of paginated shared build projects returned per response. Use
        /// <code>nextToken</code> to iterate pages in the list of returned <code>Project</code>
        /// objects. The default value is 100. 
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
        ///  During a previous call, the maximum number of items that can be returned is the value
        /// specified in <code>maxResults</code>. If there more items in the list, then a unique
        /// string called a <i>nextToken</i> is returned. To get the next batch of items in the
        /// list, call this operation again, adding the next token to the call. To get all of
        /// the items in the list, keep calling this operation with each subsequent next token
        /// that is returned, until no more next tokens are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        ///  The criterion to be used to list build projects shared with the current AWS account
        /// or user. Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ARN</code>: List based on the ARN. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFIED_TIME</code>: List based on when information about the shared project
        /// was last changed. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SharedResourceSortByType SortBy
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
        /// The order in which to list shared build projects. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASCENDING</code>: List in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DESCENDING</code>: List in descending order.
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