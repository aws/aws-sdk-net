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
    /// Container for the parameters to the CreateFileSystem operation.
    /// Creates a new, empty Amazon FSx file system. You can create the following supported
    /// Amazon FSx file systems using the <c>CreateFileSystem</c> API operation:
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
    /// you can retry a <c>CreateFileSystem</c> operation without the risk of creating an
    /// extra file system. This approach can be useful when an initial call fails in a way
    /// that makes it unclear whether a file system was created. Examples are if a transport
    /// level timeout occurred, or your connection was reset. If you use the same client request
    /// token and the initial call created a file system, the client receives success as long
    /// as the parameters are the same.
    /// </para>
    ///  
    /// <para>
    /// If a file system with the specified client request token exists and the parameters
    /// match, <c>CreateFileSystem</c> returns the description of the existing file system.
    /// If a file system with the specified client request token exists and the parameters
    /// don't match, this call returns <c>IncompatibleParameterError</c>. If a file system
    /// with the specified client request token doesn't exist, <c>CreateFileSystem</c> does
    /// the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new, empty Amazon FSx file system with an assigned ID, and an initial lifecycle
    /// state of <c>CREATING</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the file system in JSON format.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The <c>CreateFileSystem</c> call returns while the file system's lifecycle state is
    /// still <c>CREATING</c>. You can check the file-system creation status by calling the
    /// <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
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
        private NetworkType _networkType;
        private CreateFileSystemOntapConfiguration _ontapConfiguration;
        private CreateFileSystemOpenZFSConfiguration _openZFSConfiguration;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _storageCapacity;
        private StorageType _storageType;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
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
        /// The type of Amazon FSx file system to create. Valid values are <c>WINDOWS</c>, <c>LUSTRE</c>,
        /// <c>ONTAP</c>, and <c>OPENZFS</c>.
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
        /// For FSx for Lustre file systems, sets the Lustre version for the file system that
        /// you're creating. Valid values are <c>2.10</c>, <c>2.12</c>, and <c>2.15</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>2.10</c> is supported by the Scratch and Persistent_1 Lustre deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2.12</c> is supported by all Lustre deployment types, except for <c>PERSISTENT_2</c>
        /// with a metadata configuration mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2.15</c> is supported by all Lustre deployment types and is recommended for all
        /// new file systems.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default value is <c>2.10</c>, except for the following deployments:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Default value is <c>2.12</c> when <c>DeploymentType</c> is set to <c>PERSISTENT_2</c>
        /// without a metadata configuration mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default value is <c>2.15</c> when <c>DeploymentType</c> is set to <c>PERSISTENT_2</c>
        /// with a metadata configuration mode.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the Amazon FSx file system that you are creating. Valid values
        /// are <c>IPV4</c> (which supports IPv4 only) and <c>DUAL</c> (for dual-stack mode, which
        /// supports both IPv4 and IPv6). The default is <c>IPV4</c>. Supported for FSx for OpenZFS,
        /// FSx for ONTAP, and FSx for Windows File Server file systems.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
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
        ///  <important> 
        /// <para>
        /// You must specify a security group if you are creating a Multi-AZ FSx for ONTAP file
        /// system in a VPC subnet that has been shared with you.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// Sets the storage capacity of the file system that you're creating, in gibibytes (GiB).
        /// </para>
        ///  
        /// <para>
        ///  <b>FSx for Lustre file systems</b> - The amount of storage capacity that you can
        /// configure depends on the value that you set for <c>StorageType</c> and the Lustre
        /// <c>DeploymentType</c>, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>SCRATCH_2</c>, <c>PERSISTENT_2</c>, and <c>PERSISTENT_1</c> deployment types
        /// using SSD storage type, the valid values are 1200 GiB, 2400 GiB, and increments of
        /// 2400 GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>PERSISTENT_1</c> HDD file systems, valid values are increments of 6000 GiB
        /// for 12 MB/s/TiB file systems and increments of 1800 GiB for 40 MB/s/TiB file systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SCRATCH_1</c> deployment type, valid values are 1200 GiB, 2400 GiB, and increments
        /// of 3600 GiB.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>FSx for ONTAP file systems</b> - The amount of storage capacity that you can configure
        /// depends on the value of the <c>HAPairs</c> property. The minimum value is calculated
        /// as 1,024 * <c>HAPairs</c> and the maximum is calculated as 524,288 * <c>HAPairs</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>FSx for OpenZFS file systems</b> - The amount of storage capacity that you can
        /// configure is from 64 GiB up to 524,288 GiB (512 TiB).
        /// </para>
        ///  
        /// <para>
        ///  <b>FSx for Windows File Server file systems</b> - The amount of storage capacity
        /// that you can configure depends on the value that you set for <c>StorageType</c> as
        /// follows:
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
        [AWSProperty(Min=0, Max=2147483647)]
        public int? StorageCapacity
        {
            get { return this._storageCapacity; }
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
        /// Sets the storage class for the file system that you're creating. Valid values are
        /// <c>SSD</c>, <c>HDD</c>, and <c>INTELLIGENT_TIERING</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <c>SSD</c> to use solid state drive storage. SSD is supported on all Windows,
        /// Lustre, ONTAP, and OpenZFS deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>HDD</c> to use hard disk drive storage, which is supported on <c>SINGLE_AZ_2</c>
        /// and <c>MULTI_AZ_1</c> Windows file system deployment types, and on <c>PERSISTENT_1</c>
        /// Lustre file system deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>INTELLIGENT_TIERING</c> to use fully elastic, intelligently-tiered storage.
        /// Intelligent-Tiering is only available for OpenZFS file systems with the Multi-AZ deployment
        /// type and for Lustre file systems with the Persistent_2 deployment type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default value is <c>SSD</c>. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/optimize-fsx-costs.html#storage-type-options">
        /// Storage type options</a> in the <i>FSx for Windows File Server User Guide</i>, <a
        /// href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-fsx-lustre.html#lustre-storage-classes">FSx
        /// for Lustre storage classes</a> in the <i>FSx for Lustre User Guide</i>, and <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance-intelligent-tiering">Working
        /// with Intelligent-Tiering</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
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
        /// Windows and ONTAP <c>MULTI_AZ_1</c> deployment types,provide exactly two subnet IDs,
        /// one for the preferred file server and one for the standby file server. You specify
        /// one of these subnets as the preferred subnet using the <c>WindowsConfiguration &gt;
        /// PreferredSubnetID</c> or <c>OntapConfiguration &gt; PreferredSubnetID</c> properties.
        /// For more information about Multi-AZ file system configuration, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/high-availability-multiAZ.html">
        /// Availability and durability: Single-AZ and Multi-AZ file systems</a> in the <i>Amazon
        /// FSx for Windows User Guide</i> and <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/high-availability-multiAZ.html">
        /// Availability and durability</a> in the <i>Amazon FSx for ONTAP User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For Windows <c>SINGLE_AZ_1</c> and <c>SINGLE_AZ_2</c> and all Lustre deployment types,
        /// provide exactly one subnet ID. The file server is launched in that subnet's Availability
        /// Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the file system that's being created. The key value of the <c>Name</c>
        /// tag appears in the console as the file system name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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