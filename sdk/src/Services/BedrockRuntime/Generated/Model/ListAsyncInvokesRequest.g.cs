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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the ListAsyncInvokes operation. Lists asynchronous
    /// invocations.
    /// </summary>
    public partial class ListAsyncInvokesRequest : AmazonBedrockRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of invocations to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// How to sort the response.
        /// </para>
        /// </summary>
        public SortAsyncInvocationBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sorting order for the response.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filter invocations by status.
        /// </para>
        /// </summary>
        public AsyncInvokeStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;

        /// <summary>
        /// Gets and sets the property SubmitTimeAfter. 
        /// <para>
        /// Include invocations submitted after this time.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTimeAfter property is set.
        /// </summary>
        internal bool IsSetSubmitTimeAfter() => this.SubmitTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property SubmitTimeBefore. 
        /// <para>
        /// Include invocations submitted before this time.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTimeBefore property is set.
        /// </summary>
        internal bool IsSetSubmitTimeBefore() => this.SubmitTimeBefore.HasValue;
    }
}
