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
    /// Container for the parameters to the ListAppImageConfigs operation.
    /// Lists the AppImageConfigs in your account and their properties. The list can be filtered
    /// by creation time or modified time, and whether the AppImageConfig name contains a
    /// specified string.
    /// </summary>
    public partial class ListAppImageConfigsRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private int? _maxResults;
        private DateTime? _modifiedTimeAfter;
        private DateTime? _modifiedTimeBefore;
        private string _nameContains;
        private string _nextToken;
        private AppImageConfigSortKey _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only AppImageConfigs created on or after the specified time.
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
        /// A filter that returns only AppImageConfigs created on or before the specified time.
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
        /// The maximum number of AppImageConfigs to return in the response. The default value
        /// is 10. 
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
        /// Gets and sets the property ModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only AppImageConfigs modified on or after the specified time.
        /// </para>
        /// </summary>
        public DateTime ModifiedTimeAfter
        {
            get { return this._modifiedTimeAfter.GetValueOrDefault(); }
            set { this._modifiedTimeAfter = value; }
        }

        // Check to see if ModifiedTimeAfter property is set
        internal bool IsSetModifiedTimeAfter()
        {
            return this._modifiedTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only AppImageConfigs modified on or before the specified time.
        /// </para>
        /// </summary>
        public DateTime ModifiedTimeBefore
        {
            get { return this._modifiedTimeBefore.GetValueOrDefault(); }
            set { this._modifiedTimeBefore = value; }
        }

        // Check to see if ModifiedTimeBefore property is set
        internal bool IsSetModifiedTimeBefore()
        {
            return this._modifiedTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A filter that returns only AppImageConfigs whose name contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
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
        /// If the previous call to <code>ListImages</code> didn't return the full set of AppImageConfigs,
        /// the call returns a token for getting the next set of AppImageConfigs.
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
        /// The property used to sort results. The default value is <code>CreationTime</code>.
        /// </para>
        /// </summary>
        public AppImageConfigSortKey SortBy
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
        /// The sort order. The default value is <code>Descending</code>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
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