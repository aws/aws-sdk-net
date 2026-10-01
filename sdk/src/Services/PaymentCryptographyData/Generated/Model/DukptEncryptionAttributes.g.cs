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
    /// Parameters that are required to encrypt plaintext data using DUKPT.
    /// </summary>
    public partial class DukptEncryptionAttributes
    {
        /// <summary>
        /// Gets and sets the property DukptKeyDerivationType. 
        /// <para>
        /// The key type encrypted using DUKPT from a Base Derivation Key (BDK) and Key Serial
        /// Number (KSN). This must be less than or equal to the strength of the BDK. For example,
        /// you can't use <c>AES_128</c> as a derivation type for a BDK of <c>AES_128</c> or <c>TDES_2KEY</c>
        /// 
        /// </para>
        /// </summary>
        public DukptDerivationType DukptKeyDerivationType { get; set; }

        /// <summary>
        /// Checks to see if the DukptKeyDerivationType property is set.
        /// </summary>
        internal bool IsSetDukptKeyDerivationType() => this.DukptKeyDerivationType != null;

        /// <summary>
        /// Gets and sets the property DukptKeyVariant. 
        /// <para>
        /// The type of use of DUKPT, which can be incoming data decryption, outgoing data encryption,
        /// or both.
        /// </para>
        /// </summary>
        public DukptKeyVariant DukptKeyVariant { get; set; }

        /// <summary>
        /// Checks to see if the DukptKeyVariant property is set.
        /// </summary>
        internal bool IsSetDukptKeyVariant() => this.DukptKeyVariant != null;

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
        /// Gets and sets the property KeySerialNumber. 
        /// <para>
        /// The unique identifier known as Key Serial Number (KSN) that comes from an encrypting
        /// device using DUKPT encryption method. The KSN is derived from the encrypting device
        /// unique identifier and an internal transaction counter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 24)]
        public string KeySerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the KeySerialNumber property is set.
        /// </summary>
        internal bool IsSetKeySerialNumber() => this.KeySerialNumber != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The block cipher method to use for encryption.
        /// </para>
        ///  
        /// <para>
        /// The default is CBC.
        /// </para>
        /// </summary>
        public DukptEncryptionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
