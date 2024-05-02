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
    /// Container for the parameters to the GenerateCardValidationData operation.
    /// Generates card-related validation data using algorithms such as Card Verification
    /// Values (CVV/CVV2), Dynamic Card Verification Values (dCVV/dCVV2), or Card Security
    /// Codes (CSC). For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-card-data.html">Generate
    /// card data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation generates a CVV or CSC value that is printed on a payment credit or
    /// debit card during card production. The CVV or CSC, PAN (Primary Account Number) and
    /// expiration date of the card are required to check its validity during transaction
    /// processing. To begin this operation, a CVK (Card Verification Key) encryption key
    /// is required. You can use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
    /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
    /// to establish a CVK within Amazon Web Services Payment Cryptography. The <c>KeyModesOfUse</c>
    /// should be set to <c>Generate</c> and <c>Verify</c> for a CVK encryption key. 
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
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifyCardValidationData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerateCardValidationDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private CardGenerationAttributes _generationAttributes;
        private string _keyIdentifier;
        private string _primaryAccountNumber;
        private int? _validationDataLength;

        /// <summary>
        /// Gets and sets the property GenerationAttributes. 
        /// <para>
        /// The algorithm for generating CVV or CSC values for the card within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CardGenerationAttributes GenerationAttributes
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
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the CVK encryption key that Amazon Web Services Payment Cryptography
        /// uses to generate card data.
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
        /// Gets and sets the property ValidationDataLength. 
        /// <para>
        /// The length of the CVV or CSC to be generated. The default value is 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=5)]
        public int? ValidationDataLength
        {
            get { return this._validationDataLength; }
            set { this._validationDataLength = value; }
        }

        // Check to see if ValidationDataLength property is set
        internal bool IsSetValidationDataLength()
        {
            return this._validationDataLength.HasValue; 
        }

    }
}