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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// The encryption configuration for the repository. This determines how the contents
    /// of your repository are encrypted at rest.
    /// 
    ///  
    /// <para>
    /// By default, when no encryption configuration is set or the <code>AES256</code> encryption
    /// type is used, Amazon ECR uses server-side encryption with Amazon S3-managed encryption
    /// keys which encrypts your data at rest using an AES-256 encryption algorithm. This
    /// does not require any action on your part.
    /// </para>
    ///  
    /// <para>
    /// For more control over the encryption of the contents of your repository, you can use
    /// server-side encryption with customer master keys (CMKs) stored in AWS Key Management
    /// Service (AWS KMS) to encrypt your images. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/encryption-at-rest.html">Amazon
    /// ECR encryption at rest</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private EncryptionType _encryptionType;
        private string _kmsKey;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type to use.
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>KMS</code> encryption type, the contents of the repository will
        /// be encrypted using server-side encryption with customer master keys (CMKs) stored
        /// in AWS KMS. When you use AWS KMS to encrypt your data, you can either use the default
        /// AWS managed CMK for Amazon ECR, or specify your own CMK, which you already created.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs Stored in AWS Key Management Service (SSE-KMS)</a>
        /// in the <i>Amazon Simple Storage Service Console Developer Guide.</i>.
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>AES256</code> encryption type, Amazon ECR uses server-side encryption
        /// with Amazon S3-managed encryption keys which encrypts the images in the repository
        /// using an AES-256 encryption algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Protecting
        /// Data Using Server-Side Encryption with Amazon S3-Managed Encryption Keys (SSE-S3)</a>
        /// in the <i>Amazon Simple Storage Service Console Developer Guide.</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionType EncryptionType
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
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// If you use the <code>KMS</code> encryption type, specify the CMK to use for encryption.
        /// The alias, key ID, or full ARN of the CMK can be specified. The key must exist in
        /// the same Region as the repository. If no key is specified, the default AWS managed
        /// CMK for Amazon ECR will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

    }
}