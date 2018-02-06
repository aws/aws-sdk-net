/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the ListOperations operation.
    /// Lists operations that match the criteria that you specify.
    /// </summary>
    public partial class ListOperationsRequest : AmazonServiceDiscoveryRequest
    {
        private List<OperationFilter> _filters = new List<OperationFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A complex type that contains specifications for the operations that you want to list,
        /// for example, operations that you started between a specified start date and end date.
        /// </para>
        ///  
        /// <para>
        /// If you specify more than one filter, an operation must match all filters to be returned
        /// by <code>ListOperations</code>.
        /// </para>
        /// </summary>
        public List<OperationFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items that you want Amazon Route 53 to return in the response
        /// to a <code>ListOperations</code> request. If you don't specify a value for <code>MaxResults</code>,
        /// Route 53 returns up to 100 operations.
        /// </para>
        /// </summary>
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
        /// For the first <code>ListOperations</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If the response contains <code>NextToken</code>, submit another <code>ListOperations</code>
        /// request to get the next group of results. Specify the value of <code>NextToken</code>
        /// from the previous response in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Route 53 gets <code>MaxResults</code> operations and then filters them based on the
        /// specified criteria. It's possible that no operations in the first <code>MaxResults</code>
        /// operations matched the specified criteria but that subsequent groups of <code>MaxResults</code>
        /// operations do contain operations that match the criteria.
        /// </para>
        ///  </note>
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