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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Container for the parameters to the GeneratePinData operation.
    /// Generates pin-related data such as PIN, PIN Verification Value (PVV), PIN Block, and
    /// PIN Offset during new card issuance or reissuance. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-pin-data.html">Generate
    /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// PIN data is never transmitted in clear to or from Amazon Web Services Payment Cryptography.
    /// This operation generates PIN, PVV, or PIN Offset and then encrypts it using Pin Encryption
    /// Key (PEK) to create an <code>EncryptedPinBlock</code> for transmission from Amazon
    /// Web Services Payment Cryptography. This operation uses a separate Pin Verification
    /// Key (PVK) for VISA PVV generation. 
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
    ///  <a>GenerateCardValidationData</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TranslatePinData</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifyPinData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GeneratePinDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _encryptionKeyIdentifier;
        private PinGenerationAttributes _generationAttributes;
        private string _generationKeyIdentifier;
        private PinBlockFormatForPinData _pinBlockFormat;
        private int? _pinDataLength;
        private string _primaryAccountNumber;

        /// <summary>
        /// Gets and sets the property EncryptionKeyIdentifier. 
        /// <para>
        /// The <code>keyARN</code> of the PEK that Amazon Web Services Payment Cryptography uses
        /// to encrypt the PIN Block.
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
        /// Gets and sets the property GenerationAttributes. 
        /// <para>
        /// The attributes and values to use for PIN, PVV, or PIN Offset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PinGenerationAttributes GenerationAttributes
        {
            get { return this._generationAttributes; }
            set { this._generationAttributes = value; }
        }

        // Check to see if GenerationAttributes property is set
        internal bool IsSetGenerationAttributes()
        {
            return this._generationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationKeyIdentifier. 
        /// <para>
        /// The <code>keyARN</code> of the PEK that Amazon Web Services Payment Cryptography uses
        /// for pin data generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string GenerationKeyIdentifier
        {
            get { return this._generationKeyIdentifier; }
            set { this._generationKeyIdentifier = value; }
        }

        // Check to see if GenerationKeyIdentifier property is set
        internal bool IsSetGenerationKeyIdentifier()
        {
            return this._generationKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PinBlockFormat. 
        /// <para>
        /// The PIN encoding format for pin data generation as specified in ISO 9564. Amazon Web
        /// Services Payment Cryptography supports <code>ISO_Format_0</code> and <code>ISO_Format_3</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>ISO_Format_0</code> PIN block format is equivalent to the ANSI X9.8, VISA-1,
        /// and ECI-1 PIN block formats. It is similar to a VISA-4 PIN block format. It supports
        /// a PIN from 4 to 12 digits in length.
        /// </para>
        ///  
        /// <para>
        /// The <code>ISO_Format_3</code> PIN block format is the same as <code>ISO_Format_0</code>
        /// except that the fill digits are random values from 10 to 15.
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
        /// The length of PIN under generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=12)]
        public int PinDataLength
        {
            get { return this._pinDataLength.GetValueOrDefault(); }
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

    }
}