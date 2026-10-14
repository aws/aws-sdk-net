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
    /// An individual entry in a batch billing adjustment request, specifying the invoice
    /// and adjustment details.
    /// </summary>
    public partial class BatchCreateBillingAdjustmentRequestEntry
    {
        /// <summary>
        /// Gets and sets the property AdjustmentAmount. 
        /// <para>
        /// The adjustment amount as a string representation of a decimal number in the currency
        /// of the invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AdjustmentAmount { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentAmount property is set.
        /// </summary>
        internal bool IsSetAdjustmentAmount() => this.AdjustmentAmount != null;

        /// <summary>
        /// Gets and sets the property AdjustmentReasonCode. 
        /// <para>
        /// The reason code for the billing adjustment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingAdjustmentReasonCode AdjustmentReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentReasonCode property is set.
        /// </summary>
        internal bool IsSetAdjustmentReasonCode() => this.AdjustmentReasonCode != null;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with the invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The 3-letter ISO 4217 currency code for the adjustment amount. Must match the currency
        /// code of the offer associated with the agreement (e.g., <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional detailed description of the adjustment reason.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OriginalInvoiceId. 
        /// <para>
        /// The identifier of the original invoice to adjust.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OriginalInvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the OriginalInvoiceId property is set.
        /// </summary>
        internal bool IsSetOriginalInvoiceId() => this.OriginalInvoiceId != null;
    }
}
