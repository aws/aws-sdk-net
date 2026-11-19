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

namespace Amazon.AgentRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the SearchDiscoverableRegistryRecords operation. Searches
    /// the discoverable registry records in a registry using a natural language query. Returns
    /// metadata for the matching records ordered by relevance. <para> Returns at most 1000
    /// results across all pages when <c>searchType</c> is <c>KEYWORD</c>, and at most 20
    /// results when it is <c>HYBRID</c> or <c>SEMANTIC</c>. To retrieve more records, refine
    /// the query or filters, or use <c>ListDiscoverableRegistryRecords</c> to list every
    /// record. </para>
    /// </summary>
    public partial class SearchDiscoverableRegistryRecordsRequest : AmazonAgentRegistryRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  An optional structured JSON metadata filter that narrows the search results. Supports
        /// the field-level operators <c>$eq</c>, <c>$ne</c>, and <c>$in</c>, and the logical
        /// operators <c>$and</c> and <c>$or</c> on filterable fields.
        /// </para>
        ///  
        /// <para>
        ///  Specifies additional filtering on custom metadata fields using the <c>customMetadata.{key}</c>
        /// prefix. For example, to filter by a custom metadata field: <c>{"customMetadata.environment":
        /// {"$eq": "production"}}</c>. For a Boolean field, you can also use a native JSON boolean
        /// value, for example: <c>{"customMetadata.requiresApproval": {"$eq": true}}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => !this.Filters.IsNull();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in one page. Valid values are 1 through 50
        /// when <c>searchType</c> is <c>KEYWORD</c>, and 1 through 20 when it is <c>HYBRID</c>
        /// or <c>SEMANTIC</c>. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token from a previous response. Use it to retrieve the next page of
        /// results, and send the same <c>searchQuery</c>, <c>registryIds</c>, <c>filters</c>,
        /// and <c>searchType</c> that you used for the first page. If any of them differ, the
        /// request fails with a <c>ValidationException</c>. A pagination token expires 15 minutes
        /// after the service returns the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegistryIds. 
        /// <para>
        ///  The registry identifiers to search within. Currently, you must specify exactly one
        /// registry identifier. You can provide either the full Amazon Web Services Resource
        /// Name (ARN) or the registry ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> RegistryIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegistryIds property is set.
        /// </summary>
        internal bool IsSetRegistryIds() => this.RegistryIds != null && (this.RegistryIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchQuery. 
        /// <para>
        ///  The natural language query to search for matching registry records. If you specify
        /// an empty string, the operation returns the records that match the <c>filters</c>,
        /// most recently updated first, up to the result limit for the <c>searchType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 256)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Checks to see if the SearchQuery property is set.
        /// </summary>
        internal bool IsSetSearchQuery() => this.SearchQuery != null;

        /// <summary>
        /// Gets and sets the property SearchType. 
        /// <para>
        ///  Specifies how the service ranks registry records against the search query. If you
        /// omit this parameter, the service uses <c>HYBRID</c> in Amazon Web Services Regions
        /// that support semantic search and <c>KEYWORD</c> in Regions that do not. The response
        /// reports the search type that the service used. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYWORD</c> – Ranks records by keyword match between the query terms and the record
        /// name, description, descriptors, and custom metadata text values. Available in every
        /// Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SEMANTIC</c> – Ranks records by semantic similarity to the query and returns the
        /// most similar records, up to <c>maxResults</c>, even when none of them closely matches
        /// the query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HYBRID</c> – Combines keyword ranking and semantic ranking.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>HYBRID</c> and <c>SEMANTIC</c> are available in a limited number of Regions. If
        /// you specify either one in a Region that does not support semantic search, the request
        /// fails with a <c>ValidationException</c> that has the reason <c>UnsupportedInRegion</c>.
        /// </para>
        /// </summary>
        public SearchType SearchType { get; set; }

        /// <summary>
        /// Checks to see if the SearchType property is set.
        /// </summary>
        internal bool IsSetSearchType() => this.SearchType != null;
    }
}
