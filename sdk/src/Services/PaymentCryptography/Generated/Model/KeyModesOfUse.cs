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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
        private bool? _decrypt;
        private bool? _deriveKey;
        private bool? _encrypt;
        private bool? _generate;
        private bool? _noRestrictions;
        private bool? _sign;
        private bool? _unwrap;
        private bool? _verify;
        private bool? _wrap;

        /// <summary>
        /// Gets and sets the property Decrypt. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to decrypt
        /// data.
        /// </para>
        /// </summary>
        public bool? Decrypt
        {
            get { return this._decrypt; }
            set { this._decrypt = value; }
        }

        // Check to see if Decrypt property is set
        internal bool IsSetDecrypt()
        {
            return this._decrypt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeriveKey. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to derive
        /// new keys.
        /// </para>
        /// </summary>
        public bool? DeriveKey
        {
            get { return this._deriveKey; }
            set { this._deriveKey = value; }
        }

        // Check to see if DeriveKey property is set
        internal bool IsSetDeriveKey()
        {
            return this._deriveKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypt. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to encrypt
        /// data.
        /// </para>
        /// </summary>
        public bool? Encrypt
        {
            get { return this._encrypt; }
            set { this._encrypt = value; }
        }

        // Check to see if Encrypt property is set
        internal bool IsSetEncrypt()
        {
            return this._encrypt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Generate. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to generate
        /// and verify other card and PIN verification keys.
        /// </para>
        /// </summary>
        public bool? Generate
        {
            get { return this._generate; }
            set { this._generate = value; }
        }

        // Check to see if Generate property is set
        internal bool IsSetGenerate()
        {
            return this._generate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoRestrictions. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key has no special restrictions
        /// other than the restrictions implied by <c>KeyUsage</c>.
        /// </para>
        /// </summary>
        public bool? NoRestrictions
        {
            get { return this._noRestrictions; }
            set { this._noRestrictions = value; }
        }

        // Check to see if NoRestrictions property is set
        internal bool IsSetNoRestrictions()
        {
            return this._noRestrictions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sign. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used for signing.
        /// </para>
        /// </summary>
        public bool? Sign
        {
            get { return this._sign; }
            set { this._sign = value; }
        }

        // Check to see if Sign property is set
        internal bool IsSetSign()
        {
            return this._sign.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unwrap. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to unwrap
        /// other keys.
        /// </para>
        /// </summary>
        public bool? Unwrap
        {
            get { return this._unwrap; }
            set { this._unwrap = value; }
        }

        // Check to see if Unwrap property is set
        internal bool IsSetUnwrap()
        {
            return this._unwrap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Verify. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to verify
        /// signatures.
        /// </para>
        /// </summary>
        public bool? Verify
        {
            get { return this._verify; }
            set { this._verify = value; }
        }

        // Check to see if Verify property is set
        internal bool IsSetVerify()
        {
            return this._verify.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Wrap. 
        /// <para>
        /// Speciﬁes whether an Amazon Web Services Payment Cryptography key can be used to wrap
        /// other keys.
        /// </para>
        /// </summary>
        public bool? Wrap
        {
            get { return this._wrap; }
            set { this._wrap = value; }
        }

        // Check to see if Wrap property is set
        internal bool IsSetWrap()
        {
            return this._wrap.HasValue; 
        }

    }
}