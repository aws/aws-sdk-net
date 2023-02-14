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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for how your job outputs are encrypted as they are uploaded to Amazon S3.
    /// </summary>
    public partial class S3EncryptionSettings
    {
        private S3ServerSideEncryptionType _encryptionType;
        private string _kmsEncryptionContext;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property EncryptionType. Specify how you want your data keys managed.
        /// AWS uses data keys to encrypt your content. AWS also encrypts the data keys themselves,
        /// using a customer master key (CMK), and then stores the encrypted data keys alongside
        /// your encrypted content. Use this setting to specify which AWS service manages the
        /// CMK. For simplest set up, choose Amazon S3 (SERVER_SIDE_ENCRYPTION_S3). If you want
        /// your master key to be managed by AWS Key Management Service (KMS), choose AWS KMS
        /// (SERVER_SIDE_ENCRYPTION_KMS). By default, when you choose AWS KMS, KMS uses the AWS
        /// managed customer master key (CMK) associated with Amazon S3 to encrypt your data keys.
        /// You can optionally choose to specify a different, customer managed CMK. Do so by specifying
        /// the Amazon Resource Name (ARN) of the key for the setting KMS ARN (kmsKeyArn).
        /// </summary>
        public S3ServerSideEncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsEncryptionContext. Optionally, specify the encryption
        /// context that you want to use alongside your KMS key. AWS KMS uses this encryption
        /// context as additional authenticated data (AAD) to support authenticated encryption.
        /// This value must be a base64-encoded UTF-8 string holding JSON which represents a string-string
        /// map. To use this setting, you must also set Server-side encryption (S3ServerSideEncryptionType)
        /// to AWS KMS (SERVER_SIDE_ENCRYPTION_KMS). For more information about encryption context,
        /// see: https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context.
        /// </summary>
        public string KmsEncryptionContext
        {
            get { return this._kmsEncryptionContext; }
            set { this._kmsEncryptionContext = value; }
        }

        // Check to see if KmsEncryptionContext property is set
        internal bool IsSetKmsEncryptionContext()
        {
            return this._kmsEncryptionContext != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. Optionally, specify the customer master key
        /// (CMK) that you want to use to encrypt the data key that AWS uses to encrypt your output
        /// content. Enter the Amazon Resource Name (ARN) of the CMK. To use this setting, you
        /// must also set Server-side encryption (S3ServerSideEncryptionType) to AWS KMS (SERVER_SIDE_ENCRYPTION_KMS).
        /// If you set Server-side encryption to AWS KMS but don't specify a CMK here, AWS uses
        /// the AWS managed CMK associated with Amazon S3.
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}