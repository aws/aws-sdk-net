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
    /// Specifies the preferences for e-invoice delivery, including document types, attachment
    /// types, and customization settings.
    /// </summary>
    public partial class EinvoiceDeliveryPreference
    {
        private ConnectionTestingMethod _connectionTestingMethod;
        private DateTime? _einvoiceDeliveryActivationDate;
        private List<string> _einvoiceDeliveryAttachmentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _einvoiceDeliveryDocumentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Protocol _protocol;
        private List<PurchaseOrderDataSource> _purchaseOrderDataSources = AWSConfigs.InitializeCollections ? new List<PurchaseOrderDataSource>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionTestingMethod. 
        /// <para>
        /// The method to use for testing the connection to the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionTestingMethod ConnectionTestingMethod
        {
            get { return this._connectionTestingMethod; }
            set { this._connectionTestingMethod = value; }
        }

        // Check to see if ConnectionTestingMethod property is set
        internal bool IsSetConnectionTestingMethod()
        {
            return this._connectionTestingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryActivationDate. 
        /// <para>
        /// The date when e-invoice delivery should be activated for this preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EinvoiceDeliveryActivationDate
        {
            get { return this._einvoiceDeliveryActivationDate.GetValueOrDefault(); }
            set { this._einvoiceDeliveryActivationDate = value; }
        }

        // Check to see if EinvoiceDeliveryActivationDate property is set
        internal bool IsSetEinvoiceDeliveryActivationDate()
        {
            return this._einvoiceDeliveryActivationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryAttachmentTypes. 
        /// <para>
        /// The types of attachments to include with the e-invoice delivery.
        /// </para>
        /// </summary>
        public List<string> EinvoiceDeliveryAttachmentTypes
        {
            get { return this._einvoiceDeliveryAttachmentTypes; }
            set { this._einvoiceDeliveryAttachmentTypes = value; }
        }

        // Check to see if EinvoiceDeliveryAttachmentTypes property is set
        internal bool IsSetEinvoiceDeliveryAttachmentTypes()
        {
            return this._einvoiceDeliveryAttachmentTypes != null && (this._einvoiceDeliveryAttachmentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryDocumentTypes. 
        /// <para>
        /// The types of e-invoice documents to be delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> EinvoiceDeliveryDocumentTypes
        {
            get { return this._einvoiceDeliveryDocumentTypes; }
            set { this._einvoiceDeliveryDocumentTypes = value; }
        }

        // Check to see if EinvoiceDeliveryDocumentTypes property is set
        internal bool IsSetEinvoiceDeliveryDocumentTypes()
        {
            return this._einvoiceDeliveryDocumentTypes != null && (this._einvoiceDeliveryDocumentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The communication protocol to use for e-invoice delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOrderDataSources. 
        /// <para>
        /// The sources of purchase order data to use for e-invoice generation and delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PurchaseOrderDataSource> PurchaseOrderDataSources
        {
            get { return this._purchaseOrderDataSources; }
            set { this._purchaseOrderDataSources = value; }
        }

        // Check to see if PurchaseOrderDataSources property is set
        internal bool IsSetPurchaseOrderDataSources()
        {
            return this._purchaseOrderDataSources != null && (this._purchaseOrderDataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}