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
    /// Container for the parameters to the CreateProcurementPortalPreference operation.
    /// Creates a procurement portal preference configuration for e-invoice delivery and purchase
    /// order retrieval. This preference defines how invoices are delivered to a procurement
    /// portal and how purchase orders are retrieved.
    /// </summary>
    public partial class CreateProcurementPortalPreferenceRequest : AmazonInvoicingRequest
    {
        private BuyerDomain _buyerDomain;
        private string _buyerIdentifier;
        private string _clientToken;
        private List<Contact> _contacts = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private bool? _einvoiceDeliveryEnabled;
        private EinvoiceDeliveryPreference _einvoiceDeliveryPreference;
        private string _procurementPortalInstanceEndpoint;
        private ProcurementPortalName _procurementPortalName;
        private string _procurementPortalSharedSecret;
        private bool? _purchaseOrderRetrievalEnabled;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;
        private ProcurementPortalPreferenceSelector _selector;
        private SupplierDomain _supplierDomain;
        private string _supplierIdentifier;
        private TestEnvPreferenceInput _testEnvPreference;

        /// <summary>
        /// Gets and sets the property BuyerDomain. 
        /// <para>
        /// The domain identifier for the buyer in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BuyerDomain BuyerDomain
        {
            get { return this._buyerDomain; }
            set { this._buyerDomain = value; }
        }

        // Check to see if BuyerDomain property is set
        internal bool IsSetBuyerDomain()
        {
            return this._buyerDomain != null;
        }

        /// <summary>
        /// Gets and sets the property BuyerIdentifier. 
        /// <para>
        /// The unique identifier for the buyer in the procurement portal. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string BuyerIdentifier
        {
            get { return this._buyerIdentifier; }
            set { this._buyerIdentifier = value; }
        }

        // Check to see if BuyerIdentifier property is set
        internal bool IsSetBuyerIdentifier()
        {
            return this._buyerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// List of contact information for portal administrators and technical contacts responsible
        /// for the e-invoice integration.
        /// </para>
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
        /// Indicates whether e-invoice delivery is enabled for this procurement portal preference.
        /// Set to true to enable e-invoice delivery, false to disable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EinvoiceDeliveryEnabled
        {
            get { return this._einvoiceDeliveryEnabled.GetValueOrDefault(); }
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
        /// Specifies the e-invoice delivery configuration including document types, attachment
        /// types, and customization settings for the portal.
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
        /// The endpoint URL where e-invoices will be delivered to the procurement portal. Must
        /// be a valid HTTPS URL.
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
        /// Gets and sets the property ProcurementPortalName. 
        /// <para>
        /// The name of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcurementPortalName ProcurementPortalName
        {
            get { return this._procurementPortalName; }
            set { this._procurementPortalName = value; }
        }

        // Check to see if ProcurementPortalName property is set
        internal bool IsSetProcurementPortalName()
        {
            return this._procurementPortalName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcurementPortalSharedSecret. 
        /// <para>
        /// The shared secret or authentication credential used to establish secure communication
        /// with the procurement portal. This value must be encrypted at rest.
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
        /// Indicates whether purchase order retrieval is enabled for this procurement portal
        /// preference. Set to true to enable PO retrieval, false to disable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool PurchaseOrderRetrievalEnabled
        {
            get { return this._purchaseOrderRetrievalEnabled.GetValueOrDefault(); }
            set { this._purchaseOrderRetrievalEnabled = value; }
        }

        // Check to see if PurchaseOrderRetrievalEnabled property is set
        internal bool IsSetPurchaseOrderRetrievalEnabled()
        {
            return this._purchaseOrderRetrievalEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags to apply to this procurement portal preference resource. Each tag consists
        /// of a key and an optional value.
        /// </para>
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
        /// Gets and sets the property SupplierDomain. 
        /// <para>
        /// The domain identifier for the supplier in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupplierDomain SupplierDomain
        {
            get { return this._supplierDomain; }
            set { this._supplierDomain = value; }
        }

        // Check to see if SupplierDomain property is set
        internal bool IsSetSupplierDomain()
        {
            return this._supplierDomain != null;
        }

        /// <summary>
        /// Gets and sets the property SupplierIdentifier. 
        /// <para>
        /// The unique identifier for the supplier in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string SupplierIdentifier
        {
            get { return this._supplierIdentifier; }
            set { this._supplierIdentifier = value; }
        }

        // Check to see if SupplierIdentifier property is set
        internal bool IsSetSupplierIdentifier()
        {
            return this._supplierIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TestEnvPreference. 
        /// <para>
        /// Configuration settings for the test environment of the procurement portal. Includes
        /// test credentials and endpoints that are used for validation before production deployment.
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