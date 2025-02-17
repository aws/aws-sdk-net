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
    /// Container for the parameters to the UpdateInvoiceUnit operation.
    /// You can update the invoice unit configuration at any time, and Amazon Web Services
    /// will use the latest configuration at the end of the month.
    /// </summary>
    public partial class UpdateInvoiceUnitRequest : AmazonInvoicingRequest
    {
        private string _description;
        private string _invoiceUnitArn;
        private InvoiceUnitRule _rule;
        private bool? _taxInheritanceDisabled;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The assigned description for an invoice unit. This information can't be modified or
        /// deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceUnitArn. 
        /// <para>
        /// The ARN to identify an invoice unit. This information can't be modified or deleted.
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

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The <c>InvoiceUnitRule</c> object used to update invoice units. 
        /// </para>
        /// </summary>
        public InvoiceUnitRule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property TaxInheritanceDisabled. 
        /// <para>
        /// Whether the invoice unit based tax inheritance is/ should be enabled or disabled.
        /// 
        /// </para>
        /// </summary>
        public bool TaxInheritanceDisabled
        {
            get { return this._taxInheritanceDisabled.GetValueOrDefault(); }
            set { this._taxInheritanceDisabled = value; }
        }

        // Check to see if TaxInheritanceDisabled property is set
        internal bool IsSetTaxInheritanceDisabled()
        {
            return this._taxInheritanceDisabled.HasValue; 
        }

    }
}