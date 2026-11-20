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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Contains additional tax information associated with your Tax Registration Number (TRN)
    /// in the United Arab Emirates, such as the TRN type and the Peppol ID used for electronic
    /// invoicing (e-invoicing).
    /// </summary>
    public partial class UnitedArabEmiratesAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property EmiratesId. 
        /// <para>
        /// Your Emirates ID. Optional. Must be in the format <c>784-YYYY-NNNNNNN-N</c>.
        /// </para>
        /// </summary>
        public string EmiratesId { get; set; }

        /// <summary>
        /// Checks to see if the EmiratesId property is set.
        /// </summary>
        internal bool IsSetEmiratesId() => this.EmiratesId != null;

        /// <summary>
        /// Gets and sets the property PeppolId. 
        /// <para>
        /// The Peppol ID used for electronic invoicing (e-invoicing) in the United Arab Emirates.
        /// Optional. Must be a 10-digit number.
        /// </para>
        /// </summary>
        public string PeppolId { get; set; }

        /// <summary>
        /// Checks to see if the PeppolId property is set.
        /// </summary>
        internal bool IsSetPeppolId() => this.PeppolId != null;

        /// <summary>
        /// Gets and sets the property TaxRegistrationNumberType. 
        /// <para>
        /// The type of your TRN in the United Arab Emirates. Valid values are <c>VATTaxRegistrationNumber</c>
        /// and <c>LocalTaxRegistrationNumber</c> (Corporate Tax). This field must be provided.
        /// </para>
        /// </summary>
        public UaeTaxRegistrationNumberType TaxRegistrationNumberType { get; set; }

        /// <summary>
        /// Checks to see if the TaxRegistrationNumberType property is set.
        /// </summary>
        internal bool IsSetTaxRegistrationNumberType() => this.TaxRegistrationNumberType != null;

        /// <summary>
        /// Gets and sets the property TradeLicenseNumber. 
        /// <para>
        /// Your trade license number in the United Arab Emirates. Optional. Must be a 10-digit
        /// number.
        /// </para>
        /// </summary>
        public string TradeLicenseNumber { get; set; }

        /// <summary>
        /// Checks to see if the TradeLicenseNumber property is set.
        /// </summary>
        internal bool IsSetTradeLicenseNumber() => this.TradeLicenseNumber != null;
    }
}
