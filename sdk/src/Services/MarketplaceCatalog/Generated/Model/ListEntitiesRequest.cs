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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the ListEntities operation.
    /// Provides the list of entities of a given type.
    /// </summary>
    public partial class ListEntitiesRequest : AmazonMarketplaceCatalogRequest
    {
        private string _catalog;
        private string _entityType;
        private EntityTypeFilters _entityTypeFilters;
        private EntityTypeSort _entityTypeSort;
        private List<Filter> _filterList = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private OwnershipType _ownershipType;
        private Sort _sort;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entities to retrieve. Valid values are: <c>AmiProduct</c>, <c>ContainerProduct</c>,
        /// <c>DataProduct</c>, <c>SaaSProduct</c>, <c>ProcurementPolicy</c>, <c>Experience</c>,
        /// <c>Audience</c>, <c>BrandingSettings</c>, <c>Offer</c>, <c>Seller</c>, <c>ResaleAuthorization</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property EntityTypeFilters. 
        /// <para>
        /// A Union object containing filter shapes for all <c>EntityType</c>s. Each <c>EntityTypeFilter</c>
        /// shape will have filters applicable for that <c>EntityType</c> that can be used to
        /// search or filter entities.
        /// </para>
        /// </summary>
        public EntityTypeFilters EntityTypeFilters
        {
            get { return this._entityTypeFilters; }
            set { this._entityTypeFilters = value; }
        }

        // Check to see if EntityTypeFilters property is set
        internal bool IsSetEntityTypeFilters()
        {
            return this._entityTypeFilters != null;
        }

        /// <summary>
        /// Gets and sets the property EntityTypeSort. 
        /// <para>
        /// A Union object containing <c>Sort</c> shapes for all <c>EntityType</c>s. Each <c>EntityTypeSort</c>
        /// shape will have <c>SortBy</c> and <c>SortOrder</c> applicable for fields on that <c>EntityType</c>.
        /// This can be used to sort the results of the filter query.
        /// </para>
        /// </summary>
        public EntityTypeSort EntityTypeSort
        {
            get { return this._entityTypeSort; }
            set { this._entityTypeSort = value; }
        }

        // Check to see if EntityTypeSort property is set
        internal bool IsSetEntityTypeSort()
        {
            return this._entityTypeSort != null;
        }

        /// <summary>
        /// Gets and sets the property FilterList. 
        /// <para>
        /// An array of filter objects. Each filter object contains two attributes, <c>filterName</c>
        /// and <c>filterValues</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public List<Filter> FilterList
        {
            get { return this._filterList; }
            set { this._filterList = value; }
        }

        // Check to see if FilterList property is set
        internal bool IsSetFilterList()
        {
            return this._filterList != null && (this._filterList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the upper limit of the elements on a single page. If a value isn't provided,
        /// the default value is 20.
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
        /// The value of the next token, if it exists. Null if there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property OwnershipType. 
        /// <para>
        /// Filters the returned set of entities based on their owner. The default is <c>SELF</c>.
        /// To list entities shared with you through AWS Resource Access Manager (AWS RAM), set
        /// to <c>SHARED</c>. Entities shared through the AWS Marketplace Catalog API <c>PutResourcePolicy</c>
        /// operation can't be discovered through the <c>SHARED</c> parameter.
        /// </para>
        /// </summary>
        public OwnershipType OwnershipType
        {
            get { return this._ownershipType; }
            set { this._ownershipType = value; }
        }

        // Check to see if OwnershipType property is set
        internal bool IsSetOwnershipType()
        {
            return this._ownershipType != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// An object that contains two attributes, <c>SortBy</c> and <c>SortOrder</c>.
        /// </para>
        /// </summary>
        public Sort Sort
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