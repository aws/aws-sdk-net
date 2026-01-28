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
    /// Container for the parameters to the TranslateKeyMaterial operation.
    /// Translates an cryptographic key between different wrapping keys without importing
    /// the key into Amazon Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// This operation can be used when key material is frequently rotated, such as during
    /// every card transaction, and there is a need to avoid importing short-lived keys into
    /// Amazon Web Services Payment Cryptography. It translates short-lived transaction keys
    /// such as <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/terminology.html#terms.pek">PEK</a>
    /// generated for each transaction and wrapped with an <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/terminology.html#terms.ecdh">ECDH</a>
    /// derived wrapping key to another <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/terminology.html#terms.kek">KEK</a>
    /// wrapping key. 
    /// </para>
    ///  
    /// <para>
    /// Before using this operation, you must first request the public key certificate of
    /// the ECC key pair generated within Amazon Web Services Payment Cryptography to establish
    /// an ECDH key agreement. In <c>TranslateKeyData</c>, the service uses its own ECC key
    /// pair, public certificate of receiving ECC key pair, and the key derivation parameters
    /// to generate a derived key. The service uses this derived key to unwrap the incoming
    /// transaction key received as a TR31WrappedKeyBlock and re-wrap using a user provided
    /// KEK to generate an outgoing Tr31WrappedKeyBlock.
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
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TranslateKeyMaterialRequest : AmazonPaymentCryptographyDataRequest
    {
        private IncomingKeyMaterial _incomingKeyMaterial;
        private KeyCheckValueAlgorithm _keyCheckValueAlgorithm;
        private OutgoingKeyMaterial _outgoingKeyMaterial;

        /// <summary>
        /// Gets and sets the property IncomingKeyMaterial. 
        /// <para>
        /// Parameter information of the TR31WrappedKeyBlock containing the transaction key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncomingKeyMaterial IncomingKeyMaterial
        {
            get { return this._incomingKeyMaterial; }
            set { this._incomingKeyMaterial = value; }
        }

        // Check to see if IncomingKeyMaterial property is set
        internal bool IsSetIncomingKeyMaterial()
        {
            return this._incomingKeyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCheckValueAlgorithm. 
        /// <para>
        /// The key check value (KCV) algorithm used for calculating the KCV of the derived key.
        /// </para>
        /// </summary>
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm
        {
            get { return this._keyCheckValueAlgorithm; }
            set { this._keyCheckValueAlgorithm = value; }
        }

        // Check to see if KeyCheckValueAlgorithm property is set
        internal bool IsSetKeyCheckValueAlgorithm()
        {
            return this._keyCheckValueAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property OutgoingKeyMaterial. 
        /// <para>
        /// Parameter information of the wrapping key used to wrap the transaction key in the
        /// outgoing TR31WrappedKeyBlock.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutgoingKeyMaterial OutgoingKeyMaterial
        {
            get { return this._outgoingKeyMaterial; }
            set { this._outgoingKeyMaterial = value; }
        }

        // Check to see if OutgoingKeyMaterial property is set
        internal bool IsSetOutgoingKeyMaterial()
        {
            return this._outgoingKeyMaterial != null;
        }

    }
}