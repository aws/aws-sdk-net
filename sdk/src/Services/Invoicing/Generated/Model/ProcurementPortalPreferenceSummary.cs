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
    /// Provides a summary of a procurement portal preference, including key identifiers and
    /// status information.
    /// </summary>
    public partial class ProcurementPortalPreferenceSummary
    {
        private string _awsAccountId;
        private BuyerDomain _buyerDomain;
        private string _buyerIdentifier;
        private DateTime? _createDate;
        private bool? _einvoiceDeliveryEnabled;
        private ProcurementPortalPreferenceStatus _einvoiceDeliveryPreferenceStatus;
        private string _einvoiceDeliveryPreferenceStatusReason;
        private DateTime? _lastUpdateDate;
        private ProcurementPortalName _procurementPortalName;
        private string _procurementPortalPreferenceArn;
        private bool? _purchaseOrderRetrievalEnabled;
        private ProcurementPortalPreferenceStatus _purchaseOrderRetrievalPreferenceStatus;
        private string _purchaseOrderRetrievalPreferenceStatusReason;
        private ProcurementPortalPreferenceSelector _selector;
        private SupplierDomain _supplierDomain;
        private string _supplierIdentifier;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with this procurement portal preference
        /// summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the procurement portal preference was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryEnabled. 
        /// <para>
        /// Indicates whether e-invoice delivery is enabled for this procurement portal preference.
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
        /// Gets and sets the property EinvoiceDeliveryPreferenceStatus. 
        /// <para>
        /// The current status of the e-invoice delivery preference in this summary.
        /// </para>
        /// </summary>
        public ProcurementPortalPreferenceStatus EinvoiceDeliveryPreferenceStatus
        {
            get { return this._einvoiceDeliveryPreferenceStatus; }
            set { this._einvoiceDeliveryPreferenceStatus = value; }
        }

        // Check to see if EinvoiceDeliveryPreferenceStatus property is set
        internal bool IsSetEinvoiceDeliveryPreferenceStatus()
        {
            return this._einvoiceDeliveryPreferenceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryPreferenceStatusReason. 
        /// <para>
        /// The reason for the current e-invoice delivery preference status in this summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EinvoiceDeliveryPreferenceStatusReason
        {
            get { return this._einvoiceDeliveryPreferenceStatusReason; }
            set { this._einvoiceDeliveryPreferenceStatusReason = value; }
        }

        // Check to see if EinvoiceDeliveryPreferenceStatusReason property is set
        internal bool IsSetEinvoiceDeliveryPreferenceStatusReason()
        {
            return this._einvoiceDeliveryPreferenceStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date and time when the procurement portal preference was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdateDate
        {
            get { return this._lastUpdateDate; }
            set { this._lastUpdateDate = value; }
        }

        // Check to see if LastUpdateDate property is set
        internal bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate.HasValue; 
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
        /// Gets and sets the property ProcurementPortalPreferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the procurement portal preference.
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
        /// Gets and sets the property PurchaseOrderRetrievalEnabled. 
        /// <para>
        /// Indicates whether purchase order retrieval is enabled for this procurement portal
        /// preference.
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
        /// Gets and sets the property PurchaseOrderRetrievalPreferenceStatus. 
        /// <para>
        /// The current status of the purchase order retrieval preference in this summary.
        /// </para>
        /// </summary>
        public ProcurementPortalPreferenceStatus PurchaseOrderRetrievalPreferenceStatus
        {
            get { return this._purchaseOrderRetrievalPreferenceStatus; }
            set { this._purchaseOrderRetrievalPreferenceStatus = value; }
        }

        // Check to see if PurchaseOrderRetrievalPreferenceStatus property is set
        internal bool IsSetPurchaseOrderRetrievalPreferenceStatus()
        {
            return this._purchaseOrderRetrievalPreferenceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOrderRetrievalPreferenceStatusReason. 
        /// <para>
        /// The reason for the current purchase order retrieval preference status in this summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PurchaseOrderRetrievalPreferenceStatusReason
        {
            get { return this._purchaseOrderRetrievalPreferenceStatusReason; }
            set { this._purchaseOrderRetrievalPreferenceStatusReason = value; }
        }

        // Check to see if PurchaseOrderRetrievalPreferenceStatusReason property is set
        internal bool IsSetPurchaseOrderRetrievalPreferenceStatusReason()
        {
            return this._purchaseOrderRetrievalPreferenceStatusReason != null;
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the procurement portal preference configuration in this summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}