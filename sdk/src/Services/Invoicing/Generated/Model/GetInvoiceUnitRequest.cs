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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Container for the parameters to the GetInvoiceUnit operation.
    /// This retrieves the invoice unit definition.
    /// </summary>
    public partial class GetInvoiceUnitRequest : AmazonInvoicingRequest
    {
        private DateTime? _asOf;
        private string _invoiceUnitArn;

        /// <summary>
        /// Gets and sets the property AsOf. 
        /// <para>
        ///  The state of an invoice unit at a specified time. You can see legacy invoice units
        /// that are currently deleted if the <c>AsOf</c> time is set to before it was deleted.
        /// If an <c>AsOf</c> is not provided, the default value is the current time. 
        /// </para>
        /// </summary>
        public DateTime? AsOf
        {
            get { return this._asOf; }
            set { this._asOf = value; }
        }

        // Check to see if AsOf property is set
        internal bool IsSetAsOf()
        {
            return this._asOf.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvoiceUnitArn. 
        /// <para>
        ///  The ARN to identify an invoice unit. This information can't be modified or deleted.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string InvoiceUnitArn
        {
            get { return this._invoiceUnitArn; }
            set { this._invoiceUnitArn = value; }
        }

        // Check to see if InvoiceUnitArn property is set
        internal bool IsSetInvoiceUnitArn()
        {
            return this._invoiceUnitArn != null;
        }

    }
}