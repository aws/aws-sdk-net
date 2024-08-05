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
    /// Parameters that are required to generate or verify Dynamic Card Verification Value
    /// (dCVV).
    /// </summary>
    public partial class DynamicCardVerificationValue
    {
        private string _applicationTransactionCounter;
        private string _cardExpiryDate;
        private string _panSequenceNumber;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property ApplicationTransactionCounter. 
        /// <para>
        /// The transaction counter value that comes from the terminal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=4)]
        public string ApplicationTransactionCounter
        {
            get { return this._applicationTransactionCounter; }
            set { this._applicationTransactionCounter = value; }
        }

        // Check to see if ApplicationTransactionCounter property is set
        internal bool IsSetApplicationTransactionCounter()
        {
            return this._applicationTransactionCounter != null;
        }

        /// <summary>
        /// Gets and sets the property CardExpiryDate. 
        /// <para>
        /// The expiry date of a payment card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=4, Max=4)]
        public string CardExpiryDate
        {
            get { return this._cardExpiryDate; }
            set { this._cardExpiryDate = value; }
        }

        // Check to see if CardExpiryDate property is set
        internal bool IsSetCardExpiryDate()
        {
            return this._cardExpiryDate != null;
        }

        /// <summary>
        /// Gets and sets the property PanSequenceNumber. 
        /// <para>
        /// A number that identifies and differentiates payment cards with the same Primary Account
        /// Number (PAN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public string PanSequenceNumber
        {
            get { return this._panSequenceNumber; }
            set { this._panSequenceNumber = value; }
        }

        // Check to see if PanSequenceNumber property is set
        internal bool IsSetPanSequenceNumber()
        {
            return this._panSequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code of the payment card. This is different from Card Security Code (CSC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=3, Max=3)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

    }
}