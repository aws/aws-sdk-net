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
    /// The encryption configuration to use when storing the generated manifest.
    /// </summary>
    public partial class GeneratedManifestEncryption
    {
        /// <summary>
        /// Gets and sets the property SSEKMS. 
        /// <para>
        /// Configuration details on how SSE-KMS is used to encrypt generated manifest objects.
        /// </para>
        /// </summary>
        public SSEKMSEncryption SSEKMS { get; set; }

        /// <summary>
        /// Checks to see if the SSEKMS property is set.
        /// </summary>
        internal bool IsSetSSEKMS() => this.SSEKMS != null;

        /// <summary>
        /// Gets and sets the property SSES3. 
        /// <para>
        /// Specifies the use of SSE-S3 to encrypt generated manifest objects.
        /// </para>
        /// </summary>
        public SSES3Encryption SSES3 { get; set; }

        /// <summary>
        /// Checks to see if the SSES3 property is set.
        /// </summary>
        internal bool IsSetSSES3() => this.SSES3 != null;
    }
}
