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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAgreementRequest operation. Creates an agreement
    /// request that acts as a quote for the terms you want to accept. The agreement request
    /// captures the requested terms, calculates charges, and returns a summary. Use <c>AcceptAgreementRequest</c>
    /// with the returned <c>agreementRequestId</c> to finalize the agreement.
    /// </summary>
    public partial class CreateAgreementRequestRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property AgreementProposalIdentifier. 
        /// <para>
        /// The agreement proposal signed by the proposer. The proposal includes the requested
        /// resources and the terms that outline an agreement outcome.
        /// </para>
        ///  <important> 
        /// <para>
        ///  This parameter is required if the intent is not <c>AMEND</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementProposalIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AgreementProposalIdentifier property is set.
        /// </summary>
        internal bool IsSetAgreementProposalIdentifier() => this.AgreementProposalIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The purpose and desired outcome of the agreement request. This is a required parameter
        /// that determines how the agreement request is processed.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c> – Creates a new agreement for terms in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AMEND</c> – Modifies an existing agreement with terms that are accepted in the
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> – Creates a new agreement with accepted terms and replaces the existing
        /// agreement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Intent Intent { get; set; }

        /// <summary>
        /// Checks to see if the Intent property is set.
        /// </summary>
        internal bool IsSetIntent() => this.Intent != null;

        /// <summary>
        /// Gets and sets the property RequestedTerms. 
        /// <para>
        /// A list of terms that define what is being accepted as part of the agreement. Some
        /// terms require configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public List<RequestedTerm> RequestedTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestedTerm>() : null;

        /// <summary>
        /// Checks to see if the RequestedTerms property is set.
        /// </summary>
        internal bool IsSetRequestedTerms() => this.RequestedTerms != null && (this.RequestedTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceAgreementIdentifier. 
        /// <para>
        /// The agreement's identifier that the request acts upon.
        /// </para>
        ///  <important> 
        /// <para>
        ///  This parameter is required for all non-<c>NEW</c> intents (i.e., <c>AMEND</c> or
        /// <c>REPLACE</c>). Don't provide this parameter if the intent is <c>NEW</c>. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceAgreementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceAgreementIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceAgreementIdentifier() => this.SourceAgreementIdentifier != null;

        /// <summary>
        /// Gets and sets the property TaxConfiguration. 
        /// <para>
        /// Configuration for tax estimation in the agreement request response.
        /// </para>
        /// </summary>
        public TaxConfiguration TaxConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TaxConfiguration property is set.
        /// </summary>
        internal bool IsSetTaxConfiguration() => this.TaxConfiguration != null;
    }
}
