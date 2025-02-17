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
    /// Parameters to derive the confidentiality and integrity keys for a payment card using
    /// EMV2000 deruv.
    /// </summary>
    public partial class Emv2000Attributes
    {
        private string _applicationTransactionCounter;
        private MajorKeyDerivationMode _majorKeyDerivationMode;
        private string _panSequenceNumber;
        private string _primaryAccountNumber;

        /// <summary>
        /// Gets and sets the property ApplicationTransactionCounter. 
        /// <para>
        /// The transaction counter of the current transaction that is provided by the terminal
        /// during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=4)]
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
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The method to use when deriving the master key for the payment card.
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
        /// Gets and sets the property PanSequenceNumber. 
        /// <para>
        /// A number that identifies and differentiates payment cards with the same Primary Account
        /// Number (PAN). Typically 00 is used, if no value is provided by the terminal.
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
        /// Gets and sets the property PrimaryAccountNumber. 
        /// <para>
        /// The Primary Account Number (PAN) of the cardholder.
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

    }
}