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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the SearchTypes operation.
    /// Searches for types in Amazon DataZone.
    /// 
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The --domain-identifier must refer to an existing Amazon DataZone domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// --search-scope must be one of the valid values including: ASSET_TYPE, GLOSSARY_TERM_TYPE,
    /// DATA_PRODUCT_TYPE.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The --managed flag must be present without a value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user must have permissions for form or asset types in the domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If using --filters, ensure that the JSON is valid.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Filters contain correct structure (attribute, value, operator).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SearchTypesRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private FilterClause _filters;
        private bool? _managed;
        private int? _maxResults;
        private string _nextToken;
        private List<SearchInItem> _searchIn = AWSConfigs.InitializeCollections ? new List<SearchInItem>() : null;
        private TypesSearchScope _searchScope;
        private string _searchText;
        private SearchSort _sort;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which to invoke the <c>SearchTypes</c>
        /// action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters for the <c>SearchTypes</c> action.
        /// </para>
        /// </summary>
        public FilterClause Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Managed. 
        /// <para>
        /// Specifies whether the search is managed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Managed
        {
            get { return this._managed; }
            set { this._managed = value; }
        }

        // Check to see if Managed property is set
        internal bool IsSetManaged()
        {
            return this._managed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call to <c>SearchTypes</c>. When
        /// the number of results to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>SearchTypes</c> to list the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of results is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of results, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>SearchTypes</c>
        /// to list the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchIn. 
        /// <para>
        /// The details of the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<SearchInItem> SearchIn
        {
            get { return this._searchIn; }
            set { this._searchIn = value; }
        }

        // Check to see if SearchIn property is set
        internal bool IsSetSearchIn()
        {
            return this._searchIn != null && (this._searchIn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// Specifies the scope of the search for types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TypesSearchScope SearchScope
        {
            get { return this._searchScope; }
            set { this._searchScope = value; }
        }

        // Check to see if SearchScope property is set
        internal bool IsSetSearchScope()
        {
            return this._searchScope != null;
        }

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// Specifies the text for which to search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SearchText
        {
            get { return this._searchText; }
            set { this._searchText = value; }
        }

        // Check to see if SearchText property is set
        internal bool IsSetSearchText()
        {
            return this._searchText != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The specifies the way to sort the <c>SearchTypes</c> results.
        /// </para>
        /// </summary>
        public SearchSort Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

    }
}