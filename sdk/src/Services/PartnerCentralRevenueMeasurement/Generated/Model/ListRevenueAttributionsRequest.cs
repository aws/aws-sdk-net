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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// Container for the parameters to the ListRevenueAttributions operation.
    /// Returns a paginated list of revenue attributions with optional filters.
    /// </summary>
    public partial class ListRevenueAttributionsRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private CatalogName _catalog;
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private List<string> _identifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private AttributionSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog to list revenue attributions from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CatalogName Catalog
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
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filter results to only include revenue attributions created after this timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Filter results to only include revenue attributions created before this timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// Filter results to only include revenue attributions with the specified identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && (this._identifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Token for pagination. Use the value returned in the previous response to retrieve
        /// the next page.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort revenue attributions by.
        /// </para>
        /// </summary>
        public AttributionSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The direction to sort results.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}