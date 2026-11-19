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
    /// Container for the parameters to the SearchEngagements operation. Searches the engagements
    /// in AWS Partner Central that match your criteria, such as customer industry or geography.
    /// You can combine a free-text <c>Keyword</c>, a structured <c>Filter</c> tree, an engagement
    /// group (<c>GroupId</c>), and <c>Sort</c> options, and each search criterion that you
    /// specify narrows the results. Results are paginated, so use <c>NextToken</c> to retrieve
    /// additional results.
    /// </summary>
    public partial class SearchEngagementsRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog to search. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c>: Production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sandbox</c>: Testing environments.
        /// </para>
        ///  </li> </ul>
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
        /// such as <c>EqualsTo</c>). When provided together with <c>Keyword</c> or <c>GroupId</c>,
        /// each one narrows the result set.
        /// </para>
        /// </summary>
        public EngagementSearchFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of an engagement group that <c>ListEngagementGroups</c> returns. When
        /// you specify a group, the operation returns only the engagements that match the criteria
        /// that define the group. The group must be active and available to you in the specified
        /// catalog. Otherwise, the request fails with a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// An optional free-text query string matched against the engagement title, description,
        /// customer company name, and member company names. When provided together with <c>Filter</c>
        /// or <c>GroupId</c>, each one narrows the result set.
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
        /// Specifies the maximum number of results to return in a single call. If you omit this
        /// value, the operation returns up to 20 results. Use this value to control pagination
        /// together with <c>NextToken</c>.
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
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the field and direction used to sort the search results. If you omit this
        /// field, results are sorted by creation time, newest first.
        /// </para>
        /// </summary>
        public EngagementSearchSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
