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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceProperties operation.
    /// An API operation used by the Systems Manager console to display information about
    /// Systems Manager managed nodes.
    /// </summary>
    public partial class DescribeInstancePropertiesRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<InstancePropertyStringFilter> _filtersWithOperator = AWSConfigs.InitializeCollections ? new List<InstancePropertyStringFilter>() : null;
        private List<InstancePropertyFilter> _instancePropertyFilterList = AWSConfigs.InitializeCollections ? new List<InstancePropertyFilter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FiltersWithOperator. 
        /// <para>
        /// The request filters to use with the operator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public List<InstancePropertyStringFilter> FiltersWithOperator
        {
            get { return this._filtersWithOperator; }
            set { this._filtersWithOperator = value; }
        }

        // Check to see if FiltersWithOperator property is set
        internal bool IsSetFiltersWithOperator()
        {
            return this._filtersWithOperator != null && (this._filtersWithOperator.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstancePropertyFilterList. 
        /// <para>
        /// An array of instance property filters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public List<InstancePropertyFilter> InstancePropertyFilterList
        {
            get { return this._instancePropertyFilterList; }
            set { this._instancePropertyFilterList = value; }
        }

        // Check to see if InstancePropertyFilterList property is set
        internal bool IsSetInstancePropertyFilterList()
        {
            return this._instancePropertyFilterList != null && (this._instancePropertyFilterList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for the call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token provided by a previous request to use to return the next set of properties.
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