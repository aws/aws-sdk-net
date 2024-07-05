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
    /// Container for the parameters to the VerifyCardValidationData operation.
    /// Verifies card-related validation data using algorithms such as Card Verification Values
    /// (CVV/CVV2), Dynamic Card Verification Values (dCVV/dCVV2) and Card Security Codes
    /// (CSC). For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-card-data.html">Verify
    /// card data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation validates the CVV or CSC codes that is printed on a payment credit
    /// or debit card during card payment transaction. The input values are typically provided
    /// as part of an inbound transaction to an issuer or supporting platform partner. Amazon
    /// Web Services Payment Cryptography uses CVV or CSC, PAN (Primary Account Number) and
    /// expiration date of the card to check its validity during transaction processing. In
    /// this operation, the CVK (Card Verification Key) encryption key for use with card data
    /// verification is same as the one in used for <a>GenerateCardValidationData</a>. 
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
    ///  <a>VerifyAuthRequestCryptogram</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifyPinData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class VerifyCardValidationDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _keyIdentifier;
        private string _primaryAccountNumber;
        private string _validationData;
        private CardVerificationAttributes _verificationAttributes;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the CVK encryption key that Amazon Web Services Payment Cryptography
        /// uses to verify card data.
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
        /// Gets and sets the property ValidationData. 
        /// <para>
        /// The CVV or CSC value for use for card data verification within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=3, Max=5)]
        public string ValidationData
        {
            get { return this._validationData; }
            set { this._validationData = value; }
        }

        // Check to see if ValidationData property is set
        internal bool IsSetValidationData()
        {
            return this._validationData != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationAttributes. 
        /// <para>
        /// The algorithm to use for verification of card data within Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CardVerificationAttributes VerificationAttributes
        {
            get { return this._verificationAttributes; }
            set { this._verificationAttributes = value; }
        }

        // Check to see if VerificationAttributes property is set
        internal bool IsSetVerificationAttributes()
        {
            return this._verificationAttributes != null;
        }

    }
}