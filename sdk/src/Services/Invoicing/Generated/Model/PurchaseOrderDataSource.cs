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
    /// Specifies the source configuration for retrieving purchase order data.
    /// </summary>
    public partial class PurchaseOrderDataSource
    {
        private EinvoiceDeliveryDocumentType _einvoiceDeliveryDocumentType;
        private PurchaseOrderDataSourceType _purchaseOrderDataSourceType;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryDocumentType. 
        /// <para>
        /// The type of e-invoice document that requires purchase order data.
        /// </para>
        /// </summary>
        public EinvoiceDeliveryDocumentType EinvoiceDeliveryDocumentType
        {
            get { return this._einvoiceDeliveryDocumentType; }
            set { this._einvoiceDeliveryDocumentType = value; }
        }

        // Check to see if EinvoiceDeliveryDocumentType property is set
        internal bool IsSetEinvoiceDeliveryDocumentType()
        {
            return this._einvoiceDeliveryDocumentType != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOrderDataSourceType. 
        /// <para>
        /// The type of source for purchase order data.
        /// </para>
        /// </summary>
        public PurchaseOrderDataSourceType PurchaseOrderDataSourceType
        {
            get { return this._purchaseOrderDataSourceType; }
            set { this._purchaseOrderDataSourceType = value; }
        }

        // Check to see if PurchaseOrderDataSourceType property is set
        internal bool IsSetPurchaseOrderDataSourceType()
        {
            return this._purchaseOrderDataSourceType != null;
        }

    }
}