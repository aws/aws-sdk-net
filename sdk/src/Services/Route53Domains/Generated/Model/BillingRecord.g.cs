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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Information for one billing record.
    /// </summary>
    public partial class BillingRecord
    {
        /// <summary>
        /// Gets and sets the property BillDate. 
        /// <para>
        /// The date that the operation was billed, in Unix format.
        /// </para>
        /// </summary>
        public DateTime? BillDate { get; set; }

        /// <summary>
        /// Checks to see if the BillDate property is set.
        /// </summary>
        internal bool IsSetBillDate() => this.BillDate.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that the billing record applies to. If the domain name contains
        /// characters other than a-z, 0-9, and - (hyphen), such as an internationalized domain
        /// name, then this value is in Punycode. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
        /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// Deprecated property. This field is retained in report structure for backwards compatibility,
        /// but will appear blank.
        /// </para>
        /// </summary>
        public string InvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceId property is set.
        /// </summary>
        internal bool IsSetInvoiceId() => this.InvoiceId != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that you were charged for.
        /// </para>
        /// </summary>
        public OperationType Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The price that you were charged for the operation, in US dollars.
        /// </para>
        ///  
        /// <para>
        /// Example value: 12.0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price.HasValue;
    }
}
