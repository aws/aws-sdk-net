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
    /// Container for the parameters to the UpdateProcurementPortalPreferenceStatus operation.
    /// Updates the status of a procurement portal preference, including the activation state
    /// of e-invoice delivery and purchase order retrieval features.
    /// </summary>
    public partial class UpdateProcurementPortalPreferenceStatusRequest : AmazonInvoicingRequest
    {
        private ProcurementPortalPreferenceStatus _einvoiceDeliveryPreferenceStatus;
        private string _einvoiceDeliveryPreferenceStatusReason;
        private string _procurementPortalPreferenceArn;
        private ProcurementPortalPreferenceStatus _purchaseOrderRetrievalPreferenceStatus;
        private string _purchaseOrderRetrievalPreferenceStatusReason;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryPreferenceStatus. 
        /// <para>
        /// The updated status of the e-invoice delivery preference.
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
        /// The reason for the e-invoice delivery preference status update, providing context
        /// for the change.
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
        /// Gets and sets the property PurchaseOrderRetrievalPreferenceStatus. 
        /// <para>
        /// The updated status of the purchase order retrieval preference.
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
        /// The reason for the purchase order retrieval preference status update, providing context
        /// for the change.
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

    }
}