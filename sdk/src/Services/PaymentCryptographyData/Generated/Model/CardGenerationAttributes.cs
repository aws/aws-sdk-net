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
    /// Card data parameters that are required to generate Card Verification Values (CVV/CVV2),
    /// Dynamic Card Verification Values (dCVV/dCVV2), or Card Security Codes (CSC).
    /// </summary>
    public partial class CardGenerationAttributes
    {
        private AmexCardSecurityCodeVersion1 _amexCardSecurityCodeVersion1;
        private AmexCardSecurityCodeVersion2 _amexCardSecurityCodeVersion2;
        private CardHolderVerificationValue _cardHolderVerificationValue;
        private CardVerificationValue1 _cardVerificationValue1;
        private CardVerificationValue2 _cardVerificationValue2;
        private DynamicCardVerificationCode _dynamicCardVerificationCode;
        private DynamicCardVerificationValue _dynamicCardVerificationValue;

        /// <summary>
        /// Gets and sets the property AmexCardSecurityCodeVersion1.
        /// </summary>
        public AmexCardSecurityCodeVersion1 AmexCardSecurityCodeVersion1
        {
            get { return this._amexCardSecurityCodeVersion1; }
            set { this._amexCardSecurityCodeVersion1 = value; }
        }

        // Check to see if AmexCardSecurityCodeVersion1 property is set
        internal bool IsSetAmexCardSecurityCodeVersion1()
        {
            return this._amexCardSecurityCodeVersion1 != null;
        }

        /// <summary>
        /// Gets and sets the property AmexCardSecurityCodeVersion2. 
        /// <para>
        /// Card data parameters that are required to generate a Card Security Code (CSC2) for
        /// an AMEX payment card.
        /// </para>
        /// </summary>
        public AmexCardSecurityCodeVersion2 AmexCardSecurityCodeVersion2
        {
            get { return this._amexCardSecurityCodeVersion2; }
            set { this._amexCardSecurityCodeVersion2 = value; }
        }

        // Check to see if AmexCardSecurityCodeVersion2 property is set
        internal bool IsSetAmexCardSecurityCodeVersion2()
        {
            return this._amexCardSecurityCodeVersion2 != null;
        }

        /// <summary>
        /// Gets and sets the property CardHolderVerificationValue. 
        /// <para>
        /// Card data parameters that are required to generate a cardholder verification value
        /// for the payment card.
        /// </para>
        /// </summary>
        public CardHolderVerificationValue CardHolderVerificationValue
        {
            get { return this._cardHolderVerificationValue; }
            set { this._cardHolderVerificationValue = value; }
        }

        // Check to see if CardHolderVerificationValue property is set
        internal bool IsSetCardHolderVerificationValue()
        {
            return this._cardHolderVerificationValue != null;
        }

        /// <summary>
        /// Gets and sets the property CardVerificationValue1. 
        /// <para>
        /// Card data parameters that are required to generate Card Verification Value (CVV) for
        /// the payment card.
        /// </para>
        /// </summary>
        public CardVerificationValue1 CardVerificationValue1
        {
            get { return this._cardVerificationValue1; }
            set { this._cardVerificationValue1 = value; }
        }

        // Check to see if CardVerificationValue1 property is set
        internal bool IsSetCardVerificationValue1()
        {
            return this._cardVerificationValue1 != null;
        }

        /// <summary>
        /// Gets and sets the property CardVerificationValue2. 
        /// <para>
        /// Card data parameters that are required to generate Card Verification Value (CVV2)
        /// for the payment card.
        /// </para>
        /// </summary>
        public CardVerificationValue2 CardVerificationValue2
        {
            get { return this._cardVerificationValue2; }
            set { this._cardVerificationValue2 = value; }
        }

        // Check to see if CardVerificationValue2 property is set
        internal bool IsSetCardVerificationValue2()
        {
            return this._cardVerificationValue2 != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicCardVerificationCode. 
        /// <para>
        /// Card data parameters that are required to generate CDynamic Card Verification Code
        /// (dCVC) for the payment card.
        /// </para>
        /// </summary>
        public DynamicCardVerificationCode DynamicCardVerificationCode
        {
            get { return this._dynamicCardVerificationCode; }
            set { this._dynamicCardVerificationCode = value; }
        }

        // Check to see if DynamicCardVerificationCode property is set
        internal bool IsSetDynamicCardVerificationCode()
        {
            return this._dynamicCardVerificationCode != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicCardVerificationValue. 
        /// <para>
        /// Card data parameters that are required to generate CDynamic Card Verification Value
        /// (dCVV) for the payment card.
        /// </para>
        /// </summary>
        public DynamicCardVerificationValue DynamicCardVerificationValue
        {
            get { return this._dynamicCardVerificationValue; }
            set { this._dynamicCardVerificationValue = value; }
        }

        // Check to see if DynamicCardVerificationValue property is set
        internal bool IsSetDynamicCardVerificationValue()
        {
            return this._dynamicCardVerificationValue != null;
        }

    }
}