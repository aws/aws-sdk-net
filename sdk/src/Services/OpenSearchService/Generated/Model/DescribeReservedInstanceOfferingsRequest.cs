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
    /// Lists available reserved OpenSearch instance offerings.
    /// </summary>
    public partial class DescribeReservedInstanceOfferingsRequest : AmazonOpenSearchServiceRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _reservedInstanceOfferingId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Set this value to limit the number of results returned. If not specified, defaults
        /// to 100.
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
        /// Provides an identifier to allow retrieval of paginated results. 
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
        /// The offering identifier filter value. Use this parameter to show only the available
        /// offering that matches the specified reservation identifier. 
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