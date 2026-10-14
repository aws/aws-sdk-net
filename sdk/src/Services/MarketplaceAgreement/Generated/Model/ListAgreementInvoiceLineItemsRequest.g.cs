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
    /// Container for the parameters to the ListAgreementInvoiceLineItems operation. Allows
    /// sellers (proposers) to retrieve aggregated billing data from AWS Marketplace agreements
    /// using flexible grouping. Supports invoice-level aggregation with filtering by billing
    /// period, invoice type, and issued date. <note> <para> The <c>groupBy</c> parameter
    /// is required and supports only <c>INVOICE_ID</c> as a value. The <c>agreementId</c>
    /// parameter is required. </para> </note>
    /// </summary>
    public partial class ListAgreementInvoiceLineItemsRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property AfterIssuedTime. 
        /// <para>
        /// An optional filter for invoices issued after the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? AfterIssuedTime { get; set; }

        /// <summary>
        /// Checks to see if the AfterIssuedTime property is set.
        /// </summary>
        internal bool IsSetAfterIssuedTime() => this.AfterIssuedTime.HasValue;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property BeforeIssuedTime. 
        /// <para>
        /// An optional filter for invoices issued before the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? BeforeIssuedTime { get; set; }

        /// <summary>
        /// Checks to see if the BeforeIssuedTime property is set.
        /// </summary>
        internal bool IsSetBeforeIssuedTime() => this.BeforeIssuedTime.HasValue;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// Specifies a grouping strategy for line items. Currently supports <c>INVOICE_ID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LineItemGroupBy GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

        /// <summary>
        /// Gets and sets the property InvoiceBillingPeriod. 
        /// <para>
        /// An optional filter for the billing period associated with the invoice.
        /// </para>
        /// </summary>
        public InvoiceBillingPeriod InvoiceBillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceBillingPeriod property is set.
        /// </summary>
        internal bool IsSetInvoiceBillingPeriod() => this.InvoiceBillingPeriod != null;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// An optional filter to retrieve invoice information for a specific invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceId property is set.
        /// </summary>
        internal bool IsSetInvoiceId() => this.InvoiceId != null;

        /// <summary>
        /// Gets and sets the property InvoiceType. 
        /// <para>
        /// An optional filter for the type of invoice. Valid values are <c>INVOICE</c> and <c>CREDIT_MEMO</c>.
        /// </para>
        /// </summary>
        public InvoiceType InvoiceType { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceType property is set.
        /// </summary>
        internal bool IsSetInvoiceType() => this.InvoiceType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start pagination.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
