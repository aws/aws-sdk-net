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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
    /// Container for the parameters to the TranslatePinData operation.
    /// Translates encrypted PIN block from and to ISO 9564 formats 0,1,3,4. For more information,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/translate-pin-data.html">Translate
    /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// PIN block translation involves changing a PIN block from one encryption key to another
    /// and optionally change its format. PIN block translation occurs entirely within the
    /// HSM boundary and PIN data never enters or leaves Amazon Web Services Payment Cryptography
    /// in clear text. The encryption key transformation can be from PEK (Pin Encryption Key)
    /// to BDK (Base Derivation Key) for DUKPT or from BDK for DUKPT to PEK.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography also supports use of dynamic keys and ECDH
    /// (Elliptic Curve Diffie-Hellman) based key exchange for this operation.
    /// </para>
    ///  
    /// <para>
    /// Dynamic keys allow you to pass a PEK as a TR-31 WrappedKeyBlock. They can be used
    /// when key material is frequently rotated, such as during every card transaction, and
    /// there is need to avoid importing short-lived keys into Amazon Web Services Payment
    /// Cryptography. To translate PIN block using dynamic keys, the <c>keyARN</c> is the
    /// Key Encryption Key (KEK) of the TR-31 wrapped PEK. The incoming wrapped key shall
    /// have a key purpose of P0 with a mode of use of B or D. For more information, see <a
    /// href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/use-cases-acquirers-dynamickeys.html">Using
    /// Dynamic Keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Using ECDH key exchange, you can receive cardholder selectable PINs into Amazon Web
    /// Services Payment Cryptography. The ECDH derived key protects the incoming PIN block,
    /// which is translated to a PEK encrypted PIN block for use within the service. You can
    /// also use ECDH for reveal PIN, wherein the service translates the PIN block from PEK
    /// to a ECDH derived encryption key. For more information on establishing ECDH derived
    /// keys, see the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/create-keys.html">Generating
    /// keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The allowed combinations of PIN block format translations are guided by PCI. It is
    /// important to note that not all encrypted PIN block formats (example, format 1) require
    /// PAN (Primary Account Number) as input. And as such, PIN block format that requires
    /// PAN (example, formats 0,3,4) cannot be translated to a format (format 1) that does
    /// not require a PAN for generation. 
    /// </para>
    ///  
    /// <para>
    /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Web Services Payment Cryptography currently supports ISO PIN block 4 translation
    /// for PIN block built using legacy PAN length. That is, PAN is the right most 12 digits
    /// excluding the check digits.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GeneratePinData</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifyPinData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TranslatePinDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _encryptedPinBlock;
        private DukptDerivationAttributes _incomingDukptAttributes;
        private string _incomingKeyIdentifier;
        private TranslationIsoFormats _incomingTranslationAttributes;
        private WrappedKey _incomingWrappedKey;
        private DukptDerivationAttributes _outgoingDukptAttributes;
        private string _outgoingKeyIdentifier;
        private TranslationIsoFormats _outgoingTranslationAttributes;
        private WrappedKey _outgoingWrappedKey;

        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// The encrypted PIN block data that Amazon Web Services Payment Cryptography translates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=32)]
        public string EncryptedPinBlock
        {
            get { return this._encryptedPinBlock; }
            set { this._encryptedPinBlock = value; }
        }

        // Check to see if EncryptedPinBlock property is set
        internal bool IsSetEncryptedPinBlock()
        {
            return this._encryptedPinBlock != null;
        }

        /// <summary>
        /// Gets and sets the property IncomingDukptAttributes. 
        /// <para>
        /// The attributes and values to use for incoming DUKPT encryption key for PIN block translation.
        /// </para>
        /// </summary>
        public DukptDerivationAttributes IncomingDukptAttributes
        {
            get { return this._incomingDukptAttributes; }
            set { this._incomingDukptAttributes = value; }
        }

        // Check to see if IncomingDukptAttributes property is set
        internal bool IsSetIncomingDukptAttributes()
        {
            return this._incomingDukptAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property IncomingKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the encryption key under which incoming PIN block data is encrypted.
        /// This key type can be PEK or BDK.
        /// </para>
        ///  
        /// <para>
        /// For dynamic keys, it is the <c>keyARN</c> of KEK of the TR-31 wrapped PEK. For ECDH,
        /// it is the <c>keyARN</c> of the asymmetric ECC key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string IncomingKeyIdentifier
        {
            get { return this._incomingKeyIdentifier; }
            set { this._incomingKeyIdentifier = value; }
        }

        // Check to see if IncomingKeyIdentifier property is set
        internal bool IsSetIncomingKeyIdentifier()
        {
            return this._incomingKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IncomingTranslationAttributes. 
        /// <para>
        /// The format of the incoming PIN block data for translation within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranslationIsoFormats IncomingTranslationAttributes
        {
            get { return this._incomingTranslationAttributes; }
            set { this._incomingTranslationAttributes = value; }
        }

        // Check to see if IncomingTranslationAttributes property is set
        internal bool IsSetIncomingTranslationAttributes()
        {
            return this._incomingTranslationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property IncomingWrappedKey. 
        /// <para>
        /// The WrappedKeyBlock containing the encryption key under which incoming PIN block data
        /// is encrypted.
        /// </para>
        /// </summary>
        public WrappedKey IncomingWrappedKey
        {
            get { return this._incomingWrappedKey; }
            set { this._incomingWrappedKey = value; }
        }

        // Check to see if IncomingWrappedKey property is set
        internal bool IsSetIncomingWrappedKey()
        {
            return this._incomingWrappedKey != null;
        }

        /// <summary>
        /// Gets and sets the property OutgoingDukptAttributes. 
        /// <para>
        /// The attributes and values to use for outgoing DUKPT encryption key after PIN block
        /// translation.
        /// </para>
        /// </summary>
        public DukptDerivationAttributes OutgoingDukptAttributes
        {
            get { return this._outgoingDukptAttributes; }
            set { this._outgoingDukptAttributes = value; }
        }

        // Check to see if OutgoingDukptAttributes property is set
        internal bool IsSetOutgoingDukptAttributes()
        {
            return this._outgoingDukptAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property OutgoingKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the encryption key for encrypting outgoing PIN block data. This
        /// key type can be PEK or BDK.
        /// </para>
        ///  
        /// <para>
        /// For ECDH, it is the <c>keyARN</c> of the asymmetric ECC key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string OutgoingKeyIdentifier
        {
            get { return this._outgoingKeyIdentifier; }
            set { this._outgoingKeyIdentifier = value; }
        }

        // Check to see if OutgoingKeyIdentifier property is set
        internal bool IsSetOutgoingKeyIdentifier()
        {
            return this._outgoingKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OutgoingTranslationAttributes. 
        /// <para>
        /// The format of the outgoing PIN block data after translation by Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranslationIsoFormats OutgoingTranslationAttributes
        {
            get { return this._outgoingTranslationAttributes; }
            set { this._outgoingTranslationAttributes = value; }
        }

        // Check to see if OutgoingTranslationAttributes property is set
        internal bool IsSetOutgoingTranslationAttributes()
        {
            return this._outgoingTranslationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property OutgoingWrappedKey. 
        /// <para>
        /// The WrappedKeyBlock containing the encryption key for encrypting outgoing PIN block
        /// data.
        /// </para>
        /// </summary>
        public WrappedKey OutgoingWrappedKey
        {
            get { return this._outgoingWrappedKey; }
            set { this._outgoingWrappedKey = value; }
        }

        // Check to see if OutgoingWrappedKey property is set
        internal bool IsSetOutgoingWrappedKey()
        {
            return this._outgoingWrappedKey != null;
        }

    }
}