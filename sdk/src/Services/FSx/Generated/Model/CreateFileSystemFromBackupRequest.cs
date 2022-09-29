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
    /// Container for the parameters to the CreateFileSystemFromBackup operation.
    /// Creates a new Amazon FSx for Lustre, Amazon FSx for Windows File Server, or Amazon
    /// FSx for OpenZFS file system from an existing Amazon FSx backup.
    /// 
    ///  
    /// <para>
    /// If a file system with the specified client request token exists and the parameters
    /// match, this operation returns the description of the file system. If a file system
    /// with the specified client request token exists but the parameters don't match, this
    /// call returns <code>IncompatibleParameterError</code>. If a file system with the specified
    /// client request token doesn't exist, this operation does the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new Amazon FSx file system from backup with an assigned ID, and an initial
    /// lifecycle state of <code>CREATING</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the file system.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Parameters like the Active Directory, default share name, automatic backup, and backup
    /// settings default to the parameters of the file system that was backed up, unless overridden.
    /// You can explicitly supply other settings.
    /// </para>
    ///  
    /// <para>
    /// By using the idempotent operation, you can retry a <code>CreateFileSystemFromBackup</code>
    /// call without the risk of creating an extra file system. This approach can be useful
    /// when an initial call fails in a way that makes it unclear whether a file system was
    /// created. Examples are if a transport level timeout occurred, or your connection was
    /// reset. If you use the same client request token and the initial call created a file
    /// system, the client receives a success message as long as the parameters are the same.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>CreateFileSystemFromBackup</code> call returns while the file system's lifecycle
    /// state is still <code>CREATING</code>. You can check the file-system creation status
    /// by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">
    /// DescribeFileSystems</a> operation, which returns the file system state along with
    /// other information.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateFileSystemFromBackupRequest : AmazonFSxRequest
    {
        private string _backupId;
        private string _clientRequestToken;
        private string _fileSystemTypeVersion;
        private string _kmsKeyId;
        private CreateFileSystemLustreConfiguration _lustreConfiguration;
        private CreateFileSystemOpenZFSConfiguration _openZFSConfiguration;
        private List<string> _securityGroupIds = new List<string>();
        private int? _storageCapacity;
        private StorageType _storageType;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private CreateFileSystemWindowsConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property BackupId.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 64 ASCII characters that Amazon FSx uses to ensure idempotent creation.
        /// This string is automatically filled on your behalf when you use the Command Line Interface
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
        /// Gets and sets the property FileSystemTypeVersion. 
        /// <para>
        /// Sets the version for the Amazon FSx for Lustre file system that you're creating from
        /// a backup. Valid values are <code>2.10</code> and <code>2.12</code>.
        /// </para>
        ///  
        /// <para>
        /// You don't need to specify <code>FileSystemTypeVersion</code> because it will be applied
        /// using the backup's <code>FileSystemTypeVersion</code> setting. If you choose to specify
        /// <code>FileSystemTypeVersion</code> when creating from backup, the value must match
        /// the backup's <code>FileSystemTypeVersion</code> setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string FileSystemTypeVersion
        {
            get { return this._fileSystemTypeVersion; }
            set { this._fileSystemTypeVersion = value; }
        }

        // Check to see if FileSystemTypeVersion property is set
        internal bool IsSetFileSystemTypeVersion()
        {
            return this._fileSystemTypeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LustreConfiguration.
        /// </summary>
        public CreateFileSystemLustreConfiguration LustreConfiguration
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
        /// The OpenZFS configuration for the file system that's being created. 
        /// </para>
        /// </summary>
        public CreateFileSystemOpenZFSConfiguration OpenZFSConfiguration
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of IDs for the security groups that apply to the specified network interfaces
        /// created for file system access. These security groups apply to all network interfaces.
        /// This value isn't returned in later <code>DescribeFileSystem</code> requests.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// Sets the storage capacity of the OpenZFS file system that you're creating from a backup,
        /// in gibibytes (GiB). Valid values are from 64 GiB up to 524,288 GiB (512 TiB). However,
        /// the value that you specify must be equal to or greater than the backup's storage capacity
        /// value. If you don't use the <code>StorageCapacity</code> parameter, the default is
        /// the backup's <code>StorageCapacity</code> value.
        /// </para>
        ///  
        /// <para>
        /// If used to create a file system other than OpenZFS, you must provide a value that
        /// matches the backup's <code>StorageCapacity</code> value. If you provide any other
        /// value, Amazon FSx responds with a 400 Bad Request. 
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Sets the storage type for the Windows or OpenZFS file system that you're creating
        /// from a backup. Valid values are <code>SSD</code> and <code>HDD</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <code>SSD</code> to use solid state drive storage. SSD is supported on all
        /// Windows and OpenZFS deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <code>HDD</code> to use hard disk drive storage. HDD is supported on <code>SINGLE_AZ_2</code>
        /// and <code>MULTI_AZ_1</code> FSx for Windows File Server file system deployment types.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The default value is <code>SSD</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// HDD and SSD storage types have different minimum storage capacity requirements. A
        /// restored file system's storage capacity is tied to the file system that was backed
        /// up. You can create a file system that uses HDD storage from a backup of a file system
        /// that used SSD storage if the original SSD file system had a storage capacity of at
        /// least 2000 GiB.
        /// </para>
        ///  </note>
        /// </summary>
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Specifies the IDs of the subnets that the file system will be accessible from. For
        /// Windows <code>MULTI_AZ_1</code> file system deployment types, provide exactly two
        /// subnet IDs, one for the preferred file server and one for the standby file server.
        /// You specify one of these subnets as the preferred subnet using the <code>WindowsConfiguration
        /// &gt; PreferredSubnetID</code> property.
        /// </para>
        ///  
        /// <para>
        /// Windows <code>SINGLE_AZ_1</code> and <code>SINGLE_AZ_2</code> file system deployment
        /// types, Lustre file systems, and OpenZFS file systems provide exactly one subnet ID.
        /// The file server is launched in that subnet's Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be applied to the file system at file system creation. The key value of
        /// the <code>Name</code> tag appears in the console as the file system name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// The configuration for this Microsoft Windows file system.
        /// </para>
        /// </summary>
        public CreateFileSystemWindowsConfiguration WindowsConfiguration
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