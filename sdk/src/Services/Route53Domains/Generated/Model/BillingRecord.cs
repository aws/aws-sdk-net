/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BillingRecord
    {
        private DateTime? _billDate;
        private string _domainName;
        private string _invoiceId;
        private OperationType _operation;
        private double? _price;

        /// <summary>
        /// Gets and sets the property BillDate. 
        /// <para>
        /// The date that the operation was billed, in Unix format.
        /// </para>
        ///  
        /// <para>
        /// Type: Double
        /// </para>
        /// </summary>
        public DateTime BillDate
        {
            get { return this._billDate.GetValueOrDefault(); }
            set { this._billDate = value; }
        }

        // Check to see if BillDate property is set
        internal bool IsSetBillDate()
        {
            return this._billDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of a domain.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// The ID of the invoice that is associated with the billing record.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that you were charged for.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Valid values: <ul> <li><code>REGISTER_DOMAIN</code></li> <li><code>TRANSFER_IN_DOMAIN</code></li>
        /// <li><code>RENEW_DOMAIN</code></li> <li><code>CHANGE_DOMAIN_OWNER</code></li> </ul>
        /// 
        /// </para>
        /// </summary>
        public OperationType Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The price that you were charged for the operation, in US dollars.
        /// </para>
        ///  
        /// <para>
        /// Type: Double
        /// </para>
        ///  
        /// <para>
        /// Example value: 12.0
        /// </para>
        /// </summary>
        public double Price
        {
            get { return this._price.GetValueOrDefault(); }
            set { this._price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this._price.HasValue; 
        }

    }
}