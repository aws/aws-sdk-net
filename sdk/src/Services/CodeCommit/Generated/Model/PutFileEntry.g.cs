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
    /// Information about a file added or updated as part of a commit.
    /// </summary>
    public partial class PutFileEntry
    {
        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// The content of the file, if a source file is not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6291456)]
        public MemoryStream FileContent { get; set; }

        /// <summary>
        /// Checks to see if the FileContent property is set.
        /// </summary>
        internal bool IsSetFileContent() => this.FileContent != null;

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

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The full path to the file in the repository, including the name of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property SourceFile. 
        /// <para>
        /// The name and full path of the file that contains the changes you want to make as part
        /// of the commit, if you are not providing the file content directly.
        /// </para>
        /// </summary>
        public SourceFileSpecifier SourceFile { get; set; }

        /// <summary>
        /// Checks to see if the SourceFile property is set.
        /// </summary>
        internal bool IsSetSourceFile() => this.SourceFile != null;
    }
}
