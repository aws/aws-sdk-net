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
    /// Directs the specified job to invoke the ComputeObjectChecksum operation on every object
    /// listed in the job's manifest.
    /// </summary>
    public partial class S3ComputeObjectChecksumOperation
    {
        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm that you want Amazon S3 to use to create the checksum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the Amazon S3 User Guide.
        /// </para>
        /// </summary>
        public ComputeObjectChecksumAlgorithm ChecksumAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumAlgorithm property is set.
        /// </summary>
        internal bool IsSetChecksumAlgorithm() => this.ChecksumAlgorithm != null;

        /// <summary>
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// Indicates the checksum type that you want Amazon S3 to use to calculate the object's
        /// checksum value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the Amazon S3 User Guide.
        /// </para>
        /// </summary>
        public ComputeObjectChecksumType ChecksumType { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumType property is set.
        /// </summary>
        internal bool IsSetChecksumType() => this.ChecksumType != null;
    }
}
