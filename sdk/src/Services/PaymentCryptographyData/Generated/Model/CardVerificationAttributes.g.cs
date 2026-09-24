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
    /// Card data parameters that are requried to verify Card Verification Values (CVV/CVV2),
    /// Dynamic Card Verification Values (dCVV/dCVV2), or Card Security Codes (CSC).
    /// </summary>
    public partial class CardVerificationAttributes
    {
        /// <summary>
        /// Gets and sets the property AmexCardSecurityCodeVersion1.
        /// </summary>
        public AmexCardSecurityCodeVersion1 AmexCardSecurityCodeVersion1 { get; set; }

        /// <summary>
        /// Checks to see if the AmexCardSecurityCodeVersion1 property is set.
        /// </summary>
        internal bool IsSetAmexCardSecurityCodeVersion1() => this.AmexCardSecurityCodeVersion1 != null;

        /// <summary>
        /// Gets and sets the property AmexCardSecurityCodeVersion2. 
        /// <para>
        /// Card data parameters that are required to verify a Card Security Code (CSC2) for an
        /// AMEX payment card.
        /// </para>
        /// </summary>
        public AmexCardSecurityCodeVersion2 AmexCardSecurityCodeVersion2 { get; set; }

        /// <summary>
        /// Checks to see if the AmexCardSecurityCodeVersion2 property is set.
        /// </summary>
        internal bool IsSetAmexCardSecurityCodeVersion2() => this.AmexCardSecurityCodeVersion2 != null;

        /// <summary>
        /// Gets and sets the property CardHolderVerificationValue. 
        /// <para>
        /// Card data parameters that are required to verify a cardholder verification value for
        /// the payment card.
        /// </para>
        /// </summary>
        public CardHolderVerificationValue CardHolderVerificationValue { get; set; }

        /// <summary>
        /// Checks to see if the CardHolderVerificationValue property is set.
        /// </summary>
        internal bool IsSetCardHolderVerificationValue() => this.CardHolderVerificationValue != null;

        /// <summary>
        /// Gets and sets the property CardVerificationValue1. 
        /// <para>
        /// Card data parameters that are required to verify Card Verification Value (CVV) for
        /// the payment card.
        /// </para>
        /// </summary>
        public CardVerificationValue1 CardVerificationValue1 { get; set; }

        /// <summary>
        /// Checks to see if the CardVerificationValue1 property is set.
        /// </summary>
        internal bool IsSetCardVerificationValue1() => this.CardVerificationValue1 != null;

        /// <summary>
        /// Gets and sets the property CardVerificationValue2. 
        /// <para>
        /// Card data parameters that are required to verify Card Verification Value (CVV2) for
        /// the payment card.
        /// </para>
        /// </summary>
        public CardVerificationValue2 CardVerificationValue2 { get; set; }

        /// <summary>
        /// Checks to see if the CardVerificationValue2 property is set.
        /// </summary>
        internal bool IsSetCardVerificationValue2() => this.CardVerificationValue2 != null;

        /// <summary>
        /// Gets and sets the property DiscoverDynamicCardVerificationCode. 
        /// <para>
        /// Card data parameters that are required to verify CDynamic Card Verification Code (dCVC)
        /// for the payment card.
        /// </para>
        /// </summary>
        public DiscoverDynamicCardVerificationCode DiscoverDynamicCardVerificationCode { get; set; }

        /// <summary>
        /// Checks to see if the DiscoverDynamicCardVerificationCode property is set.
        /// </summary>
        internal bool IsSetDiscoverDynamicCardVerificationCode() => this.DiscoverDynamicCardVerificationCode != null;

        /// <summary>
        /// Gets and sets the property DynamicCardVerificationCode. 
        /// <para>
        /// Card data parameters that are required to verify CDynamic Card Verification Code (dCVC)
        /// for the payment card.
        /// </para>
        /// </summary>
        public DynamicCardVerificationCode DynamicCardVerificationCode { get; set; }

        /// <summary>
        /// Checks to see if the DynamicCardVerificationCode property is set.
        /// </summary>
        internal bool IsSetDynamicCardVerificationCode() => this.DynamicCardVerificationCode != null;

        /// <summary>
        /// Gets and sets the property DynamicCardVerificationValue. 
        /// <para>
        /// Card data parameters that are required to verify CDynamic Card Verification Value
        /// (dCVV) for the payment card.
        /// </para>
        /// </summary>
        public DynamicCardVerificationValue DynamicCardVerificationValue { get; set; }

        /// <summary>
        /// Checks to see if the DynamicCardVerificationValue property is set.
        /// </summary>
        internal bool IsSetDynamicCardVerificationValue() => this.DynamicCardVerificationValue != null;
    }
}
