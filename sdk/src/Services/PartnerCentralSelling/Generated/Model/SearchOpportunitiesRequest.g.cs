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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the SearchOpportunities operation. The <c>SearchOpportunities</c>
    /// operation in the AWS Partner Central Selling API searches and filters the opportunities
    /// available to you in AWS Partner Central. <para> You can optionally provide a free-text
    /// <c>Keyword</c>, a structured <c>Filter</c> tree, and <c>Sort</c> options. The operation
    /// returns a curated summary view of each matching opportunity. If you supply both <c>Keyword</c>
    /// and <c>Filter</c>, the operation combines them with a logical AND, so each one narrows
    /// the result set. </para> <para> Results are paginated. Use the <c>NextToken</c> parameter
    /// to retrieve additional pages of results. </para>
    /// </summary>
    public partial class SearchOpportunitiesRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which you run the search. Use <c>AWS</c> to search production
        /// opportunities, or use <c>Sandbox</c> to search opportunities in a testing environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A recursive, structured filter tree. Each node is either a boolean combinator (<c>AndAllFilters</c>,
        /// <c>OrAllFilters</c>, or <c>NotFilter</c>) or a leaf predicate (a single comparison
        /// such as <c>EqualsTo</c>). When provided together with <c>Keyword</c>, both narrow
        /// the result set.
        /// </para>
        /// </summary>
        public OpportunitySearchFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// An optional free-text query string matched against opportunity fields. When provided
        /// together with <c>Filter</c>, both narrow the result set.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Keyword { get; set; }

        /// <summary>
        /// Checks to see if the Keyword property is set.
        /// </summary>
        internal bool IsSetKeyword() => this.Keyword != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Use this value to control
        /// pagination together with <c>NextToken</c>. If you omit this parameter, the service
        /// applies a default page size and returns the remaining results on subsequent pages.
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
        /// A pagination token returned by a previous call. Pass it in a subsequent call to retrieve
        /// the next page of results. Omit it on the first call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the field and direction used to sort the search results.
        /// </para>
        /// </summary>
        public OpportunitySearchSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
