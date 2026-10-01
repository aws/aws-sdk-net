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
    /// Parameters for plaintext encryption using EMV keys.
    /// </summary>
    public partial class EmvEncryptionAttributes
    {
        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// An input used to provide the intial state. If no value is provided, Amazon Web Services
        /// Payment Cryptography defaults it to zero.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 16, Max = 32)]
        public string InitializationVector { get; set; }

        /// <summary>
        /// Checks to see if the InitializationVector property is set.
        /// </summary>
        internal bool IsSetInitializationVector() => this.InitializationVector != null;

        /// <summary>
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The EMV derivation mode to use for ICC master key derivation as per EMV version 4.3
        /// book 2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EmvMajorKeyDerivationMode MajorKeyDerivationMode { get; set; }

        /// <summary>
        /// Checks to see if the MajorKeyDerivationMode property is set.
        /// </summary>
        internal bool IsSetMajorKeyDerivationMode() => this.MajorKeyDerivationMode != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The block cipher method to use for encryption.
        /// </para>
        /// </summary>
        public EmvEncryptionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property PanSequenceNumber. 
        /// <para>
        /// A number that identifies and differentiates payment cards with the same Primary Account
        /// Number (PAN). Typically 00 is used, if no value is provided by the terminal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string PanSequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the PanSequenceNumber property is set.
        /// </summary>
        internal bool IsSetPanSequenceNumber() => this.PanSequenceNumber != null;

        /// <summary>
        /// Gets and sets the property PrimaryAccountNumber. 
        /// <para>
        /// The Primary Account Number (PAN), a unique identifier for a payment credit or debit
        /// card and associates the card to a specific account holder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 12, Max = 19)]
        public string PrimaryAccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAccountNumber property is set.
        /// </summary>
        internal bool IsSetPrimaryAccountNumber() => this.PrimaryAccountNumber != null;

        /// <summary>
        /// Gets and sets the property SessionDerivationData. 
        /// <para>
        /// The derivation value used to derive the ICC session key. It is typically the application
        /// transaction counter value padded with zeros or previous ARQC value padded with zeros
        /// as per EMV version 4.3 book 2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 16)]
        public string SessionDerivationData { get; set; }

        /// <summary>
        /// Checks to see if the SessionDerivationData property is set.
        /// </summary>
        internal bool IsSetSessionDerivationData() => this.SessionDerivationData != null;
    }
}
