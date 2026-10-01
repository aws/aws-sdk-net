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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the Search operation. Searches for assets in Amazon
    /// DataZone. <para> Search in Amazon DataZone is a powerful capability that enables users
    /// to discover and explore data assets, glossary terms, and data products across their
    /// organization. It provides both basic and advanced search functionality, allowing users
    /// to find resources based on names, descriptions, metadata, and other attributes. Search
    /// can be scoped to specific types of resources (like assets, glossary terms, or data
    /// products) and can be filtered using various criteria such as creation date, owner,
    /// or status. The search functionality is essential for making the wealth of data resources
    /// in an organization discoverable and usable, helping users find the right data for
    /// their needs quickly and efficiently. </para> <para> Many search commands in Amazon
    /// DataZone are paginated, including <c>search</c> and <c>search-types</c>. When the
    /// result set is large, Amazon DataZone returns a <c>nextToken</c> in the response. This
    /// token can be used to retrieve the next page of results. </para> <para> Prerequisites:
    /// </para> <ul> <li> <para> The --domain-identifier must refer to an existing Amazon
    /// DataZone domain. </para> </li> <li> <para> --search-scope must be one of: ASSET, GLOSSARY_TERM,
    /// DATA_PRODUCT, or GLOSSARY. </para> </li> <li> <para> The user must have search permissions
    /// in the specified domain. </para> </li> <li> <para> If using --filters, ensure that
    /// the JSON is well-formed and that each filter includes valid attribute and value keys.
    /// </para> </li> <li> <para> For paginated results, be prepared to use --next-token to
    /// fetch additional pages. </para> </li> </ul> <para> To run a standard free-text search,
    /// the <c>searchText</c> parameter must be supplied. By default, all searchable fields
    /// are indexed for semantic search and will return semantic matches for SearchListings
    /// queries. To prevent semantic search indexing for a custom form attribute, see the
    /// <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateFormType.html">CreateFormType
    /// API documentation</a>. To run a lexical search query, enclose the query with double
    /// quotes (""). This will disable semantic search even for fields that have semantic
    /// search enabled and will only return results that contain the keywords wrapped by double
    /// quotes (order of tokens in the query is not enforced). Free-text search is supported
    /// for all attributes annotated with @amazon.datazone#searchable. </para> <para> To run
    /// a filtered search, provide filter clause using the <c>filters</c> parameter. To filter
    /// on glossary terms, use the special attribute <c>__DataZoneGlossaryTerms</c>. To filter
    /// on an indexed numeric attribute (i.e., a numeric attribute annotated with <c>@amazon.datazone#sortable</c>),
    /// provide a filter using the <c>intValue</c> parameter. The filters parameter can also
    /// be used to run more advanced free-text searches that target specific attributes (attributes
    /// must be annotated with <c>@amazon.datazone#searchable</c> for free-text search). Create/update
    /// timestamp filtering is supported using the special <c>creationTime</c>/<c>lastUpdatedTime</c>
    /// attributes. Filter types can be mixed and matched to power complex queries. </para>
    /// <para> To find out whether an attribute has been annotated and indexed for a given
    /// search type, use the GetFormType API to retrieve the form containing the attribute.
    /// </para>
    /// </summary>
    public partial class SearchRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// Specifies additional attributes for the <c>Search</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAttributes property is set.
        /// </summary>
        internal bool IsSetAdditionalAttributes() => this.AdditionalAttributes != null && (this.AdditionalAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Specifies the search filters.
        /// </para>
        /// </summary>
        public FilterClause Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call to <c>Search</c>. When the
        /// number of results to be listed is greater than the value of <c>MaxResults</c>, the
        /// response contains a <c>NextToken</c> value that you can use in a subsequent call to
        /// <c>Search</c> to list the next set of results.
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
        /// When the number of results is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of results, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>Search</c>
        /// to list the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the owning project specified for the search.
        /// </para>
        /// </summary>
        public string OwningProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetOwningProjectIdentifier() => this.OwningProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property SearchIn. 
        /// <para>
        /// The details of the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<SearchInItem> SearchIn { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchInItem>() : null;

        /// <summary>
        /// Checks to see if the SearchIn property is set.
        /// </summary>
        internal bool IsSetSearchIn() => this.SearchIn != null && (this.SearchIn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// The scope of the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InventorySearchScope SearchScope { get; set; }

        /// <summary>
        /// Checks to see if the SearchScope property is set.
        /// </summary>
        internal bool IsSetSearchScope() => this.SearchScope != null;

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// Specifies the text for which to search.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SearchText { get; set; }

        /// <summary>
        /// Checks to see if the SearchText property is set.
        /// </summary>
        internal bool IsSetSearchText() => this.SearchText != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the way in which the search results are to be sorted.
        /// </para>
        /// </summary>
        public SearchSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
