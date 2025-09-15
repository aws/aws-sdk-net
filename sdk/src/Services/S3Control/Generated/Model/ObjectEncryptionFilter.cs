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
    /// An optional filter for the <c>S3JobManifestGenerator</c> that identifies the subset
    /// of objects by encryption type. This filter is used to create an object list for S3
    /// Batch Operations jobs. If provided, this filter will generate an object list that
    /// only includes objects with the specified encryption type.
    /// </summary>
    public partial class ObjectEncryptionFilter
    {
        private DSSEKMSFilter _dssekms;
        private NotSSEFilter _notsse;
        private SSECFilter _ssec;
        private SSEKMSFilter _ssekms;
        private SSES3Filter _sses3;

        /// <summary>
        /// Gets and sets the property DSSEKMS. 
        /// <para>
        /// Filters for objects that are encrypted by dual-layer server-side encryption with Amazon
        /// Web Services Key Management Service (KMS) keys (DSSE-KMS).
        /// </para>
        /// </summary>
        public DSSEKMSFilter DSSEKMS
        {
            get { return this._dssekms; }
            set { this._dssekms = value; }
        }

        // Check to see if DSSEKMS property is set
        internal bool IsSetDSSEKMS()
        {
            return this._dssekms != null;
        }

        /// <summary>
        /// Gets and sets the property NOTSSE. 
        /// <para>
        /// Filters for objects that are not encrypted by server-side encryption. 
        /// </para>
        /// </summary>
        public NotSSEFilter NOTSSE
        {
            get { return this._notsse; }
            set { this._notsse = value; }
        }

        // Check to see if NOTSSE property is set
        internal bool IsSetNOTSSE()
        {
            return this._notsse != null;
        }

        /// <summary>
        /// Gets and sets the property SSEC. 
        /// <para>
        /// Filters for objects that are encrypted by server-side encryption with customer-provided
        /// keys (SSE-C).
        /// </para>
        /// </summary>
        public SSECFilter SSEC
        {
            get { return this._ssec; }
            set { this._ssec = value; }
        }

        // Check to see if SSEC property is set
        internal bool IsSetSSEC()
        {
            return this._ssec != null;
        }

        /// <summary>
        /// Gets and sets the property SSEKMS. 
        /// <para>
        /// Filters for objects that are encrypted by server-side encryption with Amazon Web Services
        /// Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public SSEKMSFilter SSEKMS
        {
            get { return this._ssekms; }
            set { this._ssekms = value; }
        }

        // Check to see if SSEKMS property is set
        internal bool IsSetSSEKMS()
        {
            return this._ssekms != null;
        }

        /// <summary>
        /// Gets and sets the property SSES3. 
        /// <para>
        /// Filters for objects that are encrypted by server-side encryption with Amazon S3 managed
        /// keys (SSE-S3).
        /// </para>
        /// </summary>
        public SSES3Filter SSES3
        {
            get { return this._sses3; }
            set { this._sses3 = value; }
        }

        // Check to see if SSES3 property is set
        internal bool IsSetSSES3()
        {
            return this._sses3 != null;
        }

    }
}