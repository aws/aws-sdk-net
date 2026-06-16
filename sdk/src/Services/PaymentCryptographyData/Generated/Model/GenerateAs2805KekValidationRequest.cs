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
    /// Container for the parameters to the GenerateAs2805KekValidation operation.
    /// Generates a <c>KekValidationRequest</c> or a <c>KekValidationResponse</c> for node-to-node
    /// initialization between payment processing nodes using <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/as2805.html">Australian
    /// Standard 2805 (AS2805)</a>.
    /// 
    ///  
    /// <para>
    /// During node-to-node initialization, both communicating nodes must validate that they
    /// possess the correct Key Encrypting Keys (KEKs) before proceeding with session key
    /// exchange. In AS2805, the sending KEK (KEKs) of one node corresponds to the receiving
    /// KEK (KEKr) of its partner node. Each node uses its KEK to encrypt and decrypt session
    /// keys exchanged between the nodes. A KEK can be created or imported into Amazon Web
    /// Services Payment Cryptography using either the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
    /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
    /// operations.
    /// </para>
    ///  
    /// <para>
    /// To use <c>GenerateAs2805KekValidation</c> to generate a KEK validation request, set
    /// <c>KekValidationType</c> to <c>KekValidationRequest</c>. This operation returns both
    /// <c>RandomKeySend</c> (KRs) and <c>RandomKeyReceive</c> (KRr) as response values. The
    /// partnering node receives the KRs, uses its KEKr to decrypt it, and generates a KRr
    /// which is an inverted value of KRs. The node receiving the KRr validates it against
    /// its own KRr generated during KEK validation request outside of Amazon Web Services
    /// Payment Cryptography.
    /// </para>
    ///  
    /// <para>
    /// You can also use this operation to generate a KEK validation response, by setting
    /// <c>KekValidationType</c> to <c>KekValidationResponse</c> and providing the incoming
    /// KRs. This operation then calculates a KRr. To learn more about more about node-to-node
    /// initialization, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/as2805.kekvalidation.html">Validation
    /// of KEK</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
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
    ///  <b>Cross-account use</b>: This operation supports cross-account use when the key
    /// has a resource-based policy that grants access. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/security_iam_resource-based-policies.html">Resource-based
    /// policies</a>.
    /// </para>
    /// </summary>
    public partial class GenerateAs2805KekValidationRequest : AmazonPaymentCryptographyDataRequest
    {
        private As2805KekValidationType _kekValidationType;
        private string _keyIdentifier;
        private RandomKeySendVariantMask _randomKeySendVariantMask;

        /// <summary>
        /// Gets and sets the property KekValidationType. 
        /// <para>
        /// Defines whether to generate a KEK validation request or KEK validation response for
        /// node-to-node initialization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public As2805KekValidationType KekValidationType
        {
            get { return this._kekValidationType; }
            set { this._kekValidationType = value; }
        }

        // Check to see if KekValidationType property is set
        internal bool IsSetKekValidationType()
        {
            return this._kekValidationType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of sending KEK that Amazon Web Services Payment Cryptography uses
        /// for node-to-node initialization
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
        /// Gets and sets the property RandomKeySendVariantMask. 
        /// <para>
        /// The key variant to use for generating a random key for KEK validation during node-to-node
        /// initialization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RandomKeySendVariantMask RandomKeySendVariantMask
        {
            get { return this._randomKeySendVariantMask; }
            set { this._randomKeySendVariantMask = value; }
        }

        // Check to see if RandomKeySendVariantMask property is set
        internal bool IsSetRandomKeySendVariantMask()
        {
            return this._randomKeySendVariantMask != null;
        }

    }
}