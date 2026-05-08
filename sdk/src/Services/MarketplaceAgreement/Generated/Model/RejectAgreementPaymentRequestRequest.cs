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
    /// Container for the parameters to the RejectAgreementPaymentRequest operation.
    /// Allows buyers (acceptors) to reject a payment request that is in <c>PENDING_APPROVAL</c>
    /// status. Once rejected, the payment request transitions to <c>REJECTED</c> status and
    /// cannot be accepted. Buyers can optionally provide a reason for the rejection.
    /// 
    ///  <note> 
    /// <para>
    /// Only payment requests in <c>PENDING_APPROVAL</c> status can be rejected. A <c>ConflictException</c>
    /// is thrown if the payment request is in any other status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RejectAgreementPaymentRequestRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementId;
        private string _paymentRequestId;
        private string _rejectionReason;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with the payment request.
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
        /// Gets and sets the property PaymentRequestId. 
        /// <para>
        /// The unique identifier of the payment request to reject.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PaymentRequestId
        {
            get { return this._paymentRequestId; }
            set { this._paymentRequestId = value; }
        }

        // Check to see if PaymentRequestId property is set
        internal bool IsSetPaymentRequestId()
        {
            return this._paymentRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// An optional reason for rejecting the payment request (1-250 characters). This message
        /// is visible to the seller.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

    }
}