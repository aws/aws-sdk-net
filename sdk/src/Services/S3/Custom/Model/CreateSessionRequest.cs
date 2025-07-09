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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSession operation.
    /// </summary>
    public partial class CreateSessionRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private SessionMode _sessionMode;
        private ServerSideEncryptionMethod _serverSideEncryption;
        private string _serverSideEncryptionKeyManagementServiceKeyId;
        private string _serverSideEncryptionKeyManagementServiceEncryptionContext;
        private bool? _bucketKeyEnabled;

        /// <summary>
        /// The name of the bucket that you create a session for.
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// <para>
        /// Specifies the mode of the session that will be created, either <c>ReadWrite</c> or <c>ReadOnly</c>. By default, a <c>ReadWrite</c> session is created. 
        /// 
        /// A <c>ReadWrite</c> session is capable of executing all the Zonal endpoint API operations on a directory bucket. 
        /// A <c>ReadOnly</c> session is constrained to execute the following Zonal endpoint API operations: <c>GetObject</c>, <c>HeadObject</c>, <c>ListObjectsV2</c>, <c>GetObjectAttributes</c>, <c>ListParts</c>, and <c>ListMultipartUploads</c>.
        /// </para>
        /// </summary>
        public SessionMode SessionMode
        {
            get { return this._sessionMode; }
            set { this._sessionMode = value; }
        }

        // Check to see if SessionMode property is set
        internal bool IsSetSessionMode()
        {
            return this._sessionMode != null;
        }

        /// <summary>
        /// <para>The server-side encryption algorithm to use when you store objects in the directory bucket.</para> 
        /// <para>
        /// For directory buckets, there are only two supported options for server-side encryption: server-side encryption with Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>). 
        /// By default, Amazon S3 encrypts data with SSE-S3. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// <para>
        /// <b>S3 access points for Amazon FSx </b> - When accessing data stored in Amazon FSx
        /// file systems using S3 access points, the only valid server side encryption option
        /// is <c>aws:fsx</c>. All Amazon FSx file systems have encryption configured by default
        /// and are encrypted at rest. Data is automatically encrypted before being written to
        /// the file system, and automatically decrypted as it is read. These processes are handled
        /// transparently by Amazon FSx.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryption
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this._serverSideEncryption != null && this._serverSideEncryption != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// <para>
        /// If you specify <c>x-amz-server-side-encryption</c> with <c>aws:kms</c>, you must specify the <c>x-amz-server-side-encryption-aws-kms-key-id</c> header with the ID (Key ID or Key ARN) of the KMS symmetric encryption customer managed key to use. 
        /// Otherwise, you get an HTTP <c>400 Bad Request</c> error. Only use the key ID or key ARN. The key alias format of the KMS key isn't supported. 
        /// Also, if the KMS key doesn't exist in the same account that't issuing the command, you must use the full Key ARN not the Key ID. 
        /// </para>
        /// <para>
        /// Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> per directory bucket for the lifetime of the bucket. <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a> (<c>aws/s3</c>) isn't supported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SSEKMSKeyId
        {
            get { return this._serverSideEncryptionKeyManagementServiceKeyId; }
            set { this._serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if SSEKMSKeyId property is set.
        /// </summary>
        internal bool IsSetSSEKMSKeyId()
        {
            return !string.IsNullOrEmpty(this._serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context as an additional encryption context to use for object encryption. 
        /// The value of this header is a Base64 encoded string of a UTF-8 encoded JSON, which contains the encryption context as key-value pairs. 
        /// This value is stored as object metadata and automatically gets passed on to Amazon Web Services KMS for future <c>GetObject</c> operations on this object.
        /// </para>
        /// <para>
        /// <b>General purpose buckets</b> - This value must be explicitly added during <c>CopyObject</c> operations if you want an additional encryption context for your object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html#encryption-context">Encryption context</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// <para>
        /// <b>Directory buckets</b> - You can optionally provide an explicit encryption context value. The value must match the default encryption context - the bucket Amazon Resource Name (ARN). 
        /// An additional encryption context value is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SSEKMSEncryptionContext
        {
            get { return this._serverSideEncryptionKeyManagementServiceEncryptionContext; }
            set { this._serverSideEncryptionKeyManagementServiceEncryptionContext = value; }
        }

        /// <summary>
        /// Checks if SSEKMSEncryptionContext property is set.
        /// </summary>
        internal bool IsSetSSEKMSEncryptionContext()
        {
            return !string.IsNullOrEmpty(this._serverSideEncryptionKeyManagementServiceEncryptionContext);
        }

        /// <summary>
        /// <para>Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with server-side encryption using KMS keys (SSE-KMS).</para>
        /// <para>
        /// S3 Bucket Keys are always enabled for <c>GET</c> and <c>PUT</c> operations in a directory bucket and can't be disabled.
        /// S3 Bucket Keys aren't supported, when you copy SSE-KMS encrypted objects from general purpose buckets to directory buckets, from directory buckets to general purpose buckets, or between directory buckets, 
        /// through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>, <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>, 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the Copy operation in Batch Operations</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/create-import-job">the import jobs</a>. 
        /// In this case, Amazon S3 makes a call to KMS every time a copy request is made for a KMS-encrypted object.
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        /// <summary>
        /// Checks if BucketKeyEnabled property is set.
        /// </summary>
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue;
        }
    }
}