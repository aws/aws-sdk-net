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
    /// Parameters to derive the confidentiality and integrity keys for an Emv common payment
    /// card.
    /// </summary>
    public partial class EmvCommonAttributes
    {
        /// <summary>
        /// Gets and sets the property ApplicationCryptogram. 
        /// <para>
        /// The application cryptogram for the current transaction that is provided by the terminal
        /// during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 16)]
        public string ApplicationCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationCryptogram property is set.
        /// </summary>
        internal bool IsSetApplicationCryptogram() => this.ApplicationCryptogram != null;

        /// <summary>
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The method to use when deriving the master key for the payment card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MajorKeyDerivationMode MajorKeyDerivationMode { get; set; }

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
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property PinBlockLengthPosition. 
        /// <para>
        /// Specifies if PIN block length should be added to front of the pin block. 
        /// </para>
        ///  
        /// <para>
        /// If value is set to <c>FRONT_OF_PIN_BLOCK</c>, then PIN block padding type should be
        /// <c>ISO_IEC_7816_4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PinBlockLengthPosition PinBlockLengthPosition { get; set; }

        /// <summary>
        /// Checks to see if the PinBlockLengthPosition property is set.
        /// </summary>
        internal bool IsSetPinBlockLengthPosition() => this.PinBlockLengthPosition != null;

        /// <summary>
        /// Gets and sets the property PinBlockPaddingType. 
        /// <para>
        /// The padding to be added to the PIN block prior to encryption.
        /// </para>
        ///  
        /// <para>
        /// Padding type should be <c>ISO_IEC_7816_4</c>, if <c>PinBlockLengthPosition</c> is
        /// set to <c>FRONT_OF_PIN_BLOCK</c>. No padding is required, if <c>PinBlockLengthPosition</c>
        /// is set to <c>NONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PinBlockPaddingType PinBlockPaddingType { get; set; }

        /// <summary>
        /// Checks to see if the PinBlockPaddingType property is set.
        /// </summary>
        internal bool IsSetPinBlockPaddingType() => this.PinBlockPaddingType != null;

        /// <summary>
        /// Gets and sets the property PrimaryAccountNumber. 
        /// <para>
        /// The Primary Account Number (PAN) of the cardholder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 12, Max = 19)]
        public string PrimaryAccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAccountNumber property is set.
        /// </summary>
        internal bool IsSetPrimaryAccountNumber() => this.PrimaryAccountNumber != null;
    }
}
