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
    /// Container for the parameters to the UpdateProcurementPortalPreferenceStatus operation.
    /// <i> <b>This feature API is subject to changing at any time. For more information,
    /// see the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service
    /// Terms</a> (Betas and Previews).</b> </i> <para> Updates the status of a procurement
    /// portal preference, including the activation state of e-invoice delivery and purchase
    /// order retrieval features. </para>
    /// </summary>
    public partial class UpdateProcurementPortalPreferenceStatusRequest : AmazonInvoicingRequest
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
        /// Gets and sets the property EinvoiceDeliveryPreferenceStatus. 
        /// <para>
        /// The updated status of the e-invoice delivery preference.
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
        /// The reason for the e-invoice delivery preference status update, providing context
        /// for the change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EinvoiceDeliveryPreferenceStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryPreferenceStatusReason property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryPreferenceStatusReason() => this.EinvoiceDeliveryPreferenceStatusReason != null;

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
        /// Gets and sets the property PurchaseOrderRetrievalPreferenceStatus. 
        /// <para>
        /// The updated status of the purchase order retrieval preference.
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
        /// The reason for the purchase order retrieval preference status update, providing context
        /// for the change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PurchaseOrderRetrievalPreferenceStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderRetrievalPreferenceStatusReason property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderRetrievalPreferenceStatusReason() => this.PurchaseOrderRetrievalPreferenceStatusReason != null;
    }
}
