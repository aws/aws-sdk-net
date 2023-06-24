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
    /// Provides information about the number of objects that are in an S3 bucket and use
    /// certain types of server-side encryption, use client-side encryption, or aren't encrypted.
    /// </summary>
    public partial class ObjectCountByEncryptionType
    {
        private long? _customerManaged;
        private long? _kmsManaged;
        private long? _s3Managed;
        private long? _unencrypted;
        private long? _unknown;

        /// <summary>
        /// Gets and sets the property CustomerManaged. 
        /// <para>
        /// The total number of objects that are encrypted with a customer-provided key. The objects
        /// use customer-provided server-side encryption (SSE-C).
        /// </para>
        /// </summary>
        public long CustomerManaged
        {
            get { return this._customerManaged.GetValueOrDefault(); }
            set { this._customerManaged = value; }
        }

        // Check to see if CustomerManaged property is set
        internal bool IsSetCustomerManaged()
        {
            return this._customerManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsManaged. 
        /// <para>
        /// The total number of objects that are encrypted with an KMS key, either an Amazon Web
        /// Services managed key or a customer managed key. The objects use KMS encryption (SSE-KMS).
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
        /// The total number of objects that are encrypted with an Amazon S3 managed key. The
        /// objects use Amazon S3 managed encryption (SSE-S3).
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
        /// The total number of objects that use client-side encryption or aren't encrypted.
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

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The total number of objects that Amazon Macie doesn't have current encryption metadata
        /// for. Macie can't provide current data about the encryption settings for these objects.
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