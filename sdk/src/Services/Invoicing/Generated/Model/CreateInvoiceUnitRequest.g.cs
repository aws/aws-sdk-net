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
    /// Container for the parameters to the CreateInvoiceUnit operation. This creates a new
    /// invoice unit with the provided definition.
    /// </summary>
    public partial class CreateInvoiceUnitRequest : AmazonInvoicingRequest
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
        ///  The invoice unit's description. This can be changed at a later time. 
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
        [AWSProperty(Required = true)]
        public string InvoiceReceiver { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceReceiver property is set.
        /// </summary>
        internal bool IsSetInvoiceReceiver() => this.InvoiceReceiver != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The unique name of the invoice unit that is shown on the generated invoice. This
        /// can't be changed once it is set. To change this name, you must delete the invoice
        /// unit recreate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  The tag structure that contains a tag key and value. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The <c>InvoiceUnitRule</c> object used to create invoice units. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
