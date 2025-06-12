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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the SearchTables operation.
    /// Searches a set of tables based on properties in the table metadata as well as on the
    /// parent database. You can search against text or filter conditions. 
    /// 
    ///  
    /// <para>
    /// You can only get tables that you have access to based on the security policies defined
    /// in Lake Formation. You need at least a read-only access to the table for it to be
    /// returned. If you do not have access to all the columns in the table, these columns
    /// will not be searched against when returning the list of tables back to you. If you
    /// have access to the columns but not the data in the columns, those columns and the
    /// associated metadata for those columns will be included in the search. 
    /// </para>
    /// </summary>
    public partial class SearchTablesRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private List<PropertyPredicate> _filters = AWSConfigs.InitializeCollections ? new List<PropertyPredicate>() : null;
        private bool? _includeStatusDetails;
        private int? _maxResults;
        private string _nextToken;
        private ResourceShareType _resourceShareType;
        private string _searchText;
        private List<SortCriterion> _sortCriteria = AWSConfigs.InitializeCollections ? new List<SortCriterion>() : null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// A unique identifier, consisting of <c> <i>account_id</i> </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of key-value pairs, and a comparator used to filter the search results. Returns
        /// all entities matching the predicate.
        /// </para>
        ///  
        /// <para>
        /// The <c>Comparator</c> member of the <c>PropertyPredicate</c> struct is used only for
        /// time fields, and can be omitted for other field types. Also, when comparing string
        /// values, such as when <c>Key=Name</c>, a fuzzy match algorithm is used. The <c>Key</c>
        /// field (for example, the value of the <c>Name</c> field) is split on certain punctuation
        /// characters, for example, -, :, #, etc. into tokens. Then each token is exact-match
        /// compared with the <c>Value</c> member of <c>PropertyPredicate</c>. For example, if
        /// <c>Key=Name</c> and <c>Value=link</c>, tables named <c>customer-link</c> and <c>xx-link-yy</c>
        /// are returned, but <c>xxlinkyy</c> is not returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PropertyPredicate> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeStatusDetails. 
        /// <para>
        /// Specifies whether to include status details related to a request to create or update
        /// an Glue Data Catalog view.
        /// </para>
        /// </summary>
        public bool? IncludeStatusDetails
        {
            get { return this._includeStatusDetails; }
            set { this._includeStatusDetails = value; }
        }

        // Check to see if IncludeStatusDetails property is set
        internal bool IsSetIncludeStatusDetails()
        {
            return this._includeStatusDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tables to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// A continuation token, included if this is a continuation call.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceShareType. 
        /// <para>
        /// Allows you to specify that you want to search the tables shared with your account.
        /// The allowable values are <c>FOREIGN</c> or <c>ALL</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If set to <c>FOREIGN</c>, will search the tables shared with your account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>ALL</c>, will search the tables shared with your account, as well as
        /// the tables in yor local account. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceShareType ResourceShareType
        {
            get { return this._resourceShareType; }
            set { this._resourceShareType = value; }
        }

        // Check to see if ResourceShareType property is set
        internal bool IsSetResourceShareType()
        {
            return this._resourceShareType != null;
        }

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// A string used for a text search.
        /// </para>
        ///  
        /// <para>
        /// Specifying a value in quotes filters based on an exact match to the value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// A list of criteria for sorting the results by a field name, in an ascending or descending
        /// order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<SortCriterion> SortCriteria
        {
            get { return this._sortCriteria; }
            set { this._sortCriteria = value; }
        }

        // Check to see if SortCriteria property is set
        internal bool IsSetSortCriteria()
        {
            return this._sortCriteria != null && (this._sortCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}