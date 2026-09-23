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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeBuckets operation. Retrieves (queries)
    /// statistical data and other information about one or more S3 buckets that Amazon Macie
    /// monitors and analyzes for an account.
    /// </summary>
    public partial class DescribeBucketsRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The criteria to use to filter the query results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, BucketCriteriaAdditionalProperties> Criteria { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, BucketCriteriaAdditionalProperties>() : null;

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null && (this.Criteria.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to include in each page of the response. The default value
        /// is 50.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string that specifies which page of results to return in a paginated
        /// response.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The criteria to use to sort the query results.
        /// </para>
        /// </summary>
        public BucketSortCriteria SortCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SortCriteria property is set.
        /// </summary>
        internal bool IsSetSortCriteria() => this.SortCriteria != null;
    }
}
