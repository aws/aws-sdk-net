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
    /// Container for the parameters to the GenerateAuthRequestCryptogram operation.
    /// Generates an Authorization Request Cryptogram (ARQC) for an EMV chip payment card
    /// authorization. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.generateauthrequestcryptogram.html">Generate
    /// auth request cryptogram</a> in the <i>Amazon Web Services Payment Cryptography User
    /// Guide</i>.
    /// 
    ///  
    /// <para>
    /// ARQC generation uses an Issuer Master Key (IMK) for application cryptograms (TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS)
    /// to derive a session key, which is then used to generate the cryptogram from the provided
    /// transaction data (when applicable). To use this operation, you must first create or
    /// import an IMK-AC key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
    /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// The <c>KeyModesOfUse</c> should be set to <c>DeriveKey</c> for the IMK-AC encryption
    /// key.
    /// </para>
    ///  <important> 
    /// <para>
    /// This operation is intended for development and testing scenarios only. It is not recommended
    /// to use this operation as a substitute for card-based cryptogram generation in production
    /// payment flows.
    /// </para>
    ///  </important> 
    /// <para>
    /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: This operation supports cross-account use when the key
    /// has a resource-based policy that grants access. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/security_iam_resource-based-policies.html">Resource-based
    /// policies</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>VerifyAuthRequestCryptogram</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerateAuthRequestCryptogramRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _keyIdentifier;
        private MajorKeyDerivationMode _majorKeyDerivationMode;
        private SessionKeyDerivation _sessionKeyDerivationAttributes;
        private string _transactionData;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the IMK-AC (TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS) that Amazon Web
        /// Services Payment Cryptography uses to generate the ARQC.
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
        /// The method to use when deriving the major encryption key for ARQC generation within
        /// Amazon Web Services Payment Cryptography.
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
        /// The attributes and values to use for deriving a session key for ARQC generation within
        /// Amazon Web Services Payment Cryptography.
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
        /// The transaction data that Amazon Web Services Payment Cryptography uses for ARQC generation.
        /// The same transaction data is used for ARQC verification by the issuer using <a>VerifyAuthRequestCryptogram</a>.
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