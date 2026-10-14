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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a specific Git blob object.
    /// </summary>
    public partial class BlobMetadata
    {
        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The full ID of the blob.
        /// </para>
        /// </summary>
        public string BlobId { get; set; }

        /// <summary>
        /// Checks to see if the BlobId property is set.
        /// </summary>
        internal bool IsSetBlobId() => this.BlobId != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The file mode permissions of the blob. File mode permission codes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>100644</c> indicates read/write
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>100755</c> indicates read/write/execute
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>160000</c> indicates a submodule
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>120000</c> indicates a symlink
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the blob and associated file name, if any.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;
    }
}
