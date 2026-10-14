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
    /// An invoice unit is a set of mutually exclusive accounts that correspond to your business
    /// entity. Invoice units allow you separate Amazon Web Services account costs and configures
    /// your invoice for each business entity going forward.
    /// </summary>
    public partial class InvoiceUnit
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The assigned description for an invoice unit. This information can't be modified or
        /// deleted. 
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
        /// The account that receives invoices related to the invoice unit. 
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
        /// ARN to identify an invoice unit. This information can't be modified or deleted. 
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
        ///  The last time the invoice unit was updated. This is important to determine the version
        /// of invoice unit configuration used to create the invoices. Any invoice created after
        /// this modified time will use this invoice unit configuration. 
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
        ///  A unique name that is distinctive within your Amazon Web Services. 
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
        /// <para>
        ///  An <c>InvoiceUnitRule</c> object used the categorize invoice units. 
        /// </para>
        /// </summary>
        public InvoiceUnitRule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property TaxInheritanceDisabled. 
        /// <para>
        /// Whether the invoice unit based tax inheritance is/ should be enabled or disabled.
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
