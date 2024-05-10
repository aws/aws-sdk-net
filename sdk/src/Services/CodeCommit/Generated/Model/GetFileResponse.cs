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
    /// This is the response object from the GetFile operation.
    /// </summary>
    public partial class GetFileResponse : AmazonWebServiceResponse
    {
        private string _blobId;
        private string _commitId;
        private MemoryStream _fileContent;
        private FileModeTypeEnum _fileMode;
        private string _filePath;
        private long? _fileSize;

        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The blob ID of the object that represents the file content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full commit ID of the commit that contains the content returned by GetFile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }

        // Check to see if CommitId property is set
        internal bool IsSetCommitId()
        {
            return this._commitId != null;
        }

        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// The base-64 encoded binary data object that represents the content of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=6291456)]
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
        /// The extrapolated file mode permissions of the blob. Valid values include strings such
        /// as EXECUTABLE and not numeric values.
        /// </para>
        ///  <note> 
        /// <para>
        /// The file mode permissions returned by this API are not the standard file mode permission
        /// values, such as 100644, but rather extrapolated values. See the supported return values.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The fully qualified path to the specified file. Returns the name and extension of
        /// the file.
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
        /// Gets and sets the property FileSize. 
        /// <para>
        /// The size of the contents of the file, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? FileSize
        {
            get { return this._fileSize; }
            set { this._fileSize = value; }
        }

        // Check to see if FileSize property is set
        internal bool IsSetFileSize()
        {
            return this._fileSize.HasValue; 
        }

    }
}