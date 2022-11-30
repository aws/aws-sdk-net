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
    /// Container for the parameters to the ListApps operation.
    /// Lists apps.
    /// </summary>
    public partial class ListAppsRequest : AmazonSageMakerRequest
    {
        private string _domainIdEquals;
        private int? _maxResults;
        private string _nextToken;
        private AppSortKey _sortBy;
        private SortOrder _sortOrder;
        private string _spaceNameEquals;
        private string _userProfileNameEquals;

        /// <summary>
        /// Gets and sets the property DomainIdEquals. 
        /// <para>
        /// A parameter to search for the domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string DomainIdEquals
        {
            get { return this._domainIdEquals; }
            set { this._domainIdEquals = value; }
        }

        // Check to see if DomainIdEquals property is set
        internal bool IsSetDomainIdEquals()
        {
            return this._domainIdEquals != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Returns a list up to a specified limit.
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
        /// If the previous response was truncated, you will receive this token. Use it in your
        /// next request to receive the next set of results.
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
        /// The parameter by which to sort the results. The default is CreationTime.
        /// </para>
        /// </summary>
        public AppSortKey SortBy
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
        /// The sort order for the results. The default is Ascending.
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

        /// <summary>
        /// Gets and sets the property SpaceNameEquals. 
        /// <para>
        /// A parameter to search by space name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string SpaceNameEquals
        {
            get { return this._spaceNameEquals; }
            set { this._spaceNameEquals = value; }
        }

        // Check to see if SpaceNameEquals property is set
        internal bool IsSetSpaceNameEquals()
        {
            return this._spaceNameEquals != null;
        }

        /// <summary>
        /// Gets and sets the property UserProfileNameEquals. 
        /// <para>
        /// A parameter to search by user profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string UserProfileNameEquals
        {
            get { return this._userProfileNameEquals; }
            set { this._userProfileNameEquals = value; }
        }

        // Check to see if UserProfileNameEquals property is set
        internal bool IsSetUserProfileNameEquals()
        {
            return this._userProfileNameEquals != null;
        }

    }
}