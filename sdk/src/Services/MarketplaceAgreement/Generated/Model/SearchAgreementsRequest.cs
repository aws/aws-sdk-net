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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAgreements operation.
    /// Searches across all agreements that a proposer or an acceptor has in AWS Marketplace.
    /// The search returns a list of agreements with basic agreement information.
    /// </summary>
    public partial class SearchAgreementsRequest : AmazonMarketplaceAgreementRequest
    {
        private string _catalog;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
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
        ///  <c>ResourceIdentifier</c> – The unique identifier of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> – Type of the resource, which is the product (<c>AmiProduct</c>,
        /// <c>ContainerProduct</c>, <c>SaaSProduct</c>, <c>ProfessionalServicesProduct</c>, or
        /// <c>MachineLearningProduct</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> – The party type of the caller. Use <c>Proposer</c> or <c>Acceptor</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AcceptorAccountId</c> – The AWS account ID of the party accepting the agreement
        /// terms.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OfferId</c> – The unique identifier of the offer in which the terms are registered
        /// in the agreement token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c> – The current status of the agreement. Values include <c>ACTIVE</c>,
        /// <c>CANCELLED</c>, <c>EXPIRED</c>, <c>RENEWED</c>, <c>REPLACED</c>, and <c>TERMINATED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BeforeEndTime</c> – A date used to filter agreements with a date before the <c>endTime</c>
        /// of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AfterEndTime</c> – A date used to filter agreements with a date after the <c>endTime</c>
        /// of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BeforeStartTime</c> – A date used to filter agreements with a date before the
        /// <c>startTime</c> of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AfterStartTime</c> – A date used to filter agreements with a date after the <c>startTime</c>
        /// of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BeforeLastUpdateTime</c> – A date used to filter agreements with a date before
        /// the <c>lastUpdateTime</c> of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AfterLastUpdateTime</c> – A date used to filter agreements with a date after the
        /// <c>lastUpdateTime</c> of an agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> – The type of agreement. Supported value includes <c>PurchaseAgreement</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OfferSetId</c> – A unique identifier for the offer set containing this offer.
        /// All agreements created from offers in this set include this identifier as context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EndTimeBehaviorType</c> – What happens to the agreement when it reaches its end
        /// date. Values include <c>RENEW</c>, <c>REPLACE</c>, and <c>EXPIRE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EndTimeBehaviorReasonCode</c> – The reason why the agreement doesn't renew at
        /// its end date. Values include <c>PROPOSER_RENEW_OPTED_OUT</c>, <c>ACCEPTOR_RENEW_OPTED_OUT</c>,
        /// <c>NO_RENEWAL_TERM</c>, and <c>RENEWAL_LIMIT_EXHAUSTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InitialAgreementId</c> – The unique identifier of the very first agreement in
        /// a chain of related agreements. Use this filter to return every agreement in the same
        /// chain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LicenseArn</c> – The Amazon Resource Name (ARN) of the AWS License Manager license
        /// associated with an entitlement granted by the agreement.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A proposer can use any combination of the preceding filters along with <c>AgreementType</c>,
        /// which is required.
        /// </para>
        ///  
        /// <para>
        /// The following filter combinations are supported when the <c>PartyType</c> is <c>Acceptor</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AgreementType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceIdentifier</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceIdentifier</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceIdentifier</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceIdentifier</c> + <c>Status</c> + <c>EndTime</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceType</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To filter by <c>EndTime</c>, you can use <c>BeforeEndTime</c>, <c>AfterEndTime</c>,
        /// or both.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of agreements to return in the response.
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
        /// An object that contains the <c>SortBy</c> and <c>SortOrder</c> attributes. For <c>SearchAgreements</c>,
        /// <c>SortBy</c> supports <c>EndTime</c> for both party types, and <c>StartTime</c> and
        /// <c>LastUpdateTime</c> only when <c>PartyType</c> is <c>Proposer</c>. The default <c>SortBy</c>
        /// value is <c>EndTime</c>.
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