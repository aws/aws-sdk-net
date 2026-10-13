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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// An image that is picked from the Face Liveness video and returned for audit trail
    /// purposes, returned as Base64-encoded bytes.
    /// </summary>
    public partial class AuditImage
    {
        /// <summary>
        /// Gets and sets the property BoundingBox.
        /// </summary>
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The Base64-encoded bytes representing an image selected from the Face Liveness video
        /// and returned for audit purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 204800)]
        public MemoryStream Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes != null;

        /// <summary>
        /// Gets and sets the property S3Object.
        /// </summary>
        public S3Object S3Object { get; set; }

        /// <summary>
        /// Checks to see if the S3Object property is set.
        /// </summary>
        internal bool IsSetS3Object() => this.S3Object != null;
    }
}
