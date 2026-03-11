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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFileSystem operation.
    /// Deletes a file system. After deletion, the file system no longer exists, and its data
    /// is gone. Any existing automatic backups and snapshots are also deleted.
    /// 
    ///  
    /// <para>
    /// To delete an Amazon FSx for NetApp ONTAP file system, first delete all the volumes
    /// and storage virtual machines (SVMs) on the file system. Then provide a <c>FileSystemId</c>
    /// value to the <c>DeleteFileSystem</c> operation.
    /// </para>
    ///  
    /// <para>
    /// Before deleting an Amazon FSx for OpenZFS file system, make sure that there aren't
    /// any Amazon S3 access points attached to any volume. For more information on how to
    /// list S3 access points that are attached to volumes, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/access-points-list.html">Listing
    /// S3 access point attachments</a>. For more information on how to delete S3 access points,
    /// see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/delete-access-point.html">Deleting
    /// an S3 access point attachment</a>.
    /// </para>
    ///  
    /// <para>
    /// By default, when you delete an Amazon FSx for Windows File Server file system, a final
    /// backup is created upon deletion. This final backup isn't subject to the file system's
    /// retention policy, and must be manually deleted.
    /// </para>
    ///  
    /// <para>
    /// To delete an Amazon FSx for Lustre file system, first <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/unmounting-fs.html">unmount</a>
    /// it from every connected Amazon EC2 instance, then provide a <c>FileSystemId</c> value
    /// to the <c>DeleteFileSystem</c> operation. By default, Amazon FSx will not take a final
    /// backup when the <c>DeleteFileSystem</c> operation is invoked. On file systems not
    /// linked to an Amazon S3 bucket, set <c>SkipFinalBackup</c> to <c>false</c> to take
    /// a final backup of the file system you are deleting. Backups cannot be enabled on S3-linked
    /// file systems. To ensure all of your data is written back to S3 before deleting your
    /// file system, you can either monitor for the <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/monitoring-cloudwatch.html#auto-import-export-metrics">AgeOfOldestQueuedMessage</a>
    /// metric to be zero (if using automatic export) or you can run an <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/export-data-repo-task-dra.html">export
    /// data repository task</a>. If you have automatic export enabled and want to use an
    /// export data repository task, you have to disable automatic export before executing
    /// the export data repository task.
    /// </para>
    ///  
    /// <para>
    /// The <c>DeleteFileSystem</c> operation returns while the file system has the <c>DELETING</c>
    /// status. You can check the file system deletion status by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
    /// operation, which returns a list of file systems in your account. If you pass the file
    /// system ID for a deleted file system, the <c>DescribeFileSystems</c> operation returns
    /// a <c>FileSystemNotFound</c> error.
    /// </para>
    ///  <note> 
    /// <para>
    /// If a data repository task is in a <c>PENDING</c> or <c>EXECUTING</c> state, deleting
    /// an Amazon FSx for Lustre file system will fail with an HTTP status code 400 (Bad Request).
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// The data in a deleted file system is also deleted and can't be recovered by any means.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteFileSystemRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private string _fileSystemId;
        private DeleteFileSystemLustreConfiguration _lustreConfiguration;
        private DeleteFileSystemOpenZFSConfiguration _openZFSConfiguration;
        private DeleteFileSystemWindowsConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 63 ASCII characters that Amazon FSx uses to ensure idempotent deletion.
        /// This token is automatically filled on your behalf when using the Command Line Interface
        /// (CLI) or an Amazon Web Services SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// The ID of the file system that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
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
        /// Gets and sets the property LustreConfiguration.
        /// </summary>
        public DeleteFileSystemLustreConfiguration LustreConfiguration
        {
            get { return this._lustreConfiguration; }
            set { this._lustreConfiguration = value; }
        }

        // Check to see if LustreConfiguration property is set
        internal bool IsSetLustreConfiguration()
        {
            return this._lustreConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The configuration object for the OpenZFS file system used in the <c>DeleteFileSystem</c>
        /// operation.
        /// </para>
        /// </summary>
        public DeleteFileSystemOpenZFSConfiguration OpenZFSConfiguration
        {
            get { return this._openZFSConfiguration; }
            set { this._openZFSConfiguration = value; }
        }

        // Check to see if OpenZFSConfiguration property is set
        internal bool IsSetOpenZFSConfiguration()
        {
            return this._openZFSConfiguration != null;
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