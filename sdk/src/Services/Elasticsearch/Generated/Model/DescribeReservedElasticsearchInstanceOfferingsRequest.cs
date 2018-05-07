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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedElasticsearchInstanceOfferings operation.
    /// Lists available reserved Elasticsearch instance offerings.
    /// </summary>
    public partial class DescribeReservedElasticsearchInstanceOfferingsRequest : AmazonElasticsearchRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _reservedElasticsearchInstanceOfferingId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Set this value to limit the number of results returned. If not specified, defaults
        /// to 100.
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
        /// NextToken should be sent in case if earlier API call produced result containing NextToken.
        /// It is used for pagination.
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
        /// Gets and sets the property ReservedElasticsearchInstanceOfferingId. 
        /// <para>
        /// The offering identifier filter value. Use this parameter to show only the available
        /// offering that matches the specified reservation identifier.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceOfferingId
        {
            get { return this._reservedElasticsearchInstanceOfferingId; }
            set { this._reservedElasticsearchInstanceOfferingId = value; }
        }

        // Check to see if ReservedElasticsearchInstanceOfferingId property is set
        internal bool IsSetReservedElasticsearchInstanceOfferingId()
        {
            return this._reservedElasticsearchInstanceOfferingId != null;
        }

    }
}