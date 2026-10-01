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
    /// Parameters to derive a session key for Authorization Response Cryptogram (ARQC) verification.
    /// </summary>
    public partial class SessionKeyDerivation
    {
        /// <summary>
        /// Gets and sets the property Amex. 
        /// <para>
        /// Parameters to derive session key for an Amex payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyAmex Amex { get; set; }

        /// <summary>
        /// Checks to see if the Amex property is set.
        /// </summary>
        internal bool IsSetAmex() => this.Amex != null;

        /// <summary>
        /// Gets and sets the property Emv2000. 
        /// <para>
        /// Parameters to derive session key for an Emv2000 payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyEmv2000 Emv2000 { get; set; }

        /// <summary>
        /// Checks to see if the Emv2000 property is set.
        /// </summary>
        internal bool IsSetEmv2000() => this.Emv2000 != null;

        /// <summary>
        /// Gets and sets the property EmvCommon. 
        /// <para>
        /// Parameters to derive session key for an Emv common payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyEmvCommon EmvCommon { get; set; }

        /// <summary>
        /// Checks to see if the EmvCommon property is set.
        /// </summary>
        internal bool IsSetEmvCommon() => this.EmvCommon != null;

        /// <summary>
        /// Gets and sets the property Mastercard. 
        /// <para>
        /// Parameters to derive session key for a Mastercard payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyMastercard Mastercard { get; set; }

        /// <summary>
        /// Checks to see if the Mastercard property is set.
        /// </summary>
        internal bool IsSetMastercard() => this.Mastercard != null;

        /// <summary>
        /// Gets and sets the property UnionPay. 
        /// <para>
        /// Parameters to derive session key for a UnionPay payment card for Authorization Request
        /// Cryptogram (ARQC) generation and verification.
        /// </para>
        /// </summary>
        public SessionKeyUnionPay UnionPay { get; set; }

        /// <summary>
        /// Checks to see if the UnionPay property is set.
        /// </summary>
        internal bool IsSetUnionPay() => this.UnionPay != null;

        /// <summary>
        /// Gets and sets the property Visa. 
        /// <para>
        /// Parameters to derive session key for a Visa payment cardfor ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyVisa Visa { get; set; }

        /// <summary>
        /// Checks to see if the Visa property is set.
        /// </summary>
        internal bool IsSetVisa() => this.Visa != null;
    }
}
