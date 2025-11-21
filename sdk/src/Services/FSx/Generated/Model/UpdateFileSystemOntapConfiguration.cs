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
    /// The configuration updates for an Amazon FSx for NetApp ONTAP file system.
    /// </summary>
    public partial class UpdateFileSystemOntapConfiguration
    {
        private List<string> _addRouteTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _endpointIpv6AddressRange;
        private string _fsxAdminPassword;
        private int? _haPairs;
        private List<string> _removeRouteTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _throughputCapacity;
        private int? _throughputCapacityPerHAPair;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of new virtual private cloud (VPC) route tables to associate
        /// (add) with your Amazon FSx for NetApp ONTAP file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> AddRouteTableIds
        {
            get { return this._addRouteTableIds; }
            set { this._addRouteTableIds = value; }
        }

        // Check to see if AddRouteTableIds property is set
        internal bool IsSetAddRouteTableIds()
        {
            return this._addRouteTableIds != null && (this._addRouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays.
        /// </summary>
        [AWSProperty(Min=0, Max=90)]
        public int? AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays; }
            set { this._automaticBackupRetentionDays = value; }
        }

        // Check to see if AutomaticBackupRetentionDays property is set
        internal bool IsSetAutomaticBackupRetentionDays()
        {
            return this._automaticBackupRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime.
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
        public string DailyAutomaticBackupStartTime
        {
            get { return this._dailyAutomaticBackupStartTime; }
            set { this._dailyAutomaticBackupStartTime = value; }
        }

        // Check to see if DailyAutomaticBackupStartTime property is set
        internal bool IsSetDailyAutomaticBackupStartTime()
        {
            return this._dailyAutomaticBackupStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration. 
        /// <para>
        /// The SSD IOPS (input output operations per second) configuration for an Amazon FSx
        /// for NetApp ONTAP file system. The default is 3 IOPS per GB of storage capacity, but
        /// you can provision additional IOPS per GB of storage. The configuration consists of
        /// an IOPS mode (<c>AUTOMATIC</c> or <c>USER_PROVISIONED</c>), and in the case of <c>USER_PROVISIONED</c>
        /// IOPS, the total number of SSD IOPS provisioned. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/storage-capacity-and-IOPS.html">File
        /// system storage capacity and IOPS</a>.
        /// </para>
        /// </summary>
        public DiskIopsConfiguration DiskIopsConfiguration
        {
            get { return this._diskIopsConfiguration; }
            set { this._diskIopsConfiguration = value; }
        }

        // Check to see if DiskIopsConfiguration property is set
        internal bool IsSetDiskIopsConfiguration()
        {
            return this._diskIopsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIpv6AddressRange. 
        /// <para>
        /// (Multi-AZ only) Specifies the IPv6 address range in which the endpoints to access
        /// your file system will be created. By default in the Amazon FSx API and Amazon FSx
        /// console, Amazon FSx selects an available /118 IP address range for you from one of
        /// the VPC's CIDR ranges. You can have overlapping endpoint IP addresses for file systems
        /// deployed in the same VPC/route tables, as long as they don't overlap with any subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=43)]
        public string EndpointIpv6AddressRange
        {
            get { return this._endpointIpv6AddressRange; }
            set { this._endpointIpv6AddressRange = value; }
        }

        // Check to see if EndpointIpv6AddressRange property is set
        internal bool IsSetEndpointIpv6AddressRange()
        {
            return this._endpointIpv6AddressRange != null;
        }

        /// <summary>
        /// Gets and sets the property FsxAdminPassword. 
        /// <para>
        /// Update the password for the <c>fsxadmin</c> user by entering a new password. You use
        /// the <c>fsxadmin</c> user to access the NetApp ONTAP CLI and REST API to manage your
        /// file system resources. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-resources-ontap-apps.html">Managing
        /// resources using NetApp Application</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=50)]
        public string FsxAdminPassword
        {
            get { return this._fsxAdminPassword; }
            set { this._fsxAdminPassword = value; }
        }

        // Check to see if FsxAdminPassword property is set
        internal bool IsSetFsxAdminPassword()
        {
            return this._fsxAdminPassword != null;
        }

        /// <summary>
        /// Gets and sets the property HAPairs. 
        /// <para>
        /// Use to update the number of high-availability (HA) pairs for a second-generation single-AZ
        /// file system. If you increase the number of HA pairs for your file system, you must
        /// specify proportional increases for <c>StorageCapacity</c>, <c>Iops</c>, and <c>ThroughputCapacity</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/administering-file-systems.html#HA-pairs">High-availability
        /// (HA) pairs</a> in the FSx for ONTAP user guide. Block storage protocol support (iSCSI
        /// and NVMe over TCP) is disabled on file systems with more than 6 HA pairs. For more
        /// information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/supported-fsx-clients.html#using-block-storage">Using
        /// block storage protocols</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public int? HAPairs
        {
            get { return this._haPairs; }
            set { this._haPairs = value; }
        }

        // Check to see if HAPairs property is set
        internal bool IsSetHAPairs()
        {
            return this._haPairs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of existing virtual private cloud (VPC) route tables
        /// to disassociate (remove) from your Amazon FSx for NetApp ONTAP file system. You can
        /// use the API operation to retrieve the list of VPC route table IDs for a file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> RemoveRouteTableIds
        {
            get { return this._removeRouteTableIds; }
            set { this._removeRouteTableIds = value; }
        }

        // Check to see if RemoveRouteTableIds property is set
        internal bool IsSetRemoveRouteTableIds()
        {
            return this._removeRouteTableIds != null && (this._removeRouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Enter a new value to change the amount of throughput capacity for the file system
        /// in megabytes per second (MBps). For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-throughput-capacity.html">Managing
        /// throughput capacity</a> in the FSx for ONTAP User Guide.
        /// </para>
        ///  
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) for the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacity</c> and <c>ThroughputCapacityPerHAPair</c> are
        /// not the same value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacity</c> when divided by the value of <c>HAPairs</c>
        /// is outside of the valid range for <c>ThroughputCapacity</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=8, Max=100000)]
        public int? ThroughputCapacity
        {
            get { return this._throughputCapacity; }
            set { this._throughputCapacity = value; }
        }

        // Check to see if ThroughputCapacity property is set
        internal bool IsSetThroughputCapacity()
        {
            return this._throughputCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacityPerHAPair. 
        /// <para>
        /// Use to choose the throughput capacity per HA pair, rather than the total throughput
        /// for the file system. 
        /// </para>
        ///  
        /// <para>
        /// This field and <c>ThroughputCapacity</c> cannot be defined in the same API call, but
        /// one is required.
        /// </para>
        ///  
        /// <para>
        /// This field and <c>ThroughputCapacity</c> are the same for file systems with one HA
        /// pair.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_1</c> and <c>MULTI_AZ_1</c> file systems, valid values are 128, 256,
        /// 512, 1024, 2048, or 4096 MBps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_2</c>, valid values are 1536, 3072, or 6144 MBps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>MULTI_AZ_2</c>, valid values are 384, 768, 1536, 3072, or 6144 MBps.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) for the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacity</c> and <c>ThroughputCapacityPerHAPair</c> are
        /// not the same value for file systems with one HA pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of deployment type is <c>SINGLE_AZ_2</c> and <c>ThroughputCapacity</c> /
        /// <c>ThroughputCapacityPerHAPair</c> is not a valid HA pair (a value between 1 and 12).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacityPerHAPair</c> is not a valid value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=128, Max=6144)]
        public int? ThroughputCapacityPerHAPair
        {
            get { return this._throughputCapacityPerHAPair; }
            set { this._throughputCapacityPerHAPair = value; }
        }

        // Check to see if ThroughputCapacityPerHAPair property is set
        internal bool IsSetThroughputCapacityPerHAPair()
        {
            return this._throughputCapacityPerHAPair.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime.
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}