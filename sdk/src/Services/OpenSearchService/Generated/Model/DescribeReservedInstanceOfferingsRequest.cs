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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstanceOfferings operation.
    /// Describes the available Amazon OpenSearch Service Reserved Instance offerings for
    /// a given Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ri.html">Reserved
    /// Instances in Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class DescribeReservedInstanceOfferingsRequest : AmazonOpenSearchServiceRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _reservedInstanceOfferingId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <code>nextToken</code> to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
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
        /// If your initial <code>DescribeReservedInstanceOfferings</code> operation returns a
        /// <code>nextToken</code>, you can include the returned <code>nextToken</code> in subsequent
        /// <code>DescribeReservedInstanceOfferings</code> operations, which returns results in
        /// the next page.
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

        /// <summary>
        /// Gets and sets the property ReservedInstanceOfferingId. 
        /// <para>
        /// The Reserved Instance identifier filter value. Use this parameter to show only the
        /// available instance types that match the specified reservation identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ReservedInstanceOfferingId
        {
            get { return this._reservedInstanceOfferingId; }
            set { this._reservedInstanceOfferingId = value; }
        }

        // Check to see if ReservedInstanceOfferingId property is set
        internal bool IsSetReservedInstanceOfferingId()
        {
            return this._reservedInstanceOfferingId != null;
        }

    }
}