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
    /// Contains configuration settings for testing the procurement portal integration in
    /// a non-production environment.
    /// </summary>
    public partial class TestEnvPreference
    {
        private BuyerDomain _buyerDomain;
        private string _buyerIdentifier;
        private string _procurementPortalInstanceEndpoint;
        private string _procurementPortalSharedSecret;
        private string _purchaseOrderRetrievalEndpoint;
        private SupplierDomain _supplierDomain;
        private string _supplierIdentifier;

        /// <summary>
        /// Gets and sets the property BuyerDomain. 
        /// <para>
        /// The domain identifier for the buyer in the test environment of the procurement portal.
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
        /// The unique identifier for the buyer in the test environment of the procurement portal.
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
        /// Gets and sets the property ProcurementPortalInstanceEndpoint. 
        /// <para>
        /// The endpoint URL where e-invoices are delivered in the test environment.
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
        /// Gets and sets the property ProcurementPortalSharedSecret. 
        /// <para>
        /// The shared secret or authentication credential used for secure communication with
        /// the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property PurchaseOrderRetrievalEndpoint. 
        /// <para>
        /// The endpoint URL used for retrieving purchase orders in the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PurchaseOrderRetrievalEndpoint
        {
            get { return this._purchaseOrderRetrievalEndpoint; }
            set { this._purchaseOrderRetrievalEndpoint = value; }
        }

        // Check to see if PurchaseOrderRetrievalEndpoint property is set
        internal bool IsSetPurchaseOrderRetrievalEndpoint()
        {
            return this._purchaseOrderRetrievalEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SupplierDomain. 
        /// <para>
        /// The domain identifier for the supplier in the test environment of the procurement
        /// portal.
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
        /// The unique identifier for the supplier in the test environment of the procurement
        /// portal.
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

    }
}