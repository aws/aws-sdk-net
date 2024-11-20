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
    /// Parameters for plaintext encryption using EMV keys.
    /// </summary>
    public partial class EmvEncryptionAttributes
    {
        private string _initializationVector;
        private EmvMajorKeyDerivationMode _majorKeyDerivationMode;
        private EmvEncryptionMode _mode;
        private string _panSequenceNumber;
        private string _primaryAccountNumber;
        private string _sessionDerivationData;

        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// An input used to provide the intial state. If no value is provided, Amazon Web Services
        /// Payment Cryptography defaults it to zero.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=16, Max=32)]
        public string InitializationVector
        {
            get { return this._initializationVector; }
            set { this._initializationVector = value; }
        }

        // Check to see if InitializationVector property is set
        internal bool IsSetInitializationVector()
        {
            return this._initializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The EMV derivation mode to use for ICC master key derivation as per EMV version 4.3
        /// book 2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EmvMajorKeyDerivationMode MajorKeyDerivationMode
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The block cipher method to use for encryption.
        /// </para>
        /// </summary>
        public EmvEncryptionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
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
        /// The Primary Account Number (PAN), a unique identifier for a payment credit or debit
        /// card and associates the card to a specific account holder.
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
        /// Gets and sets the property SessionDerivationData. 
        /// <para>
        /// The derivation value used to derive the ICC session key. It is typically the application
        /// transaction counter value padded with zeros or previous ARQC value padded with zeros
        /// as per EMV version 4.3 book 2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=16)]
        public string SessionDerivationData
        {
            get { return this._sessionDerivationData; }
            set { this._sessionDerivationData = value; }
        }

        // Check to see if SessionDerivationData property is set
        internal bool IsSetSessionDerivationData()
        {
            return this._sessionDerivationData != null;
        }

    }
}