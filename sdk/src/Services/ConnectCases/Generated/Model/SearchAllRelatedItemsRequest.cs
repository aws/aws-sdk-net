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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAllRelatedItems operation.
    /// Searches for related items across all cases within a domain. This is a global search
    /// operation that returns related items from multiple cases, unlike the case-specific
    /// <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_SearchRelatedItems.html">SearchRelatedItems</a>
    /// API.
    /// 
    ///  
    /// <para>
    ///  <b>Use cases</b> 
    /// </para>
    ///  
    /// <para>
    /// Following are common uses cases for this API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Find cases with similar issues across the domain. For example, search for all cases
    /// containing comments about "product defect" to identify patterns and existing solutions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Locate all cases associated with specific contacts or orders. For example, find all
    /// cases linked to a contactArn to understand the complete customer journey. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Monitor SLA compliance across cases. For example, search for all cases with "Active"
    /// SLA status to prioritize remediation efforts.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// This API returns case identifiers, not complete case objects. To retrieve full case
    /// details, you must make additional calls to the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetCase.html">GetCase</a>
    /// API for each returned case ID. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This API searches across related items content, not case fields. Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_SearchCases.html">SearchCases</a>
    /// API to search within case field values.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    /// </summary>
    public partial class SearchAllRelatedItemsRequest : AmazonConnectCasesRequest
    {
        private string _domainId;
        private List<RelatedItemTypeFilter> _filters = AWSConfigs.InitializeCollections ? new List<RelatedItemTypeFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<SearchAllRelatedItemsSort> _sorts = AWSConfigs.InitializeCollections ? new List<SearchAllRelatedItemsSort>() : null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The list of types of related items and their parameters to use for filtering. The
        /// filters work as an OR condition: caller gets back related items that match any of
        /// the specified filter types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RelatedItemTypeFilter> Filters
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9000)]
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
        /// Gets and sets the property Sorts. 
        /// <para>
        /// A structured set of sort terms to specify the order in which related items should
        /// be returned. Supports sorting by association time or case ID. The sorts work in the
        /// order specified: first sort term takes precedence over subsequent terms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<SearchAllRelatedItemsSort> Sorts
        {
            get { return this._sorts; }
            set { this._sorts = value; }
        }

        // Check to see if Sorts property is set
        internal bool IsSetSorts()
        {
            return this._sorts != null && (this._sorts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}