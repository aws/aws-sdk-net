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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFileSystem operation.
    /// Deletes a file system, permanently severing access to its contents. Upon return, the
    /// file system no longer exists and you can't access any contents of the deleted file
    /// system.
    /// 
    ///  
    /// <para>
    ///  You can't delete a file system that is in use. That is, if the file system has any
    /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
    /// and <a>DeleteMountTarget</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>DeleteFileSystem</code> call returns while the file system state is still
    /// <code>deleting</code>. You can check the file system deletion status by calling the
    /// <a>DescribeFileSystems</a> operation, which returns a list of file systems in your
    /// account. If you pass file system ID or creation token for the deleted file system,
    /// the <a>DescribeFileSystems</a> returns a <code>404 FileSystemNotFound</code> error.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystem</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteFileSystemRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteFileSystemRequest() { }

        /// <summary>
        /// Instantiates DeleteFileSystemRequest with the parameterized properties
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system you want to delete.</param>
        public DeleteFileSystemRequest(string fileSystemId)
        {
            _fileSystemId = fileSystemId;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system you want to delete.
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

    }
}