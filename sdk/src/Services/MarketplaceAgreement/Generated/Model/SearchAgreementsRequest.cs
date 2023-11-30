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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAgreements operation.
    /// Searches across all agreements that a proposer or an acceptor has in AWS Marketplace.
    /// The search returns a list of agreements with basic agreement information.
    /// 
    ///  
    /// <para>
    /// The following filter combinations are supported:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>ResourceIdentifier</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>OfferId</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>Status</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>ResourceIdentifier</code>
    /// + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>OfferId</code>
    /// + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>ResourceType</code>
    /// + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>ResourceType</code> + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>OfferId</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>OfferId</code> + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>ResourceIdentifier</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>ResourceIdentifier</code> + <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PartyType</code> as <code>Proposer</code> + <code>AgreementType</code> + <code>AcceptorAccountId</code>
    /// + <code>ResourceType</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SearchAgreementsRequest : AmazonMarketplaceAgreementRequest
    {
        private string _catalog;
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private Sort _sort;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which the agreement was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filter name and value pair used to return a specific list of results.
        /// </para>
        ///  
        /// <para>
        /// The following filters are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ResourceIdentifier</code> – The unique identifier of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceType</code> – Type of the resource, which is the product (<code>AmiProduct</code>,
        /// <code>ContainerProduct</code>, or <code>SaaSProduct</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PartyType</code> – The party type (either <code>Acceptor</code> or <code>Proposer</code>)
        /// of the caller. For agreements where the caller is the proposer, use the <code>Proposer</code>
        /// filter. For agreements where the caller is the acceptor, use the <code>Acceptor</code>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AcceptorAccountId</code> – The AWS account ID of the party accepting the agreement
        /// terms.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OfferId</code> – The unique identifier of the offer in which the terms are
        /// registered in the agreement token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> – The current status of the agreement. Values include <code>ACTIVE</code>,
        /// <code>ARCHIVED</code>, <code>CANCELLED</code>, <code>EXPIRED</code>, <code>RENEWED</code>,
        /// <code>REPLACED</code>, and <code>TERMINATED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BeforeEndTime</code> – A date used to filter agreements with a date before
        /// the <code>endTime</code> of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AfterEndTime</code> – A date used to filter agreements with a date after the
        /// <code>endTime</code> of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AgreementType</code> – The type of agreement. Values include <code>PurchaseAgreement</code>
        /// or <code>VendorInsightsAgreement</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of agreements to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// A token to specify where to start pagination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property Sort. 
        /// <para>
        /// An object that contains the <code>SortBy</code> and <code>SortOrder</code> attributes.
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