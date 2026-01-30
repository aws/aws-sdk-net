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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// If <c>SSEKMS</c> is specified for <c>UpdateObjectEncryption</c>, this data type specifies
    /// the Amazon Web Services KMS key Amazon Resource Name (ARN) to use and whether to use
    /// an S3 Bucket Key for server-side encryption using Key Management Service (KMS) keys
    /// (SSE-KMS).
    /// </summary>
    public partial class S3UpdateObjectEncryptionSSEKMS
    {
        private bool? _bucketKeyEnabled;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Key Management Service (KMS) keys (SSE-KMS). If this
        /// value isn't specified, it defaults to <c>false</c>. Setting this value to <c>true</c>
        /// causes Amazon S3 to use an S3 Bucket Key for update object encryption with SSE-KMS.
        /// </para>
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
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// Specifies the Amazon Web Services KMS key Amazon Resource Name (ARN) to use for the
        /// updated server-side encryption type. Required if <c>UpdateObjectEncryption</c> specifies
        /// <c>SSEKMS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string KMSKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KMSKeyArn property is set
        internal bool IsSetKMSKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}