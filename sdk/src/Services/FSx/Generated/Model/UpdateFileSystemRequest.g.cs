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
    /// Container for the parameters to the UpdateFileSystem operation. Use this operation
    /// to update the configuration of an existing Amazon FSx file system. You can update
    /// multiple properties in a single request. <para> For FSx for Windows File Server file
    /// systems, you can update the following properties: </para> <ul> <li> <para> <c>AuditLogConfiguration</c>
    /// </para> </li> <li> <para> <c>AutomaticBackupRetentionDays</c> </para> </li> <li> <para>
    /// <c>DailyAutomaticBackupStartTime</c> </para> </li> <li> <para> <c>DiskIopsConfiguration</c>
    /// </para> </li> <li> <para> <c>SelfManagedActiveDirectoryConfiguration</c> </para> </li>
    /// <li> <para> <c>StorageCapacity</c> </para> </li> <li> <para> <c>StorageType</c> </para>
    /// </li> <li> <para> <c>ThroughputCapacity</c> </para> </li> <li> <para> <c>WeeklyMaintenanceStartTime</c>
    /// </para> </li> </ul> <para> For FSx for Lustre file systems, you can update the following
    /// properties: </para> <ul> <li> <para> <c>AutoImportPolicy</c> </para> </li> <li> <para>
    /// <c>AutomaticBackupRetentionDays</c> </para> </li> <li> <para> <c>DailyAutomaticBackupStartTime</c>
    /// </para> </li> <li> <para> <c>DataCompressionType</c> </para> </li> <li> <para> <c>FileSystemTypeVersion</c>
    /// </para> </li> <li> <para> <c>LogConfiguration</c> </para> </li> <li> <para> <c>LustreReadCacheConfiguration</c>
    /// </para> </li> <li> <para> <c>LustreRootSquashConfiguration</c> </para> </li> <li>
    /// <para> <c>MetadataConfiguration</c> </para> </li> <li> <para> <c>PerUnitStorageThroughput</c>
    /// </para> </li> <li> <para> <c>StorageCapacity</c> </para> </li> <li> <para> <c>ThroughputCapacity</c>
    /// </para> </li> <li> <para> <c>WeeklyMaintenanceStartTime</c> </para> </li> </ul> <para>
    /// For FSx for ONTAP file systems, you can update the following properties: </para> <ul>
    /// <li> <para> <c>AddRouteTableIds</c> </para> </li> <li> <para> <c>AutomaticBackupRetentionDays</c>
    /// </para> </li> <li> <para> <c>DailyAutomaticBackupStartTime</c> </para> </li> <li>
    /// <para> <c>DiskIopsConfiguration</c> </para> </li> <li> <para> <c>EndpointIpv6AddressRange</c>
    /// </para> </li> <li> <para> <c>FsxAdminPassword</c> </para> </li> <li> <para> <c>HAPairs</c>
    /// </para> </li> <li> <para> <c>RemoveRouteTableIds</c> </para> </li> <li> <para> <c>StorageCapacity</c>
    /// </para> </li> <li> <para> <c>ThroughputCapacity</c> </para> </li> <li> <para> <c>ThroughputCapacityPerHAPair</c>
    /// </para> </li> <li> <para> <c>WeeklyMaintenanceStartTime</c> </para> </li> </ul> <para>
    /// For FSx for OpenZFS file systems, you can update the following properties: </para>
    /// <ul> <li> <para> <c>AddRouteTableIds</c> </para> </li> <li> <para> <c>AutomaticBackupRetentionDays</c>
    /// </para> </li> <li> <para> <c>CopyTagsToBackups</c> </para> </li> <li> <para> <c>CopyTagsToVolumes</c>
    /// </para> </li> <li> <para> <c>DailyAutomaticBackupStartTime</c> </para> </li> <li>
    /// <para> <c>DiskIopsConfiguration</c> </para> </li> <li> <para> <c>EndpointIpv6AddressRange</c>
    /// </para> </li> <li> <para> <c>ReadCacheConfiguration</c> </para> </li> <li> <para>
    /// <c>RemoveRouteTableIds</c> </para> </li> <li> <para> <c>StorageCapacity</c> </para>
    /// </li> <li> <para> <c>ThroughputCapacity</c> </para> </li> <li> <para> <c>WeeklyMaintenanceStartTime</c>
    /// </para> </li> </ul>
    /// </summary>
    public partial class UpdateFileSystemRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 63 ASCII characters that Amazon FSx uses to ensure idempotent updates.
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
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property FileSystemTypeVersion. 
        /// <para>
        /// The Lustre version you are updating an FSx for Lustre file system to. Valid values
        /// are <c>2.12</c> and <c>2.15</c>. The value you choose must be newer than the file
        /// system's current Lustre version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string FileSystemTypeVersion { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemTypeVersion property is set.
        /// </summary>
        internal bool IsSetFileSystemTypeVersion() => this.FileSystemTypeVersion != null;

        /// <summary>
        /// Gets and sets the property LustreConfiguration.
        /// </summary>
        public UpdateFileSystemLustreConfiguration LustreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LustreConfiguration property is set.
        /// </summary>
        internal bool IsSetLustreConfiguration() => this.LustreConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Changes the network type of an FSx for OpenZFS file system.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OntapConfiguration.
        /// </summary>
        public UpdateFileSystemOntapConfiguration OntapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OntapConfiguration property is set.
        /// </summary>
        internal bool IsSetOntapConfiguration() => this.OntapConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The configuration updates for an FSx for OpenZFS file system.
        /// </para>
        /// </summary>
        public UpdateFileSystemOpenZFSConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenZFSConfiguration() => this.OpenZFSConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// Use this parameter to increase the storage capacity of an FSx for Windows File Server,
        /// FSx for Lustre, FSx for OpenZFS, or FSx for ONTAP file system. For second-generation
        /// FSx for ONTAP file systems, you can also decrease the storage capacity. Specifies
        /// the storage capacity target value, in GiB, for the file system that you're updating.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't make a storage capacity increase request if there is an existing storage
        /// capacity increase request in progress.
        /// </para>
        ///  </note> 
        /// <para>
        /// For Lustre file systems, the storage capacity target value can be the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>SCRATCH_2</c>, <c>PERSISTENT_1</c>, and <c>PERSISTENT_2 SSD</c> deployment
        /// types, valid values are in multiples of 2400 GiB. The value must be greater than the
        /// current storage capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>PERSISTENT HDD</c> file systems, valid values are multiples of 6000 GiB for
        /// 12-MBps throughput per TiB file systems and multiples of 1800 GiB for 40-MBps throughput
        /// per TiB file systems. The values must be greater than the current storage capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SCRATCH_1</c> file systems, you can't increase the storage capacity.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/managing-storage-capacity.html">Managing
        /// storage and throughput capacity</a> in the <i>FSx for Lustre User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For FSx for OpenZFS file systems, the storage capacity target value must be at least
        /// 10 percent greater than the current storage capacity value. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/managing-storage-capacity.html">Managing
        /// storage capacity</a> in the <i>FSx for OpenZFS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For Windows file systems, the storage capacity target value must be at least 10 percent
        /// greater than the current storage capacity value. To increase storage capacity, the
        /// file system must have at least 16 MBps of throughput capacity. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-storage-capacity.html">Managing
        /// storage capacity</a> in the <i>Amazon FSxfor Windows File Server User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For ONTAP file systems, when increasing storage capacity, the storage capacity target
        /// value must be at least 10 percent greater than the current storage capacity value.
        /// When decreasing storage capacity on second-generation file systems, the target value
        /// must be at least 9 percent smaller than the current SSD storage capacity. For more
        /// information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/storage-capacity-and-IOPS.html">File
        /// system storage capacity and IOPS</a> in the Amazon FSx for NetApp ONTAP User Guide.
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
        /// </summary>
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// The configuration updates for an Amazon FSx for Windows File Server file system.
        /// </para>
        /// </summary>
        public UpdateFileSystemWindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WindowsConfiguration property is set.
        /// </summary>
        internal bool IsSetWindowsConfiguration() => this.WindowsConfiguration != null;
    }
}
