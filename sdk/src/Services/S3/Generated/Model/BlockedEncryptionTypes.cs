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
    /// A bucket-level setting for Amazon S3 general purpose buckets used to prevent the upload
    /// of new objects encrypted with the specified server-side encryption type. For example,
    /// blocking an encryption type will block <c>PutObject</c>, <c>CopyObject</c>, <c>PostObject</c>,
    /// multipart upload, and replication requests to the bucket for objects with the specified
    /// encryption type. However, you can continue to read and list any pre-existing objects
    /// already encrypted with the specified encryption type. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/userguide/block-encryption-type.html">Blocking
    /// an encryption type for a general purpose bucket</a>. 
    /// 
    ///  
    /// <para>
    /// This data type is used with the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketEncryption.html">PutBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketEncryption.html">GetBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketEncryption.html">DeleteBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> </ul> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:PutEncryptionConfiguration</c> permission to block or unblock
    /// an encryption type for a bucket. 
    /// </para>
    ///  
    /// <para>
    /// You must have the <c>s3:GetEncryptionConfiguration</c> permission to view a bucket's
    /// encryption type. 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class BlockedEncryptionTypes
    {
        private List<string> _encryptionType = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The object encryption type that you want to block or unblock for an Amazon S3 general
        /// purpose bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter only supports blocking or unblocking server side encryption
        /// with customer-provided keys (SSE-C). For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerSideEncryptionCustomerKeys.html">Using
        /// server-side encryption with customer-provided keys (SSE-C)</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null && (this._encryptionType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}