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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the default server-side encryption configuration.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets</b> - If you're specifying a customer managed KMS key,
    /// we recommend using a fully qualified KMS key ARN. If you use a KMS key alias instead,
    /// then KMS resolves the key within the requester’s account. This behavior can result
    /// in data that's encrypted with a KMS key that belongs to the requester, and not the
    /// bucket owner.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - When you specify an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">KMS
    /// customer managed key</a> for encryption in your directory bucket, only use the key
    /// ID or key ARN. The key alias format of the KMS key isn't supported.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ServerSideEncryptionRule
    {
        private bool? _bucketKeyEnabled;
        private ServerSideEncryptionByDefault _serverSideEncryptionByDefault;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key with server-side encryption
        /// using KMS (SSE-KMS) for new objects in the bucket. Existing objects are not affected.
        /// Setting the <c>BucketKeyEnabled</c> element to <c>true</c> causes Amazon S3 to use
        /// an S3 Bucket Key. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>General purpose buckets</b> - By default, S3 Bucket Key is not enabled. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon
        /// S3 Bucket Keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - S3 Bucket Keys are always enabled for <c>GET</c> and <c>PUT</c>
        /// operations in a directory bucket and can’t be disabled. S3 Bucket Keys aren't supported,
        /// when you copy SSE-KMS encrypted objects from general purpose buckets to directory
        /// buckets, from directory buckets to general purpose buckets, or between directory buckets,
        /// through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>,
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>,
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the
        /// Copy operation in Batch Operations</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/create-import-job">the
        /// import jobs</a>. In this case, Amazon S3 makes a call to KMS every time a copy request
        /// is made for a KMS-encrypted object.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionByDefault. 
        /// <para>
        /// Specifies the default server-side encryption to apply to new objects in the bucket.
        /// If a PUT Object request doesn't specify any server-side encryption, this default encryption
        /// will be applied.
        /// </para>
        /// </summary>
        public ServerSideEncryptionByDefault ServerSideEncryptionByDefault
        {
            get { return this._serverSideEncryptionByDefault; }
            set { this._serverSideEncryptionByDefault = value; }
        }

        // Check to see if ServerSideEncryptionByDefault property is set
        internal bool IsSetServerSideEncryptionByDefault()
        {
            return this._serverSideEncryptionByDefault != null;
        }

    }
}