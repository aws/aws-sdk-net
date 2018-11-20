/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify the decryption settings used to decrypt encrypted input
    /// </summary>
    public partial class InputDecryptionSettings
    {
        private DecryptionMode _decryptionMode;
        private string _encryptedDecryptionKey;
        private string _initializationVector;
        private string _kmsKeyRegion;

        /// <summary>
        /// Gets and sets the property DecryptionMode.
        /// </summary>
        public DecryptionMode DecryptionMode
        {
            get { return this._decryptionMode; }
            set { this._decryptionMode = value; }
        }

        // Check to see if DecryptionMode property is set
        internal bool IsSetDecryptionMode()
        {
            return this._decryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptedDecryptionKey. Decryption key either 128 or 192
        /// or 256 bits encrypted with KMS
        /// </summary>
        public string EncryptedDecryptionKey
        {
            get { return this._encryptedDecryptionKey; }
            set { this._encryptedDecryptionKey = value; }
        }

        // Check to see if EncryptedDecryptionKey property is set
        internal bool IsSetEncryptedDecryptionKey()
        {
            return this._encryptedDecryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationVector. Initialization Vector 96 bits (CTR/GCM
        /// mode only) or 128 bits.
        /// </summary>
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
        /// Gets and sets the property KmsKeyRegion. The AWS region in which decryption key was
        /// encrypted with KMS
        /// </summary>
        public string KmsKeyRegion
        {
            get { return this._kmsKeyRegion; }
            set { this._kmsKeyRegion = value; }
        }

        // Check to see if KmsKeyRegion property is set
        internal bool IsSetKmsKeyRegion()
        {
            return this._kmsKeyRegion != null;
        }

    }
}