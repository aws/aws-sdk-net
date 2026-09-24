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
    /// Parameters required for encryption or decryption of data using DUKPT.
    /// </summary>
    public partial class DukptDerivationAttributes
    {
        /// <summary>
        /// Gets and sets the property DukptKeyDerivationType. 
        /// <para>
        /// The key type derived using DUKPT from a Base Derivation Key (BDK) and Key Serial Number
        /// (KSN). This must be less than or equal to the strength of the BDK. For example, you
        /// can't use <c>AES_128</c> as a derivation type for a BDK of <c>AES_128</c> or <c>TDES_2KEY</c>
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
        /// The type of use of DUKPT, which can be for incoming data decryption, outgoing data
        /// encryption, or both.
        /// </para>
        /// </summary>
        public DukptKeyVariant DukptKeyVariant { get; set; }

        /// <summary>
        /// Checks to see if the DukptKeyVariant property is set.
        /// </summary>
        internal bool IsSetDukptKeyVariant() => this.DukptKeyVariant != null;

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
    }
}
