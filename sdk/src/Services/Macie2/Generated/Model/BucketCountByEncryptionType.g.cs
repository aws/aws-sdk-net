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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the number of S3 buckets whose settings do or don't specify
    /// default server-side encryption behavior for objects that are added to the buckets.
    /// For detailed information about these settings, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-encryption.html">Setting
    /// default server-side encryption behavior for Amazon S3 buckets</a> in the <i>Amazon
    /// Simple Storage Service User Guide</i>.
    /// </summary>
    public partial class BucketCountByEncryptionType
    {
        /// <summary>
        /// Gets and sets the property KmsManaged. 
        /// <para>
        /// The total number of buckets whose default encryption settings are configured to encrypt
        /// new objects with an KMS key, either an Amazon Web Services managed key or a customer
        /// managed key. By default, these buckets encrypt new objects automatically using DSSE-KMS
        /// or SSE-KMS encryption.
        /// </para>
        /// </summary>
        public long? KmsManaged { get; set; }

        /// <summary>
        /// Checks to see if the KmsManaged property is set.
        /// </summary>
        internal bool IsSetKmsManaged() => this.KmsManaged.HasValue;

        /// <summary>
        /// Gets and sets the property S3Managed. 
        /// <para>
        /// The total number of buckets whose default encryption settings are configured to encrypt
        /// new objects with an Amazon S3 managed key. By default, these buckets encrypt new objects
        /// automatically using SSE-S3 encryption.
        /// </para>
        /// </summary>
        public long? S3Managed { get; set; }

        /// <summary>
        /// Checks to see if the S3Managed property is set.
        /// </summary>
        internal bool IsSetS3Managed() => this.S3Managed.HasValue;

        /// <summary>
        /// Gets and sets the property Unencrypted. 
        /// <para>
        /// The total number of buckets that don't specify default server-side encryption behavior
        /// for new objects. Default encryption settings aren't configured for these buckets.
        /// </para>
        /// </summary>
        public long? Unencrypted { get; set; }

        /// <summary>
        /// Checks to see if the Unencrypted property is set.
        /// </summary>
        internal bool IsSetUnencrypted() => this.Unencrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The total number of buckets that Amazon Macie doesn't have current encryption metadata
        /// for. For example, the buckets' permissions settings or a quota prevented Macie from
        /// retrieving the default encryption settings for the buckets.
        /// </para>
        /// </summary>
        public long? Unknown { get; set; }

        /// <summary>
        /// Checks to see if the Unknown property is set.
        /// </summary>
        internal bool IsSetUnknown() => this.Unknown.HasValue;
    }
}
