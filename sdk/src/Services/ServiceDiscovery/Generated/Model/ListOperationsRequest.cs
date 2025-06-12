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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the ListOperations operation.
    /// Lists operations that match the criteria that you specify.
    /// </summary>
    public partial class ListOperationsRequest : AmazonServiceDiscoveryRequest
    {
        private List<OperationFilter> _filters = AWSConfigs.InitializeCollections ? new List<OperationFilter>() : null;
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
        /// by <c>ListOperations</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperationFilter> Filters
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
        /// The maximum number of items that you want Cloud Map to return in the response to a
        /// <c>ListOperations</c> request. If you don't specify a value for <c>MaxResults</c>,
        /// Cloud Map returns up to 100 operations.
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
        /// For the first <c>ListOperations</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If the response contains <c>NextToken</c>, submit another <c>ListOperations</c> request
        /// to get the next group of results. Specify the value of <c>NextToken</c> from the previous
        /// response in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cloud Map gets <c>MaxResults</c> operations and then filters them based on the specified
        /// criteria. It's possible that no operations in the first <c>MaxResults</c> operations
        /// matched the specified criteria but that subsequent groups of <c>MaxResults</c> operations
        /// do contain operations that match the criteria.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=4096)]
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