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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateFileSystemFromBackup operation. Creates
    /// a new Amazon FSx for Lustre, Amazon FSx for Windows File Server, or Amazon FSx for
    /// OpenZFS file system from an existing Amazon FSx backup. <para> If a file system with
    /// the specified client request token exists and the parameters match, this operation
    /// returns the description of the file system. If a file system with the specified client
    /// request token exists but the parameters don't match, this call returns <c>IncompatibleParameterError</c>.
    /// If a file system with the specified client request token doesn't exist, this operation
    /// does the following: </para> <ul> <li> <para> Creates a new Amazon FSx file system
    /// from backup with an assigned ID, and an initial lifecycle state of <c>CREATING</c>.
    /// </para> </li> <li> <para> Returns the description of the file system. </para> </li>
    /// </ul> <para> Parameters like the Active Directory, default share name, automatic backup,
    /// and backup settings default to the parameters of the file system that was backed up,
    /// unless overridden. You can explicitly supply other settings. </para> <para> By using
    /// the idempotent operation, you can retry a <c>CreateFileSystemFromBackup</c> call without
    /// the risk of creating an extra file system. This approach can be useful when an initial
    /// call fails in a way that makes it unclear whether a file system was created. Examples
    /// are if a transport level timeout occurred, or your connection was reset. If you use
    /// the same client request token and the initial call created a file system, the client
    /// receives a success message as long as the parameters are the same. </para> <note>
    /// <para> The <c>CreateFileSystemFromBackup</c> call returns while the file system's
    /// lifecycle state is still <c>CREATING</c>. You can check the file-system creation status
    /// by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">
    /// DescribeFileSystems</a> operation, which returns the file system state along with
    /// other information. </para> </note>
    /// </summary>
    public partial class CreateFileSystemFromBackupRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property BackupId.
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 128)]
        public string BackupId { get; set; }

        /// <summary>
        /// Checks to see if the BackupId property is set.
        /// </summary>
        internal bool IsSetBackupId() => this.BackupId != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 63 ASCII characters that Amazon FSx uses to ensure idempotent creation.
        /// This string is automatically filled on your behalf when you use the Command Line Interface
        /// (CLI) or an Amazon Web Services SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property FileSystemTypeVersion. 
        /// <para>
        /// Sets the version for the Amazon FSx for Lustre file system that you're creating from
        /// a backup. Valid values are <c>2.10</c>, <c>2.12</c>, and <c>2.15</c>.
        /// </para>
        ///  
        /// <para>
        /// You can enter a Lustre version that is newer than the backup's <c>FileSystemTypeVersion</c>
        /// setting. If you don't enter a newer Lustre version, it defaults to the backup's setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string FileSystemTypeVersion { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemTypeVersion property is set.
        /// </summary>
        internal bool IsSetFileSystemTypeVersion() => this.FileSystemTypeVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LustreConfiguration.
        /// </summary>
        public CreateFileSystemLustreConfiguration LustreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LustreConfiguration property is set.
        /// </summary>
        internal bool IsSetLustreConfiguration() => this.LustreConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Sets the network type for the Amazon FSx for OpenZFS file system that you're creating
        /// from a backup.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The OpenZFS configuration for the file system that's being created. 
        /// </para>
        /// </summary>
        public CreateFileSystemOpenZFSConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenZFSConfiguration() => this.OpenZFSConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of IDs for the security groups that apply to the specified network interfaces
        /// created for file system access. These security groups apply to all network interfaces.
        /// This value isn't returned in later <c>DescribeFileSystem</c> requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// Sets the storage capacity of the OpenZFS file system that you're creating from a backup,
        /// in gibibytes (GiB). Valid values are from 64 GiB up to 524,288 GiB (512 TiB). However,
        /// the value that you specify must be equal to or greater than the backup's storage capacity
        /// value. If you don't use the <c>StorageCapacity</c> parameter, the default is the backup's
        /// <c>StorageCapacity</c> value.
        /// </para>
        ///  
        /// <para>
        /// If used to create a file system other than OpenZFS, you must provide a value that
        /// matches the backup's <c>StorageCapacity</c> value. If you provide any other value,
        /// Amazon FSx responds with an HTTP status code 400 Bad Request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? StorageCapacity { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacity property is set.
        /// </summary>
        internal bool IsSetStorageCapacity() => this.StorageCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Sets the storage type for the Windows, OpenZFS, or Lustre file system that you're
        /// creating from a backup. Valid values are <c>SSD</c>, <c>HDD</c>, and <c>INTELLIGENT_TIERING</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <c>SSD</c> to use solid state drive storage. SSD is supported on all Windows
        /// and OpenZFS deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>HDD</c> to use hard disk drive storage. HDD is supported on <c>SINGLE_AZ_2</c>
        /// and <c>MULTI_AZ_1</c> FSx for Windows File Server file system deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>INTELLIGENT_TIERING</c> to use fully elastic, intelligently-tiered storage.
        /// Intelligent-Tiering is only available for OpenZFS file systems with the Multi-AZ deployment
        /// type and for Lustre file systems with the Persistent_2 deployment type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The default value is <c>SSD</c>. 
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
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Specifies the IDs of the subnets that the file system will be accessible from. For
        /// Windows <c>MULTI_AZ_1</c> file system deployment types, provide exactly two subnet
        /// IDs, one for the preferred file server and one for the standby file server. You specify
        /// one of these subnets as the preferred subnet using the <c>WindowsConfiguration > PreferredSubnetID</c>
        /// property.
        /// </para>
        ///  
        /// <para>
        /// Windows <c>SINGLE_AZ_1</c> and <c>SINGLE_AZ_2</c> file system deployment types, Lustre
        /// file systems, and OpenZFS file systems provide exactly one subnet ID. The file server
        /// is launched in that subnet's Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be applied to the file system at file system creation. The key value of
        /// the <c>Name</c> tag appears in the console as the file system name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// The configuration for this Microsoft Windows file system.
        /// </para>
        /// </summary>
        public CreateFileSystemWindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WindowsConfiguration property is set.
        /// </summary>
        internal bool IsSetWindowsConfiguration() => this.WindowsConfiguration != null;
    }
}
