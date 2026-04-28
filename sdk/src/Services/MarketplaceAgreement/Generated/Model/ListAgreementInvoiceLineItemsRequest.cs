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
    /// Container for the parameters to the ListAgreementInvoiceLineItems operation.
    /// Allows sellers (proposers) to retrieve aggregated billing data from AWS Marketplace
    /// agreements using flexible grouping. Supports invoice-level aggregation with filtering
    /// by billing period, invoice type, and issued date.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>groupBy</c> parameter is required and currently supports only <c>INVOICE_ID</c>
    /// as a value. The <c>agreementId</c> parameter is required.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListAgreementInvoiceLineItemsRequest : AmazonMarketplaceAgreementRequest
    {
        private DateTime? _afterIssuedTime;
        private string _agreementId;
        private DateTime? _beforeIssuedTime;
        private LineItemGroupBy _groupBy;
        private InvoiceBillingPeriod _invoiceBillingPeriod;
        private string _invoiceId;
        private InvoiceType _invoiceType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AfterIssuedTime. 
        /// <para>
        /// An optional filter for invoices issued after the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? AfterIssuedTime
        {
            get { return this._afterIssuedTime; }
            set { this._afterIssuedTime = value; }
        }

        // Check to see if AfterIssuedTime property is set
        internal bool IsSetAfterIssuedTime()
        {
            return this._afterIssuedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
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
        /// Gets and sets the property BeforeIssuedTime. 
        /// <para>
        /// An optional filter for invoices issued before the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? BeforeIssuedTime
        {
            get { return this._beforeIssuedTime; }
            set { this._beforeIssuedTime = value; }
        }

        // Check to see if BeforeIssuedTime property is set
        internal bool IsSetBeforeIssuedTime()
        {
            return this._beforeIssuedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// Specifies a grouping strategy for line items. Currently supports <c>INVOICE_ID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LineItemGroupBy GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceBillingPeriod. 
        /// <para>
        /// An optional filter for the billing period associated with the invoice.
        /// </para>
        /// </summary>
        public InvoiceBillingPeriod InvoiceBillingPeriod
        {
            get { return this._invoiceBillingPeriod; }
            set { this._invoiceBillingPeriod = value; }
        }

        // Check to see if InvoiceBillingPeriod property is set
        internal bool IsSetInvoiceBillingPeriod()
        {
            return this._invoiceBillingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// An optional filter to retrieve invoice information for a specific invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string InvoiceId
        {
            get { return this._invoiceId; }
            set { this._invoiceId = value; }
        }

        // Check to see if InvoiceId property is set
        internal bool IsSetInvoiceId()
        {
            return this._invoiceId != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceType. 
        /// <para>
        /// An optional filter for the type of invoice. Valid values are <c>INVOICE</c> and <c>CREDIT_MEMO</c>.
        /// </para>
        /// </summary>
        public InvoiceType InvoiceType
        {
            get { return this._invoiceType; }
            set { this._invoiceType = value; }
        }

        // Check to see if InvoiceType property is set
        internal bool IsSetInvoiceType()
        {
            return this._invoiceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start pagination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}