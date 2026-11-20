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
    /// Container for the parameters to the ListFinancialRecords operation. Lists the financial
    /// records on your account, with the newest first by default. A financial record is an
    /// invoice or a credit memo. You must specify at least one record type in <c>types</c>.
    /// You can narrow the results further by settlement status and issue date. This operation
    /// returns summaries. To get the details that are specific to a record's type, use <c>GetFinancialRecord</c>
    /// or <c>BatchGetFinancialRecord</c>. Results are paginated. Use <c>nextToken</c> to
    /// retrieve more results. <para> To use this operation, you must have Amazon Web Services
    /// Identity and Access Management (IAM) permission for both <c>payments:ListFinancialRecords</c>
    /// and <c>payments:GetPaymentStatus</c>. </para>
    /// </summary>
    public partial class ListFinancialRecordsRequest : AmazonPaymentsRequest
    {
        /// <summary>
        /// Gets and sets the property IssuedAfter. 
        /// <para>
        /// The earliest date and time to return records for, inclusive. The operation returns
        /// the records that were issued at or after this time.
        /// </para>
        /// </summary>
        public DateTime? IssuedAfter { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAfter property is set.
        /// </summary>
        internal bool IsSetIssuedAfter() => this.IssuedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedBefore. 
        /// <para>
        /// The latest date and time to return records for, exclusive. The operation returns the
        /// records that were issued before this time. When you specify both <c>issuedAfter</c>
        /// and <c>issuedBefore</c>, <c>issuedBefore</c> must be later than <c>issuedAfter</c>.
        /// </para>
        /// </summary>
        public DateTime? IssuedBefore { get; set; }

        /// <summary>
        /// Checks to see if the IssuedBefore property is set.
        /// </summary>
        internal bool IsSetIssuedBefore() => this.IssuedBefore.HasValue;

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

        /// <summary>
        /// Gets and sets the property SettlementStatuses. 
        /// <para>
        /// The settlement statuses to filter by. <c>OPEN</c> returns records whose <c>status</c>
        /// is <c>OUTSTANDING</c> or <c>PROCESSING</c>. <c>CLOSED</c> returns records whose <c>status</c>
        /// is <c>SETTLED</c> or <c>CANCELED</c>. When you omit this member, the operation returns
        /// records with both settlement statuses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> SettlementStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SettlementStatuses property is set.
        /// </summary>
        internal bool IsSetSettlementStatuses() => this.SettlementStatuses != null && (this.SettlementStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort the results by. The default is <c>ISSUED_AT</c>, the date and time
        /// when the record was issued.
        /// </para>
        /// </summary>
        public FinancialRecordSortField SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort the results in. The default is <c>DESCENDING</c>, which returns
        /// the newest records first. <c>ASCENDING</c> returns the oldest records first.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The financial record types to return. The following values are valid:
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<string> Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Types property is set.
        /// </summary>
        internal bool IsSetTypes() => this.Types != null && (this.Types.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
