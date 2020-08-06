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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFileSystem operation.
    /// Use this operation to update the configuration of an existing Amazon FSx file system.
    /// You can update multiple properties in a single request.
    /// 
    ///  
    /// <para>
    /// For Amazon FSx for Windows File Server file systems, you can update the following
    /// properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// AutomaticBackupRetentionDays
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DailyAutomaticBackupStartTime
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SelfManagedActiveDirectoryConfiguration
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// StorageCapacity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ThroughputCapacity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// WeeklyMaintenanceStartTime
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For Amazon FSx for Lustre file systems, you can update the following properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// AutoImportPolicy
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AutomaticBackupRetentionDays
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DailyAutomaticBackupStartTime
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// WeeklyMaintenanceStartTime
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateFileSystemRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private string _fileSystemId;
        private UpdateFileSystemLustreConfiguration _lustreConfiguration;
        private int? _storageCapacity;
        private UpdateFileSystemWindowsConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 64 ASCII characters that Amazon FSx uses to ensure idempotent updates.
        /// This string is automatically filled on your behalf when you use the AWS Command Line
        /// Interface (AWS CLI) or an AWS SDK.
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
        /// Identifies the file system that you are updating.
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
        public UpdateFileSystemLustreConfiguration LustreConfiguration
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
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// Use this parameter to increase the storage capacity of an Amazon FSx for Windows File
        /// Server file system. Specifies the storage capacity target value, GiB, for the file
        /// system you're updating. The storage capacity target value must be at least 10 percent
        /// (%) greater than the current storage capacity value. In order to increase storage
        /// capacity, the file system needs to have at least 16 MB/s of throughput capacity. You
        /// cannot make a storage capacity increase request if there is an existing storage capacity
        /// increase request in progress. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-storage-capacity.html">Managing
        /// Storage Capacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int StorageCapacity
        {
            get { return this._storageCapacity.GetValueOrDefault(); }
            set { this._storageCapacity = value; }
        }

        // Check to see if StorageCapacity property is set
        internal bool IsSetStorageCapacity()
        {
            return this._storageCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// The configuration updates for an Amazon FSx for Windows File Server file system.
        /// </para>
        /// </summary>
        public UpdateFileSystemWindowsConfiguration WindowsConfiguration
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