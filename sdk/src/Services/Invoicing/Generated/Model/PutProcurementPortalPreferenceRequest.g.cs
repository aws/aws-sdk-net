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
    /// Container for the parameters to the PutProcurementPortalPreference operation. <i>
    /// <b>This feature API is subject to changing at any time. For more information, see
    /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
    /// (Betas and Previews).</b> </i> <para> Updates an existing procurement portal preference
    /// configuration. This operation can modify settings for e-invoice delivery and purchase
    /// order retrieval. </para>
    /// </summary>
    public partial class PutProcurementPortalPreferenceRequest : AmazonInvoicingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure idempotency of the
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
        /// Gets and sets the property Contacts. 
        /// <para>
        /// Updated list of contact information for portal administrators and technical contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<Contact> Contacts { get; set; } = AWSConfigs.InitializeCollections ? new List<Contact>() : null;

        /// <summary>
        /// Checks to see if the Contacts property is set.
        /// </summary>
        internal bool IsSetContacts() => this.Contacts != null && (this.Contacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryEnabled. 
        /// <para>
        /// Updated flag indicating whether e-invoice delivery is enabled for this procurement
        /// portal preference.
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
        /// Updated e-invoice delivery configuration including document types, attachment types,
        /// and customization settings for the portal.
        /// </para>
        /// </summary>
        public EinvoiceDeliveryPreference EinvoiceDeliveryPreference { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryPreference property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryPreference() => this.EinvoiceDeliveryPreference != null;

        /// <summary>
        /// Gets and sets the property MarketplacePunchOutEnabled. Whether Marketplace PunchOut
        /// is enabled for this connection. Defaults to false if not provided.
        /// </summary>
        public bool? MarketplacePunchOutEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MarketplacePunchOutEnabled property is set.
        /// </summary>
        internal bool IsSetMarketplacePunchOutEnabled() => this.MarketplacePunchOutEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MarketplacePunchOutPreference. Configuration for Marketplace
        /// PunchOut. Required when MarketplacePunchOutEnabled is true.
        /// </summary>
        public MarketplacePunchOutPreference MarketplacePunchOutPreference { get; set; }

        /// <summary>
        /// Checks to see if the MarketplacePunchOutPreference property is set.
        /// </summary>
        internal bool IsSetMarketplacePunchOutPreference() => this.MarketplacePunchOutPreference != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalInstanceEndpoint. 
        /// <para>
        /// The updated endpoint URL where e-invoices will be delivered to the procurement portal.
        /// Must be a valid HTTPS URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ProcurementPortalInstanceEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalInstanceEndpoint property is set.
        /// </summary>
        internal bool IsSetProcurementPortalInstanceEndpoint() => this.ProcurementPortalInstanceEndpoint != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalPreferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the procurement portal preference to update.
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
        /// The updated shared secret or authentication credential for the procurement portal.
        /// This value must be encrypted at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string ProcurementPortalSharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalSharedSecret property is set.
        /// </summary>
        internal bool IsSetProcurementPortalSharedSecret() => this.ProcurementPortalSharedSecret != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalEnabled. 
        /// <para>
        /// Updated flag indicating whether purchase order retrieval is enabled for this procurement
        /// portal preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? PurchaseOrderRetrievalEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderRetrievalEnabled property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderRetrievalEnabled() => this.PurchaseOrderRetrievalEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Selector.
        /// </summary>
        public ProcurementPortalPreferenceSelector Selector { get; set; }

        /// <summary>
        /// Checks to see if the Selector property is set.
        /// </summary>
        internal bool IsSetSelector() => this.Selector != null;

        /// <summary>
        /// Gets and sets the property TestEnvPreference. 
        /// <para>
        /// Updated configuration settings for the test environment of the procurement portal.
        /// </para>
        /// </summary>
        public TestEnvPreferenceInput TestEnvPreference { get; set; }

        /// <summary>
        /// Checks to see if the TestEnvPreference property is set.
        /// </summary>
        internal bool IsSetTestEnvPreference() => this.TestEnvPreference != null;
    }
}
