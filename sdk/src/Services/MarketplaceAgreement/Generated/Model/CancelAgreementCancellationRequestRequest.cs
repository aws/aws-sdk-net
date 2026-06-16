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
    /// Container for the parameters to the CancelAgreementCancellationRequest operation.
    /// Allows sellers (proposers) to withdraw an existing agreement cancellation request
    /// that is in a pending state. Once cancelled, the cancellation request transitions to
    /// <c>CANCELLED</c> status and can no longer be approved or rejected by the buyer.
    /// 
    ///  <note> 
    /// <para>
    /// Only cancellation requests in <c>PENDING_APPROVAL</c> status can be cancelled. A <c>ConflictException</c>
    /// is thrown if the cancellation request is in any other status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CancelAgreementCancellationRequestRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementCancellationRequestId;
        private string _agreementId;
        private string _cancellationReason;

        /// <summary>
        /// Gets and sets the property AgreementCancellationRequestId. 
        /// <para>
        /// The unique identifier of the cancellation request to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AgreementCancellationRequestId
        {
            get { return this._agreementCancellationRequestId; }
            set { this._agreementCancellationRequestId = value; }
        }

        // Check to see if AgreementCancellationRequestId property is set
        internal bool IsSetAgreementCancellationRequestId()
        {
            return this._agreementCancellationRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with the cancellation request.
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
        /// Gets and sets the property CancellationReason. 
        /// <para>
        /// A required message explaining why the cancellation request is being withdrawn (1-2000
        /// characters).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2000)]
        public string CancellationReason
        {
            get { return this._cancellationReason; }
            set { this._cancellationReason = value; }
        }

        // Check to see if CancellationReason property is set
        internal bool IsSetCancellationReason()
        {
            return this._cancellationReason != null;
        }

    }
}