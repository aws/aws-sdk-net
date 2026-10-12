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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// This is the response object from the GetInvoiceUnit operation.
    /// </summary>
    public partial class GetInvoiceUnitResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The assigned description for an invoice unit. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InvoiceReceiver. 
        /// <para>
        ///  The Amazon Web Services account ID chosen to be the receiver of an invoice unit.
        /// All invoices generated for that invoice unit will be sent to this account ID. 
        /// </para>
        /// </summary>
        public string InvoiceReceiver { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceReceiver property is set.
        /// </summary>
        internal bool IsSetInvoiceReceiver() => this.InvoiceReceiver != null;

        /// <summary>
        /// Gets and sets the property InvoiceUnitArn. 
        /// <para>
        ///  The ARN to identify an invoice unit. This information can't be modified or deleted.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InvoiceUnitArn { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceUnitArn property is set.
        /// </summary>
        internal bool IsSetInvoiceUnitArn() => this.InvoiceUnitArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        ///  The most recent date the invoice unit response was updated. 
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The unique name of the invoice unit that is shown on the generated invoice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rule.
        /// </summary>
        public InvoiceUnitRule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property TaxInheritanceDisabled. 
        /// <para>
        ///  Whether the invoice unit based tax inheritance is/ should be enabled or disabled.
        /// 
        /// </para>
        /// </summary>
        public bool? TaxInheritanceDisabled { get; set; }

        /// <summary>
        /// Checks to see if the TaxInheritanceDisabled property is set.
        /// </summary>
        internal bool IsSetTaxInheritanceDisabled() => this.TaxInheritanceDisabled.HasValue;
    }
}
