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
    /// Container for the parameters to the AcceptAgreementPaymentRequest operation. Allows
    /// buyers (acceptors) to accept a payment request that is in <c>PENDING_APPROVAL</c>
    /// status. Once accepted, the payment request transitions to <c>APPROVED</c> status and
    /// the charge will be processed. Buyers can optionally provide a purchase order reference
    /// for their internal tracking. <note> <para> Only payment requests in <c>PENDING_APPROVAL</c>
    /// status can be accepted. A <c>ConflictException</c> is thrown if the payment request
    /// is in any other status. </para> </note>
    /// </summary>
    public partial class AcceptAgreementPaymentRequestRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with the payment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property PaymentRequestId. 
        /// <para>
        /// The unique identifier of the payment request to accept.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentRequestId property is set.
        /// </summary>
        internal bool IsSetPaymentRequestId() => this.PaymentRequestId != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderReference. 
        /// <para>
        /// An optional purchase order reference that buyers can provide to associate the payment
        /// request with their internal purchase order system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string PurchaseOrderReference { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderReference property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderReference() => this.PurchaseOrderReference != null;
    }
}
