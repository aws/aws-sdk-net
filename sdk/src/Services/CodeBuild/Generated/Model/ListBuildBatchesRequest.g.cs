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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListBuildBatches operation. Retrieves the identifiers
    /// of your build batches in the current region.
    /// </summary>
    public partial class ListBuildBatchesRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A <c>BuildBatchFilter</c> object that specifies the filters for the search.
        /// </para>
        /// </summary>
        public BuildBatchFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// The <c>nextToken</c> value returned from a previous call to <c>ListBuildBatches</c>.
        /// This specifies the next item to return. To return the beginning of the list, exclude
        /// this parameter.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the sort order of the returned items. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASCENDING</c>: List the batch build identifiers in ascending order by identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESCENDING</c>: List the batch build identifiers in descending order by identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SortOrderType SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
