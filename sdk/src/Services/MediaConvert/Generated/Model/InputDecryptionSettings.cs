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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for decrypting any input files that you encrypt before you upload them to
    /// Amazon S3. MediaConvert can decrypt files only when you use AWS Key Management Service
    /// (KMS) to encrypt the data key that you use to encrypt your content.
    /// </summary>
    public partial class InputDecryptionSettings
    {
        private DecryptionMode _decryptionMode;
        private string _encryptedDecryptionKey;
        private string _initializationVector;
        private string _kmsKeyRegion;

        /// <summary>
        /// Gets and sets the property DecryptionMode. Specify the encryption mode that you used
        /// to encrypt your input files.
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
        /// Gets and sets the property EncryptedDecryptionKey. Warning! Don't provide your encryption
        /// key in plaintext. Your job settings could be intercepted, making your encrypted content
        /// vulnerable. Specify the encrypted version of the data key that you used to encrypt
        /// your content. The data key must be encrypted by AWS Key Management Service (KMS).
        /// The key can be 128, 192, or 256 bits.
        /// </summary>
        [AWSProperty(Min=24, Max=512)]
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
        /// Gets and sets the property InitializationVector. Specify the initialization vector
        /// that you used when you encrypted your content before uploading it to Amazon S3. You
        /// can use a 16-byte initialization vector with any encryption mode. Or, you can use
        /// a 12-byte initialization vector with GCM or CTR. MediaConvert accepts only initialization
        /// vectors that are base64-encoded.
        /// </summary>
        [AWSProperty(Min=16, Max=24)]
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
        /// Gets and sets the property KmsKeyRegion. Specify the AWS Region for AWS Key Management
        /// Service (KMS) that you used to encrypt your data key, if that Region is different
        /// from the one you are using for AWS Elemental MediaConvert.
        /// </summary>
        [AWSProperty(Min=9, Max=19)]
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