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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListTrainingPlans operation.
    /// Retrieves a list of training plans for the current account.
    /// </summary>
    public partial class ListTrainingPlansRequest : AmazonSageMakerRequest
    {
        private List<TrainingPlanFilter> _filters = AWSConfigs.InitializeCollections ? new List<TrainingPlanFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private TrainingPlanSortBy _sortBy;
        private TrainingPlanSortOrder _sortOrder;
        private DateTime? _startTimeAfter;
        private DateTime? _startTimeBefore;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Additional filters to apply to the list of training plans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<TrainingPlanFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
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
        /// A token to continue pagination if more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// The training plan field to sort the results by (e.g., StartTime, Status).
        /// </para>
        /// </summary>
        public TrainingPlanSortBy SortBy
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
        /// The order to sort the results (Ascending or Descending).
        /// </para>
        /// </summary>
        public TrainingPlanSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeAfter. 
        /// <para>
        /// Filter to list only training plans with an actual start time after this date.
        /// </para>
        /// </summary>
        public DateTime? StartTimeAfter
        {
            get { return this._startTimeAfter; }
            set { this._startTimeAfter = value; }
        }

        // Check to see if StartTimeAfter property is set
        internal bool IsSetStartTimeAfter()
        {
            return this._startTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeBefore. 
        /// <para>
        /// Filter to list only training plans with an actual start time before this date.
        /// </para>
        /// </summary>
        public DateTime? StartTimeBefore
        {
            get { return this._startTimeBefore; }
            set { this._startTimeBefore = value; }
        }

        // Check to see if StartTimeBefore property is set
        internal bool IsSetStartTimeBefore()
        {
            return this._startTimeBefore.HasValue; 
        }

    }
}