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
    /// Container for the parameters to the CreateInvoiceUnit operation.
    /// This creates a new invoice unit with the provided definition.
    /// </summary>
    public partial class CreateInvoiceUnitRequest : AmazonInvoicingRequest
    {
        private string _description;
        private string _invoiceReceiver;
        private string _name;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;
        private InvoiceUnitRule _rule;
        private bool? _taxInheritanceDisabled;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The invoice unit's description. This can be changed at a later time. 
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
        /// Gets and sets the property InvoiceReceiver. 
        /// <para>
        ///  The Amazon Web Services account ID chosen to be the receiver of an invoice unit.
        /// All invoices generated for that invoice unit will be sent to this account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InvoiceReceiver
        {
            get { return this._invoiceReceiver; }
            set { this._invoiceReceiver = value; }
        }

        // Check to see if InvoiceReceiver property is set
        internal bool IsSetInvoiceReceiver()
        {
            return this._invoiceReceiver != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The unique name of the invoice unit that is shown on the generated invoice. This
        /// can't be changed once it is set. To change this name, you must delete the invoice
        /// unit recreate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  The tag structure that contains a tag key and value. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The <c>InvoiceUnitRule</c> object used to create invoice units. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        public bool? TaxInheritanceDisabled
        {
            get { return this._taxInheritanceDisabled; }
            set { this._taxInheritanceDisabled = value; }
        }

        // Check to see if TaxInheritanceDisabled property is set
        internal bool IsSetTaxInheritanceDisabled()
        {
            return this._taxInheritanceDisabled.HasValue; 
        }

    }
}