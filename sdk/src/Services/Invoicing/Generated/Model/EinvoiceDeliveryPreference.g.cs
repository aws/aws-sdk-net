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
    /// Specifies the preferences for e-invoice delivery, including document types, attachment
    /// types, and customization settings.
    /// </summary>
    public partial class EinvoiceDeliveryPreference
    {
        /// <summary>
        /// Gets and sets the property ConnectionTestingMethod. 
        /// <para>
        /// The method to use for testing the connection to the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionTestingMethod ConnectionTestingMethod { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTestingMethod property is set.
        /// </summary>
        internal bool IsSetConnectionTestingMethod() => this.ConnectionTestingMethod != null;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryActivationDate. 
        /// <para>
        /// The date when e-invoice delivery should be activated for this preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EinvoiceDeliveryActivationDate { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryActivationDate property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryActivationDate() => this.EinvoiceDeliveryActivationDate.HasValue;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryAttachmentTypes. 
        /// <para>
        /// The types of attachments to include with the e-invoice delivery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EinvoiceDeliveryAttachmentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryAttachmentTypes property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryAttachmentTypes() => this.EinvoiceDeliveryAttachmentTypes != null && (this.EinvoiceDeliveryAttachmentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryDocumentTypes. 
        /// <para>
        /// The types of e-invoice documents to be delivered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<string> EinvoiceDeliveryDocumentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryDocumentTypes property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryDocumentTypes() => this.EinvoiceDeliveryDocumentTypes != null && (this.EinvoiceDeliveryDocumentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The communication protocol to use for e-invoice delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderDataSources. 
        /// <para>
        /// The sources of purchase order data to use for e-invoice generation and delivery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PurchaseOrderDataSource> PurchaseOrderDataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<PurchaseOrderDataSource>() : null;

        /// <summary>
        /// Checks to see if the PurchaseOrderDataSources property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderDataSources() => this.PurchaseOrderDataSources != null && (this.PurchaseOrderDataSources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
