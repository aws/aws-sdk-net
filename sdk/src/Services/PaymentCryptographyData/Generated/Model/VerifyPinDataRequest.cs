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
    /// Container for the parameters to the VerifyPinData operation.
    /// Verifies pin-related data such as PIN and PIN Offset using algorithms including VISA
    /// PVV and IBM3624. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-pin-data.html">Verify
    /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation verifies PIN data for user payment card. A card holder PIN data is
    /// never transmitted in clear to or from Amazon Web Services Payment Cryptography. This
    /// operation uses PIN Verification Key (PVK) for PIN or PIN Offset generation and then
    /// encrypts it using PIN Encryption Key (PEK) to create an <c>EncryptedPinBlock</c> for
    /// transmission from Amazon Web Services Payment Cryptography. 
    /// </para>
    ///  
    /// <para>
    /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>. 
    /// </para>
    ///  
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
    ///  <a>TranslatePinData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class VerifyPinDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private DukptAttributes _dukptAttributes;
        private string _encryptedPinBlock;
        private string _encryptionKeyIdentifier;
        private WrappedKey _encryptionWrappedKey;
        private PinBlockFormatForPinData _pinBlockFormat;
        private int? _pinDataLength;
        private string _primaryAccountNumber;
        private PinVerificationAttributes _verificationAttributes;
        private string _verificationKeyIdentifier;

        /// <summary>
        /// Gets and sets the property DukptAttributes. 
        /// <para>
        /// The attributes and values for the DUKPT encrypted PIN block data.
        /// </para>
        /// </summary>
        public DukptAttributes DukptAttributes
        {
            get { return this._dukptAttributes; }
            set { this._dukptAttributes = value; }
        }

        // Check to see if DukptAttributes property is set
        internal bool IsSetDukptAttributes()
        {
            return this._dukptAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// The encrypted PIN block data that Amazon Web Services Payment Cryptography verifies.
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
        /// Gets and sets the property EncryptionKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the encryption key under which the PIN block data is encrypted.
        /// This key type can be PEK or BDK.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string EncryptionKeyIdentifier
        {
            get { return this._encryptionKeyIdentifier; }
            set { this._encryptionKeyIdentifier = value; }
        }

        // Check to see if EncryptionKeyIdentifier property is set
        internal bool IsSetEncryptionKeyIdentifier()
        {
            return this._encryptionKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionWrappedKey.
        /// </summary>
        public WrappedKey EncryptionWrappedKey
        {
            get { return this._encryptionWrappedKey; }
            set { this._encryptionWrappedKey = value; }
        }

        // Check to see if EncryptionWrappedKey property is set
        internal bool IsSetEncryptionWrappedKey()
        {
            return this._encryptionWrappedKey != null;
        }

        /// <summary>
        /// Gets and sets the property PinBlockFormat. 
        /// <para>
        /// The PIN encoding format for pin data generation as specified in ISO 9564. Amazon Web
        /// Services Payment Cryptography supports <c>ISO_Format_0</c> and <c>ISO_Format_3</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>ISO_Format_0</c> PIN block format is equivalent to the ANSI X9.8, VISA-1, and
        /// ECI-1 PIN block formats. It is similar to a VISA-4 PIN block format. It supports a
        /// PIN from 4 to 12 digits in length.
        /// </para>
        ///  
        /// <para>
        /// The <c>ISO_Format_3</c> PIN block format is the same as <c>ISO_Format_0</c> except
        /// that the fill digits are random values from 10 to 15.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PinBlockFormatForPinData PinBlockFormat
        {
            get { return this._pinBlockFormat; }
            set { this._pinBlockFormat = value; }
        }

        // Check to see if PinBlockFormat property is set
        internal bool IsSetPinBlockFormat()
        {
            return this._pinBlockFormat != null;
        }

        /// <summary>
        /// Gets and sets the property PinDataLength. 
        /// <para>
        /// The length of PIN being verified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=12)]
        public int? PinDataLength
        {
            get { return this._pinDataLength; }
            set { this._pinDataLength = value; }
        }

        // Check to see if PinDataLength property is set
        internal bool IsSetPinDataLength()
        {
            return this._pinDataLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryAccountNumber. 
        /// <para>
        /// The Primary Account Number (PAN), a unique identifier for a payment credit or debit
        /// card that associates the card with a specific account holder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=12, Max=19)]
        public string PrimaryAccountNumber
        {
            get { return this._primaryAccountNumber; }
            set { this._primaryAccountNumber = value; }
        }

        // Check to see if PrimaryAccountNumber property is set
        internal bool IsSetPrimaryAccountNumber()
        {
            return this._primaryAccountNumber != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationAttributes. 
        /// <para>
        /// The attributes and values for PIN data verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PinVerificationAttributes VerificationAttributes
        {
            get { return this._verificationAttributes; }
            set { this._verificationAttributes = value; }
        }

        // Check to see if VerificationAttributes property is set
        internal bool IsSetVerificationAttributes()
        {
            return this._verificationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the PIN verification key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string VerificationKeyIdentifier
        {
            get { return this._verificationKeyIdentifier; }
            set { this._verificationKeyIdentifier = value; }
        }

        // Check to see if VerificationKeyIdentifier property is set
        internal bool IsSetVerificationKeyIdentifier()
        {
            return this._verificationKeyIdentifier != null;
        }

    }
}