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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes the default server-side encryption to apply to new objects in the bucket.
    /// If a PUT Object request doesn't specify any server-side encryption, this default encryption
    /// will be applied. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTencryption.html">PUT
    /// Bucket encryption</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public class ServerSideEncryptionByDefault
    {
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod serverSideEncryptionAlgorithm;

        /// <summary>
        /// KMS master key ID to use for the default encryption. 
        /// This parameter is allowed if SSEAlgorithm is aws:kms.
        /// <para>
        /// Amazon Web Services Key Management Service (KMS) customer Amazon Web Services KMS
        /// key ID to use for the default encryption. This parameter is allowed if and only if
        /// <code>SSEAlgorithm</code> is set to <code>aws:kms</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the key ID or the Amazon Resource Name (ARN) of the KMS key. However,
        /// if you are using encryption with cross-account operations, you must use a fully qualified
        /// KMS key ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html#bucket-encryption-update-bucket-policy">Using
        /// encryption for cross-account operations</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>For example:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Amazon S3 only supports symmetric encryption KMS keys. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// keys in Amazon Web Services KMS</a> in the <i>Amazon Web Services Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKeyManagementServiceKeyId property is set
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return this.serverSideEncryptionKeyManagementServiceKeyId != null;
        }
        
        /// <summary>
        /// Server-side encryption algorithm to use for the default encryption.
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionAlgorithm
        {
            get { return this.serverSideEncryptionAlgorithm; }
            set { this.serverSideEncryptionAlgorithm = value; }
        }

        // Check to see if ServerSideEncryptionAlgorithm property is set
        internal bool IsSetServerSideEncryptionAlgorithm()
        {
            return this.serverSideEncryptionAlgorithm != null;
        }

    }
}