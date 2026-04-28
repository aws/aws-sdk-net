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
    /// An individual entry in a batch billing adjustment request, specifying the invoice
    /// and adjustment details.
    /// </summary>
    public partial class BatchCreateBillingAdjustmentRequestEntry
    {
        private string _adjustmentAmount;
        private BillingAdjustmentReasonCode _adjustmentReasonCode;
        private string _agreementId;
        private string _clientToken;
        private string _currencyCode;
        private string _description;
        private string _originalInvoiceId;

        /// <summary>
        /// Gets and sets the property AdjustmentAmount. 
        /// <para>
        /// The adjustment amount as a string representation of a decimal number in the currency
        /// of the invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdjustmentAmount
        {
            get { return this._adjustmentAmount; }
            set { this._adjustmentAmount = value; }
        }

        // Check to see if AdjustmentAmount property is set
        internal bool IsSetAdjustmentAmount()
        {
            return this._adjustmentAmount != null;
        }

        /// <summary>
        /// Gets and sets the property AdjustmentReasonCode. 
        /// <para>
        /// The reason code for the billing adjustment. Valid values include <c>INCORRECT_TERMS_ACCEPTED</c>,
        /// <c>INCORRECT_METERING</c>, <c>TEST_ENVIRONMENT_CHARGES</c>, <c>ALTERNATIVE_PROCUREMENT_CHANNEL</c>,
        /// <c>UNINTENDED_RENEWAL</c>, <c>BUYER_DISSATISFACTION</c>, and <c>OTHER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillingAdjustmentReasonCode AdjustmentReasonCode
        {
            get { return this._adjustmentReasonCode; }
            set { this._adjustmentReasonCode = value; }
        }

        // Check to see if AdjustmentReasonCode property is set
        internal bool IsSetAdjustmentReasonCode()
        {
            return this._adjustmentReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with the invoice.
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
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The 3-letter ISO 4217 currency code for the adjustment amount (e.g., <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional detailed description of the adjustment reason.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
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
        /// Gets and sets the property OriginalInvoiceId. 
        /// <para>
        /// The identifier of the original invoice to adjust.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OriginalInvoiceId
        {
            get { return this._originalInvoiceId; }
            set { this._originalInvoiceId = value; }
        }

        // Check to see if OriginalInvoiceId property is set
        internal bool IsSetOriginalInvoiceId()
        {
            return this._originalInvoiceId != null;
        }

    }
}