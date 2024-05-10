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
    /// Returns information about a file in a repository.
    /// </summary>
    public partial class File
    {
        private string _absolutePath;
        private string _blobId;
        private FileModeTypeEnum _fileMode;
        private string _relativePath;

        /// <summary>
        /// Gets and sets the property AbsolutePath. 
        /// <para>
        /// The fully qualified path to the file in the repository.
        /// </para>
        /// </summary>
        public string AbsolutePath
        {
            get { return this._absolutePath; }
            set { this._absolutePath = value; }
        }

        // Check to see if AbsolutePath property is set
        internal bool IsSetAbsolutePath()
        {
            return this._absolutePath != null;
        }

        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The blob ID that contains the file information.
        /// </para>
        /// </summary>
        public string BlobId
        {
            get { return this._blobId; }
            set { this._blobId = value; }
        }

        // Check to see if BlobId property is set
        internal bool IsSetBlobId()
        {
            return this._blobId != null;
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
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The relative path of the file from the folder where the query originated.
        /// </para>
        /// </summary>
        public string RelativePath
        {
            get { return this._relativePath; }
            set { this._relativePath = value; }
        }

        // Check to see if RelativePath property is set
        internal bool IsSetRelativePath()
        {
            return this._relativePath != null;
        }

    }
}