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
    /// Container for the parameters to the UpdateInvoiceUnit operation. You can update the
    /// invoice unit configuration at any time, and Amazon Web Services will use the latest
    /// configuration at the end of the month.
    /// </summary>
    public partial class UpdateInvoiceUnitRequest : AmazonInvoicingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique, case-sensitive identifier that you provide to ensure idempotency of the
        /// request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Gets and sets the property InvoiceUnitArn. 
        /// <para>
        /// The ARN to identify an invoice unit. This information can't be modified or deleted.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InvoiceUnitArn { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceUnitArn property is set.
        /// </summary>
        internal bool IsSetInvoiceUnitArn() => this.InvoiceUnitArn != null;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The <c>InvoiceUnitRule</c> object used to update invoice units. 
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
