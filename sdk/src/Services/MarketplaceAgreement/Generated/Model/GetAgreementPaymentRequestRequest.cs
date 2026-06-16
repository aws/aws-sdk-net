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
    /// Container for the parameters to the GetAgreementPaymentRequest operation.
    /// Retrieves detailed information about a specific payment request. Both sellers (proposers)
    /// and buyers (acceptors) can use this operation to view payment requests associated
    /// with their agreements. The response includes the current status, charge details, timestamps,
    /// and the charge ID if the request has been approved.
    /// 
    ///  <note> 
    /// <para>
    /// The calling identity must be either the acceptor or proposer of the payment request.
    /// A <c>ResourceNotFoundException</c> is returned if the payment request does not exist.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetAgreementPaymentRequestRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementId;
        private string _paymentRequestId;

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
        /// The identifier of the payment request.
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

    }
}