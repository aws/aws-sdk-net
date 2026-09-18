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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the ListLiveSources operation. Lists the live sources
    /// contained in a source location. A source represents a piece of content.
    /// </summary>
    public partial class ListLiveSourcesRequest : AmazonMediaTailorRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of live sources that you want MediaTailor to return in response
        /// to the current request. If there are more than <c>MaxResults</c> live sources, use
        /// the value of <c>NextToken</c> in the response to get the next page of results.
        /// </para>
        ///  
        /// <para>
        /// The default value is 100. MediaTailor uses DynamoDB-based pagination, which means
        /// that a response might contain fewer than <c>MaxResults</c> items, including 0 items,
        /// even when more results are available. To retrieve all results, you must continue making
        /// requests using the <c>NextToken</c> value from each response until the response no
        /// longer includes a <c>NextToken</c> value.
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
        /// Pagination token returned by the list request when results exceed the maximum allowed.
        /// Use the token to fetch the next page of results.
        /// </para>
        ///  
        /// <para>
        /// For the first <c>ListLiveSources</c> request, omit this value. For subsequent requests,
        /// get the value of <c>NextToken</c> from the previous response and specify that value
        /// for <c>NextToken</c> in the request. Continue making requests until the response no
        /// longer includes a <c>NextToken</c> value, which indicates that all results have been
        /// retrieved.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location associated with this Live Sources list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;
    }
}
