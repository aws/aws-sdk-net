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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Represents a charge associated with an agreement, including amount, timing, and purchase
    /// order details.
    /// </summary>
    public partial class Charge
    {
        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement that resulted in this charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// The type of agreement that resulted in this charge (for example, <c>PurchaseAgreement</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Checks to see if the AgreementType property is set.
        /// </summary>
        internal bool IsSetAgreementType() => this.AgreementType != null;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The amount of the charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the charge amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderReference. 
        /// <para>
        /// The purchase order reference associated with the charge, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string PurchaseOrderReference { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderReference property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderReference() => this.PurchaseOrderReference != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of the charge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The date and time when the charge will be incurred. This is available only when the
        /// charge date is known.
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;
    }
}
