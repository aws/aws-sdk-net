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
    /// Provides information about the number of objects that are in an S3 bucket and use
    /// certain types of server-side encryption, use client-side encryption, or aren't encrypted.
    /// </summary>
    public partial class ObjectCountByEncryptionType
    {
        /// <summary>
        /// Gets and sets the property CustomerManaged. 
        /// <para>
        /// The total number of objects that are encrypted with customer-provided keys. The objects
        /// use server-side encryption with customer-provided keys (SSE-C).
        /// </para>
        /// </summary>
        public long? CustomerManaged { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManaged property is set.
        /// </summary>
        internal bool IsSetCustomerManaged() => this.CustomerManaged.HasValue;

        /// <summary>
        /// Gets and sets the property KmsManaged. 
        /// <para>
        /// The total number of objects that are encrypted with KMS keys, either Amazon Web Services
        /// managed keys or customer managed keys. The objects use dual-layer server-side encryption
        /// or server-side encryption with KMS keys (DSSE-KMS or SSE-KMS).
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
        /// The total number of objects that are encrypted with Amazon S3 managed keys. The objects
        /// use server-side encryption with Amazon S3 managed keys (SSE-S3).
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
        /// The total number of objects that use client-side encryption or aren't encrypted.
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
        /// The total number of objects that Amazon Macie doesn't have current encryption metadata
        /// for. Macie can't provide current data about the encryption settings for these objects.
        /// </para>
        /// </summary>
        public long? Unknown { get; set; }

        /// <summary>
        /// Checks to see if the Unknown property is set.
        /// </summary>
        internal bool IsSetUnknown() => this.Unknown.HasValue;
    }
}
