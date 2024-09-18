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
    /// <para>
    /// Describes the default server-side encryption to apply to new objects in the bucket. 
    /// If a PUT Object request doesn't specify any server-side encryption, this default encryption will be applied. 
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTencryption.html">PutBucketEncryption</a>.
    /// </para> 
    /// 
    /// <note>
    /// <ul>
    /// 
    /// <li>
    /// <para>
    /// <b>General purpose buckets</b> - If you don't specify a customer managed key at configuration, Amazon S3 automatically creates an Amazon Web Services KMS key (<c>aws/s3</c>) 
    /// in your Amazon Web Services account the first time that you add an object encrypted with SSE-KMS to a bucket. 
    /// By default, Amazon S3 uses this KMS key for SSE-KMS.
    /// </para>
    /// </li>
    /// 
    /// <li>
    /// <para>
    /// <b>Directory buckets</b> - Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> 
    /// per directory bucket for the lifetime of the bucket. 
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a> (<c>aws/s3</c>) isn't supported.
    /// </para>
    /// </li>
    /// 
    /// <li>
    /// <para>
    /// <b>Directory buckets</b> - For directory buckets, there are only two supported options for server-side encryption: SSE-S3 and SSE-KMS.
    /// </para>
    /// </li>
    /// 
    /// </ul> 
    /// </note>
    /// </summary>
    public class ServerSideEncryptionByDefault
    {
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod serverSideEncryptionAlgorithm;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceKeyId. 
        /// <para>
        /// Amazon Web Services Key Management Service (KMS) customer managed key ID to use for the default encryption. 
        /// </para>
        /// 
        /// <note>
        /// <ul>
        /// <li>
        /// <para><b>General purpose buckets</b> - This parameter is allowed if and only if <c>SSEAlgorithm</c> is set to <c>aws:kms</c> or <c>aws:kms:dsse</c>.</para>
        /// </li>
        /// 
        /// <li>
        /// <para><b>Directory buckets</b> - This parameter is allowed if and only if <c>SSEAlgorithm</c> is set to <c>aws:kms</c>.</para>
        /// </li>
        /// </ul>
        /// </note>
        /// 
        /// <para>You can specify the key ID, key alias, or the Amazon Resource Name (ARN) of the KMS key.</para> 
        /// <ul>
        /// <li>
        /// <para>Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c></para>
        /// </li>
        /// <li>
        /// <para>Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c></para>
        /// </li>
        /// 
        /// <li><para>Key Alias: <c>alias/alias-name</c></para></li>
        /// </ul> 
        /// 
        /// <para>
        /// If you are using encryption with cross-account or Amazon Web Services service operations, you must use a fully qualified KMS key ARN. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html#bucket-encryption-update-bucket-policy">Using encryption 
        /// for cross-account operations</a>.
        /// </para> 
        /// 
        /// <note>
        /// <ul>
        /// <li>
        /// <para> 
        /// <b>General purpose buckets</b> - If you're specifying a customer managed KMS key, we recommend using a fully qualified KMS key ARN. 
        /// If you use a KMS key alias instead, then KMS resolves the key within the requester’s account. This behavior can result in data that's encrypted with a KMS key that 
        /// belongs to the requester, and not the bucket owner. 
        /// Also, if you use a key ID, you can run into a LogDestination undeliverable error when creating a VPC flow log. 
        /// </para> 
        /// </li>
        /// 
        /// <li>
        /// <para>
        /// <b>Directory buckets</b> - When you specify an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">KMS customer managed key</a> 
        /// for encryption in your directory bucket, only use the key ID or key ARN. 
        /// The key alias format of the KMS key isn't supported.
        /// </para>
        /// </li>
        /// </ul>
        /// </note>
        /// 
        /// <important>
        /// <para>
        /// Amazon S3 only supports symmetric encryption KMS keys. 
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric keys in Amazon Web Services KMS</a> 
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </para> 
        /// </important>
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
        /// <para>
        /// Server-side encryption algorithm to use for the default encryption.
        /// </para> 
        /// 
        /// <note>
        /// <para>
        /// For directory buckets, there are only two supported values for server-side encryption: <c>AES256</c> and <c>aws:kms</c>.
        /// </para> 
        /// </note>
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