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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// The list of cryptographic operations that you can perform using the key. The modes
    /// of use are deﬁned in section A.5.3 of the TR-31 spec.
    /// </summary>
    public partial class KeyModesOfUse
    {
        /// <summary>
        /// Gets and sets the property Decrypt. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to decrypt
        /// data.
        /// </para>
        /// </summary>
        public bool? Decrypt { get; set; }

        /// <summary>
        /// Checks to see if the Decrypt property is set.
        /// </summary>
        internal bool IsSetDecrypt() => this.Decrypt.HasValue;

        /// <summary>
        /// Gets and sets the property DeriveKey. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to derive
        /// new keys.
        /// </para>
        /// </summary>
        public bool? DeriveKey { get; set; }

        /// <summary>
        /// Checks to see if the DeriveKey property is set.
        /// </summary>
        internal bool IsSetDeriveKey() => this.DeriveKey.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypt. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to encrypt
        /// data.
        /// </para>
        /// </summary>
        public bool? Encrypt { get; set; }

        /// <summary>
        /// Checks to see if the Encrypt property is set.
        /// </summary>
        internal bool IsSetEncrypt() => this.Encrypt.HasValue;

        /// <summary>
        /// Gets and sets the property Generate. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to generate
        /// and verify other card and PIN verification keys.
        /// </para>
        /// </summary>
        public bool? Generate { get; set; }

        /// <summary>
        /// Checks to see if the Generate property is set.
        /// </summary>
        internal bool IsSetGenerate() => this.Generate.HasValue;

        /// <summary>
        /// Gets and sets the property NoRestrictions. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key has no special restrictions
        /// other than the restrictions implied by <c>KeyUsage</c>.
        /// </para>
        /// </summary>
        public bool? NoRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the NoRestrictions property is set.
        /// </summary>
        internal bool IsSetNoRestrictions() => this.NoRestrictions.HasValue;

        /// <summary>
        /// Gets and sets the property Sign. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used for signing.
        /// </para>
        /// </summary>
        public bool? Sign { get; set; }

        /// <summary>
        /// Checks to see if the Sign property is set.
        /// </summary>
        internal bool IsSetSign() => this.Sign.HasValue;

        /// <summary>
        /// Gets and sets the property Unwrap. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to unwrap
        /// other keys.
        /// </para>
        /// </summary>
        public bool? Unwrap { get; set; }

        /// <summary>
        /// Checks to see if the Unwrap property is set.
        /// </summary>
        internal bool IsSetUnwrap() => this.Unwrap.HasValue;

        /// <summary>
        /// Gets and sets the property Verify. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to verify
        /// signatures.
        /// </para>
        /// </summary>
        public bool? Verify { get; set; }

        /// <summary>
        /// Checks to see if the Verify property is set.
        /// </summary>
        internal bool IsSetVerify() => this.Verify.HasValue;

        /// <summary>
        /// Gets and sets the property Wrap. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to wrap
        /// other keys.
        /// </para>
        /// </summary>
        public bool? Wrap { get; set; }

        /// <summary>
        /// Checks to see if the Wrap property is set.
        /// </summary>
        internal bool IsSetWrap() => this.Wrap.HasValue;
    }
}
