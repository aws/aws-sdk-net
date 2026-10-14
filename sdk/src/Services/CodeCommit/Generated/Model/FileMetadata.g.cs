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
    /// A file to be added, updated, or deleted as part of a commit.
    /// </summary>
    public partial class FileMetadata
    {
        /// <summary>
        /// Gets and sets the property AbsolutePath. 
        /// <para>
        /// The full path to the file to be added or updated, including the name of the file.
        /// </para>
        /// </summary>
        public string AbsolutePath { get; set; }

        /// <summary>
        /// Checks to see if the AbsolutePath property is set.
        /// </summary>
        internal bool IsSetAbsolutePath() => this.AbsolutePath != null;

        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The blob ID that contains the file information.
        /// </para>
        /// </summary>
        public string BlobId { get; set; }

        /// <summary>
        /// Checks to see if the BlobId property is set.
        /// </summary>
        internal bool IsSetBlobId() => this.BlobId != null;

        /// <summary>
        /// Gets and sets the property FileMode. 
        /// <para>
        /// The extrapolated file mode permissions for the file. Valid values include EXECUTABLE
        /// and NORMAL.
        /// </para>
        /// </summary>
        public FileModeTypeEnum FileMode { get; set; }

        /// <summary>
        /// Checks to see if the FileMode property is set.
        /// </summary>
        internal bool IsSetFileMode() => this.FileMode != null;
    }
}
