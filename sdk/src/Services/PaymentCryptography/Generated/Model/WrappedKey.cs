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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
        private string _keyCheckValue;
        private KeyCheckValueAlgorithm _keyCheckValueAlgorithm;
        private string _keyMaterial;
        private WrappedKeyMaterialFormat _wrappedKeyMaterialFormat;
        private string _wrappingKeyArn;

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) is used to check if all parties holding a given key have
        /// the same key or to detect that a key has changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=16)]
        public string KeyCheckValue
        {
            get { return this._keyCheckValue; }
            set { this._keyCheckValue = value; }
        }

        // Check to see if KeyCheckValue property is set
        internal bool IsSetKeyCheckValue()
        {
            return this._keyCheckValue != null;
        }

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
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm
        {
            get { return this._keyCheckValueAlgorithm; }
            set { this._keyCheckValueAlgorithm = value; }
        }

        // Check to see if KeyCheckValueAlgorithm property is set
        internal bool IsSetKeyCheckValueAlgorithm()
        {
            return this._keyCheckValueAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterial. 
        /// <para>
        /// Parameter information for generating a wrapped key using TR-31 or TR-34 skey exchange
        /// method.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=48, Max=16384)]
        public string KeyMaterial
        {
            get { return this._keyMaterial; }
            set { this._keyMaterial = value; }
        }

        // Check to see if KeyMaterial property is set
        internal bool IsSetKeyMaterial()
        {
            return this._keyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterialFormat. 
        /// <para>
        /// The key block format of a wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WrappedKeyMaterialFormat WrappedKeyMaterialFormat
        {
            get { return this._wrappedKeyMaterialFormat; }
            set { this._wrappedKeyMaterialFormat = value; }
        }

        // Check to see if WrappedKeyMaterialFormat property is set
        internal bool IsSetWrappedKeyMaterialFormat()
        {
            return this._wrappedKeyMaterialFormat != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyArn. 
        /// <para>
        /// The <c>KeyARN</c> of the wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string WrappingKeyArn
        {
            get { return this._wrappingKeyArn; }
            set { this._wrappingKeyArn = value; }
        }

        // Check to see if WrappingKeyArn property is set
        internal bool IsSetWrappingKeyArn()
        {
            return this._wrappingKeyArn != null;
        }

    }
}