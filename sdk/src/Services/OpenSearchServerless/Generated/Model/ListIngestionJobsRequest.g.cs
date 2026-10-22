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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListIngestionJobs operation. Returns a list of
    /// ingestion jobs in a collection.
    /// </summary>
    public partial class ListIngestionJobsRequest : AmazonOpenSearchServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The unique identifier of the collection to list ingestion jobs for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 40)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Checks to see if the CollectionId property is set.
        /// </summary>
        internal bool IsSetCollectionId() => this.CollectionId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. Valid values are 1–100. If you don't specify
        /// a value, the default is 100. You can use <c>nextToken</c> to get the next page of
        /// results.
        /// </para>
        ///  
        /// <para>
        /// A response can contain fewer results than <c>maxResults</c>, or no results, and still
        /// include a <c>nextToken</c>. To retrieve all results, continue to make the call with
        /// the returned <c>nextToken</c> until no <c>nextToken</c> is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your initial <c>ListIngestionJobs</c> operation returns a <c>nextToken</c>, you
        /// can include the returned <c>nextToken</c> in subsequent <c>ListIngestionJobs</c> operations,
        /// which returns results in the next page.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
