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
    /// Container for the parameters to the SplitCredit operation. Splits the available balance
    /// of a credit into 2 to 99 new credits in the same account, and cancels the original
    /// credit. The new credits keep the original credit's end date and applicable products.
    /// <para> The available balance is the remaining balance minus any amount reserved for
    /// a bill that isn't finalized. The portions must add up to exactly the available balance.
    /// Each portion must be at least 100.00 in the currency of the credit. For example, if
    /// the credit is in USD, each portion must be at least USD $100.00. A reserved amount
    /// stays on the original credit and still applies to that bill. </para> <para> A credit
    /// and every credit split from it count toward a limit of 100 credits. After a split,
    /// you can't split or transfer the original credit. You can split or transfer its new
    /// credits, and you can split a credit after you transfer it. </para> <para> You must
    /// own the credit or be the payer of the account that owns it. You can't undo a split.
    /// This operation is idempotent and supports a dry run. </para>
    /// </summary>
    public partial class SplitCreditRequest : AmazonBillingRequest
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
        /// The ID of the credit to split.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string CreditId { get; set; }

        /// <summary>
        /// Checks to see if the CreditId property is set.
        /// </summary>
        internal bool IsSetCreditId() => this.CreditId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request and return the result without changing any
        /// credit.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Portions. 
        /// <para>
        /// The new credits to create, one for each portion, in the order listed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 99)]
        public List<SplitPortion> Portions { get; set; } = AWSConfigs.InitializeCollections ? new List<SplitPortion>() : null;

        /// <summary>
        /// Checks to see if the Portions property is set.
        /// </summary>
        internal bool IsSetPortions() => this.Portions != null && (this.Portions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
