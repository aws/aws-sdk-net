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
    /// Container for the parameters to the VerifyPinData operation. Verifies pin-related
    /// data such as PIN and PIN Offset using algorithms including VISA PVV and IBM3624. For
    /// more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-pin-data.html">Verify
    /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>. <para>
    /// This operation verifies PIN data for user payment card. A card holder PIN data is
    /// never transmitted in clear to or from Amazon Web Services Payment Cryptography. This
    /// operation uses PIN Verification Key (PVK) for PIN or PIN Offset generation and then
    /// encrypts it using PIN Encryption Key (PEK) to create an <c>EncryptedPinBlock</c> for
    /// transmission from Amazon Web Services Payment Cryptography. </para> <para> For information
    /// about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>. </para> <para> <b>Cross-account use</b>: This operation supports cross-account
    /// use when the key has a resource-based policy that grants access. For more information,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/security_iam_resource-based-policies.html">Resource-based
    /// policies</a>. </para> <para> <b>Related operations:</b> </para> <ul> <li> <para> <a>GeneratePinData</a>
    /// </para> </li> <li> <para> <a>TranslatePinData</a> </para> </li> </ul>
    /// </summary>
    public partial class VerifyPinDataRequest : AmazonPaymentCryptographyDataRequest
    {
        /// <summary>
        /// Gets and sets the property DukptAttributes. 
        /// <para>
        /// The attributes and values for the DUKPT encrypted PIN block data.
        /// </para>
        /// </summary>
        public DukptAttributes DukptAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DukptAttributes property is set.
        /// </summary>
        internal bool IsSetDukptAttributes() => this.DukptAttributes != null;

        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// The encrypted PIN block data that Amazon Web Services Payment Cryptography verifies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 32)]
        public string EncryptedPinBlock { get; set; }

        /// <summary>
        /// Checks to see if the EncryptedPinBlock property is set.
        /// </summary>
        internal bool IsSetEncryptedPinBlock() => this.EncryptedPinBlock != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the encryption key under which the PIN block data is encrypted.
        /// This key type can be PEK or BDK.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string EncryptionKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyIdentifier() => this.EncryptionKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property EncryptionWrappedKey.
        /// </summary>
        public WrappedKey EncryptionWrappedKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionWrappedKey property is set.
        /// </summary>
        internal bool IsSetEncryptionWrappedKey() => this.EncryptionWrappedKey != null;

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
        [AWSProperty(Required = true)]
        public PinBlockFormatForPinData PinBlockFormat { get; set; }

        /// <summary>
        /// Checks to see if the PinBlockFormat property is set.
        /// </summary>
        internal bool IsSetPinBlockFormat() => this.PinBlockFormat != null;

        /// <summary>
        /// Gets and sets the property PinDataLength. 
        /// <para>
        /// The length of PIN being verified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 12)]
        public int? PinDataLength { get; set; }

        /// <summary>
        /// Checks to see if the PinDataLength property is set.
        /// </summary>
        internal bool IsSetPinDataLength() => this.PinDataLength.HasValue;

        /// <summary>
        /// Gets and sets the property PrimaryAccountNumber. 
        /// <para>
        /// The Primary Account Number (PAN), a unique identifier for a payment credit or debit
        /// card that associates the card with a specific account holder.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 12, Max = 19)]
        public string PrimaryAccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAccountNumber property is set.
        /// </summary>
        internal bool IsSetPrimaryAccountNumber() => this.PrimaryAccountNumber != null;

        /// <summary>
        /// Gets and sets the property VerificationAttributes. 
        /// <para>
        /// The attributes and values for PIN data verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PinVerificationAttributes VerificationAttributes { get; set; }

        /// <summary>
        /// Checks to see if the VerificationAttributes property is set.
        /// </summary>
        internal bool IsSetVerificationAttributes() => this.VerificationAttributes != null;

        /// <summary>
        /// Gets and sets the property VerificationKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the PIN verification key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string VerificationKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VerificationKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetVerificationKeyIdentifier() => this.VerificationKeyIdentifier != null;
    }
}
