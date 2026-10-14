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
    /// Represents the full configuration of a procurement portal preference, including settings
    /// for e-invoice delivery and purchase order retrieval.
    /// </summary>
    public partial class ProcurementPortalPreference
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with this procurement portal preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property BuyerDomain. 
        /// <para>
        /// The domain identifier for the buyer in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BuyerDomain BuyerDomain { get; set; }

        /// <summary>
        /// Checks to see if the BuyerDomain property is set.
        /// </summary>
        internal bool IsSetBuyerDomain() => this.BuyerDomain != null;

        /// <summary>
        /// Gets and sets the property BuyerIdentifier. 
        /// <para>
        /// The unique identifier for the buyer in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string BuyerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BuyerIdentifier property is set.
        /// </summary>
        internal bool IsSetBuyerIdentifier() => this.BuyerIdentifier != null;

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// List of contact information for portal administrators and technical contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Contact> Contacts { get; set; } = AWSConfigs.InitializeCollections ? new List<Contact>() : null;

        /// <summary>
        /// Checks to see if the Contacts property is set.
        /// </summary>
        internal bool IsSetContacts() => this.Contacts != null && (this.Contacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the procurement portal preference was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryEnabled. 
        /// <para>
        /// Indicates whether e-invoice delivery is enabled for this procurement portal preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EinvoiceDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryEnabled() => this.EinvoiceDeliveryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryPreference. 
        /// <para>
        /// The e-invoice delivery configuration including document types, attachment types, and
        /// customization settings.
        /// </para>
        /// </summary>
        public EinvoiceDeliveryPreference EinvoiceDeliveryPreference { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryPreference property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryPreference() => this.EinvoiceDeliveryPreference != null;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryPreferenceStatus. 
        /// <para>
        /// The current status of the e-invoice delivery preference.
        /// </para>
        /// </summary>
        public ProcurementPortalPreferenceStatus EinvoiceDeliveryPreferenceStatus { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryPreferenceStatus property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryPreferenceStatus() => this.EinvoiceDeliveryPreferenceStatus != null;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryPreferenceStatusReason. 
        /// <para>
        /// The reason for the current e-invoice delivery preference status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EinvoiceDeliveryPreferenceStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryPreferenceStatusReason property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryPreferenceStatusReason() => this.EinvoiceDeliveryPreferenceStatusReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date and time when the procurement portal preference was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateDate() => this.LastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property MarketplacePunchOutEnabled. 
        /// <para>
        /// Indicates whether Marketplace PunchOut is enabled for this procurement portal preference.
        /// Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? MarketplacePunchOutEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MarketplacePunchOutEnabled property is set.
        /// </summary>
        internal bool IsSetMarketplacePunchOutEnabled() => this.MarketplacePunchOutEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MarketplacePunchOutPreference. 
        /// <para>
        /// The Marketplace PunchOut configuration for this procurement portal preference. This
        /// is present when <c>MarketplacePunchOutEnabled</c> is <c>true</c>.
        /// </para>
        /// </summary>
        public MarketplacePunchOutPreference MarketplacePunchOutPreference { get; set; }

        /// <summary>
        /// Checks to see if the MarketplacePunchOutPreference property is set.
        /// </summary>
        internal bool IsSetMarketplacePunchOutPreference() => this.MarketplacePunchOutPreference != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalInstanceEndpoint. 
        /// <para>
        /// The endpoint URL where e-invoices are delivered to the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ProcurementPortalInstanceEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalInstanceEndpoint property is set.
        /// </summary>
        internal bool IsSetProcurementPortalInstanceEndpoint() => this.ProcurementPortalInstanceEndpoint != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalName. 
        /// <para>
        /// The name of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcurementPortalName ProcurementPortalName { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalName property is set.
        /// </summary>
        internal bool IsSetProcurementPortalName() => this.ProcurementPortalName != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalPreferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the procurement portal preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ProcurementPortalPreferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalPreferenceArn property is set.
        /// </summary>
        internal bool IsSetProcurementPortalPreferenceArn() => this.ProcurementPortalPreferenceArn != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalSharedSecret. 
        /// <para>
        /// The shared secret or authentication credential used for secure communication with
        /// the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ProcurementPortalSharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalSharedSecret property is set.
        /// </summary>
        internal bool IsSetProcurementPortalSharedSecret() => this.ProcurementPortalSharedSecret != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalEnabled. 
        /// <para>
        /// Indicates whether purchase order retrieval is enabled for this procurement portal
        /// preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? PurchaseOrderRetrievalEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderRetrievalEnabled property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderRetrievalEnabled() => this.PurchaseOrderRetrievalEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalEndpoint. 
        /// <para>
        /// The endpoint URL used for retrieving purchase orders from the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PurchaseOrderRetrievalEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderRetrievalEndpoint property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderRetrievalEndpoint() => this.PurchaseOrderRetrievalEndpoint != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalPreferenceStatus. 
        /// <para>
        /// The current status of the purchase order retrieval preference.
        /// </para>
        /// </summary>
        public ProcurementPortalPreferenceStatus PurchaseOrderRetrievalPreferenceStatus { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderRetrievalPreferenceStatus property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderRetrievalPreferenceStatus() => this.PurchaseOrderRetrievalPreferenceStatus != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalPreferenceStatusReason. 
        /// <para>
        /// The reason for the current purchase order retrieval preference status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PurchaseOrderRetrievalPreferenceStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderRetrievalPreferenceStatusReason property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderRetrievalPreferenceStatusReason() => this.PurchaseOrderRetrievalPreferenceStatusReason != null;

        /// <summary>
        /// Gets and sets the property Selector.
        /// </summary>
        public ProcurementPortalPreferenceSelector Selector { get; set; }

        /// <summary>
        /// Checks to see if the Selector property is set.
        /// </summary>
        internal bool IsSetSelector() => this.Selector != null;

        /// <summary>
        /// Gets and sets the property SupplierDomain. 
        /// <para>
        /// The domain identifier for the supplier in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupplierDomain SupplierDomain { get; set; }

        /// <summary>
        /// Checks to see if the SupplierDomain property is set.
        /// </summary>
        internal bool IsSetSupplierDomain() => this.SupplierDomain != null;

        /// <summary>
        /// Gets and sets the property SupplierIdentifier. 
        /// <para>
        /// The unique identifier for the supplier in the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string SupplierIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SupplierIdentifier property is set.
        /// </summary>
        internal bool IsSetSupplierIdentifier() => this.SupplierIdentifier != null;

        /// <summary>
        /// Gets and sets the property TestEnvPreference. 
        /// <para>
        /// Configuration on settings for the test environment of the procurement portal.
        /// </para>
        /// </summary>
        public TestEnvPreference TestEnvPreference { get; set; }

        /// <summary>
        /// Checks to see if the TestEnvPreference property is set.
        /// </summary>
        internal bool IsSetTestEnvPreference() => this.TestEnvPreference != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the procurement portal preference configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
