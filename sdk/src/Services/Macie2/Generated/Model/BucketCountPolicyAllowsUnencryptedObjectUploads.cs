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
    /// Provides information about the number of S3 buckets whose bucket policies do or don't
    /// require server-side encryption of objects when objects are uploaded to the buckets.
    /// </summary>
    public partial class BucketCountPolicyAllowsUnencryptedObjectUploads
    {
        private long? _allowsUnencryptedObjectUploads;
        private long? _deniesUnencryptedObjectUploads;
        private long? _unknown;

        /// <summary>
        /// Gets and sets the property AllowsUnencryptedObjectUploads. 
        /// <para>
        /// The total number of buckets that don't have a bucket policy or have a bucket policy
        /// that doesn't require server-side encryption of new objects. If a bucket policy exists,
        /// the policy doesn't require PutObject requests to include a valid server-side encryption
        /// header: the x-amz-server-side-encryption header with a value of AES256 or aws:kms,
        /// or the x-amz-server-side-encryption-customer-algorithm header with a value of AES256.
        /// </para>
        /// </summary>
        public long AllowsUnencryptedObjectUploads
        {
            get { return this._allowsUnencryptedObjectUploads.GetValueOrDefault(); }
            set { this._allowsUnencryptedObjectUploads = value; }
        }

        // Check to see if AllowsUnencryptedObjectUploads property is set
        internal bool IsSetAllowsUnencryptedObjectUploads()
        {
            return this._allowsUnencryptedObjectUploads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeniesUnencryptedObjectUploads. 
        /// <para>
        /// The total number of buckets whose bucket policies require server-side encryption of
        /// new objects. PutObject requests for these buckets must include a valid server-side
        /// encryption header: the x-amz-server-side-encryption header with a value of AES256
        /// or aws:kms, or the x-amz-server-side-encryption-customer-algorithm header with a value
        /// of AES256.
        /// </para>
        /// </summary>
        public long DeniesUnencryptedObjectUploads
        {
            get { return this._deniesUnencryptedObjectUploads.GetValueOrDefault(); }
            set { this._deniesUnencryptedObjectUploads = value; }
        }

        // Check to see if DeniesUnencryptedObjectUploads property is set
        internal bool IsSetDeniesUnencryptedObjectUploads()
        {
            return this._deniesUnencryptedObjectUploads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The total number of buckets that Amazon Macie wasn't able to evaluate server-side
        /// encryption requirements for. Macie can't determine whether the bucket policies for
        /// these buckets require server-side encryption of new objects.
        /// </para>
        /// </summary>
        public long Unknown
        {
            get { return this._unknown.GetValueOrDefault(); }
            set { this._unknown = value; }
        }

        // Check to see if Unknown property is set
        internal bool IsSetUnknown()
        {
            return this._unknown.HasValue; 
        }

    }
}