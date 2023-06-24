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
    /// Container for the parameters to the CreateFileSystem operation.
    /// Creates a new, empty Amazon FSx file system. You can create the following supported
    /// Amazon FSx file systems using the <code>CreateFileSystem</code> API operation:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Amazon FSx for Lustre
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for NetApp ONTAP
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for OpenZFS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for Windows File Server
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation requires a client request token in the request that Amazon FSx uses
    /// to ensure idempotent creation. This means that calling the operation multiple times
    /// with the same client request token has no effect. By using the idempotent operation,
    /// you can retry a <code>CreateFileSystem</code> operation without the risk of creating
    /// an extra file system. This approach can be useful when an initial call fails in a
    /// way that makes it unclear whether a file system was created. Examples are if a transport
    /// level timeout occurred, or your connection was reset. If you use the same client request
    /// token and the initial call created a file system, the client receives success as long
    /// as the parameters are the same.
    /// </para>
    ///  
    /// <para>
    /// If a file system with the specified client request token exists and the parameters
    /// match, <code>CreateFileSystem</code> returns the description of the existing file
    /// system. If a file system with the specified client request token exists and the parameters
    /// don't match, this call returns <code>IncompatibleParameterError</code>. If a file
    /// system with the specified client request token doesn't exist, <code>CreateFileSystem</code>
    /// does the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new, empty Amazon FSx file system with an assigned ID, and an initial lifecycle
    /// state of <code>CREATING</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the file system in JSON format.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
    /// is still <code>CREATING</code>. You can check the file-system creation status by calling
    /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
    /// operation, which returns the file system state along with other information.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateFileSystemRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private FileSystemType _fileSystemType;
        private string _fileSystemTypeVersion;
        private string _kmsKeyId;
        private CreateFileSystemLustreConfiguration _lustreConfiguration;
        private CreateFileSystemOntapConfiguration _ontapConfiguration;
        private CreateFileSystemOpenZFSConfiguration _openZFSConfiguration;
        private List<string> _securityGroupIds = new List<string>();
        private int? _storageCapacity;
        private StorageType _storageType;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private CreateFileSystemWindowsConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 63 ASCII characters that Amazon FSx uses to ensure idempotent creation.
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
        /// Gets and sets the property FileSystemType. 
        /// <para>
        /// The type of Amazon FSx file system to create. Valid values are <code>WINDOWS</code>,
        /// <code>LUSTRE</code>, <code>ONTAP</code>, and <code>OPENZFS</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileSystemType FileSystemType
        {
            get { return this._fileSystemType; }
            set { this._fileSystemType = value; }
        }

        // Check to see if FileSystemType property is set
        internal bool IsSetFileSystemType()
        {
            return this._fileSystemType != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemTypeVersion. 
        /// <para>
        /// (Optional) For FSx for Lustre file systems, sets the Lustre version for the file system
        /// that you're creating. Valid values are <code>2.10</code> and <code>2.12</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 2.10 is supported by the Scratch and Persistent_1 Lustre deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.12 is supported by all Lustre deployment types. <code>2.12</code> is required when
        /// setting FSx for Lustre <code>DeploymentType</code> to <code>PERSISTENT_2</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default value = <code>2.10</code>, except when <code>DeploymentType</code> is set
        /// to <code>PERSISTENT_2</code>, then the default is <code>2.12</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <code>FileSystemTypeVersion</code> to <code>2.10</code> for a <code>PERSISTENT_2</code>
        /// Lustre deployment type, the <code>CreateFileSystem</code> operation fails.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property OntapConfiguration.
        /// </summary>
        public CreateFileSystemOntapConfiguration OntapConfiguration
        {
            get { return this._ontapConfiguration; }
            set { this._ontapConfiguration = value; }
        }

        // Check to see if OntapConfiguration property is set
        internal bool IsSetOntapConfiguration()
        {
            return this._ontapConfiguration != null;
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
        /// A list of IDs specifying the security groups to apply to all network interfaces created
        /// for file system access. This list isn't returned in later requests to describe the
        /// file system.
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
        /// Sets the storage capacity of the file system that you're creating, in gibibytes (GiB).
        /// </para>
        ///  
        /// <para>
        ///  <b>FSx for Lustre file systems</b> - The amount of storage capacity that you can
        /// configure depends on the value that you set for <code>StorageType</code> and the Lustre
        /// <code>DeploymentType</code>, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>SCRATCH_2</code>, <code>PERSISTENT_2</code> and <code>PERSISTENT_1</code>
        /// deployment types using SSD storage type, the valid values are 1200 GiB, 2400 GiB,
        /// and increments of 2400 GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>PERSISTENT_1</code> HDD file systems, valid values are increments of 6000
        /// GiB for 12 MB/s/TiB file systems and increments of 1800 GiB for 40 MB/s/TiB file systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>SCRATCH_1</code> deployment type, valid values are 1200 GiB, 2400 GiB, and
        /// increments of 3600 GiB.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>FSx for ONTAP file systems</b> - The amount of storage capacity that you can configure
        /// is from 1024 GiB up to 196,608 GiB (192 TiB).
        /// </para>
        ///  
        /// <para>
        ///  <b>FSx for OpenZFS file systems</b> - The amount of storage capacity that you can
        /// configure is from 64 GiB up to 524,288 GiB (512 TiB).
        /// </para>
        ///  
        /// <para>
        ///  <b>FSx for Windows File Server file systems</b> - The amount of storage capacity
        /// that you can configure depends on the value that you set for <code>StorageType</code>
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For SSD storage, valid values are 32 GiB-65,536 GiB (64 TiB).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For HDD storage, valid values are 2000 GiB-65,536 GiB (64 TiB).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
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
        /// Sets the storage type for the file system that you're creating. Valid values are <code>SSD</code>
        /// and <code>HDD</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <code>SSD</code> to use solid state drive storage. SSD is supported on all
        /// Windows, Lustre, ONTAP, and OpenZFS deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <code>HDD</code> to use hard disk drive storage. HDD is supported on <code>SINGLE_AZ_2</code>
        /// and <code>MULTI_AZ_1</code> Windows file system deployment types, and on <code>PERSISTENT_1</code>
        /// Lustre file system deployment types. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default value is <code>SSD</code>. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/optimize-fsx-costs.html#storage-type-options">
        /// Storage type options</a> in the <i>FSx for Windows File Server User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/what-is.html#storage-options">Multiple
        /// storage options</a> in the <i>FSx for Lustre User Guide</i>. 
        /// </para>
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
        /// Windows and ONTAP <code>MULTI_AZ_1</code> deployment types,provide exactly two subnet
        /// IDs, one for the preferred file server and one for the standby file server. You specify
        /// one of these subnets as the preferred subnet using the <code>WindowsConfiguration
        /// &gt; PreferredSubnetID</code> or <code>OntapConfiguration &gt; PreferredSubnetID</code>
        /// properties. For more information about Multi-AZ file system configuration, see <a
        /// href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/high-availability-multiAZ.html">
        /// Availability and durability: Single-AZ and Multi-AZ file systems</a> in the <i>Amazon
        /// FSx for Windows User Guide</i> and <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/high-availability-multiAZ.html">
        /// Availability and durability</a> in the <i>Amazon FSx for ONTAP User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For Windows <code>SINGLE_AZ_1</code> and <code>SINGLE_AZ_2</code> and all Lustre deployment
        /// types, provide exactly one subnet ID. The file server is launched in that subnet's
        /// Availability Zone.
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
        /// The tags to apply to the file system that's being created. The key value of the <code>Name</code>
        /// tag appears in the console as the file system name.
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
        /// The Microsoft Windows configuration for the file system that's being created. 
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