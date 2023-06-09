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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters requried to encrypt plaintext data using symmetric keys.
    /// </summary>
    public partial class SymmetricEncryptionAttributes
    {
        private string _initializationVector;
        private EncryptionMode _mode;
        private PaddingType _paddingType;

        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// An input to cryptographic primitive used to provide the intial state. The <code>InitializationVector</code>
        /// is typically required have a random or psuedo-random value, but sometimes it only
        /// needs to be unpredictable or unique. If a value is not provided, Amazon Web Services
        /// Payment Cryptography generates a random value.
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The block cipher mode of operation. Block ciphers are designed to encrypt a block
        /// of data of fixed size (for example, 128 bits). The size of the input block is usually
        /// same as the size of the encrypted output block, while the key length can be different.
        /// A mode of operation describes how to repeatedly apply a cipher's single-block operation
        /// to securely transform amounts of data larger than a block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionMode Mode
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
        /// Gets and sets the property PaddingType. 
        /// <para>
        /// The padding to be included with the data.
        /// </para>
        /// </summary>
        public PaddingType PaddingType
        {
            get { return this._paddingType; }
            set { this._paddingType = value; }
        }

        // Check to see if PaddingType property is set
        internal bool IsSetPaddingType()
        {
            return this._paddingType != null;
        }

    }
}