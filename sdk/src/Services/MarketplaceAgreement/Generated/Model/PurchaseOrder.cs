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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Contains information about a purchase order association to a charge within an agreement.
    /// </summary>
    public partial class PurchaseOrder
    {
        private string _agreementId;
        private string _chargeId;
        private long? _chargeRevision;
        private string _purchaseOrderReference;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with this charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeId. 
        /// <para>
        /// The unique identifier of the charge to associate the purchase order with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ChargeId
        {
            get { return this._chargeId; }
            set { this._chargeId = value; }
        }

        // Check to see if ChargeId property is set
        internal bool IsSetChargeId()
        {
            return this._chargeId != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeRevision. 
        /// <para>
        /// The revision of the charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ChargeRevision
        {
            get { return this._chargeRevision; }
            set { this._chargeRevision = value; }
        }

        // Check to see if ChargeRevision property is set
        internal bool IsSetChargeRevision()
        {
            return this._chargeRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PurchaseOrderReference. 
        /// <para>
        /// The purchase order reference to associate with the charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PurchaseOrderReference
        {
            get { return this._purchaseOrderReference; }
            set { this._purchaseOrderReference = value; }
        }

        // Check to see if PurchaseOrderReference property is set
        internal bool IsSetPurchaseOrderReference()
        {
            return this._purchaseOrderReference != null;
        }

    }
}