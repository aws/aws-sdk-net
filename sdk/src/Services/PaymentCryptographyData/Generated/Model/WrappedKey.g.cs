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
    /// Parameter information of a WrappedKeyBlock for encryption key exchange.
    /// </summary>
    public partial class WrappedKey
    {
        /// <summary>
        /// Gets and sets the property KeyCheckValueAlgorithm. 
        /// <para>
        /// The algorithm that Amazon Web Services Payment Cryptography uses to calculate the
        /// key check value (KCV). It is used to validate the key integrity.
        /// </para>
        ///  
        /// <para>
        /// For TDES keys, the KCV is computed by encrypting 8 bytes, each with value of zero,
        /// with the key to be checked and retaining the 3 highest order bytes of the encrypted
        /// result. For AES keys, the KCV is computed using a CMAC algorithm where the input data
        /// is 16 bytes of zero and retaining the 3 highest order bytes of the encrypted result.
        /// </para>
        /// </summary>
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValueAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyCheckValueAlgorithm() => this.KeyCheckValueAlgorithm != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterial. 
        /// <para>
        /// Parameter information of a WrappedKeyBlock for encryption key exchange.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WrappedKeyMaterial WrappedKeyMaterial { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyMaterial property is set.
        /// </summary>
        internal bool IsSetWrappedKeyMaterial() => this.WrappedKeyMaterial != null;
    }
}
