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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the ListCisScanResultsAggregatedByChecks operation.
    /// Lists scan results aggregated by checks.
    /// </summary>
    public partial class ListCisScanResultsAggregatedByChecksRequest : AmazonInspector2Request
    {
        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// The filter criteria.
        /// </para>
        /// </summary>
        public CisScanResultsAggregatedByChecksFilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteria property is set.
        /// </summary>
        internal bool IsSetFilterCriteria() => this.FilterCriteria != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of scan results aggregated by checks to be returned in a single
        /// page of results.
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
        /// The pagination token from a previous request that's used to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The scan ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanArn property is set.
        /// </summary>
        internal bool IsSetScanArn() => this.ScanArn != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The sort by order.
        /// </para>
        /// </summary>
        public CisScanResultsAggregatedByChecksSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order.
        /// </para>
        /// </summary>
        public CisSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
