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
    /// Container for the parameters to the DescribeReservedElasticsearchInstances operation.
    /// Returns information about reserved Elasticsearch instances for this account.
    /// </summary>
    public partial class DescribeReservedElasticsearchInstancesRequest : AmazonElasticsearchRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _reservedElasticsearchInstanceId;

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
        /// Gets and sets the property ReservedElasticsearchInstanceId. 
        /// <para>
        /// The reserved instance identifier filter value. Use this parameter to show only the
        /// reservation that matches the specified reserved Elasticsearch instance ID.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceId
        {
            get { return this._reservedElasticsearchInstanceId; }
            set { this._reservedElasticsearchInstanceId = value; }
        }

        // Check to see if ReservedElasticsearchInstanceId property is set
        internal bool IsSetReservedElasticsearchInstanceId()
        {
            return this._reservedElasticsearchInstanceId != null;
        }

    }
}