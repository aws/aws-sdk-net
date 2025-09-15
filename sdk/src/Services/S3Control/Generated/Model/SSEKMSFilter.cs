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
    /// A filter that returns objects that are encrypted by server-side encryption with Amazon
    /// Web Services KMS (SSE-KMS).
    /// </summary>
    public partial class SSEKMSFilter
    {
        private bool? _bucketKeyEnabled;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Amazon Web Services Key Management Service (Amazon Web
        /// Services KMS) keys (SSE-KMS). If specified, will filter SSE-KMS encrypted objects
        /// by S3 Bucket Key status. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-key.html">Reducing
        /// the cost of SSE-KMS with Amazon S3 Bucket Keys</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key to use for the filter
        /// to return objects that are encrypted by the specified key. For best performance, we
        /// recommend using the <c>KMSKeyArn</c> filter in conjunction with other object metadata
        /// filters, like <c>MatchAnyPrefix</c>, <c>CreatedAfter</c>, or <c>MatchAnyStorageClass</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide the full KMS Key ARN. You can't use an alias name or alias ARN. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">
        /// KMS keys</a> in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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