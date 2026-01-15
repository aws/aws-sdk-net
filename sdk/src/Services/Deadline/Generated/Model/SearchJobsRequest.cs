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
    /// Container for the parameters to the SearchJobs operation.
    /// Searches for jobs.
    /// </summary>
    public partial class SearchJobsRequest : AmazonDeadlineRequest
    {
        private string _farmId;
        private SearchGroupedFilterExpressions _filterExpressions;
        private int? _itemOffset;
        private int? _pageSize;
        private List<string> _queueIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SearchSortExpression> _sortExpressions = AWSConfigs.InitializeCollections ? new List<SearchSortExpression>() : null;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property FilterExpressions. 
        /// <para>
        /// The search terms for a resource.
        /// </para>
        /// </summary>
        public SearchGroupedFilterExpressions FilterExpressions
        {
            get { return this._filterExpressions; }
            set { this._filterExpressions = value; }
        }

        // Check to see if FilterExpressions property is set
        internal bool IsSetFilterExpressions()
        {
            return this._filterExpressions != null;
        }

        /// <summary>
        /// Gets and sets the property ItemOffset. 
        /// <para>
        /// The offset for the search results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public int ItemOffset
        {
            get { return this._itemOffset.GetValueOrDefault(); }
            set { this._itemOffset = value; }
        }

        // Check to see if ItemOffset property is set
        internal bool IsSetItemOffset()
        {
            return this._itemOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Specifies the number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueIds. 
        /// <para>
        /// The queue ID to use in the job search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> QueueIds
        {
            get { return this._queueIds; }
            set { this._queueIds = value; }
        }

        // Check to see if QueueIds property is set
        internal bool IsSetQueueIds()
        {
            return this._queueIds != null && (this._queueIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SortExpressions. 
        /// <para>
        /// The search terms for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<SearchSortExpression> SortExpressions
        {
            get { return this._sortExpressions; }
            set { this._sortExpressions = value; }
        }

        // Check to see if SortExpressions property is set
        internal bool IsSetSortExpressions()
        {
            return this._sortExpressions != null && (this._sortExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}