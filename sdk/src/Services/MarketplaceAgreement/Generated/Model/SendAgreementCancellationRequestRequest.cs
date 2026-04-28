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
    /// Container for the parameters to the SendAgreementCancellationRequest operation.
    /// Allows sellers (proposers) to submit a cancellation request for an active agreement.
    /// The cancellation request is created in <c>PENDING_APPROVAL</c> status, at which point
    /// the buyer can review it.
    /// </summary>
    public partial class SendAgreementCancellationRequestRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementId;
        private string _clientToken;
        private string _description;
        private AgreementCancellationRequestReasonCode _reasonCode;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement for which the cancellation request is being
        /// submitted.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional detailed description of the cancellation reason (1-2000 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason code for the cancellation request. Valid values include <c>INCORRECT_TERMS_ACCEPTED</c>,
        /// <c>REPLACING_AGREEMENT</c>, <c>TEST_AGREEMENT</c>, <c>ALTERNATIVE_PROCUREMENT_CHANNEL</c>,
        /// <c>PRODUCT_DISCONTINUED</c>, <c>UNINTENDED_RENEWAL</c>, <c>BUYER_DISSATISFACTION</c>,
        /// and <c>OTHER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgreementCancellationRequestReasonCode ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

    }
}