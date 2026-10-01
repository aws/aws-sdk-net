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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters to derive the payment card specific confidentiality and integrity keys.
    /// </summary>
    public partial class DerivationMethodAttributes
    {
        /// <summary>
        /// Gets and sets the property Amex. 
        /// <para>
        /// Parameters to derive the confidentiality and integrity keys for a payment card using
        /// Amex derivation method.
        /// </para>
        /// </summary>
        public AmexAttributes Amex { get; set; }

        /// <summary>
        /// Checks to see if the Amex property is set.
        /// </summary>
        internal bool IsSetAmex() => this.Amex != null;

        /// <summary>
        /// Gets and sets the property Emv2000. 
        /// <para>
        /// Parameters to derive the confidentiality and integrity keys for a payment card using
        /// Emv2000 derivation method.
        /// </para>
        /// </summary>
        public Emv2000Attributes Emv2000 { get; set; }

        /// <summary>
        /// Checks to see if the Emv2000 property is set.
        /// </summary>
        internal bool IsSetEmv2000() => this.Emv2000 != null;

        /// <summary>
        /// Gets and sets the property EmvCommon. 
        /// <para>
        /// Parameters to derive the confidentiality and integrity keys for a payment card using
        /// Emv common derivation method.
        /// </para>
        /// </summary>
        public EmvCommonAttributes EmvCommon { get; set; }

        /// <summary>
        /// Checks to see if the EmvCommon property is set.
        /// </summary>
        internal bool IsSetEmvCommon() => this.EmvCommon != null;

        /// <summary>
        /// Gets and sets the property Mastercard. 
        /// <para>
        /// Parameters to derive the confidentiality and integrity keys for a payment card using
        /// Mastercard derivation method.
        /// </para>
        /// </summary>
        public MasterCardAttributes Mastercard { get; set; }

        /// <summary>
        /// Checks to see if the Mastercard property is set.
        /// </summary>
        internal bool IsSetMastercard() => this.Mastercard != null;

        /// <summary>
        /// Gets and sets the property Visa. 
        /// <para>
        /// Parameters to derive the confidentiality and integrity keys for a a payment card using
        /// Visa derivation method.
        /// </para>
        /// </summary>
        public VisaAttributes Visa { get; set; }

        /// <summary>
        /// Checks to see if the Visa property is set.
        /// </summary>
        internal bool IsSetVisa() => this.Visa != null;
    }
}
