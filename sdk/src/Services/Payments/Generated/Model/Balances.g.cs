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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// How much of the record's <c>amount</c> is outstanding, processing, settled, and canceled.
    /// The four balances add up to <c>amount</c>. Each balance is in the currency of <c>amount</c>,
    /// and a balance with nothing in it is 0.
    /// </summary>
    public partial class Balances
    {
        /// <summary>
        /// Gets and sets the property Canceled. 
        /// <para>
        /// The part of the amount that was canceled and isn't settled, for example when an invoice
        /// is voided. When a partly settled record is canceled, it keeps its <c>settled</c> balance,
        /// and the rest of the amount moves to <c>canceled</c>. This balance is more than 0 only
        /// when the <c>status</c> is <c>CANCELED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CurrencyAmount Canceled { get; set; }

        /// <summary>
        /// Checks to see if the Canceled property is set.
        /// </summary>
        internal bool IsSetCanceled() => this.Canceled != null;

        /// <summary>
        /// Gets and sets the property Outstanding. 
        /// <para>
        /// The part of the amount that isn't settled and has no settlement in progress. For an
        /// invoice, this is what remains to pay. For a credit memo, this is the credit that isn't
        /// yet applied. This balance doesn't include <c>processing</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CurrencyAmount Outstanding { get; set; }

        /// <summary>
        /// Checks to see if the Outstanding property is set.
        /// </summary>
        internal bool IsSetOutstanding() => this.Outstanding != null;

        /// <summary>
        /// Gets and sets the property Processing. 
        /// <para>
        /// The part of the amount with a settlement in progress, for example a payment that's
        /// submitted but not yet confirmed. It moves to <c>settled</c> when the settlement completes,
        /// and back to <c>outstanding</c> when the settlement fails. This balance is more than
        /// 0 only when the <c>status</c> is <c>PROCESSING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CurrencyAmount Processing { get; set; }

        /// <summary>
        /// Checks to see if the Processing property is set.
        /// </summary>
        internal bool IsSetProcessing() => this.Processing != null;

        /// <summary>
        /// Gets and sets the property Settled. 
        /// <para>
        /// The part of the amount that is settled. For an invoice, this is the amount paid or
        /// covered by credit memos. For a credit memo, this is the amount applied to invoices.
        /// This balance is 0 when nothing is settled yet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CurrencyAmount Settled { get; set; }

        /// <summary>
        /// Checks to see if the Settled property is set.
        /// </summary>
        internal bool IsSetSettled() => this.Settled != null;
    }
}
