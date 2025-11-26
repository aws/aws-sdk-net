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
    /// Container for the parameters to the PutProcurementPortalPreference operation.
    /// Updates an existing procurement portal preference configuration. This operation can
    /// modify settings for e-invoice delivery and purchase order retrieval.
    /// </summary>
    public partial class PutProcurementPortalPreferenceRequest : AmazonInvoicingRequest
    {
        private List<Contact> _contacts = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private bool? _einvoiceDeliveryEnabled;
        private EinvoiceDeliveryPreference _einvoiceDeliveryPreference;
        private string _procurementPortalInstanceEndpoint;
        private string _procurementPortalPreferenceArn;
        private string _procurementPortalSharedSecret;
        private bool? _purchaseOrderRetrievalEnabled;
        private ProcurementPortalPreferenceSelector _selector;
        private TestEnvPreferenceInput _testEnvPreference;

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// Updated list of contact information for portal administrators and technical contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<Contact> Contacts
        {
            get { return this._contacts; }
            set { this._contacts = value; }
        }

        // Check to see if Contacts property is set
        internal bool IsSetContacts()
        {
            return this._contacts != null && (this._contacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryEnabled. 
        /// <para>
        /// Updated flag indicating whether e-invoice delivery is enabled for this procurement
        /// portal preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EinvoiceDeliveryEnabled
        {
            get { return this._einvoiceDeliveryEnabled; }
            set { this._einvoiceDeliveryEnabled = value; }
        }

        // Check to see if EinvoiceDeliveryEnabled property is set
        internal bool IsSetEinvoiceDeliveryEnabled()
        {
            return this._einvoiceDeliveryEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryPreference. 
        /// <para>
        /// Updated e-invoice delivery configuration including document types, attachment types,
        /// and customization settings for the portal.
        /// </para>
        /// </summary>
        public EinvoiceDeliveryPreference EinvoiceDeliveryPreference
        {
            get { return this._einvoiceDeliveryPreference; }
            set { this._einvoiceDeliveryPreference = value; }
        }

        // Check to see if EinvoiceDeliveryPreference property is set
        internal bool IsSetEinvoiceDeliveryPreference()
        {
            return this._einvoiceDeliveryPreference != null;
        }

        /// <summary>
        /// Gets and sets the property ProcurementPortalInstanceEndpoint. 
        /// <para>
        /// The updated endpoint URL where e-invoices will be delivered to the procurement portal.
        /// Must be a valid HTTPS URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ProcurementPortalInstanceEndpoint
        {
            get { return this._procurementPortalInstanceEndpoint; }
            set { this._procurementPortalInstanceEndpoint = value; }
        }

        // Check to see if ProcurementPortalInstanceEndpoint property is set
        internal bool IsSetProcurementPortalInstanceEndpoint()
        {
            return this._procurementPortalInstanceEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ProcurementPortalPreferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the procurement portal preference to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProcurementPortalPreferenceArn
        {
            get { return this._procurementPortalPreferenceArn; }
            set { this._procurementPortalPreferenceArn = value; }
        }

        // Check to see if ProcurementPortalPreferenceArn property is set
        internal bool IsSetProcurementPortalPreferenceArn()
        {
            return this._procurementPortalPreferenceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProcurementPortalSharedSecret. 
        /// <para>
        /// The updated shared secret or authentication credential for the procurement portal.
        /// This value must be encrypted at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string ProcurementPortalSharedSecret
        {
            get { return this._procurementPortalSharedSecret; }
            set { this._procurementPortalSharedSecret = value; }
        }

        // Check to see if ProcurementPortalSharedSecret property is set
        internal bool IsSetProcurementPortalSharedSecret()
        {
            return this._procurementPortalSharedSecret != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalEnabled. 
        /// <para>
        /// Updated flag indicating whether purchase order retrieval is enabled for this procurement
        /// portal preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PurchaseOrderRetrievalEnabled
        {
            get { return this._purchaseOrderRetrievalEnabled; }
            set { this._purchaseOrderRetrievalEnabled = value; }
        }

        // Check to see if PurchaseOrderRetrievalEnabled property is set
        internal bool IsSetPurchaseOrderRetrievalEnabled()
        {
            return this._purchaseOrderRetrievalEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Selector.
        /// </summary>
        public ProcurementPortalPreferenceSelector Selector
        {
            get { return this._selector; }
            set { this._selector = value; }
        }

        // Check to see if Selector property is set
        internal bool IsSetSelector()
        {
            return this._selector != null;
        }

        /// <summary>
        /// Gets and sets the property TestEnvPreference. 
        /// <para>
        /// Updated configuration settings for the test environment of the procurement portal.
        /// </para>
        /// </summary>
        public TestEnvPreferenceInput TestEnvPreference
        {
            get { return this._testEnvPreference; }
            set { this._testEnvPreference = value; }
        }

        // Check to see if TestEnvPreference property is set
        internal bool IsSetTestEnvPreference()
        {
            return this._testEnvPreference != null;
        }

    }
}