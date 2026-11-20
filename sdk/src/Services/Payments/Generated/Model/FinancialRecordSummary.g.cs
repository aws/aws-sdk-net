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
    /// A financial record as <c>ListFinancialRecords</c> returns it, without the details
    /// that are specific to its type. To get the full record, use <c>GetFinancialRecord</c>
    /// or <c>BatchGetFinancialRecord</c>.
    /// </summary>
    public partial class FinancialRecordSummary
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The total amount of the financial record, in the currency that the record was issued
        /// in. The amount doesn't change as the record is settled. <c>balances</c> shows how
        /// much of it is in each settlement state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CurrencyAmount Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property Balances. 
        /// <para>
        /// How much of <c>amount</c> is outstanding, processing, settled, and canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Balances Balances { get; set; }

        /// <summary>
        /// Checks to see if the Balances property is set.
        /// </summary>
        internal bool IsSetBalances() => this.Balances != null;

        /// <summary>
        /// Gets and sets the property BusinessUnit. 
        /// <para>
        /// The Amazon Web Services business unit that issued the record: its merchant of record
        /// and its line of business.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BusinessUnit BusinessUnit { get; set; }

        /// <summary>
        /// Checks to see if the BusinessUnit property is set.
        /// </summary>
        internal bool IsSetBusinessUnit() => this.BusinessUnit != null;

        /// <summary>
        /// Gets and sets the property ClosedAt. 
        /// <para>
        /// The date and time, in UTC, when the record was last closed, that is, when its <c>status</c>
        /// last became <c>SETTLED</c> or <c>CANCELED</c>. This member is absent while the <c>settlementStatus</c>
        /// is <c>OPEN</c>, including after a closed record reopens.
        /// </para>
        /// </summary>
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Checks to see if the ClosedAt property is set.
        /// </summary>
        internal bool IsSetClosedAt() => this.ClosedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Amazon Web Services Payments issued for the record. To retrieve the full
        /// record, pass this value to <c>GetFinancialRecord</c> or <c>BatchGetFinancialRecord</c>
        /// as <c>identifier</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 23)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The date and time, in UTC, when this record was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SettlementStatus. 
        /// <para>
        /// Whether the record is open or closed. If you receive a <c>status</c> value that you
        /// don't recognize, use this member to tell open records from closed ones. The following
        /// values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OPEN</c> – Part of the amount is outstanding or processing. The <c>status</c>
        /// is <c>OUTSTANDING</c> or <c>PROCESSING</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLOSED</c> – The whole amount is settled or canceled. The <c>status</c> is <c>SETTLED</c>
        /// or <c>CANCELED</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <c>CLOSED</c> record becomes <c>OPEN</c> again if a payment or credit applied to
        /// it is reversed. Its <c>closedAt</c> is then absent until the record closes again.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SettlementStatus SettlementStatus { get; set; }

        /// <summary>
        /// Checks to see if the SettlementStatus property is set.
        /// </summary>
        internal bool IsSetSettlementStatus() => this.SettlementStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The settlement stage of the record. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OUTSTANDING</c> – Part of the amount isn't settled, and no settlement is in progress
        /// on the record. For an invoice, <c>dueStatus</c> shows whether it's due or past due.
        /// The <c>settlementStatus</c> is <c>OPEN</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROCESSING</c> – A settlement of part or all of the amount is in progress, for
        /// example a payment that's submitted but not yet confirmed. <c>PROCESSING</c> takes
        /// precedence over <c>OUTSTANDING</c>: while any part of the amount is processing, the
        /// status is <c>PROCESSING</c>, even if another part is still outstanding. The <c>settlementStatus</c>
        /// is <c>OPEN</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SETTLED</c> – The whole amount is settled. The <c>settlementStatus</c> is <c>CLOSED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> – The record is canceled. The part of the amount that wasn't settled
        /// isn't collected or applied. The <c>settlementStatus</c> is <c>CLOSED</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FinancialRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the financial record. On the full record, the populated member of <c>details</c>
        /// matches this type. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INVOICE</c> – An invoice: a bill from Amazon Web Services. Payments and credit
        /// memos applied to the invoice settle it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREDIT_MEMO</c> – A credit memo: a credit issued to your account, for example
        /// for a billing correction or a service credit. Applying it to one or more invoices
        /// settles it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FinancialRecordType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
