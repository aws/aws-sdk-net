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
    /// Container for the parameters to the VerifyAuthRequestCryptogram operation. Verifies
    /// Authorization Request Cryptogram (ARQC) for a EMV chip payment card authorization.
    /// For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.verifyauthrequestcryptogram.html">Verify
    /// auth request cryptogram</a> in the <i>Amazon Web Services Payment Cryptography User
    /// Guide</i>. <para> ARQC generation is done outside of Amazon Web Services Payment Cryptography
    /// and is typically generated on a point of sale terminal for an EMV chip card to obtain
    /// payment authorization during transaction time. For ARQC verification, you must first
    /// import the ARQC generated outside of Amazon Web Services Payment Cryptography by calling
    /// <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// This operation uses the imported ARQC and an major encryption key (DUKPT) created
    /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
    /// to either provide a boolean ARQC verification result or provide an APRC (Authorization
    /// Response Cryptogram) response using Method 1 or Method 2. The <c>ARPC_METHOD_1</c>
    /// uses <c>AuthResponseCode</c> to generate ARPC and <c>ARPC_METHOD_2</c> uses <c>CardStatusUpdate</c>
    /// to generate ARPC. </para> <para> For information about valid keys for this operation,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>. </para> <para> <b>Cross-account use</b>: This operation supports cross-account
    /// use when the key has a resource-based policy that grants access. For more information,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/security_iam_resource-based-policies.html">Resource-based
    /// policies</a>. </para> <para> <b>Related operations:</b> </para> <ul> <li> <para> <a>VerifyCardValidationData</a>
    /// </para> </li> <li> <para> <a>VerifyPinData</a> </para> </li> </ul>
    /// </summary>
    public partial class VerifyAuthRequestCryptogramRequest : AmazonPaymentCryptographyDataRequest
    {
        /// <summary>
        /// Gets and sets the property AuthRequestCryptogram. 
        /// <para>
        /// The auth request cryptogram imported into Amazon Web Services Payment Cryptography
        /// for ARQC verification using a major encryption key and transaction data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 16)]
        public string AuthRequestCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the AuthRequestCryptogram property is set.
        /// </summary>
        internal bool IsSetAuthRequestCryptogram() => this.AuthRequestCryptogram != null;

        /// <summary>
        /// Gets and sets the property AuthResponseAttributes. 
        /// <para>
        /// The attributes and values for auth request cryptogram verification. These parameters
        /// are required in case using ARPC Method 1 or Method 2 for ARQC verification.
        /// </para>
        /// </summary>
        public CryptogramAuthResponse AuthResponseAttributes { get; set; }

        /// <summary>
        /// Checks to see if the AuthResponseAttributes property is set.
        /// </summary>
        internal bool IsSetAuthResponseAttributes() => this.AuthResponseAttributes != null;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the major encryption key that Amazon Web Services Payment Cryptography
        /// uses for ARQC verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string KeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKeyIdentifier() => this.KeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The method to use when deriving the major encryption key for ARQC verification within
        /// Amazon Web Services Payment Cryptography. The same key derivation mode was used for
        /// ARQC generation outside of Amazon Web Services Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MajorKeyDerivationMode MajorKeyDerivationMode { get; set; }

        /// <summary>
        /// Checks to see if the MajorKeyDerivationMode property is set.
        /// </summary>
        internal bool IsSetMajorKeyDerivationMode() => this.MajorKeyDerivationMode != null;

        /// <summary>
        /// Gets and sets the property SessionKeyDerivationAttributes. 
        /// <para>
        /// The attributes and values to use for deriving a session key for ARQC verification
        /// within Amazon Web Services Payment Cryptography. The same attributes were used for
        /// ARQC generation outside of Amazon Web Services Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionKeyDerivation SessionKeyDerivationAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SessionKeyDerivationAttributes property is set.
        /// </summary>
        internal bool IsSetSessionKeyDerivationAttributes() => this.SessionKeyDerivationAttributes != null;

        /// <summary>
        /// Gets and sets the property TransactionData. 
        /// <para>
        /// The transaction data that Amazon Web Services Payment Cryptography uses for ARQC verification.
        /// The same transaction is used for ARQC generation outside of Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 1024)]
        public string TransactionData { get; set; }

        /// <summary>
        /// Checks to see if the TransactionData property is set.
        /// </summary>
        internal bool IsSetTransactionData() => this.TransactionData != null;
    }
}
