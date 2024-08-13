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
    /// Container for the parameters to the VerifyAuthRequestCryptogram operation.
    /// Verifies Authorization Request Cryptogram (ARQC) for a EMV chip payment card authorization.
    /// For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.verifyauthrequestcryptogram.html">Verify
    /// auth request cryptogram</a> in the <i>Amazon Web Services Payment Cryptography User
    /// Guide</i>.
    /// 
    ///  
    /// <para>
    /// ARQC generation is done outside of Amazon Web Services Payment Cryptography and is
    /// typically generated on a point of sale terminal for an EMV chip card to obtain payment
    /// authorization during transaction time. For ARQC verification, you must first import
    /// the ARQC generated outside of Amazon Web Services Payment Cryptography by calling
    /// <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// This operation uses the imported ARQC and an major encryption key (DUKPT) created
    /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
    /// to either provide a boolean ARQC verification result or provide an APRC (Authorization
    /// Response Cryptogram) response using Method 1 or Method 2. The <c>ARPC_METHOD_1</c>
    /// uses <c>AuthResponseCode</c> to generate ARPC and <c>ARPC_METHOD_2</c> uses <c>CardStatusUpdate</c>
    /// to generate ARPC. 
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
    ///  <a>VerifyCardValidationData</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifyPinData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class VerifyAuthRequestCryptogramRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _authRequestCryptogram;
        private CryptogramAuthResponse _authResponseAttributes;
        private string _keyIdentifier;
        private MajorKeyDerivationMode _majorKeyDerivationMode;
        private SessionKeyDerivation _sessionKeyDerivationAttributes;
        private string _transactionData;

        /// <summary>
        /// Gets and sets the property AuthRequestCryptogram. 
        /// <para>
        /// The auth request cryptogram imported into Amazon Web Services Payment Cryptography
        /// for ARQC verification using a major encryption key and transaction data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=16)]
        public string AuthRequestCryptogram
        {
            get { return this._authRequestCryptogram; }
            set { this._authRequestCryptogram = value; }
        }

        // Check to see if AuthRequestCryptogram property is set
        internal bool IsSetAuthRequestCryptogram()
        {
            return this._authRequestCryptogram != null;
        }

        /// <summary>
        /// Gets and sets the property AuthResponseAttributes. 
        /// <para>
        /// The attributes and values for auth request cryptogram verification. These parameters
        /// are required in case using ARPC Method 1 or Method 2 for ARQC verification.
        /// </para>
        /// </summary>
        public CryptogramAuthResponse AuthResponseAttributes
        {
            get { return this._authResponseAttributes; }
            set { this._authResponseAttributes = value; }
        }

        // Check to see if AuthResponseAttributes property is set
        internal bool IsSetAuthResponseAttributes()
        {
            return this._authResponseAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the major encryption key that Amazon Web Services Payment Cryptography
        /// uses for ARQC verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string KeyIdentifier
        {
            get { return this._keyIdentifier; }
            set { this._keyIdentifier = value; }
        }

        // Check to see if KeyIdentifier property is set
        internal bool IsSetKeyIdentifier()
        {
            return this._keyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The method to use when deriving the major encryption key for ARQC verification within
        /// Amazon Web Services Payment Cryptography. The same key derivation mode was used for
        /// ARQC generation outside of Amazon Web Services Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MajorKeyDerivationMode MajorKeyDerivationMode
        {
            get { return this._majorKeyDerivationMode; }
            set { this._majorKeyDerivationMode = value; }
        }

        // Check to see if MajorKeyDerivationMode property is set
        internal bool IsSetMajorKeyDerivationMode()
        {
            return this._majorKeyDerivationMode != null;
        }

        /// <summary>
        /// Gets and sets the property SessionKeyDerivationAttributes. 
        /// <para>
        /// The attributes and values to use for deriving a session key for ARQC verification
        /// within Amazon Web Services Payment Cryptography. The same attributes were used for
        /// ARQC generation outside of Amazon Web Services Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionKeyDerivation SessionKeyDerivationAttributes
        {
            get { return this._sessionKeyDerivationAttributes; }
            set { this._sessionKeyDerivationAttributes = value; }
        }

        // Check to see if SessionKeyDerivationAttributes property is set
        internal bool IsSetSessionKeyDerivationAttributes()
        {
            return this._sessionKeyDerivationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionData. 
        /// <para>
        /// The transaction data that Amazon Web Services Payment Cryptography uses for ARQC verification.
        /// The same transaction is used for ARQC generation outside of Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=1024)]
        public string TransactionData
        {
            get { return this._transactionData; }
            set { this._transactionData = value; }
        }

        // Check to see if TransactionData property is set
        internal bool IsSetTransactionData()
        {
            return this._transactionData != null;
        }

    }
}