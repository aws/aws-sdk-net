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
    /// Container for the parameters to the ListFeatureGroups operation.
    /// List <code>FeatureGroup</code>s based on given filter and order.
    /// </summary>
    public partial class ListFeatureGroupsRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private FeatureGroupStatus _featureGroupStatusEquals;
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private OfflineStoreStatusValue _offlineStoreStatusEquals;
        private FeatureGroupSortBy _sortBy;
        private FeatureGroupSortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Use this parameter to search for <code>FeatureGroups</code>s created after a specific
        /// date and time.
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
        /// Use this parameter to search for <code>FeatureGroups</code>s created before a specific
        /// date and time.
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
        /// Gets and sets the property FeatureGroupStatusEquals. 
        /// <para>
        /// A <code>FeatureGroup</code> status. Filters by <code>FeatureGroup</code> status. 
        /// </para>
        /// </summary>
        public FeatureGroupStatus FeatureGroupStatusEquals
        {
            get { return this._featureGroupStatusEquals; }
            set { this._featureGroupStatusEquals = value; }
        }

        // Check to see if FeatureGroupStatusEquals property is set
        internal bool IsSetFeatureGroupStatusEquals()
        {
            return this._featureGroupStatusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <code>ListFeatureGroups</code>.
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string that partially matches one or more <code>FeatureGroup</code>s names. Filters
        /// <code>FeatureGroup</code>s by name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// A token to resume pagination of <code>ListFeatureGroups</code> results.
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
        /// Gets and sets the property OfflineStoreStatusEquals. 
        /// <para>
        /// An <code>OfflineStore</code> status. Filters by <code>OfflineStore</code> status.
        /// 
        /// </para>
        /// </summary>
        public OfflineStoreStatusValue OfflineStoreStatusEquals
        {
            get { return this._offlineStoreStatusEquals; }
            set { this._offlineStoreStatusEquals = value; }
        }

        // Check to see if OfflineStoreStatusEquals property is set
        internal bool IsSetOfflineStoreStatusEquals()
        {
            return this._offlineStoreStatusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value on which the feature group list is sorted.
        /// </para>
        /// </summary>
        public FeatureGroupSortBy SortBy
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
        /// The order in which feature groups are listed.
        /// </para>
        /// </summary>
        public FeatureGroupSortOrder SortOrder
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