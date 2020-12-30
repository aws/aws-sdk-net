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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the number of S3 buckets that use certain types of server-side
    /// encryption or don't encrypt objects by default.
    /// </summary>
    public partial class BucketCountByEncryptionType
    {
        private long? _kmsManaged;
        private long? _s3Managed;
        private long? _unencrypted;

        /// <summary>
        /// Gets and sets the property KmsManaged.  
        /// <para>
        /// The total number of buckets that use an AWS Key Management Service (AWS KMS) customer
        /// master key (CMK) by default to encrypt objects. These buckets use AWS managed AWS
        /// KMS (AWS-KMS) encryption or customer managed AWS KMS (SSE-KMS) encryption.
        /// </para>
        /// </summary>
        public long KmsManaged
        {
            get { return this._kmsManaged.GetValueOrDefault(); }
            set { this._kmsManaged = value; }
        }

        // Check to see if KmsManaged property is set
        internal bool IsSetKmsManaged()
        {
            return this._kmsManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Managed. 
        /// <para>
        /// The total number of buckets that use an Amazon S3 managed key by default to encrypt
        /// objects. These buckets use Amazon S3 managed (SSE-S3) encryption.
        /// </para>
        /// </summary>
        public long S3Managed
        {
            get { return this._s3Managed.GetValueOrDefault(); }
            set { this._s3Managed = value; }
        }

        // Check to see if S3Managed property is set
        internal bool IsSetS3Managed()
        {
            return this._s3Managed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unencrypted. 
        /// <para>
        /// The total number of buckets that don't encrypt objects by default. Default encryption
        /// is disabled for these buckets.
        /// </para>
        /// </summary>
        public long Unencrypted
        {
            get { return this._unencrypted.GetValueOrDefault(); }
            set { this._unencrypted = value; }
        }

        // Check to see if Unencrypted property is set
        internal bool IsSetUnencrypted()
        {
            return this._unencrypted.HasValue; 
        }

    }
}