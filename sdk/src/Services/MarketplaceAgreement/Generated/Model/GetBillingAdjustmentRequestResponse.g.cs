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
    /// This is the response object from the GetBillingAdjustmentRequest operation.
    /// </summary>
    public partial class GetBillingAdjustmentRequestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdjustmentAmount. 
        /// <para>
        /// The adjustment amount as a string representation of a decimal number.
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
        /// The unique identifier of the agreement associated with this billing adjustment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property BillingAdjustmentRequestId. 
        /// <para>
        /// The unique identifier of the billing adjustment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string BillingAdjustmentRequestId { get; set; }

        /// <summary>
        /// Checks to see if the BillingAdjustmentRequestId property is set.
        /// </summary>
        internal bool IsSetBillingAdjustmentRequestId() => this.BillingAdjustmentRequestId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the billing adjustment request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the adjustment amount (e.g., <c>USD</c>).
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
        /// The detailed description of the billing adjustment reason, if provided.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OriginalInvoiceId. 
        /// <para>
        /// The identifier of the original invoice being adjusted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OriginalInvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the OriginalInvoiceId property is set.
        /// </summary>
        internal bool IsSetOriginalInvoiceId() => this.OriginalInvoiceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the billing adjustment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingAdjustmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional context about the billing adjustment request status.
        /// This field is populated only when the status is <c>VALIDATION_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the billing adjustment request was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
