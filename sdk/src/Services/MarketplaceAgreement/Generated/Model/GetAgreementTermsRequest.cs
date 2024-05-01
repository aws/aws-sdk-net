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
    /// Container for the parameters to the GetAgreementTerms operation.
    /// Obtains details about the terms in an agreement that you participated in as proposer
    /// or acceptor.
    /// 
    ///  
    /// <para>
    /// The details include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>TermType</c> – The type of term, such as <c>LegalTerm</c>, <c>RenewalTerm</c>,
    /// or <c>ConfigurableUpfrontPricingTerm</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TermID</c> – The ID of the particular term, which is common between offer and
    /// agreement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TermPayload</c> – The key information contained in the term, such as the EULA
    /// for <c>LegalTerm</c> or pricing and dimensions for various pricing terms, such as
    /// <c>ConfigurableUpfrontPricingTerm</c> or <c>UsageBasedPricingTerm</c>.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>Configuration</c> – The buyer/acceptor's selection at the time of agreement creation,
    /// such as the number of units purchased for a dimension or setting the <c>EnableAutoRenew</c>
    /// flag.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetAgreementTermsRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
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
        /// A token to specify where to start pagination
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

    }
}