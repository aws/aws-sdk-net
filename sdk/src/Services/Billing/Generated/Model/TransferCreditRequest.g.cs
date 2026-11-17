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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the TransferCredit operation. Moves a credit to another
    /// account in the same consolidated billing family. The credit keeps its ID, balance,
    /// end date, and applicable products. Only the account that owns the credit changes.
    /// <para> The transfer removes the credit's sharing settings. The new owner or the payer
    /// can set them again. Any amount reserved for a bill that isn't finalized moves with
    /// the credit and still applies to that bill. </para> <para> You must be the payer of
    /// both accounts. You can't transfer a credit that has ended, has no available balance,
    /// or is the original credit of a split. A transfer creates no credit, so it doesn't
    /// count toward the split limit, and the payer can transfer the credit back. This operation
    /// is idempotent and supports a dry run. </para>
    /// </summary>
    public partial class TransferCreditRequest : AmazonBillingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry a successful request with the same client
        /// token and parameters, the retry completes without performing any further actions.
        /// If you reuse a client token with different parameters, the request fails with a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreditId. 
        /// <para>
        /// The ID of the credit to transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string CreditId { get; set; }

        /// <summary>
        /// Checks to see if the CreditId property is set.
        /// </summary>
        internal bool IsSetCreditId() => this.CreditId != null;

        /// <summary>
        /// Gets and sets the property DestinationAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that becomes the owner of the credit. The account
        /// must be in your consolidated billing family and must not be the current owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationAccountId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAccountId property is set.
        /// </summary>
        internal bool IsSetDestinationAccountId() => this.DestinationAccountId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request and return the result without changing the
        /// credit.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;
    }
}
