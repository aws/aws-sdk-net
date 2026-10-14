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
    /// Returns information about a symbolic link in a repository folder.
    /// </summary>
    public partial class SymbolicLink
    {
        /// <summary>
        /// Gets and sets the property AbsolutePath. 
        /// <para>
        /// The fully qualified path to the folder that contains the symbolic link.
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
        /// The blob ID that contains the information about the symbolic link.
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
        /// The file mode permissions of the blob that cotains information about the symbolic
        /// link.
        /// </para>
        /// </summary>
        public FileModeTypeEnum FileMode { get; set; }

        /// <summary>
        /// Checks to see if the FileMode property is set.
        /// </summary>
        internal bool IsSetFileMode() => this.FileMode != null;

        /// <summary>
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The relative path of the symbolic link from the folder where the query originated.
        /// </para>
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// Checks to see if the RelativePath property is set.
        /// </summary>
        internal bool IsSetRelativePath() => this.RelativePath != null;
    }
}
