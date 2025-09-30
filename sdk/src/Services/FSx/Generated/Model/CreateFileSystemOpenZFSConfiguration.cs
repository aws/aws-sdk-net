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
    /// The Amazon FSx for OpenZFS configuration properties for the file system that you are
    /// creating.
    /// </summary>
    public partial class CreateFileSystemOpenZFSConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private bool? _copyTagsToVolumes;
        private string _dailyAutomaticBackupStartTime;
        private OpenZFSDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _endpointIpAddressRange;
        private string _endpointIpv6AddressRange;
        private string _preferredSubnetId;
        private OpenZFSReadCacheConfiguration _readCacheConfiguration;
        private OpenZFSCreateRootVolumeConfiguration _rootVolumeConfiguration;
        private List<string> _routeTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

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
        /// Gets and sets the property CopyTagsToBackups. 
        /// <para>
        /// A Boolean value indicating whether tags for the file system should be copied to backups.
        /// This value defaults to <c>false</c>. If it's set to <c>true</c>, all tags for the
        /// file system are copied to all automatic and user-initiated backups where the user
        /// doesn't specify tags. If this value is <c>true</c>, and you specify one or more tags,
        /// only the specified tags are copied to backups. If you specify one or more tags when
        /// creating a user-initiated backup, no tags are copied from the file system, regardless
        /// of this value.
        /// </para>
        /// </summary>
        public bool? CopyTagsToBackups
        {
            get { return this._copyTagsToBackups; }
            set { this._copyTagsToBackups = value; }
        }

        // Check to see if CopyTagsToBackups property is set
        internal bool IsSetCopyTagsToBackups()
        {
            return this._copyTagsToBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToVolumes. 
        /// <para>
        /// A Boolean value indicating whether tags for the file system should be copied to volumes.
        /// This value defaults to <c>false</c>. If it's set to <c>true</c>, all tags for the
        /// file system are copied to volumes where the user doesn't specify tags. If this value
        /// is <c>true</c>, and you specify one or more tags, only the specified tags are copied
        /// to volumes. If you specify one or more tags when creating the volume, no tags are
        /// copied from the file system, regardless of this value.
        /// </para>
        /// </summary>
        public bool? CopyTagsToVolumes
        {
            get { return this._copyTagsToVolumes; }
            set { this._copyTagsToVolumes = value; }
        }

        // Check to see if CopyTagsToVolumes property is set
        internal bool IsSetCopyTagsToVolumes()
        {
            return this._copyTagsToVolumes.HasValue; 
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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the file system deployment type. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MULTI_AZ_1</c>- Creates file systems with high availability and durability by
        /// replicating your data and supporting failover across multiple Availability Zones in
        /// the same Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_HA_2</c>- Creates file systems with high availability and throughput
        /// capacities of 160 - 10,240 MB/s using an NVMe L2ARC cache by deploying a primary and
        /// standby file system within the same Availability Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_HA_1</c>- Creates file systems with high availability and throughput
        /// capacities of 64 - 4,096 MB/s by deploying a primary and standby file system within
        /// the same Availability Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_2</c>- Creates file systems with throughput capacities of 160 - 10,240
        /// MB/s using an NVMe L2ARC cache that automatically recover within a single Availability
        /// Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_1</c>- Creates file systems with throughput capacities of 64 - 4,096
        /// MBs that automatically recover within a single Availability Zone.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of which Amazon Web Services Regions each deployment type is available
        /// in, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/availability-durability.html#available-aws-regions">Deployment
        /// type availability</a>. For more information on the differences in performance between
        /// deployment types, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance.html#zfs-fs-performance">File
        /// system performance</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenZFSDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration.
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
        /// Gets and sets the property EndpointIpAddressRange. 
        /// <para>
        /// (Multi-AZ only) Specifies the IPv4 address range in which the endpoints to access
        /// your file system will be created. By default in the Amazon FSx API and Amazon FSx
        /// console, Amazon FSx selects an available /28 IP address range for you from one of
        /// the VPC's CIDR ranges. You can have overlapping endpoint IP addresses for file systems
        /// deployed in the same VPC/route tables, as long as they don't overlap with any subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=17)]
        public string EndpointIpAddressRange
        {
            get { return this._endpointIpAddressRange; }
            set { this._endpointIpAddressRange = value; }
        }

        // Check to see if EndpointIpAddressRange property is set
        internal bool IsSetEndpointIpAddressRange()
        {
            return this._endpointIpAddressRange != null;
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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// Required when <c>DeploymentType</c> is set to <c>MULTI_AZ_1</c>. This specifies the
        /// subnet in which you want the preferred file server to be located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=24)]
        public string PreferredSubnetId
        {
            get { return this._preferredSubnetId; }
            set { this._preferredSubnetId = value; }
        }

        // Check to see if PreferredSubnetId property is set
        internal bool IsSetPreferredSubnetId()
        {
            return this._preferredSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property ReadCacheConfiguration. 
        /// <para>
        ///  Specifies the optional provisioned SSD read cache on file systems that use the Intelligent-Tiering
        /// storage class. 
        /// </para>
        /// </summary>
        public OpenZFSReadCacheConfiguration ReadCacheConfiguration
        {
            get { return this._readCacheConfiguration; }
            set { this._readCacheConfiguration = value; }
        }

        // Check to see if ReadCacheConfiguration property is set
        internal bool IsSetReadCacheConfiguration()
        {
            return this._readCacheConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RootVolumeConfiguration. 
        /// <para>
        /// The configuration Amazon FSx uses when creating the root value of the Amazon FSx for
        /// OpenZFS file system. All volumes are children of the root volume. 
        /// </para>
        /// </summary>
        public OpenZFSCreateRootVolumeConfiguration RootVolumeConfiguration
        {
            get { return this._rootVolumeConfiguration; }
            set { this._rootVolumeConfiguration = value; }
        }

        // Check to see if RootVolumeConfiguration property is set
        internal bool IsSetRootVolumeConfiguration()
        {
            return this._rootVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Multi-AZ only) Specifies the route tables in which Amazon FSx creates the rules for
        /// routing traffic to the correct file server. You should specify all virtual private
        /// cloud (VPC) route tables associated with the subnets in which your clients are located.
        /// By default, Amazon FSx selects your VPC's default route table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && (this._routeTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Specifies the throughput of an Amazon FSx for OpenZFS file system, measured in megabytes
        /// per second (MBps). Valid values depend on the <c>DeploymentType</c> that you choose,
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>MULTI_AZ_1</c> and <c>SINGLE_AZ_2</c>, valid values are 160, 320, 640, 1280,
        /// 2560, 3840, 5120, 7680, or 10240 MBps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_1</c>, valid values are 64, 128, 256, 512, 1024, 2048, 3072, or 4096
        /// MBps.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You pay for additional throughput capacity that you provision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=100000)]
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