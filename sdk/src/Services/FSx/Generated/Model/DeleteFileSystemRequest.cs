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
    /// Container for the parameters to the DeleteFileSystem operation.
    /// Deletes a file system, deleting its contents. After deletion, the file system no longer
    /// exists, and its data is gone. Any existing automatic backups will also be deleted.
    /// 
    ///  
    /// <para>
    /// By default, when you delete an Amazon FSx for Windows File Server file system, a final
    /// backup is created upon deletion. This final backup is not subject to the file system's
    /// retention policy, and must be manually deleted.
    /// </para>
    ///  
    /// <para>
    /// The <code>DeleteFileSystem</code> action returns while the file system has the <code>DELETING</code>
    /// status. You can check the file system deletion status by calling the <a>DescribeFileSystems</a>
    /// action, which returns a list of file systems in your account. If you pass the file
    /// system ID for a deleted file system, the <a>DescribeFileSystems</a> returns a <code>FileSystemNotFound</code>
    /// error.
    /// </para>
    ///  <important> 
    /// <para>
    /// The data in a deleted file system is also deleted and can't be recovered by any means.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteFileSystemRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private string _fileSystemId;
        private DeleteFileSystemWindowsConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// (Optional) A string of up to 64 ASCII characters that Amazon FSx uses to ensure idempotent
        /// deletion. This is automatically filled on your behalf when using the AWS CLI or SDK.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
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

        /// <summary>
        /// Gets and sets the property WindowsConfiguration.
        /// </summary>
        public DeleteFileSystemWindowsConfiguration WindowsConfiguration
        {
            get { return this._windowsConfiguration; }
            set { this._windowsConfiguration = value; }
        }

        // Check to see if WindowsConfiguration property is set
        internal bool IsSetWindowsConfiguration()
        {
            return this._windowsConfiguration != null;
        }

    }
}