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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The encryption configuration to associate with the repository creation template.
    /// </summary>
    public partial class EncryptionConfigurationForRepositoryCreationTemplate
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
        /// If you use the <c>KMS</c> encryption type, the contents of the repository will be
        /// encrypted using server-side encryption with Key Management Service key stored in KMS.
        /// When you use KMS to encrypt your data, you can either use the default Amazon Web Services
        /// managed KMS key for Amazon ECR, or specify your own KMS key, which you already created.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// data using server-side encryption with an KMS key stored in Key Management Service
        /// (SSE-KMS)</a> in the <i>Amazon Simple Storage Service Console Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you use the <c>AES256</c> encryption type, Amazon ECR uses server-side encryption
        /// with Amazon S3-managed encryption keys which encrypts the images in the repository
        /// using an AES256 encryption algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Protecting
        /// data using server-side encryption with Amazon S3-managed encryption keys (SSE-S3)</a>
        /// in the <i>Amazon Simple Storage Service Console Developer Guide</i>.
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
        /// If you use the <c>KMS</c> encryption type, specify the KMS key to use for encryption.
        /// The full ARN of the KMS key must be specified. The key must exist in the same Region
        /// as the repository. If no key is specified, the default Amazon Web Services managed
        /// KMS key for Amazon ECR will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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