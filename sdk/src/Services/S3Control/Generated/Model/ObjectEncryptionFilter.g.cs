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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// An optional filter for the S3JobManifestGenerator that identifies the subset of objects
    /// by encryption type.
    /// </summary>
    public partial class ObjectEncryptionFilter
    {
        /// <summary>
        /// Gets and sets the property DSSEKMS. 
        /// <para>
        /// Filters for objects that are encrypted by dual-layer server-side encryption with Amazon
        /// Web Services Key Management Service (KMS) keys (DSSE-KMS).
        /// </para>
        /// </summary>
        public DSSEKMSFilter DSSEKMS { get; set; }

        /// <summary>
        /// Checks to see if the DSSEKMS property is set.
        /// </summary>
        internal bool IsSetDSSEKMS() => this.DSSEKMS != null;

        /// <summary>
        /// Gets and sets the property NOTSSE. 
        /// <para>
        /// Filters for objects that are not encrypted by server-side encryption.
        /// </para>
        /// </summary>
        public NotSSEFilter NOTSSE { get; set; }

        /// <summary>
        /// Checks to see if the NOTSSE property is set.
        /// </summary>
        internal bool IsSetNOTSSE() => this.NOTSSE != null;

        /// <summary>
        /// Gets and sets the property SSEC. 
        /// <para>
        /// Filters for objects that are encrypted by server-side encryption with customer-provided
        /// keys (SSE-C).
        /// </para>
        /// </summary>
        public SSECFilter SSEC { get; set; }

        /// <summary>
        /// Checks to see if the SSEC property is set.
        /// </summary>
        internal bool IsSetSSEC() => this.SSEC != null;

        /// <summary>
        /// Gets and sets the property SSEKMS. 
        /// <para>
        /// Filters for objects that are encrypted by server-side encryption with Amazon Web Services
        /// Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public SSEKMSFilter SSEKMS { get; set; }

        /// <summary>
        /// Checks to see if the SSEKMS property is set.
        /// </summary>
        internal bool IsSetSSEKMS() => this.SSEKMS != null;

        /// <summary>
        /// Gets and sets the property SSES3. 
        /// <para>
        /// Filters for objects that are encrypted by server-side encryption with Amazon S3 managed
        /// keys (SSE-S3).
        /// </para>
        /// </summary>
        public SSES3Filter SSES3 { get; set; }

        /// <summary>
        /// Checks to see if the SSES3 property is set.
        /// </summary>
        internal bool IsSetSSES3() => this.SSES3 != null;
    }
}
