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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the SearchDataTables operation. Searches for data
    /// tables based on the table's ID, name, and description. In the future, this operation
    /// can support searching on attribute names and possibly primary values. Follows other
    /// search operations closely and supports both search criteria and filters.
    /// </summary>
    public partial class SearchDataTablesRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the Amazon Connect instance to search within.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of data tables to return in one page of results.
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
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchCriteria. 
        /// <para>
        /// Search criteria including string conditions for matching table names, descriptions,
        /// or resource IDs. Supports STARTS_WITH, CONTAINS, and EXACT comparison types.
        /// </para>
        /// </summary>
        public DataTableSearchCriteria SearchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SearchCriteria property is set.
        /// </summary>
        internal bool IsSetSearchCriteria() => this.SearchCriteria != null;

        /// <summary>
        /// Gets and sets the property SearchFilter. 
        /// <para>
        /// Optional filters to apply to the search results, such as tag-based filtering for attribute-based
        /// access control.
        /// </para>
        /// </summary>
        public DataTableSearchFilter SearchFilter { get; set; }

        /// <summary>
        /// Checks to see if the SearchFilter property is set.
        /// </summary>
        internal bool IsSetSearchFilter() => this.SearchFilter != null;
    }
}
