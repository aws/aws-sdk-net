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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListResources operation.
    /// Lists the resources registered to be managed by the Data Catalog.
    /// </summary>
    public partial class ListResourcesRequest : AmazonLakeFormationRequest
    {
        private List<FilterCondition> _filterConditionList = new List<FilterCondition>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FilterConditionList. 
        /// <para>
        /// Any applicable row-level and/or column-level filtering conditions for the resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<FilterCondition> FilterConditionList
        {
            get { return this._filterConditionList; }
            set { this._filterConditionList = value; }
        }

        // Check to see if FilterConditionList property is set
        internal bool IsSetFilterConditionList()
        {
            return this._filterConditionList != null && this._filterConditionList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of resource results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// A continuation token, if this is not the first call to retrieve these resources.
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

    }
}