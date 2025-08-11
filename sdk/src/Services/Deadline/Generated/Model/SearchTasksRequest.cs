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
    /// Container for the parameters to the SearchTasks operation.
    /// Searches for tasks.
    /// </summary>
    public partial class SearchTasksRequest : AmazonDeadlineRequest
    {
        private string _farmId;
        private SearchGroupedFilterExpressions _filterExpressions;
        private int? _itemOffset;
        private string _jobId;
        private int? _pageSize;
        private List<string> _queueIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SearchSortExpression> _sortExpressions = AWSConfigs.InitializeCollections ? new List<SearchSortExpression>() : null;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the task.
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
        /// The filter expression, <c>AND</c> or <c>OR</c>, to use when searching among a group
        /// of search strings in a resource. 
        /// <para>
        /// You can use two groupings per search each within parenthesis <c>()</c>.
        /// </para>
        /// 
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
        /// Defines how far into the scrollable list to start the return of results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public int? ItemOffset
        {
            get { return this._itemOffset; }
            set { this._itemOffset = value; }
        }

        // Check to see if ItemOffset property is set
        internal bool IsSetItemOffset()
        {
            return this._itemOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID for the task search.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Specifies the number of items per page for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? PageSize
        {
            get { return this._pageSize; }
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
        /// The queue IDs to include in the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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