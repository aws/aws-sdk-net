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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Parameter information for generating a WrappedKeyBlock for key exchange.
    /// </summary>
    public partial class WrappedKey
    {
        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) is used to check if all parties holding a given key have
        /// the same key or to detect that a key has changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 16)]
        public string KeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValue property is set.
        /// </summary>
        internal bool IsSetKeyCheckValue() => this.KeyCheckValue != null;

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
        /// For HMAC keys, the KCV is computed using the hash selected at key creation on a zero-length
        /// message, taking the leftmost 3 bytes.
        /// </para>
        /// </summary>
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValueAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyCheckValueAlgorithm() => this.KeyCheckValueAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyMaterial. 
        /// <para>
        /// Parameter information for generating a wrapped key using TR-31 or TR-34 skey exchange
        /// method.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 32, Max = 16384)]
        public string KeyMaterial { get; set; }

        /// <summary>
        /// Checks to see if the KeyMaterial property is set.
        /// </summary>
        internal bool IsSetKeyMaterial() => this.KeyMaterial != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterialFormat. 
        /// <para>
        /// The key block format of a wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WrappedKeyMaterialFormat WrappedKeyMaterialFormat { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyMaterialFormat property is set.
        /// </summary>
        internal bool IsSetWrappedKeyMaterialFormat() => this.WrappedKeyMaterialFormat != null;

        /// <summary>
        /// Gets and sets the property WrappingKeyArn. 
        /// <para>
        /// The <c>KeyARN</c> of the wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string WrappingKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the WrappingKeyArn property is set.
        /// </summary>
        internal bool IsSetWrappingKeyArn() => this.WrappingKeyArn != null;
    }
}
