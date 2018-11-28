/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The response object for the <code>DeleteFileSystem</code> operation.
    /// </summary>
    public partial class DeleteFileSystemResponse : AmazonWebServiceResponse
    {
        private string _fileSystemId;
        private FileSystemLifecycle _lifecycle;
        private DeleteFileSystemWindowsResponse _windowsResponse;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system being deleted.
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The file system lifecycle for the deletion request. Should be <code>DELETING</code>.
        /// </para>
        /// </summary>
        public FileSystemLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property WindowsResponse.
        /// </summary>
        public DeleteFileSystemWindowsResponse WindowsResponse
        {
            get { return this._windowsResponse; }
            set { this._windowsResponse = value; }
        }

        // Check to see if WindowsResponse property is set
        internal bool IsSetWindowsResponse()
        {
            return this._windowsResponse != null;
        }

    }
}