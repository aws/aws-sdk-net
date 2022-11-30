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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListModelCards operation.
    /// List existing model cards.
    /// </summary>
    public partial class ListModelCardsRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private int? _maxResults;
        private ModelCardStatus _modelCardStatus;
        private string _nameContains;
        private string _nextToken;
        private ModelCardSortBy _sortBy;
        private ModelCardSortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Only list model cards that were created after the time specified.
        /// </para>
        /// </summary>
        public DateTime CreationTimeAfter
        {
            get { return this._creationTimeAfter.GetValueOrDefault(); }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Only list model cards that were created before the time specified.
        /// </para>
        /// </summary>
        public DateTime CreationTimeBefore
        {
            get { return this._creationTimeBefore.GetValueOrDefault(); }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of model cards to list.
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
        /// Gets and sets the property ModelCardStatus. 
        /// <para>
        /// Only list model cards with the specified approval status.
        /// </para>
        /// </summary>
        public ModelCardStatus ModelCardStatus
        {
            get { return this._modelCardStatus; }
            set { this._modelCardStatus = value; }
        }

        // Check to see if ModelCardStatus property is set
        internal bool IsSetModelCardStatus()
        {
            return this._modelCardStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Only list model cards with names that contain the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <code>ListModelCards</code> request was truncated, the
        /// response includes a <code>NextToken</code>. To retrieve the next set of model cards,
        /// use the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Sort model cards by either name or creation time. Sorts by creation time by default.
        /// </para>
        /// </summary>
        public ModelCardSortBy SortBy
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
        /// Sort model cards by ascending or descending order.
        /// </para>
        /// </summary>
        public ModelCardSortOrder SortOrder
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