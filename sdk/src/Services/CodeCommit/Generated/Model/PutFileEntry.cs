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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
        private MemoryStream _fileContent;
        private FileModeTypeEnum _fileMode;
        private string _filePath;
        private SourceFileSpecifier _sourceFile;

        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// The content of the file, if a source file is not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Max=6291456)]
        public MemoryStream FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }

        // Check to see if FileContent property is set
        internal bool IsSetFileContent()
        {
            return this._fileContent != null;
        }

        /// <summary>
        /// Gets and sets the property FileMode. 
        /// <para>
        /// The extrapolated file mode permissions for the file. Valid values include EXECUTABLE
        /// and NORMAL.
        /// </para>
        /// </summary>
        public FileModeTypeEnum FileMode
        {
            get { return this._fileMode; }
            set { this._fileMode = value; }
        }

        // Check to see if FileMode property is set
        internal bool IsSetFileMode()
        {
            return this._fileMode != null;
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The full path to the file in the repository, including the name of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFile. 
        /// <para>
        /// The name and full path of the file that contains the changes you want to make as part
        /// of the commit, if you are not providing the file content directly.
        /// </para>
        /// </summary>
        public SourceFileSpecifier SourceFile
        {
            get { return this._sourceFile; }
            set { this._sourceFile = value; }
        }

        // Check to see if SourceFile property is set
        internal bool IsSetSourceFile()
        {
            return this._sourceFile != null;
        }

    }
}