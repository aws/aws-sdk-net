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
    /// Container for the parameters to the SendAgreementPaymentRequest operation.
    /// Allows sellers (proposers) to submit a payment request to buyers (acceptors) for a
    /// specific charge amount for an agreement that includes a <c>VariablePaymentTerm</c>.
    /// The payment request is created in <c>PENDING_APPROVAL</c> status, at which point the
    /// buyer can accept or reject it.
    /// 
    ///  <note> 
    /// <para>
    /// The agreement must be active and have a <c>VariablePaymentTerm</c> to support payment
    /// requests. The <c>chargeAmount</c> must not exceed the remaining available balance
    /// under the <c>VariablePaymentTerm</c> <c>maxTotalChargeAmount</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SendAgreementPaymentRequestRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementId;
        private string _chargeAmount;
        private string _clientToken;
        private string _description;
        private string _name;
        private string _termId;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement for which the payment request is being submitted.
        /// Use <c>GetAgreementTerms</c> to retrieve agreement term details.
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
        /// Gets and sets the property ChargeAmount. 
        /// <para>
        /// The amount requested to be charged to the buyer, positive decimal value in the currency
        /// of the accepted term.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <c>ValidationException</c> is returned if the <c>chargeAmount</c> exceeds the available
        /// balance, if the agreement doesn't have an active <c>VariablePaymentTerm</c>, or if
        /// the <c>termId</c> is invalid.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChargeAmount
        {
            get { return this._chargeAmount; }
            set { this._chargeAmount = value; }
        }

        // Check to see if ChargeAmount property is set
        internal bool IsSetChargeAmount()
        {
            return this._chargeAmount != null;
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
        /// An optional detailed description of the payment request (1-2000 characters).
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the payment request (5-64 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TermId. 
        /// <para>
        /// The unique identifier of the <c>VariablePaymentTerm</c> for the agreement that the
        /// payment request is being sent for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TermId
        {
            get { return this._termId; }
            set { this._termId = value; }
        }

        // Check to see if TermId property is set
        internal bool IsSetTermId()
        {
            return this._termId != null;
        }

    }
}