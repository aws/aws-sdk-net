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
    /// Container for the parameters to the RejectAgreementApproval operation. Allows the
    /// management account or a delegated administrator of the buyer's AWS organization to
    /// reject an agreement approval that is in <c>PENDING_APPROVAL</c> status, as the organization
    /// administrator approver or on behalf of another approver. Once rejected, the agreement
    /// approval and its agreement request transition to <c>REJECTED</c> status. You must
    /// provide a reason for the rejection.
    /// </summary>
    public partial class RejectAgreementApprovalRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property BuyerAgreementApprovalRejectionInput. 
        /// <para>
        /// The rejection decision for an agreement approval that the buyer's organization requires.
        /// </para>
        /// </summary>
        public BuyerAgreementApprovalRejectionInput BuyerAgreementApprovalRejectionInput { get; set; }

        /// <summary>
        /// Checks to see if the BuyerAgreementApprovalRejectionInput property is set.
        /// </summary>
        internal bool IsSetBuyerAgreementApprovalRejectionInput() => this.BuyerAgreementApprovalRejectionInput != null;
    }
}
