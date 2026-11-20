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
    /// Container for the parameters to the GetAccountBalance operation. Retrieves one balance
    /// of your account, selected by balance type, as one amount for each merchant of record
    /// and currency. Each amount is the sum of the outstanding balances of your invoices
    /// or credit memos that have the status <c>OUTSTANDING</c>. Amounts are never added together
    /// across merchants of record or currencies. This operation is eventually consistent.
    /// Results are paginated. Use <c>nextToken</c> to retrieve more results. <para> To use
    /// this operation, you must have Amazon Web Services Identity and Access Management (IAM)
    /// permission for both <c>payments:GetAccountBalance</c> and <c>payments:GetPaymentStatus</c>.
    /// </para>
    /// </summary>
    public partial class GetAccountBalanceRequest : AmazonPaymentsRequest
    {
        /// <summary>
        /// Gets and sets the property BalanceType. 
        /// <para>
        /// The balance to retrieve. You can specify only one balance type in a single request.
        /// Each balance adds up the <c>outstanding</c> balance of the records that have the status
        /// <c>OUTSTANDING</c>. A record that is <c>PROCESSING</c>, <c>SETTLED</c>, or <c>CANCELED</c>
        /// isn't included, even when part of its amount is outstanding. The following values
        /// are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INVOICES_DUE</c> – The outstanding balance of your <c>OUTSTANDING</c> invoices
        /// that aren't past their due date, where <c>dueStatus</c> is <c>DUE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVOICES_PAST_DUE</c> – The outstanding balance of your <c>OUTSTANDING</c> invoices
        /// that are past their due date, where <c>dueStatus</c> is <c>PAST_DUE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTSTANDING_CREDIT_MEMOS</c> – The outstanding balance of your <c>OUTSTANDING</c>
        /// credit memos: the credit that isn't yet applied to an invoice.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public BalanceType BalanceType { get; set; }

        /// <summary>
        /// Checks to see if the BalanceType property is set.
        /// </summary>
        internal bool IsSetBalanceType() => this.BalanceType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one page. The default is 100. A page can
        /// contain fewer results even when more remain. Use <c>nextToken</c> to find out whether
        /// more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from the <c>nextToken</c> of the previous response. Omit it to
        /// get the first page. Tokens expire. If the token is malformed or expired, or doesn't
        /// match the original request, the request fails with <c>ValidationException</c> and
        /// the reason <c>INVALID_PAGINATION_TOKEN</c>. In that case, start again from the first
        /// page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
