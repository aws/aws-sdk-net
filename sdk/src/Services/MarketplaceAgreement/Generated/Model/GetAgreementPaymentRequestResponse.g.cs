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
    /// This is the response object from the GetAgreementPaymentRequest operation.
    /// </summary>
    public partial class GetAgreementPaymentRequestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with this payment request. Use <c>DescribeAgreement</c>
        /// to retrieve full agreement details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property ChargeAmount. 
        /// <para>
        /// The amount charged or to be charged to the buyer.
        /// </para>
        /// </summary>
        public string ChargeAmount { get; set; }

        /// <summary>
        /// Checks to see if the ChargeAmount property is set.
        /// </summary>
        internal bool IsSetChargeAmount() => this.ChargeAmount != null;

        /// <summary>
        /// Gets and sets the property ChargeId. 
        /// <para>
        /// The unique identifier of the charge created after the payment request is approved.
        /// This field is only present for approved payment requests and follows the pattern <c>ch-[a-zA-Z0-9]+</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ChargeId { get; set; }

        /// <summary>
        /// Checks to see if the ChargeId property is set.
        /// </summary>
        internal bool IsSetChargeId() => this.ChargeId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the payment request was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the charge amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the payment request, if provided.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the payment request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PaymentRequestId. 
        /// <para>
        /// The unique identifier of the payment request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentRequestId property is set.
        /// </summary>
        internal bool IsSetPaymentRequestId() => this.PaymentRequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the payment request. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VALIDATING</c> – The payment request is being validated against agreement terms.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VALIDATION_FAILED</c> – The payment request failed validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_APPROVAL</c> – The payment request is awaiting buyer action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPROVED</c> – The buyer has approved the payment request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> – The buyer has rejected the payment request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> – The seller has cancelled the payment request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PaymentRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// An optional message providing additional context about the payment request status,
        /// such as a rejection reason or validation failure details.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the payment request was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
