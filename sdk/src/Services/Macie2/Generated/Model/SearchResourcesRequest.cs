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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the SearchResources operation.
    /// Retrieves (queries) statistical data and other information about Amazon Web Services
    /// resources that Amazon Macie monitors and analyzes for an account.
    /// </summary>
    public partial class SearchResourcesRequest : AmazonMacie2Request
    {
        private SearchResourcesBucketCriteria _bucketCriteria;
        private int? _maxResults;
        private string _nextToken;
        private SearchResourcesSortCriteria _sortCriteria;

        /// <summary>
        /// Gets and sets the property BucketCriteria. 
        /// <para>
        /// The filter conditions that determine which S3 buckets to include or exclude from the
        /// query results.
        /// </para>
        /// </summary>
        public SearchResourcesBucketCriteria BucketCriteria
        {
            get { return this._bucketCriteria; }
            set { this._bucketCriteria = value; }
        }

        // Check to see if BucketCriteria property is set
        internal bool IsSetBucketCriteria()
        {
            return this._bucketCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to include in each page of the response. The default value
        /// is 50.
        /// </para>
        /// </summary>
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
        /// The nextToken string that specifies which page of results to return in a paginated
        /// response.
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
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The criteria to use to sort the results.
        /// </para>
        /// </summary>
        public SearchResourcesSortCriteria SortCriteria
        {
            get { return this._sortCriteria; }
            set { this._sortCriteria = value; }
        }

        // Check to see if SortCriteria property is set
        internal bool IsSetSortCriteria()
        {
            return this._sortCriteria != null;
        }

    }
}